<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="View.publico.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link rel="shortcut icon" href="~/publico/imagens/favicon.ico" " />
    <link href="/publico/estilos/EstiloLogin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Image ID="Image1" runat="server" Height="101px" ImageUrl="~/publico/imagens/odontolead.png" Width="312px" />
            <br />
            <br />
        </div>
        <asp:Label ID="lblEntrar" runat="server" Text="Entrar"></asp:Label>
        <br />
        <asp:Label ID="lblDescricao" runat="server" Text="Se você já possui login, preencha seus dados de acesso a plataforma"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtCpf" runat="server" MaxLength="14" placeholder="CNPJ:"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtSenha" runat="server" placeholder="SENHA:" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Acessar" Width="312px" />
        <br />
        <br />
        <asp:HyperLink ID="hpCadastro" runat="server" NavigateUrl="~/publico/nova-clincia.aspx">Ainda não possui login? Clique Aqui para se Cadastrar</asp:HyperLink>
    </form>
</body>
</html>
