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
            NewCube();
        }

        // Creating Cube
        private Color[,,] cells = new Color[6, 3, 3];
        private Color[] colors = {
            Color.White,
            Color.Red,
            Color.Yellow,
            Color.Orange,
            Color.Blue,
            Color.Green
        };
        private void NewCube() // Sets all colors of cube to default
        {
            for (int s = 0; s < 6; s++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        cells[s, i, l] = colors[s];
                    }
                }
            }
        }


        // All about drawing
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintCube(e);
        }
        private void PaintCube(PaintEventArgs e)
        {
            int y = (int)Math.Round(213 / Math.Cos(0.523599) / 6);
            int x = 213 / 3;
            Point[] points = new Point[4];
            Color cellCol;
            for (int i = 0; i < 3; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    // Side y
                    points[0] = new Point(213 + l * x, 246 + y * (i * 2 - l));
                    points[1] = new Point(points[0].X + x, points[0].Y - y);
                    points[2] = new Point(points[1].X, points[1].Y + y * 2);
                    points[3] = new Point(points[0].X, points[0].Y + y * 2);
                    cellCol = cells[2, i, l];
                    PaintCell(e, points, cellCol);

                    // Side x
                    points[0] = new Point(l * x, 123 + y * (i * 2 + l));
                    points[1] = new Point(points[0].X + x, points[0].Y + y);
                    points[2] = new Point(points[1].X, points[1].Y + y * 2);
                    points[3] = new Point(points[0].X, points[0].Y + y * 2);
                    cellCol = cells[1, i, l];
                    PaintCell(e, points, cellCol);

                    // Side z
                    points[0] = new Point(213 + (l - i) * x, y * (i + l));
                    points[1] = new Point(points[0].X + x, points[0].Y + y);
                    points[2] = new Point(points[0].X, points[0].Y + y * 2);
                    points[3] = new Point(points[0].X - x, points[1].Y);
                    cellCol = cells[4, i, l];
                    PaintCell(e, points, cellCol);
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
            SolidBrush brush = new SolidBrush(color);

            // Draw polygon to screen.
            e.Graphics.FillPolygon(brush, points, newFillMode);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int height = 120;
            int width;
            Pen blackPen = new Pen(Color.Black, 1);
            for (int side = 0; side < 6; side++)
            {
                if (side > 3)
                {
                    height = side == 4 ? 0 : 240;
                    width = 120;
                }
                else width = side * 120;
                for (int i = 0; i < 3; i++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        e.Graphics.DrawRectangle(blackPen, width + l * 40, height + i * 40, 40, 40);
                        SolidBrush brush = new SolidBrush(cells[side, i, l]);
                        e.Graphics.FillRectangle(brush, width + l * 40 + 1, height + i * 40 + 1, 39, 39);
                    }
                }
            }
        }

        // Rotating Cube sides

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void z1_Click(object sender, EventArgs e)
        {
            Z_Rotate(0, true);
        }


        private void Z_Rotate(int row, bool clockwise)
        {
            Color[,,] colorsCopy = new Color[6, 3, 3];
            Array.Copy(cells, colorsCopy, cells.Length);
            int b;
            for (int a = 0; a < 4; a++)
            {
                if (!clockwise) b = a == 3 ? 0 : a + 1;
                else b = a == 0 ? 3 : a - 1;
                for (int l = 0; l < 3; l++)
                {
                    cells[b, row, l] = colorsCopy[a, row, l];
                }
            }

            if (row != 1)
            {
                int side = row == 0 ? 4 : 5;
                SideRotate(side, clockwise);
            }
            panel1.Invalidate();
            panel2.Invalidate();

        }
        private void Y_Rotate(int column, bool clockwise)
        {
            Color[,,] colorsCopy = new Color[6, 3, 3];
            Array.Copy(cells, colorsCopy, cells.Length);
            int[] sideOrder = { 1, 4, 3, 5 };
            int b;
            for (int a = 0; a < 4; a++)
            {
                if (clockwise) b = (a == 3) ? sideOrder[0] : sideOrder[a + 1];
                else b = (a == 0) ? sideOrder[3] : sideOrder[a - 1];
                for (int l = 0; l < 3; l++)
                {
                    cells[b, l, column] = colorsCopy[sideOrder[a], l, column];
                }
            }

            if (column != 1)
            {

                if (column == 0) clockwise = !clockwise;
                SideRotate(2 - column, clockwise);
            }
            panel1.Invalidate();
            panel2.Invalidate();
        }

        private void SideRotate(int side, bool clockwise)
        {
            Color[,,] colorsCopy = new Color[6, 3, 3];
            Array.Copy(cells, colorsCopy, cells.Length);

            if (clockwise)
            {
                cells[side, 0, 0] = colorsCopy[side, 2, 0];
                cells[side, 0, 1] = colorsCopy[side, 1, 0];
                cells[side, 0, 2] = colorsCopy[side, 0, 0];
                cells[side, 1, 0] = colorsCopy[side, 2, 1];
                cells[side, 1, 2] = colorsCopy[side, 0, 1];
                cells[side, 2, 0] = colorsCopy[side, 2, 2];
                cells[side, 2, 1] = colorsCopy[side, 1, 2];
                cells[side, 2, 2] = colorsCopy[side, 0, 2];
            } else
            {
                cells[side, 0, 0] = colorsCopy[side, 2, 0];
                cells[side, 0, 1] = colorsCopy[side, 1, 0];
                cells[side, 0, 2] = colorsCopy[side, 0, 0];
                cells[side, 1, 0] = colorsCopy[side, 2, 1];
                cells[side, 1, 2] = colorsCopy[side, 0, 1];
                cells[side, 2, 0] = colorsCopy[side, 2, 2];
                cells[side, 2, 1] = colorsCopy[side, 1, 2];
                cells[side, 2, 2] = colorsCopy[side, 0, 2];
            }
        }

        private void z2_Click(object sender, EventArgs e)
        {

        }

        private void y1_Click(object sender, EventArgs e)
        {
            Y_Rotate(2, true);
            panel1.Invalidate();
        }

        
    }
}
