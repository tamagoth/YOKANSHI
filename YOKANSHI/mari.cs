using System;
using System.Collections.Generic;
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
						r= Int32.Parse(reader.GetString(0));
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
	}
}
