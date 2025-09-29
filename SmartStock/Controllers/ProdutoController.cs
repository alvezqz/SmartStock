using SmartStock.Context;
using SmartStock.Models.Partials;
using SmartStock.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartStock.Controllers
{
	public class ProdutoController
	{
		public static int NovoId()
		{
			ConexaoBanco bd = new ConexaoBanco();
			string query = $"SELECT MAX(idProduto) AS MaxID FROM Produto";
			DataTable dt = bd.ExecutarConsulta(query);
			if (dt.Rows.Count > 0)
				if (dt.Rows[0]["MaxID"] != DBNull.Value &&
					int.TryParse(dt.Rows[0]["MaxID"].ToString(), out int maxid))
					return maxid + 1;
			return 1;
		}

		public List<Models.Partials.Produto> RetornaLista()
		{
			var lista = new List<Models.Partials.Produto>();
			string query = "SELECT idProduto, quantidadeAtual, ativo, nome, " +
			"validade, preco, descricao " +
			"FROM Produto WHERE idEmpresa = @idEmpresa AND ativo = 1";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query, new List<MySql.Data.MySqlClient.MySqlParameter>()
			{
				new MySql.Data.MySqlClient.MySqlParameter("@idEmpresa", FormPrincipal._empresa.IdEmpresa)
			});

			foreach(DataRow row in dt.Rows)
			{
				Produto produto = new Produto();
				produto.IdProduto = row.IsNull("idProduto") ? 0 : row.Field<int>("idProduto");
				produto.Descricao = row.IsNull("descricao") ? string.Empty : row.Field<string>("descricao");
				produto.QuantidadeAtual = row.IsNull("quantidadeAtual") ? 0 : row.Field<int>("quantidadeAtual");
				produto.Ativo = row.IsNull("ativo") ? false : Convert.ToBoolean(row["ativo"]);
				produto.Nome = row.IsNull("nome") ? string.Empty : row.Field<string>("nome");
				produto.Preco = row.IsNull("preco") ? 0.0m : row.Field<decimal>("preco");
				produto.Validade = row.IsNull("validade") ? DateTime.MinValue : row.Field<DateTime>("validade");
				produto.Status = (row.IsNull("validade") ? DateTime.MinValue : row.Field<DateTime>("validade")) >= DateTime.Today ? "Normal" : "Vencido";
				lista.Add(produto);
			}
			return lista;
		}
	}
}
