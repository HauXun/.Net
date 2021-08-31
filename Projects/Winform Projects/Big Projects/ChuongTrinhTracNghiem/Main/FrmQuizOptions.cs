﻿using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmQuizOptions : Form
	{
		public bool isMockTest = false;
		private string test;
		private string subjectID;

		Exam exam;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public Exam Exam { get => exam; set => exam = value; }

		public FrmQuizOptions(UserAccount account)
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

		#region Methods

		private void LoadData()
		{
			SubjectBLL.Instance.GetSubjectFromEduProg(cbSubject, Account.UserID);
			test = (isMockTest == true) ? "đề thi thử" : "đề thi";
		}

		private bool IsValidComboBoxControl()
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

		private void FrmQuizOptions_Load(object sender, EventArgs e)
		{
			LoadData();
			IsValidComboBoxControl();
			if (isMockTest == true)
				lbInform.Text = $"Chào {Account.FullName}! Hãy lựa chọn môn thi của mình để bắt đầu luyện tập ngay nào! 🙇‍♂️🙇‍♂️🙇‍♂️";
			else
				lbInform.Text = $"Chào {Account.FullName}! Hãy lựa chọn môn thi của mình để bắt đầu bài thi ngay nào! 🙇‍♂️🙇‍♂️🙇‍♂️";
		}

		private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
		{
			subjectID = cbSubject.SelectedValue.ToString();
			try
			{
				Exam = ExamBLL.Instance.GetExamByRequest(subjectID, isMockTest);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại dữ liệu!" + ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
			btnStartQuiz.Focus();
		}

		private void btnStartQuiz_Click(object sender, EventArgs e)
		{
			if (!IsValidComboBoxControl())
				return;

			if (Exam == null)
			{
				MessageBox.Show($"Hiện tại không có {test} cho môn {SubjectBLL.Instance.GetSubjectByID(subjectID).SubjectName}!. Thử môn khác xem nào! 🚀🚀🚀",
					"Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				return;
			}
			else if (Exam.QCurrentCount == 0)
			{
				MessageBox.Show($"Hiện tại không có câu hỏi cho {test} của môn {SubjectBLL.Instance.GetSubjectByID(subjectID).SubjectName}!. Thử lại khi khác nhé! 🚀🚀🚀",
					"Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				return;
			}	
			FrmQuiz frm = new FrmQuiz(Account, Exam);
			this.Hide();
			frm.FormClosing += Frm_FormClosing;
			frm.ShowDialog();
		}

		private void Frm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Dispose();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion
	}
}
