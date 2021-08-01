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
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
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
			errorProviderWar.SetError(tbRole, "");
			errorProviderWar.SetError(tbAccount, "");
			errorProviderWar.SetError(tbFullName, "");
			errorProviderWar.SetError(tbPassword, "");
			errorProviderWar.SetError(tbEmail, "");
			errorProviderWar.SetError(tbPhone, "");
			errorProviderWar.SetError(dtpDob, "");
			errorProviderWar.SetError(tbAddress, "");

			// Kiểm tra chức vụ không được để trống
			if (tbRole.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbRole, "Chức vụ không được để trống!");
				return false;
			}
			else
			{
				List<string> role = new List<string>() { "admin", "teacher", "user" };
				if (!role.Contains(tbRole.Text.ToLower().Trim()))
				{
					errorProviderWar.SetError(tbRole, "Vui lòng nhập đúng chức vụ!\nAdmin, Teacher, User");
					return false;
				}
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
			UserAccount account = GetUserInfo();
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

		#endregion

		private void FrmManageUser_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			dgvData["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
		}

		private void dgvData_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			try
			{
				DataGridViewRow row = dgvData.Rows[e.RowIndex];
				tbUserID.Text = row.Cells["UserID"].Value.ToString();
				tbAccount.Text = row.Cells["Username"].Value.ToString();
				tbPassword.Text = row.Cells["Password"].Value.ToString();
				tbFullName.Text = row.Cells["FullName"].Value.ToString();
				tbRole.Text = row.Cells["RoleID"].Value.ToString();
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			UserAccount account = GetUserInfo();
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
	}
}
