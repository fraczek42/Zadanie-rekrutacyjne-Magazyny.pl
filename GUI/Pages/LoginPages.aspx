<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPages.aspx.cs" Inherits="GUI.Pages.LoginPages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html" charset="utf-8"/>
    <title>Logowanie - Magazyny.pl</title>
    <link href="../Content/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="loginbox">

            <div class ="logo">
                 <h1 class="text-with-gardient">MAGAZYNY.PL</h1>
            </div>

            <div class="register">
                <h2>Logowanie</h2>
            </div>

            <div class ="text-box text-box-login">
                <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
                <asp:TextBox CssClass="textbox textbox-login" ID="Txb_login" runat="server"></asp:TextBox>
            </div>

            <div class ="text-box text-box-pass">
                <asp:Label ID="Label2" runat="server" Text="Hasło:"></asp:Label>
                <asp:TextBox CssClass="textbox textbox-pass" ID="Txb_pass" runat="server"></asp:TextBox>
            </div>
            
            <div class="btn_login">
                <asp:Button CssClass="btnlogin" ID="Btn_login" runat="server" Text="Zaloguj się!" />
            </div>

        </div>

    </form>
</body>
</html>
