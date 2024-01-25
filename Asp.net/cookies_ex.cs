using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookie_example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = new HttpCookie("cook");
            cookie1.Values.Add("username", TextBox1.Text);
            Response.Cookies.Add(cookie1);
            Label1.Text = "temporary cookie added to client machine";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["cook"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                Label1.Text = "username:" + uname;
            }
            else
            {
                Label1.Text = "no cookies exit";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie cookie12 = Request.Cookies["cook"];
            cookie12.Values.Add("username", TextBox1.Text);
            cookie12.Values.Add("email", TextBox2.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(2, 0, 2);
            cookie12.Expires = dt.Add(ts);
            Label1.Text = "permanent cookie added to client machine";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie cookie12 = Request.Cookies["cook1"];
            if (cookie12 != null)
            {
                string uname = cookie12.Values["username"].ToString();
                string uemail = cookie12.Values["email"].ToString();
                Label1.Text = "username : " + uname;
                Label2.Text = "email : " + uemail;
            }
            else
            {
                Label1.Text = "no permanent cookie exist";
            }
        }
    }
}
