using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace product
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("order no: " + TextBox1.Text + "<br>");
            sb.Append("customer name: " + TextBox2.Text + "<br>");
            sb.Append("order date: " + TextBox3.Text + "<br>");
            sb.Append("product name: " + DropDownList1.Text + "<br>");
            sb.Append("price: " + TextBox4.Text + "<br>");
            sb.Append("quantity: " + TextBox5.Text + "<br>");
            int total = Convert.ToInt32(TextBox4.Text) * Convert.ToInt32(TextBox5.Text);
            sb.Append("total: " + total.ToString()+ "<br>");
            Label1.Text = sb.ToString();
        }

            
    }
}