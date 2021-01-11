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

        }

        protected void enrollButton_Click(object sender, EventArgs e)
        {
            int sid = (int)Session["sid"];
            int cid = Int32.Parse(cidText.Text);
            int instID = Int32.Parse(instIdText.Text);
            if (cid.ToString().Length == 0)
            {
                error.Visible = true;
                error.Text = "Please enter a valid course ID ";
            }
            else if (instID.ToString().Length == 0)
            {
                error.Visible = true;
                error.Text = "Please enter a valid instructor ID ";
            }
            else
            {
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
        }
    }
}


