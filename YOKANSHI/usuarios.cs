using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace YOKANSHI
{
	public partial class usuarios : Form
	{
		public string pass;
		int idS = -1;
		int AdS = 0;
		int status = 0;
		int doc = 0;
		int adm = 0;
		int val = 0;
		int aux = 0;
		String contra = "NULL";
		/*Status
		 * 0=Buscar
		 * 1=Crear
		 * 2=Editar
		 * */
		public usuarios(int id, int adm)
		{
			idS = id;
			AdS = adm;
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void cmdPass_Click(object sender, EventArgs e)
		{

			using (Contraseña chanpass = new Contraseña())
			{

				chanpass.action = 1;

				if (chanpass.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
				{
					this.contra = chanpass.contranue;
				}
			}
		}

		private void usuarios_Load(object sender, EventArgs e)
		{
			if (idS == -1 || AdS==1)
			{
				status = 0;
				changeStatus();
			}
			else {
				mari maria = new mari();
				string temp = maria.getuserID(idS);
				txtID.Text = temp;
				cargauser();
				pctNew.Visible = false;
				pctBuscar.Visible = false;

			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 0;
			mari maria = new mari();
			i = maria.userexist(txtID.Text);
			if (txtID.Text == "" || txtID.Text == " ") {
				MessageBox.Show("Ingrese un codigo de usuario.");
				return;

			}

			if (chDoc.Checked && (txtCedula.Text == "" || txtCedula.Text == " ")) {
				MessageBox.Show("El numero de Cedula es obligatorio para usuarios marcados como doctores.");
				return;
			}

			if (contra == "NULL") {
				MessageBox.Show("Defina una contraseña");
				return;
			}

			if (i >= 0)
			{
				MessageBox.Show("Codigo de usuario ya existe.");
				return;
			}
			else {
				pass = CalculateMD5Hash(contra);
				if (chAdmin.Checked) adm = 1;
				else adm = 0;

				if (chDoc.Checked) doc = 1;
				else doc = 0;
				aux=maria.insertUsuario(txtID.Text, txtNombre.Text, txtApellido.Text, doc, txtCedula.Text, txtEmail.Text, adm, pass);
				if (aux > 0){
					MessageBox.Show("Registrado correctamente.");
					status = 1;
					changeStatus();
					return;
				}
				else
				{
					MessageBox.Show("Error al actualizar.");
					return;
				}
			}

			return;
		}

		private void chDoc_CheckedChanged(object sender, EventArgs e)
		{
			if (chDoc.Checked) {
				txtCedula.Enabled = true;
				cmdClini.Enabled = true;
			}
			else 
			{
				txtCedula.Enabled = false;
				cmdClini.Enabled = false;
			}
		}

		private void cmdCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void changeStatus() {
			if (status == 0) {
				this.Text = "Buscar Usuario";
				contra = "NULL";
				chvalid.Visible = false;
				lblCh.Visible = false;
				txtID.Enabled = true;
				chAdmin.Enabled = false;
				txtNombre.Enabled = false;
				cmdPass.Enabled = false;
				txtApellido.Enabled = false;
				txtEmail.Enabled = false;
				chDoc.Enabled = false;
				txtCedula.Enabled = false;
				cmdClini.Enabled = false;
				cmdCancelar.Visible = true;
				cmdBuscar.Visible = true;
				cmdCrear.Visible = false;
				cmdGuardar.Visible = false;
				pctBuscar.Visible = false;
				pctNew.Visible = true;

				txtID.Text = "";
				chAdmin.Checked = false;
				txtNombre.Text = "";
				txtApellido.Text = "";
				txtEmail.Text = "";
				txtCedula.Text = "";
				chDoc.Checked = false;
			}
			if (status == 1)
			{
				this.Text = "Crear Usuario";
				lblCh.Visible = false;
				chvalid.Visible = false;
				contra = "NULL";
				txtID.Enabled = true;
				chAdmin.Enabled = true;
				txtNombre.Enabled = true;
				cmdPass.Enabled = true;
				txtApellido.Enabled = true;
				txtEmail.Enabled = true;
				chDoc.Enabled = true;
				txtCedula.Enabled = false;
				cmdClini.Enabled = false;
				cmdCancelar.Visible = true;
				cmdBuscar.Visible = false;
				cmdCrear.Visible = true;
				cmdGuardar.Visible = false; 
				pctBuscar.Visible = true;
				pctNew.Visible = false;

				txtID.Text = "";
				chAdmin.Checked = false;
				txtNombre.Text = "";
				txtApellido.Text = "";
				txtEmail.Text = "";
				txtCedula.Text = "";
				chDoc.Checked = false;
			}
			if (status == 2)
			{
				this.Text = "Editar Usuario";

				if (AdS == 1)
				{
					chAdmin.Enabled = true;
					cmdPass.Enabled = true;
					chDoc.Enabled = true;
					chvalid.Visible = true;
					lblCh.Visible = true;
				}
				else
				{

					chAdmin.Enabled = false;
					cmdPass.Enabled = true;
					chDoc.Enabled = false;
					chvalid.Visible = false;
					lblCh.Visible = false;
					txtCedula.Enabled = false;
					pctBuscar.Visible = false;
					pctNew.Visible = false;
					
				}
					txtID.Enabled = false;
					txtNombre.Enabled = true;
					txtApellido.Enabled = true;
					txtEmail.Enabled = true;
					cmdGuardar.Visible = true;
					cmdCrear.Visible = false;
					cmdBuscar.Visible = false;
					pctBuscar.Visible = true;
					pctNew.Visible = true;
				
			}
		}

		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			mari maria = new mari();
			if (txtID.Text == "" || txtID.Text == " ") {
				MessageBox.Show("ingrese el codigo de usuario.");
				return;
			}
			if (maria.userexist(txtID.Text) == -1)
			{
				MessageBox.Show("Usuario no encontrado.");
				return;
			}
			else {
				dt=maria.getInfoUser(txtID.Text);
				foreach (DataRow row in dt.Rows) {
					txtID.Text = row["UserID"].ToString();
					txtNombre.Text = row["Nombre"].ToString();
					txtApellido.Text= row["Apellidos"].ToString();
					txtCedula.Text= row["Cedula"].ToString();
					txtEmail.Text= row["Email"].ToString();
					pass= row["Pass"].ToString();
					contra = "NULL";
					//contra = CalculateMD5Hash(pass);
					if (row["Admin"].ToString() == "1") {
						chAdmin.Checked = true;
						
					}
					if (row["Doctor"].ToString() == "1")
					{
						chDoc.Checked = true;
						cmdClini.Enabled = true;
						txtCedula.Enabled = true;
					}
					if (row["Valid"].ToString() == "1")
					{
						chvalid.Checked = true;						
					}
					status = 2;
					changeStatus();
				}
			}
		}

		private void cargauser() {
			DataTable dt = new DataTable();
			mari maria = new mari();
			if (txtID.Text == "" || txtID.Text == " ")
			{
				MessageBox.Show("ingrese el codigo de usuario.");
				return;
			}
			if (maria.userexist(txtID.Text) == -1)
			{
				MessageBox.Show("Usuario no encontrado.");
				return;
			}
			else
			{
				dt = maria.getInfoUser(txtID.Text);
				foreach (DataRow row in dt.Rows)
				{
					txtID.Text = row["UserID"].ToString();
					txtNombre.Text = row["Nombre"].ToString();
					txtApellido.Text = row["Apellidos"].ToString();
					txtCedula.Text = row["Cedula"].ToString();
					txtEmail.Text = row["Email"].ToString();
					pass = row["Pass"].ToString();
					contra = "NULL";
					//contra = CalculateMD5Hash(pass);
					if (row["Admin"].ToString() == "1")
					{
						chAdmin.Checked = true;

					}
					if (row["Doctor"].ToString() == "1")
					{
						chDoc.Checked = true;
						cmdClini.Enabled = true;
						txtCedula.Enabled = true;
					}
					if (row["Valid"].ToString() == "1")
					{
						chvalid.Checked = true;
					}
					status = 2;
					changeStatus();
				}
			}


		}
		private void pctNew_Click(object sender, EventArgs e)
		{
			status = 1;
			changeStatus();
		}

		private void pctBuscar_Click(object sender, EventArgs e)
		{
			status = 0;
			changeStatus();
		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			
			if (chDoc.Checked && (txtCedula.Text == "" || txtCedula.Text == " "))
			{
				MessageBox.Show("El numero de Cedula es obligatorio para usuarios marcados como doctores.");
				return;
			}
			else
			{
				mari maria = new mari();
				if (contra != "NULL")
				{
					pass = CalculateMD5Hash(contra);
				}
				if (chAdmin.Checked) adm = 1;
				else adm = 0;
				if (chDoc.Checked) doc = 1;
				else doc = 0;
				if (chvalid.Checked) val = 1;
				else val = 0;
				aux = maria.updatetUsuario(txtID.Text, txtNombre.Text, txtApellido.Text, doc, txtCedula.Text, txtEmail.Text, adm, pass,val);
				if (aux > 0)
				{
					MessageBox.Show("Actualizado correctamente.");
					if (AdS == 1)
					{
						status = 1;
						changeStatus();
					}
					return;
				}
				else {
					MessageBox.Show("Error al actualizar.");
					return;
				}
			}

		}


		public string CalculateMD5Hash(string input)
		{
			// step 1, calculate MD5 hash from input
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
			byte[] hash = md5.ComputeHash(inputBytes);

			// step 2, convert byte array to hex string
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString("X2"));
			}
			return sb.ToString();
		}
	}
}
