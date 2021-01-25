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

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");
        }
        protected void courses_Click(object sender, EventArgs e)
        {
            Response.Redirect("AceeptedCourses.aspx");
        }

        protected void creditcards_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCreditCards.aspx");

        }

        protected void promocodes_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyPromoCodes.aspx");
        }

        protected void telephone_Click(object sender, EventArgs e)
        {
            Session["number"] = 0;
            Response.Redirect("TelephoneNumbers.aspx");
        }
        protected void myCources_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCourses.aspx");
        }

  

        protected void ListCertificates_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListCertificates.aspx");
        }

        protected void h_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx");

        }


        protected void p_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");

        }

        protected void c_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCourses.aspx");

        }

        protected void pc_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyPromoCodes.aspx");

        }

        protected void cer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListCertificates.aspx");
        }
    }
}