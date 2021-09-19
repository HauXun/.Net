using Bunifu.UI.WinForms;
using DataAccessLayer;
using System;
using System.Data.SqlClient;

namespace Main.DataAccessLayer
{
	class BackupRestoreDAL
	{
		private static BackupRestoreDAL instance;

		public static BackupRestoreDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new BackupRestoreDAL();
				return instance;
			}
			private set => instance = value;
		}

		public void BackupDatabase(string selectedPath, string name)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(DataProvider.connectionString))
				{
					string server = connection.DataSource;           //-> this gives you the Server name.
					string database = connection.Database;     //-> this gives you the Db name.
					connection.Open();
					string cmd = $"BACKUP DATABASE {database} TO DISK = '{selectedPath.Trim()}\\{database}_BACKUP({name}).bak.bak'";
					SqlCommand sqlCommand = new SqlCommand(cmd, connection);
					sqlCommand.ExecuteNonQuery();
					connection.Dispose();
				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void RestoreDatabase(string selectedPath)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(DataProvider.connectionString))
				{
					string server = connection.DataSource;           //-> this gives you the Server name.
					string database = connection.Database;     //-> this gives you the Db name.
					connection.Open();
					string cmd = $"ALTER DATABASE [{database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
					SqlCommand sqlCommand = new SqlCommand(cmd, connection);
					sqlCommand.ExecuteNonQuery();

					string cmd2 = $"USE MASTER RESTORE DATABASE [{database}] FROM DISK = '{selectedPath.Trim()}' WITH REPLACE;";
					SqlCommand sqlCommand2 = new SqlCommand(cmd2, connection);
					sqlCommand2.ExecuteNonQuery();

					string cmd3 = $"ALTER DATABASE [{database}] SET MULTI_USER";
					SqlCommand sqlCommand3 = new SqlCommand(cmd3, connection);
					sqlCommand3.ExecuteNonQuery();
					sqlCommand3.ExecuteNonQuery();
					connection.Dispose();
				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void ListOfDatabase(BunifuDropdown box)
		{
			try
			{
				SqlDataReader reader = null;
				using (SqlConnection connection = new SqlConnection(DataProvider.connectionString))
				{
					connection.Open();
					string query = "SELECT * FROM sys.databases d WHERE d.database_id > 4";
					SqlCommand sqlCommand = new SqlCommand(query, connection);
					reader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
					while (reader.Read())
					{
						box.Items.Add(reader[0].ToString());
					}
					connection.Dispose();
				}
			}
			catch (Exception e)
			{

				throw e;
			}
		}
	}
}
