using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
	public partial class ThemMonAn : Form
	{
		private MonAn monAn;

		public MonAn MonAn { get => monAn; set => monAn = value; }

		public ThemMonAn()
		{
			InitializeComponent();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbMonAn, "");
			errorProviderWar.SetError(tbMonAn, "");
			errorProviderWar.SetError(tbSoLuong, "");

			// Kiểm tra	tên món ăn không được để trống
			if (tbMonAn.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbMonAn, "Tên món ăn không được để trống!");
				return;
			}

			// Kiểm tra	giá không được để trống
			if (tbMonAn.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbMonAn, "Giá không được để trống");
				return;
			}

			// Kiểm tra	số lượng không được để trống
			if (tbSoLuong.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbSoLuong, "Số lượng không được để trống");
				return;
			}

			string ten = tbMonAn.Text;
			int gia;

			// Nếu các trường dữ liệu có data
			if (!int.TryParse(tbGia.Text, out gia) && gia < 0)
			{
				errorProviderWar.SetError(tbGia, "Định dạng giá không thể tồn tại\nVui lòng nhập lại giá!");
				return;
			}

			int soLuong;
			if (!int.TryParse(tbSoLuong.Text, out soLuong) && soLuong < 0)
			{
				errorProviderWar.SetError(tbGia, "Định dạng số lượng không thể tồn tại\nVui lòng nhập lại số lượng!");
				return;
			}

			MonAn mon = new MonAn(ten, gia, soLuong);
			MonAn = mon;
			this.Close();
		}
	}
}
