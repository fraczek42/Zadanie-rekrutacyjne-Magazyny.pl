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

            <div class="text-admin">
                <h2 class="textAdmin">STRONA ADMINISTRATORA</h2>
            </div>

            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="Btn_AddPartsPage" runat="server" Text="Dodaj część" />
            </div>
            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="Button1" runat="server" Text="Stan magazyny" />
            </div>
            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="Btn_ReceiptOfGoods" runat="server" Text="Kiedy towar został przyjęty" />
            </div>
            <div class="btn-admin">
                 <asp:Button CssClass="btnAdmin" ID="Btn_DeliveryOfTheGoods" runat="server" Text="Kiedy towar został wydany" />
            </div>

        </div>

    </form>
</body>
</html>
