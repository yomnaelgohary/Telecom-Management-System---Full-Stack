<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consumption.aspx.cs" Inherits="WebApplication1.consumption" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Consumption</title>
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
        }

        h2 {
            text-align: center;
            color: #1E90FF;
            margin-bottom: 30px;
        }

       
        label {
            font-size: 16px;
            color: #333;
            display: block;
            margin-bottom: 5px;
        }

        
        input[type="text"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 8px;
            font-size: 14px;
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
            margin-top: 10px;
            width: 100%;
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

        .button-back {
            background-color: #808080; 
            width: auto;
            display: inline-block;
            margin-top: 10px;
        }

        .button-back:hover {
            background-color: #696969;
        }

        
        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
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

        
        .error-message {
            color: red;
            margin-bottom: 20px;
            font-size: 14px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enter Your Data Consumption Details</h2>

            
            <label for="plan">Enter your plan name:</label>
            <asp:TextBox ID="plan" runat="server"></asp:TextBox>

           
            <label for="start">Enter the start date (yyyy-mm-dd):</label>
            <asp:TextBox ID="start" runat="server"></asp:TextBox>

           
            <label for="end">Enter the end date:</label>
            <asp:TextBox ID="end" runat="server"></asp:TextBox>

           
            <asp:Button ID="Showbutton" runat="server" Text="Show" OnClick="Showbutton_Click1" CssClass="button" />
            <br />
            <br />

          
            <div class="error-message">
                <asp:Label ID="Exceplabel3" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server"  ForeColor="Red" Visible="False"></asp:Label>
            </div>

           
            <asp:GridView ID="grid" runat="server" CssClass="gridview"></asp:GridView>

            
            <asp:Button ID="Buttonback" runat="server" Text="Back" OnClick="Buttonback_Click" CssClass="button button-back" />
        </div>
    </form>
</body>
</html>
