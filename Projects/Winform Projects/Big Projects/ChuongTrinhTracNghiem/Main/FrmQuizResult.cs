using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmQuizResult : Form
    {
        private float mark;
        private byte correct;
		private DataTable data;
        private Exam exam;

		public DataTable Data { get => data; set => data = value; }
		public Exam Exam { get => exam; set => exam = value; }

		public FrmQuizResult(DataTable data, Exam exam, float mark, byte correct)
		{
			InitializeComponent();
			Data = data;
            Exam = exam;
            this.mark = mark;
            this.correct = correct;
        }

		#region Methods

		private void LoadStateQuestion(CheckState check, ref byte i, string answer)
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
				Font = new Font("Arial", 6.5F, FontStyle.Regular),
				BackColor = Color.Transparent,
				FlatStyle = FlatStyle.Flat
			};

			button.FlatAppearance.BorderSize = 0;
			button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

			switch (check)
			{
				case CheckState.Unchecked:
					button.Image = new Bitmap(Properties.Resources.cancel, new Size(40, 40)) ;
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

        private void LoadStateResult(byte value, byte length, State state)
		{
            int vLength = value.ToString().Length;

            Button button = new Button()
            {
                AutoSize = true,
                Width = 110,
                Height = 45,
                Text = "".PadRight(length - vLength > 0 ? length - vLength + 1 : 0) + $"{value} Câu",
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Font = new Font("Arial", 9, FontStyle.Regular),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat
            };

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            RJProgressBar bar = new RJProgressBar()
            {
                SliderHeight = 10,
                ChannelHeight = 8,
                ForeBackColor = Color.Transparent,
                ForeColor = Color.Black,
                ShowMaximun = true,
                ShowValue = TextPosition.Center,
                Value = (int)((float)value * 10 / Exam.QCount * 10),
                Size = new Size(210, 27),
                ChannelColor = Color.Gainsboro
            };

			switch (state)
			{
				case State.Check:
                    button.Image = new Bitmap(Properties.Resources._checked, new Size(20, 20));
                    bar.SliderColor = Color.Lime;
                    break;
				case State.Uncheck:
                    button.Image = new Bitmap(Properties.Resources.cancel, new Size(20, 20));
                    bar.SliderColor = Color.Red;
                    break;
				case State.Indeterminate:
                    button.Image = new Bitmap(Properties.Resources.warning, new Size(20, 20));
                    bar.SliderColor = Color.Gold;
                    break;
				default:
					break;
			}

            fLPResult.Controls.Add(button);
            fLPResult.Controls.Add(bar);

        }

		private void LoadState()
		{
			byte i = 1;
            byte correctAnswer = 0;
            byte failAnswer = 0;
            byte notyetAnswer = 0;
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

            byte cLength = (byte)correctAnswer.ToString().Length;
            byte fLength = (byte)failAnswer.ToString().Length;
            byte nyLength = (byte)notyetAnswer.ToString().Length;
            byte length = (cLength > fLength) ? (cLength > nyLength ? cLength : nyLength) : (fLength > nyLength ? fLength : nyLength);

            LoadStateResult(correctAnswer, length, State.Check);
            LoadStateResult(failAnswer, length, State.Uncheck);
            LoadStateResult(notyetAnswer, length, State.Indeterminate);
        }

        private void LoadMark()
        {
            string sCorrect = (correct < 9) ? $"0{correct}" : correct.ToString();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
