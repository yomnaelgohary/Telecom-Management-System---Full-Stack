<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SMSoffers.aspx.cs" Inherits="WebApplication1.sms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
    html, body {
        height: 100%;
        margin: 0;
    }
    body {
        display: flex;
        justify-content: center;  
        align-items: center;      
        background-color: #f0f0f0;
    }


    form {
        background-color: white;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    }

    .form-element {
        margin-bottom: 15px;
    }
</style>
        <style>
    .blue-button {
        background-color: darkblue;
        color: white;
        padding: 10px 20px;
        border: none;
        border-radius: 5px;
        cursor: pointer;
    }

    .blue-button:hover {
        background-color: darkblue;
    }
</style>
                <style>
      .back-button {
        background-color: lightgrey;
        color: black;
        padding: 10px 20px;
        border: none;
        border-radius: 5px;
        cursor: pointer;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="List all SMS offers"  style="font-weight: bold; font-size: 24px; text-align: center; display: block; margin: 0 auto;"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter your mobile number"></asp:Label>
            <br />
            <asp:TextBox ID="mobileb" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="submit" CssClass="blue-button" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server"><HeaderStyle BackColor="darkblue" ForeColor="White" /></asp:GridView>
            <br />
            <asp:Label ID="Label3" runat="server" Text="" ForeColor="Red"></asp:Label>  
            <br />
            <asp:Button ID="BackButton" runat="server" Text="Back" CssClass="back-button" OnClick="BackButton_Click" />
        </div>
    </form>
</body>
</html>
