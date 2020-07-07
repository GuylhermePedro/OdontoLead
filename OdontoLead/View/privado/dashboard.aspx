<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="View.privado.dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu</title>
    <link rel="shortcut icon" href="~/publico/imagens/favicon.ico"/>
    <link href="/publico/estilos/EstiloDashboard.css" rel="stylesheet" type="text/css" />
    <!-- Global site tag (gtag.js) - Google Analytics -->
<script async src="https://www.googletagmanager.com/gtag/js?id=UA-171631241-1"></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'UA-171631241-1');
</script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="112px" ImageUrl="~/publico/imagens/threefree-img.png" Width="110px" />
            <br />
            <br />
            <asp:Button ID="btnContato" runat="server" Text="GERENCIAR CONTATOS" OnClick="btnContato_Click" Width="313px" />
            <br />
            <br />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ADICIONAR CONTATO" Width="315px" />
        <br />
        <br />
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="EXPORTAR" Width="315px" />
    </form>
</body>
</html>
