using System.Data.SqlClient;

namespace Main.Partial
{
	class SqlHelper
	{
		SqlConnection sqlConnection;

		public SqlHelper(string connectionString)
		{
			sqlConnection = new SqlConnection(connectionString);
		}

		public bool IsConnection
		{
			get
			{
				if (sqlConnection.State == System.Data.ConnectionState.Closed)
					sqlConnection.Open();
				return true;
			}
		}
	}
}
