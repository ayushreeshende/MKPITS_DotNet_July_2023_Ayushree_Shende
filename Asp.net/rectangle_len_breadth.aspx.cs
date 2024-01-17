using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rectangle_length_breadth
{
    public partial class rectangle_len_breadth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int length = Convert.ToInt32(TextBox1.Text);
            int breadth = Convert.ToInt32(TextBox2.Text);
            float area;

            {
                float a = length * breadth;
                Label1.Text = a.ToString();
            }
        }
    }
}

                
          