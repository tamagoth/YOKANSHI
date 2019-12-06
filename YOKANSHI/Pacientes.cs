using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YOKANSHI
{
	public partial class Pacientes : Form
	{
		int idIni = -1;
		int status = 0; //Controla que realiza el formulario 0=Buscar,1=Agregar,2=Editar
		mari maria = new mari();
		public Pacientes(int Id)
		{
			InitializeComponent();
			idIni = Id;
		}

		private void Pacientes_Load(object sender, EventArgs e)
		{
			if (idIni == -1)
			{
				status = 0;
				changestatus();
			}
			else {

			}
		}



		private void changestatus() {
			if (status == 0) {
				this.Text = "Buscar Paciente";
				pctAdd.Visible = true;
				pctSearch.Visible = false;
				txtID.Enabled = true;
				txtCurp.Enabled = true;
				txtNombre.Enabled = false;
				txtTel.Enabled = false;
				dtFecNac.Enabled = false;
				txtEmail.Enabled = false;
				txtApP.Enabled = false;
				txtApM.Enabled = false;
				txtDirCalle.Enabled = false;
				txtDirCol.Enabled = false;
				txtDirNo.Enabled = false;
				txtDirEst.Enabled = false;
				txtDirCP.Enabled = false;
				lstAlergias.Enabled = false;
				cmdCrear.Visible = false;
				cmdBuscar.Visible = true;
				cmdEditar.Visible = false;
				lblEdad.Visible = false;
			}
			if (status == 1)
			{
				this.Text = "Registrar Paciente";
				pctAdd.Visible = false;
				pctSearch.Visible = true;
				txtID.Enabled = false;
				txtCurp.Enabled = true;
				txtNombre.Enabled = true;
				txtTel.Enabled = true;
				dtFecNac.Enabled = true;
				txtEmail.Enabled = true;
				txtApP.Enabled = true;
				txtApM.Enabled = true;
				txtDirCalle.Enabled = true;
				txtDirCol.Enabled = true;
				txtDirNo.Enabled = true;
				txtDirEst.Enabled = true;
				txtDirCP.Enabled = true;
				lstAlergias.Enabled = true;
				cmdCrear.Visible = true;
				cmdBuscar.Visible = false;
				cmdEditar.Visible = false;
				lblEdad.Visible = true;
			}
			if (status == 2)
			{
				this.Text = "Editar Paciente";
				pctAdd.Visible = true;
				pctSearch.Visible = true;
				txtID.Enabled = false;
				txtCurp.Enabled = true;
				txtNombre.Enabled = true;
				txtTel.Enabled = true;
				dtFecNac.Enabled = true;
				txtEmail.Enabled = true;
				txtApP.Enabled = true;
				txtApM.Enabled = true;
				txtDirCalle.Enabled = true;
				txtDirCol.Enabled = true;
				txtDirNo.Enabled = true;
				txtDirEst.Enabled = true;
				txtDirCP.Enabled = true;
				lstAlergias.Enabled = true;
				cmdCrear.Visible = false;
				cmdBuscar.Visible = false;
				cmdEditar.Visible = true;
				lblEdad.Visible = true;

			}
		}


		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmdCrear_Click(object sender, EventArgs e)
		{

		}

		private void pctSearch_Click(object sender, EventArgs e)
		{
			status = 0;
			changestatus();
		}

		private void pctAdd_Click(object sender, EventArgs e)
		{
			status = 1;
			changestatus();
		}
	}
}
