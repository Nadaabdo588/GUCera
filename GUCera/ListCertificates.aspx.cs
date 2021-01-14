﻿using System;
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
    public partial class ListCertificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sid = (int)Session["user"];
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewCertificate = new SqlCommand("viewCertificate", conn);
            viewCertificate.CommandType = CommandType.StoredProcedure;
            viewCertificate.Parameters.Add(new SqlParameter("@sid", sid));

            conn.Open();
            String query = "select * from studentCertifyCourse where sid='" + sid + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Image b = new Image();
                b.ImageUrl = "https://img.icons8.com/doodle/48/000000/certificate.png";

                viewCertificate.Parameters.Add(new SqlParameter("@cid", reader.GetInt32(reader.GetOrdinal("cid"))));
                SqlDataReader reader1 = viewCertificate.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader1.Read())
                {
                    Label sid1 = new Label();
                    sid1.CssClass = "Label2";
                    sid1.Text = reader.GetInt32(reader.GetOrdinal("sid")).ToString();

                    Label cid1 = new Label();
                    cid1.CssClass = "Label2";
                    cid1.Text = reader.GetInt32(reader.GetOrdinal("cid")).ToString();

                    Label issueDate1 = new Label();
                    issueDate1.CssClass = "Label2";
                    DateTime dt1 = reader.GetDateTime(reader.GetOrdinal("issueDate"));
                    String x1 = dt1.ToString();
                    issueDate1.Text = x1;

                    Label c = new Label();
                    c.CssClass = "Label1";

                    Label i = new Label();
                    i.CssClass = "Label1";

                    Label s = new Label();
                    s.CssClass = "Label1";

                    c.Text = "Course ID : ";
                    form1.Controls.Add(b);
                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(c);
                    form1.Controls.Add(new LiteralControl("&nbsp"));
                    form1.Controls.Add(cid1);

                    i.Text = "Issue Date :";
                    form1.Controls.Add(new LiteralControl("<br />"));
                    form1.Controls.Add(i);
                    form1.Controls.Add(new LiteralControl("&nbsp"));
                    form1.Controls.Add(issueDate1);

                }

                form1.Controls.Add(new LiteralControl("<hr />"));
            }
        }
    }
}