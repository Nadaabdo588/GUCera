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
    public partial class Telephone2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String number = Request.Form["numberText"];


                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand addMobileProc = new SqlCommand("addMobile", conn);
                addMobileProc.CommandType = CommandType.StoredProcedure;
                addMobileProc.Parameters.Add(new SqlParameter("@ID", (int)Session["user"]));
                addMobileProc.Parameters.Add(new SqlParameter("@mobile_number", number));

                conn.Open();
                addMobileProc.ExecuteNonQuery();
                error.Visible = true;
                error.Text = "Number is added Successfully";
                conn.Close();
            }
            catch (Exception ex)
            {
                error.Visible = true;
                error.Text = "Invalid data entered by the user";
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