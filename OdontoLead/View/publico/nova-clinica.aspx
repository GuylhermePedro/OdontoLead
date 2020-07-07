<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nova-clinica.aspx.cs" Inherits="View.publico.nova_clincia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro</title>
    <link rel="shortcut icon" href="~/publico/imagens/favicon.ico"/>
     <link href="/publico/estilos/EstiloNovaClinica.css" rel="stylesheet" type="text/css" />
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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="114px" ImageUrl="~/publico/imagens/icone.png" Width="208px" style="margin-top: 0px" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Cadastre-se"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Insira os dados nos campos abaixo para realizar o seu cadastro."></asp:Label>
            <asp:TextBox ID="txtNomeClinica" runat="server" placeholder="Nome da Clínica:"></asp:TextBox>
        </div>
        <br />
        <asp:TextBox ID="txtCNPJ" runat="server" MaxLength="14" placeholder="CNPJ:"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço:"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail:"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" placeholder="Senha:"></asp:TextBox>
        <p>
            <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" Width="312px" />
        </p>
        <p>
            <asp:HyperLink ID="hpLogin" runat="server" NavigateUrl="~/publico/inicio.aspx">Clique Aqui para Realizar Login</asp:HyperLink>
        </p>
    </form>
</body>
</html>
