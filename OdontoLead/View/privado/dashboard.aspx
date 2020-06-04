<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="View.privado.dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Dashboard"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnContato" runat="server" Text="CONTATO" OnClick="btnContato_Click" />
            <br />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ADICIONAR CONTATO" />
        <br />
        <br />
        <asp:Button ID="btnRelatorio" runat="server" Text="RELATORIO" />
    </form>
</body>
</html>
