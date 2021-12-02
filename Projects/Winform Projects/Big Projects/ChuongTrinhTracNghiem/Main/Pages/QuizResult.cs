using Entities;
using Main.Partial;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class QuizResult : UserControl
    {
        private ushort correctAnswer;
        private DataTable data;
        private Exam exam;
		private ToolTip toolTipUnchecked = new ToolTip()
		{
			AutomaticDelay = 0,
			AutoPopDelay = 10000,
			InitialDelay = 0,
			ReshowDelay = 0,
			ToolTipTitle = "Đáp án đúng",
			ToolTipIcon = ToolTipIcon.Error
		};
		private ToolTip toolTipChecked = new ToolTip()
		{
			AutomaticDelay = 0,
			AutoPopDelay = 10000,
			InitialDelay = 0,
			ReshowDelay = 0,
			ToolTipTitle = "Đáp án đúng",
			ToolTipIcon = ToolTipIcon.Info
		};
		private ToolTip toolTipIndeterminate = new ToolTip()
		{
			AutomaticDelay = 0,
			AutoPopDelay = 10000,
			InitialDelay = 0,
			ReshowDelay = 0,
			ToolTipTitle = "Đáp án đúng",
			ToolTipIcon = ToolTipIcon.Warning
		};

        public DataTable Data { get => data; set => data = value; }
        public Exam Exam { get => exam; set => exam = value; }

        public QuizResult()
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

        //Bo tròn các góc của Control
        #region Rounded Form
        private void RoundedControls()
        {
			//Panels
            fLPdata.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, fLPdata.Width, fLPdata.Height, 10, 10));
        }
		#endregion

		#region Methods

		private void LoadStateQuestion(CheckState check, ref ushort i, string answer)
		{
			Button button = new Button()
			{
				AutoSize = true,
				Width = 65,
				Height = 65,
				Text = $"Câu {i++}",
				TextImageRelation = TextImageRelation.TextAboveImage,
				Font = new Font("Verdana", 8, FontStyle.Regular),
				BackColor = Color.Transparent,
				FlatStyle = FlatStyle.Flat
			};

			button.FlatAppearance.BorderSize = 0;
			button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			button.FlatAppearance.MouseDownBackColor = button.FlatAppearance.MouseOverBackColor = Color.White;
			button.Enter += btnCheck_Enter;
			button.Click += QuizResult_Click;

			switch (check)
			{
				case CheckState.Unchecked:
					button.Image = new Bitmap(Properties.Resources.cancel, new Size(40, 40));
					toolTipUnchecked.ToolTipIcon = ToolTipIcon.Error;
					toolTipUnchecked.SetToolTip(button, answer);
					break;
				case CheckState.Checked:
					button.Image = new Bitmap(Properties.Resources._checked, new Size(40, 40));
					toolTipChecked.ToolTipIcon = ToolTipIcon.Info;
					toolTipChecked.SetToolTip(button, answer);
					break;
				case CheckState.Indeterminate:
					button.Image = new Bitmap(Properties.Resources.warning, new Size(40, 40));
					toolTipIndeterminate.ToolTipIcon = ToolTipIcon.Warning;
					toolTipIndeterminate.SetToolTip(button, answer);
					break;
			}

			fLPdata.Controls.Add(button);
		}

		private enum State
		{
			Check,
			Uncheck,
			Indeterminate
		}

		private void LoadStateResult(ushort value, ushort length, State state)
		{
			ushort vLength = (ushort)value.ToString().Length;

			switch (state)
			{
				case State.Uncheck:
					btnUncheck.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
					btnUncheck.Text = " ".PadRight(length - vLength > 0 ? length - vLength + 1 : 0) + $"{value} Câu";
					btnUncheck.Image = new Bitmap(Properties.Resources.cancel, new Size(25, 25));
					barUncheck.Value = value * 10 / Exam.QCurrentCount * 10;
					lbUncheck.Text = Math.Round(value * 10 / (float)Exam.QCurrentCount * 10, 1).ToString() + "%";
					break;
				case State.Check:
					btnCheck.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
					btnCheck.Text = " ".PadRight(length - vLength > 0 ? length - vLength + 1 : 0) + $"{value} Câu";
					btnCheck.Image = new Bitmap(Properties.Resources._checked, new Size(25, 25));
					barCheck.Value = value * 10 / Exam.QCurrentCount * 10;
					lbCheck.Text = Math.Round(value * 10 / (float)Exam.QCurrentCount * 10, 1).ToString() + "%";
					break;
				case State.Indeterminate:
					btnIndeterminate.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
					btnIndeterminate.Text = " ".PadRight(length - vLength > 0 ? length - vLength + 1 : 0) + $"{value} Câu";
					btnIndeterminate.Image = new Bitmap(Properties.Resources.warning, new Size(25, 25));
					barIndeterminate.Value = value * 10 / Exam.QCurrentCount * 10;
					lbIndeterminate.Text = Math.Round(value * 10 / (float)Exam.QCurrentCount * 10, 1).ToString() + "%";
					break;
			}
		}

		private void LoadState()
		{
			ushort i = 1;
			ushort failAnswer = 0;
			ushort notyetAnswer = 0;
			string answer;
			string selectedOption;

			CheckBox check = new CheckBox();

			foreach (DataRow row in Data.Rows)
			{
				answer = row["Answer"].ToString();
				selectedOption = row["SelectedOption"].ToString();
				selectedOption = (selectedOption != string.Empty && selectedOption.Substring(3).Length > 0) ? selectedOption.Substring(3) : "";

				if (selectedOption.Equals(string.Empty))
				{
					check.CheckState = CheckState.Indeterminate;
					notyetAnswer++;
				}
				else if (selectedOption.Equals(answer))
				{
					check.CheckState = CheckState.Checked;
					correctAnswer++;
				}
				else
				{
					check.CheckState = CheckState.Unchecked;
					failAnswer++;
				}
				LoadStateQuestion(check.CheckState, ref i, answer);
			}

			ushort cLength = (ushort)correctAnswer.ToString().Length;
			ushort fLength = (ushort)failAnswer.ToString().Length;
			ushort nyLength = (ushort)notyetAnswer.ToString().Length;
			ushort length = (cLength > fLength) ? (cLength > nyLength ? cLength : nyLength) : (fLength > nyLength ? fLength : nyLength);

			LoadStateResult(correctAnswer, length, State.Check);
			LoadStateResult(failAnswer, length, State.Uncheck);
			LoadStateResult(notyetAnswer, length, State.Indeterminate);
		}

		private void LoadMark()
		{
			string sCorrect = (correctAnswer < 9) ? $"0{correctAnswer}" : correctAnswer.ToString();
			string sQCount = (Exam.QCurrentCount < 9) ? $"0{Exam.QCurrentCount}" : Exam.QCurrentCount.ToString();
			lbCorrectNumber.Text = $"{sCorrect}/{sQCount}";
		}

		#endregion

		#region Events

		public void FrmQuizResult_Load(object sender, EventArgs e)
		{
			if (Exam != null && Data != null)
			{
				fLPdata.Controls.Clear();
				correctAnswer = 0;
				LoadState();
				LoadMark();
				Session.AntiPopup?.Invoke(false);
			}
		}

		private void btnCheck_Enter(object sender, EventArgs e)
		{
			if (sender is FontAwesome.Sharp.IconButton)
				(sender as FontAwesome.Sharp.IconButton).GotFocus += QuizResult_GotFocus;
			else
				(sender as Button).GotFocus += QuizResult_GotFocus;
		}

		private void QuizResult_GotFocus(object sender, EventArgs e)
		{
			lbTitleResult.Focus();
		}

		private void QuizResult_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
