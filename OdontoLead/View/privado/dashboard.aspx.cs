using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View.privado
{
    public partial class dashboard : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/privado/novo-contato.aspx");
        }

        protected void btnContato_Click(object sender, EventArgs e)
        {
            Response.Redirect("/privado/lista-contatos.aspx");
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/privado/exportar.aspx");
        }
    }
}