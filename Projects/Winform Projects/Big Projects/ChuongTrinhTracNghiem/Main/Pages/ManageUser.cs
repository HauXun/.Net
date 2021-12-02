using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System.Text;
using System.Linq;
using System.ComponentModel;

namespace Main.Pages
{
	public partial class ManageUser : UserControl
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public Action CancleAction;

		public ManageUser()
		{
			InitializeComponent();
			RoundedControls();
			CancleAction = () =>
			{
				if (btnSave.Visible && MsgBox.ShowMessage("Dữ liệu chưa được lưu!. Tiếp tục thoát ?", "Amazing Quiz Application",
					   MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
				{
					btnCancle_Click(this, new EventArgs());
					Session.Cancle = true;
				}
				else if (!btnSave.Visible)
					Session.Cancle = true;
				else
					Session.Cancle = false;
			};
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				tbSearch_IconRightClick(this, new EventArgs());
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 240F)) // 196, 232, 250 || //FromArgb(230, 110, 130)
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		//Bo tròn góc các Control
		#region Rounded Controls

		private void RoundedControls()
		{
			//Buttons
			btnAdd.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 6, 6));
			btnEdit.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnEdit.Width, btnEdit.Height, 6, 6));
			btnDelete.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 6, 6));
			btnSave.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 6, 6));
			btnCancle.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnCancle.Width, btnCancle.Height, 6, 6));
			btnClearFilter.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnClearFilter.Width, btnClearFilter.Height, 6, 6));
			btnResetPassword.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnResetPassword.Width, btnResetPassword.Height, 6, 6));
			//DataGridView
			aDgvdata.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, aDgvdata.Width, aDgvdata.Height, 15, 15));
		}

		#endregion

		#region Methods

		private void LoadData()
		{
			try
			{
				AccountBLL.Instance.GetAllAccount(aDgvdata);
				RoleBLL.Instance.GetAllRoleUser(cbRole);
				RoleBLL.Instance.GetAllRoleUser(cbFilter);
				UserClassBLL.Instance.GetAllClass(cbClassID);
				CourseBLL.Instance.GetAllCourse(cbCourseID);
				cbCourseID.SelectedIndex = -1;
				if (aDgvdata.Rows.Count > 0)
					DetailData(0);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				ClearControl();
			}
		}

		private UserAccount GetUserInfo()
		{
			try
			{
				UserAccount account = new UserAccount();
				account.UserID = int.Parse(tbUserID.Text); // AccountBLL.Instance.GetIDMissing();
				account.UserRole = cbRole.SelectedValue.ToString();
				account.ClassID = (string)cbClassID.SelectedValue;
				account.Username = tbAccount.Text;
				account.FullName = tbFullName.Text;
				account.Email = tbEmail.Text;
				account.PhoneNumber = tbPhone.Text;
				account.Birthday = dtpDob.Value;
				account.Address = tbAddress.Text;
				return account;
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				ClearControl();
			}
			return null;
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				if (aDgvdata.Rows.Count > 0)
				{
					DataGridViewRow row = aDgvdata.Rows[rowIndex];
					tbUserID.Text = row.Cells["UserID"].Value.ToString();
					cbRole.SelectedValue = row.Cells["UserRole"].Value;
					cbClassID.SelectedValue = row.Cells["ClassID"].Value;
					tbAccount.Text = row.Cells["Username"].Value.ToString();
					tbFullName.Text = row.Cells["FullName"].Value.ToString();
					tbPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
					tbAddress.Text = row.Cells["Address"].Value.ToString();
					tbEmail.Text = row.Cells["Email"].Value.ToString();
					dtpDob.Text = row.Cells["Birthday"].FormattedValue.ToString();
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				ClearControl();
			}
		}

		private void AddUser()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			if (!IsValidUser())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			UserAccount account = GetUserInfo();
			account.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			account.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";
			account.Note = $"Đã được tạo bởi {Account.UserRole} - {Account.FullName} vào {DateTime.Now.ToString("dd/MM/yyyy")}";

			try
			{
				if (AccountBLL.Instance.InsertAccount(account))
				{
					MsgBox.ShowMessage("Thêm thành công!", "Amazing Quiz Application",
						   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					//cbCourseID.SelectedIndex = -1;
					isFunc = false;
					AccountBLL.Instance.GetAllAccount(aDgvdata);
					NextAdditional();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Amazing Quiz Application",
					   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				//cbCourseID.SelectedIndex = -1;
				isFunc = false;
				NextAdditional();
			}
		}

		private void UpdateAccount()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			if (!IsValidUser())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			UserAccount account = GetUserInfo();
			account.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";
			account.Note = $"Đã được sửa bởi {Account.UserRole} - {Account.FullName} vào {DateTime.Now.ToString("dd/MM/yyyy")}";

			try
			{
				if (AccountBLL.Instance.UpdateAccount(account))
				{
					MsgBox.ShowMessage("Cập nhập thành công!", "Amazing Quiz Application",
						   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					cbCourseID.SelectedIndex = -1;
					LoadData();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Amazing Quiz Application",
					   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				cbCourseID.SelectedIndex = -1;
				DetailData(rowIndex);
			}
		}

		private void VisibleButton(bool isVisibleButton = false)
		{
			btnSave.Visible = btnCancle.Visible = isVisibleButton;
			btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = !isVisibleButton;
		}

		private void EnableControl(bool isEnable = true)
		{
			pnlControls.Enabled = isEnable;
			if (aDgvdata.Rows.Count == 0)
				btnResetPassword.Enabled = false;
		}

		private void ClearControl()
		{
			foreach (Control control in pnlInfo1.Controls)
			{
				if (control is BunifuDropdown)
					(control as BunifuDropdown).SelectedIndex = -1;
			}
			foreach (Control control in pnlInfo2.Controls)
			{
				if (control is Guna2TextBox)
					(control as Guna2TextBox).Text = "";
			}
			foreach (Control control in pnlInfo3.Controls)
			{
				if (control is Guna2TextBox)
					(control as Guna2TextBox).Text = "";
				if (control is Guna2DateTimePicker)
					(control as Guna2DateTimePicker).Value = DateTime.Today;
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

			if (cbRole.SelectedValue.ToString().Equals("User"))
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
			if (string.IsNullOrEmpty(tbAccount.Text))
			{
				errorProviderWar.SetError(tbAccount, "Tên tài khoản không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbAccount.Text))
				{
					errorProviderWar.SetError(tbAccount, "Tài khoản không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpecialCharacters(tbAccount.Text))
					{
						errorProviderWar.SetError(tbAccount, "Tài khoản không được chứa ký tự đặc biệt!");
						return false;
					}
				}
			}

			string[] arr = tbFullName.Text.Split(' '); //.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

			// Kiểm tra fullname không được để trống
			if (string.IsNullOrEmpty(tbFullName.Text))
			{
				errorProviderWar.SetError(tbFullName, "Tên không được để trống!");
				return false;
			}
			else
			{
				foreach (var item in arr)
				{
					if (string.IsNullOrEmpty(item))
					{
						errorProviderWar.SetError(tbFullName, "Tên không được chứa nhiều dấu khoảng trắng!");
						return false;
					}
				}
			}

			// Kiểm tra email không được để trống
			if (string.IsNullOrEmpty(tbEmail.Text))
			{
				errorProviderWar.SetError(tbEmail, "Email không được để trống!");
				return false;
			}
			else
			{
				if (IsSpaceCharacters(tbEmail.Text))
				{
					errorProviderWar.SetError(tbEmail, "Email không được chứa khoảng trắng!");
					return false;
				}
				else
				{
					if (IsUnicode(tbEmail.Text))
					{
						errorProviderWar.SetError(tbEmail, "Email không được có dấu!");
						return false;
					}
					else if (IsSpecialCharacters(tbEmail.Text))
					{
						if (tbEmail.Text.Contains("@"))
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
			if (string.IsNullOrEmpty(tbPhone.Text))
			{
				errorProviderWar.SetError(tbPhone, "Số điện thoại không được để trống!");
				return false;
			}
			else
			{
				if (IsSpaceCharacters(tbPhone.Text))
				{
					errorProviderWar.SetError(tbPhone, "Số điện thoại không\nđược chứa khoảng trắng!");
					return false;
				}
				else
				{
					if (!IsDigit(tbPhone.Text))
					{
						errorProviderWar.SetError(tbPhone, "Số điện thoại không được\nchứa ký tự khác ngoài số!");
						return false;
					}
				}
			}

			// Kiểm tra ngày sinh toàn vẹn giá trị
			if (DateTime.Now.Year - dtpDob.Value.Year < 18)
			{
				errorProviderWar.SetError(dtpDob, "Phải từ 18 tuổi trở lên!");
				return false;
			}

			// Kiểm tra địa chỉ không được để trống
			if (string.IsNullOrEmpty(tbAddress.Text))
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

		private void NextAdditional()
		{
			isAddnew = isEnable = true;
			foreach (Control control in pnlInfo2.Controls)
			{
				if (control is Guna2TextBox)
					(control as Guna2TextBox).Text = "";
			}
			foreach (Control control in pnlInfo3.Controls)
			{
				if (control is Guna2TextBox)
					(control as Guna2TextBox).Text = "";
				if (control is Guna2DateTimePicker)
					(control as Guna2DateTimePicker).Value = DateTime.Today;
			}
			tbUserID.Text = AccountBLL.Instance.GetIDMissing().ToString();
		}

		#endregion

		#region Events

		public void FrmManageUser_Load(object sender, EventArgs e)
		{
			LoadData();
			EnableControl(false);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isAddnew = true;
			isFunc = false;
			tbUserID.Text = AccountBLL.Instance.GetIDMissing().ToString();
			ClearControl();
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (int.Parse(tbUserID.Text) == 0)
			{
				MsgBox.ShowMessage("Vui lòng chọn người dùng cần xóa!", "Amazing Quiz Application",
					   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}

			if (MsgBox.ShowMessage("Xác nhận xóa!", "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
			{
				try
				{
					if (AccountBLL.Instance.DeleteAccount(int.Parse(tbUserID.Text)))
					{
						MsgBox.ShowMessage("Xóa thành công!", "Amazing Quiz Application",
							   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
						LoadData();
					}
				}
				catch (Exception ex)
				{
					MsgBox.ShowMessage("Xóa không thành công! Vui lòng kiểm tra lại!\n" + ex.Message, "Amazing Quiz Application",
						   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				}
			}
		}

		private void aDgvdata_SortStringChanged(object sender, EventArgs e)
		{
			if (!aDgvdata.SortString.Contains("STT"))
			{
				BindingSource source = new BindingSource() { DataSource = aDgvdata.DataSource, Sort = aDgvdata.SortString };
				aDgvdata.DataSource = source.DataSource;
			}
			else
			{
				if (aDgvdata.SortString.Split(' ')[1].Equals("DESC"))
				{
					this.aDgvdata.Sort(this.aDgvdata.Columns[1], ListSortDirection.Descending);
				}
				else if (aDgvdata.SortString.Split(' ')[1].Equals("ASC"))
				{
					this.aDgvdata.Sort(this.aDgvdata.Columns[1], ListSortDirection.Ascending);
				}
			}
		}

		private void aDgvdata_FilterStringChanged(object sender, EventArgs e)
		{
			if (!aDgvdata.FilterString.Contains("STT"))
			{
				BindingSource source = new BindingSource() { DataSource = aDgvdata.DataSource, Filter = aDgvdata.FilterString };
				aDgvdata.DataSource = source.DataSource;
			}
		}

		private void btnClearFilter_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			try
			{
				if (!string.IsNullOrEmpty(tbSearch.Text))
					AccountBLL.Instance.SearchAccount(aDgvdata, "");
				aDgvdata.ClearFilter();
				aDgvdata_FilterStringChanged(sender, e);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void aDgvdata_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (isFunc)
			{
				if (e.RowIndex < 0)
					return;
				rowIndex = e.RowIndex;
				DetailData(rowIndex);
			}
			else
			{
				rowIndex = e.RowIndex;
			}
		}

		private void tbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSearch.Text))
			{
				tbSearch.Text = "Nhập từ khóa ...";
			}
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isAddnew = false;
			isFunc = true;
			cbCourseID.SelectedIndex = -1;
			VisibleButton(false);
			// Restore
			DetailData(rowIndex);
			EnableControl(false);
			ClearError();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isFunc = true;
			isEnable = false;
			try
			{
				if (isAddnew)
					AddUser();
				else
					UpdateAccount();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbCourseID.SelectedValue = cbClassID.SelectedValue = string.Empty;
			if (cbRole.SelectedValue != null && cbRole.SelectedValue.ToString().Equals("User"))
			{
				cbCourseID.Enabled = cbClassID.Enabled = true;
			}
			else
			{
				cbCourseID.Enabled = cbClassID.Enabled = false;
			}
		}

		private void cbCourseID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isFunc && cbCourseID.SelectedValue != null)
			{
				UserClassBLL.Instance.GetAllClassByCourseID(cbClassID, cbCourseID.SelectedValue.ToString());
				cbClassID.SelectedIndex = -1;
			}
			else if (!isAddnew)
			{
				UserClassBLL.Instance.GetAllClass(cbClassID);
			}
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (MsgBox.ShowMessage("Xác nhận thay đổi!", "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
			{
				try
				{
					if (AccountBLL.Instance.ResetPassword(tbAccount.Text))
					{
						MsgBox.ShowMessage("Thay đổi thành công!", "Amazing Quiz Application",
							   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
						LoadData();
					}
				}
				catch (Exception ex)
				{
					MsgBox.ShowMessage("Thay đổi không thành công! Vui lòng kiểm tra lại!\n" + ex.Message, "Amazing Quiz Application",
						   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
					DetailData(rowIndex);
				}
			}
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFilter.SelectedValue != null)
				AccountBLL.Instance.SearchAccount(aDgvdata, "", cbFilter.SelectedValue.ToString());
		}

		private void aDgvdata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 5;
				bScrollBar.Value = bScrollBar.Maximum;
			}
			catch { }
		}

		private void aDgvdata_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 5;
				bScrollBar.Value = bScrollBar.Maximum;
			}
			catch { }
		}

		private void bScrollBar_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
		{
			try
			{
				if (e.Value > 4)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - e.Value - 4].Index;
				else if (e.Value == 0)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1)].Index;
				else
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - 5].Index;
			}
			catch { }
		}

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += ManageUser_GotFocus;
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as ADGV.AdvancedDataGridView).GotFocus += ManageUser_GotFocus;
		}

		private void ManageUser_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void tbSearch_IconRightClick(object sender, EventArgs e)
		{
			try
			{
				string keyword = tbSearch.Text.Trim();
				if (keyword.Equals("Nhập từ khóa ..."))
					keyword = string.Empty;

				string roleFilter = "ALL";
				if (cbFilter.SelectedValue != null)
					roleFilter = cbFilter.SelectedValue.ToString();

				AccountBLL.Instance.SearchAccount(aDgvdata, keyword, roleFilter);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void ManageUser_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
