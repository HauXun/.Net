using BusinessLogicLayer;
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
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }

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
			SubjectBLL.Instance.GetAllSubject(cbSubject);
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
			if (isMockTest == false)
				lbInform.Text = $"Chào {Account.FullName}! Hãy lựa chọn môn thi của mình để bắt đầu luyện tập ngay nào! 🙇‍♂️🙇‍♂️🙇‍♂️";
			else
				lbInform.Text = $"Chào {Account.FullName}! Hãy lựa chọn môn thi của mình để bắt đầu bài thi ngay nào! 🙇‍♂️🙇‍♂️🙇‍♂️";
		}

		private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
		{
			string subjectID = cbSubject.SelectedValue.ToString().Trim();
		}

		private void btnStartQuiz_Click(object sender, EventArgs e)
		{
			//if (tbQuizTime.Enabled)
			//{
			//	if (!IsValidComboBoxControl())
			//		return;
			//}
			//FrmQuiz frm = new FrmQuiz(Account, cbSubject.SelectedValue, cbQuestionCount.SelectedItem, tbQuizTime.Text);
			//this.Hide();
			//frm.ShowDialog();
			//this.Show();
		}

		#endregion
	}
}
