<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lista-contatos.aspx.cs" Inherits="View.privado.lista_contatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtPesquisar" runat="server" Width="166px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" Width="129px" OnClick="btnPesquisar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="Exportar" />
            <br />
            <asp:GridView ID="dgvLista" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" Height="143px"  Width="726px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField HeaderText="Nome " DataField="nome_lead" />
                    <asp:BoundField HeaderText="Telefone" DataField="fone_lead" />
                    <asp:BoundField HeaderText="Genero " DataField="sexo_lead" />
                    <asp:BoundField HeaderText="Data de Contato" DataField="data_lead" />
                    <asp:BoundField HeaderText="Origem " DataField="origem_lead" />
                    <asp:BoundField DataField="status" HeaderText="Status" />
                    <asp:BoundField HeaderText="Editar" />
                    <asp:BoundField HeaderText="Excluir " />
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
