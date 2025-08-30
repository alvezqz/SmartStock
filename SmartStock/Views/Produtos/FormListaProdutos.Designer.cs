namespace SmartStock.Views.Produtos
{
	partial class FormListaProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaProdutos));
			this.DgvListagem = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tsbEditar = new System.Windows.Forms.ToolStripButton();
			this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbRelatorio = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.DgvListagem)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DgvListagem
			// 
			this.DgvListagem.AllowUserToAddRows = false;
			this.DgvListagem.AllowUserToDeleteRows = false;
			this.DgvListagem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.DgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvListagem.Location = new System.Drawing.Point(0, 53);
			this.DgvListagem.Name = "DgvListagem";
			this.DgvListagem.ReadOnly = true;
			this.DgvListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvListagem.Size = new System.Drawing.Size(1017, 555);
			this.DgvListagem.TabIndex = 0;
			this.DgvListagem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListagem_CellClick);
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
            this.tsbAtualizar,
            this.toolStripSeparator4,
            this.tsbRelatorio});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1017, 50);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(78, 47);
			this.toolStripButton1.Text = "Adicionar";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// tsbEditar
			// 
			this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
			this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEditar.Name = "tsbEditar";
			this.tsbEditar.Size = new System.Drawing.Size(57, 47);
			this.tsbEditar.Text = "Editar";
			this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
			// 
			// tsbExcluir
			// 
			this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
			this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExcluir.Name = "tsbExcluir";
			this.tsbExcluir.Size = new System.Drawing.Size(62, 47);
			this.tsbExcluir.Text = "Excluir";
			this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
			// 
			// tsbAtualizar
			// 
			this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
			this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAtualizar.Name = "tsbAtualizar";
			this.tsbAtualizar.Size = new System.Drawing.Size(73, 47);
			this.tsbAtualizar.Text = "Atualizar";
			this.tsbAtualizar.Click += new System.EventHandler(this.tsbAtualizar_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
			// 
			// tsbRelatorio
			// 
			this.tsbRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("tsbRelatorio.Image")));
			this.tsbRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRelatorio.Name = "tsbRelatorio";
			this.tsbRelatorio.Size = new System.Drawing.Size(74, 47);
			this.tsbRelatorio.Text = "Relatório";
			// 
			// FormListaProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 606);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.DgvListagem);
			this.Name = "FormListaProdutos";
			this.Text = "Produtos";
			this.Load += new System.EventHandler(this.FormListaProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.DgvListagem)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton tsbEditar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbAtualizar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsbRelatorio;
		private System.Windows.Forms.ToolStripButton tsbExcluir;
		private System.Windows.Forms.DataGridView DgvListagem;
	}
}