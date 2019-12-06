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
	public partial class MedicoClinica : Form
	{
		public MedicoClinica()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void MedicoClinica_Load(object sender, EventArgs e)
		{
			mari maria = new mari();
			List<String> Medicos = new List<String>();
			Medicos = maria.getMedicos();
			cmbMed.DataSource = Medicos;
		}
	}
}
