using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	class CategoryDAO
	{
		private static CategoryDAO instance;

		public static CategoryDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new CategoryDAO();
				return instance;
			}
			private set => instance = value;
		}

		private CategoryDAO() { }

		public List<Category> GetListCategory()
		{
			List<Category> categories = new List<Category>();
			string query = "SELECT * FROM dbo.FoodCategory";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				Category category = new Category(item);
				categories.Add(category);
			}
			return categories;
		}

		public Category GetCategoryByID(int id)
		{
			Category category = null;
			string query = "SELECT * FROM dbo.FoodCategory WHERE ID = " + id;
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				category = new Category(item);
				return category;
			}
			return category;
		}
	}
}
