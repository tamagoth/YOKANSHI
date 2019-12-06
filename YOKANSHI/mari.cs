using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace YOKANSHI
{
	class mari
	{
		public static string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=toor;database=yokadb;";
		private static string query = "SELECT * FROM tusu";
		int r = -1;
		int doc = -1;
		int adm = -1;


		public int logi(string user, string passmd) {
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			query = "Select id from tusu where userid='" + user + "' and Pass like '" + passmd + "' and valid=1 LIMIT 1";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;			
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						r = Int32.Parse(reader.GetString(0));						
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return -1;
			}

			return r;
		}

		public int isMed(int id)
		{
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			query = "Select Doctor from tusu where id=" + id +"";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						doc = Int32.Parse(reader.GetString(0));
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return -1;
			}

			return doc;
		}
		public int insertUsuario(string userid,string nombre, string apellidos,int doc,string cedula,string email, int admin, string pass)
		{
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			//query = "Select Doctor from tusu where id=" + id + "";			
			query = "Insert into tusu (UserID, Nombre, Apellidos, Doctor, Cedula, Email, Admin, Pass, Valid)" +
				" values(" +
				"'" +userid +"',"+
				"'" + nombre + "'," +
				"'" + apellidos + "'," +
				"" + doc + "," +
				"'" + cedula + "'," +
				"'" + email + "'," +
				"" + admin + "," +
				"'" + pass + "'," +
				"" + 1 + ")";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				commandDatabase.ExecuteNonQuery();				
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return -1;
			}

			return 1;
		}
		//todo
		public int updatetUsuario(string userid, string nombre, string apellidos, int doc, string cedula, string email, int admin, string pass,int valid)
		{
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			//query = "Select Doctor from tusu where id=" + id + "";			
			query = "update tusu set Nombre='"+nombre +"',Apellidos='"+apellidos+"'," +
			"Doctor="+doc+", Cedula='"+cedula+"',Email='"+email+"'," +
			"Admin ="+ admin + ",pass = '"+pass+"',valid ="+valid +
			" where UserID = '"+ userid+"'";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			
			try
			{
				databaseConnection.Open();
				commandDatabase.ExecuteNonQuery();
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return -1;
			}

			return 1;
		}

		public String getName(int id)
		{
			String name = "";
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			query = "Select Nombre from tusu where id=" + id + "";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						name = reader.GetString(0);
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return "Usuario";
			}

			return name;
		}

		public String getuserID(int id)
		{
			String name = "";
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			query = "Select UserID from tusu where id=" + id + "";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						name = reader.GetString(0);
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return "error";
			}

			return name;
		}

		public int isAdm(int id)
		{
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			query = "Select Admin from tusu where id=" + id + "";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						adm = Int32.Parse(reader.GetString(0));
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return -1;
			}

			return adm;
		}

		public int userexist(String id)
		{
			int i = -1;
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			query = "Select ID from tusu where userid='" + id+ "'";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						i = Int32.Parse(reader.GetString(0));
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return -1;
			}

			return i;
		}


		

		public DataTable getInfoUser(String userId) {
			DataTable dt = new DataTable();
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			databaseConnection.Open();
			query = "Select * from tusu where userid='" + userId + "'";			
			MySqlDataAdapter adapter = new MySqlDataAdapter(query, databaseConnection);			
			try
			{
				adapter.Fill(dt);
			}
			catch (Exception ex)
			{
				r++;
			}
			databaseConnection.Close();
			return dt;
		}

		public int insertClinic() {
			int r = -1;


			return r;
		}
		public int testc() {
			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();				
				reader = commandDatabase.ExecuteReader();	
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						r++;
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				return 1;
			}
			return 0;
		}

		public List<String> getMedicos() {
			List<String> Medicos = new List<String>();

			MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
			query = "Select userID from tusu where Valid=1 and Doctor=1";
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Medicos.Add(reader.GetString(0));
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch { }

			return Medicos;
		}
	}
}
