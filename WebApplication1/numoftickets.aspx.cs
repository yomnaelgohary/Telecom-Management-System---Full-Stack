using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace WebApplication1
{
    public partial class numoftickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string user = NID.Text;

            int nationID;
            bool isInt = int.TryParse(user, out nationID);

            if ((string.IsNullOrEmpty(NID.Text)) || !(int.TryParse(NID.Text, out _)))
            {

                ErrorLabel.Text = "Enter a valid NationalID. ";
                ErrorLabel.Visible = true;

            }

            else
            {

                conn.Open();
                string querycheck = "SELECT COUNT(*) FROM dbo.customer_profile WHERE nationalID = @ID";
                SqlCommand check = new SqlCommand(querycheck, conn);
                check.Parameters.AddWithValue("@ID", nationID);
                int count = (int)check.ExecuteScalar();
                if (count <= 0)
                {
                    ErrorLabel.Text = "NationalID not found.  Try Again";
                    ErrorLabel.Visible = true;
                }
                else
                {
                    SqlCommand technicalsupportticket = new SqlCommand("Ticket_Account_Customer", conn);
                    technicalsupportticket.CommandType = CommandType.StoredProcedure;

                    technicalsupportticket.Parameters.Add(new SqlParameter("@NID", nationID));

                    DataTable ticket = new DataTable();


                    SqlDataAdapter numadapter = new SqlDataAdapter(technicalsupportticket);
                    numadapter.Fill(ticket);
                    conn.Close();
                    if (ticket.Rows.Count > 0)
                    {
                        Label2.Visible = false;
                        Label1.Visible = false;
                        NID.Visible = false;
                        Button1.Visible = false;
                        LabelHeading.Visible = false;
                        ErrorLabel.Visible = false;
                        numofticketsgrid.DataSource = ticket;
                        numofticketsgrid.DataBind();
                    }
                    else
                    {
                        ErrorLabel.Text = "No CashBack Transactions For This NationalID.";
                        ErrorLabel.Visible = true;
                        numofticketsgrid.Visible = false;

                    }
                }






            }




        }








        protected void Button2_Click(object sender, EventArgs e)
        {

            string mobile = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + mobile);
        }
    }
}