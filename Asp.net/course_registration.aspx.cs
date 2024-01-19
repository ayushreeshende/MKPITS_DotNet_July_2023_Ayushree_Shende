using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace course_registration
{
    public partial class course_registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                stype = "student";
                TextBox4.Text = "1000";
            }
               
            }
        static string stype = "student"; 

        

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
            switch (c)
            {
                case "India":
                    DropDownList2.Items.Add("maharashtra");
                    DropDownList2.Items.Add("andhra");

                    break;

                case "Usa":
                    DropDownList2.Items.Add("nyka");
                    DropDownList2.Items.Add("la");

                    break;



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Full Name:" + TextBox1.Text + "<br>");

            string g = null;
            if (RadioButton1.Checked)
                g = RadioButton1.Text;
            else if (RadioButton2.Checked)
                g = RadioButton2.Text;
            else if (RadioButton3.Checked)
                g = RadioButton3.Text;
            sb.Append("gender" + g + "<br>");

            string c = null;
            if (RadioButton4.Checked)
                c = RadioButton4.Text;
            else if (RadioButton5.Checked)
                c = RadioButton5.Text;
            sb.Append("category" + c + "<br>");

            sb.Append("Country" + DropDownList1.Text + "<br>");
            sb.Append("State" + DropDownList2.Text + "<br>");
            sb.Append("City" + DropDownList4.Text + "<br>");




        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
         if(stype=="student")
            {
                double fper = Convert.ToDouble(TextBox4.Text) * 0.5;
                if (Convert.ToDouble(TextBox5.Text) < fper)
                {
                    Label1.Text = "amount paid should be equal or greater than 50%";
                }
                else
                {
                    bal = Convert.ToDouble(TextBox4.Text) - Convert.ToInt32(TextBox5.Text);
                    TextBox6.Text = bal.ToString();
                    Label1.Text = "";

                }         
                }
         else if(stype=="it")
            {
                double fper = Convert.ToDouble(TextBox4.Text) * 0.8;
                if (Convert.ToDouble(TextBox5.Text) < fper)
                {
                    Label1.Text = "amount paid should be equal or greater than 80%";
                }
                else
                {
                    bal = Convert.ToInt32(TextBox4.Text) - Convert.ToInt32(TextBox5.Text);
                    TextBox6.Text = bal.ToString();
                    Label1.Text = "";

                }

            }
            }
            
        

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList4.Items.Clear();
            switch (c)
            {
                case "India":
                    DropDownList4.Items.Add("akola");
                    DropDownList4.Items.Add("bhandar");

                    break;

                case "Usa":
                    DropDownList4.Items.Add("hump");
                    DropDownList4.Items.Add("lanesia");
                    break;

            }
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton4.Checked)
            {
                stype = "student";
                TextBox4.Text = "1000";
                TextBox5.Text = "0";
                TextBox6.Text = "0";
            }
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton5.Checked)
            {
                stype = "it";
                TextBox4.Text = "3000";
                TextBox5.Text = "0";
                TextBox6.Text = "0";
            }
        }
        double bal = 0;
    }
}