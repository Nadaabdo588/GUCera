using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void viewC_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewdCourses.aspx");

        }

        protected void notacceptedC_Click(object sender, EventArgs e)
        {
            Response.Redirect("NonAcceptedCourses.aspx");
        }

        protected void MngOpt_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageOptions.aspx");
        }
    }
 }