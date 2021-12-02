using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Main
{
	public partial class SelectExamForm : Form
	{
		public bool isMockTest = false;
		private string test;
		private string subjectID;

		private Exam exam;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public Exam Exam { get => exam; set => exam = value; }
		public Action HomeFunc;

		public SelectExamForm()
		{
			InitializeComponent();
			this.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));

		}

		#region Methods

		private void LoadData()
		{
			if (Account != null)
				SubjectBLL.Instance.GetSubjectFromEduProg(cbSubject, Account.UserID, isMockTest);
			test = (isMockTest == true) ? "đề thi thử" : "đề thi";
		}

		public bool IsValidComboBoxControl()
		{
			errorProviderWar.SetError(cbSubject, "");

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

			return true;
		}

		#endregion

		#region Events

		public void FrmSelectExam_Load(object sender, EventArgs e)
		{
			LoadData();
			if (isMockTest == true)
				lbInform.Text = $"Chào {Account.FullName}! Hãy lựa chọn môn thi của mình để bắt đầu luyện tập ngay nào! 🙇‍♂️🙇‍♂️🙇‍♂️";
			else
				lbInform.Text = $"Chào {Account.FullName}! Hãy lựa chọn môn thi của mình để bắt đầu bài thi ngay nào! 🙇‍♂️🙇‍♂️🙇‍♂️";
			cbSubject.SelectedIndex = -1;
		}

		private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cbSubject.SelectedValue != null)
					subjectID = cbSubject.SelectedValue.ToString();
				Exam = ExamBLL.Instance.GetExamByRequest(subjectID, isMockTest);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Có lỗi xảy ra! Vui lòng kiểm tra lại dữ liệu!" + ex.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
			btnStartQuiz.Focus();
		}

		private void btnStartQuiz_Click(object sender, EventArgs e)
		{
			if (!IsValidComboBoxControl())
				return;
			StringBuilder @string = new StringBuilder();
			if (Exam == null)
				@string.Append($"Tạm thời không có {test} cho môn {SubjectBLL.Instance.GetSubjectByID(subjectID).SubjectName}!. ");
			if (Exam.QCurrentCount <= 0)
				@string.Append($"Hiện tại không có câu hỏi cho {test} của môn {SubjectBLL.Instance.GetSubjectByID(subjectID).SubjectName}!. ");
			if (Exam.QuizTimes <= 0)
				@string.Append($"Số lần thi bị hạn chế!. ");
			if (Exam.Status == false)
				@string.Append($"Bài thi chưa được mở!. ");

			if (@string.Length > 0)
			{
				MsgBox.ShowMessage(@string.ToString() + "Thử lại khi khác nhé! 🚀🚀🚀", "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}

			Session.Exam = this.Exam;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SelectExamForm_Shown(object sender, EventArgs e)
		{
			this.Activate();
			btnThoat.Focus();
		}

		#endregion
	}
}
