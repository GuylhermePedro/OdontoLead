<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="novo-contato.aspx.cs" Inherits="View.privado.novo_contato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="/publico/estilos/EstiloNovoContato.css" rel="stylesheet" type="text/css" />
      <script>
        function funcao1()
        {
        alert("Eu sou um alert!");
        }
      </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome "></asp:Label>
        </div>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label>
        </p>
        <asp:DropDownList ID="DropSexo" runat="server" Height="65px" Width="315px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Feminino </asp:ListItem>
            <asp:ListItem>Masculino</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Data de Contato"></asp:Label>
        </p>
        <asp:TextBox ID="txtData" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Origem"></asp:Label>
        <br />
        <asp:DropDownList ID="DropOrigem" runat="server" Height="65px" Width="315px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Facebook</asp:ListItem>
            <asp:ListItem>Site</asp:ListItem>
            <asp:ListItem>Rádio</asp:ListItem>
            <asp:ListItem>TV</asp:ListItem>
            <asp:ListItem>Desconhecido </asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Status"></asp:Label>
        <br />
        <asp:DropDownList ID="DropStatus" runat="server" Height="65px" Width="315px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Aguardando Contato</asp:ListItem>
            <asp:ListItem>Em conversa</asp:ListItem>
            <asp:ListItem>Agendado</asp:ListItem>
            <asp:ListItem>Avaliado</asp:ListItem>
            <asp:ListItem>Cliente</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click"  Width="320px" />
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/privado/dashboard.aspx">Voltar</asp:HyperLink>
    </form>
</body>
</html>
