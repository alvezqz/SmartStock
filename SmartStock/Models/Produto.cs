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
		public int Quantidade { get; set; }
		public bool Ativo { get; set; }
		public string Nome { get; set; }
		public DateTime? Validade { get; set; }
		public int EstoqueIdeal { get; set; }
		public decimal Preco { get; set; }
		public char Status { get; set; }
		public decimal EstoqueMinimo { get; set; }
		public string Descricao { get; set; }
		public int IdEmpresa { get; set; }
	}
}
