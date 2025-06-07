using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Usage_Plan7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mobileno = mobileb.Text;
            DateTime startdate;

            if (string.IsNullOrEmpty(mobileno) && !DateTime.TryParse(startb.Text, out startdate))
            {
                Label3.Text = "Please enter both a valid mobile number and a subscription date.";
                Label3.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;
                GridView1.DataBind();
                return;
            }
            long number;
            if(!long.TryParse(mobileno, out number)&& !DateTime.TryParse(startb.Text, out startdate))
            {
                Label3.Text = "Please enter both a valid mobile number and a subscription date.";
                Label3.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;
                GridView1.DataBind();
                return;
            }
            if (string.IsNullOrEmpty(mobileno)|| !long.TryParse(mobileno, out number))
            {
                Label3.Text = "Please enter a valid mobile number.";
                Label3.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;
                GridView1.DataBind();
                return;
            }

            if (!DateTime.TryParse(startb.Text, out startdate))
            {
                Label3.Text = "Please enter a valid subscription date.";
                Label3.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;
                GridView1.DataBind();
                return;
            }
            // Try to parse the input from the TextBox as a valid DateTime
            if (DateTime.TryParse(startb.Text, out startdate))
            {

                String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                string query = "SELECT * FROM dbo.Account_Usage_Plan(@mobile_num, @start_date)";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@mobile_num", mobileno);
                command.Parameters.AddWithValue("@start_date", startdate);  
                

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
                    Label3.Text = "No record found for the given mobile number and subscription date.";
                    Label3.ForeColor = System.Drawing.Color.Red;
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                }
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin1.aspx");
        }
    }
}