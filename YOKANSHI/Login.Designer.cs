namespace YOKANSHI
{
	partial class Login
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.cmdLogin = new System.Windows.Forms.Button();
			this.lblinf = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(79, 76);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(79, 102);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(100, 20);
			this.txtPass.TabIndex = 3;
			this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
			// 
			// cmdLogin
			// 
			this.cmdLogin.Enabled = false;
			this.cmdLogin.Location = new System.Drawing.Point(79, 128);
			this.cmdLogin.Name = "cmdLogin";
			this.cmdLogin.Size = new System.Drawing.Size(75, 23);
			this.cmdLogin.TabIndex = 4;
			this.cmdLogin.Text = "Acceder";
			this.cmdLogin.UseVisualStyleBackColor = true;
			this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
			// 
			// lblinf
			// 
			this.lblinf.AutoSize = true;
			this.lblinf.Location = new System.Drawing.Point(12, 54);
			this.lblinf.Name = "lblinf";
			this.lblinf.Size = new System.Drawing.Size(62, 13);
			this.lblinf.TabIndex = 5;
			this.lblinf.Text = "placeholder";
			this.lblinf.Visible = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(189, 165);
			this.Controls.Add(this.lblinf);
			this.Controls.Add(this.cmdLogin);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YOKANSHI";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Button cmdLogin;
		private System.Windows.Forms.Label lblinf;
	}
}

