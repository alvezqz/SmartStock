using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
	public class Categoria
	{
		public int IdCategoria { get; set; }	

		public int IdEmpresa { get; set; }

		public string NomeCategoria { get; set; }	

		public int? EstoqueIdeal { get; set; }	

		public decimal? estoqueMinimo { get; set; }
	}
}
