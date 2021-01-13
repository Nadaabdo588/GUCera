    using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class NonAcceptedCourses : System.Web.UI.Page
    {
        StringBuilder sb = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand adminViewNonC = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            adminViewNonC.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = adminViewNonC.ExecuteReader(CommandBehavior.CloseConnection);
            sb.Append("<table border = '1'> ");
            sb.Append("<tr> <th> Course Name</th> <th> Credit Hours</th> <th> Price </th> <th> Content</th> </tr>");
            while (rdr.Read())
            {
                /*
                 creditHours, price, content, accepted
                 */
                String cN = rdr.GetString(rdr.GetOrdinal("name"));
                String cH = rdr.GetInt32(rdr.GetOrdinal("creditHours")).ToString();
                String p = rdr.GetDecimal(rdr.GetOrdinal("price")).ToString();
                String c = "";
                if (!rdr.IsDBNull(rdr.GetOrdinal("content")))
               
                    c = rdr.GetString(rdr.GetOrdinal("content"));
                
                String htmlLine = "<tr>" + "<th> " + cN + "</th>" + "<th> " + cH + "</th>" + "<th> " + p + "</th>" + "<th> " + c + "</th>" + "</tr>";
                sb.Append(htmlLine);
            }
            form1.Controls.Add(new Literal { Text = sb.ToString() });

        }
    }
}