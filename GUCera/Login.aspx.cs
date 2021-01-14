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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["number"] = 0;
            Session["card"] = 0;
        }

        protected void logIn_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int32.Parse(Request.Form["usernameText"]);
            String pass = Request.Form["passwordText"];

            Console.Write(pass);
            SqlCommand userLoginProc = new SqlCommand("userLogin", conn);
            userLoginProc.CommandType = CommandType.StoredProcedure;
            userLoginProc.Parameters.Add(new SqlParameter("@id", id));
            userLoginProc.Parameters.Add(new SqlParameter("@password", pass));

            SqlParameter succ = userLoginProc.Parameters.Add(new SqlParameter("@success", SqlDbType.Int));
            SqlParameter type = userLoginProc.Parameters.Add(new SqlParameter("@type", SqlDbType.Int));

            succ.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;

            conn.Open();
            userLoginProc.ExecuteNonQuery();
            conn.Close();
            if(succ.Value.ToString()=="1")
            {        
                Session["user"] = id;

                if(type.Value.ToString()=="0")
                {
                   
                    Response.Redirect("InstructorHome.aspx");

                }else if(type.Value.ToString()=="1")
                {
                    Session["user"] = id;
                    Response.Redirect("AdminHome.aspx");

                }
                else
                {
                    Response.Redirect("StudentHome.aspx");
                }

            }
           else
            {
                error.Visible = true;
                error.Text = "Login failed";
            }


        }
    }
}