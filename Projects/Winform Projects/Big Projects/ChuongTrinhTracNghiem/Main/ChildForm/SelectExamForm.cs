using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Drawing;
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
			RoundedControls();
		}

		//Bo tròn góc các Control
		#region Rounded Controls

		private void RoundedControls()
		{
			Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
			//Panel
			pnlChonMonThi.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlChonMonThi.Width, pnlChonMonThi.Height, 10, 10));
			//Panel Shadow
			pnlChonMonThiShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlChonMonThiShadow.Width, pnlChonMonThiShadow.Height, 10, 10));
		}

		#endregion


		#region Methods

		private void LoadData()
		{
			if (Account != null)
				SubjectBLL.Instance.GetSubjectFromEduProg(cbSubject, Account.UserID);
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

			if (Exam == null)
			{
				MsgBox.ShowMessage($"Hiện tại không có {test} cho môn {SubjectBLL.Instance.GetSubjectByID(subjectID).SubjectName}!. Thử môn khác xem nào! 🚀🚀🚀",
					"Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}
			else if (Exam.QCurrentCount == 0)
			{
				MsgBox.ShowMessage($"Hiện tại không có câu hỏi cho {test} của môn {SubjectBLL.Instance.GetSubjectByID(subjectID).SubjectName}!. Thử lại khi khác nhé! 🚀🚀🚀",
					"Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				return;
			}
			Session.Exam = this.Exam;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion
	}
}
