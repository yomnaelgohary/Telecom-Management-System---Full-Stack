<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerlogin.aspx.cs" Inherits="WebApplication1.customerlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login</title>
    <style type="text/css">
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f0f4f7; 
            color: #333; 
            margin: 0;
            height: 100%;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .form-container {
            background-color: #fff;
            padding: 40px;
            border-radius: 12px;
            box-shadow: 0 6px 20px rgba(0, 0, 0, 0.1);
            width: 350px;
            text-align: center;
        }

        .form-container h2 {
            color: #2563EB;
            margin-bottom: 30px;
        }

        .form-container label {
            font-weight: bold;
            margin-bottom: 10px;
            display: block;
            text-align: left;
        }

        .form-container input {
            width: 100%;
            padding: 12px;
            margin-bottom: 20px;
            border-radius: 8px;
            border: 1px solid #ddd;
            font-size: 16px;
            color: #333;
        }

        .form-container input:focus {
            outline: none;
            border-color: #2563EB;
        }

        .login-button {
            background-color:#2563EB; 
            color: #fff;
            padding: 15px 0;
            border: none;
            border-radius: 8px;
            font-size: 18px;
            width: 100%;
            cursor: pointer;
            transition: background-color 0.3s ease, transform 0.2s ease;
        }

        .login-button:hover {
            background-color: #1D4ED8;
            transform: translateY(-2px); 
        }

        .login-button:active {
            background-color: #1D4ED8;
            transform: translateY(0); 
        }

        .error-message {
            color: red;
            font-size: 14px;
            margin-bottom: 10px;
        }

        .form-container .info-text {
            font-size: 14px;
            color: #777;
            margin-top: 20px;
        }

        .form-container .info-text a {
            color: #2563EB;
            text-decoration: none;
        }

        .form-container .info-text a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Please Enter Your Account Mobile Number and Password to Login</h2>

            <div class="form-element">
                <label for="MobileNumber">Mobile Number</label>
                <asp:TextBox ID="MobileNumber" runat="server" CssClass="form-input"></asp:TextBox>
            </div>

            <div class="form-element">
                <label for="Password">Password</label>
                <asp:TextBox ID="Password" runat="server" CssClass="form-input" TextMode="Password"></asp:TextBox>
            </div>

            <!-- Error message for invalid input -->
            <asp:Label ID="ErrorLabelmob" runat="server" CssClass="error-message" Visible="False" />
             <br />
             <br />

            <!-- Login Button -->
            <asp:Button ID="Loginbutton" runat="server" OnClick="Loginclick" Text="Login"  ForeColor="White" CssClass="login-button" />

            <!-- General exception/error label -->
            <asp:Label ID="Exceplabel" runat="server" CssClass="error-message" Visible="False" />
            <br />
              <br />

            <asp:Label ID="Exceplabel2" runat="server" CssClass="error-message" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click1" />
        </div>
    </form>
</body>
</html>
