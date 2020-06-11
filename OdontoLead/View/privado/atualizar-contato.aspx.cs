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
    public partial class atualizar_contato : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["itemSel"] != null)
            {
                Carregar();
            }
        }

        public void Carregar()
        {

            Lead l= new Lead();

            l.idlead = int.Parse(Request.QueryString["itemSel"]);

            l.clinina = UsuarioLogado;

           l = new LeadController().ListarAlt(l)[0];

            ViewState.Add("itemSel", l);

            txtNome.Text = l.nome_lead;
            txtTel.Text = l.fone_lead;
            dropSexo.Text = l.sexo_lead;
            dropOrigem.Text = l.origem_lead;
            dropStatus.Text = l.status;

        }

        public void Alterar()
        {
            try
            {

                Lead lead = (Lead)ViewState["itemSel"];

                lead.nome_lead = txtNome.Text;
                lead.fone_lead = txtTel.Text;
                lead.sexo_lead = dropSexo.Text;
                lead.sexo_lead = dropSexo.Text;
                lead.status = dropStatus.Text;
                lead.clinina = UsuarioLogado;

                new LeadController().Atualizar(lead);

                Response.Redirect("/privado/cadastro-sucesso.aspx");

            }
            catch (ConsistenciaException ex)
            {
                ExibirMensagemAlert(ex.Mensagem);
            }

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
    }
}