﻿
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
			this.lbTime = new System.Windows.Forms.Label();
			this.lbRemainTime = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbFlag = new System.Windows.Forms.Label();
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
			this.lbSubject = new System.Windows.Forms.Label();
			this.tbDisplayname = new System.Windows.Forms.TextBox();
			this.tbQuestionCount = new System.Windows.Forms.TextBox();
			this.lbDisplayname = new System.Windows.Forms.Label();
			this.lbDoB = new System.Windows.Forms.Label();
			this.lbQuestionCount = new System.Windows.Forms.Label();
			this.tbSubject = new System.Windows.Forms.TextBox();
			this.tbDoB = new System.Windows.Forms.TextBox();
			this.gbUserInfo = new System.Windows.Forms.GroupBox();
			this.pMain.SuspendLayout();
			this.gbTime.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbAnswer.SuspendLayout();
			this.gbProgressQuestion.SuspendLayout();
			this.gbQuestionInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.gbUserInfo.SuspendLayout();
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
			this.pMain.Controls.Add(this.gbUserInfo);
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
			this.gbTime.Controls.Add(this.lbTime);
			this.gbTime.Controls.Add(this.lbRemainTime);
			this.gbTime.Location = new System.Drawing.Point(707, 12);
			this.gbTime.Name = "gbTime";
			this.gbTime.Size = new System.Drawing.Size(342, 75);
			this.gbTime.TabIndex = 7;
			this.gbTime.TabStop = false;
			this.gbTime.Text = "Thời gian";
			// 
			// lbTime
			// 
			this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.Color.Red;
			this.lbTime.Location = new System.Drawing.Point(137, 41);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(68, 26);
			this.lbTime.TabIndex = 1;
			this.lbTime.Text = "00:00";
			this.lbTime.TextChanged += new System.EventHandler(this.lbTime_TextChanged);
			// 
			// lbRemainTime
			// 
			this.lbRemainTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbRemainTime.AutoSize = true;
			this.lbRemainTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRemainTime.ForeColor = System.Drawing.Color.MediumBlue;
			this.lbRemainTime.Location = new System.Drawing.Point(97, 16);
			this.lbRemainTime.Name = "lbRemainTime";
			this.lbRemainTime.Size = new System.Drawing.Size(148, 22);
			this.lbRemainTime.TabIndex = 0;
			this.lbRemainTime.Text = "Thời gian còn lại";
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
			this.panel1.Controls.Add(this.lbFlag);
			this.panel1.Controls.Add(this.btnLastQuestion);
			this.panel1.Controls.Add(this.btnNextQuestion);
			this.panel1.Controls.Add(this.btnPreviousQuestion);
			this.panel1.Controls.Add(this.btnFirstQuestion);
			this.panel1.Location = new System.Drawing.Point(12, 560);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(683, 29);
			this.panel1.TabIndex = 2;
			// 
			// lbFlag
			// 
			this.lbFlag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lbFlag.AutoSize = true;
			this.lbFlag.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFlag.Location = new System.Drawing.Point(545, 8);
			this.lbFlag.Name = "lbFlag";
			this.lbFlag.Size = new System.Drawing.Size(54, 13);
			this.lbFlag.TabIndex = 3;
			this.lbFlag.Text = "Đánh dấu";
			this.toolTipTicked.SetToolTip(this.lbFlag, "Tích để đánh dấu câu hỏi hiện tại!");
			this.lbFlag.MouseEnter += new System.EventHandler(this.lbFlag_MouseEnter);
			this.lbFlag.MouseLeave += new System.EventHandler(this.lbFlag_MouseLeave);
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
			this.gbAnswer.Size = new System.Drawing.Size(683, 225);
			this.gbAnswer.TabIndex = 0;
			this.gbAnswer.TabStop = false;
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
			this.gbProgressQuestion.Location = new System.Drawing.Point(704, 93);
			this.gbProgressQuestion.Name = "gbProgressQuestion";
			this.gbProgressQuestion.Size = new System.Drawing.Size(348, 461);
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
			this.lvData.Size = new System.Drawing.Size(342, 442);
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
			this.gbQuestionInfo.Location = new System.Drawing.Point(12, 93);
			this.gbQuestionInfo.Name = "gbQuestionInfo";
			this.gbQuestionInfo.Size = new System.Drawing.Size(686, 230);
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
			this.rtbQuestionContent.Size = new System.Drawing.Size(674, 156);
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
			// lbSubject
			// 
			this.lbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbSubject.AutoSize = true;
			this.lbSubject.Location = new System.Drawing.Point(41, 49);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(45, 13);
			this.lbSubject.TabIndex = 6;
			this.lbSubject.Text = "Môn thi:";
			// 
			// tbDisplayname
			// 
			this.tbDisplayname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDisplayname.BackColor = System.Drawing.Color.White;
			this.tbDisplayname.Location = new System.Drawing.Point(104, 17);
			this.tbDisplayname.Name = "tbDisplayname";
			this.tbDisplayname.ReadOnly = true;
			this.tbDisplayname.Size = new System.Drawing.Size(159, 20);
			this.tbDisplayname.TabIndex = 8;
			this.tbDisplayname.TabStop = false;
			// 
			// tbQuestionCount
			// 
			this.tbQuestionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbQuestionCount.BackColor = System.Drawing.Color.White;
			this.tbQuestionCount.Location = new System.Drawing.Point(474, 47);
			this.tbQuestionCount.Name = "tbQuestionCount";
			this.tbQuestionCount.ReadOnly = true;
			this.tbQuestionCount.Size = new System.Drawing.Size(159, 20);
			this.tbQuestionCount.TabIndex = 10;
			this.tbQuestionCount.TabStop = false;
			// 
			// lbDisplayname
			// 
			this.lbDisplayname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDisplayname.AutoSize = true;
			this.lbDisplayname.Location = new System.Drawing.Point(41, 20);
			this.lbDisplayname.Name = "lbDisplayname";
			this.lbDisplayname.Size = new System.Drawing.Size(57, 13);
			this.lbDisplayname.TabIndex = 11;
			this.lbDisplayname.Text = "Họ và tên:";
			// 
			// lbDoB
			// 
			this.lbDoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDoB.AutoSize = true;
			this.lbDoB.Location = new System.Drawing.Point(411, 20);
			this.lbDoB.Name = "lbDoB";
			this.lbDoB.Size = new System.Drawing.Size(57, 13);
			this.lbDoB.TabIndex = 12;
			this.lbDoB.Text = "Ngày sinh:";
			// 
			// lbQuestionCount
			// 
			this.lbQuestionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbQuestionCount.AutoSize = true;
			this.lbQuestionCount.Location = new System.Drawing.Point(378, 50);
			this.lbQuestionCount.Name = "lbQuestionCount";
			this.lbQuestionCount.Size = new System.Drawing.Size(90, 13);
			this.lbQuestionCount.TabIndex = 13;
			this.lbQuestionCount.Text = "Số lượng câu hỏi:";
			// 
			// tbSubject
			// 
			this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSubject.BackColor = System.Drawing.Color.White;
			this.tbSubject.Location = new System.Drawing.Point(104, 46);
			this.tbSubject.Name = "tbSubject";
			this.tbSubject.ReadOnly = true;
			this.tbSubject.Size = new System.Drawing.Size(159, 20);
			this.tbSubject.TabIndex = 14;
			this.tbSubject.TabStop = false;
			// 
			// tbDoB
			// 
			this.tbDoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDoB.BackColor = System.Drawing.Color.White;
			this.tbDoB.Location = new System.Drawing.Point(474, 17);
			this.tbDoB.Name = "tbDoB";
			this.tbDoB.ReadOnly = true;
			this.tbDoB.Size = new System.Drawing.Size(159, 20);
			this.tbDoB.TabIndex = 15;
			this.tbDoB.TabStop = false;
			// 
			// gbUserInfo
			// 
			this.gbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gbUserInfo.BackColor = System.Drawing.Color.White;
			this.gbUserInfo.Controls.Add(this.tbDoB);
			this.gbUserInfo.Controls.Add(this.tbSubject);
			this.gbUserInfo.Controls.Add(this.lbQuestionCount);
			this.gbUserInfo.Controls.Add(this.lbDoB);
			this.gbUserInfo.Controls.Add(this.lbDisplayname);
			this.gbUserInfo.Controls.Add(this.tbQuestionCount);
			this.gbUserInfo.Controls.Add(this.tbDisplayname);
			this.gbUserInfo.Controls.Add(this.lbSubject);
			this.gbUserInfo.Location = new System.Drawing.Point(12, 12);
			this.gbUserInfo.Name = "gbUserInfo";
			this.gbUserInfo.Size = new System.Drawing.Size(683, 75);
			this.gbUserInfo.TabIndex = 2;
			this.gbUserInfo.TabStop = false;
			this.gbUserInfo.Text = "Thông tin thí sinh";
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
			this.gbTime.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gbAnswer.ResumeLayout(false);
			this.gbAnswer.PerformLayout();
			this.gbProgressQuestion.ResumeLayout(false);
			this.gbQuestionInfo.ResumeLayout(false);
			this.gbQuestionInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.gbUserInfo.ResumeLayout(false);
			this.gbUserInfo.PerformLayout();
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
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Label lbRemainTime;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lbFlag;
		private System.Windows.Forms.ToolTip toolTipTicked;
		private System.Windows.Forms.GroupBox gbProgressQuestion;
		private System.Windows.Forms.ListView lvData;
		private System.Windows.Forms.GroupBox gbUserInfo;
		private System.Windows.Forms.TextBox tbDoB;
		private System.Windows.Forms.TextBox tbSubject;
		private System.Windows.Forms.Label lbQuestionCount;
		private System.Windows.Forms.Label lbDoB;
		private System.Windows.Forms.Label lbDisplayname;
		private System.Windows.Forms.TextBox tbQuestionCount;
		private System.Windows.Forms.TextBox tbDisplayname;
		private System.Windows.Forms.Label lbSubject;
	}
}