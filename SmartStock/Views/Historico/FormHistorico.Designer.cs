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
			((System.ComponentModel.ISupportInitialize)(this.DgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// DgvListagem
			// 
			this.DgvListagem.AccessibleName = "Table";
			this.DgvListagem.Location = new System.Drawing.Point(1, 53);
			this.DgvListagem.Name = "DgvListagem";
			this.DgvListagem.Size = new System.Drawing.Size(798, 395);
			this.DgvListagem.TabIndex = 0;
			this.DgvListagem.Text = "sfDataGrid1";
			// 
			// FormHistorico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DgvListagem);
			this.Name = "FormHistorico";
			this.Text = "FormHistorico";
			((System.ComponentModel.ISupportInitialize)(this.DgvListagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.WinForms.DataGrid.SfDataGrid DgvListagem;
	}
}