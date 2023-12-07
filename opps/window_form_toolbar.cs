using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_scroll_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("name:" + textBox1.Text +"\n");
            sb.Append("dob:" +textBox2.Text+"\n");
            sb.Append("address:" + textBox3.Text + "\n");
            sb.Append("email id:" + textBox4.Text + "\n");
            sb.Append("city:" + textBox5.Text + "\n");
            sb.Append("qualification:" + textBox6.Text + "\n");
            sb.Append("nationality:" + textBox7.Text + "\n");
            label8.Text = sb.ToString();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("first name:" + textBox8.Text + "\n");
            sb.Append("surname:" + textBox14.Text + "\n");
            sb.Append("father name:" + textBox9.Text + "\n");
            sb.Append("mother name:" + textBox10.Text + "\n");
            sb.Append("father occupation:" + textBox11.Text + "\n");
            sb.Append("mother occupation:" + textBox15 + "\n");
            sb.Append("dob:" + textBox12.Text + "\n");
            sb.Append("qualification:" + textBox16 + "\n");
            string gender = null;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else if (radioButton2.Checked)
                gender = radioButton2.Text;
            sb.Append("gender:" + gender);
            label19.Text = sb.ToString();
        }
        
    }
}
