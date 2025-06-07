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
    public partial class thismonthusage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];
           

            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String q3 = "SELECT * FROM dbo.Usage_Plan_CurrentMonth(@mobile_num)";
            using (SqlCommand usagemon = new SqlCommand(q3, conn))
            {
                usagemon.CommandType = CommandType.Text;
                usagemon.Parameters.AddWithValue("@mobile_num", valueFromQueryhomepage);

                SqlDataAdapter adaptusage = new SqlDataAdapter(usagemon);
                DataTable dtusage = new DataTable();
                conn.Open();
                adaptusage.Fill(dtusage);

                if (dtusage.Rows.Count > 0)
                {
                    Label1.Visible = false;

                    grid.Visible = true;
                    grid.DataSource = dtusage;
                    grid.DataBind();
                }
                else
                {
                    Label1.Text = "No Active Plans Found In This Month.";
                    Label1.Visible = true;
                    grid.Visible = false;


                }

            }
        }
        protected void BackButton_Click(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + valueFromQueryhomepage);
        }
    }
}