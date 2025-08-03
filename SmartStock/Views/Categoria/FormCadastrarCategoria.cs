using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views.Categoria
{
	public partial class FormCadastrarCategoria : Form
	{
		public bool _save = false;
		private int? _idCategoria;

		public FormCadastrarCategoria(int? idCategoria = null)
		{
			_idCategoria = idCategoria;
			InitializeComponent();
			CarregarDados();
		}

		private void CarregarDados()
		{
			if(_idCategoria != null)
			{
				string query = "SELECT idCategoria, idEmpresa, nomeCategoria, EstoqueIdeal, estoqueMinimo FROM Categoria WHERE idCategoria = @idCategoria";
				DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
				{
					new MySql.Data.MySqlClient.MySqlParameter("@idCategoria", _idCategoria)
				}) ?? null;

				if(dt != null)
				{
					txtNomeCategoria.Text = dt.Rows[0]["nomeCategoria"].ToString();
					NumIdeal.Value = int.Parse(dt.Rows[0]["EstoqueIdeal"].ToString());
					NumMinimo.Value = int.Parse(dt.Rows[0]["estoqueMinimo"].ToString());
				}
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
			=> this.Close();

		private bool ValidarForm()
		{
			string msg = string.Empty;

			if (txtNomeCategoria.Text.Length <= 0)
				msg += "\n - Defina o nome da Categoria";
			if (NumIdeal.Value <= 0)
				msg += "\n - Defina o estoque Ideal";
			if (NumMinimo.Value <= 0)
				msg += "\n - Defina o estoque Mímino";

			if (!string.IsNullOrEmpty(msg))
				Mensagem.Erro(msg);
			return string.IsNullOrEmpty(msg);
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidarForm())
				{
					string query = "INSERT INTO Categoria (idCategoria, idEmpresa, nomeCategoria, " +
						"EstoqueIdeal, estoqueMinimo) VALUES (@idCategoria, @idEmpresa, @nomeCategoria, @EstoqueIdeal, @estoqueMinimo)";

					bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
					{
						new MySql.Data.MySqlClient.MySqlParameter("@idCategoria", Controllers.CategoriaController.NovoId()),
						new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa),
						new MySql.Data.MySqlClient.MySqlParameter("@nomeCategoria", txtNomeCategoria.Text),
						new MySql.Data.MySqlClient.MySqlParameter("@EstoqueIdeal", NumIdeal.Value),
						new MySql.Data.MySqlClient.MySqlParameter("@estoqueMinimo", NumMinimo.Value)
					});
					if (resultado)
					{
						Mensagem.Sucesso("Categoria Cadastrada com Sucesso");
						_save = resultado;
						this.Close();
					}
				}
			}
			catch(Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
			
		}
	}
}
