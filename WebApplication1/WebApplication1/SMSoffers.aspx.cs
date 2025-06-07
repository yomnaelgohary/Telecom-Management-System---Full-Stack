using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace WebApplication1
{
    public partial class sms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mobileno = mobileb.Text;
            if (string.IsNullOrEmpty(mobileno))
            {
                Label3.Text = "Please enter a valid mobile number.";
                Label3.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;  
                GridView1.DataBind();
                return;
            }
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string query = "SELECT * FROM dbo.Account_SMS_Offers(@mobile_num)";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@mobile_num", mobileno);


            conn.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(reader);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label3.Text = "";
            }
            else
            {
                Label3.Text = "No record found for the given mobile number.";
                Label3.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;  // Set the data source to null
                GridView1.DataBind();
            }
        }
    }
}