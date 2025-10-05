using MySql.Data.MySqlClient;
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

namespace SmartStock.Views.Historico
{
	public partial class FormHistorico : Form
	{
		public FormHistorico()
		{
			InitializeComponent();
			CarregarDados();
		}

		private void CarregarDados()
		{
			string query = "SELECT nomeCategoria, idCategoria FROM Categoria WHERE idEmpresa = @idEmpresa";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySqlParameter>(){
				new MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
			});
			ComboCategoria.DataSource = dt;
			ComboCategoria.ValueMember = "idCategoria";
			ComboCategoria.DisplayMember = "nomeCategoria";
			ComboCategoria.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;

			if(ComboCategoria.SelectedIndex >= 0)
			{
				if (DgvListagem?.ColumnCount > 0)
					DgvListagem?.Columns.Clear();
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "IdProduto", HeaderText = "Id" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Nome", HeaderText = "Nome" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "QuantidadeAtual", HeaderText = "Quantidade Atual" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Preco", HeaderText = "Preço" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridDateTimeColumn() { MappingName = "Validade", HeaderText = "Data Validade" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Descricao", HeaderText = "Descricao" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Status", HeaderText = "Status" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn() { MappingName = "Ativo", HeaderText = "Ativo" });
				DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "QuantDoado", HeaderText = "Quantidade Doada" });

				DgvListagem.DataSource = Lista(int.Parse(ComboCategoria.SelectedValue.ToString()));
				DgvListagem.Refresh();
			}
		}

		private List<Models.Partials.Produto> Lista(int idCategoria)
		{
			var lista = new List<Models.Partials.Produto>();
			string query = "SELECT idProduto, nome, quantidadeAtual, preco, " +
			"validade, descricao, p.status, ativo, SUM(quantidade) AS QuantidadeDoada" +
			"FROM Produto p " +
			"LEFT JOIN Doacao d USING(idProduto) WHERE idEmpresa = @idEmpresa AND idCategoria = @idCategoria " +
			"GROUP BY p.idProduto";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa),
				new MySql.Data.MySqlClient.MySqlParameter("@idCategoria", idCategoria)
			});

			foreach (DataRow row in dt.Rows)
			{
				Models.Partials.Produto produto = new Models.Partials.Produto();
				produto.IdProduto = row.IsNull("idProduto") ? 0 : row.Field<int>("idProduto");
				produto.Descricao = row.IsNull("descricao") ? string.Empty : row.Field<string>("descricao");
				produto.QuantidadeAtual = row.IsNull("quantidadeAtual") ? 0 : row.Field<int>("quantidadeAtual");
				produto.Ativo = row.IsNull("ativo") ? false : Convert.ToBoolean(row["ativo"]);
				produto.Nome = row.IsNull("nome") ? string.Empty : row.Field<string>("nome");
				produto.Preco = row.IsNull("preco") ? 0.0m : row.Field<decimal>("preco");
				produto.Validade = row.IsNull("validade") ? DateTime.MinValue : row.Field<DateTime>("validade");
				produto.Status = row.Field<string>("status") == "N" ? "Normal" : "Vencido";
				produto.QuantDoada = row.IsNull("QuantidadeDoada") ? 0 : row.Field<int>("QuantidadeDoada");
				lista.Add(produto);
			}
			return lista;
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			if (ComboCategoria.SelectedIndex >= 0)
				CarregarDados();
		}
	}
}
