using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            float area;
            r = Convert.ToInt32(textBox1.Text);
            area = 3.14f * r * r;
            label3.Text = "result:" + area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sqr;
            int side;
            Console.WriteLine("enter a side");
            side = Convert.ToInt32(textBox1.Text);
            sqr = side * side;
            label3.Text="result:" +sqr ;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(textBox1.Text);
            int breadth = Convert.ToInt32(textBox2.Text);
            int result = length * breadth;
            label3.Text = "result=" + result;

           
        }
    }
    }

