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
            Color.Lime
        };
        private bool shuffled;
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int height = 125;
            int width;
            Pen blackPen = new Pen(Color.Black, 1);
            SolidBrush brush;
            for (int side = 0; side < 6; side++)
            {
                if (side > 3)
                {
                    height = side == 4 ? 0 : 250;
                    width = 125;
                }
                else width = side * 125;
                for (int i = 0; i < 3; i++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        brush = new SolidBrush(cells[side, i, l]);
                        e.Graphics.FillRectangle(brush, width + l * 40, height + i * 40, 40, 40);
                        e.Graphics.DrawRectangle(blackPen, width + l * 40, height + i * 40, 40, 40);
                    }
                }
            }
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
                    points[0] = new Point(275 + l * x, 300 + y * (i * 2 - l));
                    points[1] = new Point(points[0].X + x, points[0].Y - y);
                    points[2] = new Point(points[1].X, points[1].Y + y * 2);
                    points[3] = new Point(points[0].X, points[0].Y + y * 2);
                    cellCol = cells[2, i, l];
                    PaintCell(e, points, cellCol);

                    // Side x
                    points[0] = new Point(62 + l * x, 177 + y * (i * 2 + l));
                    points[1] = new Point(points[0].X + x, points[0].Y + y);
                    points[2] = new Point(points[1].X, points[1].Y + y * 2);
                    points[3] = new Point(points[0].X, points[0].Y + y * 2);
                    cellCol = cells[1, i, l];
                    PaintCell(e, points, cellCol);

                    // Side z
                    points[0] = new Point(275 + (l - i) * x, 54 + y * (i + l));
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
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Brushing polygon
            FillMode newFillMode = FillMode.Winding;
            SolidBrush brush = new SolidBrush(color);

            // Draw polygon to screen.
            e.Graphics.FillPolygon(brush, points, newFillMode);

            // Drawing lines
            Pen blackPen = new Pen(Color.Black, 1);
            e.Graphics.DrawPolygon(blackPen, points);
        }
        private void Valid()
        {
            panel1.Invalidate();
            panel2.Invalidate();
            CubeProgress();
        }

        // Rotating Cube sides
        private void Z_Rotate(int row, bool clockwise) // rotating cube along z-axis
        {
            Color[,,] colorsCopy = new Color[6, 3, 3];
            Array.Copy(cells, colorsCopy, cells.Length);
            int b;
            for (int a = 0; a < 4; a++)
            {
                if (!clockwise) b = (a == 3) ? 0 : a + 1;
                else b = (a == 0) ? 3 : a - 1;
                for (int l = 0; l < 3; l++)
                {
                    cells[b, row, l] = colorsCopy[a, row, l];
                }
            }
            if (row != 1)
            {
                if (row != 0) clockwise = !clockwise;
                SideRotate(4 + row / 2, clockwise);
            }
        }
        private void Y_Rotate(int column, bool clockwise)
        {
            Color[,,] colorsCopy = new Color[6, 3, 3];
            Array.Copy(cells, colorsCopy, cells.Length);
            int[] sideOrder = { 1, 4, 3, 5 };
            int b;
            for (int a = 0; a < 4; a++)
            {
                if (clockwise) b = (a == 3) ? 1 : sideOrder[a + 1];
                else b = (a == 0) ? 5 : sideOrder[a - 1];
                for (int l = 0; l < 3; l++)
                {
                    if (b == 3) cells[b, 2 - l, column] = colorsCopy[sideOrder[a], l, 2 - column];
                    else if (a == 2) cells[b, l, 2 - column] = colorsCopy[sideOrder[a], 2 - l, column];
                    else cells[b, l, 2 - column] = colorsCopy[sideOrder[a], l, 2 - column];
                }
            }
            if (column != 1)
            {
                if (column == 2) clockwise = !clockwise;
                SideRotate(2 - column, clockwise);
            }
        }
        private void X_Rotate(int column, bool clockwise)
        {
            Color[,,] colorsCopy = new Color[6, 3, 3];
            Array.Copy(cells, colorsCopy, cells.Length);
            int[] sideOrder = { 0, 4, 2, 5 };
            int b, rowb, colb, rowa, cola;
            for (int a = 0; a < 4; a++) {
                if (clockwise) b = (a == 3) ? 0 : sideOrder[a + 1];
                else b = (a == 0) ? 5 : sideOrder[a - 1];
                for (int l = 0; l < 3; l++)
                {
                    if (b > 3)
                    {
                        rowb = b == 4 ? 2 - column : column;
                        colb = b == 4 ? l : 2 - l;
                        rowa = a == 0 ? 2 - l : l;
                        cola = a == 0 ? 2 - column : column;
                        cells[b, rowb, colb] = colorsCopy[sideOrder[a], rowa, cola];
                    } else {
                        rowb = b == 0 ? 2 - l : l;
                        colb = b == 0 ? 2 - column : column;
                        rowa = a == 1 ? 2 - column : column;
                        cola = a == 1 ? l : 2 - l;
                        cells[b, rowb, colb] = colorsCopy[sideOrder[a], rowa, cola];
                    }
                }
            }
            if (column != 1)
            {
                if (column == 2) clockwise = !clockwise;
                SideRotate(1 + column, clockwise);
            }
        }

        private void SideRotate(int side, bool clockwise)
        {
            Color[,,] colorsCopy = new Color[6, 3, 3];
            Array.Copy(cells, colorsCopy, cells.Length);
            for (int i = 0; i < 3; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    if (clockwise) cells[side, i, l] = colorsCopy[side, 2 - l, i];
                    else cells[side, i, l] = colorsCopy[side, l, 2 - i];
                }
            }
        }

        // "New" button
        private void button1_Click(object sender, EventArgs e)
        {
            shuffled = false;
            NewCube();
            Valid();
        }

        // Shuffle button
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int axis, row;
            bool clockwise;
            for (int i = 0; i < 25; i++)
            {
                axis = rnd.Next(3);
                row = rnd.Next(3);
                clockwise = rnd.Next(2) > 0;
                if (axis == 0) X_Rotate(row, clockwise);
                else if (axis == 1) Y_Rotate(row, clockwise);
                else Z_Rotate(row, clockwise);
            }
            Valid();
            shuffled = true;
        }

        private void zRotate01_Click(object sender, EventArgs e)
        {
            Z_Rotate(0, true);
            Valid();
        }

        private void zRotate11_Click(object sender, EventArgs e)
        {
            Z_Rotate(1, true);
            Valid();
        }

        private void zRotate21_Click(object sender, EventArgs e)
        {
            Z_Rotate(2, true);
            Valid();
        }

        private void zRotate00_Click(object sender, EventArgs e)
        {
            Z_Rotate(0, false);
            Valid();
        }

        private void zRotate10_Click(object sender, EventArgs e)
        {
            Z_Rotate(1, false);
            Valid();
        }

        private void zRotate20_Click(object sender, EventArgs e)
        {
            Z_Rotate(2, false);
            Valid();
        }

        private void yRotate1_Click(object sender, EventArgs e)
        {
            Y_Rotate(0, true);
            Valid();
        }

        private void yRotate11_Click(object sender, EventArgs e)
        {
            Y_Rotate(1, true);
            Valid();
        }

        private void yRotate21_Click(object sender, EventArgs e)
        {
            Y_Rotate(2, true);
            Valid();
        }

        private void yRotate00_Click(object sender, EventArgs e)
        {
            Y_Rotate(0, false);
            Valid();
        }

        private void yRotate10_Click(object sender, EventArgs e)
        {
            Y_Rotate(1, false);
            Valid();
        }

        private void yRotate20_Click(object sender, EventArgs e)
        {
            Y_Rotate(2, false);
            Valid();
        }

        private void xRotate01_Click(object sender, EventArgs e)
        {
            X_Rotate(0, true);
            Valid();
        }

        private void xRotate11_Click(object sender, EventArgs e)
        {
            X_Rotate(1, true);
            Valid();
        }

        private void xRotate21_Click(object sender, EventArgs e)
        {
            X_Rotate(2, true);
            Valid();
        }

        private void xRotate00_Click(object sender, EventArgs e)
        {
            X_Rotate(0, false);
            Valid();
        }

        private void xRotate10_Click(object sender, EventArgs e)
        {
            X_Rotate(1, false);
            Valid();
        }

        private void xRotate20_Click(object sender, EventArgs e)
        {
            X_Rotate(2, false);
            Valid();
        }

        private void xRotateAll_Click(object sender, EventArgs e)
        {
            X_Rotate(0, true);
            X_Rotate(1, true);
            X_Rotate(2, true);
            Valid();
        }

        private void yRotateAll_Click(object sender, EventArgs e)
        {
            Y_Rotate(0, true);
            Y_Rotate(1, true);
            Y_Rotate(2, true);
            Valid();
        }

        private void zRotateAll_Click(object sender, EventArgs e)
        {
            Z_Rotate(0, true);
            Z_Rotate(1, true);
            Z_Rotate(2, true);
            Valid();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CubeProgress()
        {
            int[] nColors = new int[6];
            float[] avgMaxCol = new float[6];
            for (int side = 0; side < 6; side++)
            {
                // making arrays default
                for (int i = 0; i < 6; i++)
                {
                    nColors[i] = 0;
                }
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        for (int color = 0; color < 6; color++)
                        {
                            if (cells[side, row, col] == colors[color]) nColors[color]++;
                        }
                    }
                }
                avgMaxCol[side] = (float)nColors.Max() / 9;
            }
            float averag = avgMaxCol.Average();
            if (averag < 0.3) averag = (float)0.3;
            progressBar1.Value = (int) (averag * 100);

            if (progressBar1.Value == 100 && shuffled)
            {
                MessageBox.Show("Congrats!\nYou have solved all sides");
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
