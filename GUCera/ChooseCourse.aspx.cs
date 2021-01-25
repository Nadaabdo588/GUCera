using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ChooseCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Int32.Parse(Request.Form["courseText"]);
                Session["course"] = cid;
                if ((int)Session["request"] == 1)
                    Response.Redirect("ViewsubAssignments.aspx");
                else
                    Response.Redirect("ViewFeedbacks.aspx");
            }
            catch (Exception er)
            {
                error.Visible = true;
                error.Text = "an error has occured";
            }
        }
        protected void h_Click(object sender, EventArgs e)
        {


            Response.Redirect("InstructorHome.aspx");

        }



        protected void as_Click(object sender, EventArgs e)
        {
            Session["request"] = 1;

            Response.Redirect("ChooseCourse.aspx?req=1");


        }

        protected void fd_Click(object sender, EventArgs e)
        {

            Session["request"] = 0;
            Response.Redirect("ChooseCourse.aspx?req=0");

        }
    }
}