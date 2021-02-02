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
            form2.Visible = false;
            form3.Visible = false;
        }

        protected void logIn_Click(object sender, EventArgs e)
        {
            try
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
                if (succ.Value.ToString() == "1")
                {
                    Session["user"] = id;

                    if (type.Value.ToString() == "0")
                    {

                        Response.Redirect("InstructorHome.aspx");

                    }
                    else if (type.Value.ToString() == "1")
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
            }catch(Exception ex)
            {
                error.Visible = true;
                error.Text = "Login failed";

            }


        }


        protected void MyFunction_Click(object sender, EventArgs e)
        {
            form1.Visible = false;
            form2.Visible = true;
        }
        protected void MyFunction2_Click(object sender, EventArgs e)
        {
            form1.Visible = false;
            form3.Visible = true;
        }
        protected void RegisterButtonI_Click(object sender, EventArgs e)
        {
            try
            {
                String firstname = Request.Form["firstnameText"];
                String lastname = Request.Form["lastnameText"];
                String password = Request.Form["passwordText"];
                String email = Request.Form["emailText"];
                String address = Request.Form["addressText"];
                String selected = Request.Form["GenderList"];
                int gender = 1;
                if (selected == "Female")
                    gender = 0;
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand instructorRegisterProc = new SqlCommand("instructorRegister", conn);
                instructorRegisterProc.CommandType = CommandType.StoredProcedure;
                instructorRegisterProc.Parameters.Add(new SqlParameter("@first_name", firstname));
                instructorRegisterProc.Parameters.Add(new SqlParameter("@last_name", lastname));
                instructorRegisterProc.Parameters.Add(new SqlParameter("@password", password));
                instructorRegisterProc.Parameters.Add(new SqlParameter("@email", email));
                instructorRegisterProc.Parameters.Add(new SqlParameter("@address", address));
                instructorRegisterProc.Parameters.Add(new SqlParameter("@gender", gender));

                conn.Open();
                instructorRegisterProc.ExecuteNonQuery();
                String query = "select max(id) from Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                int id = Int32.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                Session["user"] = id;
                Session["type"] = 0;
                Response.Redirect("LoadingPage.aspx");
            }
            catch (Exception ex)
            {
                Label2.Visible = true;
                Label2.Text = "Invalid data";
                form2.Visible = true;
            }

        }
        protected void RegisterButtonS_Click(object sender, EventArgs e)
        {
            try
            {
                String firstname = Request.Form["firstnameText"];
                String lastname = Request.Form["lastnameText"];
                String password = Request.Form["passwordText"];
                String email = Request.Form["emailText"];
                String address = Request.Form["addressText"];
                String selected = Request.Form["GenderList"];
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
            catch (Exception ex)
            {
                Label1.Visible = true;
                Label1.Text = "Invalid data";
                form3.Visible = true;
            }



        }

        protected void sigin_Click(object sender, EventArgs e)
        {
            form2.Visible = false;
            form3.Visible = false;
            form1.Visible = true;
        }
    }
}