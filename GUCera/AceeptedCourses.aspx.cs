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
            SqlDataReader reader = viewProfileProc.ExecuteReader();
            while (reader.Read())
            {
                //ImageButton b = new ImageButton();
                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/bubbles/100/000000/book-reading.png";

                String cname = reader.GetString(reader.GetOrdinal("name"));
                String query = "select id,creditHours,price from Course where name='"+cname+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader2 = cmd.ExecuteReader();
                if(reader2.Read())
                {
                    int id = reader2.GetInt32(reader2.GetOrdinal("id"));
                    int credit= reader2.GetInt32(reader2.GetOrdinal("creditHours"));
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

                    form1.Controls.Add(b);
                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(nameLabel);
                    form1.Controls.Add(new LiteralControl("&nbsp"));
                    form1.Controls.Add(nameValue);
                    form1.Controls.Add(new LiteralControl("<br />"));

                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(creditLabel);
                    form1.Controls.Add(new LiteralControl("&nbsp"));
                    form1.Controls.Add(creditValue);
                    form1.Controls.Add(new LiteralControl("<br />"));

                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(priceLabel);
                    form1.Controls.Add(new LiteralControl("&nbsp"));
                    form1.Controls.Add(priceValue);
                    form1.Controls.Add(new LiteralControl("<br />"));

                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(enroll);
                    form1.Controls.Add(new LiteralControl("<br />"));
                    reader2.Close();

                }

            }reader.Close();
        }
        protected void enroll_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewProfileProc = new SqlCommand("availableCourses", conn);
            viewProfileProc.CommandType = CommandType.StoredProcedure;

        }
    
        
    }
}