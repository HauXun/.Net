using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class QuizTest : UserControl
	{
		private string selectedIndex = "1";

		private int correctAnswer = 0;
		private float mark = 0;

		private DataTable data;
		public CountDownTimer timer = new CountDownTimer();

		public Exam Exam;
		public UserAccount Account;
		public DataTable Data { get => data; set => data = value; }

		public QuizTest()
		{
			InitializeComponent();
			RoundedControls();
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
			btnReset.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 5, 5));
			btnEnd.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnEnd.Width, btnEnd.Height, 5, 5));
			btnNextQuestion.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnNextQuestion.Width, btnNextQuestion.Height, 5, 5));
			btnFirstQuestion.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnFirstQuestion.Width, btnFirstQuestion.Height, 5, 5));
			btnLastQuestion.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnLastQuestion.Width, btnLastQuestion.Height, 5, 5));
			btnPreviousQuestion.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnPreviousQuestion.Width, btnPreviousQuestion.Height, 5, 5));
			btnNextQuestion.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnNextQuestion.Width, btnNextQuestion.Height, 5, 5));
			btnFlags.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnFlags.Width, btnFlags.Height, 5, 5));
		}

		#endregion

		#region Methods

		private void LoadData(EventArgs e)
		{
			try
			{
				fLPdata.Controls.Clear();
				LoadQuestion();
				btnFirstQuestion_Click(this, e);
				NavigationButton();
				pNavigation.Enabled = fLPdata.Controls.Count > 0;
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

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
			lbNumberQuestion.Text = ((sender as Button).Tag as Question).QuestionIdx;

			SaveCurrentSelected();
			ClearChecked();
			selectedIndex = (sender as Button).Name;
			ShowQuestion(questionID);
			NavigationButton();
			LoadPrevSelectedOption();
		}

		private void SaveCurrentSelected()
		{
			if (int.TryParse(selectedIndex, out int idx) && idx > 0 && idx <= Exam.QCurrentCount)
			{
				string answer = GetSelectedOption();
				Data.Rows[idx - 1]["SelectedOption"] = answer;

				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx).ToString())).FirstOrDefault();
				if (!button.CausesValidation)
				{
					button.Image = null;
					button.TextImageRelation = TextImageRelation.Overlay;
					button.BackColor = Color.White;
					button.Font = new Font("Verdana", 9, FontStyle.Regular);
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
			if (Data.Rows.Count > 0)
			{
				Data.Columns.Add("SelectedOption");
				int i = 1;
				foreach (DataRow row in Data.Rows)
				{
					Question question = new Question(row);
					question.QuestionIdx = row["QuestionIdx"].ToString();
					Button button = new Button()
					{
						Width = 50,
						Height = 50,
						Name = i.ToString(),
						Text = $"Câu {i++}",
						TextAlign = ContentAlignment.MiddleCenter,
						TextImageRelation = TextImageRelation.Overlay,
						Font = new Font("Verdana", 9, FontStyle.Regular),
						Tag = question,
						BackColor = Color.White,
						FlatStyle = FlatStyle.Standard,
						CausesValidation = false
					};
					button.FlatAppearance.BorderSize = 1;
					button.FlatAppearance.BorderColor = Color.Blue;
					button.Click += Button_Click;
					button.Enter += btnPreviousQuestion_Enter;
					fLPdata.Controls.Add(button);
				}
			}
		}

		private void LoadPrevSelectedOption()
		{
			string prevSelected = Data.Rows[int.Parse(selectedIndex) - 1]["SelectedOption"].ToString();
			foreach (Control control in pnlAnswer.Controls)
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
			foreach (Control control in pnlAnswer.Controls)
			{
				if (control is RadioButton && (control as RadioButton).Checked)
					return (control as RadioButton).Text;
			}
			return string.Empty;
		}

		public void ClearAnswerData()
		{
			foreach (DataRow row in Data.Rows)
			{
				row["SelectedOption"] = string.Empty;
			}
		}

		private void NavigationButton()
		{
			btnFirstQuestion.Enabled = btnPreviousQuestion.Enabled = (int.TryParse(selectedIndex, out int idx) && idx - 1 > 0);
			btnLastQuestion.Enabled = btnNextQuestion.Enabled = (int.TryParse(selectedIndex, out idx) && idx + 1 <= Exam.QCurrentCount);
		}

		private void FinishQuiz()
		{
			timer.Stop();
			if (Exam != null && Data != null)
			{
				SaveCurrentSelected();
				ClearChecked();
				SavePoint();
				SaveTestHistory();

				Session.Data = this.Data;
			}
			else
			{
				MsgBox.ShowMessage("Xung đột dữ liệu, không thể kết thúc!", "Amazing Quiz Application", 
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void SavePoint()
		{
			correctAnswer = 0;
			mark = 0;
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

			mark = (float)correctAnswer * 10 / Exam.QCurrentCount;
		}

		private void SaveTestHistory()
		{
			try
			{
				Entities.TestHistory history = new Entities.TestHistory()
				{
					ExamID = Exam.ExamID,
					SubjectID = Exam.SubjectID,
					UserID = Account.UserID,
					SemesterID = SubjectBLL.Instance.GetSubjectByID(Exam.SubjectID).SemesterID,
					CorrectAnswer = correctAnswer,
					TotalQuestion = Exam.QCurrentCount,
					Mark = mark,
					CreatedBy = Account.FullName
				};

				TestHistoryBLL.Instance.SaveTestHistory(history);
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage(e.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		public void ClearChecked()
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
				FinishQuiz();
				Session.Submit?.Invoke();
			};
			timer.StepMs = 77;
		}

		#endregion

		#region Events

		public void FrmQuiz_Load(object sender, EventArgs e)
		{
			if (Exam != null)
			{
				timer = new CountDownTimer();
				selectedIndex = "1";
				LoadData(e);
				CountDownTimer();
			}
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			try
			{
				ShowDetailQuestion(sender, e);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Có lỗi xảy ra! Vui lòng kiểm tra lại dữ liệu!" + ex.Message,
					"Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void btnFirstQuestion_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals("1")).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnLastQuestion_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals(Exam.QCurrentCount.ToString())).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnPreviousQuestion_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (int.TryParse(selectedIndex, out int idx) && idx - 1 > 0 && fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx - 1).ToString())).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnNextQuestion_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (int.TryParse(selectedIndex, out int idx) && idx + 1 <= Exam.QCurrentCount && fLPdata.Controls.Count > 0)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx + 1).ToString())).FirstOrDefault();
				Button_Click(button, e);
			}
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (MsgBox.ShowMessage("Bạn có chắn chắn muốn nộp bài!", "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.No)
			{
				Session.Data = null;
				Session.AntiPopup?.Invoke(true);
				return;
			}

			FinishQuiz();
		}

		private void lLuncheck_MouseEnter(object sender, EventArgs e)
		{
			lLuncheck.LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void lLuncheck_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			ClearChecked();
			SaveCurrentSelected();
		}

		private void lLuncheck_MouseLeave(object sender, EventArgs e)
		{
			lLuncheck.LinkBehavior = LinkBehavior.NeverUnderline;
		}

		private void btnFlags_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (int.TryParse(selectedIndex, out int idx) && idx > 0 && idx <= Exam.QCurrentCount)
			{
				Button button = fLPdata.Controls.Cast<Button>().Where(x => x.Name.Equals((idx).ToString())).FirstOrDefault();

				if (!button.CausesValidation)
				{
					button.Image = new Bitmap(Properties.Resources.flags, new Size(15, 15));
					button.TextImageRelation = TextImageRelation.ImageAboveText;
					button.BackColor = Color.MistyRose;
					button.Font = new Font("Verdana", 7, FontStyle.Regular);
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

		private void btnReset_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (Exam != null && Data != null)
			{
				if (MsgBox.ShowMessage("Bạn có chắn chắn muốn làm lại bài thi không? Đáp án trước đó sẽ được hủy!", "Amazing Quiz Application",
					MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
				{
					ClearAnswerData();
					ClearChecked();
					LoadData(e);
				}
				Session.AntiPopup?.Invoke(true);
			}
			else
			{
				MsgBox.ShowMessage("Xung đột dữ liệu, không thể đặt lại!", "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void btnPreviousQuestion_Enter(object sender, EventArgs e)
		{
			if (sender is FontAwesome.Sharp.IconButton)
				(sender as FontAwesome.Sharp.IconButton).GotFocus += QuizTest_GotFocus;
			else
				(sender as Button).GotFocus += QuizTest_GotFocus;
		}

		private void QuizTest_GotFocus(object sender, EventArgs e)
		{
			lbNoiDungCauHoi.Focus();
		}

		private void QuizTest_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
