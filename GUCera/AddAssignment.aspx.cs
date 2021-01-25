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
    public partial class AddAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Session["user"];
                int course = Int32.Parse(Request.Form["courseText"]);
                String type = Request.Form[ "typeText"];
                int number = Int32.Parse(Request.Form["numberText"]);
                int fullGrade = Int32.Parse(Request.Form["gradeText"]);
                double weight = double.Parse(Request.Form["weightText"]);
                DateTime deadline = DateTime.Parse(Request.Form["deadlineText"]);
                String content = Request.Form["contentText"];

                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand addAssignment = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                addAssignment.CommandType = CommandType.StoredProcedure;
                addAssignment.Parameters.Add(new SqlParameter("@instId", id));
                addAssignment.Parameters.Add(new SqlParameter("@cid", course));
                addAssignment.Parameters.Add(new SqlParameter("@number", number));
                addAssignment.Parameters.Add(new SqlParameter("@type", type));
                addAssignment.Parameters.Add(new SqlParameter("@fullGrade", fullGrade));
                addAssignment.Parameters.Add(new SqlParameter("@weight", weight));
                addAssignment.Parameters.Add(new SqlParameter("@deadline", deadline));
                addAssignment.Parameters.Add(new SqlParameter("@content", content));

                conn.Open();
                addAssignment.ExecuteNonQuery();
                conn.Close();
                error.Visible = true;
                error.Text = "assignment added Successfully";
            }
            catch(Exception er)
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