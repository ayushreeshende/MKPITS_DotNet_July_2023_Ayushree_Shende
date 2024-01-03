using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado.net_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentClass s = new studentClass();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "male";
            }
            if (radioButton2.Checked)
            {
                g = "female";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "music";
            }
            if (checkBox2.Checked)
            {
                h = "dance";
            }
            if (checkBox3.Checked)
            {
                if (h != null)
                    h = h + " " + "drawing";
                else
                    h = "drawing";
            }
            string result = s.Insertstudent22(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();
        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentClass s = new studentClass();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "male";
            }
            if (radioButton2.Checked)
            {
                g = "female";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "music";
            }
            if (checkBox2.Checked)
            {
                h = "dance";
            }
            if (checkBox3.Checked)
            {
                if (h != null)
                    h = h + " " + "drawing";
                else
                    h = "drawing";
            }
            string result = s.Updatestudent22(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentClass s = new studentClass();

            string result = s.Deletestudent22(Convert.ToInt32(textBox1.Text), textBox2.Text);

            label7.Text = result;
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<studentClass> li = new List<studentClass>();
            studentClass s = new studentClass();
            li = s.searchstudent(Convert.ToInt32(textBox1.Text));
            textBox2.Text = li[0].name;
            string g = li[0].gender;
            string h = li[0]hobby;
            if (g == "male")
            {
                radioButton1.Checked = true;
            }
            else if (g == "female")
            {
                radioButton2.Checked = true;
           
            }
            string result = s.Updatestudent22(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();
        }

           
        }
    }










