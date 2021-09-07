
namespace Main
{
	partial class FrmQuiz
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pMain = new System.Windows.Forms.Panel();
			this.gbTime = new System.Windows.Forms.GroupBox();
			this.cPBCountDownTime = new CircularProgressBar.CircularProgressBar();
			this.pNavigationQuiz = new System.Windows.Forms.Panel();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.pNavigation = new System.Windows.Forms.Panel();
			this.lLuncheck = new System.Windows.Forms.LinkLabel();
			this.lLflag = new System.Windows.Forms.LinkLabel();
			this.btnLastQuestion = new System.Windows.Forms.Button();
			this.btnNextQuestion = new System.Windows.Forms.Button();
			this.btnPreviousQuestion = new System.Windows.Forms.Button();
			this.btnFirstQuestion = new System.Windows.Forms.Button();
			this.gbAnswer = new System.Windows.Forms.GroupBox();
			this.rbAnswerD = new System.Windows.Forms.RadioButton();
			this.rbAnswerC = new System.Windows.Forms.RadioButton();
			this.rbAnswerB = new System.Windows.Forms.RadioButton();
			this.rbAnswerA = new System.Windows.Forms.RadioButton();
			this.gbProgressQuestion = new System.Windows.Forms.GroupBox();
			this.fLPdata = new System.Windows.Forms.FlowLayoutPanel();
			this.gbQuestionInfo = new System.Windows.Forms.GroupBox();
			this.lbNumberQuestion = new System.Windows.Forms.Label();
			this.rtbQuestionContent = new System.Windows.Forms.RichTextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTipCheck = new System.Windows.Forms.ToolTip(this.components);
			this.pMain.SuspendLayout();
			this.gbTime.SuspendLayout();
			this.pNavigationQuiz.SuspendLayout();
			this.pNavigation.SuspendLayout();
			this.gbAnswer.SuspendLayout();
			this.gbProgressQuestion.SuspendLayout();
			this.gbQuestionInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.gbTime);
			this.pMain.Controls.Add(this.pNavigationQuiz);
			this.pMain.Controls.Add(this.pNavigation);
			this.pMain.Controls.Add(this.gbAnswer);
			this.pMain.Controls.Add(this.gbProgressQuestion);
			this.pMain.Controls.Add(this.gbQuestionInfo);
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1064, 601);
			this.pMain.TabIndex = 0;
			// 
			// gbTime
			// 
			this.gbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbTime.BackColor = System.Drawing.Color.White;
			this.gbTime.Controls.Add(this.cPBCountDownTime);
			this.gbTime.Location = new System.Drawing.Point(764, 329);
			this.gbTime.Name = "gbTime";
			this.gbTime.Size = new System.Drawing.Size(288, 225);
			this.gbTime.TabIndex = 7;
			this.gbTime.TabStop = false;
			this.gbTime.Text = "Thời gian làm bài";
			// 
			// cPBCountDownTime
			// 
			this.cPBCountDownTime.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.cPBCountDownTime.AnimationSpeed = 500;
			this.cPBCountDownTime.BackColor = System.Drawing.Color.Transparent;
			this.cPBCountDownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.cPBCountDownTime.ForeColor = System.Drawing.Color.White;
			this.cPBCountDownTime.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.cPBCountDownTime.InnerMargin = 2;
			this.cPBCountDownTime.InnerWidth = -1;
			this.cPBCountDownTime.Location = new System.Drawing.Point(46, 26);
			this.cPBCountDownTime.MarqueeAnimationSpeed = 2000;
			this.cPBCountDownTime.Name = "cPBCountDownTime";
			this.cPBCountDownTime.OuterColor = System.Drawing.Color.Gray;
			this.cPBCountDownTime.OuterMargin = -25;
			this.cPBCountDownTime.OuterWidth = 26;
			this.cPBCountDownTime.ProgressColor = System.Drawing.Color.RoyalBlue;
			this.cPBCountDownTime.ProgressWidth = 5;
			this.cPBCountDownTime.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.cPBCountDownTime.Size = new System.Drawing.Size(196, 182);
			this.cPBCountDownTime.StartAngle = 270;
			this.cPBCountDownTime.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.cPBCountDownTime.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cPBCountDownTime.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.cPBCountDownTime.SubscriptText = "";
			this.cPBCountDownTime.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cPBCountDownTime.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.cPBCountDownTime.SuperscriptText = " ";
			this.cPBCountDownTime.TabIndex = 2;
			this.cPBCountDownTime.Text = "00:00:00";
			this.cPBCountDownTime.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cPBCountDownTime.Value = 68;
			// 
			// pNavigationQuiz
			// 
			this.pNavigationQuiz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pNavigationQuiz.BackColor = System.Drawing.Color.White;
			this.pNavigationQuiz.Controls.Add(this.btnEnd);
			this.pNavigationQuiz.Controls.Add(this.btnReset);
			this.pNavigationQuiz.Location = new System.Drawing.Point(764, 560);
			this.pNavigationQuiz.Name = "pNavigationQuiz";
			this.pNavigationQuiz.Size = new System.Drawing.Size(288, 29);
			this.pNavigationQuiz.TabIndex = 3;
			// 
			// btnEnd
			// 
			this.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEnd.Location = new System.Drawing.Point(210, 3);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(75, 23);
			this.btnEnd.TabIndex = 1;
			this.btnEnd.Text = "Nộp bài";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnReset.Location = new System.Drawing.Point(5, 3);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "Làm lại";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// pNavigation
			// 
			this.pNavigation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pNavigation.BackColor = System.Drawing.Color.White;
			this.pNavigation.Controls.Add(this.lLuncheck);
			this.pNavigation.Controls.Add(this.lLflag);
			this.pNavigation.Controls.Add(this.btnLastQuestion);
			this.pNavigation.Controls.Add(this.btnNextQuestion);
			this.pNavigation.Controls.Add(this.btnPreviousQuestion);
			this.pNavigation.Controls.Add(this.btnFirstQuestion);
			this.pNavigation.Location = new System.Drawing.Point(12, 560);
			this.pNavigation.Name = "pNavigation";
			this.pNavigation.Size = new System.Drawing.Size(746, 29);
			this.pNavigation.TabIndex = 2;
			// 
			// lLuncheck
			// 
			this.lLuncheck.AutoSize = true;
			this.lLuncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lLuncheck.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lLuncheck.LinkColor = System.Drawing.Color.Black;
			this.lLuncheck.Location = new System.Drawing.Point(235, 8);
			this.lLuncheck.Name = "lLuncheck";
			this.lLuncheck.Size = new System.Drawing.Size(53, 13);
			this.lLuncheck.TabIndex = 6;
			this.lLuncheck.TabStop = true;
			this.lLuncheck.Text = "Hủy chọn";
			this.toolTipCheck.SetToolTip(this.lLuncheck, "Hủy đáp án đã chọn");
			this.lLuncheck.Click += new System.EventHandler(this.lLuncheck_Click);
			this.lLuncheck.MouseEnter += new System.EventHandler(this.lLuncheck_MouseEnter);
			this.lLuncheck.MouseLeave += new System.EventHandler(this.lLuncheck_MouseLeave);
			// 
			// lLflag
			// 
			this.lLflag.ActiveLinkColor = System.Drawing.Color.Black;
			this.lLflag.AutoSize = true;
			this.lLflag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lLflag.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lLflag.LinkColor = System.Drawing.Color.Red;
			this.lLflag.Location = new System.Drawing.Point(616, 8);
			this.lLflag.Name = "lLflag";
			this.lLflag.Size = new System.Drawing.Size(43, 13);
			this.lLflag.TabIndex = 5;
			this.lLflag.TabStop = true;
			this.lLflag.Text = "Cắm cờ";
			this.toolTipCheck.SetToolTip(this.lLflag, "Đánh dấu câu hỏi");
			this.lLflag.Click += new System.EventHandler(this.lLflag_Click);
			this.lLflag.MouseEnter += new System.EventHandler(this.lLflag_MouseEnter);
			this.lLflag.MouseLeave += new System.EventHandler(this.lLflag_MouseLeave);
			// 
			// btnLastQuestion
			// 
			this.btnLastQuestion.AutoSize = true;
			this.btnLastQuestion.Location = new System.Drawing.Point(665, 3);
			this.btnLastQuestion.Name = "btnLastQuestion";
			this.btnLastQuestion.Size = new System.Drawing.Size(75, 23);
			this.btnLastQuestion.TabIndex = 4;
			this.btnLastQuestion.Text = "Câu cuối >>";
			this.btnLastQuestion.UseVisualStyleBackColor = true;
			this.btnLastQuestion.Click += new System.EventHandler(this.btnLastQuestion_Click);
			// 
			// btnNextQuestion
			// 
			this.btnNextQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnNextQuestion.AutoSize = true;
			this.btnNextQuestion.Location = new System.Drawing.Point(376, 3);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
			this.btnNextQuestion.TabIndex = 2;
			this.btnNextQuestion.Text = "Câu tiếp >";
			this.btnNextQuestion.UseVisualStyleBackColor = true;
			this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
			// 
			// btnPreviousQuestion
			// 
			this.btnPreviousQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnPreviousQuestion.AutoSize = true;
			this.btnPreviousQuestion.Location = new System.Drawing.Point(295, 3);
			this.btnPreviousQuestion.Name = "btnPreviousQuestion";
			this.btnPreviousQuestion.Size = new System.Drawing.Size(75, 23);
			this.btnPreviousQuestion.TabIndex = 1;
			this.btnPreviousQuestion.Text = "< Câu trước";
			this.btnPreviousQuestion.UseVisualStyleBackColor = true;
			this.btnPreviousQuestion.Click += new System.EventHandler(this.btnPreviousQuestion_Click);
			// 
			// btnFirstQuestion
			// 
			this.btnFirstQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnFirstQuestion.AutoSize = true;
			this.btnFirstQuestion.Location = new System.Drawing.Point(3, 3);
			this.btnFirstQuestion.Name = "btnFirstQuestion";
			this.btnFirstQuestion.Size = new System.Drawing.Size(75, 23);
			this.btnFirstQuestion.TabIndex = 0;
			this.btnFirstQuestion.Text = "<< Câu đầu";
			this.btnFirstQuestion.UseVisualStyleBackColor = true;
			this.btnFirstQuestion.Click += new System.EventHandler(this.btnFirstQuestion_Click);
			// 
			// gbAnswer
			// 
			this.gbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbAnswer.BackColor = System.Drawing.Color.White;
			this.gbAnswer.Controls.Add(this.rbAnswerD);
			this.gbAnswer.Controls.Add(this.rbAnswerC);
			this.gbAnswer.Controls.Add(this.rbAnswerB);
			this.gbAnswer.Controls.Add(this.rbAnswerA);
			this.gbAnswer.Location = new System.Drawing.Point(12, 329);
			this.gbAnswer.Name = "gbAnswer";
			this.gbAnswer.Size = new System.Drawing.Size(746, 225);
			this.gbAnswer.TabIndex = 0;
			this.gbAnswer.TabStop = false;
			this.gbAnswer.Text = "Trả lời";
			// 
			// rbAnswerD
			// 
			this.rbAnswerD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rbAnswerD.AutoSize = true;
			this.rbAnswerD.Location = new System.Drawing.Point(13, 183);
			this.rbAnswerD.Name = "rbAnswerD";
			this.rbAnswerD.Size = new System.Drawing.Size(71, 17);
			this.rbAnswerD.TabIndex = 3;
			this.rbAnswerD.Text = "Đáp án D";
			this.rbAnswerD.UseVisualStyleBackColor = true;
			// 
			// rbAnswerC
			// 
			this.rbAnswerC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rbAnswerC.AutoSize = true;
			this.rbAnswerC.Location = new System.Drawing.Point(13, 131);
			this.rbAnswerC.Name = "rbAnswerC";
			this.rbAnswerC.Size = new System.Drawing.Size(70, 17);
			this.rbAnswerC.TabIndex = 2;
			this.rbAnswerC.Text = "Đáp án C";
			this.rbAnswerC.UseVisualStyleBackColor = true;
			// 
			// rbAnswerB
			// 
			this.rbAnswerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rbAnswerB.AutoSize = true;
			this.rbAnswerB.Location = new System.Drawing.Point(13, 79);
			this.rbAnswerB.Name = "rbAnswerB";
			this.rbAnswerB.Size = new System.Drawing.Size(70, 17);
			this.rbAnswerB.TabIndex = 1;
			this.rbAnswerB.Text = "Đáp án B";
			this.rbAnswerB.UseVisualStyleBackColor = true;
			// 
			// rbAnswerA
			// 
			this.rbAnswerA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rbAnswerA.AutoSize = true;
			this.rbAnswerA.Location = new System.Drawing.Point(13, 27);
			this.rbAnswerA.Name = "rbAnswerA";
			this.rbAnswerA.Size = new System.Drawing.Size(70, 17);
			this.rbAnswerA.TabIndex = 0;
			this.rbAnswerA.Text = "Đáp án A";
			this.rbAnswerA.UseVisualStyleBackColor = true;
			// 
			// gbProgressQuestion
			// 
			this.gbProgressQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbProgressQuestion.BackColor = System.Drawing.Color.White;
			this.gbProgressQuestion.Controls.Add(this.fLPdata);
			this.gbProgressQuestion.Location = new System.Drawing.Point(764, 12);
			this.gbProgressQuestion.Name = "gbProgressQuestion";
			this.gbProgressQuestion.Size = new System.Drawing.Size(288, 311);
			this.gbProgressQuestion.TabIndex = 1;
			this.gbProgressQuestion.TabStop = false;
			this.gbProgressQuestion.Text = "Sơ đồ câu hỏi";
			// 
			// fLPdata
			// 
			this.fLPdata.AutoScroll = true;
			this.fLPdata.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fLPdata.Location = new System.Drawing.Point(3, 16);
			this.fLPdata.Name = "fLPdata";
			this.fLPdata.Size = new System.Drawing.Size(282, 292);
			this.fLPdata.TabIndex = 0;
			// 
			// gbQuestionInfo
			// 
			this.gbQuestionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbQuestionInfo.BackColor = System.Drawing.Color.White;
			this.gbQuestionInfo.Controls.Add(this.lbNumberQuestion);
			this.gbQuestionInfo.Controls.Add(this.rtbQuestionContent);
			this.gbQuestionInfo.Location = new System.Drawing.Point(12, 12);
			this.gbQuestionInfo.Name = "gbQuestionInfo";
			this.gbQuestionInfo.Size = new System.Drawing.Size(746, 311);
			this.gbQuestionInfo.TabIndex = 1;
			this.gbQuestionInfo.TabStop = false;
			this.gbQuestionInfo.Text = "Thông tin câu hỏi";
			// 
			// lbNumberQuestion
			// 
			this.lbNumberQuestion.AutoSize = true;
			this.lbNumberQuestion.Location = new System.Drawing.Point(6, 26);
			this.lbNumberQuestion.Name = "lbNumberQuestion";
			this.lbNumberQuestion.Size = new System.Drawing.Size(38, 13);
			this.lbNumberQuestion.TabIndex = 47;
			this.lbNumberQuestion.Text = "Câu 1:";
			// 
			// rtbQuestionContent
			// 
			this.rtbQuestionContent.BackColor = System.Drawing.Color.White;
			this.rtbQuestionContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbQuestionContent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbQuestionContent.Location = new System.Drawing.Point(6, 42);
			this.rtbQuestionContent.Name = "rtbQuestionContent";
			this.rtbQuestionContent.ReadOnly = true;
			this.rtbQuestionContent.Size = new System.Drawing.Size(734, 263);
			this.rtbQuestionContent.TabIndex = 46;
			this.rtbQuestionContent.TabStop = false;
			this.rtbQuestionContent.Text = "Nội dung câu hỏi";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// toolTipCheck
			// 
			this.toolTipCheck.AutomaticDelay = 0;
			this.toolTipCheck.AutoPopDelay = 10000;
			this.toolTipCheck.InitialDelay = 0;
			this.toolTipCheck.ReshowDelay = 110;
			this.toolTipCheck.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipCheck.ToolTipTitle = "Nhắc nhở!";
			// 
			// FrmQuiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 601);
			this.Controls.Add(this.pMain);
			this.MinimumSize = new System.Drawing.Size(1080, 640);
			this.Name = "FrmQuiz";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quiz";
			this.Load += new System.EventHandler(this.FrmQuiz_Load);
			this.pMain.ResumeLayout(false);
			this.gbTime.ResumeLayout(false);
			this.pNavigationQuiz.ResumeLayout(false);
			this.pNavigation.ResumeLayout(false);
			this.pNavigation.PerformLayout();
			this.gbAnswer.ResumeLayout(false);
			this.gbAnswer.PerformLayout();
			this.gbProgressQuestion.ResumeLayout(false);
			this.gbQuestionInfo.ResumeLayout(false);
			this.gbQuestionInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.GroupBox gbQuestionInfo;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Panel pNavigationQuiz;
		private System.Windows.Forms.Panel pNavigation;
		private System.Windows.Forms.Button btnLastQuestion;
		private System.Windows.Forms.Button btnNextQuestion;
		private System.Windows.Forms.Button btnPreviousQuestion;
		private System.Windows.Forms.Button btnFirstQuestion;
		private System.Windows.Forms.GroupBox gbAnswer;
		private System.Windows.Forms.RadioButton rbAnswerD;
		private System.Windows.Forms.RadioButton rbAnswerC;
		private System.Windows.Forms.RadioButton rbAnswerB;
		private System.Windows.Forms.RadioButton rbAnswerA;
		private System.Windows.Forms.Label lbNumberQuestion;
		private System.Windows.Forms.RichTextBox rtbQuestionContent;
		private System.Windows.Forms.GroupBox gbTime;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.GroupBox gbProgressQuestion;
		private System.Windows.Forms.LinkLabel lLflag;
		private CircularProgressBar.CircularProgressBar cPBCountDownTime;
		private System.Windows.Forms.FlowLayoutPanel fLPdata;
		private System.Windows.Forms.LinkLabel lLuncheck;
		private System.Windows.Forms.ToolTip toolTipCheck;
	}
}