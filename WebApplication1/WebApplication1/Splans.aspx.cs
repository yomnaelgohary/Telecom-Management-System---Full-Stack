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
    public partial class Splans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Any code to run on initial page load
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate the input for mobile number
            string mobileNo = txtMobileNo.Text.Trim();
            if (string.IsNullOrEmpty(mobileNo))
            {
                // Display an error message if mobile number is empty
                Label1.Text = "Please enter a valid mobile number.";
                return;
            }

            // Call the method to bind data to the GridView
            BindGridView(mobileNo);
        }
        private void BindGridView(string mobileNo)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Telecom_Team_74"].ConnectionString;
                string query = @"SELECT * FROM dbo.Subscribed_plans_5_Months(@MobileNo)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MobileNo", mobileNo);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                GridView1.DataSource = dt;
                                GridView1.DataBind();
                            }
                            else
                            {
                                Label1.Text = "No records found.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mobile);
        }
    }
}