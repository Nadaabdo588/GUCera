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
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errmsg.Visible = false;
            sucadd.Visible = false;
            succer.Visible = false;
            sucacc.Visible = false;
            suciss.Visible = false;
        }

        protected void viewC_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewdCourses.aspx");

        }

        protected void notacceptedC_Click(object sender, EventArgs e)
        {
            Response.Redirect("NonAcceptedCourses.aspx");
        }

        protected void acceptC(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
            if (courseId.Text.Length != 0)
            {
                int adminid = (int)Session["user"];
                int courseid = Int32.Parse(courseId.Text);
                SqlCommand accCourse = new SqlCommand("AdminAcceptRejectCourse", conn);
                accCourse.CommandType = CommandType.StoredProcedure;
                accCourse.Parameters.Add(new SqlParameter("@adminid", adminid));
                accCourse.Parameters.Add(new SqlParameter("@courseId", courseid));
                errmsg.Visible = false;
                sucacc.Visible = true;
                conn.Open();
                accCourse.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                errmsg.Text = "Course ID field cannot be empty";
                errmsg.Visible = true;
            }
        }

        protected void createP(object sender, EventArgs e)
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
                errmsg.Visible = false;
                succer.Visible = true;
                conn.Open();
                createPromo.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                errmsg.Text = "Promo code fields cannot be empty";
                errmsg.Visible = true;
            }


        }
        protected void issue(object sender, EventArgs e)
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
                errmsg.Visible = false;
                suciss.Visible = true;
                conn.Open();
                issuePromo.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                errmsg.Text = "You should specify the student id and the promo code";
                errmsg.Visible = true;
            }
        }

    
        protected void addNo_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (mob.Text.Length!=0)
            {
                String mNo = mob.Text;
                int adminid = (int)Session["user"];
                String s = adminid.ToString();
                SqlCommand addMob = new SqlCommand("addMobile", conn);
                addMob.CommandType = CommandType.StoredProcedure;
                addMob.Parameters.Add(new SqlParameter("@ID", s));
                addMob.Parameters.Add(new SqlParameter("@mobile_number", mNo));
                errmsg.Visible = false;
                sucadd.Visible = true;
                conn.Open();
                addMob.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                errmsg.Text = "Telephone number field cannot be empty";
                errmsg.Visible = true;
            }
        }
    }
}