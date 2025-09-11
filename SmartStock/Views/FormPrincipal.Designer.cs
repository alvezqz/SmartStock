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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDoacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHistorico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEstoque,
            this.tsbAnalisarEstoque,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsbDoacao,
            this.toolStripSeparator3,
            this.tsbHistorico,
            this.toolStripSeparator2,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 62);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEstoque
            // 
            this.tsbEstoque.Image = ((System.Drawing.Image)(resources.GetObject("tsbEstoque.Image")));
            this.tsbEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEstoque.Name = "tsbEstoque";
            this.tsbEstoque.Size = new System.Drawing.Size(53, 59);
            this.tsbEstoque.Text = "Estoque";
            this.tsbEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEstoque.Click += new System.EventHandler(this.tsbEstoque_Click);
            // 
            // tsbAnalisarEstoque
            // 
            this.tsbAnalisarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnalisarEstoque.Image")));
            this.tsbAnalisarEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnalisarEstoque.Name = "tsbAnalisarEstoque";
            this.tsbAnalisarEstoque.Size = new System.Drawing.Size(98, 59);
            this.tsbAnalisarEstoque.Text = "Analisar Estoque";
            this.tsbAnalisarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAnalisarEstoque.Click += new System.EventHandler(this.tsbAnalisarEstoque_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(113, 59);
            this.toolStripButton1.Text = "Categoria Produtos";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbDoacao
            // 
            this.tsbDoacao.Image = ((System.Drawing.Image)(resources.GetObject("tsbDoacao.Image")));
            this.tsbDoacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDoacao.Name = "tsbDoacao";
            this.tsbDoacao.Size = new System.Drawing.Size(51, 59);
            this.tsbDoacao.Text = "Doação";
            this.tsbDoacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDoacao.Click += new System.EventHandler(this.tsbDoacao_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbHistorico
            // 
            this.tsbHistorico.Image = ((System.Drawing.Image)(resources.GetObject("tsbHistorico.Image")));
            this.tsbHistorico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHistorico.Name = "tsbHistorico";
            this.tsbHistorico.Size = new System.Drawing.Size(59, 59);
            this.tsbHistorico.Text = "Histórico";
            this.tsbHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbHistorico.Click += new System.EventHandler(this.tsbHistorico_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbSair
            // 
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(30, 59);
            this.tsbSair.Text = "Sair";
            this.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
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
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}