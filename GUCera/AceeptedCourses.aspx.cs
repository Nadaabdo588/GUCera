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
    public partial class AceeptedCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewProfileProc = new SqlCommand("availableCourses", conn);
            viewProfileProc.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = viewProfileProc.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                //ImageButton b = new ImageButton();
                ImageButton b = new ImageButton();
                b.ImageUrl = "https://img.icons8.com/bubbles/100/000000/book-reading.png";
                Label name = new Label();
                name.CssClass = "Label1";
                name.Text = reader.GetString(reader.GetOrdinal("name"));
              //  b.ID = reader.GetInt32(reader.GetOrdinal("id")).ToString();
              //  b.Click += new ImageClickEventHandler(this.MyClickEvent);
                form1.Controls.Add(b);
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(name);
                form1.Controls.Add(new LiteralControl("<br />"));



            }
        }
       protected void MyClickEvent(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("courseInformation", conn);
            courses.CommandType = CommandType.StoredProcedure;
            int cid = Int32.Parse((sender as Button).ID);
            courses.Parameters.Add(new SqlParameter("@id", cid));

            conn.Open();
            SqlDataReader reader = courses.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                Response.Redirect("CourseInfo.aspx?id" + cid);
            }
        }
    }
}