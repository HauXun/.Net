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
	public partial class FrmManageUser : Form
	{
		public FrmManageUser()
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

		#region Methods

		private void LoadData()
		{
			AccountBLL.Instance.GetAllAccount(dgvData);
		}

		private UserAccount GetUserInfo()
		{
			UserAccount account = new UserAccount();
			int.TryParse(tbUserID.Text, out int userId);
			account.UserID = userId;
			account.RoleID = tbRole.Text.Trim();
			account.Username = tbAccount.Text.Trim();
			account.FullName = tbFullName.Text.Trim();
			account.Password = tbPassword.Text.Trim();
			account.Email = tbEmail.Text.Trim();
			account.PhoneNumber = tbPhone.Text.Trim();
			account.Birthday = dtpDob.Value;
			account.Address = tbAddress.Text.Trim();
			account.CreatedBy = "Cheems";
			account.CreatedAt = DateTime.Now;
			account.ModifiedBy = "Cheems";
			account.ModifiedAt = DateTime.Now;
			account.Note = "Hôm nay cheem bủh quá :((";
			return account;
		}

		private bool IsValidUser()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbUserID, "");
			errorProviderWar.SetError(tbRole, "");
			errorProviderWar.SetError(tbAccount, "");
			errorProviderWar.SetError(tbFullName, "");
			errorProviderWar.SetError(tbPassword, "");
			errorProviderWar.SetError(tbEmail, "");
			errorProviderWar.SetError(tbPhone, "");
			errorProviderWar.SetError(dtpDob, "");
			errorProviderWar.SetError(tbAddress, "");

			// Kiểm tra	mã người dùng không được để trống
			if (tbUserID.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbUserID, "Mã người dùng\nkhông được để trống!");
				return false;
			}

			// Kiểm tra chức vụ không được để trống
			if (tbRole.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbRole, "Chức vụ không được để trống!");
				return false;
			}

			// Kiểm tra tên tài khoản không được để trống
			if (tbAccount.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbAccount, "Tên tài khoản không được để trống!");
				return false;
			}

			// Kiểm tra fullname không được để trống
			if (tbFullName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbFullName, "Họ và tên không được để trống!");
				return false;
			}

			// Kiểm tra mật khẩu không được để trống
			if (tbPassword.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống!");
				return false;
			}

			// Kiểm tra email khoản không được để trống
			if (tbEmail.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbEmail, "Email không được để trống!");
				return false;
			}

			// Kiểm tra số điện thoại khoản không được để trống
			if (tbPhone.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPhone, "Số điện thoại không được để trống!");
				return false;
			}

			// Kiểm tra ngày sinh toàn vẹn giá trị
			if (dtpDob.Value.Date.Equals(DateTime.Now.Date))
			{
				errorProviderWar.SetError(dtpDob, "Ngày tháng năm sinh có vấn đề!");
				return false;
			}

			// Kiểm tra địa chỉ không được để trống
			if (tbAddress.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbAddress, "Địa chỉ không được để trống!");
				return false;
			}
			return true;
		}

		#endregion

		#region Events

		private void btnAdd_Click(object sender, EventArgs e)
		{
			UserAccount account = GetUserInfo();
			if (!IsValidUser())
				return;

			if (AccountBLL.Instance.InsertAccount(account))
			{
				MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		#endregion

		private void FrmManageUser_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			dgvData["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
		}
	}
}
