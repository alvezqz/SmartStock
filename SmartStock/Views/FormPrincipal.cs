using SmartStock.Models;
using SmartStock.Views.Doacao;
using SmartStock.Views.Estoque;
using SmartStock.Views.Historico;
using SmartStock.Views.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views
{
	public partial class FormPrincipal : Form
	{
		public static Empresa _empresa;
		public FormPrincipal(Empresa empresa)
		{
			_empresa = empresa;
			InitializeComponent();
			tsbEstoque.PerformClick();
		}

		private void AbreFromMdi(Form form)
		{
			form.MdiParent = this;
			form.Show();
		}

		private void tsbAnalisarEstoque_Click(object sender, EventArgs e)
		 => AbreFromMdi(new FormParamAnaliseEstoque());

		private void tsbDoacao_Click(object sender, EventArgs e)
		 => AbreFromMdi(new FormListaDoacao());

		private void tsbHistorico_Click(object sender, EventArgs e)
		 => AbreFromMdi(new FormHistorico());

		private void tsbEstoque_Click(object sender, EventArgs e)
		=> AbreFromMdi(new FormListaProdutos());

		private void toolStripButton1_Click(object sender, EventArgs e)
		=> AbreFromMdi(new SmartStock.Views.Categoria.FormListaCategoria());

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmarSaida())
                e.Cancel = true;
			else
			{
				Dispose();
				Close();
			}

        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            if (ConfirmarSaida())
            {
                Dispose();
                this.Close();
            }
        }

        private bool ConfirmarSaida()
			=> Mensagem.Confirmacao("Deseja realmente sair do sistema?") == DialogResult.Yes;

		private void tsbApresentarDoacao_Click(object sender, EventArgs e)
			=> AbreFromMdi(new FormApresentaDoacao());
	}
}
