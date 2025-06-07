using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Renew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mobile);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string mobileNum = txtMobileNum.Text;
            decimal amount;
            string paymentMethod = ddlPaymentMethod.SelectedValue;
            int planId;

            if (string.IsNullOrEmpty(mobileNum) || !decimal.TryParse(txtAmount.Text, out amount) ||
                string.IsNullOrEmpty(paymentMethod) || !int.TryParse(txtPlanId.Text, out planId))
            {
                lblResult.Text = "Invalid input. Please check your entries.";
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["Telecom_Team_74"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Initiate_plan_payment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@mobile_num", mobileNum);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@payment_method", paymentMethod);
                    cmd.Parameters.AddWithValue("@plan_id", planId);

                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Payment processed successfully!";
                }
                catch (Exception ex)
                {
                    lblResult.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}