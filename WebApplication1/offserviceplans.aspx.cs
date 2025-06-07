using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace WebApplication1
{
    public partial class offserviceplans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string quer = "select * from allServicePlans";

            conn.Open();
            SqlDataAdapter serv = new SqlDataAdapter(quer, conn);
            DataTable dt = new DataTable();
            serv.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Label2.Visible = false;

                GridViewserviceplans.Visible = true;
                GridViewserviceplans.DataSource = dt;
                GridViewserviceplans.DataBind();
            }
            else
            {
                Label2.Text = "There is No Service Plans Offered.";
                Label2.Visible = true;
                GridViewserviceplans.Visible = false;


            }

            GridViewserviceplans.DataSource = dt;
            GridViewserviceplans.DataBind();
        }

        protected void backbutton_Click(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];

            Response.Redirect("customerhomepage.aspx?data=" + valueFromQueryhomepage);
        }
    }
}