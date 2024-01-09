using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_form_ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;integrated security=true ;database=login_mkpsample";
        SqlConnection con = null;
        SqlCommand cmd = null;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            con = new SqlConnection(str);
           
            String qr = "select count(*) from users121 where username=@username and password=@password";

            cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);

            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
                MessageBox.Show( "login successfull");
            else
                MessageBox.Show("invalid credentail,try again");


            con.Close();
            panel1.Visible = false;
            menuStrip1.Visible = true;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.Show();
        }
    }
}
