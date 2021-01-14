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
    public partial class MyAsignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int sid = (int)Session["user"];
            int cid = Int32.Parse(Request.QueryString["cid"].Substring(0,Request.QueryString["cid"].Length-1));

            conn.Open();
            String query = "SELECT assignmentNumber,assignmenttype FROM StudentTakeAssignment WHERE sid = '" + sid + "' And cid = '"+ cid +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/plasticine/100/000000/task.png";

                Label cid1 = new Label();
                cid1.CssClass = "Label2";
                cid1.Text = cid.ToString();

                Label number = new Label();
                number.CssClass = "Label2";
                number.Text = reader.GetInt32(reader.GetOrdinal("assignmentNumber")).ToString();

                Label type = new Label();
                type.CssClass = "Label2";
                type.Text = reader.GetString(reader.GetOrdinal("assignmenttype"));

                Label c = new Label();
                c.CssClass = "Label1";

                Label n = new Label();
                n.CssClass = "Label1";

                Label t = new Label();
                t.CssClass = "Label1";

                c.Text = "CourseID : ";
                form1.Controls.Add(b);
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(c);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(cid1);

                n.Text = "Assignment Number :";
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(n);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(number);

                t.Text = "Type :";
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(t);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(type);
                form1.Controls.Add(new LiteralControl("<br />"));
                   
                SqlCommand viewAssignGrades = new SqlCommand("viewAssignGrades", conn);
                viewAssignGrades.CommandType = CommandType.StoredProcedure;
                viewAssignGrades.Parameters.Add(new SqlParameter("@assignnumber", reader.GetInt32(reader.GetOrdinal("assignmentNumber"))));
                viewAssignGrades.Parameters.Add(new SqlParameter("@assignType", reader.GetString(reader.GetOrdinal("assignmenttype"))));
                viewAssignGrades.Parameters.Add(new SqlParameter("@sid", sid));
                viewAssignGrades.Parameters.Add(new SqlParameter("@cid", cid));

                SqlParameter assignGrade = new SqlParameter();
                assignGrade.ParameterName = "@assignGrade";
                assignGrade.DbType = DbType.Int32;
                assignGrade.Direction = ParameterDirection.Output;
                viewAssignGrades.Parameters.Add(assignGrade);
                viewAssignGrades.ExecuteNonQuery();
                String Text = "Grade : '" + viewAssignGrades.Parameters["@assignGrade"].Value.ToString() + "'";
                if (Text.Equals("Grade : ''"))
                {
                    Text = "No Grade Yet";
                }
                Label g = new Label();
                g.CssClass = "Label1";
                g.Text = Text;
                form1.Controls.Add(g);
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(new LiteralControl("<hr />"));
            }
            conn.Close();
        }
    }
}