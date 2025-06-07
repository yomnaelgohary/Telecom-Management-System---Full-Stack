<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customerwallet.aspx.cs" Inherits="WebApplication1.Customerwallet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>Payment Wallet Cashback</title>
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
        input[type="text"], input[type="number"] {
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
            color: #d9534f; /* Red color for error messages */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Payment Wallet Cashback</h2>
        <div class="form-group">
            <label for="txtMobileNo">Mobile Number:</label>
            <asp:TextBox ID="txtMobileNo" runat="server" CssClass="form-control" placeholder="Enter Mobile Number"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtPaymentId">Payment ID:</label>
            <asp:TextBox ID="txtPaymentId" runat="server" CssClass="form-control" placeholder="Enter Payment ID"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtBenefitId">Benefit ID:</label>
            <asp:TextBox ID="txtBenefitId" runat="server" CssClass="form-control" placeholder="Enter Benefit ID"></asp:TextBox>
        </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Process Cashback" CssClass="btn-submit" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblResult" runat="server" CssClass="result-message"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
    </form>
</body>
</html>