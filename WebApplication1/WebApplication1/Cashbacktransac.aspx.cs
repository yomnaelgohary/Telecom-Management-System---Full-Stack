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
    public partial class Cashbacktransac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            string valueFromQueryhomepage = Request.QueryString["data"];
            Response.Redirect("customerhomepage.aspx?data=" + valueFromQueryhomepage);
        }

        protected void ShowButton_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(nationalid.Text)) || !(int.TryParse(nationalid.Text, out _)))
            {


                Exceplabel4.Text = "You Must Enter A Valid NationalID.";

                Exceplabel4.Visible = true;
                Label1.Visible = false;
                GridView1.Visible = false;

            }
            else
            {


                int NationalID = Convert.ToInt32(nationalid.Text);
                String connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                string quer = "SELECT * from dbo.Cashback_Wallet_Customer(@NID)";

                using (SqlCommand cashback = new SqlCommand(quer, conn))
                {

                    cashback.CommandType = CommandType.Text;

                    cashback.Parameters.AddWithValue("@NID", NationalID);


                    SqlDataAdapter cash = new SqlDataAdapter(cashback);
                    DataTable cashdt = new DataTable();
                    conn.Open();
                    cash.Fill(cashdt);

                    if (cashdt.Rows.Count > 0)
                    {
                        Label1.Visible = false;
                        Exceplabel4.Visible = false;

                        GridView1.Visible = true;
                        GridView1.DataSource = cashdt;
                        GridView1.DataBind();
                    }
                    else
                    {
                        Label1.Text = "No CashBack Transactions For This NationalID.";
                        Label1.Visible = true;
                        GridView1.Visible = false;
                        Exceplabel4.Visible = false;


                    }




                }


            }
        }
    }
}
