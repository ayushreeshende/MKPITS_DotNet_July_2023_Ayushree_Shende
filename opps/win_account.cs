using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_account_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            account act = null;
            int acctno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if (tt == "saving") 
            {
                act = new saving();

            }
            else if (tt == "current")
            {
                act = new current();
            }
            label4.Text = act.deposit(acctno,amt);
            label5.Text = act.showbalance();
            
        }
    }
}
