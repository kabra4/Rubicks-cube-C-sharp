using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private Color[,] cells = new Color[6, 9];
        private Color[] colors = {
            Color.White,
            Color.Red,
            Color.Yellow,
            Color.Orange,
            Color.Blue,
            Color.Green
        };

        private void NewCube()
        {
            for (int s = 0; s < 6; s++)
            {
                for (int i = 0; i < 9; i++)
                {
                    cells[s, i] = colors[s];
                    
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            NewCube();
            PaintCube(e);
            

            // Painting lines
            
        }

        private void PaintCube(PaintEventArgs e)
        {
            var c = 200/Math.Cos(0.523599);
            int x = 200/3;
            var y = c / 3;
            for (float i = 0; i < 3; i++)
            {
                for (float l = 0; l < 3; l++)
                {
                    // Side y
                    Point[] cellPoints =
                    {
                        new Point((int)(300 + l * x), (int)(300 + y * (i - l/2))),
                        new Point((int)(300 + (l + 1) * x), (int)(300 + i*y - (l+1)/2*y)),
                        new Point((int)(300 + (l+1)*x), (int)(300 + (i+1)*y - (l+1)*y/2)),
                        new Point((int)(300 + l*x), (int)(300 + (i+1)*y - l*y/2))
                    };
                    Color cellColor = cells[2, (int)(i + l * 3)];
                    PaintCell(e, cellPoints, cellColor);

                    // Side x
                    cellPoints[0] = new Point((int)(300 - (i + 1) * x), (int)(300 + l * y - (i + 1) / 2 * y));
                    cellPoints[1] = new Point((int)(300 - i * x), (int)(300 + l * y - i * y / 2));
                    cellPoints[2] = new Point((int)(300 - i * x), (int)(300 + (l + 1) * y - i * y / 2));
                    cellPoints[3] = new Point((int)(300 - (i + 1) * x), (int)(300 + (l + 1) * y - (i + 1) * y / 2));
                    cellColor = cells[1, (int)(2 - i + l * 3)];
                    PaintCell(e, cellPoints, cellColor);

                    // Side z
                    cellPoints[0] = new Point((int)(300 - (i - l) * x), (int)(300 - (i + l + 2) / 2 * y));
                    cellPoints[1] = new Point((int)(300 - (i - l - 1) * x), (int)(300 - (i + l + 1) / 2 * y));
                    cellPoints[2] = new Point((int)(300 - (i - l) * x), (int)(300 - (i + l) / 2 * y));
                    cellPoints[3] = new Point((int)(300 - (i - l + 1) * x), (int)(300 - (i + l + 1) / 2 * y));
                    cellColor = cells[4, (int)(2 - i + (2 - l) * 3)];
                    PaintCell(e, cellPoints, cellColor);
                }
            }
        }

        private void PaintCell(PaintEventArgs e, Point[] points, Color color)
        {
            // Drawing lines
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen blackPen = new Pen(Color.Black, 1);
            e.Graphics.DrawPolygon(blackPen, points);

            // Brushing polygon
            int temp = points[0].X == points[2].X ? 1 : 0;
            points[0] = new Point(points[0].X + temp, points[0].Y + 1);
            points[0] = new Point(points[0].X -1, points[0].Y + temp);
            points[0] = new Point(points[0].X - temp, points[0].Y - 1);
            points[0] = new Point(points[0].X + 1, points[0].Y - temp);

            FillMode newFillMode = FillMode.Winding;

            // Draw polygon to screen.
            e.Graphics.FillPolygon(new SolidBrush(color), points, newFillMode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
