using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
                HtmlGenericControl card = new HtmlGenericControl("div");
                card.Attributes.Add("class", "card col");
                HtmlGenericControl cardbody = new HtmlGenericControl("div");
                cardbody.Attributes.Add("class", "card-body");
                Image i = new Image();
                i.ImageUrl =  "https://img.icons8.com/clouds/100/000000/task.png" ;


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

                cardbody.Controls.Add(i);
                cardbody.Controls.Add(new LiteralControl("<br>"));


                cardbody.Controls.Add(studentLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(studentValue);
                cardbody.Controls.Add(new LiteralControl("<br>"));

                cardbody.Controls.Add(new LiteralControl("<br>"));
                cardbody.Controls.Add(numLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(numValue);
                cardbody.Controls.Add(new LiteralControl("<br>"));

                cardbody.Controls.Add(new LiteralControl("<br>"));
                cardbody.Controls.Add(typeLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(typeValue);
                cardbody.Controls.Add(new LiteralControl("<br>"));

                cardbody.Controls.Add(new LiteralControl("<br>"));
                cardbody.Controls.Add(gradeLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(gradeValue);

                card.Controls.Add(cardbody);
                PlaceHolder1.Controls.Add(card);
 
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