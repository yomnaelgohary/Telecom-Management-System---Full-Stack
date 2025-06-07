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
    public partial class toppayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string mobilenumber = Request.QueryString["data"];

            SqlCommand topsuccessful = new SqlCommand("Top_Successful_Payments", conn);
            topsuccessful.CommandType = CommandType.StoredProcedure;

            topsuccessful.Parameters.Add(new SqlParameter("@mobile_num", mobilenumber));

            DataTable pay = new DataTable();

            conn.Open();
            SqlDataAdapter topadapter = new SqlDataAdapter(topsuccessful);
            topadapter.Fill(pay);
            conn.Close();


            GridViewtop.DataSource = pay;
            GridViewtop.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mobile);
        }
    }
}