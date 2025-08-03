using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SmartStock.Context
{
	public class ConexaoBanco
	{

        //private const string conexao = "Server=177.116.171.34:3306;Database=smartstock;User Id=smartAcesso;Password=smart_Stock1945;";
        private const string conexao = "Server=favelabelloni.duckdns.org;Port=14707;Database=smartstock;User Id=smartAcesso;Password=smart_Stock1945;";


        public MySqlConnection Conexao()
		{
			MySqlConnection conn = new MySqlConnection(conexao);
			if (conn.State != ConnectionState.Open)
				conn.Open();
			return conn;
		}

		public bool ExecutarComando(string query, List<MySqlParameter> parameters = null)
		{
			bool sucesso = false;
			MySqlConnection conn = Conexao();
			try
			{
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = query;
				cmd.CommandType = CommandType.Text;

				if (parameters != null)
				{
					foreach (var item in parameters)
					{
						object value = item.Value ?? DBNull.Value;
						cmd.Parameters.AddWithValue(item.ParameterName, value);
					}
				}

				sucesso = cmd.ExecuteNonQuery() >= 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}

			return sucesso;
		}

		public DataTable ExecutarConsulta(string query, List<MySqlParameter> parameters = null)
		{
			DataTable dt = new DataTable();
			MySqlConnection conn = Conexao();
			try
			{
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = query;
				cmd.CommandType = CommandType.Text;

				if (parameters != null)
				{
					foreach (var item in parameters)
					{
						object value = item.Value ?? DBNull.Value;
						cmd.Parameters.AddWithValue(item.ParameterName, value);
					}
				}

				MySqlDataReader rdr = cmd.ExecuteReader();
				if (rdr != null)
					dt.Load(rdr);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (conn.State != ConnectionState.Closed)
					conn.Close();
			}

			return dt;
		}

		public object ExecutarEscalar(string query, List<MySqlParameter> parameters = null)
		{
			using (MySqlConnection conn = Conexao())
			{
				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					if (parameters != null)
						cmd.Parameters.AddRange(parameters.ToArray());

					return cmd.ExecuteScalar();
				}
			}
		}
	}
}
