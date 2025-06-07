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
            conn.Open();
            bool isInt = int.TryParse(user, out nationID);
            if (!isInt)
            {
                Label2.Text = "enter a valid number";
                Label2.Visible = true;

            }
            else
            {
                string quercheck = "SELECT COUNT(*) FROM dbo.customer_profile WHERE nationalID = @nationalid";
                SqlCommand check = new SqlCommand(quercheck, conn);
                check.Parameters.AddWithValue("@nationalid", nationID);
                int count = (int)check.ExecuteScalar();
                if (count > 0)
                {

                    SqlCommand technicalsupportticket = new SqlCommand("Ticket_Account_Customer", conn);
                    technicalsupportticket.CommandType = CommandType.StoredProcedure;

                    technicalsupportticket.Parameters.Add(new SqlParameter("@NID", nationID));

                    DataTable ticket = new DataTable();


                    SqlDataAdapter numadapter = new SqlDataAdapter(technicalsupportticket);
                    numadapter.Fill(ticket);
                    conn.Close();
                    Label2.Visible=false;
                    Label1.Visible = false;
                    NID.Visible = false;
                    Button1.Visible = false;
                    LabelHeading.Visible = false;
                    DetailsView1.DataSource = ticket;
                    DetailsView1.DataBind();
                    
                }
                else
                {
                    ErrorLabel.Text = "nationalID not found";
                    ErrorLabel.Visible = true;
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