using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View.privado
{
    public partial class cadastro_sucesso : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("/privado/novo-contato.aspx");
        }

        protected void btnGerenciar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/privado/lista-contatos.aspx");
        }
    }
}