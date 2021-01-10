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
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["course"] == 1)
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                String query = "select max(id) from Course";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int id = Int32.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();

                error.Visible = true;
                error.Text = "Course added Successfully with id = "+id;
                Session["course"] = 0;
            }
        }

        protected void submitC_Click(object sender, EventArgs e)
        {

            int id = (int)Session["user"];
            String name = nameText.Text;
           
            int hours = Int32.Parse(hoursText.Text);
            double price = double.Parse(PriceText.Text);
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand addCourse = new SqlCommand("InstAddCourse", conn);
            addCourse.CommandType = CommandType.StoredProcedure;
            addCourse.Parameters.Add(new SqlParameter("@creditHours", hours));
            addCourse.Parameters.Add(new SqlParameter("@name", name));
            addCourse.Parameters.Add(new SqlParameter("@price", price));
            addCourse.Parameters.Add(new SqlParameter("@instructorId", id));
            conn.Open();
            addCourse.ExecuteNonQuery();
            conn.Close();
            Session["course"] = 1;
            Response.Redirect("AddCourse.aspx");

        }
    }
}