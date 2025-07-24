using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
	public class Doacao
	{
        public int IdDoacao { get; set; }
		public string NomeInstituicao {  get; set; }
		public int Quantidade { get; set; }
		public DateTime? DataDoacao { get; set; }
		public char Status { get; set; }
		public int IdProduto { get; set; }	
    }
}
