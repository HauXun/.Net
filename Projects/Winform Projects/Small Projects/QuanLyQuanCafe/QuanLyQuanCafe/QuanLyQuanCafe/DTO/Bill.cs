using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	class Bill
	{
		private int id;
		private DateTime? dateCheckIn;
		private DateTime? dateCheckOut;
		private int status;
		private int discount;

		public int Id { get => id; set => id = value; }
		public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
		public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
		public int Status { get => status; set => status = value; }
		public int Discount { get => discount; set => discount = value; }

		public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount = 0)
		{
			Id = id;
			DateCheckIn = dateCheckIn;
			DateCheckOut = dateCheckOut;
			Status = status;
			Discount = discount;
		}

		public Bill(DataRow row)
		{
			Id = (int)row["id"];
			DateCheckIn = (DateTime?)row["dateCheckIn"];
			if (!string.IsNullOrEmpty(row["dateCheckOut"].ToString()))
				DateCheckOut = (DateTime?)row["dateCheckOut"];
			Status = (int)row["status"];
			if (!string.IsNullOrEmpty(row["Discount"].ToString()))
			Discount = (int)row["Discount"];
		}
	}
}
