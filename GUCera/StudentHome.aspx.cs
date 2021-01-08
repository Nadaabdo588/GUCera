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
            int id = (int)Session["user"];
            Response.Redirect("StudentProfile.aspx" );
        }
        protected void courses_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AceeptedCourses.aspx");
        }

        protected void creditcards_Click(object sender, ImageClickEventArgs e)
        {
            //String id =Request.QueryString["id"];
            String id = "1";
            Response.Redirect("MyCreditCards.aspx" );

        }

        protected void promocodes_Click(object sender, ImageClickEventArgs e)
        {
            String id =Request.QueryString["id"];
            Response.Redirect("MyPromoCodes.aspx?id=" + id);
        }
    }
}