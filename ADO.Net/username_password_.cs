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
using System.Linq.Expressions;

namespace username_password_ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String constr = "server=.\\SQLEXPRESS; integrated security=true;database=mkpsample";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                MessageBox.Show("connected successfully");
            }
            catch (Exception ee)

            {
                MessageBox.Show(ee.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection strcon = database_connection.getConnection();
            if (strcon != null)
            {
                MessageBox.Show("successfully connected");
                strcon.Close();
            }
            else
            {
                MessageBox.Show("could not connect to sqlserver");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS; integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "insert into users22 values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label3.Text = "record inserted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS; integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "update users22 set password='" + textBox2.Text + "'where usernamename='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label3.Text = "record update successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS; integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "delete from users22  where usernamename='" + textBox1.Text + "' or password ='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label3.Text = "record deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

            }

        private void button6_Click(object sender, EventArgs e)
        {

            string constr = "server=.\\SQLEXPRESS; integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "select * from users22 where usernamename='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["password"].ToString();
                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    label3.Text = "record not found";
                }
            }
                catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
                    
            }

        }
    }
    }
    

    

