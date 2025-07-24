namespace SmartStock.Views
{
	partial class FormPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbEstoque = new System.Windows.Forms.ToolStripButton();
			this.tsbAnalisarEstoque = new System.Windows.Forms.ToolStripButton();
			this.tsbDoacao = new System.Windows.Forms.ToolStripButton();
			this.tsbHistorico = new System.Windows.Forms.ToolStripButton();
			this.tsbSair = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEstoque,
            this.tsbAnalisarEstoque,
            this.toolStripSeparator1,
            this.tsbDoacao,
            this.toolStripSeparator3,
            this.tsbHistorico,
            this.toolStripSeparator2,
            this.tsbSair});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 50);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbEstoque
			// 
			this.tsbEstoque.Image = ((System.Drawing.Image)(resources.GetObject("tsbEstoque.Image")));
			this.tsbEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEstoque.Name = "tsbEstoque";
			this.tsbEstoque.Size = new System.Drawing.Size(53, 47);
			this.tsbEstoque.Text = "Estoque";
			this.tsbEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbAnalisarEstoque
			// 
			this.tsbAnalisarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnalisarEstoque.Image")));
			this.tsbAnalisarEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAnalisarEstoque.Name = "tsbAnalisarEstoque";
			this.tsbAnalisarEstoque.Size = new System.Drawing.Size(98, 47);
			this.tsbAnalisarEstoque.Text = "Analisar Estoque";
			this.tsbAnalisarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbAnalisarEstoque.Click += new System.EventHandler(this.tsbAnalisarEstoque_Click);
			// 
			// tsbDoacao
			// 
			this.tsbDoacao.Image = ((System.Drawing.Image)(resources.GetObject("tsbDoacao.Image")));
			this.tsbDoacao.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDoacao.Name = "tsbDoacao";
			this.tsbDoacao.Size = new System.Drawing.Size(51, 47);
			this.tsbDoacao.Text = "Doação";
			this.tsbDoacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbDoacao.Click += new System.EventHandler(this.tsbDoacao_Click);
			// 
			// tsbHistorico
			// 
			this.tsbHistorico.Image = ((System.Drawing.Image)(resources.GetObject("tsbHistorico.Image")));
			this.tsbHistorico.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbHistorico.Name = "tsbHistorico";
			this.tsbHistorico.Size = new System.Drawing.Size(59, 47);
			this.tsbHistorico.Text = "Histórico";
			this.tsbHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbHistorico.Click += new System.EventHandler(this.tsbHistorico_Click);
			// 
			// tsbSair
			// 
			this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
			this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSair.Name = "tsbSair";
			this.tsbSair.Size = new System.Drawing.Size(30, 47);
			this.tsbSair.Text = "Sair";
			this.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.IsMdiContainer = true;
			this.Name = "FormPrincipal";
			this.Text = "FormPrincipal";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbEstoque;
		private System.Windows.Forms.ToolStripButton tsbAnalisarEstoque;
		private System.Windows.Forms.ToolStripButton tsbDoacao;
		private System.Windows.Forms.ToolStripButton tsbHistorico;
		private System.Windows.Forms.ToolStripButton tsbSair;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}