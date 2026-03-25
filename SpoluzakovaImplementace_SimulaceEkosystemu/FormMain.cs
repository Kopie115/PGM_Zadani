using System.Linq;

namespace SpoluzakovaImplementace_SimulaceEkosystemu
{
    public partial class FormMain : Form
    {
        Random random = new Random();


        public FormMain()
        {
            InitializeComponent();
            ApplyDarkTheme(this);
            OverrideDarkTheme();

            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            InitEcosystem();
            update();
        }

        void InitEcosystem()
        {
            decimal maxMapWidth = Math.Floor((decimal)panelMapRender.Width / 10);
            decimal maxMapHeight = Math.Floor((decimal)panelMapRender.Height / 10);
            InitDialog dialog = new InitDialog(maxMapWidth, maxMapHeight);

            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    day = 0;
                    map = CreateMap(
                        dialog.MapWidth,
                        dialog.MapHeight,
                        dialog.Plants,
                        dialog.Herbivores,
                        dialog.Carnivores
                    );
                }
                else { this.Close(); }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                InitEcosystem();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            try //hodi to exception kdyz vypnu form
            {
                this.Hide();
                InitEcosystem();
                update();
                this.Show();
            }
            catch { }
        }
        private void btnNextDay_Click(object sender, EventArgs e) => NextDay();


        private void checkBoxAutoNextDay_CheckedChanged(object sender, EventArgs e)
            => timerAutoNextDay.Enabled = checkBoxAutoNextDay.Checked;
        private void timerAutoNextDay_Tick(object sender, EventArgs e) => NextDay();
        private void sliderAutoNextDay_ValueChanged(object sender, EventArgs e)
            => timerAutoNextDay.Interval = sliderAutoNextDay.Value;
        void update()
        {
            lblDayCount.Text = day.ToString();
            lblPlantCount.Text = $"{plants.Count} {entityEmojis[typeof(Plant)]} {(plants.Count == 0 ? "❌🥀❌" : "")}";
            lblHerbivoreCount.Text = $"{herbivores.Count} {entityEmojis[typeof(Herbivore)]} {(herbivores.Count == 0 ? "❌💀❌" : "")}";
            lblCarnivoreCount.Text = $"{carnivores.Count} {entityEmojis[typeof(Carnivore)]} {(carnivores.Count == 0 ? "❌💀❌" : "")}";
            panelMapRender.Invalidate();
            panelMapRender.Refresh();
        }
    }
}
