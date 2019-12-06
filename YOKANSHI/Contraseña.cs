using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOKANSHI
{
	public partial class Contraseña : Form
	{
		public int action;
		public string contranue{ get; set; }
		public Contraseña()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Contraseña_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtpassn.Text=="" || txtpassn.Text == " ")
			{
				MessageBox.Show("Coloque una contraseña");
				
			}
			if (txtpassnv.Text == "" || txtpassnv.Text == " ")
			{
				MessageBox.Show("Ingrese la validacion");
				
			}
			if (txtpassn.Text != txtpassnv.Text )
			{
				MessageBox.Show("Las contraseñas no coinciden");
				
			}
			else 
			{
				contranue = txtpassn.Text;
				return;
			}
		}

		private void txtpassnv_TextChanged(object sender, EventArgs e)
		{
			if (txtpassn.Text == txtpassnv.Text && txtpassn.Text!="" && txtpassn.Text != " " && txtpassnv.Text != "" && txtpassnv.Text != " ")
			{
				button1.Enabled = true;

			}
			else {
				lblerror.Visible = true;
				button1.Enabled = false;
			}
		}
	}
}
