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
    public partial class MyCreditCards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitC_Click(object sender, EventArgs e)
        {
            //int id = Int32.Parse(Request.QueryString["id"]);
            int id = 1;
            String number = ccn.Text;  
            if (number.Length == 0)
            {
                error.Visible = true;
                error.Text = "You should enter your credit card number";
                return;
            }
            String holderName = hname.Text;
            DateTime expirydate = DateTime.Parse(date.Text);
            String cvvN = cvv.Text;
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
            error.Visible = true;
            error.Text = "Credit card is added successfully";
            conn.Close();


        }
    }
}