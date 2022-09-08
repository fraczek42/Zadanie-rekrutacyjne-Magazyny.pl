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
            <div class ="grid-view">
                <asp:GridView CssClass="gridView" ID="GvState" runat="server" Height="218px" Width="347px">
                    </asp:GridView>
            </div>

        </div>

    </form>
</body>
</html>
