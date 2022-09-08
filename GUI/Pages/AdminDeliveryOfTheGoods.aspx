<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDeliveryOfTheGoods.aspx.cs" Inherits="GUI.Pages.AdminDeliveryOfTheGoods" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Historia magazynu - Admin</title>
    <link href="../Content/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="menubox">

            <div class ="logo">
                 <h1 class="text-with-gardient">MAGAZYNY.PL</h1>
            </div>

            <div class="text-description">
                <h2 class="textDescription">HISTORIA TOWARU</h2>
            </div>

            <div class="gridV">
                <asp:GridView ID="GvDeliveryOfTheGoods" AutoGenerateColumns="false" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="id_parts_issued" SortExpression="id_parts_issued" />
                        <asp:BoundField HeaderText="Nazwa części" DataField="name_part" SortExpression="name_part" />
                        <asp:BoundField HeaderText="Seria wydania" DataField="series_of_outputs" SortExpression="series_of_outputs" />
                        <asp:BoundField HeaderText="Nazwisko osoba przyjmującej na magazyn" DataField="last_name_user" SortExpression="last_name_user" />
                        <asp:BoundField HeaderText="Nazwisko osoba wydającej z magazynu" DataField="last_name_user" SortExpression="last_name_user" />
                        <asp:BoundField HeaderText="Data przyjęcia na magazyn" DataField="date_take" SortExpression="date_take" DataFormatString="{0:dd-MM-yyyy}" />
                        <asp:BoundField HeaderText="Data wydania z magazynu" DataField="date_spend" SortExpression="date_spend" DataFormatString="{0:dd-MM-yyyy}" />
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
