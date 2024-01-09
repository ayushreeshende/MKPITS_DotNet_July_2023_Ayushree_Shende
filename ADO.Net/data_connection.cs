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


namespace username_password_ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {


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

       
}




        }
   
