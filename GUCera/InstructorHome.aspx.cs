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

        protected void courses_Click(object sender, EventArgs e)
        {
            Session["course"] = 0;
            Response.Redirect("AddCourse.aspx");
        }



        protected void addAssignment_Click(object sender, EventArgs e)
        {
            Session["assignment"] = 0;
            Response.Redirect("AddAssignment.aspx");
        }

        protected void gradeAssignments_Click(object sender, EventArgs e)
        {
            Session["grade"] = 0;
            Response.Redirect("GradeAssignment.aspx");
        }

        protected void telephone_Click(object sender, EventArgs e)
        {
            Session["number"] = 0;
            Session["type"] = 0;
            Response.Redirect("TelephoneNumbers.aspx");
        }

        protected void certificate_Click(object sender, EventArgs e)
        {
            Session["certificate"] = 0;
            Response.Redirect("IssueCertificate.aspx");
        }

        protected void submittedAssignments_Click(object sender, EventArgs e)
        {
            Session["request"] = 1;
            Response.Redirect("ChooseCourse.aspx");
        }

        protected void feedbacks_Click(object sender, EventArgs e)
        {
            Session["request"] = 0;
            Response.Redirect("ChooseCourse.aspx");

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