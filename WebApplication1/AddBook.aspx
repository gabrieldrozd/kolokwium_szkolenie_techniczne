<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="WebApplication1.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Book Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblBookType" runat="server" Text="Book Type"></asp:Label>
            <asp:DropDownList ID="ddlBookType" runat="server"></asp:DropDownList>
        </div>

        <div>
            <asp:Label ID="lblNumberOfPages" runat="server" Text="Number of pages"></asp:Label>
            <asp:TextBox ID="txtNumberOfPages" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblReleaseDate" runat="server" Text="Released at"></asp:Label>
            <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
