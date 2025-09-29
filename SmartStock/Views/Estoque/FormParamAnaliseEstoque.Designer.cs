namespace SmartStock.Views.Estoque
{
	partial class FormParamAnaliseEstoque
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NumAno = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.ComboCategoria = new System.Windows.Forms.ComboBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGerar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumAno)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.ComboCategoria);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.NumAno);
			this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(14, 14);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(418, 193);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Analise de Estoque";
			// 
			// NumAno
			// 
			this.NumAno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumAno.Location = new System.Drawing.Point(35, 87);
			this.NumAno.Name = "NumAno";
			this.NumAno.Size = new System.Drawing.Size(107, 21);
			this.NumAno.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ano de Estoque";
			// 
			// ComboCategoria
			// 
			this.ComboCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboCategoria.FormattingEnabled = true;
			this.ComboCategoria.Location = new System.Drawing.Point(207, 85);
			this.ComboCategoria.Name = "ComboCategoria";
			this.ComboCategoria.Size = new System.Drawing.Size(168, 23);
			this.ComboCategoria.TabIndex = 2;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(357, 213);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGerar
			// 
			this.btnGerar.Location = new System.Drawing.Point(276, 213);
			this.btnGerar.Name = "btnGerar";
			this.btnGerar.Size = new System.Drawing.Size(75, 23);
			this.btnGerar.TabIndex = 2;
			this.btnGerar.Text = "Gerar";
			this.btnGerar.UseVisualStyleBackColor = true;
			this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(204, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Selecione a Categoria";
			// 
			// FormParamAnaliseEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 244);
			this.Controls.Add(this.btnGerar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FormParamAnaliseEstoque";
			this.Text = "Parâmetros para Analise de Estoque";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumAno)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown NumAno;
		private System.Windows.Forms.ComboBox ComboCategoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGerar;
	}
}