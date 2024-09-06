using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
	public class MonAn
	{
		private string ten;
		private int gia;
		private int soLuong;

		public string Ten { get => ten; set => ten = value; }
		public int Gia
		{
			get => gia;
			set
			{
				if (value >= 0)
					gia = value;
			}
		}
		public int SoLuong 
		{ 
			get => soLuong;
			set
			{
				soLuong = value;
			}
		}

		public MonAn(string ten, int gia, int soLuong)
		{
			Ten = ten;
			Gia = gia;
			SoLuong = soLuong;
		}
	}
}
