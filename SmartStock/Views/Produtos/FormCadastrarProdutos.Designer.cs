namespace SmartStock.Views
{
	partial class FormCadastrarProdutos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateValidade = new System.Windows.Forms.DateTimePicker();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.CheckAtivo = new System.Windows.Forms.CheckBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ComboCategoria = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateValidade
			// 
			this.dateValidade.Location = new System.Drawing.Point(340, 97);
			this.dateValidade.Name = "dateValidade";
			this.dateValidade.Size = new System.Drawing.Size(248, 20);
			this.dateValidade.TabIndex = 2;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(412, 296);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
			this.btnCadastrar.TabIndex = 3;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(493, 296);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// CheckAtivo
			// 
			this.CheckAtivo.AutoSize = true;
			this.CheckAtivo.BackColor = System.Drawing.Color.Transparent;
			this.CheckAtivo.Checked = true;
			this.CheckAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckAtivo.Location = new System.Drawing.Point(38, 267);
			this.CheckAtivo.Name = "CheckAtivo";
			this.CheckAtivo.Size = new System.Drawing.Size(50, 17);
			this.CheckAtivo.TabIndex = 5;
			this.CheckAtivo.Text = "Ativo";
			this.CheckAtivo.UseVisualStyleBackColor = false;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(32, 47);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(359, 20);
			this.txtNome.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(506, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Quantidade";
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(509, 47);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(79, 20);
			this.txtQuantidade.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(398, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Preco";
			// 
			// txtPreco
			// 
			this.txtPreco.Location = new System.Drawing.Point(397, 47);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(106, 20);
			this.txtPreco.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Descrição:";
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(32, 148);
			this.txtDescricao.Multiline = true;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(556, 113);
			this.txtDescricao.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(357, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Validade:";
			// 
			// ComboCategoria
			// 
			this.ComboCategoria.BackColor = System.Drawing.SystemColors.Window;
			this.ComboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboCategoria.FormattingEnabled = true;
			this.ComboCategoria.Location = new System.Drawing.Point(32, 96);
			this.ComboCategoria.Name = "ComboCategoria";
			this.ComboCategoria.Size = new System.Drawing.Size(302, 21);
			this.ComboCategoria.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "Categoria:";
			// 
			// FormCadastrarProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 355);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.ComboCategoria);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.CheckAtivo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.dateValidade);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNome);
			this.Name = "FormCadastrarProdutos";
			this.Text = "Cadastrar Produtos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dateValidade;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.CheckBox CheckAtivo;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox ComboCategoria;
		private System.Windows.Forms.Label label8;
	}
}