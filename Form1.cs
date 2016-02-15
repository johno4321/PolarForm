using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            var p = new Pen(Color.Black, 2.0f);
            
            g.DrawEllipse(p, 0.0f, 0.0f, pictureBox1.Width, pictureBox1.Height);

            g.DrawLine(p, new Point(0, pictureBox1.Height / 2), new Point(pictureBox1.Width, pictureBox1.Height / 2));
            g.DrawLine(p, new Point(pictureBox1.Width / 2, 0), new Point(pictureBox1.Width / 2, pictureBox1.Height));
            var tanVal = (float) (1.0/3.0);

            var angle = InverseTan(tanVal);
            angle *= -1;

            var r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            g.DrawPie(p, r, 0.0f, angle);

            g.Dispose();
        }

        private float InverseTan(float val)
        {
            return (float)(Math.Atan(val)*180/Math.PI);
        }
    }
}
