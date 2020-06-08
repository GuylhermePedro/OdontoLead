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
    public partial class nova_clincia : PageBase
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

                Clinica cl = new Clinica();

                cl.nome_clinica = txtNomeClinica.Text;
                cl.cnpj = txtCNPJ.Text;
                cl.senha = txtSenha.Text;

                new ClinicaController().incluir(cl);

                Response.Redirect("/publico/inicio.aspx");

            }
            catch (ConsistenciaException ex)
            {
                ExibirMensagemAlert(ex.Mensagem);
            }
        }

    }
}