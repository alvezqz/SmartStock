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
		}

		private void CarregarDados()
		{
			if (DgvListagem?.ColumnCount > 0)
				DgvListagem?.Columns.Clear();
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() {MappingName = "IdProduto", HeaderText = "Id" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Nome", HeaderText = "Nome" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "QuantidadeAtual", HeaderText = "Quantidade" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Preco", HeaderText = "Preço" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridDateTimeColumn() { MappingName = "Validade", HeaderText = "Data Validade" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "EstoqueIdeal", HeaderText = "Estoque Ideal" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "EstoqueMinimo", HeaderText = "Estoque Minimo" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Descricao", HeaderText = "Descricao" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Status", HeaderText = "Status" });
			DgvListagem.Columns.Add(new Syncfusion.WinForms.DataGrid.GridTextColumn() { MappingName = "Ativo", HeaderText = "Ativo" });
		}
	}
}
