using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class DataProvider
	{
		private static DataProvider instance;
		public static DataProvider Instance
		{ 
			get
			{
				if (instance == null)
					instance = new DataProvider();
				return instance;
			}
			private set => instance = value;
		}

		private DataProvider() { }

		private string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True";

		public DataTable ExcuteQuery(string query, object[] parameter = null)
		{
			DataTable data = new DataTable();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				if (parameter != null)
				{
					string[] listParameter = query.Split(' ');
					int i = 0;
					foreach (var item in listParameter)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameter[i++]);
						}	
					}
				}	
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(data);
				connection.Dispose();
			}
			return data;
		}

		public int ExcuteNonQuery(string query, object[] parameter = null)
		{
			int data = 0;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				if (parameter != null)
				{
					string[] listParameter = query.Split(' ');
					int i = 0;
					foreach (var item in listParameter)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameter[i++]);
						}
					}
				}
				data = command.ExecuteNonQuery();
				connection.Dispose();
			}
			return data;
		}

		public object ExcuteScalar(string query, object[] parameter = null)
		{
			object data = 0;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				if (parameter != null)
				{
					string[] listParameter = query.Split(' ');
					int i = 0;
					foreach (var item in listParameter)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameter[i++]);
						}
					}
				}
				data = command.ExecuteScalar();
				connection.Dispose();
			}
			return data;
		}
	}
}
