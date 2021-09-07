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

		private int correctAnswer = 0;
		private float mark = 0;

		private UserAccount account;
		private Exam exam;
		private DataTable data;
		CountDownTimer timer = new CountDownTimer();

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
			ClearChecked();
			selectedIndex = (sender as Button).Name;
			ShowQuestion(questionID);
			NavigationButton();
			LoadPrevSelectedOption();
		}

		private void SaveCurrentSelected()
		{
			if (int.TryParse(selectedIndex, out int idx) && idx > 0 && idx <= Exam.QCount)
			{
				string answer = GetSelectedOption();
				Data.Rows[idx - 1]["SelectedOption"] = answer;

				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx).ToString())).FirstOrDefault();
				if (!button.CausesValidation)
				{
					button.Image = null;
					button.TextImageRelation = TextImageRelation.Overlay;
					button.BackColor = Color.White;
					button.Font = new Font("Arial", 9, FontStyle.Regular);
					button.FlatAppearance.BorderSize = 1;
					if (answer.Equals(string.Empty))
					{
						button.FlatStyle = FlatStyle.Standard;
						button.FlatAppearance.BorderColor = Color.Blue;
					}
					else
					{
						button.FlatStyle = FlatStyle.Flat;
						button.FlatAppearance.BorderColor = Color.Lime;
					}
				}
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
					Width = 47,
					Height = 47,
					Name = i.ToString(),
					Text = $"Câu {i++}",
					TextAlign = ContentAlignment.MiddleCenter,
					Font = new Font("Arial", 9, FontStyle.Regular),
					Tag = question,
					CausesValidation = false
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

		private void ClearAnswerData()
		{
			foreach (DataRow row in Data.Rows)
			{
				row["SelectedOption"] = string.Empty;
			}
		}

		private void NavigationButton()
		{
			btnFirstQuestion.Enabled = btnPreviousQuestion.Enabled = (int.TryParse(selectedIndex, out int idx) && idx - 1 > 0);
			btnLastQuestion.Enabled = btnNextQuestion.Enabled = (int.TryParse(selectedIndex, out idx) && idx + 1 <= Exam.QCount);
		}

		private void FinishQuiz()
		{
			timer.Stop();
			SaveCurrentSelected();
			SavePoint();
			SaveTestHistory();

			FrmQuizResult frm = new FrmQuizResult(Data, Exam, (ushort)correctAnswer);
			frm.cPBCountDownTime.Text = (!timer.MustStop) ? this.cPBCountDownTime.Text : "Finished";
			this.Hide();
			frm.FormClosing += Frm_FormClosing;
			frm.ShowDialog();
		}

		private void SavePoint()
		{
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
		}

		private void SaveTestHistory()
		{
			TestHistory history = new TestHistory()
			{
				ExamID = Exam.ExamID,
				SubjectID = Exam.SubjectID,
				UserID = Account.UserID,
				SemesterID = byte.Parse(SubjectBLL.Instance.GetSubjectFromEduProg(Account.UserID).Rows[0]["SemesterID"].ToString()),
				CorrectAnswer = correctAnswer,
				TotalQuestion = Exam.QCount,
				Mark = mark,
				Success = (mark <= 2) ? false : true,
				CreatedBy = Account.FullName
			};

			try
			{
				TestHistoryBLL.Instance.SaveTestHistory(history);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ClearChecked()
		{
			rbAnswerA.Checked = rbAnswerB.Checked = rbAnswerC.Checked = rbAnswerD.Checked = false;
		}

		private void CountDownTimer()
		{
			timer.SetTime(Exam.ExamTime, 0);
			timer.Start();
			timer.TimeChanged += (() =>
			{
				cPBCountDownTime.Text = timer.TimeLeftMsStr;
				cPBCountDownTime.SuperscriptText = timer.TimeLeftMil;
			});
			timer.CountDownFinished += () =>
			{
				cPBCountDownTime.SuperscriptText = "Finish!";
				timer.Stop();
				FinishQuiz();
			};
			timer.StepMs = 77;
		}

		#endregion

		#region Events

		private void FrmQuiz_Load(object sender, EventArgs e)
		{
			LoadQuestion();
			btnFirstQuestion_Click(this, e);
			NavigationButton();
			pNavigation.Enabled = fLPdata.Controls.Count > 0;
			CountDownTimer();

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

		private void lLuncheck_MouseEnter(object sender, EventArgs e)
		{
			lLuncheck.LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void lLuncheck_Click(object sender, EventArgs e)
		{
			ClearChecked();
			SaveCurrentSelected();
		}

		private void lLuncheck_MouseLeave(object sender, EventArgs e)
		{
			lLuncheck.LinkBehavior = LinkBehavior.NeverUnderline;
		}

		private void lLflag_MouseEnter(object sender, EventArgs e)
		{
			lLflag.LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void lLflag_MouseLeave(object sender, EventArgs e)
		{
			lLflag.LinkBehavior = LinkBehavior.NeverUnderline;
			lLflag.BackColor = Color.White;
		}

		private void lLflag_Click(object sender, EventArgs e)
		{
			lLflag.BackColor = Color.Gainsboro;
			if (int.TryParse(selectedIndex, out int idx) && idx > 0 && idx <= Exam.QCount)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx).ToString())).FirstOrDefault();

				if (!button.CausesValidation)
				{
					button.Image = new Bitmap(Properties.Resources.flags, new Size(15, 15));
					button.TextImageRelation = TextImageRelation.ImageAboveText;
					button.BackColor = Color.MistyRose;
					button.Font = new Font("Arial", 7, FontStyle.Regular);
					button.FlatStyle = FlatStyle.Flat;
					button.FlatAppearance.BorderSize = 2;
					button.FlatAppearance.BorderColor = Color.Red;

					button.CausesValidation = true;
				}
				else
				{
					button.CausesValidation = false;
					SaveCurrentSelected();
				}
			}
		}

		private void Frm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Dispose();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			fLPdata.Controls.Clear();
			ClearAnswerData();
			ClearChecked();
			LoadQuestion();
			btnFirstQuestion_Click(this, e);
			NavigationButton();
			pNavigation.Enabled = fLPdata.Controls.Count > 0;
		}

		#endregion
	}
}
