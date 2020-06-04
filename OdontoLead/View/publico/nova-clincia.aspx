<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nova-clincia.aspx.cs" Inherits="View.publico.nova_clincia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome da Clíncia"></asp:Label>
            <br />
            <asp:TextBox ID="txtNomeClinica" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="CNPJ"></asp:Label>
        <br />
        <asp:TextBox ID="txtCNPJ" runat="server" MaxLength="14"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Senha"></asp:Label>
        <br />
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
        </p>
    </form>
</body>
</html>
