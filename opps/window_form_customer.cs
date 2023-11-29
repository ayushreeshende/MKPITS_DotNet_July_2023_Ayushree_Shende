using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, customer> cust = new Dictionary<int, customer>();
        private void button1_Click(object sender, EventArgs e)
        {
            customer c1 = new customer(Convert.ToInt32(textBox1.Text), textBox3.Text);
            customer c2 = new customer(Convert.ToInt32(textBox2.Text), textBox4.Text);
            cust.Add(c1.Id, c1);
            cust.Add(c2.Id, c2);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, customer> kv in cust)
            {
                sb.Append("cust id " + kv.Key + " customer name " + kv.Value.name + "\n");
            }
            label5.Text = sb.ToString();
        }

    }
}