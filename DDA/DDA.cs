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
    public partial class DDA : Form
    {
        private Random rnd = new Random(new System.DateTime().Millisecond);
        public DDA()
        {
            InitializeComponent();
            this.Text = "DDA Algorithm";

            bf1.BackColor = Color.Black;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x1 = 0;
            int y1 = 0;

            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);


            if(x1 > bf1.Width ||
                x2 > bf1.Width||
                y1 > bf1.Height ||
                y2 > bf1.Height)
            {
                MessageBox.Show("OutOfBounds input");
                return;
            }

            Point pt1 = new Point(x1, y1);
            Point pt2 = new Point(x2, y2);


            

            string log = "x1: " + x1.ToString() + " y1:" + y1.ToString() +
                "\nx2: " + x2.ToString() + " y2:" + y2.ToString();
            //MessageBox.Show(log);
            DDAlgorithm(pt1, pt2);


        }

        private int round(float a) {
            float f = a + (float)0.5;
            return (int)f; 
        }


        private void clearPBox(PictureBox PBox)
        {
            Graphics g = PBox.CreateGraphics();
            g.Clear(Color.Black);
        }

        private void DDAlgorithm(Point p1,Point p2)
        {

            clearPBox(bf1);
            int steps;
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            float xIncrement, yIncrement, x = p1.X, y = p1.Y;

          
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;


            SetPixel(round(x), round(y), Color.LimeGreen);
            Color randomColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            for ( int k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;

                

                SetPixel(round(x), round(y), randomColor);
            }

        }

        private void SetPixel(int cx, int cy, Color c, int Stroke = 3)
        {
           
            
            int DeltaX = 2;
            int DeltaY = 2;

            Graphics g = Graphics.FromHwnd(bf1.Handle);
            SolidBrush brush = new SolidBrush(c);
            Point dPoint = new Point(cx, (bf1.Height - cy));

            //Move Whole circle x & y pos
            dPoint.X = dPoint.X - DeltaX; ;
            dPoint.Y = dPoint.Y - DeltaY;
            Rectangle rect = new Rectangle(dPoint, new Size(Stroke, Stroke));

            g.FillRectangle(brush, rect);
            g.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bf1_Click(object sender, EventArgs e)
        {

        }

        private void Y1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Y2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bf1_MouseMove(object sender, MouseEventArgs e)
        {
            Point Default = new Point(bf1.Width / 2, bf1.Height / 2);
            Point point = new Point(e.X  , bf1.Height - e.Y  );
            DDAlgorithm(Default, point);

        }
    }
}
