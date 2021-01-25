using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AceeptedCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int sid = (int)(Session["user"]);
            String query = "select c.id,c.name,c.creditHours,c.price from Course c where accepted=1 and( c.id not in (select st.cid from StudentTakeCourse st where st.sid =" + sid+"))";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader2 = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader2.Read())
            {
                //ImageButton b = new ImageButton();
                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/bubbles/100/000000/book-reading.png";

                String cname = reader2.GetString(reader2.GetOrdinal("name"));
                HtmlGenericControl card = new HtmlGenericControl("div");
                card.Attributes.Add("class", "col card");
                HtmlGenericControl cardbody = new HtmlGenericControl("div");
                cardbody.Attributes.Add("class", "card-body");
                HtmlGenericControl cardfooter = new HtmlGenericControl("div");
                cardfooter.Attributes.Add("class", "card-footer");
                int id = reader2.GetInt32(reader2.GetOrdinal("id"));
                cardbody.ID = id.ToString() + "mydiv";

                int credit = reader2.GetInt32(reader2.GetOrdinal("creditHours"));
                decimal price = reader2.GetDecimal(reader2.GetOrdinal("price"));
                Label nameValue = new Label();
                nameValue.CssClass = "Label2";
                nameValue.Text = cname;

                Label creditValue = new Label();
                creditValue.CssClass = "Label2";
                creditValue.Text = credit.ToString();

                Label priceValue = new Label();
                priceValue.CssClass = "Label2";
                priceValue.Text = price.ToString();

                Label nameLabel = new Label();
                nameLabel.CssClass = "Label1";
                nameLabel.Text = "Course Name :";

                Label creditLabel = new Label();
                creditLabel.CssClass = "Label1";
                creditLabel.Text = "Credit hours :";

                Label priceLabel = new Label();
                priceLabel.CssClass = "Label1";
                priceLabel.Text = "Price :";

                Button enroll = new Button();
                enroll.CssClass = "Curved1";
                enroll.Text = "Enroll";
                enroll.Click += enroll_Click;
                enroll.ID = id.ToString();

                cardbody.Controls.Add(b);
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(nameLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(nameValue);
                cardbody.Controls.Add(new LiteralControl("<br />"));

                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(creditLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(creditValue);
                cardbody.Controls.Add(new LiteralControl("<br />"));

                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(priceLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(priceValue);
                cardbody.Controls.Add(new LiteralControl("<br />"));

                cardfooter.Controls.Add(enroll);
                card.Controls.Add(cardbody);
                card.Controls.Add(cardfooter);
                PlaceHolder1.Controls.Add(card);

            }
        }         
        
        protected void enroll_Click(object sender, EventArgs e)
        {

            Response.Redirect("EnrollPage.aspx?cid="+((Button)sender).ID);
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