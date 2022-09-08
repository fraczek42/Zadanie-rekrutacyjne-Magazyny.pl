<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPartPage.aspx.cs" Inherits="GUI.Pages.AddPart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/Style.css" rel="stylesheet" />
    <title>Dodaj część</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="menubox">

            <div class ="logo">
                 <h1 class="text-with-gardient">MAGAZYNY.PL</h1>
            </div>

            <div class="text-description">
                <h2 class="textDescription">DODAJ CZĘŚĆ
                </h2>
            </div>
            <div class ="txb-name">
                <asp:Label ID="Label1" runat="server" Text="Nazwa części : "></asp:Label>
                <asp:TextBox CssClass="txbName" ID="txbName" runat="server"></asp:TextBox>
            </div>
            <div class ="txb-description">
                <asp:Label ID="Label2" runat="server" Text="Opis części : "></asp:Label>
                <asp:TextBox CssClass="txbDescription" ID="txbDescription" runat="server"></asp:TextBox>
            </div>
            <div class="btn-padding-top">
                <asp:Button CssClass="btnAdmin" ID="BtnAddPart" runat="server" Text="Dodaj część" OnClick="BtnAddPart_Click" />
            </div>

        </div>

    </form>
</body>
</html>
