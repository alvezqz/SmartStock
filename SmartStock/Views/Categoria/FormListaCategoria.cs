using MySql.Data.MySqlClient;
using SmartStock.Models;
using SmartStock.Views.Doacao;
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
	public partial class FormListaCategoria : Form
	{
		private Models.Categoria Categoria = new Models.Categoria();

		public FormListaCategoria()
		{
			InitializeComponent();
			CarregarDados();
		}

		private void CarregarDados()
		{
			string query = "SELECT idCategoria, nomeCategoria , EstoqueIdeal, estoqueMinimo FROM Categoria " +
				"WHERE idEmpresa = @idEmpresa";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
			});
			if (dgvListagem.ColumnCount > 0)
				dgvListagem.Columns.Clear();
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "idCategoria", HeaderText = "Código" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "nomeCategoria", HeaderText = "Nome da Categoria" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "EstoqueIdeal", HeaderText = "Estoque Ideal" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "estoqueMinimo", HeaderText = "Estoque Mínimo" });
			dgvListagem.DataSource = dt;
			dgvListagem.Refresh();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			using (FormCadastrarCategoria frm = new FormCadastrarCategoria())
			{
				if (frm._save)
					tsbAtualizar.PerformClick();
			}
		}

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			try
			{
                if (dgvListagem.CurrentItem is object obj)
                {
                    dynamic item = (dynamic)obj;
                    Categoria.IdCategoria = Convert.ToInt32(item["idCategoria"]);
                }
                if (Categoria != null)
				{
					int idCategoria = Categoria.IdCategoria;
					using (FormCadastrarCategoria frm = new FormCadastrarCategoria(idCategoria))
					{
						frm.ShowDialog();
						if (frm._save)
							tsbAtualizar.PerformClick();
					}
				}
				else
				{
					Mensagem.Erro("Selecionar Categoria para Editar");
				}
			}
			catch (Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
		}

		private void tsbExcluir_Click(object sender, EventArgs e)
		{
			try
			{
                if (dgvListagem.CurrentItem is object obj)
                {
                    dynamic item = (dynamic)obj;
                    Categoria.IdCategoria = Convert.ToInt32(item["idCategoria"]);
                }
                if (Categoria != null)
				{
					DialogResult dr = Mensagem.Confirmacao("Deseja Excluir essa Categoria?");
					if (dr == DialogResult.Yes)
					{
						string query = "DELETE FROM Categoria WHERE idCategoria = @idCategoria";
						bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySqlParameter>()
						{
							new MySqlParameter("@idCategoria", Categoria.IdCategoria)
						});
						if (resultado)
						{
							Mensagem.Sucesso("Categoria Deletada Com Sucesso");
							tsbAtualizar.PerformClick();
						}
					}
				}
				else
				{
					Mensagem.Erro("Selecione uma categoria para exclui-la");
				}
			}
			catch (Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
		}

		private void tsbAtualizar_Click(object sender, EventArgs e)
			=> CarregarDados();

		private void dgvListagem_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
		{
			//try
			//{
				
			//}
			//catch (Exception ex)
			//{
			//	Mensagem.Erro(ex.Message);
			//}
		}
	}
}
