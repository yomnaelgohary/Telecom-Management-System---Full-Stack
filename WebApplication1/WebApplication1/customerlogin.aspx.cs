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
    public partial class customerlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Loginclick(object sender, EventArgs e)
        {


            if ((string.IsNullOrEmpty(MobileNumber.Text)) || (string.IsNullOrEmpty(Password.Text)) || (MobileNumber.Text.Length != 11))
            {


                Exceplabel.Text = "You Must Enter a Valid MobileNumber and a Valid Password.";
                Exceplabel2.Text = "A Valid MobileNumber consists of 11 numbers and A Valid Password must contains atleast one character. ";
                Exceplabel.Visible = true;
                Exceplabel2.Visible = true;
                ErrorLabelmob.Visible = false;

            }
            else
            {

                String mobileno = MobileNumber.Text;
                String pass = Password.Text;


                String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand logincustomer = new SqlCommand("SELECT dbo.AccountLoginValidation(@mobile_num, @pass)", conn);
                logincustomer.CommandType = CommandType.Text;


                logincustomer.Parameters.AddWithValue("@mobile_num", mobileno);
                logincustomer.Parameters.AddWithValue("@pass", pass);

                conn.Open();
                object result = logincustomer.ExecuteScalar();
                int output = Convert.ToInt32(result);



                if (output == 0)

                {
                    ErrorLabelmob.Text = "Wrong MobileNumber or Password,Please Try Again.";
                    ErrorLabelmob.Visible = true;
                    Exceplabel.Visible = false;
                    Exceplabel2.Visible = false;
                }
                else
                {
                    Response.Redirect("customerhomepage.aspx?data=" + mobileno);
                }
                conn.Close();
            }
        }

     

        protected void BackButton_Click1(object sender, EventArgs e)
        {
            Response.Redirect("customer.admin.aspx");
        }
    }
}