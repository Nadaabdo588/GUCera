using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class viewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sid = (int)Session["user"];
            int cid = Int32.Parse(Request.QueryString["cid"]);
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewAssign = new SqlCommand("viewAssign", conn);
            viewAssign.CommandType = CommandType.StoredProcedure;
            viewAssign.Parameters.Add(new SqlParameter("@courseId", cid));
            viewAssign.Parameters.Add(new SqlParameter("@Sid", sid));

            conn.Open();
            SqlDataReader reader = viewAssign.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                HtmlGenericControl card = new HtmlGenericControl("div");
                card.Attributes.Add("class", "col card");
                HtmlGenericControl cardbody = new HtmlGenericControl("div");
                cardbody.Attributes.Add("class", "card-body");
                HtmlGenericControl cardfooter = new HtmlGenericControl("div");
                cardfooter.Attributes.Add("class", "card-footer");

                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/plasticine/100/000000/task.png";

                Label cid1 = new Label();
                cid1.CssClass = "Label2";
                cid1.Text = cid.ToString();

                Label number = new Label();
                number.CssClass = "Label2";
                number.Text = reader.GetInt32(reader.GetOrdinal("number")).ToString();

                Label type = new Label();
                type.CssClass = "Label2";
                type.Text = reader.GetString(reader.GetOrdinal("type"));

                Label fullGrade = new Label();
                fullGrade.CssClass = "Label2";
                fullGrade.Text = reader.GetInt32(reader.GetOrdinal("fullGrade")).ToString();

                Label weight = new Label();
                weight.CssClass = "Label2";
                weight.Text = reader.GetDecimal(reader.GetOrdinal("weight")).ToString();

                Label deadline = new Label();
                deadline.CssClass = "Label2";
                DateTime dt = reader.GetDateTime(reader.GetOrdinal("deadline"));
                String x = dt.ToString();
                deadline.Text = x;

                Label content = new Label();
                content.CssClass = "Label2";
                content.Text = reader.GetString(reader.GetOrdinal("content"));

                Label cid2 = new Label();
                cid2.CssClass = "Label1";

                Label n = new Label();
                n.CssClass = "Label1";

                Label t = new Label();
                t.CssClass = "Label1";

                Label f = new Label();
                f.CssClass = "Label1";

                Label w = new Label();
                w.CssClass = "Label1";

                Label d = new Label();
                d.CssClass = "Label1";

                Label c = new Label();
                c.CssClass = "Label1";

                cid2.Text = "CourseID : ";
                cardbody.Controls.Add(b);
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(cid2);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(cid1);

                n.Text = "Assignment Number :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(n);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(number);

                t.Text = "type :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(t);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(type);

                f.Text = "fullGrade :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(f);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(fullGrade);

                w.Text = "weight :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(w);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(weight);

                d.Text = "deadline :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(d);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(deadline);

                c.Text = "content :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(c);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(content);


                String query = "SELECT * FROM StudentTakeAssignment WHERE sid = '" + sid + "' And cid = '" + cid + "' And assignmentNumber = '" + reader.GetInt32(reader.GetOrdinal("number")) + "' And assignmenttype = '" + reader.GetString(reader.GetOrdinal("type")) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader1 = cmd.ExecuteReader();
                if (!reader1.Read())
                {
                    Button submitAssign = new Button();
                    submitAssign.CssClass = "Curved1";
                    submitAssign.Text = "Submit " + type.Text + "";
                    submitAssign.Click += submitAssign_Click;
                    submitAssign.AccessKey = number.Text;
                    cardfooter.Controls.Add(submitAssign);
                }
                else
                {
                    Label tb = new Label();
                    tb.CssClass = "Label1";
                    tb.Text = "Submitted Sucessfully";
                    cardfooter.Controls.Add(tb);
                }
                card.Controls.Add(cardbody);
                card.Controls.Add(cardfooter);
                PlaceHolder1.Controls.Add(card);

            }
        }

        private void submitAssign_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int sid = (int)Session["user"];
            int cid = Int32.Parse(Request.QueryString["cid"]);
            Button b = (Button)sender;

            SqlCommand submitAssign = new SqlCommand("submitAssign", conn);
            submitAssign.CommandType = CommandType.StoredProcedure;
            submitAssign.Parameters.Add(new SqlParameter("@assignType", b.Text.Substring(7)));
            submitAssign.Parameters.Add(new SqlParameter("@assignnumber", Int32.Parse(b.AccessKey)));
            submitAssign.Parameters.Add(new SqlParameter("@sid", sid));
            submitAssign.Parameters.Add(new SqlParameter("@cid", cid));

            conn.Open();
            submitAssign.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("ViewAssignments.aspx?cid=" + cid);
        }
        protected void h_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx");

        }


        protected void p_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");

        }

        protected void c_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCourses.aspx");

        }

        protected void pc_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyPromoCodes.aspx");

        }
        protected void cer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListCertificates.aspx");
        }
    }
}