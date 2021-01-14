using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Student_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id =(int)(Session["user"]);

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewProfileProc = new SqlCommand("viewMyProfile", conn);
            viewProfileProc.CommandType = CommandType.StoredProcedure;
            viewProfileProc.Parameters.Add(new SqlParameter("@id", id));

            conn.Open();
            SqlDataReader reader = viewProfileProc.ExecuteReader(CommandBehavior.CloseConnection);
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
      
           if (reader.Read())
            {
                ID.Text = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                First_name.Text = reader.GetString(reader.GetOrdinal("firstName"));
                Last_name.Text = reader.GetString(reader.GetOrdinal("lastName"));
                Password.Text = reader.GetString(reader.GetOrdinal("password"));
                Email.Text = reader.GetString(reader.GetOrdinal("email"));
               // bool g =reader.GetBoolean(reader.GetOrdinal("gender"));
                byte[] g= (byte[])reader["gender"];
                String gender = "Male";
                if (g[0]==1)
                gender = "Female";
               Gender.Text = gender;
               Address.Text = reader.GetString(reader.GetOrdinal("address"));
               GPA.Text = reader.GetDecimal(reader.GetOrdinal("gpa")).ToString();
            }


        }

       
    }
}