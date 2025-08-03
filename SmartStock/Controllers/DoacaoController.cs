using SmartStock.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Controllers
{
	public class DoacaoController
	{
		public static int NovoId()
		{
			ConexaoBanco bd = new ConexaoBanco();
			string query = $"SELECT MAX(idDoacao) AS MaxID FROM Doacao";
			DataTable dt = bd.ExecutarConsulta(query);
			if (dt.Rows.Count > 0)
				if (dt.Rows[0]["MaxID"] != DBNull.Value &&
					int.TryParse(dt.Rows[0]["MaxID"].ToString(), out int maxid))
					return maxid + 1;
			return 1;
		}
	}
}
