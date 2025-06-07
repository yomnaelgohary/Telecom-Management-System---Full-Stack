<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cashbacktransac.aspx.cs" Inherits="WebApplication1.Cashbacktransac" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cashback Transactions</title>
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
            background-color: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
            width: 80%;
            max-width: 800px;
            overflow: hidden;
        }

        h2 {
            text-align: center;
            color: #1E90FF;
            margin-bottom: 30px;
        }

        label {
            font-size: 16px;
            color: #333;
        }

        input[type="text"] {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            border: 1px solid #ddd;
            border-radius: 8px;
            font-size: 14px;
            box-sizing: border-box;
        }

        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }

        .gridview th, .gridview td {
            padding: 12px;
            text-align: left;
            border: 1px solid #ddd;
        }

        .gridview th {
            background-color: #1E90FF;
            color: white;
        }

        .gridview tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        .gridview tr:hover {
            background-color: #f1f1f1;
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
            margin-top: 20px;
            width: 100%;
            display: inline-block;
            text-align: center;
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

        
        .back-button {
            background-color: #6c757d; 
            color: white;
            padding: 8px 16px;
            border: none;
            border-radius: 20px;
            font-size: 14px;
            cursor: pointer;
            width: auto;
            margin-top: 15px;
            display: inline-block;
            text-align: center;
        }

        .back-button:hover {
            background-color: #5a6268;
        }

        .back-button:active {
            background-color: #4e555b;
        }

        .back-button:focus {
            outline: none;
        }

        
        .error-message {
            color: red;
            font-size: 14px;
            font-weight: bold;
            display: none;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cashback Transactions</h2>

            
            <label for="nationalid">Enter Your National ID:</label>
            <asp:TextBox ID="nationalid" runat="server" CssClass="form-control" />
            <br />
            <br />
            <asp:Label ID="Exceplabel4" runat="server" ForeColor="Red" Visible="False"></asp:Label>

           
            <asp:Button ID="ShowButton" runat="server" Text="Show Transactions" OnClick="ShowButton_Click" CssClass="button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <br />

            
            <asp:GridView ID="GridView1" runat="server" CssClass="gridview" Height="206px" Width="100%" />

           
            <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click" CssClass="back-button" />
        </div>
    </form>
</body>
</html>
