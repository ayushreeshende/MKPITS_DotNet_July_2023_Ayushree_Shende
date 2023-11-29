using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //stringbuilder  class used to add new string to existing string
            StringBuilder sb = new StringBuilder();
            int num = Convert.ToInt32(textBox1.Text);
            int res = 1;
            for(int cnt=1;cnt<=10;cnt++)
            {
                res = num * cnt;
                sb.Append(num + "*" + cnt + "=" + res + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
