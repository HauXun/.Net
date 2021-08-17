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
	public partial class FrmManageCourse : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private bool isEnable = false;
		private int rowIndex = 0;

		public FrmManageCourse()
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
			FacultyBLL.Instance.GetAllFaculty(cbFaculty);
			RoleBLL.Instance.GetAllTrainingRole(cbTrainingRole);
			CourseBLL.Instance.GetAllCourse(aDgvdata);
			if (aDgvdata.Rows.Count > 0)
				DetailData(0);
		}

		private CourseOrder GetCourseOrderInfo()
		{
			CourseOrder course = new CourseOrder();
			course.CourseID = tbCourseID.Text.Trim();
			course.FacultyID = cbFaculty.SelectedValue.ToString();
			course.TrainingID = cbTrainingRole.SelectedValue.ToString();
			course.Description = tbDescription.Text.Trim();
			return course;
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = aDgvdata.Rows[rowIndex];
				tbCourseID.Text = row.Cells["CourseID"].Value.ToString();
				cbFaculty.SelectedValue = row.Cells["FacultyID"].Value;
				cbTrainingRole.SelectedValue = row.Cells["TrainingID"].Value;
				tbDescription.Text = row.Cells["Description"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
		}

		private void AddCourseOrder()
		{
			CourseOrder course = GetCourseOrderInfo();

			if (!IsValidCourseOrder())
			{
				isEnable = true;
				return;
			}

			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (CourseBLL.Instance.InsertCourse(course))
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

		private void UpdateCourseOrder()
		{
			CourseOrder course = GetCourseOrderInfo();

			if (!IsValidCourseOrder())
			{
				isEnable = true;
				return;
			}

			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (CourseBLL.Instance.UpdateCourse(course))
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
				if (control is ComboBox)
				{
					(control as ComboBox).SelectedIndex = -1;
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
			if (tbCourseID.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbCourseID, "Mã khoa không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbCourseID.Text.Trim()))
				{
					errorProviderWar.SetError(tbCourseID, "Mã khoa không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpaceCharacters(tbCourseID.Text.Trim()))
					{
						errorProviderWar.SetError(tbCourseID, "Mã khoa không được chứa khoảng trắng!");
						return false;
					}

					if (IsSpecialCharacters(tbCourseID.Text.Trim()))
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

		private void FrmManageTrainingProg_Load(object sender, EventArgs e)
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
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string subjectID = tbCourseID.Text.Trim();
			if (!IsValidCourseOrder())
				return;

			if (string.IsNullOrEmpty(subjectID) || rowIndex < 0)
			{
				MessageBox.Show("Vui lòng chọn khóa học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					if (CourseBLL.Instance.DeleteCourse(subjectID))
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
			aDgvdata.ClearFilter();
			aDgvdata_FilterStringChanged(sender, e);
		}

		private void aDgvdata_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			aDgvdata["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
		}

		private void aDgvdata_RowEnter(object sender, DataGridViewCellEventArgs e)
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
				tbSearch.Text = "Nhập từ khóa ...";
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
			try
			{
				if (isAddnew)
					AddCourseOrder();
				else
					UpdateCourseOrder();
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
