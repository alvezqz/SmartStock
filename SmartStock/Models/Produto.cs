using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
	public partial class Produto
	{
        public int IdProduto{ get; set; }
		public int? Quantidade { get; set; }
		public bool? Ativo { get; set; }
		public string Nome { get; set; }
		public DateTime? Validade { get; set; }
		public decimal? Preco { get; set; }
		public string Status { get; set; }
		public string Descricao { get; set; }
		public int IdEmpresa { get; set; }
		public int IdCategoria { get; set; }
		public DateTime CriadoEm { get; set; }
	}
}
