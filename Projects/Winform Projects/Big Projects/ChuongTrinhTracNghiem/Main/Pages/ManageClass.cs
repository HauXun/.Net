using Bunifu.UI.WinForms;
using BusinessLogicLayer;
using Entities;
using Guna.UI2.WinForms;
using Main.Partial;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class ManageClass : UserControl
	{
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;

		private UserAccount account;
		public UserAccount Account { get => account; set => account = value; }
		public Action CancleAction;

		public ManageClass()
		{
			InitializeComponent();
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

		#region Methods

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void RoundedControls()
		{
			//Buttons
			btnAdd.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 6, 6));
			btnEdit.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnEdit.Width, btnEdit.Height, 6, 6));
			btnDelete.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 6, 6));
			btnSave.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 6, 6));
			btnCancle.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnCancle.Width, btnCancle.Height, 6, 6));
			btnClearFilter.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnClearFilter.Width, btnClearFilter.Height, 6, 6));
			//DataGridView
			aDgvdata.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, aDgvdata.Width, aDgvdata.Height, 15, 15));
		}

		/// <summary>
		/// Load dữ liệu lên
		/// </summary>
		private void LoadData()
		{
			try
			{
				UserClassBLL.Instance.GetAllClass(aDgvdata);
				CourseBLL.Instance.GetAllCourse(cbCourseID);
				FacultyBLL.Instance.GetAllFaculty(cbFaculty);
				SemesterBLL.Instance.GetAllSemester(cbNumberOfTrainingSemester);
				cbNumberOfTrainingSemester.DisplayMember = "SemesterID";
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

		/// <summary>
		/// Lấy thông tin lớp từ UI xuống
		/// </summary>
		/// <returns></returns>
		private UserClass GetUserClassInfo()
		{
			try
			{
				UserClass userClass = new UserClass();
				userClass.ClassID = tbClassID.Text.Trim();
				userClass.CourseID = cbCourseID.SelectedValue.ToString();
				userClass.FacultyID = cbFaculty.SelectedValue.ToString();
				userClass.AdmissionYear = (int)nudAdmissionYear.Value;
				userClass.NofTrainingSemester = byte.Parse(cbNumberOfTrainingSemester.SelectedValue.ToString());
				userClass.Description = tbDescription.Text.Trim();
				return userClass;
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				ClearControl();
			}
			return null;
		}

		/// <summary>
		/// Đưa data từ Datagridview lên
		/// </summary>
		/// <param name="rowIndex"></param>
		private void DetailData(int rowIndex)
		{
			try
			{
				if (aDgvdata.Rows.Count > 0)
				{
					DataGridViewRow row = aDgvdata.Rows[rowIndex];
					tbClassID.Text = row.Cells["ClassID"].Value.ToString();
					cbFaculty.SelectedValue = row.Cells["FacultyID"].Value;
					cbCourseID.SelectedValue = row.Cells["CourseID"].Value;
					nudAdmissionYear.Value = ushort.Parse(row.Cells["AdmissionYear"].Value.ToString());
					cbNumberOfTrainingSemester.SelectedValue = row.Cells["NofTrainingSemester"].Value;
					tbDescription.Text = row.Cells["Description"].Value.ToString();
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				ClearControl();
			}
		}

		/// <summary>
		/// Thêm lớp
		/// </summary>
		private void AddUserClass()
		{
			if (!IsValidUserClass())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			UserClass userClass = GetUserClassInfo();
			userClass.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			userClass.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (UserClassBLL.Instance.InsertClass(userClass))
				{
					MsgBox.ShowMessage("Thêm thành công!", "Amazing Quiz Application",
						MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					isFunc = false;
					UserClassBLL.Instance.GetAllClass(aDgvdata);
					NextAdditional();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu!\n" + e.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				isFunc = false;
				NextAdditional();
			}
		}

		/// <summary>
		/// Cập nhập lớp
		/// </summary>
		private void UpdateUserClass()
		{
			if (!IsValidUserClass())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			UserClass userClass = GetUserClassInfo();
			userClass.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (UserClassBLL.Instance.UpdateClass(userClass))
				{
					MsgBox.ShowMessage("Cập nhập thành công!", "Amazing Quiz Application",
						MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					cbFaculty.SelectedIndex = -1;
					LoadData();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!\n" + e.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				cbFaculty.SelectedIndex = -1;
				DetailData(rowIndex);
			}
		}

		/// <summary>
		/// Ẩn hiện các nút điều hướng
		/// </summary>
		/// <param name="isVisibleButton"></param>
		private void VisibleButton(bool isVisibleButton = false)
		{
			btnSave.Visible = btnCancle.Visible = isVisibleButton;
			btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = !isVisibleButton;
		}

		/// <summary>
		/// Ẩn hiển bảng thông tin UI
		/// </summary>
		/// <param name="isEnable"></param>
		private void EnableControl(bool isEnable = true)
		{
			pnlControls.Enabled = isEnable;
		}

		/// <summary>
		/// Xóa dữ liệu của control
		/// </summary>
		private void ClearControl()
		{
			foreach (Control control in pnlInfo1.Controls)
			{
				if (control is Guna2TextBox)
				{
					(control as Guna2TextBox).Text = "";
				}
			}
			foreach (Control control in pnlInfo2.Controls)
			{
				if (control is BunifuDropdown)
				{
					(control as BunifuDropdown).SelectedIndex = -1;
				}
			}
			foreach (Control control in pnlInfo3.Controls)
			{
				if (control is BunifuDropdown)
				{
					(control as BunifuDropdown).SelectedIndex = -1;
				}
				if (control is Guna2NumericUpDown)
				{
					(control as Guna2NumericUpDown).Value = 1900;
				}
			}
		}

		/// <summary>
		/// Xóa hết thông báo lỗi
		/// </summary>
		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbClassID, "");
			errorProviderWar.SetError(cbCourseID, "");
			errorProviderWar.SetError(cbFaculty, "");
			errorProviderWar.SetError(cbNumberOfTrainingSemester, "");
			errorProviderWar.SetError(nudAdmissionYear, "");
		}

		/// <summary>
		/// Bắt lỗi từ combobox
		/// </summary>
		/// <returns></returns>
		private bool IsValidComboBoxControl()
		{
			ClearError();

			if (cbCourseID.Items.Count == 0)
			{
				errorProviderWar.SetError(cbCourseID, "Không có khóa sinh viên nào!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbCourseID.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbCourseID, "Vui lòng chọn khóa của sinh viên!");
					return false;
				}
			}

			if (cbFaculty.Items.Count == 0)
			{
				errorProviderWar.SetError(cbFaculty, "Không có khoa!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbFaculty.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbFaculty, "Vui lòng chọn khoa!");
					return false;
				}
			}

			// Kiểm tra năm nhập học không được để trống
			if (string.IsNullOrEmpty(nudAdmissionYear.Text))
			{
				errorProviderWar.SetError(nudAdmissionYear, "Năm nhập học không được để trống!");
				return false;
			}
			else
			{
				if (nudAdmissionYear.Value <= 0)
				{
					errorProviderWar.SetError(nudAdmissionYear, "Năm nhập học phải lớn hơn 0!");
					return false;
				}
			}

			// Kiểm tra số học kì đào tạo không được để trống
			if (cbNumberOfTrainingSemester.Items.Count == 0)
			{
				errorProviderWar.SetError(cbNumberOfTrainingSemester, "Không có số học kì đào tạo\ncụ thể! Vui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbNumberOfTrainingSemester.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbNumberOfTrainingSemester, "Vui lòng chọn số học kì đào tạo!");
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Bắt lỗi từ bảng thông tin UI
		/// </summary>
		/// <returns></returns>
		private bool IsValidUserClass()
		{
			ClearError();

			// Kiểm tra mã khoa không được để trống
			if (string.IsNullOrEmpty(tbClassID.Text))
			{
				errorProviderWar.SetError(tbClassID, "Mã lớp không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbClassID.Text))
				{
					errorProviderWar.SetError(tbClassID, "Mã lớp không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpaceCharacters(tbClassID.Text))
					{
						errorProviderWar.SetError(tbClassID, "Mã lớp không được chứa khoảng trắng!");
						return false;
					}

					if (IsSpecialCharacters(tbClassID.Text))
					{
						errorProviderWar.SetError(tbClassID, "Mã lớp không được chứa ký tự đặc biệt!");
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		/// Kiểm tra chuỗi Unicode
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsUnicode(string input)
		{
			var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
			var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
			return asciiBytesCount != unicodBytesCount;
		}

		/// <summary>
		/// Kiểm tra kí tự đặc biệt
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsSpecialCharacters(string input) => input.Any(p => !char.IsLetterOrDigit(p));

		/// <summary>
		/// Kiểm tra chuỗi chứa khoảng trắng
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsSpaceCharacters(string input) => input.Any(char.IsWhiteSpace);

		/// <summary>
		/// Kiểm tra chuỗi chứa số
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsDigit(string input) => input.All(char.IsDigit);

		private void NextAdditional()
		{
			isAddnew = isEnable = true;
			tbDescription.Text = "";
			tbClassID.Text = "";
		}

		#endregion

		#region Events

		public void ManageClass_Load(object sender, EventArgs e)
		{
			LoadData();
			EnableControl(false);
			RoundedControls();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isAddnew = true;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			ClearControl();
			tbClassID.Enabled = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			tbClassID.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			string idClass = tbClassID.Text;

			if (string.IsNullOrEmpty(idClass) || rowIndex < 0)
			{
				MsgBox.ShowMessage("Vui lòng chọn lớp học cần xóa!", "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}

			if (MsgBox.ShowMessage("Xác nhận xóa!", "Amazing Quiz Application",
					   MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
			{
				try
				{
					if (UserClassBLL.Instance.DeleteClass(idClass))
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
					UserClassBLL.Instance.SearchClass(aDgvdata, "");
				aDgvdata.ClearFilter();
				aDgvdata_FilterStringChanged(sender, e);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void aDgvdata_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			aDgvdata["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
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

		private void tbSearch_IconRightClick(object sender, EventArgs e)
		{
			try
			{
				string keyword = tbSearch.Text;
				if (keyword.Equals("Nhập từ khóa ..."))
					keyword = string.Empty;
				UserClassBLL.Instance.SearchClass(aDgvdata, keyword);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isFunc = true;
			isAddnew = false;
			cbFaculty.SelectedIndex = -1;
			VisibleButton(false);
			// Restore
			DetailData(rowIndex);
			EnableControl(false);
			ClearError();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isEnable = false;
			isFunc = true;
			try
			{
				if (isAddnew)
					AddUserClass();
				else
					UpdateUserClass();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isFunc && cbFaculty.SelectedValue != null)
			{
				CourseBLL.Instance.GetAllCourseByFaculty(cbCourseID, cbFaculty.SelectedValue.ToString());
				cbCourseID.SelectedIndex = -1;
			}
			else if (!isAddnew)
			{
				CourseBLL.Instance.GetAllCourse(cbCourseID);
			}
		}

		private void aDgvdata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 7;
				bScrollBar.Value = bScrollBar.Maximum;
			}
			catch { }
		}

		private void aDgvdata_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 7;
				bScrollBar.Value = bScrollBar.Maximum;
			}
			catch { }
		}

		private void bScrollBar_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
		{
			try
			{
				if (e.Value > 6)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - e.Value - 6].Index;
				else if (e.Value == 0)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1)].Index;
				else
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - 7].Index;
			}
			catch { }
		}

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += ManageClass_GotFocus;
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as ADGV.AdvancedDataGridView).GotFocus += ManageClass_GotFocus;
		}

		private void ManageClass_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void ManageClass_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}