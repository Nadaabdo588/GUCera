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
            int cid = Int32.Parse(courseText.Text);
            Session["course"] = cid;
            if((int)Session["request"]==1)
                Response.Redirect("ViewAssignments.aspx");
            else
                Response.Redirect("ViewFeedbacks.aspx");
        }
    }
}