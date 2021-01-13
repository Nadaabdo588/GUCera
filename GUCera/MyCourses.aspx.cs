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
    public partial class MyCources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = (int)Session["user"];
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String query1 = "select cid from StudentTakeCourse where sid='" + userID + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            conn.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                //ImageButton b = new ImageButton();
                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/bubbles/100/000000/book-reading.png";

                int cid = reader.GetInt32(reader.GetOrdinal("cid"));
                String query = "select name from Course where id='" + cid + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader2 = cmd.ExecuteReader();
                if (reader2.Read())
                {
                    String cname = reader2.GetString(reader2.GetOrdinal("name"));

                    Label nameValue = new Label();
                    nameValue.CssClass = "Label2";
                    nameValue.Text = cname;

                    Label nameLabel = new Label();
                    nameLabel.CssClass = "Label1";
                    nameLabel.Text = "Course Name :";

                    Label idValue = new Label();
                    nameValue.CssClass = "Label2";
                    nameValue.Text = cid.ToString();

                    Label idLabel = new Label();
                    nameLabel.CssClass = "Label1";
                    nameLabel.Text = "Course ID :";

                    Button viewNotSubmittedAssignments = new Button();
                    viewNotSubmittedAssignments.CssClass = "Curved1";
                    viewNotSubmittedAssignments.Text = "View All Submitted Assignments";
                    viewNotSubmittedAssignments.Click += viewNotSubmittedAssignments_Click;
                    viewNotSubmittedAssignments.ID = cid.ToString();

                    Button viewAssignmentsGrades = new Button();
                    viewAssignmentsGrades.CssClass = "Curved1";
                    viewAssignmentsGrades.Text = "View Assignments Grades";
                    viewAssignmentsGrades.Click += viewAssignmentsGrades_Click;
                    viewAssignmentsGrades.ID = cid.ToString()+"0";

                    form1.Controls.Add(b);
                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(idLabel);
                    form1.Controls.Add(new LiteralControl("&nbsp"));
                    form1.Controls.Add(idValue);
                    form1.Controls.Add(new LiteralControl("<br />"));

                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(nameLabel);
                    form1.Controls.Add(new LiteralControl("&nbsp"));
                    form1.Controls.Add(nameValue);
                    form1.Controls.Add(new LiteralControl("<br />"));

                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(viewNotSubmittedAssignments);
                    form1.Controls.Add(new LiteralControl("<br />"));

                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(viewAssignmentsGrades);
                    form1.Controls.Add(new LiteralControl("<br />"));
                    reader2.Close();

                }

            }
            reader.Close();
        }

        private void viewAssignmentsGrades_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Response.Redirect("MyAssignments.aspx?cid=" + button.ID);
        }

        protected void viewNotSubmittedAssignments_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Response.Redirect("ViewAssignments.aspx?cid=" + button.ID);
        }
    }
}