using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
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
			ExamBLL.Instance.GetAllExam(dgvData);
		}

		private Exam GetExamInfo()
		{
			Exam exam = new Exam();
			exam.ExamID = tbExamID.Text.Trim();
			exam.SubjectID = cbSubject.SelectedValue.ToString();
			exam.ExamTime = (int)nudExamTime.Value;
			exam.QCount = (int)nudQCount.Value;
			exam.QCurrentCount = (int)nudQCurrentCount.Value;
			return exam;
		}

		private void AddExam()
		{
			Exam exam = GetExamInfo();
			exam.CreatedBy = $"{Account.RoleID} - {Account.FullName}";
			exam.ModifiedBy = $"{Account.RoleID} - {Account.FullName}";
			if (!IsValidExam())
			{
				isEnable = true;
				return;
			}

			if (ExamBLL.Instance.InsertExam(exam))
			{
				MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				LoadData();
			}
			else
			{
				MessageBox.Show("Thêm không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void UpdateExam()
		{
			Exam exam = GetExamInfo();
			exam.ModifiedBy = $"{Account.RoleID} - {Account.FullName}";
			if (!IsValidExam())
			{
				isEnable = true;
				return;
			}

			if (ExamBLL.Instance.UpdateExam(exam))
			{
				MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				LoadData();
			}
			else
			{
				MessageBox.Show("Cập nhập không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = dgvData.Rows[rowIndex];
				tbExamID.Text = row.Cells["ExamID"].Value.ToString();
				nudExamTime.Value = int.Parse(row.Cells["ExamTime"].Value.ToString());
				nudQCount.Value = int.Parse(row.Cells["QCount"].Value.ToString());
				nudQCurrentCount.Value = int.Parse(row.Cells["QCurrentCount"].Value.ToString());
				SubjectExam = SubjectBLL.Instance.GetSubjectByID(row.Cells["SubjectID"].Value.ToString());
				cbSubject.Text = SubjectExam.SubjectName;
			}
			catch 
			{
				// MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				foreach (Control control in gbControls.Controls)
				{
					if (control is TextBox)
						control.Text = string.Empty;
					if (control is NumericUpDown)
						(control as NumericUpDown).Value = 0;
				}
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

		private bool IsValidExam()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbExamID, "");
			errorProviderWar.SetError(nudQCount, "");
			errorProviderWar.SetError(nudExamTime, "");
			errorProviderWar.SetError(nudQCurrentCount, "");

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

			// Kiểm tra số lượng câu hỏi của đề thi không được để trống
			if (nudExamTime.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(nudExamTime, "Số lượng câu hỏi của đề thi\nkhông được để trống!");
				return false;
			}

			// Kiểm tra số lượng câu hỏi hiện tại của đề thi không được để trống
			if (nudQCurrentCount.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(nudQCurrentCount, "Số lượng câu hỏi hiện tại của đề thi\nkhông được để trống!");
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
			isAddnew = true;
			VisibleButton(true);
			EnableControl(true);
		}

		private void FrmManageExam_Load(object sender, EventArgs e)
		{
			LoadData();
			EnableControl(false);
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			VisibleButton(true);
			EnableControl(true);
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
				if (ExamBLL.Instance.DeleteExam(subjectID))
				{
					MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
				else
				{
					MessageBox.Show("Xóa không thành công!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = tbSearch.Text.Trim();
			if (keyword.Equals("Nhập mã đề thi/Mã môn ..."))
				keyword = string.Empty;
			ExamBLL.Instance.SearchExam(dgvData, keyword);
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
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			isEnable = false;
			if (isAddnew)
				AddExam();
			else
				UpdateExam();
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		#endregion
	}
}
