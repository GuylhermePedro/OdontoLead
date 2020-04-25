using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace View.publico
{
    public partial class cadastro_usuario : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        public void Incluir()
        {
            try
            {

                Usuario us = new Usuario();

                us.Nome = txtNome.Text;
                us.Cpf = txtCpf.Text;
                us.Email = txtEmail.Text;
                us.Telefone_usuario = txtTel.Text;
                us.Senha = txtSenha.Text;

                new UsuarioController().incluir(us);

                Response.Redirect("/publico/inicio.aspx");

            }
            catch (ConsistenciaException ex)
            {
                ExibirMensagemAlert(ex.Mensagem);
            }
        }
    }
}