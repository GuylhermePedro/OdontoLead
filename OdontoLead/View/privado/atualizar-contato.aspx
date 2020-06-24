<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="atualizar-contato.aspx.cs" Inherits="View.privado.atualizar_contato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Atualizar</title>
    <link rel="shortcut icon" href="~/publico/imagens/favicon.ico" " />
    <link href="/publico/estilos/EstilosAtualizar.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
        </div>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label>
        <br />
        <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label>
        <br />
        <asp:DropDownList ID="dropSexo" runat="server" Width="315px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Feminino</asp:ListItem>
            <asp:ListItem>Masculino</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Origem"></asp:Label>
        <br />
        <asp:DropDownList ID="dropOrigem" runat="server">
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
        <br />
        <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
        <br />
        <asp:DropDownList ID="dropStatus" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Aguardando Contato</asp:ListItem>
            <asp:ListItem>Em conversa</asp:ListItem>
            <asp:ListItem>Não respondeu </asp:ListItem>
            <asp:ListItem>Agendado</asp:ListItem>
            <asp:ListItem>Avaliado</asp:ListItem>
            <asp:ListItem>Cliente</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar" Width="314px" />
        <br />
        <asp:HyperLink ID="hpVoltar" runat="server" NavigateUrl="~/privado/lista-contatos.aspx">Voltar</asp:HyperLink>
    </form>
</body>
</html>
