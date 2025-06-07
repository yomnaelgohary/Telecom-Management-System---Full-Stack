<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="benefittable.aspx.cs" Inherits="WebApplication1.benefittable" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Active Benefits</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f8ff;
            color: #333;
            margin: 0;
            padding: 0;
        }

        #form1 {
            margin: 20px;
        }

        .label-heading {
            color: #1E90FF;
            text-align: center;
            font-size: 2em;
            display: block;
        }

        .gridview-style {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
            border: 1px solid #ddd;
        }

        .gridview-style th, .gridview-style td {
            padding: 8px 12px;
            text-align: center;
            border: 1px solid #ddd;
        }

        .gridview-style th {
            background-color: #1E90FF;
            color: white;
        }

        .gridview-style tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .gridview-style tr:hover {
            background-color: #ddd;
        }

        .btn-back {
            background-color: #1E90FF;
            color: white;
            border: none;
            padding: 10px 20px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            text-align: center;
            display: inline-block;
            transition: background-color 0.3s;
        }

        .btn-back:hover {
            background-color: #4682B4;
        }

        .btn-back:active {
            background-color: #5F9EA0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="LabelHeading" runat="server" Text="All Active Benefits" CssClass="label-heading"></asp:Label>
        
        <asp:GridView ID="GridViewbenifits" runat="server" CssClass="gridview-style">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="backbutton" runat="server" Text="Back" OnClick="backbutton_Click" CssClass="btn-back" />
    </form>
</body>
</html>
