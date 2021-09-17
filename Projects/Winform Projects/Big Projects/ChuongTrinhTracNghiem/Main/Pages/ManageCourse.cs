﻿using BusinessLogicLayer;
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
	public partial class ManageCourse : UserControl
    {
        private bool isAddnew = false;
        private bool isEnable = false;
        private bool isFunc = true;
        private int rowIndex = 0;
        public Action HomeFunc;

        public ManageCourse()
		{
			InitializeComponent();
            RoundedControls();
            HomeFunc = () =>
            {
				if (btnSave.Visible && MsgBox.ShowMessage("Dữ liệu chưa được lưu!. Tiếp tục thoát ?", "Amazing Quiz Application",
					MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
				{
					Session.bP.SetPage((int)Session.TabPage.MainMenu);
					btnCancle_Click(this, new EventArgs());
				}
				else if (!btnSave.Visible)
				{
					Session.bP.SetPage((int)Session.TabPage.MainMenu);
				}
			};
        }

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rectangle = ClientRectangle;
            if (rectangle.IsEmpty)
                return;
            if (rectangle.Width == 0 || rectangle.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 90F)) // 196, 232, 250 || //FromArgb(230, 110, 130)
            {
                e.Graphics.FillRectangle(brush, rectangle);
            }
        }

        //Bo tròn góc các Control
        #region Rounded Controls

        private void RoundedControls()
        {
            //Panels
            pnlDataGridView.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlDataGridView.Width, pnlDataGridView.Height, 10, 10));
            pnlInfo1.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlInfo1.Width, pnlInfo1.Height, 10, 10));
            pnlInfo2.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlInfo2.Width, pnlInfo2.Height, 10, 10));
            //Panels Shadow
            pnlDataGridViewShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlDataGridViewShadow.Width, pnlDataGridViewShadow.Height, 10, 10));
            pnl1Shadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnl1Shadow.Width, pnl1Shadow.Height, 10, 10));
            pnl2Shadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnl2Shadow.Width, pnl2Shadow.Height, 10, 10));
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
				FacultyBLL.Instance.GetAllFaculty(cbFaculty);
				RoleBLL.Instance.GetAllTrainingRole(cbTrainingRole);
				CourseBLL.Instance.GetAllCourse(aDgvdata);
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

		private CourseOrder GetCourseOrderInfo()
		{
			try
			{
				CourseOrder course = new CourseOrder();
				course.CourseID = tbCourseID.Text.Trim();
				course.FacultyID = cbFaculty.SelectedValue.ToString();
				course.TrainingID = cbTrainingRole.SelectedValue.ToString();
				course.Description = tbDescription.Text.Trim();
				return course;
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
					tbCourseID.Text = row.Cells["CourseID"].Value.ToString();
					cbFaculty.SelectedValue = row.Cells["FacultyID"].Value;
					cbTrainingRole.SelectedValue = row.Cells["TrainingID"].Value;
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

		private void AddCourseOrder()
		{
			if (!IsValidCourseOrder())
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

			CourseOrder course = GetCourseOrderInfo();

			try
			{
				if (CourseBLL.Instance.InsertCourse(course))
				{
					MsgBox.ShowMessage("Thêm thành công!", "Amazing Quiz Application",
						MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					isAddnew = false;
					LoadData();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu!\n" + e.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void UpdateCourseOrder()
		{
			if (!IsValidCourseOrder())
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

			CourseOrder course = GetCourseOrderInfo();

			try
			{
				if (CourseBLL.Instance.UpdateCourse(course))
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
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbCourseID, "");
			errorProviderWar.SetError(cbFaculty, "");
			errorProviderWar.SetError(cbTrainingRole, "");
		}

		private bool IsValidComboBoxControl()
		{
			ClearError();

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

			if (cbTrainingRole.Items.Count == 0)
			{
				errorProviderWar.SetError(cbTrainingRole, "Không có loại hình đào tạo!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbTrainingRole.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbTrainingRole, "Vui lòng chọn loại hình đào tạo!");
					return false;
				}
			}

			return true;
		}

		private bool IsValidCourseOrder()
		{
			ClearError();

			// Kiểm tra mã khoa không được để trống
			if (string.IsNullOrEmpty(tbCourseID.Text))
			{
				errorProviderWar.SetError(tbCourseID, "Mã khoa không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbCourseID.Text))
				{
					errorProviderWar.SetError(tbCourseID, "Mã khoa không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpaceCharacters(tbCourseID.Text))
					{
						errorProviderWar.SetError(tbCourseID, "Mã khoa không được chứa khoảng trắng!");
						return false;
					}

					if (IsSpecialCharacters(tbCourseID.Text))
					{
						errorProviderWar.SetError(tbCourseID, "Mã khoa không được chứa ký tự đặc biệt!");
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

		#endregion

		#region Events

		public void FrmManageCourse_Load(object sender, EventArgs e)
		{
			this.FindForm().AcceptButton = btnSearch;
			LoadData();
			EnableControl(false);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			isAddnew = true;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			ClearControl();
			tbCourseID.Enabled = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			tbCourseID.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string subjectID = tbCourseID.Text;
			string facultyID = cbFaculty.SelectedValue.ToString();
			if (!IsValidCourseOrder())
				return;

			if (string.IsNullOrEmpty(subjectID) || rowIndex < 0)
			{
				MsgBox.ShowMessage("Vui lòng chọn khóa học cần xóa!", "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}

			if (MsgBox.ShowMessage("Xác nhận xóa!", "Amazing Quiz Application",
					   MessageBoxButtons.YesNo, MsgBox.MessageIcon.ExclamationTriangle) == DialogResult.Yes)
			{
				try
				{
					if (CourseBLL.Instance.DeleteCourse(subjectID, facultyID))
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

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = tbSearch.Text;
			if (keyword.Equals("Nhập từ khóa ..."))
				keyword = string.Empty;
			CourseBLL.Instance.SearchCourse(aDgvdata, keyword);
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
			if (!string.IsNullOrEmpty(tbSearch.Text))
				CourseBLL.Instance.SearchCourse(aDgvdata, "");
			aDgvdata.ClearFilter();
			aDgvdata_FilterStringChanged(sender, e);
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
			isFunc = true;
			isAddnew = false;
			VisibleButton(false);
			// Restore
			DetailData(rowIndex);
			EnableControl(false);
			ClearError();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			isEnable = false;
			isFunc = true;
			try
			{
				if (isAddnew)
					AddCourseOrder();
				else
					UpdateCourseOrder();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		#endregion
	}
}