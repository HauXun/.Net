using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class BillInfo
	{
		private int id;
		private int billId;
		private int foodId;
		private int count;

		public int Id { get => id; set => id = value; }
		public int BillId { get => billId; set => billId = value; }
		public int FoodId { get => foodId; set => foodId = value; }
		public int Count { get => count; set => count = value; }

		public BillInfo(int id, int billId, int foodId, int count)
		{
			Id = id;
			BillId = billId;
			FoodId = foodId;
			Count = count;
		}

		public BillInfo(DataRow row)
		{
			Id = (int)row["id"];
			BillId = (int)row["idBill"];
			FoodId = (int)row["idFood"];
			Count = (int)row["count"];
		}
	}
}
