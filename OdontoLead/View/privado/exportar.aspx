<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exportar.aspx.cs" Inherits="View.privado.exportar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dropOrigem" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Facebook</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:DropDownList ID="dropStatus" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Aguardando Contato</asp:ListItem>
            </asp:DropDownList>
            <br />
        </div>
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="Exportar" />
    </form>
</body>
</html>
