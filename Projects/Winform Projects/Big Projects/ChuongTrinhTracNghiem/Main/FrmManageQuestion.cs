using BusinessLogicLayer;
using Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmManageQuestion : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private bool isEnable = false;
		private int rowIndex = 0;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }

		public FrmManageQuestion(UserAccount account)
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
			ExamBLL.Instance.GetAllExam(cbExamID);
			QuestionBLL.Instance.GetAllQuestion(aDgvdata);
			if (aDgvdata.Rows.Count > 0)
				DetailData(0);
		}

		private Question GetQuestionInfo()
		{
			Question question = new Question();
			int.TryParse(tbQuestionID.Text.Trim(), out int userId);
			question.QuestionID = userId;
			question.SubjectID = cbSubject.SelectedValue.ToString();
			question.ExamID = cbExamID.SelectedValue.ToString();
			question.QContent = tbContent.Text.Trim();
			question.OptionA = tbAnswerA.Text.Trim();
			question.OptionB = tbAnswerB.Text.Trim();
			question.OptionC = tbAnswerC.Text.Trim();
			question.OptionD = tbAnswerD.Text.Trim();
			question.Answer = tbAnswerCorrect.Text.Trim();
			return question;
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = aDgvdata.Rows[rowIndex];
				tbQuestionID.Text = row.Cells["QuestionID"].Value.ToString();
				cbSubject.SelectedValue = row.Cells["SubjectID"].Value;
				cbExamID.SelectedValue = row.Cells["ExamID"].Value;
				tbContent.Text = row.Cells["QContent"].Value.ToString();
				tbAnswerA.Text = row.Cells["OptionA"].Value.ToString();
				tbAnswerB.Text = row.Cells["OptionB"].Value.ToString();
				tbAnswerC.Text = row.Cells["OptionC"].Value.ToString();
				tbAnswerD.Text = row.Cells["OptionD"].Value.ToString();
				tbAnswerCorrect.Text = row.Cells["Answer"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClearControl();
			}
		}

		private void AddQuestion()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			Question question = GetQuestionInfo();
			question.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			question.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			if (!IsValidQuestion())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (QuestionBLL.Instance.InsertQuestion(question))
				{
					MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void UpdateQuestion()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				return;
			}

			Question question = GetQuestionInfo();
			question.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";


			if (!IsValidQuestion())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (QuestionBLL.Instance.UpdateQuestion(question))
				{
					MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
			errorProviderWar.SetError(tbQuestionID, "");
			errorProviderWar.SetError(tbContent, "");
			errorProviderWar.SetError(tbAnswerA, "");
			errorProviderWar.SetError(tbAnswerB, "");
			errorProviderWar.SetError(tbAnswerC, "");
			errorProviderWar.SetError(tbAnswerD, "");
			errorProviderWar.SetError(tbAnswerCorrect, "");
			errorProviderWar.SetError(cbSubject, "");
			errorProviderWar.SetError(cbExamID, "");
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
					errorProviderWar.SetError(cbSubject, "Vui lòng chọn môn thi");
					return false;
				}
			}

			if (cbExamID.Items.Count == 0)
			{
				errorProviderWar.SetError(cbExamID, "Không có mã môn cho bộ môn này!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbExamID.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbExamID, "Vui lòng chọn mã môn");
					return false;
				}
			}

			return true;
		}

		private bool IsValidQuestion()
		{
			ClearError();

			// Kiểm tra mã câu hỏi không được để trống
			if (tbQuestionID.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbQuestionID, "Mã câu hỏi không được để trống!");
				return false;
			}
			else
			{
				if (!IsDigit(tbQuestionID.Text.Trim()))
				{
					errorProviderWar.SetError(tbQuestionID, "Mã câu hỏi không được\nchứa ký tự khác ngoài số!");
					return false;
				}
			}

			// Kiểm tra nội dung câu hỏi không được để trống
			if (tbContent.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbContent, "Nội dung câu hỏi không được để trống!");
				return false;
			}
			else
			{
				if (tbAnswerA.Text.Trim().Equals(""))
				{
					errorProviderWar.SetError(tbAnswerA, "Nội dung câu trả lời không được để trống!");
					return false;
				}
				else
				{
					if (tbAnswerB.Text.Trim().Equals(""))
					{
						errorProviderWar.SetError(tbAnswerB, "Nội dung câu trả lời không được để trống!");
						return false;
					}
					else
					{
						if (tbAnswerC.Text.Trim().Equals(""))
						{
							errorProviderWar.SetError(tbAnswerC, "Nội dung câu trả lời không được để trống!");
							return false;
						}
						else
						{
							if (tbAnswerD.Text.Trim().Equals(""))
							{
								errorProviderWar.SetError(tbAnswerD, "Nội dung câu trả lời không được để trống!");
								return false;
							}
							else
							{
								if (tbAnswerCorrect.Text.Trim().Equals(""))
								{
									errorProviderWar.SetError(tbAnswerCorrect, "Nội dung đáp án không được để trống!");
									return false;
								}
							}
						}
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

		private void FrmManageUser_Load(object sender, EventArgs e)
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
			tbQuestionID.Text = QuestionBLL.Instance.GetIDMissing().ToString();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (!IsValidQuestion())
				return;
			if (!int.TryParse(tbQuestionID.Text, out int questionID))
			{
				MessageBox.Show("Vui lòng chọn câu hỏi dùng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					if (QuestionBLL.Instance.DeleteQuestion(questionID))
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

			QuestionBLL.Instance.SearchQuestion(aDgvdata, keyword);
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
					AddQuestion();
				else
					UpdateQuestion();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbExamID.Text = string.Empty;
			if (cbSubject.SelectedValue != null)
			{
				DataTable data = ExamBLL.Instance.GetExamByIDSubject(cbSubject.SelectedValue.ToString());
				cbExamID.DataSource = data;
			}
		}

		#endregion
	}
}
