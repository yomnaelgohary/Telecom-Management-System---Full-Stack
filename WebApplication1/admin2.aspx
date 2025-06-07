<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin2.aspx.cs" Inherits="WebApplication1.admin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
     <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
                    <style>
    body {
        font-family: 'Verdana', sans-serif;
        background-color: #eff7ff; /* Light cyan background color */
        margin: 0;
        padding: 20px;
    }
    
</style>
            <br />
            <br />
            <span style="font-family: 'Verdana', sans-serif; font-size: 18px; color: darkblue; font-weight: normal;">
            Click To View :
            </span>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  CssClass="custom-button" Text="Wallets Details" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" CssClass="custom-button" Text="E-shops" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" CssClass="custom-button" Text="Payments' Transaction" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" CssClass="custom-button" Text="Total Number Of Cashback Transactions" />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <br /> 
            <br />
            <span style="font-family: 'Verdana', sans-serif; font-size: 18px; color: darkblue; font-weight: normal;">
            Enter Mobile-Number:
            </span>
                                          
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="rounded-shadow-textbox" > </asp:TextBox> 
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" CssClass="custom2-button" Text="Accepted Transactions And Earned Points" />
             <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" CssClass="custom2-button" Text="Is it linked to a wallet?" />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" CssClass="custom2-button" Text="Update Points" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"  CssClass="label-style" Text=""></asp:Label>
            <br />
            <br />
            <br />
           
            <span style="font-family: 'Verdana', sans-serif; font-size: 18px; color: darkblue; font-weight: normal;">
            Enter Wallet-ID:
            </span>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="rounded-shadow-textbox"></asp:TextBox>
            <br />
            <span style="font-family: 'Verdana', sans-serif; font-size: 18px; color: darkblue; font-weight: normal;">
            Enter Plan-ID:
            </span>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="rounded-shadow-textbox" ></asp:TextBox>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" CssClass="custom2-button" Text="Show CashBack" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" CssClass="label-style" Text=""></asp:Label>
            <br />
            <br />
            <br />
           <span style="font-family: 'Verdana', sans-serif; font-size: 18px; color: darkblue; font-weight: normal;">
           Enter Wallet-ID:
           </span>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" CssClass="rounded-shadow-textbox"></asp:TextBox>
            <br />
            <span style="font-family: 'Verdana', sans-serif; font-size: 18px; color: darkblue; font-weight: normal;">
            Enter Start-Date:
            </span>
            <br />
            <asp:TextBox ID="TextBox5" runat="server" CssClass="rounded-shadow-textbox" ></asp:TextBox>
            <br />
            <span style="font-family: 'Verdana', sans-serif; font-size: 18px; color: darkblue; font-weight: normal;">
            Enter End-Date:
            </span>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" CssClass="rounded-shadow-textbox" ></asp:TextBox>
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" CssClass="custom2-button" Text="Show the average of the sent transaction amounts" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" CssClass="label-style" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
            <asp:GridView ID="GridView3" runat="server"></asp:GridView>
            <asp:GridView ID="GridView4" runat="server"></asp:GridView>
        <br />
        <asp:Button ID="Button10" runat="server"  CssClass="custom-button" Text="Back" OnClick="Button10_Click" />
       
    </form>
</body>
</html>
