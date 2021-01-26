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
    public partial class ManageOptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            adID.Text = "Admin ID: " + Session["user"];
            //    sucadd.Text= "<small class='text - muted'>Done</small>";
            sucadd.Visible = false;
            sucacc.Visible = false;
            suciss.Visible = false;
            succre.Visible = false;
            //          errmsg.Visible = false;


        }
        protected void acceptC(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                if (courseId.Text.Length != 0)
                {
                    int adminid = (int)Session["user"];
                    int courseid = Int32.Parse(courseId.Text);
                    int found = 0;
                    String query = "select * from course where id = " + courseid;
                    SqlCommand cour = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader rdr = cour.ExecuteReader();
                    if (rdr.Read())
                        found = 1;

                    conn.Close();

                    if (found == 1)
                    {
                        SqlCommand accCourse = new SqlCommand("AdminAcceptRejectCourse", conn);
                        accCourse.CommandType = CommandType.StoredProcedure;
                        accCourse.Parameters.Add(new SqlParameter("@adminid", adminid));
                        accCourse.Parameters.Add(new SqlParameter("@courseId", courseid));
                        //                errmsg.Visible = false;
                        sucacc.Text = "The course has been successfully accepted.";
                        sucacc.Visible = true;

                        conn.Open();
                        accCourse.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        sucacc.Text = "Course is not found.";
                        sucacc.Visible = true;
                    }
                }
                else
                {
                    sucacc.Text = "This field Can not be empty";
                    sucacc.Visible = true;
                }
            }
            catch (Exception ex)
            {
                sucacc.Text = "Invalid input";
                sucacc.Visible = true;
            }

            //errmsg.Visible = true;
        }

        protected void createP(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                if (pcode.Text.Length != 0 && expirydate.Text.Length != 0 & discount.Text.Length != 0)
                {
                    String code = pcode.Text;
                    DateTime expdate = DateTime.Parse(expirydate.Text);
                    float dis = float.Parse(discount.Text);
                    DateTime issDate = DateTime.Now;
                    int adminid = (int)Session["user"];
                    SqlCommand createPromo = new SqlCommand("AdminCreatePromocode", conn);
                    createPromo.CommandType = CommandType.StoredProcedure;
                    createPromo.Parameters.Add(new SqlParameter("@code", code));
                    createPromo.Parameters.Add(new SqlParameter("@isuueDate", issDate));
                    createPromo.Parameters.Add(new SqlParameter("@expiryDate", expdate));
                    createPromo.Parameters.Add(new SqlParameter("@discount", dis));
                    createPromo.Parameters.Add(new SqlParameter("@adminId", adminid));
                    // errmsg.Visible = false;
                    succre.Text = "A Promo code has been successfully created.";
                    succre.Visible = true;
                    conn.Open();
                    createPromo.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    succre.Text = "This field Can not be empty";
                    succre.Visible = true;
                }
            }
            catch (Exception ex)
            {
                succre.Text = "Invalid input";
                succre.Visible = true;
            }




        }
        protected void issue(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                if (pid.Text.Length != 0 && sid.Text.Length != 0)
                {
                    String code = pid.Text;
                    int studentid = Int32.Parse(sid.Text);
                    SqlCommand issuePromo = new SqlCommand("AdminIssuePromocodeToStudent", conn);
                    issuePromo.CommandType = CommandType.StoredProcedure;
                    issuePromo.Parameters.Add(new SqlParameter("@sid", studentid));
                    issuePromo.Parameters.Add(new SqlParameter("@pid", code));
                    // errmsg.Visible = false;
                    suciss.Text = "You have issued a promo code to a student.";
                    suciss.Visible = true;
                    conn.Open();
                    issuePromo.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    suciss.Text = "This field Can not be empty";
                    suciss.Visible = true;
                }
            }
            catch (Exception ex)
            {
                suciss.Text = "Invalid input";
                suciss.Visible = true;
            }

        }


        protected void addNo(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                if (mob.Text.Length != 0)
                {

                    String mNo = mob.Text;
                    int adminid = (int)Session["user"];
                    SqlCommand addMob = new SqlCommand("addMobile", conn);
                    addMob.CommandType = CommandType.StoredProcedure;
                    addMob.Parameters.Add(new SqlParameter("@ID", adminid));
                    addMob.Parameters.Add(new SqlParameter("@mobile_number", mNo));
                    //     errmsg.Visible = false;
                    sucadd.Text = "A telephone number has been successfully added.";
                    sucadd.Visible = true;
                    conn.Open();
                    addMob.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    sucadd.Text = "This field Can not be empty";
                    sucadd.Visible = true;
                }
            }
            catch (Exception ex)
            {
                sucadd.Text = "Invalid input";
                sucadd.Visible = true;
            }

        }
        protected void h_click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }


    }
}