namespace YOKANSHI
{
	partial class MainS
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
			this.cmdUsu = new System.Windows.Forms.Button();
			this.cmdClinicas = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cmdCitas = new System.Windows.Forms.Button();
			this.cmdPacientes = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdUsu
			// 
			this.cmdUsu.Location = new System.Drawing.Point(3, 3);
			this.cmdUsu.Name = "cmdUsu";
			this.cmdUsu.Size = new System.Drawing.Size(87, 23);
			this.cmdUsu.TabIndex = 0;
			this.cmdUsu.Text = "Usuarios";
			this.cmdUsu.UseVisualStyleBackColor = true;
			this.cmdUsu.Click += new System.EventHandler(this.cmdUsu_Click);
			// 
			// cmdClinicas
			// 
			this.cmdClinicas.Location = new System.Drawing.Point(3, 32);
			this.cmdClinicas.Name = "cmdClinicas";
			this.cmdClinicas.Size = new System.Drawing.Size(87, 23);
			this.cmdClinicas.TabIndex = 1;
			this.cmdClinicas.Text = "Clinicas";
			this.cmdClinicas.UseVisualStyleBackColor = true;
			this.cmdClinicas.Click += new System.EventHandler(this.cmdClinicas_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.cmdUsu);
			this.flowLayoutPanel1.Controls.Add(this.cmdClinicas);
			this.flowLayoutPanel1.Controls.Add(this.cmdCitas);
			this.flowLayoutPanel1.Controls.Add(this.cmdPacientes);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(93, 590);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// cmdCitas
			// 
			this.cmdCitas.Location = new System.Drawing.Point(3, 61);
			this.cmdCitas.Name = "cmdCitas";
			this.cmdCitas.Size = new System.Drawing.Size(87, 23);
			this.cmdCitas.TabIndex = 2;
			this.cmdCitas.Text = "Citas";
			this.cmdCitas.UseVisualStyleBackColor = true;
			this.cmdCitas.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmdPacientes
			// 
			this.cmdPacientes.Location = new System.Drawing.Point(3, 90);
			this.cmdPacientes.Name = "cmdPacientes";
			this.cmdPacientes.Size = new System.Drawing.Size(87, 23);
			this.cmdPacientes.TabIndex = 3;
			this.cmdPacientes.Text = "Pacientes";
			this.cmdPacientes.UseVisualStyleBackColor = true;
			this.cmdPacientes.Click += new System.EventHandler(this.cmdPacientes_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 119);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Medicamento";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// MainS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 590);
			this.Controls.Add(this.flowLayoutPanel1);
			this.IsMdiContainer = true;
			this.Name = "MainS";
			this.Text = "YOKANSHI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainS_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdUsu;
		private System.Windows.Forms.Button cmdClinicas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button cmdCitas;
		private System.Windows.Forms.Button cmdPacientes;
		private System.Windows.Forms.Button button1;
	}
}