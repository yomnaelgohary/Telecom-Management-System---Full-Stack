using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class Redeem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Any page load logic can be added here if needed
        }

        protected void btnRedeemVoucher_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtMobileNo.Text.Trim();
            string voucherIDText = txtVoucherID.Text.Trim();


            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 11)
            {
                lblMessage.Text = "Please enter a valid mobile number (11 digits).";
                return;
            }

            if (string.IsNullOrEmpty(voucherIDText) || !int.TryParse(voucherIDText, out int voucherID))
            {
                lblMessage.Text = "Please enter a valid Voucher ID.";
                return;
            }


            string resultMessage = RedeemVoucherPoints(mobileNumber, voucherID);

            lblMessage.Text = resultMessage;
        }

        private string RedeemVoucherPoints(string mobileNumber, int voucherID)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            string resultMessage = "An error occurred during the redemption process.";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Redeem_voucher_points", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);
                    cmd.Parameters.AddWithValue("@voucher_id", voucherID);


                    cmd.ExecuteNonQuery();

                    string checkPointsQuery = "SELECT points FROM customer_account WHERE mobileNo = @mobile_num";
                    SqlCommand checkPointsCmd = new SqlCommand(checkPointsQuery, conn);
                    checkPointsCmd.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    object pointsObj = checkPointsCmd.ExecuteScalar();
                    if (pointsObj != null && int.TryParse(pointsObj.ToString(), out int currentPoints))
                    {
                        string getVoucherPointsQuery = "SELECT points FROM Voucher WHERE voucherID = @voucher_id AND expiry_date > CURRENT_TIMESTAMP";
                        SqlCommand getVoucherPointsCmd = new SqlCommand(getVoucherPointsQuery, conn);
                        getVoucherPointsCmd.Parameters.AddWithValue("@voucher_id", voucherID);

                        object voucherPointsObj = getVoucherPointsCmd.ExecuteScalar();
                        if (voucherPointsObj != null && int.TryParse(voucherPointsObj.ToString(), out int voucherPoints))
                        {
                            if (currentPoints >= voucherPoints)
                            {
                                resultMessage = "Voucher redeemed successfully!";
                            }
                            else
                            {
                                resultMessage = "Insufficient points to redeem the voucher.";
                            }
                        }
                        else
                        {
                            resultMessage = "Voucher is invalid or expired.";
                        }
                    }
                    else
                    {
                        resultMessage = "Customer account not found or points are unavailable.";
                    }
                }
            }
            catch (Exception ex)
            {

                resultMessage = "An error occurred: " + ex.Message;
            }

            return resultMessage;
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];

            Response.Redirect("customerhomepage.aspx?data=" + valueFromQueryhomepage);
        }
    }
}