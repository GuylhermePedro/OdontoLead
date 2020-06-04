<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="View.publico.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="CPF:"></asp:Label>
        </div>
        <asp:TextBox ID="txtCpf" runat="server" MaxLength="14"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
        <br />
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Login" Width="127px" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" Width="131px" />
    </form>
</body>
</html>
