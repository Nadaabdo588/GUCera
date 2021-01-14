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
    public partial class TelephoneNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
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
    }
}