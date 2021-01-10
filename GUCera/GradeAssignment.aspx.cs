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
            if ((int)Session["grade"] == 1)
            {
                error.Visible = true;
                error.Text = "Grade submitted Successfully";
                Session["grade"] = 0;
            }

        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            int id = (int)Session["user"];
            int sid = Int32.Parse(studentText.Text);
            int cid = Int32.Parse(courseText.Text);
            String type = typeText.Text;
            int number = Int32.Parse(numberText.Text);
            double grade = double.Parse(gradeText.Text);

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
            Session["grade"] = 1;
            Response.Redirect("GradeAssignment.aspx");
        }
    }
}