using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
	public class User
	{
		private string name;
		private string pass;
		private bool isNhanVien;

		public string Name { get => name; set => name = value; }
		public string Pass { get => pass; set => pass = value; }
		public bool IsNhanVien { get => isNhanVien; set => isNhanVien = value; }

		public User()
		{
			Name = "Guest";
			IsNhanVien = false;
		}
	}
}
