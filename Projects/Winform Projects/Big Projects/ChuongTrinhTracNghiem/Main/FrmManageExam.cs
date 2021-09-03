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
	public partial class FrmManageExam : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;
		private int questionCurrentCount = 0;

		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }

		public FrmManageExam(UserAccount account)
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			Account = account;
		}

		public FrmManageExam()
		{

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

		protected override void WndProc(ref Message m)
		{
			const int WM_SYSCOMMAND = 0x0112;
			const int SC_MOVE = 0xF010;

			switch (m.Msg)
			{
				case WM_SYSCOMMAND:
					int command = m.WParam.ToInt32() & 0xfff0;
					if (command == SC_MOVE)
						return;
					break;
			}
			base.WndProc(ref m);
		}

		#region Methods

		private void LoadData()
		{
			try
			{
				RoleBLL.Instance.GetAllRoleExam(cbExamRole);
				SubjectBLL.Instance.GetAllSubject(cbSubject);
				ExamBLL.Instance.GetAllExam(aDgvdata);
				if (aDgvdata.Rows.Count > 0)
					DetailData(0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
		}

		private Exam GetExamInfo()
		{
			try
			{
				Exam exam = new Exam();
				exam.ExamID = tbExamID.Text.Trim();
				exam.SubjectID = cbSubject.SelectedValue.ToString();
				exam.ExamRole = cbExamRole.SelectedValue.ToString();
				exam.ExamTime = (int)nudExamTime.Value;
				exam.QCount = (int)nudQCount.Value;
				return exam;
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
				if (aDgvdata.Rows.Count > 0)
				{
					DataGridViewRow row = aDgvdata.Rows[rowIndex];
					tbExamID.Text = row.Cells["ExamID"].Value.ToString();
					cbSubject.SelectedValue = row.Cells["SubjectID"].Value;
					cbExamRole.SelectedValue = row.Cells["ExamRole"].Value;
					nudExamTime.Value = int.Parse(row.Cells["ExamTime"].Value.ToString());
					nudQCount.Value = int.Parse(row.Cells["QCount"].Value.ToString());
					questionCurrentCount = int.Parse(row.Cells["QCurrentCount"].Value.ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
		}

		private void AddExam()
		{
			if (!IsValidExam())
			{
				isEnable = true;
				return;
			}

			Exam exam = GetExamInfo();
			exam.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			exam.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (ExamBLL.Instance.InsertExam(exam))
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

		private void UpdateExam()
		{
			if (!IsValidExam())
			{
				isEnable = true;
				return;
			}

			Exam exam = GetExamInfo();
			exam.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (ExamBLL.Instance.UpdateExam(exam))
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
			foreach (Control control in gbControls.Controls)
			{
				control.Enabled = isEnable;
			}
		}

		private void ClearControl()
		{
			foreach (Control control in gbControls.Controls)
			{
				if (control is TextBox)
				{
					control.Text = "";
				}
				if (control is NumericUpDown)
				{
					(control as NumericUpDown).Value = 0;
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
			errorProviderWar.SetError(tbExamID, "");
			errorProviderWar.SetError(nudQCount, "");
			errorProviderWar.SetError(nudExamTime, "");
			errorProviderWar.SetError(cbSubject, "");
			errorProviderWar.SetError(cbExamRole, "");
		}

		private bool IsValidComboBoxControl()
		{
			ClearError();

			if (cbSubject.Items.Count == 0)
			{
				errorProviderWar.SetError(cbSubject, "Không có môn thi!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbSubject.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbSubject, "Vui lòng chọn môn thi!");
					return false;
				}
			}

			if (cbExamRole.Items.Count == 0)
			{
				errorProviderWar.SetError(cbExamRole, "Không có kiểu đề thi!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbExamRole.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbExamRole, "Vui lòng chọn kiểu đề thi!");
					return false;
				}
			}

			return true;
		}

		private bool IsValidExam()
		{
			ClearError();

			// Kiểm tra mã đề thi không được để trống
			if (tbExamID.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbExamID, "Mã đề thi không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbExamID.Text.Trim()))
				{
					errorProviderWar.SetError(tbExamID, "Mã đề thi không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpecialCharacters(tbExamID.Text.Trim()))
					{
						errorProviderWar.SetError(tbExamID, "Mã đề thi không được chứa ký tự đặc biệt!");
						return false;
					}
					else if (IsSpaceCharacters(tbExamID.Text.Trim()))
					{
						errorProviderWar.SetError(tbExamID, "Mã đề thi không được chứa khoảng trắng!");
						return false;
					}
				}
			}

			// Kiểm tra số lượng câu hỏi của đề thi không được để trống
			if (nudQCount.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(nudQCount, "Số lượng câu hỏi của đề thi\nkhông được để trống!");
				return false;
			}
			else
			{
				if (nudQCount.Value.Equals(0))
				{
					errorProviderWar.SetError(nudQCount, "Số lượng câu hỏi của đề thi phải lớn hơn 0!"); 
					return false;
				}
				else if (nudQCount.Value < questionCurrentCount)
				{
					errorProviderWar.SetError(nudQCount, "Số lượng câu hỏi của đề thi\nphải lớn hơn mức câu hỏi hiện có!");
					return false;
				}
			}

			// Kiểm tra thời gian thi không được để trống
			if (nudExamTime.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(nudExamTime, "Thời gian của đề thi\nkhông được để trống!");
				return false;
			}
			else if (nudExamTime.Value.Equals(0))
			{
				errorProviderWar.SetError(nudExamTime, "Thời gian của đề thi\nphải lớn hơn 0!");
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

		private void FrmManageExam_Load(object sender, EventArgs e)
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
			tbExamID.Enabled = false;
			cbSubject.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string examID = tbExamID.Text.Trim();
			string subjectID = cbSubject.SelectedValue.ToString().Trim();
			if (!IsValidExam())
				return;

			if ((string.IsNullOrEmpty(examID) && string.IsNullOrEmpty(subjectID)) || rowIndex < 0)
			{
				MessageBox.Show("Vui lòng chọn đề thi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					if (ExamBLL.Instance.DeleteExam(examID, subjectID))
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

			ExamBLL.Instance.SearchExam(aDgvdata, keyword);
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
					AddExam();
				else
					UpdateExam();
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
