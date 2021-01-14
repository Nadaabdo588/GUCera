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
    public partial class MyCreditCards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitC_Click(object sender, EventArgs e)
        {

            int id = (int)Session["user"];
            String number = Request.Form["cnn"];  
            String holderName = Request.Form["hname"];
            DateTime expirydate = DateTime.Parse(Request.Form["date"]);
            String cvvN = Request.Form["cvv"];
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand addCreditCard = new SqlCommand("addCreditCard", conn);
            addCreditCard.CommandType = CommandType.StoredProcedure;
            addCreditCard.Parameters.Add(new SqlParameter("@sid", id));
            addCreditCard.Parameters.Add(new SqlParameter("@number", number));
            addCreditCard.Parameters.Add(new SqlParameter("@cardHolderName", holderName));
            addCreditCard.Parameters.Add(new SqlParameter("@expiryDate", expirydate));
            addCreditCard.Parameters.Add(new SqlParameter("@cvv", cvvN));
            conn.Open();
            addCreditCard.ExecuteNonQuery();
            conn.Close();
            error.Visible = true;
            error.Text = "Card is added successfully";


        }
    }
}