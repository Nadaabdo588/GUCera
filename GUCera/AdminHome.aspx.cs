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
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            int adminid = (int)Session["user"];
            if (courseId.Text.Length != 0)
            {
                int courseid = Int32.Parse(courseId.Text);
                SqlCommand accCourse = new SqlCommand("AdminAcceptRejectCourse", conn);
                accCourse.CommandType = CommandType.StoredProcedure;
                accCourse.Parameters.Add(new SqlParameter("@adminid", adminid));
                accCourse.Parameters.Add(new SqlParameter("@courseId", courseid));
                errmsg.Visible = false;

                conn.Open();
                accCourse.ExecuteNonQuery();
                conn.Close();
            }
            else
                errmsg.Visible = true;
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

                conn.Open();
                createPromo.ExecuteNonQuery();
                conn.Close();
            }
            else
                errmsg.Visible = true;



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
                conn.Open();
                issuePromo.ExecuteNonQuery();
                conn.Close();
            }
            else
                errmsg.Visible = true;
        }
    }
}