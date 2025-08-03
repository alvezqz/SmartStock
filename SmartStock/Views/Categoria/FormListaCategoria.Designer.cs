namespace SmartStock.Views.Categoria
{
	partial class FormListaCategoria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaCategoria));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tsbEditar = new System.Windows.Forms.ToolStripButton();
			this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
			this.dgvListagem = new Syncfusion.WinForms.DataGrid.SfDataGrid();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbEditar,
            this.tsbExcluir,
            this.toolStripSeparator3,
            this.tsbAtualizar});
			this.toolStrip1.Location = new System.Drawing.Point(-1, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(797, 43);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(78, 40);
			this.toolStripButton1.Text = "Adicionar";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// tsbEditar
			// 
			this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
			this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEditar.Name = "tsbEditar";
			this.tsbEditar.Size = new System.Drawing.Size(57, 40);
			this.tsbEditar.Text = "Editar";
			this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
			// 
			// tsbExcluir
			// 
			this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
			this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExcluir.Name = "tsbExcluir";
			this.tsbExcluir.Size = new System.Drawing.Size(62, 40);
			this.tsbExcluir.Text = "Excluir";
			this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
			// 
			// tsbAtualizar
			// 
			this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
			this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAtualizar.Name = "tsbAtualizar";
			this.tsbAtualizar.Size = new System.Drawing.Size(73, 40);
			this.tsbAtualizar.Text = "Atualizar";
			this.tsbAtualizar.Click += new System.EventHandler(this.tsbAtualizar_Click);
			// 
			// dgvListagem
			// 
			this.dgvListagem.AccessibleName = "Table";
			this.dgvListagem.AutoGenerateColumns = false;
			this.dgvListagem.Location = new System.Drawing.Point(-1, 46);
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.Size = new System.Drawing.Size(797, 515);
			this.dgvListagem.TabIndex = 3;
			this.dgvListagem.Text = "sfDataGrid1";
			this.dgvListagem.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvListagem_CellClick);
			// 
			// FormListaCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 561);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dgvListagem);
			this.Name = "FormListaCategoria";
			this.Text = "FormListaCategoria";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton tsbEditar;
		private System.Windows.Forms.ToolStripButton tsbExcluir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbAtualizar;
		private Syncfusion.WinForms.DataGrid.SfDataGrid dgvListagem;
	}
}