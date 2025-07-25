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

namespace SmartStock.Views.Produtos
{
	public partial class FormListaProdutos : Form
	{
		public FormListaProdutos()
		{
			InitializeComponent();
			CarregarDados();
		}

		private void DgvListagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void CarregarDados()
		{
			try
			{
				var controller = new ProdutoController();
				if (DgvListagem?.Rows.Count > 0)
					DgvListagem.Rows.Clear();
				DgvListagem.Columns.Add("nome", "Nome");
				DgvListagem.Columns.Add("quantidadeAtual", "Quantidade Atual");
				DgvListagem.Columns.Add("validade", "validade");
				DgvListagem.Columns.Add("estoqueIdeal", "Estoque Ideal");
				DgvListagem.Columns.Add("estoqueMinimo", "Estoque Minimo");
				DgvListagem.Columns.Add("preco", "Preço");
				DgvListagem.Columns.Add("descricao", "Descrição");
				DgvListagem.Columns.Add("status", "Status");

				DgvListagem.DataSource = controller.RetornaLista();
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
				if(DgvListagem.CurrentRow != null && DgvListagem.CurrentRow.DataBoundItem is Models.Partials.Produto produto)
				{
					using (FormCadastrarProdutos frm = new FormCadastrarProdutos(produto.IdProduto))
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
				if (DgvListagem.CurrentRow != null && DgvListagem.CurrentRow.DataBoundItem is Models.Partials.Produto produto)
				{
					DialogResult dr = Mensagem.Confirmacao("Deseja Excluir esse produto?");
					if(dr == DialogResult.OK)
					{
						string query = "DELETE FROM Produto WHERE idProduto = @idProduto";
						bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySqlParameter>()
						{
							new MySqlParameter("@idProduto", produto.IdProduto)
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
	}
}
