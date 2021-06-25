using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
	class ThucDon
	{
		private static volatile ThucDon instance;
		private List<MonAn> menu;

		internal static ThucDon Instance 
		{
			get
			{
				if (instance == null)
					instance = new ThucDon();
				return instance;
			}
			set => instance = value;
		}
		internal List<MonAn> Menu { get => menu; set => menu = value; }

		private ThucDon()
		{
			Menu = new List<MonAn>();
			Menu.Add(new MonAn("Sườn xào chua ngọt", 120000, 20));
			Menu.Add(new MonAn("Bò nướng", 220000, 30));
			Menu.Add(new MonAn("Lẩu gà lá é", 140000, 20));
			Menu.Add(new MonAn("Ếch xào lăn", 120000, 10));
			Menu.Add(new MonAn("Canh bí đỏ", 60000, 25));
			Menu.Add(new MonAn("Cá lóc ôm chuối", 120000, 40));
		}
	}
}
