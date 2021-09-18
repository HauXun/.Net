﻿
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
			this.pnlResult = new System.Windows.Forms.Panel();
			this.barIndeterminate = new Bunifu.UI.Winforms.BunifuProgressBar();
			this.barUncheck = new Bunifu.UI.Winforms.BunifuProgressBar();
			this.lbIndeterminate = new System.Windows.Forms.Label();
			this.btnIndeterminate = new System.Windows.Forms.Button();
			this.lbUncheck = new System.Windows.Forms.Label();
			this.btnUncheck = new System.Windows.Forms.Button();
			this.barCheck = new Bunifu.UI.Winforms.BunifuProgressBar();
			this.lbCheck = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.fLPdata = new System.Windows.Forms.FlowLayoutPanel();
			this.cPBCountDownTime = new CircularProgressBar.CircularProgressBar();
			this.lbCorrectNumber = new System.Windows.Forms.Label();
			this.lbTitleResult = new System.Windows.Forms.Label();
			this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
			this.lbCongratulation = new System.Windows.Forms.Label();
			this.pnlKetQuaShadow = new System.Windows.Forms.Panel();
			this.pnlDataShadow = new System.Windows.Forms.Panel();
			this.pnlLineDSCH.SuspendLayout();
			this.pnlResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlLineDSCH
			// 
			this.pnlLineDSCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLineDSCH.BackColor = System.Drawing.Color.Transparent;
			this.pnlLineDSCH.Controls.Add(this.Line);
			this.pnlLineDSCH.Controls.Add(this.lbDanhSachCauHoi);
			this.pnlLineDSCH.Location = new System.Drawing.Point(1093, 3);
			this.pnlLineDSCH.Name = "pnlLineDSCH";
			this.pnlLineDSCH.Size = new System.Drawing.Size(454, 51);
			this.pnlLineDSCH.TabIndex = 35;
			// 
			// Line
			// 
			this.Line.BackColor = System.Drawing.Color.Black;
			this.Line.Location = new System.Drawing.Point(52, 47);
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(350, 1);
			this.Line.TabIndex = 0;
			// 
			// lbDanhSachCauHoi
			// 
			this.lbDanhSachCauHoi.BackColor = System.Drawing.Color.Transparent;
			this.lbDanhSachCauHoi.Font = new System.Drawing.Font("Arial", 18F);
			this.lbDanhSachCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbDanhSachCauHoi.Location = new System.Drawing.Point(3, 0);
			this.lbDanhSachCauHoi.Name = "lbDanhSachCauHoi";
			this.lbDanhSachCauHoi.Size = new System.Drawing.Size(440, 44);
			this.lbDanhSachCauHoi.TabIndex = 25;
			this.lbDanhSachCauHoi.Text = "Sơ đồ câu hỏi";
			this.lbDanhSachCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlResult
			// 
			this.pnlResult.BackColor = System.Drawing.Color.White;
			this.pnlResult.Controls.Add(this.barIndeterminate);
			this.pnlResult.Controls.Add(this.barUncheck);
			this.pnlResult.Controls.Add(this.lbIndeterminate);
			this.pnlResult.Controls.Add(this.btnIndeterminate);
			this.pnlResult.Controls.Add(this.lbUncheck);
			this.pnlResult.Controls.Add(this.btnUncheck);
			this.pnlResult.Controls.Add(this.barCheck);
			this.pnlResult.Controls.Add(this.lbCheck);
			this.pnlResult.Controls.Add(this.btnCheck);
			this.pnlResult.Location = new System.Drawing.Point(282, 421);
			this.pnlResult.Name = "pnlResult";
			this.pnlResult.Size = new System.Drawing.Size(560, 243);
			this.pnlResult.TabIndex = 34;
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
			this.barIndeterminate.Location = new System.Drawing.Point(177, 192);
			this.barIndeterminate.MaximumValue = 100;
			this.barIndeterminate.MinimumValue = 0;
			this.barIndeterminate.Name = "barIndeterminate";
			this.barIndeterminate.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barIndeterminate.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
			this.barIndeterminate.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.barIndeterminate.Size = new System.Drawing.Size(317, 23);
			this.barIndeterminate.TabIndex = 29;
			this.barIndeterminate.Value = 100;
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
			this.barUncheck.Location = new System.Drawing.Point(177, 112);
			this.barUncheck.MaximumValue = 100;
			this.barUncheck.MinimumValue = 0;
			this.barUncheck.Name = "barUncheck";
			this.barUncheck.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barUncheck.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.barUncheck.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.barUncheck.Size = new System.Drawing.Size(317, 23);
			this.barUncheck.TabIndex = 28;
			this.barUncheck.Value = 100;
			// 
			// lbIndeterminate
			// 
			this.lbIndeterminate.AutoSize = true;
			this.lbIndeterminate.Font = new System.Drawing.Font("Arial", 14F);
			this.lbIndeterminate.ForeColor = System.Drawing.Color.DimGray;
			this.lbIndeterminate.Location = new System.Drawing.Point(500, 192);
			this.lbIndeterminate.Name = "lbIndeterminate";
			this.lbIndeterminate.Size = new System.Drawing.Size(55, 22);
			this.lbIndeterminate.TabIndex = 27;
			this.lbIndeterminate.Text = "-10%";
			// 
			// btnIndeterminate
			// 
			this.btnIndeterminate.BackColor = System.Drawing.Color.Transparent;
			this.btnIndeterminate.FlatAppearance.BorderSize = 0;
			this.btnIndeterminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIndeterminate.Font = new System.Drawing.Font("Arial", 14F);
			this.btnIndeterminate.Location = new System.Drawing.Point(21, 178);
			this.btnIndeterminate.Name = "btnIndeterminate";
			this.btnIndeterminate.Size = new System.Drawing.Size(150, 50);
			this.btnIndeterminate.TabIndex = 25;
			this.btnIndeterminate.Text = "Indeterminate";
			this.btnIndeterminate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIndeterminate.UseVisualStyleBackColor = false;
			// 
			// lbUncheck
			// 
			this.lbUncheck.AutoSize = true;
			this.lbUncheck.Font = new System.Drawing.Font("Arial", 14F);
			this.lbUncheck.ForeColor = System.Drawing.Color.DimGray;
			this.lbUncheck.Location = new System.Drawing.Point(500, 112);
			this.lbUncheck.Name = "lbUncheck";
			this.lbUncheck.Size = new System.Drawing.Size(55, 22);
			this.lbUncheck.TabIndex = 24;
			this.lbUncheck.Text = "-10%";
			// 
			// btnUncheck
			// 
			this.btnUncheck.BackColor = System.Drawing.Color.Transparent;
			this.btnUncheck.FlatAppearance.BorderSize = 0;
			this.btnUncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUncheck.Font = new System.Drawing.Font("Arial", 14F);
			this.btnUncheck.Location = new System.Drawing.Point(21, 98);
			this.btnUncheck.Name = "btnUncheck";
			this.btnUncheck.Size = new System.Drawing.Size(150, 50);
			this.btnUncheck.TabIndex = 22;
			this.btnUncheck.Text = "Uncheck";
			this.btnUncheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUncheck.UseVisualStyleBackColor = false;
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
			this.barCheck.Location = new System.Drawing.Point(176, 31);
			this.barCheck.MaximumValue = 100;
			this.barCheck.MinimumValue = 0;
			this.barCheck.Name = "barCheck";
			this.barCheck.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barCheck.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.barCheck.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.barCheck.Size = new System.Drawing.Size(318, 23);
			this.barCheck.TabIndex = 20;
			this.barCheck.Value = 100;
			// 
			// lbCheck
			// 
			this.lbCheck.AutoSize = true;
			this.lbCheck.Font = new System.Drawing.Font("Arial", 14F);
			this.lbCheck.ForeColor = System.Drawing.Color.DimGray;
			this.lbCheck.Location = new System.Drawing.Point(500, 32);
			this.lbCheck.Name = "lbCheck";
			this.lbCheck.Size = new System.Drawing.Size(55, 22);
			this.lbCheck.TabIndex = 21;
			this.lbCheck.Text = "-10%";
			// 
			// btnCheck
			// 
			this.btnCheck.BackColor = System.Drawing.Color.Transparent;
			this.btnCheck.FlatAppearance.BorderSize = 0;
			this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheck.Font = new System.Drawing.Font("Arial", 14F);
			this.btnCheck.Location = new System.Drawing.Point(21, 18);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(150, 50);
			this.btnCheck.TabIndex = 18;
			this.btnCheck.Text = "Check";
			this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCheck.UseVisualStyleBackColor = false;
			// 
			// fLPdata
			// 
			this.fLPdata.AutoScroll = true;
			this.fLPdata.BackColor = System.Drawing.Color.White;
			this.fLPdata.Location = new System.Drawing.Point(1114, 60);
			this.fLPdata.Name = "fLPdata";
			this.fLPdata.Size = new System.Drawing.Size(413, 738);
			this.fLPdata.TabIndex = 27;
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
			this.cPBCountDownTime.Location = new System.Drawing.Point(458, 100);
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
			this.cPBCountDownTime.TabIndex = 33;
			this.cPBCountDownTime.Text = "00:00:00";
			this.cPBCountDownTime.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cPBCountDownTime.Value = 68;
			// 
			// lbCorrectNumber
			// 
			this.lbCorrectNumber.AutoSize = true;
			this.lbCorrectNumber.BackColor = System.Drawing.Color.Transparent;
			this.lbCorrectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
			this.lbCorrectNumber.Location = new System.Drawing.Point(524, 349);
			this.lbCorrectNumber.Name = "lbCorrectNumber";
			this.lbCorrectNumber.Size = new System.Drawing.Size(92, 32);
			this.lbCorrectNumber.TabIndex = 32;
			this.lbCorrectNumber.Text = "06/82";
			// 
			// lbTitleResult
			// 
			this.lbTitleResult.AutoSize = true;
			this.lbTitleResult.BackColor = System.Drawing.Color.Transparent;
			this.lbTitleResult.Font = new System.Drawing.Font("Arial", 14F);
			this.lbTitleResult.Location = new System.Drawing.Point(486, 323);
			this.lbTitleResult.Name = "lbTitleResult";
			this.lbTitleResult.Size = new System.Drawing.Size(165, 22);
			this.lbTitleResult.TabIndex = 31;
			this.lbTitleResult.Text = "Số câu hoàn thành";
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
			this.btnTrangChu.Font = new System.Drawing.Font("Arial", 14.25F);
			this.btnTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnTrangChu.HoverState.Parent = this.btnTrangChu;
			this.btnTrangChu.Location = new System.Drawing.Point(497, 699);
			this.btnTrangChu.Name = "btnTrangChu";
			this.btnTrangChu.ShadowDecoration.Parent = this.btnTrangChu;
			this.btnTrangChu.Size = new System.Drawing.Size(127, 35);
			this.btnTrangChu.TabIndex = 28;
			this.btnTrangChu.TabStop = false;
			this.btnTrangChu.Text = "Trang chủ";
			// 
			// lbCongratulation
			// 
			this.lbCongratulation.AutoSize = true;
			this.lbCongratulation.BackColor = System.Drawing.Color.Transparent;
			this.lbCongratulation.Font = new System.Drawing.Font("Arial", 18F);
			this.lbCongratulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbCongratulation.Location = new System.Drawing.Point(353, 381);
			this.lbCongratulation.Name = "lbCongratulation";
			this.lbCongratulation.Size = new System.Drawing.Size(431, 27);
			this.lbCongratulation.TabIndex = 30;
			this.lbCongratulation.Text = "Chúc mừng bạn đã hoàn thành bài thi!";
			// 
			// pnlKetQuaShadow
			// 
			this.pnlKetQuaShadow.BackColor = System.Drawing.Color.Silver;
			this.pnlKetQuaShadow.Location = new System.Drawing.Point(285, 424);
			this.pnlKetQuaShadow.Name = "pnlKetQuaShadow";
			this.pnlKetQuaShadow.Size = new System.Drawing.Size(560, 243);
			this.pnlKetQuaShadow.TabIndex = 29;
			// 
			// pnlDataShadow
			// 
			this.pnlDataShadow.BackColor = System.Drawing.Color.Silver;
			this.pnlDataShadow.Location = new System.Drawing.Point(1117, 63);
			this.pnlDataShadow.Name = "pnlDataShadow";
			this.pnlDataShadow.Size = new System.Drawing.Size(413, 738);
			this.pnlDataShadow.TabIndex = 36;
			// 
			// QuizResult
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.btnTrangChu);
			this.Controls.Add(this.fLPdata);
			this.Controls.Add(this.pnlDataShadow);
			this.Controls.Add(this.pnlLineDSCH);
			this.Controls.Add(this.pnlResult);
			this.Controls.Add(this.cPBCountDownTime);
			this.Controls.Add(this.lbCorrectNumber);
			this.Controls.Add(this.lbTitleResult);
			this.Controls.Add(this.lbCongratulation);
			this.Controls.Add(this.pnlKetQuaShadow);
			this.Name = "QuizResult";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmQuizResult_Load);
			this.pnlLineDSCH.ResumeLayout(false);
			this.pnlResult.ResumeLayout(false);
			this.pnlResult.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlLineDSCH;
		private System.Windows.Forms.Panel Line;
		private System.Windows.Forms.Label lbDanhSachCauHoi;
		private System.Windows.Forms.Panel pnlResult;
		private Bunifu.UI.Winforms.BunifuProgressBar barIndeterminate;
		private Bunifu.UI.Winforms.BunifuProgressBar barUncheck;
		private System.Windows.Forms.Label lbIndeterminate;
		private System.Windows.Forms.Button btnIndeterminate;
		private System.Windows.Forms.Label lbUncheck;
		private System.Windows.Forms.Button btnUncheck;
		private Bunifu.UI.Winforms.BunifuProgressBar barCheck;
		private System.Windows.Forms.Label lbCheck;
		private System.Windows.Forms.Button btnCheck;
		public System.Windows.Forms.FlowLayoutPanel fLPdata;
		public CircularProgressBar.CircularProgressBar cPBCountDownTime;
		private System.Windows.Forms.Label lbCorrectNumber;
		private System.Windows.Forms.Label lbTitleResult;
		public Guna.UI2.WinForms.Guna2Button btnTrangChu;
		private System.Windows.Forms.Label lbCongratulation;
		private System.Windows.Forms.Panel pnlKetQuaShadow;
		private System.Windows.Forms.Panel pnlDataShadow;
	}
}