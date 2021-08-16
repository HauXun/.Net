using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmManageUser : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private bool isEnable = false;
		private string username;
		private int rowIndex = 0;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }

		public FrmManageUser(UserAccount account)
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
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(233, 30, 59), 90F))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		#region Methods

		private void LoadData()
		{
			AccountBLL.Instance.GetAllAccount(cbClassFilter);
			RoleBLL.Instance.GetAllRoleUser(cbRole);
			RoleBLL.Instance.GetAllRoleUser(cbFilter);
			UserClassBLL.Instance.GetAllUserClass(cbClassID);
			AccountBLL.Instance.GetAllAccount(dgvData);
			if (dgvData.Rows.Count > 0)
				DetailData(0);
		}

		private UserAccount GetUserInfo()
		{
			UserAccount account = new UserAccount();
			int.TryParse(tbUserID.Text.Trim(), out int userId);
			account.UserID = userId;
			account.UserRole = cbRole.SelectedValue.ToString();
			account.ClassID = cbClassID.SelectedValue.ToString();
			account.Username = tbAccount.Text.Trim();
			account.FullName = tbFullName.Text.Trim();
			account.Email = tbEmail.Text.Trim();
			account.PhoneNumber = tbPhone.Text.Trim();
			account.Birthday = dtpDob.Value;
			account.Address = tbAddress.Text.Trim();
			return account;
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = dgvData.Rows[rowIndex];
				tbUserID.Text = row.Cells["UserID"].Value.ToString();
				cbRole.SelectedValue = row.Cells["UserRole"].Value;
				cbClassID.SelectedValue = row.Cells["ClassID"].Value;
				tbAccount.Text = row.Cells["Username"].Value.ToString();
				tbFullName.Text = row.Cells["FullName"].Value.ToString();
				tbPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
				tbAddress.Text = row.Cells["Address"].Value.ToString();
				tbEmail.Text = row.Cells["Email"].Value.ToString();
				dtpDob.Text = row.Cells["Birthday"].FormattedValue.ToString();
				username = row.Cells["Username"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
		}

		private void AddUser()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			UserAccount account = GetUserInfo();
			account.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			account.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";
			account.Note = $"Đã được tạo bởi {Account.UserRole} - {Account.FullName} vào {DateTime.Now}";

			if (!IsValidUser())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (AccountBLL.Instance.InsertAccount(account))
				{
					MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void UpdateAccount()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			UserAccount account = GetUserInfo();
			account.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";
			account.Note = $"Đã được sửa bởi {Account.UserRole} - {Account.FullName} vào {DateTime.Now}";

			if (!IsValidUser())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (AccountBLL.Instance.UpdateAccount(account))
				{
					MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void VisibleButton(bool isVisibleButton = false)
		{
			btnSave.Visible = btnCancle.Visible = isVisibleButton;
			btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = !isVisibleButton;
		}

		private void EnableControl(bool isEnable = true)
		{
			gbControls.Enabled = isEnable;
			if (dgvData.Rows.Count == 0)
				btnResetPassword.Enabled = false;
		}

		private void ClearControl()
		{
			foreach (Control control in gbControls.Controls)
			{
				if (control is TextBox)
					control.Text = string.Empty;
				if (control is DateTimePicker)
					(control as DateTimePicker).Value = DateTime.Today;
				if (control is ComboBox)
					(control as ComboBox).SelectedIndex = -1;
			}
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbAccount, "");
			errorProviderWar.SetError(tbFullName, "");
			errorProviderWar.SetError(tbEmail, "");
			errorProviderWar.SetError(tbPhone, "");
			errorProviderWar.SetError(dtpDob, "");
			errorProviderWar.SetError(tbAddress, "");
			errorProviderWar.SetError(cbRole, "");
			errorProviderWar.SetError(cbClassID, "");
		}

		private bool IsValidComboBoxControl()
		{
			ClearError();

			if (cbRole.Items.Count == 0)
			{
				errorProviderWar.SetError(cbRole, "Không có chức vụ!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbRole.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbRole, "Vui lòng chọn chức vụ");
					return false;
				}
			}

			if (cbRole.SelectedValue.ToString().Trim().Equals("User"))
			{
				if (cbClassID.Items.Count == 0)
				{
					errorProviderWar.SetError(cbClassID, "Không có lớp!\nVui lòng bổ sung");
					return false;
				}
				else
				{
					if (cbClassID.SelectedIndex == -1)
					{
						errorProviderWar.SetError(cbClassID, "Vui lòng chọn lớp");
						return false;
					}
				}
			}

			return true;
		}

		private bool IsValidUser()
		{
			ClearError();

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

			string[] arr = tbFullName.Text.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

			// Kiểm tra fullname không được để trống
			if (tbFullName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbFullName, "Tên không được để trống!");
				return false;
			}
			else
			{
				foreach (var item in arr)
				{
					if (IsSpecialCharacters(item))
					{
						errorProviderWar.SetError(tbFullName, "Tên không được chứa ký tự đặc biệt!");
						return false;
					}
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

		private void FrmManageUser_Load(object sender, EventArgs e)
		{
			LoadData();
			EnableControl(false);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			isAddnew = true;
			VisibleButton(true);
			EnableControl(true);
			ClearControl();
			tbUserID.Text = AccountBLL.Instance.GetIDMissing().ToString();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			if (!int.TryParse(tbUserID.Text, out int userID))
			{
				MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					if (AccountBLL.Instance.DeleteAccount(userID))
					{
						MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
						LoadData();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Xóa không thành công! Vui lòng kiểm tra lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = tbSearch.Text.Trim();
			if (keyword.Equals("Nhập tên/Tài khoản/..."))
				keyword = string.Empty;

			string roleFilter = "ALL";
			if (cbFilter.SelectedValue != null)
				roleFilter = cbFilter.SelectedValue.ToString();

			string classFilter = "Tất cả";
			if (cbClassFilter.SelectedValue != null)
				classFilter = cbClassFilter.SelectedValue.ToString();

			AccountBLL.Instance.SearchAccount(dgvData, keyword, roleFilter, classFilter);
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
			ClearError();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			isEnable = false;
			if (isAddnew)
				AddUser();
			else
				UpdateAccount();
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbRole.SelectedValue != null)
			{
				if (cbRole.SelectedValue.ToString().Trim().Equals("User"))
				{
					cbClassID.Enabled = true;
				}
				else
				{
					cbClassID.Enabled = false;	
				}
			}
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFilter.SelectedValue != null)
			{
				if (cbFilter.SelectedValue.ToString().Trim().Equals("User"))
				{
					cbClassFilter.Enabled = true;
				}
				else
				{
					cbClassFilter.Enabled = false;
				}
			}
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Xác nhận thay đổi!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					if (AccountBLL.Instance.ResetPassword(username))
					{
						MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
						LoadData();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Thay đổi không thành công! Vui lòng kiểm tra lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				}
			}
		}

		#endregion
	}
}
