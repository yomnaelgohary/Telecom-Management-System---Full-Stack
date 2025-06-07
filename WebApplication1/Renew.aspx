<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Renew.aspx.cs" Inherits="WebApplication1.Renew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Initiate Plan Payment</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 500px;
            margin: 50px auto;
            padding: 20px;
            background: #ffffff;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }
        h2 {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            display: block;
            margin-bottom: 5px;
            color: #555;
        }
        input[type="text"], select {
            width: calc(100% - 20px);
            padding: 10px;
            font-size: 14px;
            border: 1px solid #ddd;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .btn {
            display: block;
            width: 100%;
            padding: 10px;
            background-color: #007BFF; /* Blue button color */
            color: white;
            border: none;
            border-radius: 4px;
            font-size: 16px;
            cursor: pointer;
            margin-top: 10px;
        }
        .btn:hover {
            background-color: #0056b3; /* Darker blue on hover */
        }
        .result-message {
            text-align: center;
            margin-top: 15px;
            color: red;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Initiate Plan Payment</h2>
            
            <div class="form-group">
                <label for="txtMobileNum">Mobile Number:</label>
                <asp:TextBox ID="txtMobileNum" runat="server" CssClass="input"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label for="txtAmount">Amount:</label>
                <asp:TextBox ID="txtAmount" runat="server" CssClass="input"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label for="ddlPaymentMethod">Payment Method:</label>
                <asp:DropDownList ID="ddlPaymentMethod" runat="server" CssClass="input">
                    <asp:ListItem Text="Credit Card" Value="Credit Card"></asp:ListItem>
                    <asp:ListItem Text="Debit Card" Value="Debit Card"></asp:ListItem>
                    <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                </asp:DropDownList>
            </div>
            
            <div class="form-group">
                <label for="txtPlanId">Plan ID:</label>
                <asp:TextBox ID="txtPlanId" runat="server" CssClass="input"></asp:TextBox>
            </div>
            
            <asp:Button ID="btnSubmit" runat="server" Text="Submit Payment" CssClass="btn" OnClick="btnSubmit_Click" />
            
            <asp:Label ID="lblResult" runat="server" CssClass="result-message"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>