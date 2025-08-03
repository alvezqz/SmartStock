namespace SmartStock.Views.Categoria
{
	partial class FormCadastrarCategoria
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
			this.txtNomeCategoria = new System.Windows.Forms.TextBox();
			this.NumIdeal = new System.Windows.Forms.NumericUpDown();
			this.NumMinimo = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NumIdeal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumMinimo)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNomeCategoria
			// 
			this.txtNomeCategoria.Location = new System.Drawing.Point(24, 47);
			this.txtNomeCategoria.Multiline = true;
			this.txtNomeCategoria.Name = "txtNomeCategoria";
			this.txtNomeCategoria.Size = new System.Drawing.Size(365, 54);
			this.txtNomeCategoria.TabIndex = 0;
			// 
			// NumIdeal
			// 
			this.NumIdeal.Location = new System.Drawing.Point(71, 126);
			this.NumIdeal.Name = "NumIdeal";
			this.NumIdeal.Size = new System.Drawing.Size(80, 20);
			this.NumIdeal.TabIndex = 1;
			// 
			// NumMinimo
			// 
			this.NumMinimo.Location = new System.Drawing.Point(242, 126);
			this.NumMinimo.Name = "NumMinimo";
			this.NumMinimo.Size = new System.Drawing.Size(82, 20);
			this.NumMinimo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nome da Categoria:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Estoque Ideal:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(239, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Estoque Minimo:";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(233, 242);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(314, 242);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FormCadastrarCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 277);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NumMinimo);
			this.Controls.Add(this.NumIdeal);
			this.Controls.Add(this.txtNomeCategoria);
			this.Name = "FormCadastrarCategoria";
			this.Text = "Cadastrar Categoria";
			((System.ComponentModel.ISupportInitialize)(this.NumIdeal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumMinimo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNomeCategoria;
		private System.Windows.Forms.NumericUpDown NumIdeal;
		private System.Windows.Forms.NumericUpDown NumMinimo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
	}
}