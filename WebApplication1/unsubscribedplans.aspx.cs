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
    public partial class unsubscribedplans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];

            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand unsubscribed = new SqlCommand("Unsubscribed_Plans", conn);
            unsubscribed.CommandType = CommandType.StoredProcedure;

            unsubscribed.Parameters.Add(new SqlParameter("@mobile_num", valueFromQueryhomepage));

            DataTable sub = new DataTable();

            conn.Open();
            SqlDataAdapter unsubadapter = new SqlDataAdapter(unsubscribed);
            unsubadapter.Fill(sub);
            conn.Close();


            if (sub.Rows.Count > 0)
            {
                Label2.Visible = false;

                grid.Visible = true;
                grid.DataSource = sub;
                grid.DataBind();
            }
            else
            {
                Label2.Text = "You Are Subscribed To All The Company Offered Plans.";
                Label2.Visible = true;
                grid.Visible = false;


            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];

            Response.Redirect("customerhomepage.aspx?data=" + valueFromQueryhomepage);
        }
    }
}