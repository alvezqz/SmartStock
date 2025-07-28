using SmartStock.Controllers;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStock.Models.Partials;
using SmartStock.Models;

namespace SmartStock.Views.Produtos
{
	public partial class FormListaProdutos : Form
	{
		private Models.Produto _produto = null;
		public FormListaProdutos()
		{
			InitializeComponent();
			DgvListagem.AutoGenerateColumns = false;
			CarregarDados();
		}

		private void CarregarDados()
		{
			try
			{
				var controller = new ProdutoController();
				List<Models.Partials.Produto> lista = controller.RetornaLista();

				DgvListagem.Columns.Clear();

				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn()
				{
					Name = "idProduto",
					HeaderText = "Id",
					DataPropertyName = "IdProduto"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colNome",
					HeaderText = "Nome",
					DataPropertyName = "Nome"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colQuantidadeAtual",
					HeaderText = "Quantidade Atual",
					DataPropertyName = "QuantidadeAtual"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colValidade",
					HeaderText = "Validade",
					DataPropertyName = "Validade"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colEstoqueIdeal",
					HeaderText = "Estoque Ideal",
					DataPropertyName = "EstoqueIdeal"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colPreco",
					HeaderText = "Preço",
					DataPropertyName = "Preco"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colEstoqueMinimo",
					HeaderText = "Estoque Mínimo",
					DataPropertyName = "EstoqueMinimo"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colDescricao",
					HeaderText = "Descrição",
					DataPropertyName = "Descricao"
				});
				DgvListagem.Columns.Add(new DataGridViewTextBoxColumn
				{
					Name = "colStatus",
					HeaderText = "Status",
					DataPropertyName = "Status"
				});
				DgvListagem.Columns.Add(new DataGridViewCheckBoxColumn
				{
					Name = "colAtivo",
					HeaderText = "Ativo",
					DataPropertyName = "Ativo"
				});

				DgvListagem.DataSource = lista;
			}
			catch (Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
		}


		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			using(FormCadastrarProdutos frm = new FormCadastrarProdutos())
			{
				frm.ShowDialog();
				if (frm._save)
					tsbAtualizar.PerformClick();
			}
		}

		private void tsbAtualizar_Click(object sender, EventArgs e)
		 => CarregarDados();

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			try
			{
				if(_produto != null)
				{
					
					using (FormCadastrarProdutos frm = new FormCadastrarProdutos(_produto.IdProduto))
					{
						frm.ShowDialog();
						if(frm._save)
							tsbAtualizar.PerformClick();
					}
				} 
			}
			catch(Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
		}

		private void tsbExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (_produto != null)
				{
					DialogResult dr = Mensagem.Confirmacao("Deseja Excluir esse produto?");
					if(dr == DialogResult.OK)
					{
						string query = "DELETE FROM Produto WHERE idProduto = @idProduto";
						bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySqlParameter>()
						{
							new MySqlParameter("@idProduto", _produto.IdProduto)
						});
						if (resultado)
						{
							Mensagem.Sucesso("Produto Deletado Com Sucessp");
							tsbAtualizar.PerformClick();
						}
					}
				}
				else
				{
					Mensagem.Erro("Selecione um produto para exclui-lo");
				}
			}
			catch(Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
			
		}

		private void DgvListagem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0 || DgvListagem.Rows[e.RowIndex].Cells[0].Value == null)
					return;

				int idProduto = int.Parse(DgvListagem.Rows[e.RowIndex].Cells[0].Value.ToString());

				string query = "SELECT idProduto, quantidadeAtual, ativo, nome, validade, " +
					"estoqueIdeal, preco, status, estoqueMinimo, descricao, idEmpresa " +
					"FROM Produto WHERE idProduto = @idProduto";

				DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySqlParameter>()
				{
					new MySqlParameter("@idProduto", idProduto)
				});

				if (dt.Rows.Count == 0)
					return;

				_produto = new Models.Produto();
				_produto.IdProduto = int.Parse(dt.Rows[0]["idProduto"].ToString());
				_produto.Descricao = dt.Rows[0]["descricao"].ToString();
				_produto.EstoqueIdeal = int.Parse(dt.Rows[0]["estoqueIdeal"].ToString());
				_produto.Quantidade = int.Parse(dt.Rows[0]["quantidadeAtual"].ToString());
				_produto.Ativo = dt.Rows[0].IsNull("ativo") ? false	: Convert.ToBoolean(dt.Rows[0]["ativo"]);
				_produto.Nome = dt.Rows[0]["nome"].ToString();
				_produto.Preco = decimal.Parse(dt.Rows[0]["preco"].ToString());
				_produto.Validade = dt.Rows[0].IsNull("validade") ? DateTime.MinValue : dt.Rows[0].Field<DateTime>("validade");
				_produto.Status = _produto.Validade >= DateTime.Today ? "Normal" : "Vencido";
				_produto.EstoqueMinimo = decimal.Parse(dt.Rows[0]["estoqueMinimo"].ToString());
			}
			catch (Exception ex)
			{
				_produto = null;
				MessageBox.Show("Erro ao carregar o produto: " + ex.Message);
			}
		}

	}
}
