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
using Bunifu.UI.WinForms;

namespace Main.Pages
{
	public partial class ManageExam : UserControl
	{
		private bool isAddnew = false;
		private bool isEnable = false;
		private bool isFunc = true;
		private int rowIndex = 0;
		private int questionCurrentCount = 0;

		private UserAccount account;
		public Action CancleAction;

		public UserAccount Account { get => account; set => account = value; }

		public ManageExam()
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
			this.lbCheckStatus.TabStop = false;
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
				SubjectBLL.Instance.GetAllSubject(cbSubject);
				TestFormBLL.Instance.GetAllTestForm(cbTestFormID);
				RoleBLL.Instance.GetAllRoleExam(cbExamRole);
				ExamBLL.Instance.GetAllExam(aDgvdata);
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

		private Exam GetExamInfo()
		{
			try
			{
				Exam exam = new Exam();
				exam.ExamID = tbExamID.Text.Trim();
				exam.SubjectID = cbSubject.SelectedValue.ToString();
				if (cbTestFormID.SelectedIndex == 0 || cbTestFormID.SelectedIndex == -1)
				{
					exam.TestFormID = null;
					exam.PercentMark = null;
				}
				else
				{
					exam.TestFormID = cbTestFormID.SelectedValue.ToString();
					exam.PercentMark = (byte)nudPercentMark.Value;
				}
				exam.ExamRole = cbExamRole.SelectedValue.ToString();
				exam.ExamTime = (byte)nudExamTime.Value;
				exam.QCount = (ushort)nudQCount.Value;
				exam.QuizTimes = (byte)nudQuizTimes.Value;
				exam.Status = ckbStatus.Checked;
				return exam;
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
					tbExamID.Text = row.Cells["ExamID"].Value.ToString();
					cbSubject.SelectedValue = row.Cells["SubjectID"].Value;
					if (string.IsNullOrEmpty(row.Cells["TestFormID"].Value.ToString()))
						cbTestFormID.SelectedIndex = 0;
					else
						cbTestFormID.SelectedValue = row.Cells["TestFormID"].Value;
					ushort.TryParse(row.Cells["PercentMark"].Value.ToString(), out ushort percent);
					nudPercentMark.Value = percent;
					cbExamRole.SelectedValue = row.Cells["ExamRole"].Value;
					nudExamTime.Value = ushort.Parse(row.Cells["ExamTime"].Value.ToString());
					nudQuizTimes.Value = ushort.Parse(row.Cells["QuizTimes"].Value.ToString());
					nudQCount.Value = ushort.Parse(row.Cells["QCount"].Value.ToString());
					questionCurrentCount = ushort.Parse(row.Cells["QCurrentCount"].Value.ToString());
					ckbStatus.Checked = (bool)row.Cells["Status"].Value;
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				ClearControl();
			}
		}

