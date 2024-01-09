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

namespace login_username_password_ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;integrated security=true;database=login_mkpsample";
        SqlConnection con = null;
        SqlCommand cmd = null;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                con = new SqlConnection(str);
                String qr = "select count(*) from users121 where username=@username and password=@password";

                cmd = new SqlCommand(qr, con);
                cmd.Parameters.AddWithValue("@username",textBox1.Text);
                cmd.Parameters.AddWithValue("@password",textBox2.Text);
                con.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());

                if (cnt > 0)
                    label3.Text = "login successfull";
                else
                    label3.Text = "invalid credentail,try again";
           
            
                con.Close();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
