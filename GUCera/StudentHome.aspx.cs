using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void profile_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");
        }
        protected void courses_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AceeptedCourses.aspx");
        }

        protected void creditcards_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("MyCreditCards.aspx");

        }

        protected void promocodes_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("MyPromoCodes.aspx");
        }

        protected void telephone_Click(object sender, ImageClickEventArgs e)
        {
            Session["number"] = 0;
            Response.Redirect("TelephoneNumbers.aspx");
        }
        protected void myCources_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("MyCourses.aspx");
        }

        protected void myAssignments_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("MyAsignments.aspx");
        }

        protected void addFeedback_Click(object sender, ImageClickEventArgs e)
        {
            Session["feedback"] = 0;
            Response.Redirect("AddFeedback.aspx");
        }

        protected void ListCertificates_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ListCertificates.aspx");
        }
    }
}