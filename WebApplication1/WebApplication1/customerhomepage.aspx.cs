using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class customerhomepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void serviceplans_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("offserviceplans.aspx?data=" + mobile);
        }

        protected void Butotalconsumptiontton2_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("consumption.aspx?data=" + mobile);
        }

        protected void unsubscribedplans_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("unsubscribedplans.aspx?data=" + mobile);
        }

        protected void usagecuurentmonth_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("thismonthusage.aspx?data=" + mobile);
        }

        protected void activebenefits_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("benefittable.aspx?data="+ mobile);
        }

        protected void numofticket_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("numoftickets.aspx?data=" + mobile);
        }

        protected void vouchbutton_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("highestvoucher.aspx?data=" + mobile);
        }

        protected void remainingamount_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("remaining.aspx?data=" + mobile);
        }

        protected void extraamount_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("extra.aspx?data=" + mobile);
        }

        protected void Buttonlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerlogin.aspx");
        }

        protected void toppayments_Click(object sender, EventArgs e)
        {
            string mobile = Request.QueryString["data"];
            Response.Redirect("toppayment.aspx?data=" + mobile);
        }

        protected void shops_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("Shops.aspx?data=" + mobile);
        }

        protected void plans_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("Splans.aspx?data=" + mobile);
        }

        protected void renew_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("Customerwallet.aspx?data=" + mobile);
        }

        protected void cashback_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("Renew.aspx?data=" + mobile);
           
        }

        protected void balanceresharge_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("Balancepayment.aspx?data=" + mobile);
        }

        protected void voucher_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("Redeem.aspx?data="+ mobile);
        }

        

        protected void Cashbacktransaction_Click(object sender, EventArgs e)
        {
            String mobile = Request.QueryString["data"];
            Response.Redirect("Cashbacktransac.aspx?data=" + mobile);
        }
    }
}