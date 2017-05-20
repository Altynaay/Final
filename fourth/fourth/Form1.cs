using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fourth
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool point = true;
        public int dy;
        public int x, y;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            Timer timer = new Timer();
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (point)
            {
               x = e.Location.X;
                y = e.Location.Y;
                g.DrawEllipse(new Pen(Color.Blue), x - 15, y - 15, 30, 30);
                point = false;
                timer1.Enabled = true;
            }
            else
            {
                x = e.Location.X;
                y = e.Location.Y;
                g.DrawEllipse(new Pen(Color.Blue), x - 15, y - 15, 30, 30);
                point = true;
                timer1.Enabled = true;
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x -= dy;
        }
    }
}
