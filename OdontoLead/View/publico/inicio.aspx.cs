using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View.publico
{
    public partial class inicio : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/publico/nova-clincia.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Clinica cl = new Clinica();

                ClinicaController clinicaController = new ClinicaController();

                cl.cnpj = txtCpf.Text;
                cl.senha = txtSenha.Text;

                Clinica clinicaLogada = clinicaController.logar(cl);

                // Cria Ticket para autenticação no sistema
                FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket("  ", false, 15);
                // String para criptografia do Ticket
                String encryptTicket = FormsAuthentication.Encrypt(authTicket);
                // Cookie que armazena os dados do usuário autenticado
                HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket);
                // Adiciona o Ticket no cookie
                Response.Cookies.Add(authCookie);

                Session.Add("usuarioLogado", clinicaLogada);

                Response.Redirect("/privado/dashboard.aspx");

            }
            catch (ConsistenciaException ex)
            {
                ExibirMensagemAlert(ex.Mensagem);
            }
        }
    }
}