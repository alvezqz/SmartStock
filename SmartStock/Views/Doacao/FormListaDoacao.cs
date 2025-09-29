using MySql.Data.MySqlClient;
using SmartStock.Models;
using Syncfusion.WinForms.DataGrid;
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
	public partial class FormListaDoacao : Form
	{
		private Models.Doacao doacao = new Models.Doacao();
		public FormListaDoacao()
		{
			InitializeComponent();
			CarregarDados();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			using (FormDoacao frm = new FormDoacao())
			{
				if (frm._save)
					tsbAtualizar.PerformClick();
			}
		}

		private void CarregarDados()
		{
			List<Models.Partials.DoacaoLista> lista = new List<Models.Partials.DoacaoLista>();

			string query = "SELECT idDoacao, nome , nomeInstituicao, quantidade, dataDoacao, d.status FROM Doacao d " +
				"INNER JOIN Produto USING(idProduto) WHERE idEmpresa = @idEmpresa";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
			});

			foreach (System.Data.DataRow item in dt.Rows)
			{
				 var doacao = new Models.Partials.DoacaoLista()
				 {
					 IdDoacao = Convert.ToInt32(item["idDoacao"]),
					 Nome = item["nome"].ToString(),
					 NomeInstituicao = item["nomeInstituicao"].ToString(),
					 Quantidade = Convert.ToInt32(item["quantidade"]),
					 DataDoacao = item["dataDoacao"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(item["dataDoacao"]),
					 Status = item["status"].ToString()
				 };
				lista.Add(doacao);
			}

			if (dgvListagem.ColumnCount > 0)
				dgvListagem.Columns.Clear();
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "IdDoacao", HeaderText = "Id" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Nome", HeaderText = "NomeProduto" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "NomeInstituicao", HeaderText = "Nome Instituicao" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridDateTimeColumn() { MappingName = "DataDoacao", HeaderText = "Data Doação" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Quantidade", HeaderText = "Quantidade" });
			dgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "StatusFormatado", HeaderText = "Status" });
			dgvListagem.DataSource = lista;
			dgvListagem.Refresh();

		}

		private void tsbAtualizar_Click(object sender, EventArgs e)
		 => CarregarDados();

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			try
			{
				if (doacao != null)
				{

					using (FormDoacao frm = new FormDoacao(doacao?.IdDoacao))
					{
						frm.ShowDialog();
						if (frm._save)
							tsbAtualizar.PerformClick();
					}
				}
				else
				{
					Mensagem.Erro("Selecionar Doação para Editar");
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
				if (doacao != null)
				{
					DialogResult dr = Mensagem.Confirmacao("Deseja Excluir esse produto?");
					if (dr == DialogResult.Yes)
					{
						string query = "DELETE FROM Doacao WHERE idDoacao = @idDoacao";
						bool resultado = FormLogin.bd.ExecutarComando(query, new List<MySqlParameter>()
						{
							new MySqlParameter("@idDoacao", doacao.IdDoacao)
						});
						if (resultado)
						{
							Mensagem.Sucesso("Doação Deletada Com Sucesso");
							tsbAtualizar.PerformClick();
						}
					}
				}
				else
				{
					Mensagem.Erro("Selecione uma doação para exclui-la");
				}
			}
			catch (Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
		}

		private void dgvListagem_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
		{
			try
			{
				if (dgvListagem.CurrentItem is object obj)
				{
					dynamic item = (dynamic)obj;
					doacao.IdDoacao = item.IdDoacao;
				}
			}
			catch (Exception ex)
			{
				Mensagem.Erro(ex.Message);
			}
		}
	}
}
