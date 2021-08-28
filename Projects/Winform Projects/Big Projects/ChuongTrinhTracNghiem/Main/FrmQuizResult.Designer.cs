
namespace Main
{
	partial class FrmQuizResult
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
			this.gbProgressQuestion = new System.Windows.Forms.GroupBox();
			this.fLPdata = new System.Windows.Forms.FlowLayoutPanel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.fLPResult = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.lbCongratulation = new System.Windows.Forms.Label();
			this.lbCorrectNumber = new System.Windows.Forms.Label();
			this.lbTitleResult = new System.Windows.Forms.Label();
			this.cPBCountDownTime = new CircularProgressBar.CircularProgressBar();
			this.toolTipState = new System.Windows.Forms.ToolTip(this.components);
			this.gbProgressQuestion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbProgressQuestion
			// 
			this.gbProgressQuestion.BackColor = System.Drawing.SystemColors.Control;
			this.gbProgressQuestion.Controls.Add(this.fLPdata);
			this.gbProgressQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbProgressQuestion.Location = new System.Drawing.Point(0, 0);
			this.gbProgressQuestion.Name = "gbProgressQuestion";
			this.gbProgressQuestion.Size = new System.Drawing.Size(350, 681);
			this.gbProgressQuestion.TabIndex = 4;
			this.gbProgressQuestion.TabStop = false;
			this.gbProgressQuestion.Text = "Chi tiết kết quả";
			// 
			// fLPdata
			// 
			this.fLPdata.AutoScroll = true;
			this.fLPdata.BackColor = System.Drawing.Color.White;
			this.fLPdata.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fLPdata.Location = new System.Drawing.Point(3, 16);
			this.fLPdata.Name = "fLPdata";
			this.fLPdata.Size = new System.Drawing.Size(344, 662);
			this.fLPdata.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.fLPResult);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.lbCongratulation);
			this.splitContainer1.Panel1.Controls.Add(this.lbCorrectNumber);
			this.splitContainer1.Panel1.Controls.Add(this.lbTitleResult);
			this.splitContainer1.Panel1.Controls.Add(this.cPBCountDownTime);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gbProgressQuestion);
			this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
			this.splitContainer1.SplitterDistance = 910;
			this.splitContainer1.TabIndex = 5;
			// 
			// fLPResult
			// 
			this.fLPResult.Location = new System.Drawing.Point(286, 372);
			this.fLPResult.Name = "fLPResult";
			this.fLPResult.Size = new System.Drawing.Size(338, 154);
			this.fLPResult.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(414, 580);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Trang chủ";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lbCongratulation
			// 
			this.lbCongratulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbCongratulation.AutoSize = true;
			this.lbCongratulation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCongratulation.Location = new System.Drawing.Point(307, 323);
			this.lbCongratulation.Name = "lbCongratulation";
			this.lbCongratulation.Size = new System.Drawing.Size(297, 19);
			this.lbCongratulation.TabIndex = 11;
			this.lbCongratulation.Text = "Chúc mừng bạn đã hoàn thành bài thi";
			// 
			// lbCorrectNumber
			// 
			this.lbCorrectNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbCorrectNumber.AutoSize = true;
			this.lbCorrectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCorrectNumber.Location = new System.Drawing.Point(422, 289);
			this.lbCorrectNumber.Name = "lbCorrectNumber";
			this.lbCorrectNumber.Size = new System.Drawing.Size(67, 25);
			this.lbCorrectNumber.TabIndex = 10;
			this.lbCorrectNumber.Text = "06/82";
			// 
			// lbTitleResult
			// 
			this.lbTitleResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTitleResult.AutoSize = true;
			this.lbTitleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitleResult.Location = new System.Drawing.Point(391, 263);
			this.lbTitleResult.Name = "lbTitleResult";
			this.lbTitleResult.Size = new System.Drawing.Size(128, 17);
			this.lbTitleResult.TabIndex = 9;
			this.lbTitleResult.Text = "Số câu hoàn thành";
			// 
			// cPBCountDownTime
			// 
			this.cPBCountDownTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cPBCountDownTime.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.cPBCountDownTime.AnimationSpeed = 500;
			this.cPBCountDownTime.BackColor = System.Drawing.Color.Transparent;
			this.cPBCountDownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.cPBCountDownTime.ForeColor = System.Drawing.Color.White;
			this.cPBCountDownTime.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.cPBCountDownTime.InnerMargin = 2;
			this.cPBCountDownTime.InnerWidth = -1;
			this.cPBCountDownTime.Location = new System.Drawing.Point(357, 78);
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
			this.cPBCountDownTime.TabIndex = 8;
			this.cPBCountDownTime.Text = "00:00:00";
			this.cPBCountDownTime.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cPBCountDownTime.Value = 68;
			// 
			// toolTipState
			// 
			this.toolTipState.AutomaticDelay = 0;
			this.toolTipState.AutoPopDelay = 10000;
			this.toolTipState.InitialDelay = 0;
			this.toolTipState.ReshowDelay = 0;
			// 
			// FrmQuizResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.splitContainer1);
			this.Name = "FrmQuizResult";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmQuizResult";
			this.Load += new System.EventHandler(this.FrmQuizResult_Load);
			this.gbProgressQuestion.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox gbProgressQuestion;
		private System.Windows.Forms.FlowLayoutPanel fLPdata;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbCongratulation;
		private System.Windows.Forms.Label lbCorrectNumber;
		private System.Windows.Forms.Label lbTitleResult;
		private CircularProgressBar.CircularProgressBar cPBCountDownTime;
		private System.Windows.Forms.ToolTip toolTipState;
		private System.Windows.Forms.FlowLayoutPanel fLPResult;
	}
}