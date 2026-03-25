using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoluzakovaImplementace_SimulaceEkosystemu
{
    public partial class FormMain
    {
        Dictionary<Type, Color> entityColors = new Dictionary<Type, Color>()
        {
            { typeof(Plant),     Color.FromArgb(80, 180, 100) },
            { typeof(Herbivore), Color.FromArgb(70, 120, 210) },
            { typeof(Carnivore), Color.FromArgb(210, 70, 70)  },
        };
        Dictionary<Type, string> entityEmojis = new Dictionary<Type, string>()
        {
            { typeof(Plant),     "🌿" },
            { typeof(Herbivore), "🐇" },
            { typeof(Carnivore), "🦊" },
        };

        void ApplyDarkTheme(Control control)
        {
            //all colors suggested by AI
            control.BackColor = Color.FromArgb(30, 30, 30);
            control.ForeColor = Color.FromArgb(220, 220, 220);

            foreach (Control c in control.Controls)
            {
                c.BackColor = Color.FromArgb(45, 45, 48);
                c.ForeColor = Color.FromArgb(220, 220, 220);

                switch (c)
                {
                    case Label label:
                        label.BackColor = this.BackColor;
                        break;
                    case Button button:
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                        break;
                }
            }
        }
        void OverrideDarkTheme()
        {
            btnNextDay.BackColor = Color.LimeGreen;
            btnRestart.ForeColor = Color.Gray;

            panelPlant.BackColor = entityColors[typeof(Plant)];
            panelHerbivore.BackColor = entityColors[typeof(Herbivore)];
            panelCarnivore.BackColor = entityColors[typeof(Carnivore)];
            panelEmpty.BackColor = Color.Gray;

            lblPlantCount.ForeColor = entityColors[typeof(Plant)];
            lblHerbivoreCount.ForeColor = entityColors[typeof(Herbivore)];
            lblCarnivoreCount.ForeColor = entityColors[typeof(Carnivore)];

            panelMapRender.BackColor = Color.Transparent;
        }

        void RenderMap(Graphics g)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Entity? entity = map[x, y];
                    Color color = entity == null ?
                        Color.Gray : // empty space
                        entityColors[entity.GetType()];

                    g.FillRectangle(new SolidBrush(color), 10 * x, 10 * y, 10, 10);
                }
            }

            g.DrawRectangle(Pens.Black, 0, 0, 10 * map.GetLength(0), 10 * map.GetLength(1));
        }
        void panelMapRender_Paint(object sender, PaintEventArgs e)
        {
            RenderMap(e.Graphics);
        }
    }
}
