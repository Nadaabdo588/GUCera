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
    public partial class ViewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int instid = (int)(Session["user"]);
            int cid = (int)(Session["course"]);

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand viewAssignments = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewAssignments.CommandType = CommandType.StoredProcedure;
            viewAssignments.Parameters.Add("@instrId", instid);
            viewAssignments.Parameters.Add("@cid", cid);

            conn.Open();
            SqlDataReader reader = viewAssignments.ExecuteReader();

            while (reader.Read())
            {
                Image i = new Image();
                i.ImageUrl = "https://img.icons8.com/bubbles/100/000000/task.png";


                int sid = reader.GetInt32(reader.GetOrdinal("sid"));
                int assnum = reader.GetInt32(reader.GetOrdinal("assignmentNumber"));
                String type = reader.GetString(reader.GetOrdinal("assignmenttype"));
                String grade= "";
                int myOrdinal = reader.GetOrdinal("grade");
                if (reader.IsDBNull(myOrdinal))
                {
                    grade = "not graded yet";
                }
                else
                {
                    grade = reader.GetDecimal(reader.GetOrdinal("grade")).ToString();
                }
                    

                Label studentValue = new Label();
                studentValue.Text = sid.ToString();
                studentValue.CssClass = "Label2";

                Label numValue = new Label();
                numValue.Text = assnum.ToString();
                numValue.CssClass = "Label2";

                Label typeValue = new Label();
                typeValue.Text = type;
                typeValue.CssClass = "Label2";

                

                Label gradeValue = new Label();
                gradeValue.Text = grade.ToString();
                gradeValue.CssClass = "Label2";


                Label studentLabel = new Label();
                studentLabel.Text = "Student ID :";
                studentLabel.CssClass = "Label1";

                Label numLabel = new Label();
                numLabel.Text = "Assignment Number :";
                numLabel.CssClass = "Label1";

                Label typeLabel = new Label();
                typeLabel.Text = "Assignment Type :";
                typeLabel.CssClass = "Label1";

                Label gradeLabel = new Label();
                gradeLabel.Text = "Grade :";
                gradeLabel.CssClass = "Label1";

                form1.Controls.Add(i);
                form1.Controls.Add(new LiteralControl("<br>"));


                form1.Controls.Add(studentLabel);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(studentValue);
                form1.Controls.Add(new LiteralControl("<br>"));

                form1.Controls.Add(new LiteralControl("<br>"));
                form1.Controls.Add(numLabel);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(numValue);
                form1.Controls.Add(new LiteralControl("<br>"));

                form1.Controls.Add(new LiteralControl("<br>"));
                form1.Controls.Add(typeLabel);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(typeValue);
                form1.Controls.Add(new LiteralControl("<br>"));

                form1.Controls.Add(new LiteralControl("<br>"));
                form1.Controls.Add(gradeLabel);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(gradeValue);
                form1.Controls.Add(new LiteralControl("<br>"));
 
            }


        }
    }
}