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
                    HtmlGenericControl card = new HtmlGenericControl("div");
                    card.Attributes.Add("class", "col card");
                    HtmlGenericControl cardbody = new HtmlGenericControl("div");
                    cardbody.Attributes.Add("class", "card-body");
                    HtmlGenericControl cardfooter = new HtmlGenericControl("div");
                    cardfooter.Attributes.Add("class", "card-footer");

                    HtmlGenericControl row = new HtmlGenericControl("div");
                    row.Attributes.Add("class", "row");

                    String cname = reader2.GetString(reader2.GetOrdinal("name"));

                    Label nameValue = new Label();
                    nameValue.CssClass = "Label2";
                    nameValue.Text = cname;

                    Label nameLabel = new Label();
                    nameLabel.CssClass = "Label4";
                    nameLabel.Text = "Course Name :";

                    Label idValue = new Label();
                    idValue.CssClass = "Label2";
                    idValue.Text = cid.ToString();

                    Label idLabel = new Label();
                    idLabel.CssClass = "Label4";
                    idLabel.Text = "Course ID :";

                    Button viewNotSubmittedAssignments = new Button();
                    viewNotSubmittedAssignments.CssClass = "Curved1 col";
                    viewNotSubmittedAssignments.Style.Add("margin", "0px 4px 4px 0px");
                    viewNotSubmittedAssignments.Text = "Course Assignments";
                    viewNotSubmittedAssignments.Click += viewNotSubmittedAssignments_Click;
                    viewNotSubmittedAssignments.ID = cid.ToString();

                    Button viewAssignmentsGrades = new Button();
                    viewAssignmentsGrades.CssClass = "Curved1 col";
                    viewAssignmentsGrades.Style.Add("margin", "0px 0px 4px 4px");
                    viewAssignmentsGrades.Text = "Assignments Grades";
                    viewAssignmentsGrades.Click += viewAssignmentsGrades_Click;
                    viewAssignmentsGrades.ID = cid.ToString()+")(";

                    Button feedback = new Button();
                    feedback.CssClass = "Curved1 col";
                    feedback.Style.Add("margin", "4px 0px 0px 0px");
                    feedback.Text = "Add Feedback";
                    feedback.Click += feedback_Click;
                    feedback.ID = cid.ToString() + "ab"; 

                    cardbody.Controls.Add(b);
                    cardbody.Controls.Add(new LiteralControl("<br />"));
                    cardbody.Controls.Add(idLabel);
                    cardbody.Controls.Add(new LiteralControl("&nbsp"));
                    cardbody.Controls.Add(idValue);
                    cardbody.Controls.Add(new LiteralControl("<br />"));

                    cardbody.Controls.Add(new LiteralControl("<br />"));
                    cardbody.Controls.Add(nameLabel);
                    cardbody.Controls.Add(new LiteralControl("&nbsp"));
                    cardbody.Controls.Add(nameValue);
                    cardbody.Controls.Add(new LiteralControl("<br />"));

                    row.Controls.Add(viewNotSubmittedAssignments);
                    row.Controls.Add(viewAssignmentsGrades);
                    row.Controls.Add(feedback);
                    cardfooter.Controls.Add(row);
                    card.Controls.Add(cardbody);
                    card.Controls.Add(cardfooter);
                    PlaceHolder1.Controls.Add(card);

                }

            }
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
        protected void h_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx");

        }
        private void feedback_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Response.Redirect("AddFeedback.aspx?cid=" + button.ID);
        }


        protected void p_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");

        }

        protected void c_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCourses.aspx");

        }

        protected void pc_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyPromoCodes.aspx");

        }
        protected void cer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListCertificates.aspx");
        }
    }
}
