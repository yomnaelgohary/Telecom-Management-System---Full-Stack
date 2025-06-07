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
    public partial class Balancepayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string mobileNo = txtMobileNo.Text;
            decimal amount;
            string paymentMethod = ddlPaymentMethod.SelectedValue;

            // Validate input
            if (string.IsNullOrEmpty(mobileNo) || !decimal.TryParse(txtAmount.Text, out amount) || string.IsNullOrEmpty(paymentMethod))
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

                    // Call the stored procedure
                    SqlCommand cmd = new SqlCommand("Initiate_balance_payment", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@payment_method", paymentMethod);

                    cmd.ExecuteNonQuery();

                    lblResult.Text = "Balance recharged successfully!";
                }
                catch (Exception ex)
                {
                    lblResult.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mobile);
        }
    }
}