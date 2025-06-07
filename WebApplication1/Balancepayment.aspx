<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Balancepayment.aspx.cs" Inherits="WebApplication1.Balancepayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>Recharge Balance</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        form {
            width: 400px;
            padding: 20px;
            background-color: #ffffff;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
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
            font-weight: bold;
            color: #555;
        }
        input[type="text"], select {
            width: 100%;
            padding: 10px;
            border: 1px solid #ddd;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .btn-submit {
            display: inline-block;
            width: 100%;
            padding: 10px;
            color: #ffffff;
            background-color: #007bff;
            border: none;
            border-radius: 4px;
            font-size: 16px;
            cursor: pointer;
            text-align: center;
            margin-top: 10px;
        }
        .btn-submit:hover {
            background-color: #0056b3;
        }
        .result-message {
            margin-top: 10px;
            text-align: center;
            color: #d9534f; /* Red for error messages */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Recharge Balance</h2>
        <div class="form-group">
            <label for="txtMobileNo">Mobile Number:</label>
            <asp:TextBox ID="txtMobileNo" runat="server" CssClass="form-control" placeholder="Enter Mobile Number"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtAmount">Amount:</label>
            <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control" placeholder="Enter Amount"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="ddlPaymentMethod">Payment Method:</label>
            <asp:DropDownList ID="ddlPaymentMethod" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlPaymentMethod_SelectedIndexChanged">
                <asp:ListItem Text="Credit Card" Value="Credit Card"></asp:ListItem>
                <asp:ListItem Text="Debit Card" Value="Debit Card"></asp:ListItem>
                <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Recharge Balance" CssClass="btn-submit" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblResult" runat="server" CssClass="result-message"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
    </form>
</body>
</html>
