using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views.Estoque
{
	public partial class FormParamAnaliseEstoque : Form
	{
		public FormParamAnaliseEstoque()
		{
			InitializeComponent();
			CarregarComboCategoria();
			NumAno.Minimum = 2000;
			NumAno.Maximum = DateTime.Today.Year;
			NumAno.Value = DateTime.Today.Year;
		}

		private void btnGerar_Click(object sender, EventArgs e)
		{
			if (ValidaForm())
			{
				using(FormRelAnaliseEstoque frm = new FormRelAnaliseEstoque(Convert.ToInt32(NumAno.Value), Convert.ToInt32(ComboCategoria.SelectedValue)))
				{
					frm.ShowDialog();
				}	
			}
		}

		private void CarregarComboCategoria()
		{
			string query = "SELECT idCategoria, nomeCategoria FROM Categoria WHERE idEmpresa = @idEmpresa";

			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
			}) ?? null;

			ComboCategoria.DataSource = dt;
			ComboCategoria.DisplayMember = "nomeCategoria";
			ComboCategoria.ValueMember = "idCategoria";
			
		}

		private bool ValidaForm()
		{
			string msg = string.Empty;

			if (NumAno.Value > 0 && NumAno.Value <= DateTime.Now.Year)
			{
				DataTable dt = FormLogin.bd.ExecutarConsulta("SELECT idProduto, nome FROM Produto WHERE idEmpresa = @idEmpresa AND year(CriadoEm) = @CriadoEm",
				new List<MySql.Data.MySqlClient.MySqlParameter>()
				{
					new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa),
					new MySql.Data.MySqlClient.MySqlParameter("@CriadoEm", NumAno.Value)
				}) ?? null;

				if(dt == null)
					msg = "\n - Por favor, digite um Ano correto";	
				if(ComboCategoria.SelectedIndex < 0)
					msg = "\n - Selecione uma categoria.";
				if(dt.Rows.Count <= 0)
					msg = "\n - Não há produtos cadastrados nesse ano.";
				if(!string.IsNullOrEmpty(msg))
					Mensagem.Aviso(msg);
			}
			else
				msg = "\n - Por favor, digite um Ano correto";
			return string.IsNullOrEmpty(msg);

		}

		private void btnCancelar_Click(object sender, EventArgs e)
			=> this.Close();
	}
}
