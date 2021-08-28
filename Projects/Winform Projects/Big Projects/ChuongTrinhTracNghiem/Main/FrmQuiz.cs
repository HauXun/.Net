using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmQuiz : Form
	{
		private string selectedIndex = "1";
		private int remainTime = 0;

		private UserAccount account;
		private Exam exam;
		private DataTable data;

		public UserAccount Account { get => account; set => account = value; }
		public Exam Exam { get => exam; set => exam = value; }
		public DataTable Data { get => data; set => data = value; }


		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		public FrmQuiz(UserAccount account, Exam exam)
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			Account = account;
			Exam = exam;
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

		private void ShowQuestion(int questionID)
		{
			Question question = QuestionBLL.Instance.GetQuestionByID(questionID);
			rtbQuestionContent.Text = question.QContent;
			rbAnswerA.Text = $"A. {question.OptionA}";
			rbAnswerB.Text = $"B. {question.OptionB}";
			rbAnswerC.Text = $"C. {question.OptionC}";
			rbAnswerD.Text = $"D. {question.OptionD}";
		}

		private void ShowDetailQuestion(object sender, EventArgs e)
		{
			int questionID = ((sender as Button).Tag as Question).QuestionID;
			lbNumberQuestion.Text = ((sender as Button).Tag as Question).QuestionIdx + ':';

			SaveCurrentSelected();

			rbAnswerA.Checked = rbAnswerB.Checked = rbAnswerC.Checked = rbAnswerD.Checked = false;
			selectedIndex = (sender as Button).Name;
			ShowQuestion(questionID);
			NavigationButton();
			LoadPrevSelectedOption();
		}

		private void SaveCurrentSelected()
		{
			if (int.TryParse(selectedIndex, out int idx) && idx >= 0 && idx < Exam.QCount)
			{
				Data.Rows[idx - 1]["SelectedOption"] = GetSelectedOption();
			}
		}

		private void LoadQuestion()
		{
			Data = QuestionBLL.Instance.GetQuestionByRequest(Exam.ExamID, Exam.SubjectID);
			Data.Columns.Add("SelectedOption");
			int i = 1;
			foreach (DataRow row in Data.Rows)
			{
				Question question = new Question(row);
				question.QuestionIdx = row["QuestionIdx"].ToString();
				Button button = new Button()
				{
					Width = 38,
					Height = 38,
					Name = i.ToString(),
					Text = $"C{i++}",
					TextAlign = ContentAlignment.MiddleCenter,
					Font = new Font("Arial", 6.5F, FontStyle.Regular),
					Tag = question
				};
				button.Click += Button_Click;
				fLPdata.Controls.Add(button);
			}
		}

		private void LoadPrevSelectedOption()
		{
			string prevSelected = Data.Rows[int.Parse(selectedIndex) - 1]["SelectedOption"].ToString();
			foreach (Control control in gbAnswer.Controls)
			{
				if (control is RadioButton && (control as RadioButton).Text.Equals(prevSelected))
				{
					(control as RadioButton).Checked = true;
					return;
				}
			}
		}

		private string GetSelectedOption()
		{
			foreach (Control control in gbAnswer.Controls)
			{
				if (control is RadioButton && (control as RadioButton).Checked)
					return (control as RadioButton).Text;
			}
			return string.Empty;
		}

		private void NavigationButton()
		{
			btnFirstQuestion.Enabled = btnPreviousQuestion.Enabled = (int.TryParse(selectedIndex, out int idx) && idx - 1 > 0);
			btnLastQuestion.Enabled = btnNextQuestion.Enabled = (int.TryParse(selectedIndex, out int idx2) && idx2 + 1 <= Exam.QCount);
		}

		private void FinishQuiz()
		{
			SaveCurrentSelected();

			byte correctAnswer = 0;
			float mark = 0;

			foreach (DataRow row in Data.Rows)
			{
				string answer = row["Answer"].ToString();
				string selectedOption = row["SelectedOption"].ToString();
				selectedOption = (selectedOption != string.Empty && selectedOption.Substring(3).Length > 0) ? selectedOption.Substring(3) : "";
				if (selectedOption.Equals(answer))
				{
					correctAnswer++;
				}
			}

			mark = (float)correctAnswer * 10 / Exam.QCount;

			FrmQuizResult frm = new FrmQuizResult(Data);
			this.Close();
			frm.ShowDialog();
		}	

		#endregion

		#region Events

		#endregion

		private void FrmQuiz_Load(object sender, EventArgs e)
		{
			LoadQuestion();
			btnFirstQuestion_Click(this, e);
			NavigationButton();
			pNavigation.Enabled = fLPdata.Controls.Count > 0;
			remainTime = Exam.ExamTime * 60;    //Convert to second
			timer.Start();
		}

		private void FrmQuiz_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer.Stop();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			remainTime--;
			string gio = ((remainTime / 3600 > 0 && remainTime / 3600 < 9) ? "00" : string.Empty) + ((remainTime / 3600 > 0) ? remainTime / 3600 : 0).ToString(); ;
			string phut = (remainTime / 60 < 9) ? "0" : string.Empty + (remainTime / 60).ToString();
			string giay = (remainTime % 60).ToString();

			cPBCountDownTime.Invoke((MethodInvoker)delegate
			{
				cPBCountDownTime.Text = $"{gio}:{phut}:{giay}";
			});

			if (remainTime <= 0)
				FinishQuiz();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			try
			{
				ShowDetailQuestion(sender, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại dữ liệu!" + ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void btnFirstQuestion_Click(object sender, EventArgs e)
		{
			if (fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals("1")).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnLastQuestion_Click(object sender, EventArgs e)
		{
			if (fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals(Exam.QCount.ToString())).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnPreviousQuestion_Click(object sender, EventArgs e)
		{
			if (int.TryParse(selectedIndex, out int idx) && idx - 1 > 0 && fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx - 1).ToString())).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnNextQuestion_Click(object sender, EventArgs e)
		{
			if (int.TryParse(selectedIndex, out int idx) && idx + 1 <= Exam.QCount && fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx + 1).ToString())).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắn chắn muốn nộp bài!", "Nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			FinishQuiz();
		}
	}
}
