<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WarehousePage.aspx.cs" Inherits="GUI.Pages.WarehousePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Magazyny.pl</title>
    <link href="../Content/StyleWarehouse.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="menubox">

            <div class ="logo">
                 <h1 class="text-with-gardient">MAGAZYNY.PL</h1>
            </div>

            <div class="text-description">
                <h2 class="textDescription">MAGAZYN</h2>
            </div>

            <div class="gridV">
                <asp:GridView ID="GvWarehouse" AutoGenerateColumns="false" runat="server" OnRowCommand="GvWarehouse_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="id_stock_status" SortExpression="id_stock_status" />
                        <asp:BoundField HeaderText="Nazwa części" DataField="name_part" SortExpression="name_part" />
                        <asp:BoundField HeaderText="Seria" DataField="series" SortExpression="series" />
                        <asp:BoundField HeaderText="Data przyjęcia na magazyn" DataField="date_take" SortExpression="date_take" />
                        <asp:BoundField HeaderText="Imie osoby przyjmującej na magazyn" DataField="name_user" SortExpression="name_user" />   
                        <asp:BoundField HeaderText="Nazwisko osoba przyjmującej na magazyn" DataField="last_name_user" SortExpression="last_name_user" />  
                        <asp:ButtonField ButtonType="Button" HeaderText="Wydaj" Text="Wydaj część" CommandName="spend"/>
                    </Columns>
                </asp:GridView>
            </div>
            
            <div class="seriesDiv">
                 <span>Numer paczki wydanej : </span>
                 <asp:TextBox ID="TxbSeriesOut" runat="server" Text="0"></asp:TextBox>
                 <span>(wartość "0" oznacza brak paczki)</span>
            </div>
            <p></p>
            <div class="addPart">
                 <span>Wybierz część : </span>
                 <asp:DropDownList ID="DdlParts" runat="server" >
                 </asp:DropDownList>
                 <p>
                     <span>Numer paczki przyjętej : </span>
                     <asp:TextBox ID="TxbSeries" runat="server" Text="0"></asp:TextBox>
                     <span>(wartość "0" oznacza brak paczki)</span>
                 </p>
                 <p>
                     <asp:Button CssClass="btn" ID="btnAddPart" runat="server" Text="Dodaj część na stan magazynu" OnClick="BtnAddPart_Click" />
                 </p>
                </div>
        </div>

    </form>
</body>
</html>
