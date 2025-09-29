using SmartStock.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views.Doacao
{
	public partial class FormDoacao : Form
	{
		public bool _save = false;
		private int? _idDoacao;
		private int _idProduto = 0;
		public FormDoacao(int? idDoacao = null)
		{
			_idDoacao = idDoacao;
			InitializeComponent();
			CarregarDoacao();
		}

		private void CarregarDoacao()
		{
			string query = "SELECT idProduto, nome FROM Produto WHERE idEmpresa = @idEmpresa AND status = 'N'";
			DataTable combo = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
			});
			comboProduto.DataSource = combo;
			comboProduto.ValueMember = "idProduto";
			comboProduto.DisplayMember = "nome";


			if (_idDoacao != null)
			{
				query = "SELECT idDoacao, nomeInstituicao, quantidade, dataDoacao, status, idProduto FROM Doacao WHERE idDoacao = @idDoacao";
				DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
				{
					new MySql.Data.MySqlClient.MySqlParameter("@idDoacao", _idDoacao)
				}) ?? null;
				if (dt != null)
				{
					comboProduto.SelectedValue = dt.Rows[0]["idProduto"];
					comboStatus.SelectedIndex = dt.Rows[0]["status"].ToString() == "A" ? 1 :
						dt.Rows[0]["status"].ToString() == "C" ? 2 : 0;
					txtInstituicao.Text = dt.Rows[0]["nomeInstituicao"].ToString();
					numQuantidade.Value = int.Parse(dt.Rows[0]["quantidade"].ToString());
				}
			}

		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			if (comboProduto.SelectedIndex >= 0)
			{
				string query = "SELECT idProduto, quantidadeAtual FROM Produto WHERE idProduto = @idProduto";
				DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
				{
					new MySql.Data.MySqlClient.MySqlParameter("@idProduto", comboProduto.SelectedValue)
				}) ?? null;
				if (dt != null)
				{
					numQuantidade.Maximum = decimal.Parse(dt.Rows[0]["quantidadeAtual"].ToString());
					lblMaximoQuantidade.Text = $"Quantidade Máx: {numQuantidade.Maximum}";
					_idProduto = int.Parse(dt.Rows[0]["idProduto"].ToString());
				}

			}
			else
			{
				Mensagem.Erro("Selecione um produto válido.");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
			=> this.Close();

		private bool ValidarForm()
		{
			string msg = string.Empty;

			if (txtInstituicao.Text.Length <= 0)
				msg += "\n - Digite o nome da instituição";
			if (numQuantidade.Value <= 0)
				msg += "\n - Digite uma quantidade certa";
			if (comboStatus.SelectedIndex < 0)
				msg += "\n - Digite um status para a doação";
			if (!String.IsNullOrEmpty(msg))
				Mensagem.Erro(msg);
			return string.IsNullOrEmpty(msg);
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidarForm())
					if (_idProduto > 0)
					{
						string query = "INSERT INTO Doacao(idDoacao, nomeInstituicao, quantidade, dataDoacao, status, idProduto) " +
							"VALUES(@idDoacao, @nomeInstituicao, @quantidade, @dataDoacao, @status, @idProduto)";
						bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
						{
							new MySql.Data.MySqlClient.MySqlParameter("@idDoacao", DoacaoController.NovoId()),
							new MySql.Data.MySqlClient.MySqlParameter("@nomeInstituicao", txtInstituicao.Text),
							new MySql.Data.MySqlClient.MySqlParameter("@quantidade", numQuantidade.Value),
							new MySql.Data.MySqlClient.MySqlParameter("@dataDoacao", DateTime.Now),
							new MySql.Data.MySqlClient.MySqlParameter("@status", comboStatus.SelectedIndex == 0 ? "E" : comboStatus.SelectedIndex == 1 ? "A" : "C"),
							new MySql.Data.MySqlClient.MySqlParameter("@idProduto", _idProduto)
						});
						if (resultado)
						{
							var quantMax = numQuantidade.Maximum;

							if (quantMax == numQuantidade.Value)
							{
								query = "UPDATE Produto SET ativo = 0, status = @status WHERE idProduto = @idProduto";

								resultado = FormLogin.bd.ExecutarComando(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
								{
									new MySql.Data.MySqlClient.MySqlParameter("@idProduto", _idProduto),
									new MySql.Data.MySqlClient.MySqlParameter("@status", "D")
								});

								if (resultado)
								{
									Mensagem.Sucesso("Doação feita com Sucesso");
									_save = resultado;
									this.Close();
								}
							}
							else
							{
								query = "UPDATE Produto SET quantidadeAtual = @quantidadeAtual WHERE idProduto = @idProduto";

								resultado = FormLogin.bd.ExecutarComando(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
								{
									new MySql.Data.MySqlClient.MySqlParameter("@idProduto", _idProduto),
									new MySql.Data.MySqlClient.MySqlParameter("@quantidadeAtual", quantMax - numQuantidade.Value)
								});

								if (resultado)
								{
									Mensagem.Sucesso("Doação feita com Sucesso");
									_save = resultado;
									this.Close();
								}
							}

						}
					}
					else
					{
						Mensagem.Erro("Erro ao selecionar código do Produto");
					}
			}
			catch (Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
		}

	}
}
