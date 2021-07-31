using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	class FoodDAO
	{
		private static FoodDAO instance;

		public static FoodDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new FoodDAO();
				return instance;
			}
			private set => instance = value;
		}

		private FoodDAO() { }

		public List<Food> GetListFood()
		{
			List<Food> foods = new List<Food>();
			string query = "SELECT * FROM dbo.Food";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				Food food = new Food(item);
				foods.Add(food);
			}
			return foods;
		}

		public List<Food> GetListFoodByCategoryID(int id)
		{
			List<Food> foods = new List<Food>();
			string query = "SELECT * FROM dbo.Food WHERE IDCategory = " + id;
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				Food food = new Food(item);
				foods.Add(food);
			}
			return foods;
		}

		public List<Food> GetListFoodByName(string name)
		{
			List<Food> foods = new List<Food>();
			string query = $"SELECT * FROM dbo.Food WHERE[dbo].[fuConvertToUnsign](NAME) LIKE N'%' + [dbo].[fuConvertToUnsign](N'{name}') + '%'";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				Food food = new Food(item);
				foods.Add(food);
			}
			return foods;
		}

		public bool InsertFood(string name, int idCategory, float price)
		{
			string query = $"INSERT dbo.Food ( NAME, IDCategory, Price ) VALUES ( N'{name}', {idCategory}, {price} )";
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool UpdateFood(int id, string name, int idCategory, float price)
		{
			string query = $"UPDATE dbo.Food SET NAME = N'{name}', IDCategory = {idCategory}, Price = {price} WHERE ID = {id}";
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool DeleteFood(int id)
		{
			BillInfoDAO.Instance.DeleteBillInfoByFoodID(id);
			string query = $"DELETE dbo.Food WHERE ID = {id}";
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}
	}
}
