<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer.admin.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin and Customer Buttons</title>
    <style>
        html, body {
            height: 100%;
            margin: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        body {
            display: flex;
            justify-content: center;
            align-items: center;
            background: linear-gradient(135deg, #A7C7E7, #B4D9E9); 
            color: black;
            height: 100vh;
            margin: 0;
        }

        form {
            background-color: white;
            padding: 40px;
            border-radius: 12px;
            box-shadow: 0 6px 18px rgba(0, 0, 0, 0.1);
            width: 320px;
            text-align: center;
        }

        .form-element {
            margin-bottom: 25px;
        }

        .blue-button {
            background-color: #2563EB; 
            color: white;
            padding: 16px 30px;
            border: none;
            border-radius: 10px;
            cursor: pointer;
            font-size: 18px;
            width: 220px;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2); 
            transition: background-color 0.3s ease, transform 0.2s ease, box-shadow 0.3s ease;
        }

        .blue-button:hover {
            background-color: #1D4ED8; 
            transform: translateY(-4px); 
            box-shadow: 0 6px 12px rgba(0, 0, 0, 0.3); 
        }

        .blue-button:active {
            background-color: #1D4ED8; 
            transform: translateY(0); 
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2); 
        }

        h1 {
            font-size: 28px;
            color: #333; 
            margin-bottom: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome</h1> 
        <div class="form-element">
            <asp:Button ID="Button1" runat="server" Text="Admin" 
                CssClass="blue-button" OnClick="Button1_Click" />
        </div>
        <div class="form-element">
            <asp:Button ID="Button2" runat="server" Text="Customer" 
                CssClass="blue-button" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
