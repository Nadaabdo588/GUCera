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
    public partial class CourseInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn = new SqlConnection(connStr);
                int id = Int32.Parse(Request.QueryString["cid"]);
                String query = "select id,firstName,lastName from InstructorTeachCourse inner join Users on id=insid where cid=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    String fname = reader.GetString(reader.GetOrdinal("firstName"));
                    String lname = reader.GetString(reader.GetOrdinal("lastName"));
                    int insid = reader.GetInt32(reader.GetOrdinal("id"));
                    String insname = fname + " " + lname;
                    ListItem l = new ListItem();
                    l.Value = insid.ToString();
                    l.Text = insname;
                    dl.Items.Add(l);
                }
            } catch (Exception ex)
            {
                error.Visible = true;
                error.Text = "An error occured";
            }
        }

        protected void enrollButton_Click(object sender, EventArgs e)
        {

            try
            {
                int sid = (int)Session["user"];
                int cid = Int32.Parse(Request.QueryString["cid"]);
                int instID = Int32.Parse(dl.SelectedValue);
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand enrollInCourseProc = new SqlCommand("enrollInCourse", conn);
                enrollInCourseProc.CommandType = CommandType.StoredProcedure;
                enrollInCourseProc.Parameters.Add(new SqlParameter("@sid", sid));
                enrollInCourseProc.Parameters.Add(new SqlParameter("@cid", cid));
                enrollInCourseProc.Parameters.Add(new SqlParameter("@instr", instID));

                conn.Open();
                enrollInCourseProc.ExecuteNonQuery();
                conn.Close();
                error.Visible = true;
                error.Text = "Enrollment completed successfully !";

            }
            catch (Exception ex)
            {
                error.Visible = true;
                error.Text = "Enrollment failed";
            }
        }
        protected void h_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx");

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


