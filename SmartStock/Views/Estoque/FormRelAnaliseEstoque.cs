using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
	public partial class FormRelAnaliseEstoque : Form
	{

		private int anoSelecionado;
		private int idCategoria;
		public FormRelAnaliseEstoque(int anoSelecionado, int idCategoria)
		{
			this.anoSelecionado = anoSelecionado;
			this.idCategoria = idCategoria;
			InitializeComponent();

		}

		private void FormRelAnaliseEstoque_Load(object sender, EventArgs e)
		{
			reportViewer1.ZoomMode = ZoomMode.PageWidth;
			reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
			reportViewer1.LocalReport.DataSources.Clear();
			string query = @" SELECT MONTHNAME(CriadoEm) AS Mes, SUM(quantidadeAtual) AS QuantidadeTotal
							  FROM Produto WHERE YEAR(CriadoEm) = @Ano AND idCategoria = @IdCategoria
							  GROUP BY MONTHNAME(CriadoEm), MONTH(CriadoEm) ORDER BY MONTH(CriadoEm);";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@Ano", anoSelecionado),
				new MySql.Data.MySqlClient.MySqlParameter("@IdCategoria", idCategoria)
			});
			reportViewer1.LocalReport.SetParameters(new ReportParameter("titulo", $"{GetNomeCategoria()}"));
			ReportDataSource rds = new ReportDataSource("DsProdutos", dt);
			this.reportViewer1.LocalReport.DataSources.Add(rds);
			this.reportViewer1.RefreshReport();
		}

		private string GetNomeCategoria()
		{
			string query = "SELECT nomeCategoria FROM Categoria WHERE idCategoria = @idCategoria";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@idCategoria", idCategoria)
			}) ?? null;

			return dt.Rows[0]["nomeCategoria"].ToString();
		}
	}
}
