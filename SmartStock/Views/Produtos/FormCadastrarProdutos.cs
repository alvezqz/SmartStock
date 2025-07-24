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
	public partial class FormCadastrarProdutos : Form
	{
		public bool _save = false;
		private int? _idProduto;
		
		public FormCadastrarProdutos(int? idProduto = null)
		{
			_idProduto = idProduto;
			InitializeComponent();
			dateValidade.MinDate = DateTime.Today;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		 => this.Close();

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			if (ValidaForms())
			{

			}
		}

		private bool ValidaForms()
		{
			string msg = string.Empty;

			if (txtNome.Text == string.Empty)
				msg += "Defina o nome do produto";
			if (txtPreco.Text == string.Empty || !decimal.TryParse(txtPreco.Text, out decimal preco))
				msg += "Defina o preco do produto";
			if (!int.TryParse(txtQuantidade.Text, out int quant))
				msg += "Defina a quantidade do produto";
			if(!string.IsNullOrEmpty(msg))
				Mensagem.Erro(msg);
			return string.IsNullOrEmpty(msg);
		}
	}
}
