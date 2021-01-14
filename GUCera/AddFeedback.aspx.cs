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
    public partial class AddFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["feedback"] == 1)
            {


                error.Visible = true;
                error.Text = "feedback added Successfully";
                Session["feedback"] = 0;
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int id = (int)Session["user"];
            int course = Int32.Parse(courseID.Text);
            String comment1 = comment.Text;

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand addFeedback = new SqlCommand("addFeedback", conn);
            addFeedback.CommandType = CommandType.StoredProcedure;
            addFeedback.Parameters.Add(new SqlParameter("@comment", comment1));
            addFeedback.Parameters.Add(new SqlParameter("@cid", course));
            addFeedback.Parameters.Add(new SqlParameter("@sid", id));

            conn.Open();
            addFeedback.ExecuteNonQuery();
            conn.Close();
            Session["feedback"] = 1;
            Response.Redirect("AddFeedback.aspx");

        }
    }
}