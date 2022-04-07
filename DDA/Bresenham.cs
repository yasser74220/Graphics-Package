using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPackage
{
    public partial class Bresenham : Form
    {
        public Bresenham()
        {
            InitializeComponent();
            this.Text = "Bresenham Algorithm";

            linePanel.BackColor = Color.Black;

        }

        private void Bresenham_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);

            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);

            

            BresenhamAlgo(x1,y1 ,x2 ,y2);
        }
        public void BresenhamAlgo(int x0, int y0, int xEnd, int yEnd)
        {
            int x, y;
            int Dx = Math.Abs(xEnd - x0);
            int Dy = Math.Abs(yEnd - y0);
            int Dp = (2 * Dy) - Dx;
            int twoDy = 2 * Dy;
            int twoDyMinusDx = 2 * (Dx - Dy);
            if (x0 > xEnd)
            {
                x = xEnd;
                y = yEnd;
                xEnd = x0;

            }
            else
            {
                x = x0;
                y = y0;
            }
            SetPixel(x, y , Color.LimeGreen);
            while (x < xEnd)
            {
                x++;
                if (Dp < 0)
                    Dp += twoDy;
                else
                {
                    y++;
                    Dp += twoDyMinusDx;
                }

                SetPixel(x, y, Color.LimeGreen);




            }
        }
        private void SetPixel(int cx, int cy, Color c, int Stroke = 3)
        {


            int DeltaX = 2;
            int DeltaY = 2;

            Graphics g = Graphics.FromHwnd(linePanel.Handle);
            SolidBrush brush = new SolidBrush(c);
            Point dPoint = new Point(cx, (linePanel.Height - cy));

            //Move Whole circle x & y pos
            dPoint.X = dPoint.X - DeltaX; ;
            dPoint.Y = dPoint.Y - DeltaY;
            Rectangle rect = new Rectangle(dPoint, new Size(Stroke, Stroke));

            g.FillRectangle(brush, rect);
            g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void X1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
