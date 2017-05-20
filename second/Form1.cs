using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ind = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = ind.ToString();
                    btn.Location = new Point(j * 50, i * 50);
                    btn.Size = new Size(40, 40);
                    btn.Click += new EventHandler(number_click);
                    Controls.Add(btn);
                }

            }
           
        }
        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.TabIndex + 1 % 2 == 0)
            {
                btn.Text += btn.Text;
                textBox1.Text += textBox1.Text;
            }
        }

    
     }
 }

