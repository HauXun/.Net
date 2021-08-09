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
	public partial class FrmManageExam : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private bool isEnable = false;
		private int rowIndex = 0;
		private int qCurrentCount = 0;

		private UserAccount account;
		private Subject subjectExam;

		public UserAccount Account { get => account; set => account = value; }
		public Subject SubjectExam { get => subjectExam; set => subjectExam = value; }

		public FrmManageExam(UserAccount account)
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
			SubjectBLL.Instance.GetAllSubject(cbSubject);
			SubjectBLL.Instance.GetAllSubject(cbFilter);
			ExamBLL.Instance.GetAllExam(dgvData);
			if (dgvData.Rows.Count > 0)
				DetailData(0);
		}

		private Exam GetExamInfo()
		{
			Exam exam = new Exam();
			exam.ExamID = tbExamID.Text.Trim();
			exam.SubjectID = cbSubject.SelectedValue.ToString();
			exam.ExamTime = (int)nudExamTime.Value;
			exam.QCount = (int)nudQCount.Value;
			return exam;
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = dgvData.Rows[rowIndex];
				tbExamID.Text = row.Cells["ExamID"].Value.ToString();
				nudExamTime.Value = int.Parse(row.Cells["ExamTime"].Value.ToString());
				nudQCount.Value = int.Parse(row.Cells["QCount"].Value.ToString());
				SubjectExam = SubjectBLL.Instance.GetSubjectByID(row.Cells["SubjectID"].Value.ToString());
				cbSubject.Text = SubjectExam.SubjectName.Trim();
				qCurrentCount = int.Parse(row.Cells["QCurrentCount"].Value.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
		}

		private void AddExam()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			Exam exam = GetExamInfo();
			exam.CreatedBy = $"{Account.RoleID} - {Account.FullName}";
			exam.ModifiedBy = $"{Account.RoleID} - {Account.FullName}";

			if (!IsValidExam())
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
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			Exam exam = GetExamInfo();
			exam.ModifiedBy = $"{Account.RoleID} - {Account.FullName}";

			if (!IsValidExam())
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
				if (control is TextBox || control is ComboBox)
				{
					control.Text = "";
				}
				if (control is NumericUpDown)
				{
					(control as NumericUpDown).Value = 0;
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
		}

		private bool IsValidComboBoxControl()
		{
			errorProviderWar.SetError(cbSubject, "");
			if (cbSubject.DataSource == null)
			{
				errorProviderWar.SetError(cbSubject, "Không có môn thi!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbSubject.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbSubject, "Vui lòng chọn môn thi");
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

			// Kiểm tra thời gian thi không được để trống
			if (nudQCount.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(nudQCount, "Thời gian của đề thi\nkhông được để trống!");
				return false;
			}
			else
			{
				if (nudQCount.Value.Equals(0))
				{
					errorProviderWar.SetError(nudQCount, "Thời gian của đề thi\nphải lớn hơn 0!");
					return false;
				}
				else if (nudQCount.Value < qCurrentCount)
				{
					errorProviderWar.SetError(nudQCount, "Số lượng câu hỏi của đề thi\nphải lớn hơn mức câu hỏi hiện có!");
					return false;
				}
			}

			// Kiểm tra số lượng câu hỏi của đề thi không được để trống
			if (nudExamTime.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(nudExamTime, "Số lượng câu hỏi của đề thi\nkhông được để trống!");
				return false;
			}
			else if (nudExamTime.Value.Equals(0))
			{
				errorProviderWar.SetError(nudExamTime, "Số lượng câu hỏi của đề thi phải lớn hơn 0!");
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
			VisibleButton(true);
			EnableControl(true);
			ClearControl();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			VisibleButton(true);
			EnableControl(true);
			tbExamID.Enabled = false;
			cbSubject.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string subjectID = tbExamID.Text.Trim();
			if (!IsValidExam())
				return;

			if (string.IsNullOrEmpty(subjectID) || rowIndex < 0)
			{
				MessageBox.Show("Vui lòng chọn đề thi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					if (ExamBLL.Instance.DeleteExam(subjectID))
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
			if (keyword.Equals("Nhập mã đề thi/Mã môn ..."))
				keyword = string.Empty;

			string roleFilter = "ALL";
			if (cbFilter.SelectedValue != null)
				roleFilter = cbFilter.SelectedValue.ToString();

			ExamBLL.Instance.SearchExam(dgvData, keyword, roleFilter);
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
				tbSearch.Text = "Nhập mã đề thi/Mã môn ...";
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
