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
			string query = $"SELECT MAX(idProduto) AS MaxID FROM produto";
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
			string query = "SELECT idProduto, quantidade, ativo, nome, " +
				"validade, estoqueIdeal, preco, estoqueMinimo, descricao " +
				"FROM produto";
			DataTable dt = FormLogin.bd.ExecutarConsulta(query);

			foreach(DataRow row in dt.Rows)
			{
				Produto produto = new Produto
				{
					IdProduto = row.Field<int>("idProduto"),
					Descricao = row.Field<string>(""),
					EstoqueIdeal = row.Field<int>(""),
					QuantidadeAtual = row.Field<int>("quantidadeAtual"),
					Ativo = row.Field<bool>("ativo"),
					Nome = row.Field<string>("nome"),
					Preco = row.Field<decimal>("preco"),
					Validade = row.Field<DateTime>("validade"),
					Status = row.Field<DateTime>("validade") >= DateTime.Today ? "Normal" : "Vencido",
					EstoqueMinimo = row.Field<int>("estoqueMinimo"),
				};
				lista.Add(produto);
			}
			return lista;
		}
	}
}
