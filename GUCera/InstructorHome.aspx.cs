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



        protected void addAssignment_Click(object sender, ImageClickEventArgs e)
        {
            Session["assignment"] = 0;
            Response.Redirect("AddAssignment.aspx");
        }

        protected void gradeAssignments_Click(object sender, ImageClickEventArgs e)
        {
            Session["grade"] = 0;
            Response.Redirect("GradeAssignment.aspx");
        }

        protected void telephone_Click(object sender, ImageClickEventArgs e)
        {
            Session["number"] = 0;
            Session["type"] = 0;
            Response.Redirect("TelephoneNumbers.aspx");
        }

        protected void certificate_Click(object sender, ImageClickEventArgs e)
        {
            Session["certificate"] = 0;
            Response.Redirect("IssueCertificate.aspx");
        }
    }
}