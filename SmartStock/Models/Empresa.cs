using SmartStock.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
	public class Empresa
	{
        public int IdEmpresa  { get; set; }
		public string NomeEmpresa { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Cnpj { get; set; }
		public string Telefone { get; set; }


		
    }
}
