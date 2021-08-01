using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmChangePassword : Form
	{
		private UserAccount account;

		public UserAccount Account
		{
			get => account;
			set
			{
				account = value;
				ChangeRole(account);
			}
		}
		public FrmChangePassword(UserAccount account)
		{
			InitializeComponent();
			Account = account;
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

		#region Methods

		private void ChangeRole(UserAccount account)
		{
			tbUserName.Text = account.Username;
			tbFullName.Text = account.FullName;
		}

		private bool IsValidUser()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbUserName, "");
			errorProviderWar.SetError(tbFullName, "");
			errorProviderWar.SetError(tbPassword, "");
			errorProviderWar.SetError(tbNewPassword, "");
			errorProviderWar.SetError(tbRePassword, "");

			// Kiểm tra	tên đăng nhập không được để trống
			if (tbUserName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbUserName, "Tên đăng nhập\nkhông được để trống!");
				return false;
			}

			// Kiểm tra	tên hiển thị không được để trống
			if (tbFullName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbFullName, "Tên hiển thị\nkhông được để trống!");
				return false;
			}

			// Kiểm tra mật khẩu không được để trống
			if (tbPassword.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống!");
				return false;
			}

			// Kiểm tra mật khẩu mới không được để trống
			if (!string.IsNullOrEmpty(tbNewPassword.Text.Trim()))
			{
				// Kiểm tra mật khẩu nhập lại không được để trống
				if (tbRePassword.Text.Trim().Equals(""))
				{
					errorProviderWar.SetError(tbRePassword, "Mật khẩu không được để trống!");
					return false;
				}
				// Kiểm tra mật khẩu nhập lại phải đúng với mật khẩu mới đã nhập ở trên
				else if (!tbRePassword.Text.Trim().Equals(tbNewPassword.Text.Trim()))
				{
					errorProviderWar.SetError(tbRePassword, "Mật khẩu nhập lại không đúng!");
					return false;
				}
			}

			return true;
		}

		private void UpdateAccount()
		{
			string username = tbUserName.Text.Trim();
			string displayname = tbFullName.Text.Trim();
			string password = tbPassword.Text.Trim();
			string newPassword = tbNewPassword.Text.Trim();

			if (!IsValidUser())
				return;

			if (AccountBLL.Instance.UpdateAccount(username, displayname, password, newPassword))
			{
				MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (updateAccountInfo != null)
				{
					updateAccountInfo(this, new AccountChanged(AccountBLL.Instance.GetAccountByUserName(username)));
				}
			}
			else
			{
				MessageBox.Show("Cập nhập không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		#endregion

		#region Events

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateAccount();
		}

		private event EventHandler<AccountChanged> updateAccountInfo;
		public event EventHandler<AccountChanged> UpdateAccountInfo
		{
			add
			{
				updateAccountInfo += value;
			}
			remove
			{
				updateAccountInfo -= value;
			}
		}

		#endregion
	}

	public class AccountChanged : EventArgs
	{
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public AccountChanged(UserAccount account)
		{
			Account = account;
		}
	}
}
