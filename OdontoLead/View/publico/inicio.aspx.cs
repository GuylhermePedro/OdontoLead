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
            Response.Redirect("/publico/novo-usuario.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                UsuarioController uc = new UsuarioController();

                Usuario us = new Usuario();

                us.Cpf = txtCpf.Text;
                us.Senha = txtSenha.Text;

                Usuario ul = uc.logar(us);

                // Cria Ticket para autenticação no sistema
                FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket("  ", false, 15);
                // String para criptografia do Ticket
                String encryptTicket = FormsAuthentication.Encrypt(authTicket);
                // Cookie que armazena os dados do usuário autenticado
                HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket);
                // Adiciona o Ticket no cookie
                Response.Cookies.Add(authCookie);

                Session.Add("usuarioLogado", ul);

                bool verifica = uc.verificar_clinica(ul);

                if(verifica==false) 
                {

                    Response.Redirect("/privado/dadosclinica.aspx");
                }
                else
                {
                    Response.Redirect("/privado/dashboard.aspx");
                }

 
                

            }
            catch (ConsistenciaException ex)
            {
                ExibirMensagemAlert(ex.Mensagem);
            }
        }
    }
}