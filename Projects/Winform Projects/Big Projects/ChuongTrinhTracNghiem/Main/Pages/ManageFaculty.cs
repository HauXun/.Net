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
	public partial class ManageFaculty : UserControl
	{
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;

		public Action CancleAction;

		public ManageFaculty()
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
					isFunc = false;
					FacultyBLL.Instance.GetAllFaculty(aDgvdata);
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

		private void NextAdditional()
		{
			isAddnew = isEnable = true;
			ClearControl();
		}

		#endregion

		#region Events

		public void FrmManageFaculty_Load(object sender, EventArgs e)
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
			tbFacultyID.Enabled = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			tbFacultyID.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
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
			   MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
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
					FacultyBLL.Instance.SearchFaculty(aDgvdata, "");
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
			(sender as FontAwesome.Sharp.IconButton).GotFocus += ManageFaculty_GotFocus;
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as ADGV.AdvancedDataGridView).GotFocus += ManageFaculty_GotFocus;
		}

		private void ManageFaculty_GotFocus(object sender, EventArgs e)
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
				FacultyBLL.Instance.SearchFaculty(aDgvdata, keyword);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void ManageFaculty_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
