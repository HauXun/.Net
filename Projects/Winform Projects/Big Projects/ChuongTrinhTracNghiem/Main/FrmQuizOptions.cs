using BusinessLogicLayer;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmQuizOptions : Form
	{
		public FrmQuizOptions()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
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
			errorProviderWar.SetError(cbQuestionCount, "");

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

			if (cbQuestionCount.DataSource == null)
			{
				errorProviderWar.SetError(cbQuestionCount, "Không rõ số lượng câu hỏi!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbQuestionCount.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbQuestionCount, "Vui lòng chọn số lượng câu hỏi");
					return false;
				}
			}

			return true;
		}

		#endregion

		#region Events

		private void cbQuestionCount_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbQuizTime.Text = cbQuestionCount.Text;
		}

		private void FrmQuizOptions_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnStartQuiz_Click(object sender, EventArgs e)
		{
			if (tbQuizTime.Enabled)
			{
				if (!IsValidComboBoxControl())
					return;
			}
			FrmQuiz frm = new FrmQuiz();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		#endregion
	}
}
