using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class BillDAO
	{
		private static BillDAO instance;

		public static BillDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new BillDAO();
				return instance;
			}
			private set => instance = value;
		}

		private BillDAO() { }

		public int GetUncheckBillIdByTableId(int id)
		{
			DataTable data = DataProvider.Instance.ExcuteQuery(
				"SELECT * FROM dbo.Bill WHERE IDTable = " + id + " AND Status = 0");
			if (data.Rows.Count > 0)
			{
				Bill bill = new Bill(data.Rows[0]);
				return bill.Id;
			}
			return -1;
		}

		public void InsertBill(int id)
		{
			DataProvider.Instance.ExcuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
		}

		public int GetMaxBillId()
		{
			try
			{
				return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM Bill");
			}
			catch { return 1; }
		}

		public void CheckOut(int id, int discount, decimal totalPrice)
		{
			string query = "UPDATE dbo.Bill SET DateCheckOut = GETDATE(), Status = 1, Discount = " + discount + ", totalPrice = " + totalPrice + " WHERE ID = " + id;
			DataProvider.Instance.ExcuteNonQuery(query);
		}

		public DataTable GetBillListByDate(DateTime dateCheckIn, DateTime dateCheckOut)
		{
			string query = "EXEC USP_GetListBillByDate @dateCheckIn , @dateCheckOut";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { dateCheckIn, dateCheckOut });
		}

		public DataTable GetBillListByDateAndPage(DateTime dateCheckIn, DateTime dateCheckOut, int page)
		{
			string query = "EXEC USP_GetListBillByDateAndPage @dateCheckIn , @dateCheckOut , @page";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { dateCheckIn, dateCheckOut, page });
		}

		public int GetNumberBillListByDate(DateTime dateCheckIn, DateTime dateCheckOut)
		{
			string query = "EXEC USP_GetListBillByDate @dateCheckIn , @dateCheckOut";
			return (int)DataProvider.Instance.ExcuteScalar(query, new object[] { dateCheckIn, dateCheckOut });
		}
	}
}
