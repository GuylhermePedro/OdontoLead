using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View.privado
{
    public partial class exportar : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            Lead lead = new Lead();

            lead.origem_lead = dropOrigem.Text;
            lead.status = dropStatus.Text;
            lead.clinina = UsuarioLogado;

            List<Lead> ll = new LeadController().Exportar(lead);

            StringBuilder strDados = new StringBuilder(100000);

            // Itens necessários para importação
            strDados.Append("<html><head><META HTTP-EQUIV=\"Content-Type\" CONTENT=\"text/html; charset=ISO-8859-1\"></head><body>");

            // Início da tabela
            strDados.Append("<table width='100%' style='font-family: Calibri; font-size: 12px;'>");

            // Cabeçalho da lista
            strDados.Append(String.Concat("<tr style='font-weight: bolder; color: white;'><td style='background-color: #5D7B9D;' align='left'>Nome</td><td style='background-color: #5D7B9D;' align='left'>Telefone</td><td style='background-color: #5D7B9D;' align='center'>Genero</td><td style='background-color: #5D7B9D;' align='left'>Data de Contato</td><td style='background-color: #5D7B9D;' align='left'>Origem</td><td style='background-color: #5D7B9D;' align='left'>Status</td>"));
            // Laço para incrementar a lista
            foreach (Lead item in ll)
            {

                strDados.Append("<tr>");

                strDados.Append(String.Concat("<td>", item.nome_lead, "</td>"));
                strDados.Append(String.Concat("<td>", item.fone_lead, "</td>"));
                strDados.Append(String.Concat("<td>", item.sexo_lead, "</td>"));
                strDados.Append(String.Concat("<td>", item.data_lead.ToString("dd/MM/yyyy"), "</td>"));
                strDados.Append(String.Concat("<td>", item.origem_lead, "</td>"));
                strDados.Append(String.Concat("<td>", item.status, "</td>"));

                strDados.Append("</tr>");

            }

            strDados.Append("</table>");
            strDados.Append("</body></html>");

            Response.Clear();
            Response.AddHeader("content-disposition", "attachment;filename=Relatorio.xls");
            Response.Charset = String.Empty;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.xls";

            Response.Write(strDados.ToString());
        }
    }
}