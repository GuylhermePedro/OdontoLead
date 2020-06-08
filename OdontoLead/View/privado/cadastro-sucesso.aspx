﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro-sucesso.aspx.cs" Inherits="View.privado.cadastro_sucesso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="/publico/estilos/EstiloCadastroSucesso.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="91px" ImageUrl="~/publico/imagens/kisspng-check-mark-computer-icons-ok-clip-art-5ae1d51da92964.png" Width="119px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="CONTATO CADASTRADO"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contato foi cadastrado com sucesso, para ver sua lista de contatos clique no botão abaixo!"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnNovo" runat="server" Text="ADICIONAR NOVO" OnClick="btnNovo_Click" Width="316px" />
            <br />
            <br />
            <asp:Button ID="btnGerenciar" runat="server" Text="GERENCIAR CONTATOS" OnClick="btnGerenciar_Click" Width="315px" />
            <br />
            <br />
            <asp:HyperLink ID="hpMenu" runat="server" NavigateUrl="~/privado/dashboard.aspx">Menu</asp:HyperLink>
        </div>
    </form>
</body>
</html>