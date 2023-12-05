using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_date_year
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age = dateTimePicker1.Text;
            MessageBox.Show("dob" + age);
            string yr = age.Substring(5);
            int year = dateTimePicker1.Value.Year;

            MessageBox.Show("dob:" + yr);

            int cyr = DateTime.Now.Year;
            MessageBox.Show("current year " + cyr);
            int diff = cyr - Convert.ToInt32(yr);
            MessageBox.Show("your age is " + diff);
        }
    }
}
