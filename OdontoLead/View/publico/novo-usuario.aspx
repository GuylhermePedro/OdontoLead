<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="novo-usuario.aspx.cs" Inherits="View.publico.cadastro_usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
            <br />
        </div>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="CPF:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCpf" runat="server" Width="119px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="E-Mail:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Telefone:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Senha:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
        </p>
    </form>
</body>
</html>
