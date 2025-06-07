<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="toppayment.aspx.cs" Inherits="WebApplication1.toppayment" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Top Payment</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f8ff;
            color: #333;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            flex-direction: column;
        }

        #form1 {
            padding: 20px;
            background-color: white;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            width: 80%;
            max-width: 800px;
            text-align: center;
        }

        .label-heading {
            color: #1E90FF;
            margin-bottom: 20px;
            font-size: 2em;
            display: block;
        }

        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }

        .gridview th, .gridview td {
            padding: 10px;
            text-align: center;
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
            background-color: #1E90FF;
            color: white;
            padding: 10px 20px;
            font-size: 16px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
            width: 100%;
            margin-top: 20px;
        }

        .button:hover {
            background-color: #4682B4;
        }

        .button:active {
            background-color: #5F9EA0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="LabelHeading" runat="server" Text="Top 10 Successful Payments With Highest Value" CssClass="label-heading"></asp:Label>
        
        <asp:GridView ID="GridViewtop" runat="server" CssClass="gridview"></asp:GridView>
        
        <br />
        
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" CssClass="button" />
    </form>
</body>
</html>
