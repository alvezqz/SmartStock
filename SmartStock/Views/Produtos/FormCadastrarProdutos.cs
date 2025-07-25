using MySql.Data.MySqlClient;
using SmartStock.Controllers;
using SmartStock.Models;
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
		private Produto produto;
		
		public FormCadastrarProdutos(int? idProduto = null)
		{
			_idProduto = idProduto;
			InitializeComponent();
			dateValidade.MinDate = DateTime.Today;
			PreencherProduto();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		 => this.Close();

		private void PreencherProduto()
		{
			if(_idProduto != null)
			{
				string query = "SELECT SELECT idProduto, nome, quantidadeAtual, " +
					"estoqueMinimo, validade, preco, status, descricao, idEmpresa " +
					"FROM Produtos WHERE  idProduto = @IdProduto";
				DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySqlParameter>()
				{
					new MySqlParameter("@IdProduto", _idProduto)
				}) ?? null;
				if (dt != null)
					produto = new Produto()
					{
						IdProduto = int.Parse(dt.Rows[0]["idProduto"].ToString()),
						Nome = dt.Rows[0]["nome"].ToString(),
						Quantidade = int.Parse(dt.Rows[0]["quantidadeAtual"].ToString()),
						EstoqueMinimo = int.Parse(dt.Rows[0]["estoqueMinimo"].ToString()),
						Validade = DateTime.Parse(dt.Rows[0]["validade"].ToString()),
						Preco = decimal.Parse(dt.Rows[0]["preco"].ToString()),
						Status = dt.Rows[0]["status"].ToString(),
						Descricao = dt.Rows[0]["descricao"].ToString(),
						IdEmpresa = int.Parse(dt.Rows[0]["idEmpresa"].ToString())
						
					};
				txtNome.Text = produto.Nome;
				txtIdeal.Text = produto.EstoqueIdeal.ToString();
				txtDescricao.Text = produto.Descricao;
				txtMinimo.Text = produto.EstoqueMinimo.ToString();
				txtPreco.Text = produto.Preco.ToString();
				txtQuantidade.Text = produto.Quantidade.ToString();
			}
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			if (ValidaForms())
			{
				if(produto == null)
				{
					
					string query = "INSERT INTO Produto (idProduto, nome, quantidadeAtual, estoqueMinimo, validade, preco, status, descricao, idEmpresa)" +
						"VALUES(@idProduto, @nome, @quantidadeAtual, @estoqueMinimo, @validade, @preco, @status, @descricao, @idEmpresa)";
					bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySqlParameter>()
					{
						new MySqlParameter("@idProduto", ProdutoController.NovoId()),
						new MySqlParameter("@nome", txtNome.Text),
						new MySqlParameter("@quantidadeAtual", int.Parse(txtQuantidade.Text)),
						new MySqlParameter("@estoqueMinimo", int.Parse(txtIdeal.Text)),
						new MySqlParameter("@validade", dateValidade.Value.Date),
						new MySqlParameter("@preco", decimal.Parse(txtPreco.Text)),
						new MySqlParameter("@status", "N"),
						new MySqlParameter("@descricao", txtDescricao.Text),
						new MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
					});
					if (resultado)
					{
						Mensagem.Sucesso("Produto Cadastrado com Sucesso");
						_save = true;
					}
				}
				if(produto != null)
				{
					string query = "UPDATE Produto (nome, quantidadeAtual, estoqueMinimo, validade, " +
						"preco, descricao, idEmpresa) " +
						"SET (@nome, @quantidadeAtual, @estoqueMinimo, @validade, @preco, " +
						"@descricao, @idEmpresa) " +
						"WHERE idProduto = @idProduto";
					bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySqlParameter>()
					{
						new MySqlParameter("@nome", txtNome.Text),
						new MySqlParameter("@quantidadeAtual", int.Parse(txtQuantidade.Text)),
						new MySqlParameter("@estoqueMinimo", int.Parse(txtIdeal.Text)),
						new MySqlParameter("@validade", dateValidade.Value.Date),
						new MySqlParameter("@preco", decimal.Parse(txtPreco.Text)),
						new MySqlParameter("@descricao", txtDescricao.Text),
						new MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
					});
					if (resultado)
					{
						Mensagem.Sucesso("Produto Atualizado com Sucesso");
						_save = true;
						this.Close();
					}
				}
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
