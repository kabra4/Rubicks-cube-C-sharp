using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubicks_Cube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Cube
        {
            White,
            Red,
            Yellow,
            Orange,
            Green,
            Blue
        }

        private Cube[,] sides = new Cube[6, 9];

        private void NewCube()
        {
            var temp = 0;
            foreach (Cube color in Enum.GetValues(typeof(Cube)))
            {
                for (int i = 0; i < 9; i++)
                {
                    sides[temp, i] = color;
                    temp++;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var c = 200/Math.Cos(0.523599);
            var g = e.Graphics;

            // Painting lines
            for (int i = 0; i < 4; i++) 
            {
                g.DrawLine(Pens.Black, 100, (float)(163 + c / 3 * i), 300, (float)(281 + c / 3 * i));
                g.DrawLine(Pens.Black, 300, (float)(281 + c / 3 * i), 500, (float)(165 + c / 3 * i));
                g.DrawLine(Pens.Black, 300 + 200 / 3 * i, (float)(281 - c / 6 * i), 300 + 200 / 3 * i, (float)(281 - c / 6 * i + c));
                g.DrawLine(Pens.Black, 300 - 200 / 3 * i, (float)(281 - c / 6 * i), 300 - 200 / 3 * i, (float)(281 - c / 6 * i + c));

            }
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(Pens.Black, 300 - 200 / 3 * i, (float)(50 + c / 6 * i), 500 - 200 / 3 * i, (float)(165 + c / 6 * i));
                g.DrawLine(Pens.Black, 300 + 200 / 3 * i, (float)(50 + c / 6 * i), 100 + 200 / 3 * i, (float)(165 + c / 6 * i));
            }
        }
    }
}
