using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
	public class Endereco
	{
		public int IdEndereco { get; set; }
		public string Pais { get; set; }
		public string Uf { get; set; }
		public int IdEmpresa { get; set; }
		public string CEP { get; set; }
		public string Logradouro { get; set; }
		public int Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
	}
}
