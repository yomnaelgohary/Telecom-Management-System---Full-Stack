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
    public partial class admin2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM CustomerWallet";
                DataTable dt = new DataTable();
                //create sql command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Execute the command
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    Label4.Text = "No records found.";
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT E_shopVouchers.URL, E_shopVouchers.voucherID,E_shopVouchers.value FROM E_shopVouchers";
                DataTable dt = new DataTable();
                //create sql command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Execute the command
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
                else
                {
                    GridView2.DataSource = null;
                    GridView2.DataBind();
                    Label4.Text = "No records found.";
                }

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM AccountPayments";
                DataTable dt = new DataTable();
                //create sql command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Execute the command
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView3.DataSource = dt;
                    GridView3.DataBind();
                }
                else
                {
                    GridView3.DataSource = null;
                    GridView3.DataBind();
                    Label4.Text = "No records found.";
                }

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Num_of_cashback";
                DataTable dt = new DataTable();
                //create sql command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Execute the command
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView4.DataSource = dt;
                    GridView4.DataBind();
                }
                else
                {
                    GridView4.DataSource = null;
                    GridView4.DataBind();
                    Label4.Text = "No records found.";
                }

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String mobile_num = TextBox1.Text;
            if (string.IsNullOrEmpty(mobile_num) || mobile_num.Length != 11 || !mobile_num.All(char.IsDigit))
            {
                Label1.Text = "PLEASE ENTER A VALID 11-DIGIT MOBILE NUMBER!!";

                return;
            }

            SqlCommand cmd = new SqlCommand("Account_Payment_Points", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@mobile_num", mobile_num));
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.IsDBNull(0) || reader.IsDBNull(1))
                {
                    Label1.Text = "No data found for the provided mobile number.";
                }
                else
                {
                    int transactionCount = reader.GetInt32(0);
                    int totalPoints = reader.GetInt32(1);
                    Label1.Text = $"Number of Accepted Transactions: {transactionCount} and " +
                                  $"Total Earned Points: {totalPoints}";
                }
            }
            else
            {
                Label1.Text = "No data found for the provided mobile number.";
            }
            reader.Close();
            conn.Close();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Wallet_MobileNo(@mobile_num) AS HasWallet, " +
                                   "CASE WHEN EXISTS (SELECT 1 FROM customer_account WHERE mobileNo = @mobile_num) THEN 1 ELSE 0 END AS IsCustomer", conn);
            cmd.CommandType = CommandType.Text;
            String mobile_num = TextBox1.Text;
            if (string.IsNullOrEmpty(mobile_num) || mobile_num.Length != 11 || !mobile_num.All(char.IsDigit))
            {
                Label1.Text = "PLEASE ENTER A VALID 11-DIGIT MOBILE NUMBER!!";

                return;
            }

            cmd.Parameters.Add(new SqlParameter("@mobile_num", mobile_num));

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                bool isCustomer = reader.GetInt32(1) == 1;

                if (!isCustomer)
                {
                    Label1.Text = "No Data for this Mobile Number.";
                }
                else
                {
                    if (reader.IsDBNull(0))
                    {
                        Label1.Text = "No wallet information found for this mobile number.";
                    }
                    else
                    {
                        bool hasWallet = reader.GetBoolean(0);

                        if (hasWallet)
                        {
                            Label1.Text = "This mobile number has a wallet.";
                        }
                        else
                        {
                            Label1.Text = "This mobile number does not have a wallet.";
                        }
                    }
                }
            }
            else
            {
                Label1.Text = "No Data for this Mobile Number.";
            }

            reader.Close();
            conn.Close();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            String mobile_num = TextBox1.Text;
            if (string.IsNullOrEmpty(mobile_num) || mobile_num.Length != 11 || !mobile_num.All(char.IsDigit))
            {
                Label1.Text = "Please enter a valid 11-digit mobile number.";
                return;
            }
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM customer_account WHERE mobileNo = @mobile_num", conn);
                checkCmd.Parameters.Add(new SqlParameter("@mobile_num", mobile_num));
                int isCustomer = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (isCustomer == 0)
                {
                    Label1.Text = "No data for this mobile number.";
                    return;
                }
                SqlCommand cmd = new SqlCommand("Total_Points_Account", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mobile_num", mobile_num));
                cmd.ExecuteNonQuery();
                Label1.Text = "Points Updated!";

            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.Message;
            }
            conn.Close();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Wallet_Cashback_Amount(@walletID, @planID) AS CashbackAmount", conn);
            cmd.CommandType = CommandType.Text;
            try
            {
                int walletID = Int16.Parse(TextBox2.Text);
                int planID = Int16.Parse(TextBox3.Text);
                cmd.Parameters.Add(new SqlParameter("@walletID", walletID));
                cmd.Parameters.Add(new SqlParameter("@planID", planID));
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int cashbackAmount = Convert.ToInt32(result);
                    Label2.Text = $"Cashback Amount: {cashbackAmount}";
                }
                else
                {
                    Label2.Text = "No cashback amount found for the provided inputs.";
                }
            }
            catch (Exception ex)
            {
                Label2.Text = "Error: " + ex.Message;
            }
            conn.Close();

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Wallet_Transfer_Amount(@walletID, @start_date , @end_date ) AS avrgsenttransactions", conn);
            cmd.CommandType = CommandType.Text;
            try
            {
                int walletID = Int16.Parse(TextBox4.Text);
                DateTime start_date = DateTime.Parse(TextBox5.Text);
                DateTime end_date = DateTime.Parse(TextBox6.Text);
                cmd.Parameters.Add(new SqlParameter("@walletID", walletID));
                cmd.Parameters.Add(new SqlParameter("@start_date", start_date));
                cmd.Parameters.Add(new SqlParameter("@end_date", end_date));
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int avrgsenttransactions = Convert.ToInt32(result);
                    Label3.Text = $"Average Sent Transations: {avrgsenttransactions}";
                }
                else
                {
                    Label3.Text = "No Transactions found for the provided inputs.";
                }
            }
            catch (Exception ex)
            {
                Label3.Text = "Error: " + ex.Message;
            }
            conn.Close();

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin1.aspx");
        }
    }
}