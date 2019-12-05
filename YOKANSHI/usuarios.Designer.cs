namespace YOKANSHI
{
	partial class usuarios
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.chDoc = new System.Windows.Forms.CheckBox();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmdPass = new System.Windows.Forms.Button();
			this.chAdmin = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 248);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Apellidos";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Doctor";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Cedula";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Clinica(s)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(178, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Admin";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.chDoc);
			this.groupBox1.Controls.Add(this.txtCedula);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(15, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(173, 105);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(60, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(30, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// chDoc
			// 
			this.chDoc.AutoSize = true;
			this.chDoc.Location = new System.Drawing.Point(60, 19);
			this.chDoc.Name = "chDoc";
			this.chDoc.Size = new System.Drawing.Size(15, 14);
			this.chDoc.TabIndex = 10;
			this.chDoc.UseVisualStyleBackColor = true;
			// 
			// txtCedula
			// 
			this.txtCedula.Enabled = false;
			this.txtCedula.Location = new System.Drawing.Point(60, 40);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(100, 20);
			this.txtCedula.TabIndex = 8;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(72, 24);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 20);
			this.txtID.TabIndex = 9;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(72, 50);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 10;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(72, 76);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(100, 20);
			this.txtApellido.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(178, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Contraseña";
			// 
			// cmdPass
			// 
			this.cmdPass.Location = new System.Drawing.Point(238, 48);
			this.cmdPass.Name = "cmdPass";
			this.cmdPass.Size = new System.Drawing.Size(30, 23);
			this.cmdPass.TabIndex = 14;
			this.cmdPass.Text = "...";
			this.cmdPass.UseVisualStyleBackColor = true;
			this.cmdPass.Click += new System.EventHandler(this.cmdPass_Click);
			// 
			// chAdmin
			// 
			this.chAdmin.AutoSize = true;
			this.chAdmin.Location = new System.Drawing.Point(220, 23);
			this.chAdmin.Name = "chAdmin";
			this.chAdmin.Size = new System.Drawing.Size(15, 14);
			this.chAdmin.TabIndex = 15;
			this.chAdmin.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 109);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Email";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 102);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 17;
			// 
			// usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 287);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.chAdmin);
			this.Controls.Add(this.cmdPass);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "usuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "usuarios";
			this.Load += new System.EventHandler(this.usuarios_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox chDoc;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button cmdPass;
		private System.Windows.Forms.CheckBox chAdmin;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox1;
	}
}