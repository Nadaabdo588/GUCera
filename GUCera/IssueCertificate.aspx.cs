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
            if ((int)Session["certificate"] == 1)
            {
                error.Visible = true;
                error.Text = "Certificate issued successfully";
                Session["certificate"] = 0;
            }

        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            int id = (int)Session["user"];
            int cid = Int32.Parse(courseText.Text);
            int sid = Int32.Parse(studentText.Text);
            DateTime now = DateTime.Now;

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand IssueCertificate = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            IssueCertificate.CommandType = CommandType.StoredProcedure;
            IssueCertificate.Parameters.Add(new SqlParameter("@cid", cid));
            IssueCertificate.Parameters.Add(new SqlParameter("@sid", sid));
            IssueCertificate.Parameters.Add(new SqlParameter("@insId", id));
            IssueCertificate.Parameters.Add(new SqlParameter("@issueDate", now));
            conn.Open();
            IssueCertificate.ExecuteNonQuery();
            conn.Close();
            Session["Certificate"] = 1;
            Response.Redirect("IssueCertificate.aspx");
        }
    }
}