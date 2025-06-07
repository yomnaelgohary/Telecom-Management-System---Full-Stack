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
    public partial class Customerwallet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string mobileNo = txtMobileNo.Text;
            int paymentId, benefitId;

            // Validate input
            if (string.IsNullOrEmpty(mobileNo) || !int.TryParse(txtPaymentId.Text, out paymentId) ||
                !int.TryParse(txtBenefitId.Text, out benefitId))
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
                    SqlCommand cmd = new SqlCommand("Payment_wallet_cashback", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    cmd.Parameters.AddWithValue("@payment_id", paymentId);
                    cmd.Parameters.AddWithValue("@benefit_id", benefitId);

                    cmd.ExecuteNonQuery();

                    lblResult.Text = "Cashback processed successfully!";
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