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
                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/bubbles/100/000000/transaction-list.png";

                Label code = new Label();
                code.CssClass = "Label2";
                code.Text = reader.GetString(reader.GetOrdinal("code"));

                Label issueDate = new Label();
                issueDate.CssClass = "Label2";
                // issueDate.Text = reader.GetDateTime(reader.GetOrdinal("issueDate")).ToString();

                Label expiryDate = new Label();
                expiryDate.CssClass = "Label2";
                // expiryDate.Text = reader.GetDateTime(reader.GetOrdinal("expiryDate")).ToString();

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
                form1.Controls.Add(b);
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(c);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(code);

                i.Text = "Issue Date :";
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(i);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                //  form1.Controls.Add(issueDate);

                ex.Text = "Expiry date :";
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(ex);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                //form1.Controls.Add(expiryDate);

                d.Text = "Discount :";
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(d);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(discount);

                a.Text = "Admin Id :";
                form1.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(a);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(adminId);

                form1.Controls.Add(new LiteralControl("<hr />"));


                    

            }
        }
    }
}