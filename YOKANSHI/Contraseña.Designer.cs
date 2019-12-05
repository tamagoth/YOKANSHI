namespace YOKANSHI
{
	partial class Contraseña
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.txtpassn = new System.Windows.Forms.TextBox();
			this.txtpassnv = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contraseña Actual";
			this.label1.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nueva Contraseña";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Confirmar";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(195, 105);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(112, 12);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(158, 20);
			this.txtpass.TabIndex = 5;
			this.txtpass.Visible = false;
			// 
			// txtpassn
			// 
			this.txtpassn.Location = new System.Drawing.Point(112, 47);
			this.txtpassn.Name = "txtpassn";
			this.txtpassn.PasswordChar = '*';
			this.txtpassn.Size = new System.Drawing.Size(158, 20);
			this.txtpassn.TabIndex = 6;
			// 
			// txtpassnv
			// 
			this.txtpassnv.Location = new System.Drawing.Point(112, 73);
			this.txtpassnv.Name = "txtpassnv";
			this.txtpassnv.PasswordChar = '*';
			this.txtpassnv.Size = new System.Drawing.Size(158, 20);
			this.txtpassnv.TabIndex = 7;
			// 
			// Contraseña
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 140);
			this.Controls.Add(this.txtpassnv);
			this.Controls.Add(this.txtpassn);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Contraseña";
			this.Text = "Contraseña";
			this.Load += new System.EventHandler(this.Contraseña_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.TextBox txtpassn;
		private System.Windows.Forms.TextBox txtpassnv;
	}
}