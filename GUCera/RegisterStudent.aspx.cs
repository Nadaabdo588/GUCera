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
    public partial class RegisterStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            String firstname = firstnameText.Text;
            String lastname = lastnameText.Text;
            String password = passwordText.Text;
            String email = emailText.Text;
            String address = addressText.Text;
            String selected = genderList.SelectedValue.ToString();
            int gender = 0;
            if (selected == "Female")
                gender = 1;
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand studentRegisterProc = new SqlCommand("studentRegister", conn);
            studentRegisterProc.CommandType = CommandType.StoredProcedure;
            studentRegisterProc.Parameters.Add(new SqlParameter("@first_name", firstname));
            studentRegisterProc.Parameters.Add(new SqlParameter("@last_name", lastname));
            studentRegisterProc.Parameters.Add(new SqlParameter("@password", password));
            studentRegisterProc.Parameters.Add(new SqlParameter("@email", email));
            studentRegisterProc.Parameters.Add(new SqlParameter("@address", address));
            studentRegisterProc.Parameters.Add(new SqlParameter("@gender", gender));


            conn.Open();
            studentRegisterProc.ExecuteNonQuery();
            String query = "select max(id) from Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            int id = Int32.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            Session["user"] = id;
            Session["type"] = 2;
            Response.Redirect("LoadingPage.aspx");

            


        }
    }
}