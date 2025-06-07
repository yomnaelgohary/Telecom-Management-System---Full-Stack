<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thismonthusage.aspx.cs" Inherits="WebApplication1.thismonthusage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usage for This Month</title>
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
            max-width: 1000px;
            overflow: hidden;
        }

        h2 {
            text-align: center;
            color: #1E90FF;
            margin-bottom: 30px;
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
            background-color: grey; 
            color: white; 
            padding: 8px 16px; 
            border: none;
            border-radius: 20px; 
            font-size: 14px; 
            cursor: pointer;
            transition: background-color 0.3s, box-shadow 0.3s;
            margin-top: 20px;
            width: auto; 
            display: inline-block;
            text-align: center;
        }

        .button:hover {
            background-color: #5a6268; 
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.3);
        }

        .button:active {
            background-color: #4e555b; 
        }

        .button:focus {
            outline: none;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Usage for This Month</h2>

            
            <asp:GridView ID="grid" runat="server" CssClass="gridview"></asp:GridView>
            <br />
            <br />
         
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <br />
           
            
            <asp:Button ID="BackButton" runat="server" Text="Back" ForeColor="White" OnClick="BackButton_Click" CssClass="button" />
        </div>
    </form>
</body>
</html>
