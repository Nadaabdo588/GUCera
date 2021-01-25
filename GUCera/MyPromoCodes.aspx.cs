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
    public partial class MyPromoCodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = (int)Session["user"];
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewPromocode = new SqlCommand("viewPromocode", conn);
            viewPromocode.CommandType = CommandType.StoredProcedure;
            viewPromocode.Parameters.Add(new SqlParameter("@sid", id));

            conn.Open();
            SqlDataReader reader = viewPromocode.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                HtmlGenericControl card = new HtmlGenericControl("div");
                card.Attributes.Add("class", "card col");
                HtmlGenericControl cardbody = new HtmlGenericControl("div");
                cardbody.Attributes.Add("class", "card-body");



                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/bubbles/100/000000/transaction-list.png";

                Label code = new Label();
                code.CssClass = "Label2";
                code.Text = reader.GetString(reader.GetOrdinal("code"));

                Label issueDate = new Label();
                issueDate.CssClass = "Label2";
                DateTime dt2 = reader.GetDateTime(reader.GetOrdinal("isuueDate"));
                String x2 = dt2.ToString();
                issueDate.Text = x2;

                Label expiryDate = new Label();
                expiryDate.CssClass = "Label2";
                DateTime dt = reader.GetDateTime(reader.GetOrdinal("expiryDate"));
                String x = dt.ToString();
                expiryDate.Text = x;

                Label discount = new Label();
                discount.CssClass = "Label2";
                discount.Text = reader.GetDecimal(reader.GetOrdinal("discount")).ToString();

                Label adminId = new Label();
                adminId.CssClass = "Label2";
                adminId.Text = reader.GetInt32(reader.GetOrdinal("adminId")).ToString();

                Label c = new Label();
                c.CssClass = "Label1";

                Label i = new Label();
                i.CssClass = "Label1";

                Label ex = new Label();
                ex.CssClass = "Label1";

                Label d = new Label();
                d.CssClass = "Label1";

                Label a = new Label();
                a.CssClass = "Label1";

                c.Text = "Code : ";
                cardbody.Controls.Add(b);
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(c);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(code);

                i.Text = "Issue Date :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(i);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(issueDate);

                ex.Text = "Expiry date :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(ex);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(expiryDate);

                d.Text = "Discount :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(d);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(discount);

                a.Text = "Admin Id :";
                cardbody.Controls.Add(new LiteralControl("<br />"));
                cardbody.Controls.Add(a);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(adminId);
                card.Controls.Add(cardbody);
                PlaceHolder1.Controls.Add(card);

                // form1.Controls.Add(new LiteralControl("<hr />"));


            }


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
