using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
	public class Movimentacao
	{
        public int IdMovimentacao { get; set; }
		public DateTime? DataMovimentacao { get; set; }
		public string Tipo { get; set; }
		public string Observacao { get; set; }
        public int IdProduto { get; set; }
		public int Quantidade { get; set; }
    }
}
