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
    public partial class IssueCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Session["user"];
                int cid = Int32.Parse(Request.Form["courseText"]);
                int sid = Int32.Parse(Request.Form["studentText"]);
                DateTime now = DateTime.Now;

                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand FinalGrade = new SqlCommand("calculateFinalGrade", conn);
                FinalGrade.CommandType = CommandType.StoredProcedure;
                FinalGrade.Parameters.Add(new SqlParameter("@cid", cid));
                FinalGrade.Parameters.Add(new SqlParameter("@sid", sid));
                FinalGrade.Parameters.Add(new SqlParameter("@insId", id));


                SqlCommand IssueCertificate = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                IssueCertificate.CommandType = CommandType.StoredProcedure;
                IssueCertificate.Parameters.Add(new SqlParameter("@cid", cid));
                IssueCertificate.Parameters.Add(new SqlParameter("@sid", sid));
                IssueCertificate.Parameters.Add(new SqlParameter("@insId", id));
                IssueCertificate.Parameters.Add(new SqlParameter("@issueDate", now));


                conn.Open();
                FinalGrade.ExecuteNonQuery();
                IssueCertificate.ExecuteNonQuery();
                conn.Close();
                error.Visible = true;
                error.Text = "Certificate issued successfully";
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