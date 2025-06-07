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
    public partial class highestvoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand maxvouchervalue = new SqlCommand("Account_Highest_Voucher", conn);
            maxvouchervalue.CommandType = CommandType.StoredProcedure;

            maxvouchervalue.Parameters.AddWithValue("@mobile_num", mobile);

            DataTable maxvouxher = new DataTable();

            conn.Open();
            SqlDataAdapter vouadapter = new SqlDataAdapter(maxvouchervalue);
            vouadapter.Fill(maxvouxher);


            gridviewvoucher.DataSource = maxvouxher;
            gridviewvoucher.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mobile);
        }
    }
}