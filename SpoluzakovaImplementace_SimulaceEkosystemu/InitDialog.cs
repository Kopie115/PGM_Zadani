using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpoluzakovaImplementace_SimulaceEkosystemu
{
    public partial class InitDialog : Form
    {
        private decimal maxMapWidth, maxMapHeight;
        public InitDialog(decimal maxMapWidth, decimal maxMapHeight)
        {
            this.maxMapWidth = maxMapWidth;
            this.maxMapHeight = maxMapHeight;
            InitializeComponent();
        }
        public int MapWidth, MapHeight, Plants, Herbivores, Carnivores;

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            if (Plants + Herbivores + Carnivores > MapWidth * MapHeight)
                throw new ArgumentException("Amount of entities cannot exceed the map area");

            MapWidth = (int)numWidth.Value;
            MapHeight = (int)numHeight.Value;
            Plants = (int)numPlants.Value;
            Herbivores = (int)numHerbivores.Value;
            Carnivores = (int)numCarnivores.Value;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitDialog_Load(object sender, EventArgs e)
        {
            numWidth.Maximum = maxMapWidth;
            numHeight.Maximum = maxMapHeight;

            num_ValueChanged(null, null);
            numPlants.Value = (int)(numPlants.Maximum * 0.4m);
            numHerbivores.Value = (int)(numPlants.Maximum * 0.2m);
            numCarnivores.Value = (int)(numPlants.Maximum * 0.05m);
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            foreach (NumericUpDown num in panelEntities.Controls.OfType<NumericUpDown>())
            {
                num.Maximum = Math.Max(0, (numWidth.Value * numHeight.Value)
                    - (num != numPlants ? numPlants.Value : 0)
                    - (num != numHerbivores ? numHerbivores.Value : 0)
                    - (num != numCarnivores ? numCarnivores.Value : 0));

                num.Value = Math.Clamp(num.Value, num.Minimum, num.Maximum);
            }
        }
    }
}
