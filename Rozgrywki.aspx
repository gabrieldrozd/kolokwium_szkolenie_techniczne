<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rozgrywki.aspx.cs" Inherits="kolokwium.Rozgrywki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div>
                <asp:Label ID="lblDruzyna1" runat="server" Text="Gospodarz"></asp:Label>
                <asp:DropDownList ID="ddlDruzyna1" runat="server"></asp:DropDownList>
            </div>

            <div>
                <asp:Label ID="lblWynik" runat="server" Text="Wynik"></asp:Label>
                <asp:TextBox ID="txtWynik" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="lblDruzyna2" runat="server" Text="Przyjezdny"></asp:Label>
                <asp:DropDownList ID="ddlDruzyna2" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div>
            <asp:Label ID="lblTypRozgrywek" runat="server" Text="Typ Rozgrywek"></asp:Label>
            <asp:DropDownList ID="ddlTypRozgrywek" runat="server"></asp:DropDownList>
        </div>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
    </form>
</body>
</html>
