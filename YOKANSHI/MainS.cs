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
		int id=-1;
		int isAdm=0;
		int isDoc = 0;
		mari maria = new mari();
		public MainS(int idl,int adml,int docl)
		{			
			InitializeComponent();
			id = idl;
			isAdm = adml;
			isDoc = docl;
		}

		private void cmdUsu_Click(object sender, EventArgs e)
		{
			int t = 0;
			if (isAdm == 1)
			{
				t = -1;
			}
			else {
				t = id;
			}
			usuarios usu = new usuarios(t,isAdm);
			usu.MdiParent = this;
			usu.Show();
		}

		private void MainS_Load(object sender, EventArgs e)
		{
			label1.Text = maria.getName(id);			
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
			Pacientes paci = new Pacientes(-1);
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
