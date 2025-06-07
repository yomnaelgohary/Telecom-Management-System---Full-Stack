<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="numoftickets.aspx.cs" Inherits="WebApplication1.numoftickets" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>National ID Entry</title>
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
        }

        .label {
            font-size: 16px;
            color: #333;
            margin-bottom: 10px;
        }

        .textbox {
            padding: 8px;
            width: 100%;
            border-radius: 5px;
            border: 1px solid #ccc;
            margin-bottom: 20px;
        }

        .button {
            background-color: #1E90FF;
            color: white;
            padding: 10px 20px;
            font-size: 16px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s, transform 0.2s;
            width: 100%;
            margin-bottom: 15px;
        }

        .button:hover {
            background-color: #4682B4;
            transform: scale(1.05);
        }

        .button:active {
            background-color: #5F9EA0;
        }

        .button-back {
            background-color: #D3D3D3;
        }

        .button-back:hover {
            background-color: #A9A9A9;
        }

        .button-back:active {
            background-color: #808080;
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

        .detailsview {
            margin-bottom: 20px;
            width: 100%;
        }

        .error-label {
            color: red;
            font-size: 14px;
            margin-bottom: 10px;
        }

        .label2 {
            color: red;
            font-size: 14px;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:Label ID="LabelHeading" runat="server" Text="Enter Your National ID" CssClass="label-heading"></asp:Label>
        
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter your national ID:" CssClass="label"></asp:Label>
        <br />
        
        <asp:TextBox ID="NID" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" CssClass="button" />
        
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Visible="False" CssClass="error-label"></asp:Label>
        
        <asp:Label ID="Label2" runat="server" Visible="false" CssClass="label2"></asp:Label>
        
        <br />
        
        <asp:GridView ID="numofticketsgrid" runat="server" CssClass="gridview"></asp:GridView>
        <br />
        
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" CssClass="button button-back" />
    </form>
</body>
</html>
