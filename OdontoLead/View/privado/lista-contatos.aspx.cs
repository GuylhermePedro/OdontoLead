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

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvLista.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvLista.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvLista.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvLista.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvLista.Rows[i].Cells[j].Text.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
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