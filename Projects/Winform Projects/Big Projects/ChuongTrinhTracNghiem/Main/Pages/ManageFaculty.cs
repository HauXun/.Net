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

namespace Main.Pages
{
	public partial class ManageFaculty : UserControl
	{
        private bool isAddnew = false;
        private bool isEnable = false;
        private bool isFunc = true;
        private int rowIndex = 0;

		public Action HomeFunc;

		public ManageFaculty()
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
				FacultyBLL.Instance.GetAllFaculty(aDgvdata);
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

		private Faculty GetFacultyInfo()
		{
			try
			{
				Faculty faculty = new Faculty();
				faculty.FacultyID = tbFacultyID.Text.Trim();
				faculty.FacultyName = tbFacultyName.Text.Trim();
				faculty.FoundingDate = dtpFoundingDate.Value;
				faculty.Description = tbDescription.Text.Trim();
				return faculty;
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
					tbFacultyID.Text = row.Cells["FacultyID"].Value.ToString();
					tbFacultyName.Text = row.Cells["FacultyName"].Value.ToString();
					dtpFoundingDate.Text = row.Cells["FoundingDate"].FormattedValue.ToString();
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

		private void AddFaculty()
		{
			if (!IsValidFaculty())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			Faculty faculty = GetFacultyInfo();

			try
			{
				if (FacultyBLL.Instance.InsertFaculty(faculty))
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

		private void UpdateFaculty()
		{
			if (!IsValidFaculty())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			Faculty faculty = GetFacultyInfo();

			try
			{
				if (FacultyBLL.Instance.UpdateFaculty(faculty))
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
				if (control is Guna2TextBox)
				{
					(control as Guna2TextBox).Text = "";
				}
				if (control is Guna2DateTimePicker)
				{
					(control as Guna2DateTimePicker).Value = DateTime.Today;
				}
			}
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbFacultyID, "");
			errorProviderWar.SetError(tbFacultyName, "");
		}

		private bool IsValidFaculty()
		{
			ClearError();

			// Kiểm tra mã khoa không được để trống
			if (string.IsNullOrEmpty(tbFacultyID.Text))
			{
				errorProviderWar.SetError(tbFacultyID, "Mã khoa không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbFacultyID.Text))
				{
					errorProviderWar.SetError(tbFacultyID, "Mã khoa không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpaceCharacters(tbFacultyID.Text))
					{
						errorProviderWar.SetError(tbFacultyID, "Mã khoa không được chứa khoảng trắng!");
						return false;
					}

					if (IsSpecialCharacters(tbFacultyID.Text))
					{
						errorProviderWar.SetError(tbFacultyID, "Mã khoa không được chứa ký tự đặc biệt!");
						return false;
					}
				}
			}

			string[] arr = tbFacultyName.Text.Split(' '); //.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

			// Kiểm tra tên khoa không được để trống
			if (string.IsNullOrEmpty(tbFacultyName.Text))
			{
				errorProviderWar.SetError(tbFacultyName, "Tên khoa không được để trống!");
				return false;
			}
			else
			{
				foreach (var item in arr)
				{
					if (string.IsNullOrEmpty(item))
					{
						errorProviderWar.SetError(tbFacultyName, "Tên khoa không được chứa\nnhiều dấu khoảng trắng!");
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

		public void FrmManageFaculty_Load(object sender, EventArgs e)
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
			tbFacultyID.Enabled = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			tbFacultyID.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string facultyID = tbFacultyID.Text.Trim();
			if (!IsValidFaculty())
				return;

			if (string.IsNullOrEmpty(facultyID) || rowIndex < 0)
			{
				MsgBox.ShowMessage("Vui lòng chọn khoa cần xóa!", "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}

			if (MsgBox.ShowMessage("Xác nhận xóa!", "Amazing Quiz Application",
			   MessageBoxButtons.YesNo, MsgBox.MessageIcon.ExclamationTriangle) == DialogResult.Yes)
			{
				try
				{
					if (FacultyBLL.Instance.DeleteFaculty(facultyID))
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
			FacultyBLL.Instance.SearchFaculty(aDgvdata, keyword);
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
				FacultyBLL.Instance.SearchFaculty(aDgvdata, "");
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
				tbSearch.Text = "Nhập tên khoa/Mã khoa ...";
			}
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			isFunc = true;
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
					AddFaculty();
				else
					UpdateFaculty();
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