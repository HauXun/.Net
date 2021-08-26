
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
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
			this.lvData = new System.Windows.Forms.ListView();
			this.gbQuestionInfo = new System.Windows.Forms.GroupBox();
			this.lbNumberQuestion = new System.Windows.Forms.Label();
			this.rtbQuestionContent = new System.Windows.Forms.RichTextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTipTicked = new System.Windows.Forms.ToolTip(this.components);
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.cPBCountDownTime = new CircularProgressBar.CircularProgressBar();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.pMain.SuspendLayout();
			this.gbTime.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.pMain.Controls.Add(this.panel2);
			this.pMain.Controls.Add(this.panel1);
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
			this.gbTime.Location = new System.Drawing.Point(704, 329);
			this.gbTime.Name = "gbTime";
			this.gbTime.Size = new System.Drawing.Size(348, 225);
			this.gbTime.TabIndex = 7;
			this.gbTime.TabStop = false;
			this.gbTime.Text = "Thời gian";
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnEnd);
			this.panel2.Controls.Add(this.btnReset);
			this.panel2.Location = new System.Drawing.Point(707, 560);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(342, 29);
			this.panel2.TabIndex = 3;
			// 
			// btnEnd
			// 
			this.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEnd.Location = new System.Drawing.Point(264, 3);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(75, 23);
			this.btnEnd.TabIndex = 1;
			this.btnEnd.Text = "Nộp bài";
			this.btnEnd.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnReset.Location = new System.Drawing.Point(3, 3);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "Làm lại";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.btnLastQuestion);
			this.panel1.Controls.Add(this.btnNextQuestion);
			this.panel1.Controls.Add(this.btnPreviousQuestion);
			this.panel1.Controls.Add(this.btnFirstQuestion);
			this.panel1.Location = new System.Drawing.Point(12, 560);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(683, 29);
			this.panel1.TabIndex = 2;
			// 
			// btnLastQuestion
			// 
			this.btnLastQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnLastQuestion.AutoSize = true;
			this.btnLastQuestion.Location = new System.Drawing.Point(605, 3);
			this.btnLastQuestion.Name = "btnLastQuestion";
			this.btnLastQuestion.Size = new System.Drawing.Size(75, 23);
			this.btnLastQuestion.TabIndex = 4;
			this.btnLastQuestion.Text = "Câu cuối >>";
			this.btnLastQuestion.UseVisualStyleBackColor = true;
			// 
			// btnNextQuestion
			// 
			this.btnNextQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnNextQuestion.AutoSize = true;
			this.btnNextQuestion.Location = new System.Drawing.Point(344, 3);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
			this.btnNextQuestion.TabIndex = 2;
			this.btnNextQuestion.Text = "Câu tiếp >";
			this.btnNextQuestion.UseVisualStyleBackColor = true;
			// 
			// btnPreviousQuestion
			// 
			this.btnPreviousQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnPreviousQuestion.AutoSize = true;
			this.btnPreviousQuestion.Location = new System.Drawing.Point(263, 3);
			this.btnPreviousQuestion.Name = "btnPreviousQuestion";
			this.btnPreviousQuestion.Size = new System.Drawing.Size(75, 23);
			this.btnPreviousQuestion.TabIndex = 1;
			this.btnPreviousQuestion.Text = "< Câu trước";
			this.btnPreviousQuestion.UseVisualStyleBackColor = true;
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
			this.gbAnswer.Size = new System.Drawing.Size(686, 225);
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
			this.rbAnswerD.TabStop = true;
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
			this.rbAnswerC.TabStop = true;
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
			this.rbAnswerB.TabStop = true;
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
			this.rbAnswerA.TabStop = true;
			this.rbAnswerA.Text = "Đáp án A";
			this.rbAnswerA.UseVisualStyleBackColor = true;
			// 
			// gbProgressQuestion
			// 
			this.gbProgressQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbProgressQuestion.BackColor = System.Drawing.Color.White;
			this.gbProgressQuestion.Controls.Add(this.lvData);
			this.gbProgressQuestion.Location = new System.Drawing.Point(704, 12);
			this.gbProgressQuestion.Name = "gbProgressQuestion";
			this.gbProgressQuestion.Size = new System.Drawing.Size(348, 311);
			this.gbProgressQuestion.TabIndex = 1;
			this.gbProgressQuestion.TabStop = false;
			this.gbProgressQuestion.Text = "Tiến độ câu hỏi";
			// 
			// lvData
			// 
			this.lvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvData.HideSelection = false;
			this.lvData.Location = new System.Drawing.Point(3, 16);
			this.lvData.Name = "lvData";
			this.lvData.Size = new System.Drawing.Size(342, 292);
			this.lvData.TabIndex = 0;
			this.lvData.UseCompatibleStateImageBehavior = false;
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
			this.gbQuestionInfo.Size = new System.Drawing.Size(686, 311);
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
			this.rtbQuestionContent.Size = new System.Drawing.Size(674, 263);
			this.rtbQuestionContent.TabIndex = 46;
			this.rtbQuestionContent.TabStop = false;
			this.rtbQuestionContent.Text = "Nội dung câu hỏi";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// toolTipTicked
			// 
			this.toolTipTicked.AutoPopDelay = 10000;
			this.toolTipTicked.InitialDelay = 0;
			this.toolTipTicked.ReshowDelay = 100;
			this.toolTipTicked.ToolTipTitle = "Nhắc nhở!";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.Red;
			this.linkLabel1.Location = new System.Drawing.Point(544, 8);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(54, 13);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Đánh dấu";
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
			this.cPBCountDownTime.Location = new System.Drawing.Point(76, 26);
			this.cPBCountDownTime.MarqueeAnimationSpeed = 2000;
			this.cPBCountDownTime.Name = "cPBCountDownTime";
			this.cPBCountDownTime.OuterColor = System.Drawing.Color.Gray;
			this.cPBCountDownTime.OuterMargin = -25;
			this.cPBCountDownTime.OuterWidth = 26;
			this.cPBCountDownTime.ProgressColor = System.Drawing.Color.RoyalBlue;
			this.cPBCountDownTime.ProgressWidth = 15;
			this.cPBCountDownTime.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.cPBCountDownTime.Size = new System.Drawing.Size(196, 182);
			this.cPBCountDownTime.StartAngle = 270;
			this.cPBCountDownTime.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.cPBCountDownTime.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cPBCountDownTime.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.cPBCountDownTime.SubscriptText = ".23";
			this.cPBCountDownTime.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cPBCountDownTime.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.cPBCountDownTime.SuperscriptText = "00";
			this.cPBCountDownTime.TabIndex = 2;
			this.cPBCountDownTime.Text = "00:00:00";
			this.cPBCountDownTime.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cPBCountDownTime.Value = 68;
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
			this.Text = "Quản lý môn thi";
			this.Load += new System.EventHandler(this.FrmQuiz_Load);
			this.pMain.ResumeLayout(false);
			this.gbTime.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
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
		private System.Windows.Forms.ToolTip toolTipTicked;
		private System.Windows.Forms.GroupBox gbProgressQuestion;
		private System.Windows.Forms.ListView lvData;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private CircularProgressBar.CircularProgressBar cPBCountDownTime;
		private System.Windows.Forms.Timer timer;
	}
}