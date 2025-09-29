using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models.Partials
{
	public class DoacaoLista
	{
		public int IdDoacao { get; set; }

		public string Nome { get; set; }

		public string NomeInstituicao { get; set; }

		public int Quantidade { get; set; }	

		public DateTime? DataDoacao { get; set; }

		public string Status { get; set; }

		public string StatusFormatado { get
			{
				return Status == "E" ? "Entregue" :
					   Status == "A" ? "Em Andamento" :
					   Status == "C" ? "Cancelado" : "Desconhecido";
			}
		}
	}
}
