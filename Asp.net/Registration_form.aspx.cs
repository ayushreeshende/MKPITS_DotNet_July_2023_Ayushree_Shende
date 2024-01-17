using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_form
{
    public partial class Registration_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("user name" + TextBox1.Text + "<br>");
            sb.Append("password" + TextBox2.Text + "<br>");
            sb.Append("address" + TextBox3.Text + "<br>");

            string g = null;
            if (RadioButton1.Checked)
                g = RadioButton1.Text;
            else if (RadioButton2.Checked)
                g = RadioButton2.Text;
            sb.Append("gender" + g + "<br>");

            string h = null;
            if (CheckBox1.Checked)
                h = h + "" + CheckBox1.Text;
            if (CheckBox2.Checked)
                h = h + "" + CheckBox2.Text;
            if (CheckBox3.Checked)
                h = h + "" + CheckBox3.Text;
            sb.Append("hobby" + h + "<br>");
            sb.Append("country" + DropDownList2.Text + "<br>");
            sb.Append("city" + DropDownList3.Text + "<br>");

            string c = null;
            foreach (ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    c = c + li.Value + "<br>";
                }
            }
            sb.Append("courses" + c + "<br>");
            string cen = null;
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    cen += li.Value + "<br>";
                }
            }
            sb.Append("center" + cen + "<br>");
            Label1.Text = sb.ToString();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList2.Text;
            DropDownList3.Items.Clear();
            switch(c)
            {
                case "India":
                    DropDownList3.Items.Add("nagpur");
                    DropDownList3.Items.Add("mumbai");
                    break;

                case "USA":
                    DropDownList3.Items.Add("la");
                    DropDownList3.Items.Add("ny");
                    break;
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}