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
		}

		private void btnEstoque_Click(object sender, EventArgs e)
		 => AbreFromMdi(new FormListaProdutos());

		private void AbreFromMdi(Form form)
		{
			form.MdiParent = this;
			form.Show();
		}

		private void tsbAnalisarEstoque_Click(object sender, EventArgs e)
		 => AbreFromMdi(new FormAnaliseEstoque());

		private void tsbDoacao_Click(object sender, EventArgs e)
		 => AbreFromMdi(new FormDoacao());

		private void tsbHistorico_Click(object sender, EventArgs e)
		 => AbreFromMdi(new FormHistorico());
	}
}
