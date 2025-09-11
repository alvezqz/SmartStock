using MySql.Data.MySqlClient;

using SmartStock.Context;
using SmartStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views
{
	public partial class FormLogin : Form
	{
		public static ConexaoBanco bd = new ConexaoBanco();
		public FormLogin()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			using(FormCadastro frm = new FormCadastro())
			{
				frm.ShowDialog();
			}
		}

		private void btnFinalizarLogin_Click(object sender, EventArgs e)
		{
			if (ValidaForm())
			{
				string query = "SELECT * FROM Empresa WHERE email = @email AND " +
					"senha = @senha";
				
				DataTable dt = bd.ExecutarConsulta(query, new List<MySqlParameter>()
				{
					new MySqlParameter("@email", txtEmail.Text),
					new MySqlParameter("@senha", txtSenha.Text)
				}) ?? null;
				if(dt != null && dt.Rows.Count != 0)
				{
					Empresa empresa = new Empresa()
					{
						IdEmpresa = int.Parse(dt.Rows[0]["idEmpresa"].ToString()),
						NomeEmpresa = dt.Rows[0]["nomeEmpresa"].ToString(),
						Email = dt.Rows[0]["email"].ToString(),
						Senha = dt.Rows[0]["senha"].ToString(),
						Cnpj = dt.Rows[0]["cnpj"].ToString(),
						Telefone = dt.Rows[0]["telefone"].ToString()
					};
					using(FormPrincipal frm = new FormPrincipal(empresa))
					{
						this.Hide();
						frm.ShowDialog();
						Dispose();
						Close();
					}
				}
				else
				{
					MessageBox.Show("Email ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private bool ValidaForm()
		{
			string msg = string.Empty;
			string query = "SELECT COUNT(*) FROM Empresa WHERE email = @email AND " +
				"senha = @senha";
			var parametros = new List<MySqlParameter>
			{
				new MySqlParameter("@email", txtEmail?.Text),
				new MySqlParameter("@senha", txtSenha?.Text)
			};
			var resultado = bd.ExecutarEscalar(query, parametros);
			if (int.Parse(resultado.ToString()) == 0)
				msg += "Nenhum Login Encontrado";
			if (!string.IsNullOrEmpty(msg))
				MessageBox.Show(msg, "Erro na Validação");
			return string.IsNullOrEmpty(msg);
		}

		private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void FormLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnFinalizarLogin.PerformClick();
		}

		private void txtSenha_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnFinalizarLogin.PerformClick();
		}
	}
}
