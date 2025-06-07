using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices.ComTypes;

namespace WebApplication1
{
    public partial class benefits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mobileno = mobileb.Text;
            string id = planb.Text;
            int planid;

            if (string.IsNullOrEmpty(mobileno) && !int.TryParse(id, out planid))
            {
                Label3.Text = "Please enter both a valid mobile number and a plan id.";
                Label3.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(mobileno))
            {
                Label3.Text = "Please enter a valid mobile number.";
                Label3.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!int.TryParse(id, out planid))
            {
                Label3.Text = "Please enter a valid plan id.";
                Label3.ForeColor = System.Drawing.Color.Red;
                return;
            }
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_74"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand("Benefits_Account", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@mobile_num", mobileno);
            command.Parameters.AddWithValue("@plan_id", planid);
            conn.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Label3.Text = "Mobile number updated successfully.";
                Label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label3.Text = "No records were found for given mobile number and plan id";
                Label3.ForeColor = System.Drawing.Color.Red;
            }
            conn.Close();
        }
    }
}