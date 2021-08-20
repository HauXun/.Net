using BusinessLogicLayer;
using Entities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmManageFaculty : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;

		public FrmManageFaculty()
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
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(233, 30, 59), 90F))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

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
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
			return null;
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = aDgvdata.Rows[rowIndex];
				tbFacultyID.Text = row.Cells["FacultyID"].Value.ToString();
				tbFacultyName.Text = row.Cells["FacultyName"].Value.ToString();
				dtpFoundingDate.Text = row.Cells["FoundingDate"].FormattedValue.ToString();
				tbDescription.Text = row.Cells["Description"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
		}

		private void AddFaculty()
		{
			Faculty faculty = GetFacultyInfo();

			if (!IsValidFaculty())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (FacultyBLL.Instance.InsertFaculty(faculty))
				{
					MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu!\n" + e.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void UpdateFaculty()
		{
			Faculty faculty = GetFacultyInfo();

			if (!IsValidFaculty())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (FacultyBLL.Instance.UpdateFaculty(faculty))
				{
					MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!\n" + e.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
		}

		private void ClearControl()
		{
			foreach (Control control in gbControls.Controls)
			{
				if (control is TextBox)
				{
					control.Text = "";
				}
				if (control is DateTimePicker)
				{
					(control as DateTimePicker).Value = DateTime.Today;
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
			if (tbFacultyID.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbFacultyID, "Mã khoa không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbFacultyID.Text.Trim()))
				{
					errorProviderWar.SetError(tbFacultyID, "Mã khoa không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpaceCharacters(tbFacultyID.Text.Trim()))
					{
						errorProviderWar.SetError(tbFacultyID, "Mã khoa không được chứa khoảng trắng!");
						return false;
					}

					if (IsSpecialCharacters(tbFacultyID.Text.Trim()))
					{
						errorProviderWar.SetError(tbFacultyID, "Mã khoa không được chứa ký tự đặc biệt!");
						return false;
					}
				}
			}

			string[] arr = tbFacultyName.Text.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			// Kiểm tra tên khoa không được để trống
			if (tbFacultyName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbFacultyName, "Tên khoa không được để trống!");
				return false;
			}
			else
			{
				foreach (var item in arr)
				{
					if (IsSpecialCharacters(item))
					{
						errorProviderWar.SetError(tbFacultyName, "Tên khoa không được chứa ký tự đặc biệt!");
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

		private void FrmManageFaculty_Load(object sender, EventArgs e)
		{
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
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
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
				MessageBox.Show("Vui lòng chọn khoa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					if (FacultyBLL.Instance.DeleteFaculty(facultyID))
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
			if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
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
			VisibleButton(false);
			// Restore
			DetailData(rowIndex);
			EnableControl(false);
			tbFacultyID.Enabled = true;
			isFunc = true;
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
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		#endregion
	}
}
