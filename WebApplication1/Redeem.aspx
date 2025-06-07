<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redeem.aspx.cs" Inherits="WebApplication1.Redeem" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Redeem Voucher</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f4f8;
            padding: 40px 0;
        }

        .container {
            width: 500px;
            margin: 0 auto;
            padding: 30px;
            border: 2px solid #ddd;
            border-radius: 15px;
            background-color: #fff;
            box-shadow: 0px 10px 30px rgba(0, 0, 0, 0.1);
            position: relative;
        }

        .voucher-sticker {
            position: absolute;
            top: -20px;
            right: -40px;
            background-color: #4CAF50;
            color: white;
            font-weight: bold;
            padding: 10px 20px;
            border-radius: 20px;
            transform: rotate(45deg);
            font-size: 18px;
            text-align: center;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            display: block;
            font-weight: bold;
            font-size: 16px;
        }

        .form-group input {
            width: 100%;
            padding: 10px;
            margin-top: 8px;
            border-radius: 8px;
            border: 1px solid #ddd;
            font-size: 14px;
        }

        .form-group button {
            background-color: #4CAF50;
            color: white;
            padding: 12px 20px;
            border: none;
            border-radius: 8px;
            font-size: 16px;
            cursor: pointer;
            width: 100%;
        }

        .form-group button:hover {
            background-color: #45a049;
        }

        .message {
            color: red;
            font-weight: bold;
            margin-top: 15px;
            text-align: center;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="voucher-sticker">Voucher</div>
        <h2 style="text-align: center; margin-bottom: 20px;">Redeem Voucher</h2>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtMobileNo">Mobile Number:</label>
                <asp:TextBox ID="txtMobileNo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtVoucherID">Voucher ID:</label>
                <asp:TextBox ID="txtVoucherID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnRedeemVoucher" runat="server" Text="Redeem Voucher" OnClick="btnRedeemVoucher_Click" CssClass="btn btn-success" />
            </div>

            <div class="message">
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            </div>
              <asp:Button ID="Button1" runat="server" Text="Back" OnClick="BackButton_Click" />
        </form>
    </div>
    <br />
    <br />
   
</body>
</html>