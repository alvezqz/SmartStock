using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views.TermosDeUso
{
	public partial class FormTermosDeUso : Form
	{
		public bool confirmado = false;
		public FormTermosDeUso()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnAvançar_Click(object sender, EventArgs e)
		{
			if (CkTermos.Checked)
			{
				confirmado = true;
				this.Close();
			}
			else
			{
				Mensagem.Aviso("Você deve aceitar os termos de uso para continuar!");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Application.Exit();
			Dispose();
		}
	}
}
