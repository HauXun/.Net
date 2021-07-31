using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	class BillInfoDAO
	{
		private static BillInfoDAO instance;

		public static BillInfoDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new BillInfoDAO();
				return instance;
			}
			private set => instance = value;
		}

		private BillInfoDAO() { }

		public List<BillInfo> GetListBillInfo(int id)
		{
			List<BillInfo> billInfos = new List<BillInfo>();
			DataTable data = DataProvider.Instance.ExcuteQuery(
				"SELECT * FROM dbo.BillInfo WHERE IDBill = " + id);
			foreach (DataRow item in data.Rows)
			{
				BillInfo billInfo = new BillInfo(item);
				billInfos.Add(billInfo);
			}
			return billInfos;
		}

		public void InsertBillInfo(int idBill, int idFood, int count)
		{
			DataProvider.Instance.ExcuteNonQuery("EXEC USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
		}

		public void DeleteBillInfoByFoodID(int id)
		{
			DataProvider.Instance.ExcuteQuery("DELETE dbo.BillInfo WHERE IDFood = " + id);
		}
	}
}
