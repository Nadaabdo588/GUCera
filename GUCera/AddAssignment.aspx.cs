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
            if ((int)Session["assignment"] == 1)
            {
                

                error.Visible = true;
                error.Text = "assignment added Successfully";
                Session["assignment"] = 0;
            }
        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            int id = (int)Session["user"];
            int course = Int32.Parse(courseText.Text);
            String type = typeText.Text;
            int number = Int32.Parse(numberText.Text);
            int fullGrade = Int32.Parse(gradeText.Text);
            double weight = double.Parse(weightText.Text);
            DateTime deadline = DateTime.Parse(deadlineText.Text);
            String content = contentText.Text;

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
            Session["assignment"] = 1;
            Response.Redirect("AddAssignment.aspx");

        }
    }
}