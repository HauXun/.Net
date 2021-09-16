using Bunifu.UI.Winforms;
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
            using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 90F)) // 196, 232, 250 || //FromArgb(230, 110, 130)
            {
                e.Graphics.FillRectangle(brush, rectangle);
            }
        }

        //Bo tròn các góc của Control
        #region Rounded Form
        private void RoundedControls()
        {
			//Panels
			pnlResult.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlResult.Width, pnlResult.Height, 10, 10));
            fLPdata.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, fLPdata.Width, fLPdata.Height, 10, 10));
            //Panels Shadow
            pnlKetQuaShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlKetQuaShadow.Width, pnlKetQuaShadow.Height, 10, 10));
            flpCChiTietKetQuaShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, flpCChiTietKetQuaShadow.Width, flpCChiTietKetQuaShadow.Height, 10, 10));
        }
		#endregion

		#region Methods

		private void LoadStateQuestion(CheckState check, ref ushort i, string answer)
		{
			ToolTip tip = new ToolTip()
			{
				AutomaticDelay = 0,
				AutoPopDelay = 10000,
				InitialDelay = 0,
				ToolTipTitle = "Đáp án đúng"
			};

			Button button = new Button()
			{
				AutoSize = true,
				Width = 45,
				Height = 45,
				Text = $"Câu {i++}",
				TextImageRelation = TextImageRelation.TextAboveImage,
				Font = new Font("Arial", 8, FontStyle.Regular),
				BackColor = Color.Transparent,
				FlatStyle = FlatStyle.Flat
			};

			button.FlatAppearance.BorderSize = 0;
			button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

			switch (check)
			{
				case CheckState.Unchecked:
					button.Image = new Bitmap(Properties.Resources.cancel, new Size(40, 40));
					tip.ToolTipIcon = ToolTipIcon.Error;
					break;
				case CheckState.Checked:
					button.Image = new Bitmap(Properties.Resources._checked, new Size(40, 40));
					tip.ToolTipIcon = ToolTipIcon.Info;
					break;
				case CheckState.Indeterminate:
					button.Image = new Bitmap(Properties.Resources.warning, new Size(40, 40));
					tip.ToolTipIcon = ToolTipIcon.Warning;
					break;
				default:
					break;
			}

			tip.SetToolTip(button, answer);
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
				case State.Check:
					btnCheck.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
					btnCheck.Text = " ".PadRight(length - vLength > 0 ? length - vLength + 1 : 0) + $"{value} Câu";
					btnCheck.Image = new Bitmap(Properties.Resources._checked, new Size(25, 25));
					barCheck.ProgressColorLeft = Color.FromArgb(0, 192, 0);
					barCheck.Value = value * 10 / Exam.QCount * 10;
					lbCheck.Text = ((float)value * 10 / Exam.QCount * 10).ToString() + "%";
					break;
				case State.Uncheck:
					btnUncheck.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
					btnUncheck.Text = " ".PadRight(length - vLength > 0 ? length - vLength + 1 : 0) + $"{value} Câu";
					btnUncheck.Image = new Bitmap(Properties.Resources.cancel, new Size(25, 25));
					barUncheck.ProgressColorLeft = Color.FromArgb(210, 20, 20);
					barUncheck.Value = value * 10 / Exam.QCount * 10;
					lbUncheck.Text = ((float)value * 10 / Exam.QCount * 10).ToString() + "%";
					break;
				case State.Indeterminate:
					btnIndeterminate.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
					btnIndeterminate.Text = " ".PadRight(length - vLength > 0 ? length - vLength + 1 : 0) + $"{value} Câu";
					btnIndeterminate.Image = new Bitmap(Properties.Resources.warning, new Size(25, 25));
					barIndeterminate.ProgressColorLeft = Color.FromArgb(255, 210, 0);
					barIndeterminate.Value = value * 10 / Exam.QCount * 10;
					lbIndeterminate.Text = ((float)value * 10 / Exam.QCount * 10).ToString() + "%";
					break;
				default:
					break;
			}
		}

		private void LoadState()
		{
			ushort i = 1;
			ushort correctAnswer = 0;
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
			string sQCount = (Exam.QCount < 9) ? $"0{Exam.QCount}" : Exam.QCount.ToString();
			lbCorrectNumber.Text = $"{sCorrect}/{sQCount}";
		}

		#endregion

		#region Events

		private void FrmQuizResult_Load(object sender, EventArgs e)
		{
			LoadState();
			LoadMark();
		}

		#endregion
	}
}
