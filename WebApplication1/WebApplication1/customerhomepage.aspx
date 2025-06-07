<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerhomepage.aspx.cs" Inherits="WebApplication1.customerhomepage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Homepage</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f4f7;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        form {
            background-color: #ffffff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            width: 100%;
            max-width: 1200px; 
            overflow: auto; 
        }

        h2 {
            text-align: center;
            color: #1E90FF;
            font-size: 2em;
            margin-bottom: 20px;
        }

        .button {
            background-color: #007bff;
            color: white;
            padding: 12px 24px;
            border: none;
            border-radius: 25px; 
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s, box-shadow 0.3s;
            margin-right: 10px; 
            margin-bottom: 10px; 
        }

        .button:hover {
            background-color: #0056b3;
            box-shadow: 0 4px 8px rgba(0, 86, 179, 0.3);
        }

        .button:active {
            background-color: #004085;
        }

        .button:focus {
            outline: none;
        }

        .button-container {
            display: flex;
            flex-wrap: wrap; 
            justify-content: flex-start; 
            gap: 10px; 
        }

        
        .button-logout {
            background-color: #888888; 
            color: white;
            font-size: 16px;
            font-weight: 500;
            padding: 12px 24px;
            border-radius: 25px;
            width: 100%; 
            margin-top: 20px; 
            cursor: pointer;
        }

        .button-logout:hover {
            background-color: #666666; 
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2); 
        }

        .button-logout:active {
            background-color: #444444; 
        }

        .button-logout:focus {
            outline: none;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="button-container">
            <asp:Button ID="serviceplans" runat="server" Text="All Offered Service Plans" OnClick="serviceplans_Click" CssClass="button" />
            <asp:Button ID="Butotalconsumptiontton2" runat="server" Text="Your Data Consumption" OnClick="Butotalconsumptiontton2_Click" CssClass="button" />
            <asp:Button ID="unsubscribedplans" runat="server" Text="Your Unsubscriped Service Plans" OnClick="unsubscribedplans_Click" CssClass="button" />
            <asp:Button ID="usage" runat="server" Text=" Your Usage This Month" OnClick="usagecuurentmonth_Click" CssClass="button" />
            <asp:Button ID="Cashbacktransaction" runat="server" Text="Your Cashback Transactions" OnClick="Cashbacktransaction_Click" CssClass="button" />
            <asp:Button ID="activebenefits" runat="server" Text="All Active Benefits" OnClick="activebenefits_Click" CssClass="button" />
            <asp:Button ID="numofticket" runat="server" Text="Unresolved Technical Support Tickets" OnClick="numofticket_Click" CssClass="button" />
            <asp:Button ID="vouchbutton" runat="server" Text="Voucher With Highest Value" OnClick="vouchbutton_Click" CssClass="button" />
            <asp:Button ID="remainingamount" runat="server" Text="Show Remaining Amount" OnClick="remainingamount_Click" CssClass="button" />
            <asp:Button ID="extraamount" runat="server" Text="Show Extra Amount" OnClick="extraamount_Click" CssClass="button" />
            <asp:Button ID="toppayments" runat="server" Text="Top 10 Successful Payments" OnClick="toppayments_Click" CssClass="button" />
            <asp:Button ID="shops" runat="server" Text="View All Shops" OnClick="shops_Click" CssClass="button" />
            <asp:Button ID="plans" runat="server" Text="Service Plans Subscribed To In The Past 5 Months" OnClick="plans_Click" CssClass="button" />
            <asp:Button ID="renew" runat="server" Text="Renew Your Subscriptions" OnClick="renew_Click" CssClass="button" />
            <asp:Button ID="cashback" runat="server" Text="Initiate A Payment" OnClick="cashback_Click" CssClass="button" />
            <asp:Button ID="balanceresharge" runat="server" Text="Recharge Your Balance" OnClick="balanceresharge_Click" CssClass="button" />
            <asp:Button ID="voucher" runat="server" Text="Redeem Voucher" OnClick="voucher_Click" CssClass="button" />
            
            
            <asp:Button ID="Buttonlogout" runat="server" Text="Logout" OnClick="Buttonlogout_Click" CssClass="button-logout" />
        </div>
    </form>
</body>
</html>
