﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace third
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Point[] points = {
        new Point(230,56), new Point(318,76), new Point(365,120),
        new Point(380,178), new Point(363,249), new Point(315,302),
        new Point(232,325), new Point(143,300), new Point(99,247),
        new Point(85,175), new Point(99,118), new Point(143,74)
        };
        static int i = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        Pen pen = new Pen(Color.Cyan);
        Point center = new Point(240, 90);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point second = points[i];
            e.Graphics.DrawEllipse(pen, 80, 20, 320, 320);
            e.Graphics.DrawLine(pen, second, center);
        }

    }
}
