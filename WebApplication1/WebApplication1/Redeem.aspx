<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redeem.aspx.cs" Inherits="WebApplication1.Redeem" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Redeem Voucher</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 400px;
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
            font-size: 1.8em;
            margin-bottom: 20px;
        }
        label {
            font-weight: bold;
            display: block;
            margin-bottom: 8px;
            color: #555;
        }
        input[type="text"] {
            width: 100%;
            padding: 12px;
            margin-bottom: 15px;
            border: 1px solid #007bff;
            border-radius: 4px;
            font-size: 14px;
            background-color: #f9f9f9;
            color: #333;
        }
        input[type="text"]:focus {
            border-color: #0056b3;
            outline: none;
            box-shadow: 0 0 5px rgba(0, 86, 179, 0.5);
        }
        #btnRedeem {
            width: 100%;
            background: #007bff; /* Blue background */
            color: #fff;
            padding: 12px;
            border: none;
            border-radius: 4px;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s, box-shadow 0.3s;
        }
        #btnRedeem:hover {
            background: #0056b3; /* Darker blue on hover */
            box-shadow: 0 4px 8px rgba(0, 86, 179, 0.3); /* Adds a shadow for hover effect */
        }
        #btnRedeem:active {
            background: #004085; /* Even darker blue on active click */
        }
        .result {
            margin-top: 15px;
            text-align: center;
            font-size: 14px;
        }
        .result.error {
            color: red;
        }
        .result.success {
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Redeem Voucher</h2>
            <label for="txtMobileNo">Mobile Number:</label>
            <asp:TextBox ID="txtMobileNo" runat="server" placeholder="Enter your mobile number" CssClass="input-field" />
            
            <label for="txtVoucherID">Voucher ID:</label>
            <asp:TextBox ID="txtVoucherID" runat="server" placeholder="Enter the voucher ID" CssClass="input-field" />
            
            <asp:Button ID="btnRedeem" runat="server" Text="Redeem Voucher" OnClick="btnRedeem_Click" CssClass="button" />
            
            <div class="result">
                <asp:Label ID="lblResult" runat="server" CssClass="result" />
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
