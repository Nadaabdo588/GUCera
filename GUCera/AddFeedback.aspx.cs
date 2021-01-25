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
    public partial class AddFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = (int)Session["user"];
                int cid = Int32.Parse(Request.QueryString["cid"].Substring(0, Request.QueryString["cid"].Length - 2));
                String comment1 = Request.Form["comment"];

                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand addFeedback = new SqlCommand("addFeedback", conn);
                addFeedback.CommandType = CommandType.StoredProcedure;
                addFeedback.Parameters.Add(new SqlParameter("@comment", comment1));
                addFeedback.Parameters.Add(new SqlParameter("@cid", cid));
                addFeedback.Parameters.Add(new SqlParameter("@sid", sid));

                String query = "select * from StudentTakeCourse where sid='" + sid + "' And cid = '" + cid + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    addFeedback.ExecuteNonQuery();
                    error.Text = "Feedback added successfully";
                    error.Visible = true;
                }
               
                conn.Close();
            }
            catch (Exception ex)
            {
                error.Text = "please check your entered data";
                error.Visible = true;
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