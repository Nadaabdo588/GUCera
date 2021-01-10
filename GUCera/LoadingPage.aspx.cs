using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class LoadingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Your ID is " + Session["user"];

          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((int)Session["type"] == 0)

            {
                Response.Redirect("InstructorHome.aspx");
            }
            else
            {
                Response.Redirect("StudentHome.aspx");
            }
        }
    }
}