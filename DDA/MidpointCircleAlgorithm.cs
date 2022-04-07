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
    public partial class MidpointCircleAlgorithm : Form
    {
        public MidpointCircleAlgorithm()
        {
            InitializeComponent();
            this.Text = "MidpointCircle Algorithm";
            #region Config

            circle.BackColor = Color.Black;
            circle.BorderStyle = BorderStyle.Fixed3D;


            #endregion
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearPBox(circle);

            int x = circle.Width / 2; 
            int y = circle.Height / 2;
            int radius = int.Parse(Radius.Text); // form input

            Circle circpt = new Circle();
            
            int p = 1 - radius;
            circpt.setCoords(0,radius );
            
            circleplotpoints(x, y, circpt);
            while (circpt.getx() < circpt.gety())
            {
                circpt.incrementx();
                if (p < 0)
                {
                    p += 2 * circpt.getx() + 1;
                }
                else
                {
                    circpt.decrementy();
                    p += 2 * (circpt.getx() - circpt.gety()) + 1;
                }
                circleplotpoints(x, y, circpt);
            }

            
            
        }

        // drawing set of points to screen
        private void circleplotpoints(int xcenter, int ycenter,Circle circPt)
        {

            SetPixel(xcenter + circPt.getx(), ycenter + circPt.gety(), Color.LimeGreen);
            SetPixel(xcenter - circPt.getx(), ycenter + circPt.gety(), Color.LimeGreen);
            SetPixel(xcenter + circPt.getx(), ycenter - circPt.gety(), Color.LimeGreen);
            SetPixel(xcenter - circPt.getx(), ycenter - circPt.gety(), Color.LimeGreen);//blue
            SetPixel(xcenter + circPt.gety(), ycenter + circPt.getx(), Color.LimeGreen);
            SetPixel(xcenter - circPt.gety(), ycenter + circPt.getx(), Color.LimeGreen);//yellow
            SetPixel(xcenter + circPt.gety(), ycenter - circPt.getx(), Color.LimeGreen);
            SetPixel(xcenter - circPt.gety(), ycenter - circPt.getx(), Color.LimeGreen);//green

            
        }

        private void clearPBox(PictureBox PBox)
        {
            Graphics g = PBox.CreateGraphics();         
            g.Clear(Color.Black);
        }
       
        private void SetPixel(int cx, int cy, Color c)
        {
           
            int Stroke = 1;
            int DeltaX = int.Parse(xCenter.Text) * -1;
            int DeltaY = int.Parse(yCenter.Text);

            Graphics g = Graphics.FromHwnd(circle.Handle);
            SolidBrush brush = new SolidBrush(c);
            Point dPoint = new Point(cx, (circle.Height - cy));

            //Move Whole circle x & y pos
            dPoint.X = dPoint.X - DeltaX; ; 
            dPoint.Y = dPoint.Y - DeltaY;
            Rectangle rect = new Rectangle(dPoint, new Size(Stroke, Stroke));
            g.FillRectangle(brush, rect);
            g.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Radius_TextChanged(object sender, EventArgs e)
        {

        }

        private void circle_Click(object sender, EventArgs e)
        {

        }

        private void Xdw_Click(object sender, EventArgs e)
        {

        }
    }
}
