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

namespace employee_ado.net
{
    public partial class Form1 : Form
    {
        public string connectionstring { get; set; } = @"data source=.\SQLEXPRESS;initial catalog=company;integrated security=true;database=employee_mkpsample";
        SqlDataAdapter sqlda;
        DataSet dataSet;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            sqlda = new SqlDataAdapter("select * from employee1", connectionstring);
            cb = new SqlCommandBuilder(sqlda);
            dataSet = new DataSet();
            sqlda.Fill(dataSet, "emp");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dataSet.Tables["emp"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt32(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = textBox6.Text;
            dr[6] = Convert.ToInt32(textBox7.Text);
            dataSet.Tables["emp"].Rows.Add(dr);
            sqlda.Update(dataSet.Tables["emp"]);
            MessageBox.Show("data successfully inserted..");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["emp"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt16(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        sqlda.Update(dataSet.Tables["emp"]);
                        MessageBox.Show("Data Successfully Updated..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int counter = 0;
            foreach (DataRow dr in dataSet.Tables["emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr.Delete();
                        sqlda.Update(dataSet.Tables["emp"]);
                        dataSet.Tables["emp"].AcceptChanges();
                        MessageBox.Show("data successfully deleted...");
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                }
            }
        }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                comboBox1.DataSource = dataSet.Tables["emp"];
                comboBox1.DisplayMember = "emp_id";
            }

            private void datagridview1(object sender, DataGridViewCellEventArgs e)
            {
                textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            }

            private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            }
        }
    }




