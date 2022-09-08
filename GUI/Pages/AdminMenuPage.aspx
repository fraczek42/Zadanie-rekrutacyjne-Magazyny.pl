<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMenuPage.aspx.cs" Inherits="GUI.Pages.AdminMenuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/Style.css" rel="stylesheet" />
    <title>Admin Menu</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="menubox">

            <div class ="logo">
                 <h1 class="text-with-gardient">MAGAZYNY.PL</h1>
            </div>

            <div class="text-description">
                <h2 class="textDescription">STRONA ADMINISTRATORA</h2>
            </div>

            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="BtnAddPartPage" runat="server" Text="Dodaj część" OnClick="BtnAddPartPage_Click" />
            </div>
            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="BtnState" runat="server" Text="Stan magazyny" OnClick="BtnState_Click" />
            </div>
            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="BtnReceiptOfGoods" runat="server" Text="Kiedy towar został przyjęty" />
            </div>
            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="BtnDeliveryOfTheGoods" runat="server" Text="Kiedy towar został wydany" />
            </div>

        </div>

    </form>
</body>
</html>
