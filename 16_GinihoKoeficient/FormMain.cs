using System;
using System.Linq;
namespace _16_GinihoKoeficient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(OnDragEnter);
            this.DragDrop += new DragEventHandler(OnDragDrop);
        }
        double[] serazenePrijmy;
        double[] kumulativniPodily;
        double plochaLorenz;

        double[] SeradPrijmy(double[] prijmy)
        {
            Array.Sort(prijmy);
            return prijmy;
        }
        double[] KumulativniPodily(double[] serazenePrijmy)
        {
            int pocetObyvatel = serazenePrijmy.Length;
            double celkovePrijmy = serazenePrijmy.Sum();

            double[] kumulativniPodily = new double[pocetObyvatel];

            for (int i = 0; i < pocetObyvatel; i++)
            {
                kumulativniPodily[i] = serazenePrijmy[..(i + 1)].Sum() / celkovePrijmy;
            }

            listBoxKumu.DataSource = kumulativniPodily;
            return kumulativniPodily;
        }
        double PlochaLorenz(double[] kumulativniPodily)
        {
            int pocetOsob = kumulativniPodily.Length;
            double plocha = 0;
            for (int i = 1; i < pocetOsob; i++)
            {
                double x1 = (double)(i - 1) / pocetOsob;
                double y1 = kumulativniPodily[i - 1];

                double x2 = (double)i / pocetOsob;
                double y2 = kumulativniPodily[i];

                plocha += (x2 - x1) * (y1 + y2) / 2;
            }
            lblPlocha.Text = plocha.ToString();
            return plocha;
        }
        double VypocitejGini(double[] prijmy)
        {
            serazenePrijmy = SeradPrijmy(prijmy);
            kumulativniPodily = KumulativniPodily(serazenePrijmy);
            plochaLorenz = PlochaLorenz(kumulativniPodily);
            return 1 - (2 * plochaLorenz);
        }
        double Median(double[] serazenePrijmy) => serazenePrijmy.Length % 2 == 0
                ? ((serazenePrijmy.Length / 2 - 1) + (serazenePrijmy.Length / 2)) / 2
                : serazenePrijmy[serazenePrijmy.Length / 2];

        void OnDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        void OnDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!file.EndsWith(".txt")) continue;

                LoadFileSorted(file);
            }
        }
        void LoadFileSorted(string filePath)
        {
            List<double> prijmy = this.serazenePrijmy?.ToList()
                ?? new List<double>();

            foreach (string line in File.ReadLines(filePath))
            {
                if (!double.TryParse(line, out double value)) continue; // ignores non-numbers

                prijmy.Add(value);
            }
            serazenePrijmy = SeradPrijmy(prijmy.ToArray());
            listBoxValues.DataSource = serazenePrijmy;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (listBoxValues.Items.Count == 0) return;

            double gini = VypocitejGini(serazenePrijmy);
            MessageBox.Show(gini.ToString());

            VykresliKrivku();
        }

        void VykresliKrivku() => panel1.Refresh();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int pocetOsob = kumulativniPodily?.Length
                ?? 0;
            if (pocetOsob < 2) return;

            Point[] points = new Point[pocetOsob];
            for(int i = 0; i < pocetOsob; i++)
            {
                int x = Convert.ToInt32(100 * (double)i / pocetOsob);
                int y = Convert.ToInt32(100 * kumulativniPodily[i]);
                points[i] = new Point(x, panel1.Height - y);
            }
            g.DrawLines(Pens.Black, points);

        }

        int Map(double value, double fromMin, double fromMax, double toMin, double toMax) // claude code
            => Convert.ToInt32((value - fromMin) / (fromMax - fromMin) * (toMax - toMin) + toMin);
    }
}