		private void AddExam()
		{
			if (!IsValidExam())
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

			Exam exam = GetExamInfo();
			exam.CreatedBy = $"{Account.UserRole} - {Account.FullName}";
			exam.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (ExamBLL.Instance.InsertExam(exam))
				{
					MsgBox.ShowMessage("Thêm thành công!", "Amazing Quiz Application",
				   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					isFunc = false;
					ExamBLL.Instance.GetAllExam(aDgvdata);
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

		private void UpdateExam()
		{
			if (!IsValidExam())
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

			Exam exam = GetExamInfo();
			exam.ModifiedBy = $"{Account.UserRole} - {Account.FullName}";

			try
			{
				if (ExamBLL.Instance.UpdateExam(exam))
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

		private void EnableMark(bool isEnable = true)
		{
			gbMark.Enabled = isEnable;
		}

		private void EnablePrimaryKey(bool isEnable = true)
		{
			tbExamID.Enabled = isEnable;
			cbSubject.Enabled = isEnable;
		}

		private void ClearControl()
		{
			foreach (Control control in pnlInfo1.Controls)
			{
				if (control is BunifuDropdown)
				{
					(control as BunifuDropdown).SelectedIndex = -1;
				}
			}
			tbExamID.Text = string.Empty;
			foreach (Control control in pnlInfo2.Controls)
			{
				if (control is Guna2NumericUpDown)
				{
					(control as Guna2NumericUpDown).Value = 1;
				}
			}
			nudPercentMark.Value = 0;
			cbTestFormID.SelectedIndex = -1;
			ckbStatus.Checked = false;
			lbCheckStatus.Text = "Đóng thi";
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbExamID, "");
			errorProviderWar.SetError(cbSubject, "");
			errorProviderWar.SetError(cbTestFormID, "");
			errorProviderWar.SetError(nudPercentMark, "");
			errorProviderWar.SetError(cbExamRole, "");
			errorProviderWar.SetError(nudExamTime, "");
			errorProviderWar.SetError(nudQCount, "");
			errorProviderWar.SetError(nudQuizTimes, "");
		}

		private bool IsValidComboBoxControl()
		{
			ClearError();

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

			if (!cbExamRole.SelectedValue.ToString().Equals("mock-test"))
			{
				if (cbTestFormID.Items.Count == 0)
				{
					errorProviderWar.SetError(cbTestFormID, "Không có hình thức đề thi!\nVui lòng bổ sung");
					return false;
				}
				else
				{
					if (cbTestFormID.SelectedIndex == -1)
					{
						errorProviderWar.SetError(cbTestFormID, "Vui lòng chọn hình thức đề thi!");
						return false;
					}
				}
			}

			return true;
		}

		private bool IsValidExam()
		{
			ClearError();

			// Kiểm tra mã đề thi không được để trống
			if (string.IsNullOrEmpty(tbExamID.Text))
			{
				errorProviderWar.SetError(tbExamID, "Mã đề thi không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbExamID.Text))
				{
					errorProviderWar.SetError(tbExamID, "Mã đề thi không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpecialCharacters(tbExamID.Text))
					{
						errorProviderWar.SetError(tbExamID, "Mã đề thi không được chứa ký tự đặc biệt!");
						return false;
					}
					else if (IsSpaceCharacters(tbExamID.Text))
					{
						errorProviderWar.SetError(tbExamID, "Mã đề thi không được chứa khoảng trắng!");
						return false;
					}
				}
			}

			// Kiểm tra thời gian thi không được để trống
			if (string.IsNullOrEmpty(nudExamTime.Text))
			{
				errorProviderWar.SetError(nudExamTime, "Thời gian của đề thi\nkhông được để trống!");
				return false;
			}
			else if (nudExamTime.Value <= 0)
			{
				errorProviderWar.SetError(nudExamTime, "Thời gian của đề thi\nphải lớn hơn 0!");
				return false;
			}

			// Kiểm tra số lượng câu hỏi của đề thi không được để trống
			if (string.IsNullOrEmpty(nudQCount.Text))
			{
				errorProviderWar.SetError(nudQCount, "Số lượng câu hỏi của đề thi\nkhông được để trống!");
				return false;
			}
			else
			{
				if (nudQCount.Value <= 0)
				{
					errorProviderWar.SetError(nudQCount, "Số lượng câu hỏi của đề thi phải lớn hơn 0!");
					return false;
				}
				if (!isAddnew && nudQCount.Value < questionCurrentCount)
				{
					errorProviderWar.SetError(nudQCount, "Số lượng câu hỏi của đề thi\nphải lớn hơn mức câu hỏi hiện có!");
					return false;
				}
			}

			if (string.IsNullOrEmpty(nudQuizTimes.Text))
			{
				errorProviderWar.SetError(nudQuizTimes, "Số lần thi không được để trống!");
				return false;
			}
			else if (nudQuizTimes.Value <= 0)
			{
				errorProviderWar.SetError(nudQuizTimes, "Số lần thi phải lớn hơn 0!");
				return false;
			}

			if (cbTestFormID.SelectedIndex > 0)
			{
				if (string.IsNullOrEmpty(nudPercentMark.Text))
				{
					errorProviderWar.SetError(nudPercentMark, "Phần trăm điểm của đề thi\nkhông được để trống!");
					return false;
				}
				else if (nudPercentMark.Value.Equals(0))
				{
					errorProviderWar.SetError(nudPercentMark, "Phần trăm điểm của đề thi phải lớn hơn 0!");
					return false;
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
			tbExamID.Text = "";
		}

		#endregion

		#region Events

		public void FrmManageExam_Load(object sender, EventArgs e)
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
			EnablePrimaryKey(true);
			ClearControl();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			//isAddnew = false;
			isFunc = false;
			VisibleButton(true);
			EnableControl(true);
			EnablePrimaryKey(false);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			string examID = tbExamID.Text;
			string subjectID = cbSubject.SelectedValue.ToString();
			if (!IsValidExam())
				return;

			if ((string.IsNullOrEmpty(examID) && string.IsNullOrEmpty(subjectID)) || rowIndex < 0)
			{
				MsgBox.ShowMessage("Vui lòng chọn đề thi cần xóa!", "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}

			if (MsgBox.ShowMessage("Xác nhận xóa!", "Amazing Quiz Application",
				  MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
			{
				try
				{
					if (ExamBLL.Instance.DeleteExam(examID, subjectID))
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
					ExamBLL.Instance.SearchExam(aDgvdata, "");
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
					AddExam();
				else
					UpdateExam();
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
			(sender as FontAwesome.Sharp.IconButton).GotFocus += ManageExam_GotFocus;
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as ADGV.AdvancedDataGridView).GotFocus += ManageExam_GotFocus;
		}

		private void ManageExam_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void cbTestFormID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbTestFormID.SelectedIndex != -1)
			{
				if (cbTestFormID.SelectedIndex != 0)
				{
					lbPercentMark.Enabled = nudPercentMark.Enabled = true;
				}
				else
				{
					lbPercentMark.Enabled = nudPercentMark.Enabled = false;
					nudPercentMark.Value = 0;
				}
			}
		}

		private void ckbStatus_CheckedChanged(object sender, EventArgs e)
		{
			lbCheckStatus.Text = ckbStatus.Checked == true ? "Mở thi" : "Đóng thi";
		}

		private void cbExamRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isFunc && cbExamRole.SelectedValue != null)
			{
				if (cbExamRole.SelectedValue.ToString().Equals("mock-test"))
				{
					EnableMark(false);
				}
				else
				{
					EnableMark();
				}
				cbTestFormID.SelectedIndex = -1;
			}
		}

		private void lbCheckStatus_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			ckbStatus.Checked = !ckbStatus.Checked;
		}

		private void lbCheckStatus_MouseEnter(object sender, EventArgs e)
		{
			lbCheckStatus.LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void lbCheckStatus_MouseLeave(object sender, EventArgs e)
		{
			lbCheckStatus.LinkBehavior = LinkBehavior.NeverUnderline;
		}

		private void tbSearch_IconRightClick(object sender, EventArgs e)
		{
			try
			{
				string keyword = tbSearch.Text;
				if (keyword.Equals("Nhập từ khóa ..."))
					keyword = string.Empty;

				ExamBLL.Instance.SearchExam(aDgvdata, keyword);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void ManageExam_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
