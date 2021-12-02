using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Main.Pages
{
	public partial class ManageQuestion : UserControl
	{
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;
		private UserAccount account;
		private string[] answer = new string[4];
		string selectedPath = "";

		public UserAccount Account { get => account; set => account = value; }
		public Action CancleAction;

		public ManageQuestion()
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
			btnImportFiles.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnImportFiles.Width, btnImportFiles.Height, 6, 6));
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
				QuestionBLL.Instance.GetAllQuestion(aDgvdata);
				ExamBLL.Instance.GetAllExam(cbExamID);
				SubjectBLL.Instance.GetAllSubject(cbSubject);
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

		private Question GetQuestionInfo()
		{
			try
			{
				Question question = new Question();
				int.TryParse(tbQuestionID.Text.Trim(), out int questionID);
				question.QuestionID = questionID;
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
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				ClearControl();
			}
		}

		private void AddQuestion()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			if (!IsValidQuestion())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			Question question = GetQuestionInfo();
			question.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			question.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (QuestionBLL.Instance.InsertQuestion(question))
				{
					MsgBox.ShowMessage("Thêm thành công!", "Amazing Quiz Application",
				   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					isFunc = false;
					QuestionBLL.Instance.GetAllQuestion(aDgvdata);
					NextAdditional();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				isFunc = false;
				NextAdditional();
			}
		}

		private void UpdateQuestion()
		{
			if (!IsValidComboBoxControl())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			if (!IsValidQuestion())
			{
				isEnable = true;
				isFunc = false;
				return;
			}

			Question question = GetQuestionInfo();
			question.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (QuestionBLL.Instance.UpdateQuestion(question))
				{
					MsgBox.ShowMessage("Cập nhập thành công!", "Amazing Quiz Application",
				   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					LoadData();
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!" + e.Message, "Amazing Quiz Application",
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
				if (control is BunifuDropdown)
				{
					(control as BunifuDropdown).SelectedIndex = -1;
				}
			}
			tbAnswerCorrect.Text = "";
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

			// Kiểm tra nội dung câu hỏi không được để trống
			if (string.IsNullOrEmpty(tbContent.Text))
			{
				errorProviderWar.SetError(tbContent, "Nội dung câu hỏi không được để trống!");
				return false;
			}
			else
			{
				if (string.IsNullOrEmpty(tbAnswerA.Text))
				{
					errorProviderWar.SetError(tbAnswerA, "Nội dung câu trả lời không được để trống!");
					return false;
				}
				else
				{
					if (string.IsNullOrEmpty(tbAnswerB.Text))
					{
						errorProviderWar.SetError(tbAnswerB, "Nội dung câu trả lời không được để trống!");
						return false;
					}
					else
					{
						if (string.IsNullOrEmpty(tbAnswerC.Text))
						{
							errorProviderWar.SetError(tbAnswerC, "Nội dung câu trả lời không được để trống!");
							return false;
						}
						else
						{
							if (string.IsNullOrEmpty(tbAnswerD.Text))
							{
								errorProviderWar.SetError(tbAnswerD, "Nội dung câu trả lời không được để trống!");
								return false;
							}
							else
							{
								if (string.IsNullOrEmpty(tbAnswerCorrect.Text))
								{
									errorProviderWar.SetError(tbAnswerCorrect, "Nội dung đáp án không được để trống!");
									return false;
								}
								else
								{
									answer[0] = tbAnswerA.Text;
									answer[1] = tbAnswerB.Text;
									answer[2] = tbAnswerC.Text;
									answer[3] = tbAnswerD.Text;
									if (!answer.Contains(tbAnswerCorrect.Text))
									{
										errorProviderWar.SetError(tbAnswerCorrect, "Nội dung đáp án phải khớp với\n1 trong những câu trả lời!");
										return false;
									}
								}
							}
						}
					}
				}
			}

			return true;
		}

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
			tbAnswerCorrect.Text = "";
			tbQuestionID.Text = QuestionBLL.Instance.GetIDMissing().ToString();
		}

		private DataRowCollection ExcelAikenFormat(string path)
		{
			DataRowCollection dataRow = null;
			OleDbConnection MyConnection;
			DataTable dataTable;
			OleDbDataAdapter MyCommand;
			MyConnection = new OleDbConnection($"provider=Microsoft.Jet.OLEDB.4.0;Data Source='{path}'; Extended Properties = Excel 8.0");
			MyCommand = new OleDbDataAdapter("select * from [sheet1$]", MyConnection);
			MyCommand.TableMappings.Add("Table", "TestTable");
			dataTable = new DataTable();
			MyCommand.Fill(dataTable);
			dataRow = dataTable.Rows;
			return dataRow;
		}

		private void ReadExcel()
		{
			Thread thread = new Thread((ThreadStart)(() =>
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.InitialDirectory = @"C:\Users\Administrator\Documents";
				dialog.CheckFileExists = true;
				dialog.CheckPathExists = true;
				dialog.DefaultExt = "xls";
				dialog.Filter = "AikenQuiz Files(*.xls)|*.xls|AikenQuiz Files(*.xlsx)|*.xlsx";
				dialog.Title = "AikenQuiz Excel Import";
				dialog.FilterIndex = 0;
				dialog.RestoreDirectory = true;
				dialog.ReadOnlyChecked = true;
				dialog.ShowReadOnly = true;
				selectedPath = string.Empty;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					if (dialog.FileName != null)
					{
						selectedPath = dialog.FileName;
					}
				}
			}));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			if (!string.IsNullOrEmpty(selectedPath))
				CallAiken(selectedPath);
		}

		private void CallAiken(string path)
		{
			try
			{
				AikenFormat aikenFormat = new AikenFormat(ExcelAikenFormat(path));
				PushAikenQuestions(aikenFormat);
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage("Thao tác thất bại! " + e.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void PushAikenQuestions(AikenFormat aikenFormat)
		{
			string subjectID = aikenFormat.SubjectID;
			string examID = aikenFormat.ExamID;
			int qCount = aikenFormat.Questions.Count; ;
			for (int i = 0; i < qCount; i++)
			{
				if (i < aikenFormat.LimitPush)
				{
					int.TryParse(QuestionBLL.Instance.GetIDMissing().ToString(), out int questionID);
					aikenFormat.Questions[i].QuestionID = questionID;
					aikenFormat.Questions[i].SubjectID = subjectID;
					aikenFormat.Questions[i].ExamID = examID;
					aikenFormat.Questions[i].CreatedBy = $"{Account.UserRole} - {Account.FullName}";
					aikenFormat.Questions[i].ModifiedBy = $"{Account.UserRole} - {Account.FullName}";
					QuestionBLL.Instance.InsertQuestion(aikenFormat.Questions[i]);
				}
			}
			MsgBox.ShowMessage("Nạp dữ liệu câu hỏi hoàn tất. Mời bạn xem lại dữ liệu!", "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
			QuestionBLL.Instance.GetAllQuestion(aDgvdata);
		}

		#endregion

		#region Events

		public void FrmManageUser_Load(object sender, EventArgs e)
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
			tbQuestionID.Text = QuestionBLL.Instance.GetIDMissing().ToString();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (!IsValidQuestion())
				return;
			if (!int.TryParse(tbQuestionID.Text, out int questionID))
			{
				MsgBox.ShowMessage("Vui lòng chọn câu hỏi dùng cần xóa!", "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}
			if (MsgBox.ShowMessage("Xác nhận xóa!", "Amazing Quiz Application",
			   MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
			{
				try
				{
					if (QuestionBLL.Instance.DeleteQuestion(questionID))
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
			BindingSource source = new BindingSource() { DataSource = aDgvdata.DataSource, Sort = aDgvdata.SortString };
			aDgvdata.DataSource = source.DataSource;
		}

		private void aDgvdata_FilterStringChanged(object sender, EventArgs e)
		{
			BindingSource source = new BindingSource() { DataSource = aDgvdata.DataSource, Filter = aDgvdata.FilterString };
			aDgvdata.DataSource = source.DataSource;
		}

		private void btnClearFilter_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			try
			{
				if (!string.IsNullOrEmpty(tbSearch.Text))
					QuestionBLL.Instance.SearchQuestion(aDgvdata, "");
				aDgvdata.ClearFilter();
				aDgvdata_FilterStringChanged(sender, e);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void aDgvdata_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
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
			cbSubject.SelectedIndex = -1;
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
					AddQuestion();
				else
					UpdateQuestion();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
				return;
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isFunc && cbSubject.SelectedValue != null)
			{
				DataTable data = ExamBLL.Instance.GetExamByIDSubject(cbSubject.SelectedValue.ToString());
				if (data.Rows.Count > 0)
				{
					cbExamID.DisplayMember = "ExamID";
					cbExamID.ValueMember = "ExamID";
					cbExamID.DataSource = data;
				}
				else
				{
					cbExamID.DataSource = null;
				}
				cbExamID.SelectedIndex = -1;
			}
			else if (!isAddnew)
			{
				ExamBLL.Instance.GetAllExam(cbExamID);
			}
		}

		private void aDgvdata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 4;
				bScrollBar.Value = bScrollBar.Maximum;
			}
			catch { }
		}

		private void aDgvdata_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 4;
				bScrollBar.Value = bScrollBar.Maximum;
			}
			catch { }
		}

		private void bScrollBar_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
		{
			try
			{
				if (e.Value > 3)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - e.Value - 3].Index;
				else if (e.Value == 0)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1)].Index;
				else
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - 4].Index;
			}
			catch { }
		}

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += ManageQuestion_GotFocus;
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as ADGV.AdvancedDataGridView).GotFocus += ManageQuestion_GotFocus;
		}

		private void ManageQuestion_GotFocus(object sender, EventArgs e)
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

				QuestionBLL.Instance.SearchQuestion(aDgvdata, keyword);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void btnImportFiles_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			ReadExcel();
		}

		private void ManageQuestion_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
