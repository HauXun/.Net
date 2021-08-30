
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
			this.lbSubject = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.cbSubject = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbInform = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStartQuiz
			// 
			this.btnStartQuiz.AutoSize = true;
			this.btnStartQuiz.Location = new System.Drawing.Point(92, 180);
			this.btnStartQuiz.Margin = new System.Windows.Forms.Padding(4);
			this.btnStartQuiz.Name = "btnStartQuiz";
			this.btnStartQuiz.Size = new System.Drawing.Size(93, 28);
			this.btnStartQuiz.TabIndex = 3;
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
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
			// lbSubject
			// 
			this.lbSubject.AutoSize = true;
			this.lbSubject.BackColor = System.Drawing.Color.Transparent;
			this.lbSubject.Location = new System.Drawing.Point(66, 140);
			this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(58, 17);
			this.lbSubject.TabIndex = 2;
			this.lbSubject.Text = "Môn thi:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// cbSubject
			// 
			this.cbSubject.FormattingEnabled = true;
			this.cbSubject.Location = new System.Drawing.Point(151, 137);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(263, 24);
			this.cbSubject.TabIndex = 5;
			this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::Main.Properties.Resources.QuizInform;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(12, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 78);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// lbInform
			// 
			this.lbInform.BackColor = System.Drawing.Color.Transparent;
			this.lbInform.Location = new System.Drawing.Point(148, 67);
			this.lbInform.Name = "lbInform";
			this.lbInform.Size = new System.Drawing.Size(300, 56);
			this.lbInform.TabIndex = 1;
			this.lbInform.Text = "Chào Cheems! Hãy lựa chọn môn thi của mình để bắt đầu luyện tập ngay nào! 🙇‍♂️🙇" +
    "‍♂️🙇‍♂️";
			// 
			// FrmQuizOptions
			// 
			this.AcceptButton = this.btnStartQuiz;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(481, 227);
			this.Controls.Add(this.lbInform);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cbSubject);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStartQuiz;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lbSubject;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.ComboBox cbSubject;
		public System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbInform;
	}
}