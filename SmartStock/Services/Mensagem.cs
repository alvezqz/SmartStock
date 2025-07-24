using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock
{
	public static class Mensagem
	{
		public static void Sucesso(string mensagem, string titulo = "Sucesso")
			=>  MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

		public static void Erro(string mensagem, string titulo = "Erro")
			=>  MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
		

		public static void Aviso(string mensagem, string titulo = "Aviso")
			=>	MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		

		public static void Info(string mensagem, string titulo = "Informação")
			=> MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
		

		public static DialogResult Confirmacao(string mensagem, string titulo = "Confirmação")
			=> MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		
	}
}
