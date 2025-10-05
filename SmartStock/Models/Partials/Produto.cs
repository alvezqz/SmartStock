using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models.Partials
{
	public partial class Produto
	{
		public int IdProduto { get; set; }
		public string Nome { get; set; }	
		public int? QuantidadeAtual { get; set; }
		public DateTime Validade { get; set; }
		public decimal Preco { get; set; }
		public string Descricao { get; set; }	
		public string Status { get; set; }
		public bool? Ativo { get; set; }
		public int QuantDoada { get; set; }
	}
}
