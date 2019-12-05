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
				return;
			}
			if (txtpassnv.Text == "" || txtpassnv.Text == " ")
			{
				MessageBox.Show("Ingrese la validacion");
				return;
			}
			if (txtpassn.Text != txtpassnv.Text )
			{
				MessageBox.Show("Las contraseñas no coinciden");
				return;
			}
			else 
			{
				usuarios par = new usuarios();
				par.pass = txtpassn.Text;
				this.Close();
			}
		}
	}
}
