using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;





namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (string.IsNullOrEmpty(adminID.Text) && string.IsNullOrEmpty(password.Text))
            {
                Label4.Text = "Please enter valid AdminID and Password.";
                Label4.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else if (string.IsNullOrEmpty(adminID.Text))
            {
                Label4.Text = "Please enter a valid AdminID.";
                Label4.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else if (string.IsNullOrEmpty(password.Text))
            {
                Label4.Text = "Please enter a valid Password.";
                Label4.ForeColor = System.Drawing.Color.Red;
                return;
                
            }
            else
            {
                int id = Int16.Parse(adminID.Text);
                int pass = Int16.Parse(password.Text);
                if (id == 123 && pass == 123)
                {
                    Response.Redirect("admin1.aspx");
                    Label4.Text = "";
                }
                else
                {
                    Label4.Text = "Please enter valid AdminID and Password.";
                    Label4.ForeColor = System.Drawing.Color.Red;
                    return;

                }


            }

        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("customer.admin.aspx");
        }
    }
}
