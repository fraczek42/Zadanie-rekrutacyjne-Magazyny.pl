<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStockStatusPage.aspx.cs" Inherits="GUI.Pages.AdminStockStatusPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Stan magazynu - Admin</title>
    <link href="../Content/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="menubox">

            <div class ="logo">
                 <h1 class="text-with-gardient">MAGAZYNY.PL</h1>
            </div>

            <div class="text-description">
                <h2 class="textDescription">STAN MAGAZYNU</h2>
            </div>

            <div class="gridV">
                <asp:GridView ID="GvStockStatus" AutoGenerateColumns="false" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="id_stock_status" SortExpression="id_stock_status" />
                        <asp:BoundField HeaderText="Nazwa części" DataField="name_part" SortExpression="name_part" />
                        <asp:BoundField HeaderText="Seria" DataField="series" SortExpression="series" />
                        <asp:BoundField HeaderText="Data przyjęcia na magazyn" DataField="date_take" SortExpression="date_take" DataFormatString="{0:dd-MM-yyyy}" />
                        <asp:BoundField HeaderText="Osoba przyjmująca na magazyn" DataField="name_user" SortExpression="name_user" />                       
                    </Columns>
                </asp:GridView>
            </div>
            <div class="btn-padding-top">
                <asp:Button CssClass="btnAdmin" ID="BtnBack" runat="server" Text="Cofnij" OnClick="BtnBack_Click" />
            </div>
        </div>

    </form>
</body>
</html>
