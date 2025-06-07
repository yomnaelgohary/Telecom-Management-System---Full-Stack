using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace WebApplication1
{
    public partial class admin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void v2_Click1(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string query = "SELECT * FROM allCustomerAccounts";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label1.Text = "";
            }
            else
            {
                Label1.Text = "No records found ";
                Label1.ForeColor = System.Drawing.Color.Red;
            }


        }

        protected void v3_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string query = "SELECT * FROM PhysicalStoreVouchers";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                GridView2.DataSource = dt;
                GridView2.DataBind();
                Label1.Text = "";
            }
            else
            {
                Label1.Text = "No records found ";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void v4_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string query = "SELECT * FROM allResolvedTickets";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                GridView3.DataSource = dt;
                GridView3.DataBind();
                Label1.Text = "";
            }
            else
            {
                Label1.Text = "No records found ";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void p5_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand("Account_Plan", conn);
            command.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(reader);


            if (dt.Rows.Count > 0)
            {
                GridView4.DataSource = dt;
                GridView4.DataBind();
                Label1.Text = "";
            }
            else
            {
                Label1.Text = "No records found ";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void f6_Click(object sender, EventArgs e)
        {
            Response.Redirect("List all customer accounts.aspx");
        }

        protected void f7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Show the total usage.aspx");
        }

        protected void p8_Click(object sender, EventArgs e)
        {
            Response.Redirect("removeallbenefits.aspx");
        }
        protected void p9_Click(object sender, EventArgs e)
        {
            Response.Redirect("SMSoffers.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin2.aspx");
        }
    }
}