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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txtPass_TextChanged(object sender, EventArgs e)
		{
			if (txtPass.Text == null || txtPass.Text == "" || txtPass.Text == " ")
			{
				cmdLogin.Enabled = false;
			}
			else {
				cmdLogin.Enabled = true;
			}
		}

		private void cmdLogin_Click(object sender, EventArgs e)
		{
			int id = 0;
			mari maria = new mari();
			string md5h = CalculateMD5Hash(txtPass.Text);
			id= maria.logi(txtId.Text, md5h);
			if (id < 1)
			{
				MessageBox.Show("Los datos no corresponden con ningun registro.");
			}
			else {
				txtId.Text = "";
				txtPass.Text = "";
				MainS principal = new MainS();
				this.Hide();
				principal.ShowDialog();
				this.Close();
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

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
