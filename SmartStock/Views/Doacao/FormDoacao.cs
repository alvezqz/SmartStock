using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Views.Doacao
{
	public partial class FormDoacao : Form
	{
		public bool _save = false;
		private int _idDoacao;
		public FormDoacao(int idDoacao)
		{
			_idDoacao = idDoacao;
			InitializeComponent();
		}
	}
}
