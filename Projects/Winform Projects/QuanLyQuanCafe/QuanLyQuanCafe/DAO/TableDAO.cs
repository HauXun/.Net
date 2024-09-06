using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	class TableDAO
	{
		public static int TableWidth = 80;
		public static int TableHeight = 80;
		private static TableDAO instance;

		internal static TableDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new TableDAO();
				return instance;
			}
			private set => instance = value; 
		}

		private TableDAO() { }

		public List<Table> LoadTableList()
		{
			List<Table> tables = new List<Table>();
			DataTable data = DataProvider.Instance.ExcuteQuery("EXEC dbo.USP_GetTableList");
			foreach (DataRow item in data.Rows)
			{
				Table table = new Table(item);
				tables.Add(table);
			}
			return tables;
		}

		public void SwitchTable(int idTable1, int idTable2)
		{
			string query = "EXEC dbo.USP_SwitchTable @idTable1 , @idTable2";
			DataProvider.Instance.ExcuteQuery(query, new object[] { idTable1, idTable2 });
		}
	}
}
