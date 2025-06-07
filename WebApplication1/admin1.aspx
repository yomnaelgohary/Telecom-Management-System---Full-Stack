<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin1.aspx.cs" Inherits="WebApplication1.admin1" %>

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
            <asp:Button ID="v2" runat="server" Text="View customer profiles" CssClass="blue-button" OnClick="v2_Click1" />
            <asp:Button ID="v3" runat="server" Text="View physical stores" CssClass="blue-button" OnClick="v3_Click" />
            <asp:Button ID="v4" runat="server" Text="View resolved tickets" CssClass="blue-button" OnClick="v4_Click" />
            <asp:Button ID="p5" runat="server" Text="View customers’ accounts " CssClass="blue-button" OnClick="p5_Click" />
            <br />
            <br />
            <asp:Button ID="f6" runat="server" Text="List all customer accounts" CssClass="blue-button" OnClick="f6_Click" />
            <asp:Button ID="f7" runat="server" Text="Show the total usage" CssClass="blue-button" OnClick="f7_Click" />
            <asp:Button ID="p8" runat="server" Text="Remove all benefits" CssClass="blue-button" OnClick="p8_Click" />
            <asp:Button ID="f9" runat="server" Text="List all SMS offers" CssClass="blue-button" OnClick="p9_Click"/>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Click for more" CssClass="blue-button" OnClick="Button1_Click" />
            <br />
            <br />
             <asp:Button ID="BackButton" runat="server" Text="Back" CssClass="back-button" OnClick="BackButton_click"  />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"> <HeaderStyle BackColor="darkblue" ForeColor="White" /> </asp:GridView>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="True"><HeaderStyle BackColor="darkblue" ForeColor="White" /> </asp:GridView>
            <br />
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="True"> <HeaderStyle BackColor="darkblue" ForeColor="White" /> </asp:GridView>
            <br />
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="True"><HeaderStyle BackColor="darkblue" ForeColor="White" /></asp:GridView>

        </div>
    </form>
</body>
</html>
