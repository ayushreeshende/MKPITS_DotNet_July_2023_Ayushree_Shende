using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace windows_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("capacity:" + ar.Capacity);
            MessageBox.Show("count:" + ar.Count);
            StringBuilder sb = new StringBuilder();
            ar.Sort();

            sb.Append("sorting with arraylist");


            foreach (object o in ar)
            {
                sb.Append("name:" + o + "\n");
            }
            label2.Text = sb.ToString();
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            ar.Insert(2, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
             
            ar.RemoveAt(2);
            textBox1.Clear();
            textBox1.Focus();

                
            }
        }
    }

