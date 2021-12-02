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
using Bunifu.UI.WinForms;

namespace Main.Pages
{
	public partial class ManageSubject : UserControl
	{
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public Action CancleAction;

		public ManageSubject()
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
			//DataGridView
			aDgvdata.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, aDgvdata.Width, aDgvdata.Height, 15, 15));
		}

		#endregion


		#region Methods

		private void LoadData()
		{
			try
			{
				RoleBLL.Instance.GetAllSubjectRole(cbSubjectRole);
				FacultyBLL.Instance.GetAllFaculty(cbFacultyID);
				//cbFacultyID.SelectedIndex = -1;
				CourseBLL.Instance.GetAllCourse(cbCourseID);
				SemesterBLL.Instance.GetAllSemester(cbSemesterID);
				SubjectBLL.Instance.GetAllSubject(aDgvdata);
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

		private Subject GetSubjectInfo()
		{
			try
			{
				Subject subject = new Subject();
				subject.SubjectID = tbSubjectID.Text.Trim();
				subject.SubjectRole = cbSubjectRole.SelectedValue.ToString();
				subject.CourseID = cbCourseID.SelectedValue.ToString();
				subject.FacultyID = cbFacultyID.SelectedValue.ToString();
				subject.SemesterID = byte.Parse(cbSemesterID.SelectedValue.ToString());
				subject.SubjectName = tbSubjectName.Text.Trim();
				subject.Description = tbDescription.Text.Trim();
				return subject;
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
					tbSubjectID.Text = row.Cells["SubjectID"].Value.ToString();
					tbSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
					cbSubjectRole.SelectedValue = row.Cells["SubjectRole"].Value;
					cbFacultyID.SelectedValue = row.Cells["FacultyID"].Value;
					cbCourseID.SelectedValue = row.Cells["CourseID"].Value;
					cbSemesterID.SelectedValue = row.Cells["SemesterID"].Value;
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

		private void AddSubject()
		{
			if (!IsValidSubject())
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

			Subject subject = GetSubjectInfo();
			subject.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			subject.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (SubjectBLL.Instance.InsertSubject(subject))
				{
					MsgBox.ShowMessage("Thêm thành công!", "Amazing Quiz Application",
				   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					isFunc = false;
					SubjectBLL.Instance.GetAllSubject(aDgvdata);
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

		private void UpdateSubject()
		{
			if (!IsValidSubject())
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

			Subject subject = GetSubjectInfo();
			subject.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (SubjectBLL.Instance.UpdateSubject(subject))
				{
					MsgBox.ShowMessage("Cập nhập thành công!", "Amazing Quiz Application",
				   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!\n" + e.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
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
		}

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
				if (control is Guna2TextBox)
				{
					(control as Guna2TextBox).Text = "";
				}
				if (control is BunifuDropdown)
				{
					(control as BunifuDropdown).SelectedIndex = -1;
				}
			}
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbSubjectID, "");
			errorProviderWar.SetError(tbSubjectName, "");
			errorProviderWar.SetError(cbSubjectRole, "");
			errorProviderWar.SetError(cbFacultyID, "");
			errorProviderWar.SetError(cbCourseID, "");
			errorProviderWar.SetError(cbSemesterID, "");
		}

		private bool IsValidComboBoxControl()
		{
			ClearError();

			if (cbFacultyID.Items.Count == 0)
			{
				errorProviderWar.SetError(cbFacultyID, "Không có khoa!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbFacultyID.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbFacultyID, "Vui lòng chọn khoa của môn này!");
					return false;
				}
			}

			if (cbCourseID.Items.Count == 0)
			{
				errorProviderWar.SetError(cbCourseID, "Không có khóa sinh viên nào!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbCourseID.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbCourseID, "Vui lòng chọn khóa sinh\nviên cho bộ môn này!");
					return false;
				}
			}

			if (cbSubjectRole.Items.Count == 0)
			{
				errorProviderWar.SetError(cbSubjectRole, "Không có môn kiểu môn!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbSubjectRole.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbSubjectRole, "Vui lòng chọn kiểu môn cho môn này!");
					return false;
				}
			}

			if (cbSemesterID.Items.Count == 0)
			{
				errorProviderWar.SetError(cbSemesterID, "Không có học kì nào!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbSemesterID.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbSemesterID, "Vui lòng chọn học kì sẽ được\náp dụng cho bộ môn này!");
					return false;
				}
			}

			return true;
		}

		private bool IsValidSubject()
		{
			ClearError();

			// Kiểm tra mã môn thi không được để trống
			if (string.IsNullOrEmpty(tbSubjectID.Text))
			{
				errorProviderWar.SetError(tbSubjectID, "Mã môn thi không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbSubjectID.Text))
				{
					errorProviderWar.SetError(tbSubjectID, "Mã môn thi không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpaceCharacters(tbSubjectID.Text))
					{
						errorProviderWar.SetError(tbSubjectID, "Mã môn thi không được chứa khoảng trắng!");
						return false;
					}

					if (IsSpecialCharacters(tbSubjectID.Text))
					{
						errorProviderWar.SetError(tbSubjectID, "Mã môn thi không được chứa ký tự đặc biệt!");
						return false;
					}
				}
			}

			string[] arr = tbSubjectName.Text.Split(' '); //.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

			// Kiểm tra tên môn thi không được để trống
			if (string.IsNullOrEmpty(tbSubjectName.Text))
			{
				errorProviderWar.SetError(tbSubjectName, "Tên môn thi không được để trống!");
				return false;
			}
			else
			{
				foreach (var item in arr)
				{
					if (string.IsNullOrEmpty(item))
					{
						errorProviderWar.SetError(tbSubjectName, "Tên môn thi không được chứa\nnhiều dấu khoảng trắng!");
						return false;
					}
				}
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
			foreach (Control control in pnlInfo1.Controls)
			{
				if (control is Guna2TextBox)
				{
					(control as Guna2TextBox).Text = "";
				}
			}
			tbDescription.Text = "";
		}

		#endregion

		#region Events

		public void FrmManageSubject_Load(object sender, EventArgs e)
		{
			LoadData();
			EnableControl(false);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isAddnew = true;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			ClearControl();
			tbSubjectID.Enabled = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			tbSubjectID.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			string subjectID = tbSubjectID.Text.Trim();
			if (!IsValidSubject())
				return;

			if (string.IsNullOrEmpty(subjectID) || rowIndex < 0)
			{
				MsgBox.ShowMessage("Vui lòng chọn môn thi cần xóa!", "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}

			if (MsgBox.ShowMessage("Xác nhận xóa!", "Amazing Quiz Application",
			   MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
			{
				try
				{
					if (SubjectBLL.Instance.DeleteSubject(subjectID))
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
					SubjectBLL.Instance.SearchSubject(aDgvdata, "");
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

		private void btnCancle_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isAddnew = false;
			isFunc = true;
			cbFacultyID.SelectedIndex = -1;
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
					AddSubject();
				else
					UpdateSubject();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		private void cbFacultyID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isFunc && cbFacultyID.SelectedValue != null)
			{
				CourseBLL.Instance.GetAllCourseByFaculty(cbCourseID, cbFacultyID.SelectedValue.ToString());
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
			(sender as FontAwesome.Sharp.IconButton).GotFocus += ManageSubject_GotFocus;
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as ADGV.AdvancedDataGridView).GotFocus += ManageSubject_GotFocus;
		}

		private void ManageSubject_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void tbSearch_IconRightClick(object sender, EventArgs e)
		{
			try
			{
				string keyword = tbSearch.Text;
				if (keyword.Equals("Nhập từ khóa ..."))
					keyword = string.Empty;
				SubjectBLL.Instance.SearchSubject(aDgvdata, keyword);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void ManageSubject_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
