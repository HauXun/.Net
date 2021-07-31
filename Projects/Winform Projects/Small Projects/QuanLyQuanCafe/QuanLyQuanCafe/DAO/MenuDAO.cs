using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	class MenuDAO
	{
		private static MenuDAO instance;

		public static MenuDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new MenuDAO();
				return instance;
			}
			private set => instance = value;
		}

		private MenuDAO() { }

		public List<Menu> GetListMenuByTable(int id)
		{
			List<Menu> menus = new List<Menu>();
			string query = @"SELECT F.NAME, BIF.Count, F.Price, F.Price * BIF.Count AS totalPrice
							 FROM dbo.BillInfo AS BIF, dbo.Bill AS B, dbo.Food AS F
							 WHERE BIF.IDBill = B.ID AND BIF.IDFood = F.ID AND B.Status = 0 AND B.IDTable = " + id;
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				Menu menu = new Menu(item);
				menus.Add(menu);
			}
			return menus;
		}
	}
}
