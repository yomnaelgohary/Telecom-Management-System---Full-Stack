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
    public partial class consumption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Any code to run on initial page load
            }

        }

        protected void Showbutton_Click1(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(plan.Text)) || (string.IsNullOrEmpty(start.Text)) || (string.IsNullOrEmpty(end.Text)) || !(DateTime.TryParse(start.Text, out _)) ||
                !(DateTime.TryParse(end.Text, out _)))
            {


                Exceplabel3.Text = "You Must Enter A PlanName and A Valid StartDate and A Valid EndDate.";

                Exceplabel3.Visible = true;
                Label4.Visible = false;
                grid.Visible = false;

            }
            else
            {

                string planname = plan.Text;
                DateTime startdate = DateTime.Parse(start.Text);
                DateTime enddate = DateTime.Parse(end.Text);
                String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                string dataConsumpt = "SELECT * from dbo.Consumption(@Plan_name , @start_date , @end_date )";

                using (SqlCommand cmd = new SqlCommand(dataConsumpt, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Plan_name", planname);
                    cmd.Parameters.AddWithValue("@start_date", startdate);
                    cmd.Parameters.AddWithValue("@end_date", enddate);



                    SqlDataAdapter consump = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    conn.Open();
                    consump.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        grid.Visible = true;
                        grid.DataSource = dt;
                        grid.DataBind();
                        Label4.Visible = false;
                        Exceplabel3.Visible = false;
                    }
                    else
                    {

                        Label4.Text = "No records found.";
                        Label4.Visible = true;
                        grid.Visible = false;
                        Exceplabel3.Visible = false;
                    }


                }

            }
        }

        protected void Buttonback_Click(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];

            Response.Redirect("customerhomepage.aspx?data=" + valueFromQueryhomepage);
        }
    }
}