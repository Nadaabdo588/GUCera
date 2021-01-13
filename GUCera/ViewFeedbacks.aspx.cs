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
    public partial class View_Feedbacks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int instid = (int)(Session["user"]);
            int cid = (int)(Session["course"]);

            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand viewFeedbacks = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
            viewFeedbacks.CommandType = CommandType.StoredProcedure;
            viewFeedbacks.Parameters.Add("@instrId", instid);
            viewFeedbacks.Parameters.Add("@cid", cid);

            conn.Open();
            SqlDataReader reader = viewFeedbacks.ExecuteReader();

            while (reader.Read())
            {
                Image i = new Image();
                i.ImageUrl = "https://img.icons8.com/bubbles/100/000000/speech-bubble.png";


                int number = reader.GetInt32(reader.GetOrdinal("number"));
               
                int myOrdinal = reader.GetOrdinal("comment");
                String comment = "";
                
                if (!reader.IsDBNull(myOrdinal))
                {
                    comment = reader.GetString(reader.GetOrdinal("comment"));
                }

                int likes = reader.GetInt32(reader.GetOrdinal("numberOfLikes"));


                Label numberValue = new Label();
                numberValue.Text = number.ToString();
                numberValue.CssClass = "Label2";

                Label commentValue = new Label();
                commentValue.Text = comment;
                commentValue.CssClass = "Label2";

                Label likesValue = new Label();
                likesValue.Text = likes.ToString();
                likesValue.CssClass = "Label2";



                Label numberLabel = new Label();
                numberLabel.Text = "Feedback ID :";
                numberLabel.CssClass = "Label1";

                Label commentLabel = new Label();
                commentLabel.Text = "Comment :";
                commentLabel.CssClass = "Label1";

                Label likesLabel = new Label();
                likesLabel.Text = "number of likes :";
                likesLabel.CssClass = "Label1";

                form1.Controls.Add(i);
                form1.Controls.Add(new LiteralControl("<br>"));


                form1.Controls.Add(numberLabel);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(numberValue);
                form1.Controls.Add(new LiteralControl("<br>"));

                form1.Controls.Add(new LiteralControl("<br>"));
                form1.Controls.Add(commentLabel);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(commentValue);
                form1.Controls.Add(new LiteralControl("<br>"));

                form1.Controls.Add(new LiteralControl("<br>"));
                form1.Controls.Add(likesLabel);
                form1.Controls.Add(new LiteralControl("&nbsp"));
                form1.Controls.Add(likesValue);
                form1.Controls.Add(new LiteralControl("<br>"));


            }


        }

    }
}