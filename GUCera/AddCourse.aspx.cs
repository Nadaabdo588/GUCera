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
        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Session["user"];
                String name = Request.Form["nameText"];

                int hours = Int32.Parse(Request.Form["hoursText"]);
                double price = double.Parse(Request.Form["PriceText"]);
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

                String query = "select max(id) from Course";
                SqlCommand cmd = new SqlCommand(query, conn);
                int cid = Int32.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();

                error.Visible = true;
                error.Text = "Course added Successfully with id = " + cid;

            }
            catch (Exception er)
            {
                error.Visible = true;
                error.Text = "an error has occured";
            }

        }




        protected void h_Click(object sender, EventArgs e)
        {


            Response.Redirect("InstructorHome.aspx");

        }



        protected void as_Click(object sender, EventArgs e)
        {
            Session["request"] = 1;

            Response.Redirect("ChooseCourse.aspx?req=1");


        }

        protected void fd_Click(object sender, EventArgs e)
        {

            Session["request"] = 0;
            Response.Redirect("ChooseCourse.aspx?req=0");

        }

    }
}