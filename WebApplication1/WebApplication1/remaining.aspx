<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="remaining.aspx.cs" Inherits="WebApplication1.remaining" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Remaining Plan</title>
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
            width: 300px;
            text-align: center;
        }

        .label-heading {
            color: #1E90FF;
            font-size: 24px;
            margin-bottom: 20px;
            display: block;
        }

        .label {
            font-size: 16px;
            color: #333;
            margin-bottom: 10px;
        }

        .textbox {
            padding: 10px;
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
            transition: background-color 0.3s;
            width: 100%;
            margin-bottom: 15px;
        }

        .button:hover {
            background-color: #4682B4;
        }

        .button:active {
            background-color: #5F9EA0;
        }

        .error-label {
            color: red;
            font-size: 14px;
            margin-bottom: 10px;
        }

        .output-label {
            font-size: 16px;
            color: #1E90FF;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="LabelHeading" runat="server" Text="Enter Your Plan Name" CssClass="label-heading"></asp:Label>
        
        <asp:Label ID="Label5" runat="server" Text="Plan Name:" CssClass="label"></asp:Label>
        <br />
        <asp:TextBox ID="planname" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        
        
        <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" CssClass="button" />
        
        
        <asp:Label ID="outputremain" runat="server" Visible="False" CssClass="output-label"></asp:Label>
        <br />
        
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Visible="False" CssClass="error-label"></asp:Label>
        <br />
        
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" CssClass="button" />
    </form>
</body>
</html>
