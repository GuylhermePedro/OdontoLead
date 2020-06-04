using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View.privado
{
    public partial class novo_contato : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        public void Incluir()
        {
            try
            {

                Lead lead = new Lead();

                lead.nome_lead = txtNome.Text;
                lead.fone_lead = txtTelefone.Text;
                lead.data_lead = Convert.ToDateTime(txtData.Text);
                lead.descricao_lead = txtDescricao.Text;
                lead.origem_lead = DropOrigem.Text;
                lead.sexo_lead = DropSexo.Text;
                lead.clinina = UsuarioLogado;

                new LeadController().incluir(lead);

                Response.Redirect("/privado/dashboard.aspx");

            }
            catch (ConsistenciaException ex)
            {
                ExibirMensagemAlert(ex.Mensagem);
            }
        }
    }
}