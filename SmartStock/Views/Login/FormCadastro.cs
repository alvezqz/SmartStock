using MySql.Data.MySqlClient;
using SmartStock.Controllers;
using SmartStock.Models;
using SmartStock.Views.TermosDeUso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		=> this.Close();

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			using(FormTermosDeUso frm = new FormTermosDeUso())
			{
				frm.ShowDialog();
				if (frm.confirmado)
					if (ValidarForms())
					{
						try
						{
							string query = "INSERT INTO Empresa (idEmpresa, nomeEmpresa, email, senha, cnpj, telefone) " +
							"VALUES (@idEmpresa, @nomeEmpresa, @email, @senha, @cnpj, @telefone)";
							if (FormLogin.bd.ExecutarComando(query, new List<MySqlParameter>()
					{

						new MySqlParameter("@idEmpresa", EmpresaController.NovoId()),
						new MySqlParameter("@nomeEmpresa", txtNomeEmpresa.Text),
						new MySqlParameter("@email", txtEmail.Text),
						new MySqlParameter("@senha", txtSenha.Text),
						new MySqlParameter("@cnpj", txtCnpj.Text),
						new MySqlParameter("@telefone", txtTelefone.Text)
					}))
							{
								Mensagem.Sucesso("Empresa Cadastrada com Sucesso. \n Faça o Login");
								this.Close();
							}
						}
						catch (Exception ex)
						{
							Mensagem.Erro(ex.ToString());
						}
					}
			}
		}
		
		private bool ValidarForms()
		{
			string msg = string.Empty;
			if (txtNomeEmpresa.Text.Length <= 0)
				msg += "\n - Digite um nome para a Empresa";
			if (txtEmail.Text.Length <= 0 || !txtEmail.Text.Contains("@"))
				msg += "\n - Digite um email correto";
			if (!txtCnpj.MaskCompleted)
				msg += "\n - Digite um CPNJ válido";
			if (txtSenha.Text.Length <= 3)
				msg += "\n - Digite uma senha maior do que 3 digítos";
			if (!txtTelefone.MaskCompleted)
				msg += "\n - Digite um número válido";
			if (!String.IsNullOrEmpty(msg))
				Mensagem.Erro("Erro ao validar Formulário \n" + msg);
			return string.IsNullOrEmpty(msg);
		}
	}
}
