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

namespace ado.net_course_practise
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=course_practise";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            getnation();
            getcity();
            getstate();
            if (radioButton1.Checked)
                textBox1.Text = "1000";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getstate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcity();
        }
        public void getnation()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tablenation order by nationid", con);
                ds = new DataSet();
                da.Fill(ds, "tablenation");
                comboBox1.DataSource = ds.Tables["tablenation"];
                comboBox1.DisplayMember = "nationname";
                comboBox1.ValueMember = "nationid";
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void getstate()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablestate where nationid=@nationid", con);
                    da.SelectCommand.Parameters.AddWithValue("@nationid", comboBox1.SelectedValue);

                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "statename";
                    comboBox2.ValueMember = "stateid";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }
        public void getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablecity where stateid=@stateid", con);
                    da.SelectCommand.Parameters.AddWithValue("@stateid", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "cityname";
                    comboBox3.ValueMember = "cityid";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        public enum category { student, it_professional }
        public enum gender { male, female, other }
        category cat;
        gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selecteddate = dateTimePicker1.Value;
            if (selecteddate.Date < DateTime.Today)
            {
                MessageBox.Show("please select a payment date that is on or after today's date. ", "invalid date selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("full name can be blank");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    cat = category.student;
                }
                else if (radioButton2.Checked)
                {
                    cat = category.it_professional;
                }
                MessageBox.Show("category" + cat);
                if (radioButton3.Checked)
                {
                    gen = gender.male;
                }
                else if (radioButton4.Checked)
                {
                    gen = gender.female;
                }
                else if (radioButton5.Checked)
                {
                    gen = gender.other;
                }
                savecourseregdetail(cat, gen);
            }
        }
        public void savecourseregdetail(category c, gender g)
        {
            try
            {
                string str = "insert into tablecourseregdetail values(@categoryid,@fullname,@genderid)";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@categoryid", Convert.ToInt32(c));
                cmd.Parameters.AddWithValue("@fullname", textBox1.Text);
                cmd.Parameters.AddWithValue("@genderid", Convert.ToInt32(g));
                con.Open();
                con.Close();
                insertRegAddress();
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void insertRegAddress()
        {
            con.Open();
            string str = "select max(courseregid)from tablecourseregdetail";
            SqlCommand cmd = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd.ExecuteScalar());
            string s2 = "insert into TableRegAddress values(@courseregid,@nationid,@stateid,@cityid)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@NationID", SqlDbType.Int).Value = comboBox1.SelectedValue;
            cmd1.Parameters.Add("@StateID", SqlDbType.Int).Value = comboBox2.SelectedValue;
            cmd1.Parameters.Add("@CityID", SqlDbType.Int).Value = comboBox3.SelectedValue;

            cmd1.ExecuteNonQuery();
            MessageBox.Show("stored tableregaddress");
            con.Close();
            insertfeedetail();
        }
        public void insertfeedetail()
        {
            con.Open();
            string str = "select max(courseregid)from tablecourseregdetail";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());
            String s2 = "insert into tablefeedetail values(@courseregid,@totalamount,@miniper,@paidamount,@balamount,@paiddate)";
            SqlCommand cmd1 = new SqlCommand(s2, con);

            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = textBox2.Text;

            cmd11.Parameters.Add("@MinPer", SqlDbType.Int).Value = fp;
            cmd11.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = textBox3.Text;
            cmd11.Parameters.Add("@BalAmount", SqlDbType.Int).Value = textBox4.Text;
            cmd11.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd11.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored TableFeeDetail");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = category.it_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
              
            }
        }
        float fp = 0;
        float bamt = 0;
        public void calculatefees()
        {
            if (cat.ToString() == "student")
            {
                textBox2.Text = "1000";

                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "it_professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                cat = category.student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            getnation();
            getstate();
            getcity();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();
        }
    }


}
    
    

