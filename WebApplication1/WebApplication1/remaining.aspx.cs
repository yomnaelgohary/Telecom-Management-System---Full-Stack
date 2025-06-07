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
    public partial class remaining : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string mob = Request.QueryString["data"];
            string plan = planname.Text;
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            string quercheck = "SELECT COUNT(*) FROM dbo.Service_plan WHERE name = @name";
            SqlCommand check = new SqlCommand(quercheck, conn);
            check.Parameters.AddWithValue("@name", plan);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {

                SqlCommand amountremained = new SqlCommand("SELECT dbo.Remaining_plan_amount(@mobile_num, @plan_name)", conn);
                amountremained.CommandType = CommandType.Text;


                amountremained.Parameters.AddWithValue("@mobile_num", mob);
                amountremained.Parameters.AddWithValue("@plan_name", plan);



                object result = amountremained.ExecuteScalar();
                int output = Convert.ToInt32(result);
                conn.Close();

                Label5.Visible = false;
                planname.Visible = false;
                Button1.Visible = false;
                ErrorLabel.Visible = false;
                LabelHeading.Visible = false;
                outputremain.Text = "remaining amount:" + output.ToString();
                outputremain.Visible = true;
            }
            else
            {

                ErrorLabel.Text = "plan not found";
                ErrorLabel.Visible = true;
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mob = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mob);
        }
    }
}