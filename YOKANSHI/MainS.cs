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
	public partial class MainS : Form
	{
		public MainS()
		{
			InitializeComponent();
		}

		private void cmdUsu_Click(object sender, EventArgs e)
		{
			usuarios usu = new usuarios();
			usu.MdiParent = this;
			usu.Show();
		}

		private void MainS_Load(object sender, EventArgs e)
		{

		}

		private void cmdClinicas_Click(object sender, EventArgs e)
		{	
			Clinicas clin = new Clinicas();
			clin.MdiParent = this;
			clin.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Cita cit = new Cita();
			cit.MdiParent = this;
			cit.Show();
		}

		private void cmdPacientes_Click(object sender, EventArgs e)
		{
			Pacientes paci = new Pacientes();
			paci.MdiParent = this;
			paci.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{			
			Medicamentos med = new Medicamentos();
			med.MdiParent = this;
			med.Show();
		}
	}
}
