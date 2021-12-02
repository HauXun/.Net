
namespace Main.Pages
{
	partial class QuizTest
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
			this.rbAnswerD = new System.Windows.Forms.RadioButton();
			this.rbAnswerC = new System.Windows.Forms.RadioButton();
			this.rbAnswerB = new System.Windows.Forms.RadioButton();
			this.rbAnswerA = new System.Windows.Forms.RadioButton();
			this.lbNumberQuestion = new System.Windows.Forms.Label();
			this.lbNoiDungCauHoi = new System.Windows.Forms.Label();
			this.rtbQuestionContent = new System.Windows.Forms.RichTextBox();
			this.pnlLineDSCH = new System.Windows.Forms.Panel();
			this.Line = new System.Windows.Forms.Panel();
			this.fLPdata = new System.Windows.Forms.FlowLayoutPanel();
			this.lbDanhSachCauHoi = new System.Windows.Forms.Label();
			this.btnReset = new FontAwesome.Sharp.IconButton();
			this.btnEnd = new FontAwesome.Sharp.IconButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cPBCountDownTime = new CircularProgressBar.CircularProgressBar();
			this.btnPreviousQuestion = new FontAwesome.Sharp.IconButton();
			this.btnNextQuestion = new FontAwesome.Sharp.IconButton();
			this.btnLastQuestion = new FontAwesome.Sharp.IconButton();
			this.btnFirstQuestion = new FontAwesome.Sharp.IconButton();
			this.lLuncheck = new System.Windows.Forms.LinkLabel();
			this.btnFlags = new FontAwesome.Sharp.IconButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlCauHoi = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pnlAnswer = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pNavigation = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pnlNopBai = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pnlThoiGian = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pnlDanhSachCauHoi = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pnlLineDSCH.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlCauHoi.SuspendLayout();
			this.pnlAnswer.SuspendLayout();
			this.pNavigation.SuspendLayout();
			this.pnlNopBai.SuspendLayout();
			this.pnlThoiGian.SuspendLayout();
			this.pnlDanhSachCauHoi.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbAnswerD
			// 
			this.rbAnswerD.AutoSize = true;
			this.rbAnswerD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbAnswerD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAnswerD.Location = new System.Drawing.Point(25, 215);
			this.rbAnswerD.Name = "rbAnswerD";
			this.rbAnswerD.Size = new System.Drawing.Size(83, 18);
			this.rbAnswerD.TabIndex = 0;
			this.rbAnswerD.Text = "Đáp án D";
			this.rbAnswerD.UseVisualStyleBackColor = true;
			this.rbAnswerD.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// rbAnswerC
			// 
			this.rbAnswerC.AutoSize = true;
			this.rbAnswerC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbAnswerC.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAnswerC.Location = new System.Drawing.Point(25, 152);
			this.rbAnswerC.Name = "rbAnswerC";
			this.rbAnswerC.Size = new System.Drawing.Size(83, 18);
			this.rbAnswerC.TabIndex = 0;
			this.rbAnswerC.Text = "Đáp án C";
			this.rbAnswerC.UseVisualStyleBackColor = true;
			this.rbAnswerC.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// rbAnswerB
			// 
			this.rbAnswerB.AutoSize = true;
			this.rbAnswerB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbAnswerB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAnswerB.Location = new System.Drawing.Point(25, 89);
			this.rbAnswerB.Name = "rbAnswerB";
			this.rbAnswerB.Size = new System.Drawing.Size(82, 18);
			this.rbAnswerB.TabIndex = 0;
			this.rbAnswerB.Text = "Đáp án B";
			this.rbAnswerB.UseVisualStyleBackColor = true;
			this.rbAnswerB.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// rbAnswerA
			// 
			this.rbAnswerA.AutoSize = true;
			this.rbAnswerA.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbAnswerA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAnswerA.Location = new System.Drawing.Point(25, 26);
			this.rbAnswerA.Name = "rbAnswerA";
			this.rbAnswerA.Size = new System.Drawing.Size(82, 18);
			this.rbAnswerA.TabIndex = 0;
			this.rbAnswerA.Text = "Đáp án A";
			this.rbAnswerA.UseVisualStyleBackColor = true;
			this.rbAnswerA.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// lbNumberQuestion
			// 
			this.lbNumberQuestion.AutoSize = true;
			this.lbNumberQuestion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNumberQuestion.Location = new System.Drawing.Point(1075, 14);
			this.lbNumberQuestion.Name = "lbNumberQuestion";
			this.lbNumberQuestion.Size = new System.Drawing.Size(73, 25);
			this.lbNumberQuestion.TabIndex = 0;
			this.lbNumberQuestion.Text = "Câu 1";
			this.lbNumberQuestion.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// lbNoiDungCauHoi
			// 
			this.lbNoiDungCauHoi.AutoSize = true;
			this.lbNoiDungCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbNoiDungCauHoi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNoiDungCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbNoiDungCauHoi.Location = new System.Drawing.Point(0, 0);
			this.lbNoiDungCauHoi.Name = "lbNoiDungCauHoi";
			this.lbNoiDungCauHoi.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.lbNoiDungCauHoi.Size = new System.Drawing.Size(209, 35);
			this.lbNoiDungCauHoi.TabIndex = 0;
			this.lbNoiDungCauHoi.Text = "Nội dung câu hỏi:";
			this.lbNoiDungCauHoi.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// rtbQuestionContent
			// 
			this.rtbQuestionContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbQuestionContent.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbQuestionContent.Location = new System.Drawing.Point(15, 49);
			this.rtbQuestionContent.Name = "rtbQuestionContent";
			this.rtbQuestionContent.Size = new System.Drawing.Size(1171, 337);
			this.rtbQuestionContent.TabIndex = 0;
			this.rtbQuestionContent.TabStop = false;
			this.rtbQuestionContent.Text = "";
			this.rtbQuestionContent.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// pnlLineDSCH
			// 
			this.pnlLineDSCH.Controls.Add(this.Line);
			this.pnlLineDSCH.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLineDSCH.Location = new System.Drawing.Point(0, 44);
			this.pnlLineDSCH.Name = "pnlLineDSCH";
			this.pnlLineDSCH.Size = new System.Drawing.Size(300, 5);
			this.pnlLineDSCH.TabIndex = 0;
			this.pnlLineDSCH.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// Line
			// 
			this.Line.BackColor = System.Drawing.Color.Black;
			this.Line.Location = new System.Drawing.Point(25, 2);
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(250, 1);
			this.Line.TabIndex = 0;
			this.Line.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// fLPdata
			// 
			this.fLPdata.AutoScroll = true;
			this.fLPdata.Location = new System.Drawing.Point(0, 49);
			this.fLPdata.Name = "fLPdata";
			this.fLPdata.Size = new System.Drawing.Size(294, 345);
			this.fLPdata.TabIndex = 0;
			this.fLPdata.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// lbDanhSachCauHoi
			// 
			this.lbDanhSachCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbDanhSachCauHoi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDanhSachCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbDanhSachCauHoi.Location = new System.Drawing.Point(0, 0);
			this.lbDanhSachCauHoi.Name = "lbDanhSachCauHoi";
			this.lbDanhSachCauHoi.Size = new System.Drawing.Size(300, 44);
			this.lbDanhSachCauHoi.TabIndex = 0;
			this.lbDanhSachCauHoi.Text = "Sơ đồ câu hỏi";
			this.lbDanhSachCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbDanhSachCauHoi.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Firebrick;
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Reply;
			this.btnReset.IconColor = System.Drawing.Color.White;
			this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnReset.IconSize = 25;
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnReset.Location = new System.Drawing.Point(10, 8);
			this.btnReset.Name = "btnReset";
			this.btnReset.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnReset.Size = new System.Drawing.Size(100, 40);
			this.btnReset.TabIndex = 0;
			this.btnReset.TabStop = false;
			this.btnReset.Text = "Làm lại";
			this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			this.btnReset.Enter += new System.EventHandler(this.btnPreviousQuestion_Enter);
			// 
			// btnEnd
			// 
			this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEnd.FlatAppearance.BorderSize = 0;
			this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnd.ForeColor = System.Drawing.Color.White;
			this.btnEnd.IconChar = FontAwesome.Sharp.IconChar.Check;
			this.btnEnd.IconColor = System.Drawing.Color.White;
			this.btnEnd.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEnd.IconSize = 25;
			this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEnd.Location = new System.Drawing.Point(188, 8);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnEnd.Size = new System.Drawing.Size(100, 40);
			this.btnEnd.TabIndex = 0;
			this.btnEnd.TabStop = false;
			this.btnEnd.Text = "Nộp bài";
			this.btnEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEnd.UseVisualStyleBackColor = false;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			this.btnEnd.Enter += new System.EventHandler(this.btnPreviousQuestion_Enter);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 5);
			this.panel1.TabIndex = 0;
			this.panel1.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(25, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 1);
			this.panel2.TabIndex = 0;
			this.panel2.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thời gian làm bài";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.QuizTest_Click);
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
			this.cPBCountDownTime.Location = new System.Drawing.Point(40, 63);
			this.cPBCountDownTime.MarqueeAnimationSpeed = 2000;
			this.cPBCountDownTime.Name = "cPBCountDownTime";
			this.cPBCountDownTime.OuterColor = System.Drawing.Color.Gray;
			this.cPBCountDownTime.OuterMargin = -25;
			this.cPBCountDownTime.OuterWidth = 26;
			this.cPBCountDownTime.ProgressColor = System.Drawing.Color.RoyalBlue;
			this.cPBCountDownTime.ProgressWidth = 8;
			this.cPBCountDownTime.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.cPBCountDownTime.Size = new System.Drawing.Size(220, 220);
			this.cPBCountDownTime.StartAngle = 270;
			this.cPBCountDownTime.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.cPBCountDownTime.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cPBCountDownTime.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.cPBCountDownTime.SubscriptText = "";
			this.cPBCountDownTime.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cPBCountDownTime.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.cPBCountDownTime.SuperscriptText = " ";
			this.cPBCountDownTime.TabIndex = 0;
			this.cPBCountDownTime.Text = "00:00:00";
			this.cPBCountDownTime.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cPBCountDownTime.Value = 68;
			this.cPBCountDownTime.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// btnPreviousQuestion
			// 
			this.btnPreviousQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnPreviousQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPreviousQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPreviousQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnPreviousQuestion.FlatAppearance.BorderSize = 0;
			this.btnPreviousQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPreviousQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
			this.btnPreviousQuestion.ForeColor = System.Drawing.Color.White;
			this.btnPreviousQuestion.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
			this.btnPreviousQuestion.IconColor = System.Drawing.Color.White;
			this.btnPreviousQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPreviousQuestion.IconSize = 25;
			this.btnPreviousQuestion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPreviousQuestion.Location = new System.Drawing.Point(15, 8);
			this.btnPreviousQuestion.Name = "btnPreviousQuestion";
			this.btnPreviousQuestion.Size = new System.Drawing.Size(50, 40);
			this.btnPreviousQuestion.TabIndex = 0;
			this.btnPreviousQuestion.TabStop = false;
			this.btnPreviousQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnPreviousQuestion, "Câu trước đó");
			this.btnPreviousQuestion.UseVisualStyleBackColor = false;
			this.btnPreviousQuestion.Click += new System.EventHandler(this.btnPreviousQuestion_Click);
			this.btnPreviousQuestion.Enter += new System.EventHandler(this.btnPreviousQuestion_Enter);
			// 
			// btnNextQuestion
			// 
			this.btnNextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnNextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNextQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnNextQuestion.FlatAppearance.BorderSize = 0;
			this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
			this.btnNextQuestion.ForeColor = System.Drawing.Color.White;
			this.btnNextQuestion.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
			this.btnNextQuestion.IconColor = System.Drawing.Color.White;
			this.btnNextQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnNextQuestion.IconSize = 25;
			this.btnNextQuestion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNextQuestion.Location = new System.Drawing.Point(71, 8);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(50, 40);
			this.btnNextQuestion.TabIndex = 0;
			this.btnNextQuestion.TabStop = false;
			this.btnNextQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolTip.SetToolTip(this.btnNextQuestion, "Câu tiếp theo");
			this.btnNextQuestion.UseVisualStyleBackColor = false;
			this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
			this.btnNextQuestion.Enter += new System.EventHandler(this.btnPreviousQuestion_Enter);
			// 
			// btnLastQuestion
			// 
			this.btnLastQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnLastQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLastQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLastQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnLastQuestion.FlatAppearance.BorderSize = 0;
			this.btnLastQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLastQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
			this.btnLastQuestion.ForeColor = System.Drawing.Color.White;
			this.btnLastQuestion.IconChar = FontAwesome.Sharp.IconChar.Forward;
			this.btnLastQuestion.IconColor = System.Drawing.Color.White;
			this.btnLastQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnLastQuestion.IconSize = 25;
			this.btnLastQuestion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLastQuestion.Location = new System.Drawing.Point(1136, 8);
			this.btnLastQuestion.Name = "btnLastQuestion";
			this.btnLastQuestion.Size = new System.Drawing.Size(50, 40);
			this.btnLastQuestion.TabIndex = 0;
			this.btnLastQuestion.TabStop = false;
			this.toolTip.SetToolTip(this.btnLastQuestion, "Câu cuối");
			this.btnLastQuestion.UseVisualStyleBackColor = false;
			this.btnLastQuestion.Click += new System.EventHandler(this.btnLastQuestion_Click);
			this.btnLastQuestion.Enter += new System.EventHandler(this.btnPreviousQuestion_Enter);
			// 
			// btnFirstQuestion
			// 
			this.btnFirstQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnFirstQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFirstQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFirstQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnFirstQuestion.FlatAppearance.BorderSize = 0;
			this.btnFirstQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFirstQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
			this.btnFirstQuestion.ForeColor = System.Drawing.Color.White;
			this.btnFirstQuestion.IconChar = FontAwesome.Sharp.IconChar.Backward;
			this.btnFirstQuestion.IconColor = System.Drawing.Color.White;
			this.btnFirstQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnFirstQuestion.IconSize = 25;
			this.btnFirstQuestion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFirstQuestion.Location = new System.Drawing.Point(1080, 8);
			this.btnFirstQuestion.Name = "btnFirstQuestion";
			this.btnFirstQuestion.Size = new System.Drawing.Size(50, 40);
			this.btnFirstQuestion.TabIndex = 0;
			this.btnFirstQuestion.TabStop = false;
			this.btnFirstQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnFirstQuestion, "Câu đầu");
			this.btnFirstQuestion.UseVisualStyleBackColor = false;
			this.btnFirstQuestion.Click += new System.EventHandler(this.btnFirstQuestion_Click);
			this.btnFirstQuestion.Enter += new System.EventHandler(this.btnPreviousQuestion_Enter);
			// 
			// lLuncheck
			// 
			this.lLuncheck.AutoSize = true;
			this.lLuncheck.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lLuncheck.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lLuncheck.ForeColor = System.Drawing.Color.DimGray;
			this.lLuncheck.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lLuncheck.LinkColor = System.Drawing.Color.DimGray;
			this.lLuncheck.Location = new System.Drawing.Point(173, 20);
			this.lLuncheck.Name = "lLuncheck";
			this.lLuncheck.Size = new System.Drawing.Size(78, 18);
			this.lLuncheck.TabIndex = 0;
			this.lLuncheck.TabStop = true;
			this.lLuncheck.Text = "Hủy chọn";
			this.lLuncheck.Click += new System.EventHandler(this.lLuncheck_Click);
			this.lLuncheck.MouseEnter += new System.EventHandler(this.lLuncheck_MouseEnter);
			this.lLuncheck.MouseLeave += new System.EventHandler(this.lLuncheck_MouseLeave);
			// 
			// btnFlags
			// 
			this.btnFlags.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFlags.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnFlags.FlatAppearance.BorderSize = 0;
			this.btnFlags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFlags.IconChar = FontAwesome.Sharp.IconChar.Flag;
			this.btnFlags.IconColor = System.Drawing.Color.Firebrick;
			this.btnFlags.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnFlags.IconSize = 30;
			this.btnFlags.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFlags.Location = new System.Drawing.Point(127, 8);
			this.btnFlags.Name = "btnFlags";
			this.btnFlags.Size = new System.Drawing.Size(40, 40);
			this.btnFlags.TabIndex = 0;
			this.btnFlags.TabStop = false;
			this.toolTip.SetToolTip(this.btnFlags, "Cắm cờ (Đánh dấu) câu hỏi hiện tại");
			this.btnFlags.UseVisualStyleBackColor = true;
			this.btnFlags.Click += new System.EventHandler(this.btnFlags_Click);
			this.btnFlags.Enter += new System.EventHandler(this.btnPreviousQuestion_Enter);
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 0;
			this.toolTip.AutoPopDelay = 10000;
			this.toolTip.InitialDelay = 0;
			this.toolTip.ReshowDelay = 0;
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip.ToolTipTitle = "Suggest";
			// 
			// pnlCauHoi
			// 
			this.pnlCauHoi.BackColor = System.Drawing.Color.Transparent;
			this.pnlCauHoi.Controls.Add(this.lbNumberQuestion);
			this.pnlCauHoi.Controls.Add(this.lbNoiDungCauHoi);
			this.pnlCauHoi.Controls.Add(this.rtbQuestionContent);
			this.pnlCauHoi.FillColor = System.Drawing.Color.White;
			this.pnlCauHoi.Location = new System.Drawing.Point(12, 12);
			this.pnlCauHoi.Name = "pnlCauHoi";
			this.pnlCauHoi.Radius = 5;
			this.pnlCauHoi.ShadowColor = System.Drawing.Color.Black;
			this.pnlCauHoi.ShadowDepth = 255;
			this.pnlCauHoi.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlCauHoi.Size = new System.Drawing.Size(1200, 400);
			this.pnlCauHoi.TabIndex = 0;
			this.pnlCauHoi.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// pnlAnswer
			// 
			this.pnlAnswer.BackColor = System.Drawing.Color.Transparent;
			this.pnlAnswer.Controls.Add(this.rbAnswerD);
			this.pnlAnswer.Controls.Add(this.rbAnswerA);
			this.pnlAnswer.Controls.Add(this.rbAnswerC);
			this.pnlAnswer.Controls.Add(this.rbAnswerB);
			this.pnlAnswer.FillColor = System.Drawing.Color.White;
			this.pnlAnswer.Location = new System.Drawing.Point(12, 430);
			this.pnlAnswer.Name = "pnlAnswer";
			this.pnlAnswer.Radius = 5;
			this.pnlAnswer.ShadowColor = System.Drawing.Color.Black;
			this.pnlAnswer.ShadowDepth = 255;
			this.pnlAnswer.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlAnswer.Size = new System.Drawing.Size(1200, 300);
			this.pnlAnswer.TabIndex = 0;
			this.pnlAnswer.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// pNavigation
			// 
			this.pNavigation.BackColor = System.Drawing.Color.Transparent;
			this.pNavigation.Controls.Add(this.btnPreviousQuestion);
			this.pNavigation.Controls.Add(this.btnNextQuestion);
			this.pNavigation.Controls.Add(this.btnFlags);
			this.pNavigation.Controls.Add(this.btnLastQuestion);
			this.pNavigation.Controls.Add(this.lLuncheck);
			this.pNavigation.Controls.Add(this.btnFirstQuestion);
			this.pNavigation.FillColor = System.Drawing.Color.White;
			this.pNavigation.Location = new System.Drawing.Point(12, 746);
			this.pNavigation.Name = "pNavigation";
			this.pNavigation.Radius = 5;
			this.pNavigation.ShadowColor = System.Drawing.Color.Black;
			this.pNavigation.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pNavigation.Size = new System.Drawing.Size(1200, 60);
			this.pNavigation.TabIndex = 0;
			this.pNavigation.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// pnlNopBai
			// 
			this.pnlNopBai.BackColor = System.Drawing.Color.Transparent;
			this.pnlNopBai.Controls.Add(this.btnReset);
			this.pnlNopBai.Controls.Add(this.btnEnd);
			this.pnlNopBai.FillColor = System.Drawing.Color.White;
			this.pnlNopBai.Location = new System.Drawing.Point(1238, 746);
			this.pnlNopBai.Name = "pnlNopBai";
			this.pnlNopBai.Radius = 5;
			this.pnlNopBai.ShadowColor = System.Drawing.Color.Black;
			this.pnlNopBai.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlNopBai.Size = new System.Drawing.Size(300, 60);
			this.pnlNopBai.TabIndex = 0;
			this.pnlNopBai.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// pnlThoiGian
			// 
			this.pnlThoiGian.BackColor = System.Drawing.Color.Transparent;
			this.pnlThoiGian.Controls.Add(this.panel1);
			this.pnlThoiGian.Controls.Add(this.cPBCountDownTime);
			this.pnlThoiGian.Controls.Add(this.label1);
			this.pnlThoiGian.FillColor = System.Drawing.Color.White;
			this.pnlThoiGian.Location = new System.Drawing.Point(1238, 430);
			this.pnlThoiGian.Name = "pnlThoiGian";
			this.pnlThoiGian.Radius = 5;
			this.pnlThoiGian.ShadowColor = System.Drawing.Color.Black;
			this.pnlThoiGian.ShadowDepth = 150;
			this.pnlThoiGian.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlThoiGian.Size = new System.Drawing.Size(300, 300);
			this.pnlThoiGian.TabIndex = 3;
			this.pnlThoiGian.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// pnlDanhSachCauHoi
			// 
			this.pnlDanhSachCauHoi.BackColor = System.Drawing.Color.Transparent;
			this.pnlDanhSachCauHoi.Controls.Add(this.fLPdata);
			this.pnlDanhSachCauHoi.Controls.Add(this.pnlLineDSCH);
			this.pnlDanhSachCauHoi.Controls.Add(this.lbDanhSachCauHoi);
			this.pnlDanhSachCauHoi.FillColor = System.Drawing.Color.White;
			this.pnlDanhSachCauHoi.Location = new System.Drawing.Point(1238, 12);
			this.pnlDanhSachCauHoi.Name = "pnlDanhSachCauHoi";
			this.pnlDanhSachCauHoi.Radius = 5;
			this.pnlDanhSachCauHoi.ShadowColor = System.Drawing.Color.Black;
			this.pnlDanhSachCauHoi.ShadowDepth = 150;
			this.pnlDanhSachCauHoi.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlDanhSachCauHoi.Size = new System.Drawing.Size(300, 400);
			this.pnlDanhSachCauHoi.TabIndex = 3;
			this.pnlDanhSachCauHoi.Click += new System.EventHandler(this.QuizTest_Click);
			// 
			// QuizTest
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlDanhSachCauHoi);
			this.Controls.Add(this.pnlThoiGian);
			this.Controls.Add(this.pnlNopBai);
			this.Controls.Add(this.pNavigation);
			this.Controls.Add(this.pnlAnswer);
			this.Controls.Add(this.pnlCauHoi);
			this.Name = "QuizTest";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmQuiz_Load);
			this.Click += new System.EventHandler(this.QuizTest_Click);
			this.pnlLineDSCH.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnlCauHoi.ResumeLayout(false);
			this.pnlCauHoi.PerformLayout();
			this.pnlAnswer.ResumeLayout(false);
			this.pnlAnswer.PerformLayout();
			this.pNavigation.ResumeLayout(false);
			this.pNavigation.PerformLayout();
			this.pnlNopBai.ResumeLayout(false);
			this.pnlThoiGian.ResumeLayout(false);
			this.pnlDanhSachCauHoi.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RadioButton rbAnswerD;
		private System.Windows.Forms.RadioButton rbAnswerC;
		private System.Windows.Forms.RadioButton rbAnswerB;
		private System.Windows.Forms.RadioButton rbAnswerA;
		private System.Windows.Forms.Label lbNoiDungCauHoi;
		private System.Windows.Forms.RichTextBox rtbQuestionContent;
		private System.Windows.Forms.Panel pnlLineDSCH;
		private System.Windows.Forms.Panel Line;
		private System.Windows.Forms.Label lbDanhSachCauHoi;
		public FontAwesome.Sharp.IconButton btnEnd;
		private FontAwesome.Sharp.IconButton btnReset;
		private System.Windows.Forms.LinkLabel lLuncheck;
		private FontAwesome.Sharp.IconButton btnFlags;
        private FontAwesome.Sharp.IconButton btnLastQuestion;
        private FontAwesome.Sharp.IconButton btnFirstQuestion;
		private FontAwesome.Sharp.IconButton btnPreviousQuestion;
		private FontAwesome.Sharp.IconButton btnNextQuestion;
		private System.Windows.Forms.Label lbNumberQuestion;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.FlowLayoutPanel fLPdata;
		public CircularProgressBar.CircularProgressBar cPBCountDownTime;
		private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCauHoi;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlAnswer;
        private Guna.UI2.WinForms.Guna2ShadowPanel pNavigation;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlNopBai;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlThoiGian;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDanhSachCauHoi;
    }
}