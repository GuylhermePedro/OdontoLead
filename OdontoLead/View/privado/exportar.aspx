<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exportar.aspx.cs" Inherits="View.privado.exportar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Exportar</title>
    <link rel="shortcut icon" href="~/publico/imagens/favicon.ico"/>
    <link href="/publico/estilos/EstiloExportar.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="94px" ImageUrl="~/publico/imagens/724827.png" Width="95px" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Para gerar o relatório de contatos em Excel selecione os campos desejados. Para ver todos os contatos deixe os campos em branco  "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Origem"></asp:Label>
            <br />
            <asp:DropDownList ID="dropOrigem" runat="server" Height="55px" Width="315px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Facebook</asp:ListItem>
                <asp:ListItem>Instagram </asp:ListItem>
                <asp:ListItem>Google</asp:ListItem>
                <asp:ListItem>Televisão</asp:ListItem>
                <asp:ListItem>Rádio</asp:ListItem>
                <asp:ListItem>Outdoor</asp:ListItem>
                <asp:ListItem>Parcerias</asp:ListItem>
                <asp:ListItem>Site</asp:ListItem>
                <asp:ListItem>Desconhecido</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Status"></asp:Label>
            <br />
            <asp:DropDownList ID="dropStatus" runat="server" Height="55px" Width="315px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Aguardando Contato</asp:ListItem>
                <asp:ListItem>Em conversa</asp:ListItem>
                <asp:ListItem>Não respondeu </asp:ListItem>
                <asp:ListItem>Agendado</asp:ListItem>
                <asp:ListItem>Avaliado</asp:ListItem>
                <asp:ListItem>Cliente</asp:ListItem>
            </asp:DropDownList>
            <br />
        </div>
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="EXPORTAR" Height="48px" Width="315px" />
        <br />
        <asp:HyperLink ID="hpVoltar" runat="server" NavigateUrl="~/privado/dashboard.aspx">Voltar</asp:HyperLink>
    </form>
</body>
</html>
