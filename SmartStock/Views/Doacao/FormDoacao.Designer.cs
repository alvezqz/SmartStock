namespace SmartStock.Views.Doacao
{
	partial class FormDoacao
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
			this.comboProduto = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtInstituicao = new System.Windows.Forms.TextBox();
			this.numQuantidade = new System.Windows.Forms.NumericUpDown();
			this.comboStatus = new System.Windows.Forms.ComboBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblMaximoQuantidade = new System.Windows.Forms.Label();
			this.btnPesquisar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
			this.SuspendLayout();
			// 
			// comboProduto
			// 
			this.comboProduto.FormattingEnabled = true;
			this.comboProduto.Location = new System.Drawing.Point(33, 64);
			this.comboProduto.Name = "comboProduto";
			this.comboProduto.Size = new System.Drawing.Size(302, 21);
			this.comboProduto.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome do Produto:";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(301, 264);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(68, 20);
			this.btnSalvar.TabIndex = 2;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// txtInstituicao
			// 
			this.txtInstituicao.Location = new System.Drawing.Point(33, 120);
			this.txtInstituicao.Name = "txtInstituicao";
			this.txtInstituicao.Size = new System.Drawing.Size(370, 20);
			this.txtInstituicao.TabIndex = 3;
			// 
			// numQuantidade
			// 
			this.numQuantidade.Location = new System.Drawing.Point(177, 169);
			this.numQuantidade.Name = "numQuantidade";
			this.numQuantidade.Size = new System.Drawing.Size(71, 20);
			this.numQuantidade.TabIndex = 4;
			// 
			// comboStatus
			// 
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Items.AddRange(new object[] {
            "Entregue",
            "Em Andamento",
            "Cancelado"});
			this.comboStatus.Location = new System.Drawing.Point(33, 169);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(132, 21);
			this.comboStatus.TabIndex = 5;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(375, 264);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(68, 20);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nome Instituição:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Status:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(171, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Quantidade:";
			// 
			// lblMaximoQuantidade
			// 
			this.lblMaximoQuantidade.AutoSize = true;
			this.lblMaximoQuantidade.Location = new System.Drawing.Point(248, 171);
			this.lblMaximoQuantidade.Name = "lblMaximoQuantidade";
			this.lblMaximoQuantidade.Size = new System.Drawing.Size(0, 13);
			this.lblMaximoQuantidade.TabIndex = 10;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(341, 65);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(62, 20);
			this.btnPesquisar.TabIndex = 11;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// FormDoacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 296);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.lblMaximoQuantidade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.comboStatus);
			this.Controls.Add(this.numQuantidade);
			this.Controls.Add(this.txtInstituicao);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboProduto);
			this.Name = "FormDoacao";
			this.Text = "FormDoacao";
			((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboProduto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtInstituicao;
		private System.Windows.Forms.NumericUpDown numQuantidade;
		private System.Windows.Forms.ComboBox comboStatus;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblMaximoQuantidade;
		private System.Windows.Forms.Button btnPesquisar;
	}
}