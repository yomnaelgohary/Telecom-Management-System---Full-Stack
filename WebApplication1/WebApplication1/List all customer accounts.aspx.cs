using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class plandate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string idb = planidb.Text;
            DateTime dateb;
            int planId;
            if (string.IsNullOrEmpty(idb) && string.IsNullOrEmpty(subdateb.Text))
            {
                Label4.Text = "Please enter both a valid plan ID and a subscription date.";
                Label4.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;  
                GridView1.DataBind();
                return;
            }

            if (!int.TryParse(idb, out planId))
            {
                Label4.Text = "Please enter a valid plan ID.";
                Label4.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;
                GridView1.DataBind();
                return;
            }

            if (!DateTime.TryParse(subdateb.Text, out dateb))
            {
                Label4.Text = "Please enter a valid subscription date.";
                Label4.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;
                GridView1.DataBind();
                return;
            }

            if (DateTime.TryParse(subdateb.Text, out dateb))
            {

                String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                string query = "SELECT * FROM dbo.Account_Plan_date(@sub_date, @plan_id)";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@sub_date", dateb);  
                command.Parameters.AddWithValue("@plan_id", Convert.ToInt32(idb));

                conn.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Label4.Text = "";
                }
                else
                {
                    Label4.Text = "No record found for the given plan ID and subscription date.";
                    Label4.ForeColor = System.Drawing.Color.Red;
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                }
            }

            

        }    
    }
}