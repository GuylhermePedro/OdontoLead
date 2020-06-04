using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace View
{
    public class PageBase : System.Web.UI.Page
    {
        public Clinica UsuarioLogado
        {
            get
            {
                return (Clinica)Session["UsuarioLogado"];
            }
            set
            {
                Session.Add("UsuarioLogado", value);
            }
        }

        protected override void OnLoad(EventArgs e)
        {

            if (!Page.IsPostBack)

                base.OnLoad(e);

        }

        protected override void OnError(EventArgs e)
        {

            Exception ex = Server.GetLastError();

            Response.Redirect("~/publico/erro.aspx");

            base.OnError(e);

        }

        public void ExibirMensagemAlert(String textoMensagem)
        {
            ScriptManager.RegisterStartupScript(this.Page, GetType(), "mensagemAlert", String.Format("alert('{0}')", textoMensagem), true);
        }
        }
    }