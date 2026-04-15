namespace _13_GenerovaniMapy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<char, Brush> GetTerrainColor = new Dictionary<char, Brush>
        {
            {'V', Brushes.Aqua},
            {'P', Brushes.Yellow},
            {'T', Brushes.DarkGreen}
        };

        char[,] map;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                map = GenerateMap((int)numWidth.Value, (int)numHeight.Value,
                    (double)numWater.Value, (double)numGrass.Value);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            PrintMap(map, lblMapOutput);
            PrintMapStats(map, lblDetails);
        }
        public char[,] GenerateMap(int width, int height, double waterP, double grassP)
        {
            if (waterP + grassP > 1) { throw new ArgumentException("Sum of probabilities can't exceed 1"); }

            Random rng = new Random();
            waterP = Math.Clamp(waterP, 0, 1);
            char[,] map = new char[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double randomNumber = rng.NextDouble();

                    map[i, j] = randomNumber < waterP ? 'V' // voda
                        : randomNumber < waterP + grassP ? 'T' // tráva
                        : 'P'; // písek
                }
            }

            return map;
        }
        private void PrintMap(char[,] map, Label label)
        {
            label.Text = String.Empty;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    label.Text += map[i, j].ToString();
                }
                label.Text += Environment.NewLine;
            }

            Refresh();
        }
        private void PrintMapStats(char[,] map, Label label)
        {
            int waterCount = map.Cast<char>()
                .Where(c => c == 'V')
                .Count();
            int sandCount = map.Cast<char>()
                .Where(c => c == 'P')
                .Count();
            int grassCount = map.Cast<char>()
                .Where(c => c == 'T')
                .Count();

            int max = Math.Max(Math.Max(waterCount, sandCount), grassCount);
            string mapType = max == waterCount ? "Vodní"
                : max == sandCount ? "Píseèná"
                : "Travnatá"; //zadání nespicifikovalo jak se má nazývat balancovaná mapa

            label.Text = $"{mapType} mapa\r\n" +
                $"Voda: {waterCount}\r\n" +
                $"Písek: {sandCount}\r\n" +
                $"Tráva: {grassCount}";
        }

        private void panelMapRender_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (map == null) { return; }
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    g.FillRectangle(GetTerrainColor[map[y, x]], x * 10, y * 10, 10, 10);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        sw.Write(map[i, j]);
                    }
                    sw.Write(Environment.NewLine);
                }
            }
        }
    }
}