using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Food
	{
		private int id;
		private string name;
		private int idCategory;
		private float price;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public int IdCategory { get => idCategory; set => idCategory = value; }
		public float Price { get => price; set => price = value; }

		public Food(int id, string name, int idCategory, float price)
		{
			Id = id;
			Name = name;
			IdCategory = IdCategory;
			Price = price;
		}

		public Food(DataRow row)
		{
			Id = (int)row["id"];
			Name = row["name"].ToString();
			IdCategory = (int)row["idCategory"];
			Price = Single.Parse(row["price"].ToString());
		}
	}
}
