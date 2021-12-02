
namespace Main.Pages
{
	partial class QuizResult
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizResult));
			this.pnlLineDSCH = new System.Windows.Forms.Panel();
			this.Line = new System.Windows.Forms.Panel();
			this.lbDanhSachCauHoi = new System.Windows.Forms.Label();
			this.barIndeterminate = new Bunifu.UI.Winforms.BunifuProgressBar();
			this.barUncheck = new Bunifu.UI.Winforms.BunifuProgressBar();
			this.lbIndeterminate = new System.Windows.Forms.Label();
			this.btnIndeterminate = new System.Windows.Forms.Button();
			this.lbUncheck = new System.Windows.Forms.Label();
			this.btnUncheck = new System.Windows.Forms.Button();
			this.barCheck = new Bunifu.UI.Winforms.BunifuProgressBar();
			this.lbCheck = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.cPBCountDownTime = new CircularProgressBar.CircularProgressBar();
			this.lbCorrectNumber = new System.Windows.Forms.Label();
			this.lbTitleResult = new System.Windows.Forms.Label();
			this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
			this.lbCongratulation = new System.Windows.Forms.Label();
			this.pnlResult = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pnlThoiGian = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.fLPdata = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlLineDSCH.SuspendLayout();
			this.pnlResult.SuspendLayout();
			this.pnlThoiGian.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlLineDSCH
			// 
			this.pnlLineDSCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLineDSCH.BackColor = System.Drawing.Color.Transparent;
			this.pnlLineDSCH.Controls.Add(this.Line);
			this.pnlLineDSCH.Controls.Add(this.lbDanhSachCauHoi);
			this.pnlLineDSCH.Location = new System.Drawing.Point(1120, 3);
			this.pnlLineDSCH.Name = "pnlLineDSCH";
			this.pnlLineDSCH.Size = new System.Drawing.Size(403, 51);
			this.pnlLineDSCH.TabIndex = 0;
			this.pnlLineDSCH.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// Line
			// 
			this.Line.BackColor = System.Drawing.Color.Black;
			this.Line.Location = new System.Drawing.Point(26, 47);
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(350, 1);
			this.Line.TabIndex = 0;
			this.Line.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// lbDanhSachCauHoi
			// 
			this.lbDanhSachCauHoi.BackColor = System.Drawing.Color.Transparent;
			this.lbDanhSachCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbDanhSachCauHoi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDanhSachCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbDanhSachCauHoi.Location = new System.Drawing.Point(0, 0);
			this.lbDanhSachCauHoi.Name = "lbDanhSachCauHoi";
			this.lbDanhSachCauHoi.Size = new System.Drawing.Size(403, 44);
			this.lbDanhSachCauHoi.TabIndex = 0;
			this.lbDanhSachCauHoi.Text = "Sơ đồ câu hỏi";
			this.lbDanhSachCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbDanhSachCauHoi.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// barIndeterminate
			// 
			this.barIndeterminate.Animation = 100;
			this.barIndeterminate.AnimationStep = 5;
			this.barIndeterminate.BackColor = System.Drawing.Color.Transparent;
			this.barIndeterminate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barIndeterminate.BackgroundImage")));
			this.barIndeterminate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barIndeterminate.BorderRadius = 10;
			this.barIndeterminate.BorderThickness = 5;
			this.barIndeterminate.Location = new System.Drawing.Point(168, 189);
			this.barIndeterminate.MaximumValue = 100;
			this.barIndeterminate.MinimumValue = 0;
			this.barIndeterminate.Name = "barIndeterminate";
			this.barIndeterminate.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barIndeterminate.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
			this.barIndeterminate.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
			this.barIndeterminate.Size = new System.Drawing.Size(317, 23);
			this.barIndeterminate.TabIndex = 0;
			this.barIndeterminate.TabStop = false;
			this.barIndeterminate.Value = 100;
			this.barIndeterminate.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// barUncheck
			// 
			this.barUncheck.Animation = 100;
			this.barUncheck.AnimationStep = 5;
			this.barUncheck.BackColor = System.Drawing.Color.Transparent;
			this.barUncheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barUncheck.BackgroundImage")));
			this.barUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barUncheck.BorderRadius = 10;
			this.barUncheck.BorderThickness = 5;
			this.barUncheck.Location = new System.Drawing.Point(168, 109);
			this.barUncheck.MaximumValue = 100;
			this.barUncheck.MinimumValue = 0;
			this.barUncheck.Name = "barUncheck";
			this.barUncheck.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barUncheck.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.barUncheck.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.barUncheck.Size = new System.Drawing.Size(317, 23);
			this.barUncheck.TabIndex = 0;
			this.barUncheck.TabStop = false;
			this.barUncheck.Value = 100;
			this.barUncheck.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// lbIndeterminate
			// 
			this.lbIndeterminate.AutoSize = true;
			this.lbIndeterminate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIndeterminate.ForeColor = System.Drawing.Color.DimGray;
			this.lbIndeterminate.Location = new System.Drawing.Point(486, 189);
			this.lbIndeterminate.Name = "lbIndeterminate";
			this.lbIndeterminate.Size = new System.Drawing.Size(63, 23);
			this.lbIndeterminate.TabIndex = 0;
			this.lbIndeterminate.Text = "-10%";
			this.lbIndeterminate.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// btnIndeterminate
			// 
			this.btnIndeterminate.BackColor = System.Drawing.Color.Transparent;
			this.btnIndeterminate.FlatAppearance.BorderSize = 0;
			this.btnIndeterminate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnIndeterminate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnIndeterminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIndeterminate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIndeterminate.Location = new System.Drawing.Point(12, 175);
			this.btnIndeterminate.Name = "btnIndeterminate";
			this.btnIndeterminate.Size = new System.Drawing.Size(150, 50);
			this.btnIndeterminate.TabIndex = 0;
			this.btnIndeterminate.TabStop = false;
			this.btnIndeterminate.Text = "Indeterminate";
			this.btnIndeterminate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIndeterminate.UseVisualStyleBackColor = false;
			this.btnIndeterminate.Click += new System.EventHandler(this.QuizResult_Click);
			this.btnIndeterminate.Enter += new System.EventHandler(this.btnCheck_Enter);
			// 
			// lbUncheck
			// 
			this.lbUncheck.AutoSize = true;
			this.lbUncheck.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUncheck.ForeColor = System.Drawing.Color.DimGray;
			this.lbUncheck.Location = new System.Drawing.Point(486, 109);
			this.lbUncheck.Name = "lbUncheck";
			this.lbUncheck.Size = new System.Drawing.Size(63, 23);
			this.lbUncheck.TabIndex = 0;
			this.lbUncheck.Text = "-10%";
			this.lbUncheck.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// btnUncheck
			// 
			this.btnUncheck.BackColor = System.Drawing.Color.Transparent;
			this.btnUncheck.FlatAppearance.BorderSize = 0;
			this.btnUncheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnUncheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnUncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUncheck.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUncheck.Location = new System.Drawing.Point(12, 95);
			this.btnUncheck.Name = "btnUncheck";
			this.btnUncheck.Size = new System.Drawing.Size(150, 50);
			this.btnUncheck.TabIndex = 0;
			this.btnUncheck.TabStop = false;
			this.btnUncheck.Text = "Uncheck";
			this.btnUncheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUncheck.UseVisualStyleBackColor = false;
			this.btnUncheck.Click += new System.EventHandler(this.QuizResult_Click);
			this.btnUncheck.Enter += new System.EventHandler(this.btnCheck_Enter);
			// 
			// barCheck
			// 
			this.barCheck.Animation = 100;
			this.barCheck.AnimationStep = 5;
			this.barCheck.BackColor = System.Drawing.Color.Transparent;
			this.barCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barCheck.BackgroundImage")));
			this.barCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barCheck.BorderRadius = 10;
			this.barCheck.BorderThickness = 5;
			this.barCheck.Location = new System.Drawing.Point(167, 28);
			this.barCheck.MaximumValue = 100;
			this.barCheck.MinimumValue = 0;
			this.barCheck.Name = "barCheck";
			this.barCheck.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barCheck.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.barCheck.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.barCheck.Size = new System.Drawing.Size(318, 23);
			this.barCheck.TabIndex = 0;
			this.barCheck.TabStop = false;
			this.barCheck.Value = 100;
			this.barCheck.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// lbCheck
			// 
			this.lbCheck.AutoSize = true;
			this.lbCheck.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCheck.ForeColor = System.Drawing.Color.DimGray;
			this.lbCheck.Location = new System.Drawing.Point(486, 29);
			this.lbCheck.Name = "lbCheck";
			this.lbCheck.Size = new System.Drawing.Size(63, 23);
			this.lbCheck.TabIndex = 0;
			this.lbCheck.Text = "-10%";
			this.lbCheck.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// btnCheck
			// 
			this.btnCheck.BackColor = System.Drawing.Color.Transparent;
			this.btnCheck.FlatAppearance.BorderSize = 0;
			this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheck.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheck.Location = new System.Drawing.Point(12, 15);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(150, 50);
			this.btnCheck.TabIndex = 0;
			this.btnCheck.TabStop = false;
			this.btnCheck.Text = "Check";
			this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCheck.UseVisualStyleBackColor = false;
			this.btnCheck.Click += new System.EventHandler(this.QuizResult_Click);
			this.btnCheck.Enter += new System.EventHandler(this.btnCheck_Enter);
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
			this.cPBCountDownTime.Location = new System.Drawing.Point(457, 100);
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
			this.cPBCountDownTime.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// lbCorrectNumber
			// 
			this.lbCorrectNumber.AutoSize = true;
			this.lbCorrectNumber.BackColor = System.Drawing.Color.Transparent;
			this.lbCorrectNumber.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCorrectNumber.Location = new System.Drawing.Point(524, 350);
			this.lbCorrectNumber.Name = "lbCorrectNumber";
			this.lbCorrectNumber.Size = new System.Drawing.Size(86, 25);
			this.lbCorrectNumber.TabIndex = 0;
			this.lbCorrectNumber.Text = "06/82";
			this.lbCorrectNumber.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// lbTitleResult
			// 
			this.lbTitleResult.AutoSize = true;
			this.lbTitleResult.BackColor = System.Drawing.Color.Transparent;
			this.lbTitleResult.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitleResult.Location = new System.Drawing.Point(473, 323);
			this.lbTitleResult.Name = "lbTitleResult";
			this.lbTitleResult.Size = new System.Drawing.Size(190, 23);
			this.lbTitleResult.TabIndex = 0;
			this.lbTitleResult.Text = "Số câu hoàn thành";
			this.lbTitleResult.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// btnTrangChu
			// 
			this.btnTrangChu.Animated = true;
			this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
			this.btnTrangChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnTrangChu.BorderRadius = 5;
			this.btnTrangChu.BorderThickness = 1;
			this.btnTrangChu.CheckedState.Parent = this.btnTrangChu;
			this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTrangChu.CustomImages.Parent = this.btnTrangChu;
			this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTrangChu.DisabledState.Parent = this.btnTrangChu;
			this.btnTrangChu.FillColor = System.Drawing.Color.White;
			this.btnTrangChu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnTrangChu.HoverState.Parent = this.btnTrangChu;
			this.btnTrangChu.Location = new System.Drawing.Point(497, 699);
			this.btnTrangChu.Name = "btnTrangChu";
			this.btnTrangChu.ShadowDecoration.Parent = this.btnTrangChu;
			this.btnTrangChu.Size = new System.Drawing.Size(127, 35);
			this.btnTrangChu.TabIndex = 0;
			this.btnTrangChu.TabStop = false;
			this.btnTrangChu.Text = "Trang chủ";
			this.btnTrangChu.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// lbCongratulation
			// 
			this.lbCongratulation.AutoSize = true;
			this.lbCongratulation.BackColor = System.Drawing.Color.Transparent;
			this.lbCongratulation.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCongratulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbCongratulation.Location = new System.Drawing.Point(328, 375);
			this.lbCongratulation.Name = "lbCongratulation";
			this.lbCongratulation.Size = new System.Drawing.Size(472, 29);
			this.lbCongratulation.TabIndex = 0;
			this.lbCongratulation.Text = "Chúc mừng bạn đã hoàn thành bài thi!";
			this.lbCongratulation.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// pnlResult
			// 
			this.pnlResult.BackColor = System.Drawing.Color.Transparent;
			this.pnlResult.Controls.Add(this.barIndeterminate);
			this.pnlResult.Controls.Add(this.barCheck);
			this.pnlResult.Controls.Add(this.barUncheck);
			this.pnlResult.Controls.Add(this.btnCheck);
			this.pnlResult.Controls.Add(this.lbIndeterminate);
			this.pnlResult.Controls.Add(this.lbCheck);
			this.pnlResult.Controls.Add(this.btnIndeterminate);
			this.pnlResult.Controls.Add(this.btnUncheck);
			this.pnlResult.Controls.Add(this.lbUncheck);
			this.pnlResult.FillColor = System.Drawing.Color.White;
			this.pnlResult.Location = new System.Drawing.Point(282, 421);
			this.pnlResult.Name = "pnlResult";
			this.pnlResult.Radius = 5;
			this.pnlResult.ShadowColor = System.Drawing.Color.Black;
			this.pnlResult.ShadowDepth = 255;
			this.pnlResult.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlResult.Size = new System.Drawing.Size(560, 240);
			this.pnlResult.TabIndex = 0;
			this.pnlResult.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// pnlThoiGian
			// 
			this.pnlThoiGian.BackColor = System.Drawing.Color.Transparent;
			this.pnlThoiGian.Controls.Add(this.fLPdata);
			this.pnlThoiGian.FillColor = System.Drawing.Color.White;
			this.pnlThoiGian.Location = new System.Drawing.Point(1120, 60);
			this.pnlThoiGian.Name = "pnlThoiGian";
			this.pnlThoiGian.Radius = 5;
			this.pnlThoiGian.ShadowColor = System.Drawing.Color.Black;
			this.pnlThoiGian.ShadowDepth = 255;
			this.pnlThoiGian.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlThoiGian.Size = new System.Drawing.Size(400, 738);
			this.pnlThoiGian.TabIndex = 38;
			this.pnlThoiGian.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// fLPdata
			// 
			this.fLPdata.BackColor = System.Drawing.Color.Transparent;
			this.fLPdata.Location = new System.Drawing.Point(2, 2);
			this.fLPdata.Name = "fLPdata";
			this.fLPdata.Size = new System.Drawing.Size(392, 729);
			this.fLPdata.TabIndex = 0;
			this.fLPdata.Click += new System.EventHandler(this.QuizResult_Click);
			// 
			// QuizResult
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlThoiGian);
			this.Controls.Add(this.pnlResult);
			this.Controls.Add(this.btnTrangChu);
			this.Controls.Add(this.pnlLineDSCH);
			this.Controls.Add(this.cPBCountDownTime);
			this.Controls.Add(this.lbCorrectNumber);
			this.Controls.Add(this.lbTitleResult);
			this.Controls.Add(this.lbCongratulation);
			this.Name = "QuizResult";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmQuizResult_Load);
			this.Click += new System.EventHandler(this.QuizResult_Click);
			this.pnlLineDSCH.ResumeLayout(false);
			this.pnlResult.ResumeLayout(false);
			this.pnlResult.PerformLayout();
			this.pnlThoiGian.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlLineDSCH;
		private System.Windows.Forms.Panel Line;
		private System.Windows.Forms.Label lbDanhSachCauHoi;
		private Bunifu.UI.Winforms.BunifuProgressBar barIndeterminate;
		private Bunifu.UI.Winforms.BunifuProgressBar barUncheck;
		private System.Windows.Forms.Label lbIndeterminate;
		private System.Windows.Forms.Button btnIndeterminate;
		private System.Windows.Forms.Label lbUncheck;
		private System.Windows.Forms.Button btnUncheck;
		private Bunifu.UI.Winforms.BunifuProgressBar barCheck;
		private System.Windows.Forms.Label lbCheck;
		private System.Windows.Forms.Button btnCheck;
		public CircularProgressBar.CircularProgressBar cPBCountDownTime;
		private System.Windows.Forms.Label lbCorrectNumber;
		private System.Windows.Forms.Label lbTitleResult;
		public Guna.UI2.WinForms.Guna2Button btnTrangChu;
		private System.Windows.Forms.Label lbCongratulation;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlResult;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlThoiGian;
		public System.Windows.Forms.FlowLayoutPanel fLPdata;
	}
}