using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class InstructorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void courses_Click(object sender, ImageClickEventArgs e)
        {
            Session["course"] = 0;
            Response.Redirect("AddCourse.aspx");
        }

        protected void promocodes_Click(object sender, ImageClickEventArgs e)
        {
            Session["assignment"] = 0;
            Response.Redirect("AddAssignment.aspx");

        }
    }
}