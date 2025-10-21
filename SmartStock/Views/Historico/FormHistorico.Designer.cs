namespace SmartStock.Views.Historico
{
	partial class FormHistorico
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
			this.DgvListagem = new Syncfusion.WinForms.DataGrid.SfDataGrid();
			this.ComboCategoria = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPesquisar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// DgvListagem
			// 
			this.DgvListagem.AccessibleName = "Table";
			this.DgvListagem.AutoGenerateColumns = false;
			this.DgvListagem.Location = new System.Drawing.Point(1, 53);
			this.DgvListagem.Name = "DgvListagem";
			this.DgvListagem.Size = new System.Drawing.Size(798, 395);
			this.DgvListagem.TabIndex = 0;
			this.DgvListagem.Text = "sfDataGrid1";
			// 
			// ComboCategoria
			// 
			this.ComboCategoria.FormattingEnabled = true;
			this.ComboCategoria.Location = new System.Drawing.Point(12, 26);
			this.ComboCategoria.Name = "ComboCategoria";
			this.ComboCategoria.Size = new System.Drawing.Size(176, 21);
			this.ComboCategoria.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Categoria";
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(195, 23);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(90, 23);
			this.btnPesquisar.TabIndex = 3;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// FormHistorico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ComboCategoria);
			this.Controls.Add(this.DgvListagem);
			this.Name = "FormHistorico";
			this.Text = "Histórico";
			((System.ComponentModel.ISupportInitialize)(this.DgvListagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.WinForms.DataGrid.SfDataGrid DgvListagem;
		private System.Windows.Forms.ComboBox ComboCategoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPesquisar;
	}
}