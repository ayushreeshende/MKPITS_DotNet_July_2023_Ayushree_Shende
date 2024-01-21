using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace area_of_circle
{
    public partial class area_of_circle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
       
            

           int radius = Convert.ToInt32(TextBox1.Text);
            float area;

            area = 3.14f * radius * radius;
            Label2.Text = area.ToString();
            
            




        }
    }
}