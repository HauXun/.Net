using Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmQuizResult : Form
	{
        private Form form;
        private float mark;
        private byte correct;
		private DataTable data;
        private Exam exam;

		public DataTable Data { get => data; set => data = value; }
		public Exam Exam { get => exam; set => exam = value; }
		public Form Form { get => form; set => form = value; }

		public FrmQuizResult(DataTable data, Exam exam, float mark, byte correct, Form form)
		{
			InitializeComponent();
			Data = data;
            Exam = exam;
            this.mark = mark;
            this.correct = correct;
            Form = form;
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

		#endregion

		private void btnHome_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void FrmQuizResult_FormClosing(object sender, FormClosingEventArgs e)
		{
           // Form.Dispose();
		}
	}

	public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }
    class RJProgressBar : ProgressBar
    {
        //Fields
        //-> Appearance
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "%";
        private bool showMaximun = false;
        //-> Others
        private bool paintedBack = false;
        private bool stopPainting = false;

        //Constructor
        public RJProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }

        //Properties
        [Category("RJ Code Advance")]
        public Color ChannelColor
        {
            get { return channelColor; }
            set
            {
                channelColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color SliderColor
        {
            get { return sliderColor; }
            set
            {
                sliderColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color ForeBackColor
        {
            get { return foreBackColor; }
            set
            {
                foreBackColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int ChannelHeight
        {
            get { return channelHeight; }
            set
            {
                channelHeight = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int SliderHeight
        {
            get { return sliderHeight; }
            set
            {
                sliderHeight = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public TextPosition ShowValue
        {
            get { return showValue; }
            set
            {
                showValue = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public string SymbolBefore
        {
            get { return symbolBefore; }
            set
            {
                symbolBefore = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public string SymbolAfter
        {
            get { return symbolAfter; }
            set
            {
                symbolAfter = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public bool ShowMaximun
        {
            get { return showMaximun; }
            set
            {
                showMaximun = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
            }
        }
        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
            }
        }

        //-> Paint the background & channel
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    //Fields
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, ChannelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                            rectChannel.Y = this.Height - channelHeight;
                        else rectChannel.Y = this.Height - ((channelHeight + sliderHeight) / 2);
                        //Painting
                        graph.Clear(this.Parent.BackColor);//Surface
                        graph.FillRectangle(brushChannel, rectChannel);//Channel
                                                                       //Stop painting the back & Channel
                        if (this.DesignMode == false)
                            paintedBack = true;
                    }
                }
                //Reset painting the back & channel
                if (this.Value == this.Maximum || this.Value == this.Minimum)
                    paintedBack = false;
            }
        }

        //-> Paint slider
        protected override void OnPaint(PaintEventArgs e)
        {
            if (stopPainting == false)
            {
                //Fields
                Graphics graph = e.Graphics;
                double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight >= channelHeight)
                        rectSlider.Y = this.Height - sliderHeight;
                    else rectSlider.Y = this.Height - ((sliderHeight + channelHeight) / 2);
                    //Painting
                    if (sliderWidth > 1) //Slider
                        graph.FillRectangle(brushSlider, rectSlider);
                    if (showValue != TextPosition.None) //Text
                        DrawValueText(graph, sliderWidth, rectSlider);
                }
            }
            if (this.Value == this.Maximum) stopPainting = true;//Stop painting
            else stopPainting = false; //Keep painting
        }

        //-> Paint value text
        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            //Fields
            string text = symbolBefore + this.Value.ToString() + symbolAfter;
            if (showMaximun) text = text + "/" + symbolBefore + this.Maximum.ToString() + symbolAfter;
            var textSize = TextRenderer.MeasureText(text, this.Font);
            var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);
            using (var brushText = new SolidBrush(this.ForeColor))
            using (var brushTextBack = new SolidBrush(foreBackColor))
            using (var textFormat = new StringFormat())
            {
                switch (showValue)
                {
                    case TextPosition.Left:
                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;
                    case TextPosition.Right:
                        rectText.X = this.Width - textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;
                    case TextPosition.Center:
                        rectText.X = (this.Width - textSize.Width) / 2;
                        textFormat.Alignment = StringAlignment.Center;
                        break;
                    case TextPosition.Sliding:
                        rectText.X = sliderWidth - textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        //Clean previous text surface
                        using (var brushClear = new SolidBrush(this.Parent.BackColor))
                        {
                            var rect = rectSlider;
                            rect.Y = rectText.Y;
                            rect.Height = rectText.Height;
                            graph.FillRectangle(brushClear, rect);
                        }
                        break;
                }
                //Painting
                graph.FillRectangle(brushTextBack, rectText);
                graph.DrawString(text, this.Font, brushText, rectText, textFormat);
            }
        }
    }
}
