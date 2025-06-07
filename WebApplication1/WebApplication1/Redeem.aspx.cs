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
    public partial class Redeem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedeem_Click(object sender, EventArgs e)
        {
            string mobileNo = txtMobileNo.Text;
            int voucherId;

            // Validate input
            if (string.IsNullOrEmpty(mobileNo) || !int.TryParse(txtVoucherID.Text, out voucherId))
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
                    SqlCommand cmd = new SqlCommand("Redeem_voucher_points", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    cmd.Parameters.AddWithValue("@voucher_id", voucherId);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Capture server messages (PRINT statements)
                    conn.InfoMessage += (s, args) =>
                    {
                        lblResult.Text = args.Message;
                    };

                    // Set a generic success message if no PRINT message is captured
                    if (string.IsNullOrEmpty(lblResult.Text))
                    {
                        lblResult.Text = "Voucher redeemed successfully!";
                    }
                }
                catch (Exception ex)
                {
                    lblResult.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data="+mobile);
        }
    }
}