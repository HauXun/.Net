﻿using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmManageQuestion : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private int rowIndex = 0;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }

		public FrmManageQuestion(UserAccount account)
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			Account = account;
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

		protected override void WndProc(ref Message m)
		{
			const int WM_SYSCOMMAND = 0x0112;
			const int SC_MOVE = 0xF010;

			switch (m.Msg)
			{
				case WM_SYSCOMMAND:
					int command = m.WParam.ToInt32() & 0xfff0;
					if (command == SC_MOVE)
						return;
					break;
			}
			base.WndProc(ref m);
		}

		#region Methods

		private void LoadData()
		{
			AccountBLL.Instance.GetAllAccount(dgvData);
			RoleBLL.Instance.GetAllAccount(cbRole);
		}

		private UserAccount GetUserInfo()
		{
			UserAccount account = new UserAccount();
			int.TryParse(tbUserID.Text, out int userId);
			account.UserID = userId;
			account.RoleID = cbRole.SelectedValue.ToString();
			account.Username = tbAccount.Text.Trim();
			account.FullName = tbFullName.Text.Trim();
			account.Password = tbPassword.Text.Trim();
			account.Email = tbEmail.Text.Trim();
			account.PhoneNumber = tbPhone.Text.Trim();
			account.Birthday = dtpDob.Value;
			account.Address = tbAddress.Text.Trim();
			account.CreatedBy = $"{Account.RoleID} - {Account.FullName}";
			account.ModifiedBy = $"{Account.RoleID} - {Account.FullName}";
			return account;
		}

		private void AddUser()
		{
			UserAccount account = GetUserInfo();
			account.Note = $"Đã được tạo bởi {Account.RoleID} - {Account.FullName} vào {account.CreatedAt}";
			if (!IsValidUser())
				return;

			if (AccountBLL.Instance.InsertAccount(account))
			{
				MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				LoadData();
			}
			else
			{
				MessageBox.Show("Thêm không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void UpdateUser()
		{
			UserAccount account = GetUserInfo();
			account.Note = $"Đã được sửa bởi {Account.RoleID} - {Account.FullName} vào {account.ModifiedAt}";
			if (!IsValidUser())
				return;

			if (AccountBLL.Instance.UpdateUser(account))
			{
				MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				LoadData();
			}
			else
			{
				MessageBox.Show("Cập nhập không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = dgvData.Rows[rowIndex];
				tbUserID.Text = row.Cells["UserID"].Value.ToString();
				tbAccount.Text = row.Cells["Username"].Value.ToString();
				tbPassword.Text = row.Cells["Password"].Value.ToString();
				tbFullName.Text = row.Cells["FullName"].Value.ToString();
				cbRole.SelectedValue = row.Cells["RoleID"].Value.ToString();
				tbPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
				tbAddress.Text = row.Cells["Address"].Value.ToString();
				tbEmail.Text = row.Cells["Email"].Value.ToString();
				dtpDob.Text = row.Cells["Birthday"].FormattedValue.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void VisibleButton(bool isVisibleButton = false)
		{
			btnSave.Visible = btnCancle.Visible = isVisibleButton;
			btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = !isVisibleButton;
		}

		private void EnableControl(bool isEnable = true)
		{
			foreach (Control item in gbControls.Controls)
			{
				item.Enabled = isEnable;
			}
		}

		private bool IsValidUser()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(cbRole, "");
			errorProviderWar.SetError(tbAccount, "");
			errorProviderWar.SetError(tbFullName, "");
			errorProviderWar.SetError(tbPassword, "");
			errorProviderWar.SetError(tbEmail, "");
			errorProviderWar.SetError(tbPhone, "");
			errorProviderWar.SetError(dtpDob, "");
			errorProviderWar.SetError(tbAddress, "");

			// Kiểm tra chức vụ không được để trống
			if (cbRole.SelectedIndex == -1)
			{
				errorProviderWar.SetError(cbRole, "Vui lòng chọn chứ vụ!");
				return false;
			}

			// Kiểm tra tên tài khoản không được để trống
			if (tbAccount.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbAccount, "Tên tài khoản không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbAccount.Text.Trim()))
				{
					errorProviderWar.SetError(tbAccount, "Tài khoản không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpecialCharacters(tbAccount.Text.Trim()))
					{
						errorProviderWar.SetError(tbAccount, "Tài khoản không được chứa ký tự đặc biệt!");
						return false;
					}
				}
			}

			// Kiểm tra fullname không được để trống
			if (tbFullName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbFullName, "Tên không được để trống!");
				return false;
			}
			else if (IsSpecialCharacters(tbFullName.Text.Trim()))
			{
				errorProviderWar.SetError(tbFullName, "Tên không được chứa ký tự đặc biệt!");
				return false;
			}

			// Kiểm tra mật khẩu không được để trống
			if (tbPassword.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbPassword.Text.Trim()))
				{
					errorProviderWar.SetError(tbPassword, "Mật khẩu không được có dấu!");
					return false;
				}
				else if (IsSpaceCharacters(tbPassword.Text.Trim()))
				{
					errorProviderWar.SetError(tbPassword, "Mật khẩu không được chứa khoảng trắng!");
					return false;
				}
			}

			// Kiểm tra email không được để trống
			if (tbEmail.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbEmail, "Email không được để trống!");
				return false;
			}
			else
			{
				if (IsSpaceCharacters(tbEmail.Text.Trim()))
				{
					errorProviderWar.SetError(tbEmail, "Email không được chứa khoảng trắng!");
					return false;
				}
				else
				{
					if (IsUnicode(tbEmail.Text.Trim()))
					{
						errorProviderWar.SetError(tbEmail, "Email không được có dấu!");
						return false;
					}
					else if (IsSpecialCharacters(tbEmail.Text.Trim()))
					{
						if (tbEmail.Text.Trim().Contains("@"))
						{ }
						else
						{
							errorProviderWar.SetError(tbEmail, "Email không được chứa ký tự đặc biệt!");
							return false;
						}
					}
				}
			}

			// Kiểm tra số điện thoại khoản không được để trống
			if (tbPhone.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPhone, "Số điện thoại không được để trống!");
				return false;
			}
			else
			{
				if (IsSpaceCharacters(tbPhone.Text.Trim()))
				{
					errorProviderWar.SetError(tbPhone, "Số điện thoại không\nđược chứa khoảng trắng!");
					return false;
				}
				else
				{
					if (!IsDigit(tbPhone.Text.Trim()))
					{
						errorProviderWar.SetError(tbPhone, "Số điện thoại không được\nchứa ký tự khác ngoài số!");
						return false;
					}
				}
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

		private bool IsUnicode(string input)
		{
			var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
			var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
			return asciiBytesCount != unicodBytesCount;
		}

		private bool IsSpecialCharacters(string input) => input.Any(p => !char.IsLetterOrDigit(p));

		private bool IsSpaceCharacters(string input) => input.Any(char.IsWhiteSpace);

		private bool IsDigit(string input) => input.All(char.IsDigit);

		#endregion

		#region Events

		private void btnAdd_Click(object sender, EventArgs e)
		{
			isAddnew = true;
			VisibleButton(true);
			EnableControl(true);
			tbUserID.Text = AccountBLL.Instance.GetIDMissing().ToString();
		}

		private void FrmManageUser_Load(object sender, EventArgs e)
		{
			LoadData();
			EnableControl(false);
		}

		private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			dgvData["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
		}

		private void dgvData_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			rowIndex = e.RowIndex;
			DetailData(rowIndex);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (!IsValidUser())
				return;
			if (!int.TryParse(tbUserID.Text, out int userID))
			{
				MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				if (AccountBLL.Instance.DeleteAccount(userID))
				{
					MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
				else
				{
					MessageBox.Show("Xóa không thành công!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = tbSearch.Text.Trim();
			if (keyword.Equals("Nhập tên/Tài khoản/..."))
				keyword = string.Empty;
			AccountBLL.Instance.SearchAccount(dgvData, keyword);
		}

		private void tbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
			{
				tbSearch.Text = "Nhập tên/Tài khoản/...";
			}
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			VisibleButton(false);
			// Restore
			DetailData(rowIndex);
			EnableControl(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (isAddnew)
				AddUser();
			else
				UpdateUser();
			VisibleButton(false);
			EnableControl(false);
		}

		#endregion
	}
}
