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
                HtmlGenericControl card = new HtmlGenericControl("div");
                card.Attributes.Add("class", "card col");
                HtmlGenericControl cardbody = new HtmlGenericControl("div");
                cardbody.Attributes.Add("class", "card-body");
                Image i = new Image();
                i.ImageUrl = "https://img.icons8.com/clouds/100/000000/comments.png";

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

                cardbody.Controls.Add(i);
                cardbody.Controls.Add(new LiteralControl("<br>"));


                cardbody.Controls.Add(numberLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(numberValue);
                cardbody.Controls.Add(new LiteralControl("<br>"));

                cardbody.Controls.Add(new LiteralControl("<br>"));
                cardbody.Controls.Add(commentLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(commentValue);
                cardbody.Controls.Add(new LiteralControl("<br>"));

                cardbody.Controls.Add(new LiteralControl("<br>"));
                cardbody.Controls.Add(likesLabel);
                cardbody.Controls.Add(new LiteralControl("&nbsp"));
                cardbody.Controls.Add(likesValue);

                card.Controls.Add(cardbody);
                PlaceHolder1.Controls.Add(card);

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