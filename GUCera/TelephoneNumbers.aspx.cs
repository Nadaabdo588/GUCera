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
           
            if((int)Session["number"]==1)
            {
                error.Visible = true;
                error.Text = "Number is added Successfully";
                Session["number"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String number = numberText.Text;
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand addMobileProc = new SqlCommand("addMobile", conn);
            addMobileProc.CommandType = CommandType.StoredProcedure;
            addMobileProc.Parameters.Add(new SqlParameter("@ID",(int )Session["user"]));
            addMobileProc.Parameters.Add(new SqlParameter("@mobile_number", number));

            conn.Open();
            addMobileProc.ExecuteNonQuery();
            conn.Close();
            Session["number"] = 1;
            Response.Redirect("TelephoneNumbers.aspx");
        }
    }
}