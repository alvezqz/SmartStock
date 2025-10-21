namespace SmartStock.Views
{
	partial class FormLogin
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFinalizarLogin = new System.Windows.Forms.Button();
			this.lblCadastro = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(380, 183);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(326, 21);
			this.txtEmail.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(380, 164);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email:";
			// 
			// btnFinalizarLogin
			// 
			this.btnFinalizarLogin.BackColor = System.Drawing.SystemColors.Control;
			this.btnFinalizarLogin.Location = new System.Drawing.Point(439, 287);
			this.btnFinalizarLogin.Name = "btnFinalizarLogin";
			this.btnFinalizarLogin.Size = new System.Drawing.Size(204, 30);
			this.btnFinalizarLogin.TabIndex = 2;
			this.btnFinalizarLogin.Text = "Finalizar Login";
			this.btnFinalizarLogin.UseVisualStyleBackColor = false;
			this.btnFinalizarLogin.Click += new System.EventHandler(this.btnFinalizarLogin_Click);
			// 
			// lblCadastro
			// 
			this.lblCadastro.AutoSize = true;
			this.lblCadastro.BackColor = System.Drawing.SystemColors.Control;
			this.lblCadastro.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastro.ForeColor = System.Drawing.Color.Green;
			this.lblCadastro.Location = new System.Drawing.Point(481, 327);
			this.lblCadastro.Name = "lblCadastro";
			this.lblCadastro.Size = new System.Drawing.Size(112, 14);
			this.lblCadastro.TabIndex = 3;
			this.lblCadastro.Text = "Não tem Cadastro?";
			this.lblCadastro.Click += new System.EventHandler(this.label2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(380, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(380, 243);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(326, 21);
			this.txtSenha.TabIndex = 6;
			this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(503, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 27);
			this.label5.TabIndex = 8;
			this.label5.Text = "Login";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.Controls.Add(this.lblCadastro);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.btnFinalizarLogin);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(755, 411);
			this.panel1.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SmartStock.Properties.Resources._12718d6e44cb810be32440abbfdcefba19483183;
			this.pictureBox1.Location = new System.Drawing.Point(-11, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(344, 363);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox3.Location = new System.Drawing.Point(329, 53);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(426, 358);
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::SmartStock.Properties.Resources._9c3d2fc132272d61045baba1e7393ff9e88de588;
			this.pictureBox2.Location = new System.Drawing.Point(64, -131);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(656, 303);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 411);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.panel1);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormLogin_KeyPress);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFinalizarLogin;
		private System.Windows.Forms.Label lblCadastro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}