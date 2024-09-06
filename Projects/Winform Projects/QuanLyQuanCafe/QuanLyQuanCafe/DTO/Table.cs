using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Table
	{
		private int id;
		private string name;
		private string status;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Status { get => status; set => status = value; }

		public Table(int id, string name, string status)
		{
			Id = id;
			Name = name;
			Status = status;
		}

		public Table(DataRow row)
		{
			Id = (int)row["id"];
			Name = row["name"].ToString();
			Status = row["status"].ToString();
		}
	}
}
