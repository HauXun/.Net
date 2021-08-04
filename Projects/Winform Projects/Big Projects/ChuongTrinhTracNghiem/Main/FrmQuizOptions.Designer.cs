
namespace Main
{
	partial class FrmQuizOptions
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
			this.btnStartQuiz = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.tbQuizTime = new System.Windows.Forms.TextBox();
			this.lbSubject = new System.Windows.Forms.Label();
			this.lbQuizTime = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.lbQuestionCount = new System.Windows.Forms.Label();
			this.cbSubject = new System.Windows.Forms.ComboBox();
			this.cbQuestionCount = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStartQuiz
			// 
			this.btnStartQuiz.AutoSize = true;
			this.btnStartQuiz.Location = new System.Drawing.Point(92, 180);
			this.btnStartQuiz.Margin = new System.Windows.Forms.Padding(4);
			this.btnStartQuiz.Name = "btnStartQuiz";
			this.btnStartQuiz.Size = new System.Drawing.Size(93, 28);
			this.btnStartQuiz.TabIndex = 8;
			this.btnStartQuiz.Text = "Bắt đầu thi";
			this.btnStartQuiz.UseVisualStyleBackColor = true;
			this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(303, 180);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 28);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(94, 19);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(292, 23);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "TÙY CHỌN CẤU TRÚC BÀI THI";
			// 
			// tbQuizTime
			// 
			this.tbQuizTime.Location = new System.Drawing.Point(174, 138);
			this.tbQuizTime.Margin = new System.Windows.Forms.Padding(4);
			this.tbQuizTime.Name = "tbQuizTime";
			this.tbQuizTime.ReadOnly = true;
			this.tbQuizTime.Size = new System.Drawing.Size(263, 23);
			this.tbQuizTime.TabIndex = 3;
			this.tbQuizTime.UseSystemPasswordChar = true;
			// 
			// lbSubject
			// 
			this.lbSubject.AutoSize = true;
			this.lbSubject.BackColor = System.Drawing.Color.Transparent;
			this.lbSubject.Location = new System.Drawing.Point(44, 60);
			this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(58, 17);
			this.lbSubject.TabIndex = 1;
			this.lbSubject.Text = "Môn thi:";
			// 
			// lbQuizTime
			// 
			this.lbQuizTime.AutoSize = true;
			this.lbQuizTime.BackColor = System.Drawing.Color.Transparent;
			this.lbQuizTime.Location = new System.Drawing.Point(44, 141);
			this.lbQuizTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbQuizTime.Name = "lbQuizTime";
			this.lbQuizTime.Size = new System.Drawing.Size(90, 17);
			this.lbQuizTime.TabIndex = 2;
			this.lbQuizTime.Text = "Thời gian thi:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// lbQuestionCount
			// 
			this.lbQuestionCount.AutoSize = true;
			this.lbQuestionCount.BackColor = System.Drawing.Color.Transparent;
			this.lbQuestionCount.Location = new System.Drawing.Point(44, 100);
			this.lbQuestionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbQuestionCount.Name = "lbQuestionCount";
			this.lbQuestionCount.Size = new System.Drawing.Size(118, 17);
			this.lbQuestionCount.TabIndex = 0;
			this.lbQuestionCount.Text = "Số lượng câu hỏi:";
			// 
			// cbSubject
			// 
			this.cbSubject.FormattingEnabled = true;
			this.cbSubject.Location = new System.Drawing.Point(174, 57);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(263, 24);
			this.cbSubject.TabIndex = 10;
			// 
			// cbQuestionCount
			// 
			this.cbQuestionCount.FormattingEnabled = true;
			this.cbQuestionCount.Location = new System.Drawing.Point(174, 97);
			this.cbQuestionCount.Name = "cbQuestionCount";
			this.cbQuestionCount.Size = new System.Drawing.Size(263, 24);
			this.cbQuestionCount.TabIndex = 11;
			this.cbQuestionCount.SelectedIndexChanged += new System.EventHandler(this.cbQuestionCount_SelectedIndexChanged);
			// 
			// FrmQuizOptions
			// 
			this.AcceptButton = this.btnStartQuiz;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(481, 227);
			this.Controls.Add(this.cbQuestionCount);
			this.Controls.Add(this.cbSubject);
			this.Controls.Add(this.lbQuestionCount);
			this.Controls.Add(this.lbQuizTime);
			this.Controls.Add(this.tbQuizTime);
			this.Controls.Add(this.lbSubject);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnStartQuiz);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(497, 266);
			this.MinimumSize = new System.Drawing.Size(497, 266);
			this.Name = "FrmQuizOptions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cấu trúc bài thi";
			this.Load += new System.EventHandler(this.FrmQuizOptions_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStartQuiz;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lbSubject;
		private System.Windows.Forms.Label lbQuizTime;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Label lbQuestionCount;
		private System.Windows.Forms.ComboBox cbSubject;
		public System.Windows.Forms.TextBox tbQuizTime;
		public System.Windows.Forms.ComboBox cbQuestionCount;
		public System.Windows.Forms.Label lbTitle;
	}
}