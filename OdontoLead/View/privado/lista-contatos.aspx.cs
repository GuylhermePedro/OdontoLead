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
    }
}