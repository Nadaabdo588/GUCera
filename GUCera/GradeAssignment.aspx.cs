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
    public partial class GradeAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Session["user"];
                int sid = Int32.Parse(Request.Form["studentText"]);
                int cid = Int32.Parse(Request.Form["courseText"]);
                String type = Request.Form ["typeText"];
                int number = Int32.Parse(Request.Form["numberText"]);
                double grade = double.Parse(Request.Form["gradeText"]);

                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand gradeAssignment = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
                gradeAssignment.CommandType = CommandType.StoredProcedure;
                gradeAssignment.Parameters.Add(new SqlParameter("@instrId", id));
                gradeAssignment.Parameters.Add(new SqlParameter("@sid", sid));
                gradeAssignment.Parameters.Add(new SqlParameter("@cid", cid));
                gradeAssignment.Parameters.Add(new SqlParameter("@assignmentNumber", number));
                gradeAssignment.Parameters.Add(new SqlParameter("@type", type));
                gradeAssignment.Parameters.Add(new SqlParameter("@grade", grade));
                conn.Open();
                gradeAssignment.ExecuteNonQuery();
                conn.Close();
                error.Text = "Assignment is graded successfully";
                error.Visible = true;

            }
            catch(Exception er)
            {
                error.Text = "an error has happened";
                error.Visible = true;
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