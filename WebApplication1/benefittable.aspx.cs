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
    public partial class benefittable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string quer = "select * from allBenefits";

            conn.Open();
            SqlDataAdapter ben = new SqlDataAdapter(quer, conn);
            DataTable dt = new DataTable();
            ben.Fill(dt);

            GridViewbenifits.DataSource = dt;
            GridViewbenifits.DataBind();
        }

        protected void backbutton_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mobile);
        }
    }
}