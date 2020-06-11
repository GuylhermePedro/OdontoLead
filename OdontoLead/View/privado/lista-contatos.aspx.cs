using Controller;
using Excel = Microsoft.Office.Interop.Excel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Win32;
using System.Text;

namespace View.privado
{
    public partial class lista_contatos : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Carregar();
        }

        public void Carregar()
        {
            Lead lead = new Lead();

            lead.clinina = UsuarioLogado;

            List<Lead> ll = new LeadController().Listar(lead);

            dgvLista.DataSource = ll;

            dgvLista.DataBind();
        }

        protected void dgvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "alterar":
                    {

                        int id = int.Parse(dgvLista.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);

                        Response.Redirect("/privado/atualizar-contato.aspx?itemSel=" + id);

                    }
                    break;

                case "excluir":
                    {

                        Lead a = new Lead();
                        a.idlead = int.Parse(dgvLista.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);

                        new LeadController().Excluir(a);
                        Carregar();

                    }
                    break;
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Lead lead = new Lead();

            lead.clinina = UsuarioLogado;
            lead.nome_lead = txtPesquisar.Text;

            List<Lead> ll = new LeadController().Listar(lead);

            dgvLista.DataSource = ll;

            dgvLista.DataBind();
        }


    }
}