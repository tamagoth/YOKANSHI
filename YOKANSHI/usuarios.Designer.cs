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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
			this.cmdCrear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmdClini = new System.Windows.Forms.Button();
			this.chDoc = new System.Windows.Forms.CheckBox();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmdPass = new System.Windows.Forms.Button();
			this.chAdmin = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdBuscar = new System.Windows.Forms.Button();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.pctNew = new System.Windows.Forms.PictureBox();
			this.pctBuscar = new System.Windows.Forms.PictureBox();
			this.lblCh = new System.Windows.Forms.Label();
			this.chvalid = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctNew)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdCrear
			// 
			this.cmdCrear.Location = new System.Drawing.Point(15, 273);
			this.cmdCrear.Name = "cmdCrear";
			this.cmdCrear.Size = new System.Drawing.Size(75, 23);
			this.cmdCrear.TabIndex = 0;
			this.cmdCrear.Text = "Crear";
			this.cmdCrear.UseVisualStyleBackColor = true;
			this.cmdCrear.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 107);
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
			this.label7.Location = new System.Drawing.Point(226, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Admin";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmdClini);
			this.groupBox1.Controls.Add(this.chDoc);
			this.groupBox1.Controls.Add(this.txtCedula);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(15, 151);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(173, 105);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// cmdClini
			// 
			this.cmdClini.Enabled = false;
			this.cmdClini.Location = new System.Drawing.Point(60, 68);
			this.cmdClini.Name = "cmdClini";
			this.cmdClini.Size = new System.Drawing.Size(30, 23);
			this.cmdClini.TabIndex = 11;
			this.cmdClini.Text = "...";
			this.cmdClini.UseVisualStyleBackColor = true;
			// 
			// chDoc
			// 
			this.chDoc.AutoSize = true;
			this.chDoc.Location = new System.Drawing.Point(60, 19);
			this.chDoc.Name = "chDoc";
			this.chDoc.Size = new System.Drawing.Size(15, 14);
			this.chDoc.TabIndex = 10;
			this.chDoc.UseVisualStyleBackColor = true;
			this.chDoc.CheckedChanged += new System.EventHandler(this.chDoc_CheckedChanged);
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
			this.txtID.Location = new System.Drawing.Point(72, 47);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 20);
			this.txtID.TabIndex = 9;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(72, 73);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 10;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(72, 99);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(100, 20);
			this.txtApellido.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(196, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Contraseña";
			// 
			// cmdPass
			// 
			this.cmdPass.Location = new System.Drawing.Point(263, 59);
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
			this.chAdmin.Location = new System.Drawing.Point(268, 28);
			this.chAdmin.Name = "chAdmin";
			this.chAdmin.Size = new System.Drawing.Size(15, 14);
			this.chAdmin.TabIndex = 15;
			this.chAdmin.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 132);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Email";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(72, 125);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 20);
			this.txtEmail.TabIndex = 17;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(15, 273);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
			this.cmdGuardar.TabIndex = 18;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.Location = new System.Drawing.Point(15, 273);
			this.cmdBuscar.Name = "cmdBuscar";
			this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
			this.cmdBuscar.TabIndex = 19;
			this.cmdBuscar.Text = "Buscar";
			this.cmdBuscar.UseVisualStyleBackColor = true;
			this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Location = new System.Drawing.Point(213, 273);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
			this.cmdCancelar.TabIndex = 20;
			this.cmdCancelar.Text = "Cancelar";
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
			// 
			// pctNew
			// 
			this.pctNew.Image = ((System.Drawing.Image)(resources.GetObject("pctNew.Image")));
			this.pctNew.Location = new System.Drawing.Point(15, 12);
			this.pctNew.Name = "pctNew";
			this.pctNew.Size = new System.Drawing.Size(20, 20);
			this.pctNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctNew.TabIndex = 21;
			this.pctNew.TabStop = false;
			this.pctNew.Click += new System.EventHandler(this.pctNew_Click);
			// 
			// pctBuscar
			// 
			this.pctBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pctBuscar.Image")));
			this.pctBuscar.Location = new System.Drawing.Point(51, 12);
			this.pctBuscar.Name = "pctBuscar";
			this.pctBuscar.Size = new System.Drawing.Size(20, 20);
			this.pctBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctBuscar.TabIndex = 22;
			this.pctBuscar.TabStop = false;
			this.pctBuscar.Click += new System.EventHandler(this.pctBuscar_Click);
			// 
			// lblCh
			// 
			this.lblCh.AutoSize = true;
			this.lblCh.Location = new System.Drawing.Point(221, 102);
			this.lblCh.Name = "lblCh";
			this.lblCh.Size = new System.Drawing.Size(36, 13);
			this.lblCh.TabIndex = 23;
			this.lblCh.Text = "Valido";
			this.lblCh.Visible = false;
			// 
			// chvalid
			// 
			this.chvalid.AutoSize = true;
			this.chvalid.Location = new System.Drawing.Point(263, 102);
			this.chvalid.Name = "chvalid";
			this.chvalid.Size = new System.Drawing.Size(15, 14);
			this.chvalid.TabIndex = 24;
			this.chvalid.UseVisualStyleBackColor = true;
			this.chvalid.Visible = false;
			// 
			// usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 308);
			this.Controls.Add(this.chvalid);
			this.Controls.Add(this.lblCh);
			this.Controls.Add(this.pctBuscar);
			this.Controls.Add(this.pctNew);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdBuscar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.txtEmail);
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
			this.Controls.Add(this.cmdCrear);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "usuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar Usuarios";
			this.Load += new System.EventHandler(this.usuarios_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctNew)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCrear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdClini;
		private System.Windows.Forms.CheckBox chDoc;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button cmdPass;
		private System.Windows.Forms.CheckBox chAdmin;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Button cmdBuscar;
		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.PictureBox pctNew;
		private System.Windows.Forms.PictureBox pctBuscar;
		private System.Windows.Forms.Label lblCh;
		private System.Windows.Forms.CheckBox chvalid;
	}
}