﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using Entities;

namespace Main
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
		}

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(196, 232, 250), 90F))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Thoát chương trình!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Close();
			}
		}

		private bool IsValidUser()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbUserName, "");
			errorProviderWar.SetError(tbPassword, "");

			// Kiểm tra	tên đăng nhập không được để trống
			if (tbUserName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbUserName, "Tên đăng nhập\nkhông được để trống!");
				return false;
			}

			// Kiểm tra mật khẩu không được để trống
			if (tbPassword.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống!");
				return false;
			}
			return true;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Lấy thông tin từ giao diện
			string username = tbUserName.Text.Trim();
			string password = tbPassword.Text.Trim();

			UserAccount user = new UserAccount()
			{
				Username = username,
				Password = password
			};

			// Kiểm tra đầu vào
			if (!IsValidUser())
				return;

			// Kiểm tra tài khoản đăng nhập:
			// Kết nối tới cơ sở dữ liệu
			if (AccountBLL.Instance.IsExistAccount(user))
			{
				MessageBox.Show("Đăng nhập thành công!", "Thông báo!",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không đúng\nVui lòng kiểm tra lại!",
					"Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}