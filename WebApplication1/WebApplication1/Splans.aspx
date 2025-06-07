<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Splans.aspx.cs" Inherits="WebApplication1.Splans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>Service Plans</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 800px;
            margin: 50px auto;
            padding: 20px;
            background: #ffffff;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }
        h1 {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
        }
        .input {
            width: calc(100% - 20px);
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
            display: block;
            margin: 0 auto;
        }
        .btn {
            width: 100%;
            background: #007bff;
            color: #fff;
            padding: 10px;
            border: none;
            border-radius: 4px;
            font-size: 16px;
            cursor: pointer;
        }
        .btn:hover {
            background: #0056b3;
        }
        .table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        .table th, .table td {
            padding: 10px;
            text-align: left;
            border: 1px solid #ddd;
        }
        .table th {
            background-color: #f4f4f4;
        }
        .errorMessage {
            margin-top: 20px;
            text-align: center;
            color: red;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Service Plans Subscribed in the Last 5 Months</h1>
            <asp:TextBox ID="txtMobileNo" runat="server" CssClass="input" placeholder="Enter Mobile Number"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table">
                <Columns>
                    <asp:BoundField DataField="planID" HeaderText="Plan ID" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="price" HeaderText="Price" />
                    <asp:BoundField DataField="SMS_offered" HeaderText="SMS Offered" />
                    <asp:BoundField DataField="minutes_offered" HeaderText="Minutes Offered" />
                    <asp:BoundField DataField="data_offered" HeaderText="Data Offered" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" CssClass="errorMessage"></asp:Label>
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="back" />
        </div>
    </form>
</body>
</html>

