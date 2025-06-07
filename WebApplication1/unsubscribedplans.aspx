<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unsubscribedplans.aspx.cs" Inherits="WebApplication1.unsubscribedplans" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unsubscribed Service Plans</title>
    <style>
        /* General page styling */
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
        }

        h2 {
            text-align: center;
            color: #1E90FF;
            margin-bottom: 30px;
        }

        /* Gridview styling */
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

        /* Button styling */
        .button {
            background-color: grey; /* Set the background color to grey */
            color: white;
            padding: 12px 24px;
            border: none;
            border-radius: 25px;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s, box-shadow 0.3s;
            margin-top: 20px;
            display: inline-block;
            width: auto;
        }

        .button:hover {
            background-color: #6c757d; /* Darker grey for hover effect */
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.3);
        }

        .button:active {
            background-color: #5a6268; /* Even darker grey for active state */
        }

        .button:focus {
            outline: none;
        }

        /* Error message styling */
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
            <h2>Unsubscribed Service Plans</h2>

            <!-- GridView for displaying data -->
            <asp:GridView ID="grid" runat="server" CssClass="gridview"></asp:GridView>

            <!-- Error message section -->
            <div class="error-message">
                <asp:Label ID="Label2" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            </div>

            <!-- Back Button with grey styling -->
            <asp:Button ID="Back" runat="server" Text="Back" ForeColor="White" OnClick="Back_Click" CssClass="button" />
        </div>
    </form>
</body>
</html>
