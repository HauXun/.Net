
namespace Main
{
	partial class FrmManageQuestion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pMain = new System.Windows.Forms.Panel();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gbControls = new System.Windows.Forms.GroupBox();
			this.cbExamID = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbAnswerCorrect = new System.Windows.Forms.TextBox();
			this.lbAnswerC = new System.Windows.Forms.Label();
			this.lbContent = new System.Windows.Forms.Label();
			this.tbAnswerC = new System.Windows.Forms.TextBox();
			this.tbContent = new System.Windows.Forms.TextBox();
			this.lbAnswerB = new System.Windows.Forms.Label();
			this.lbAnswerA = new System.Windows.Forms.Label();
			this.lbAnswerD = new System.Windows.Forms.Label();
			this.tbAnswerB = new System.Windows.Forms.TextBox();
			this.tbAnswerA = new System.Windows.Forms.TextBox();
			this.tbAnswerD = new System.Windows.Forms.TextBox();
			this.lbAnswerCorrect = new System.Windows.Forms.Label();
			this.pBQuizTime = new System.Windows.Forms.PictureBox();
			this.cbSubject = new System.Windows.Forms.ComboBox();
			this.lbSubjectID = new System.Windows.Forms.Label();
			this.lbQuestionID = new System.Windows.Forms.Label();
			this.tbQuestionID = new System.Windows.Forms.TextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.cbExamIDFilter = new System.Windows.Forms.ComboBox();
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBQuizTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.cbExamIDFilter);
			this.pMain.Controls.Add(this.cbFilter);
			this.pMain.Controls.Add(this.btnCancle);
			this.pMain.Controls.Add(this.btnSave);
			this.pMain.Controls.Add(this.dgvData);
			this.pMain.Controls.Add(this.tbSearch);
			this.pMain.Controls.Add(this.btnSearch);
			this.pMain.Controls.Add(this.btnDelete);
			this.pMain.Controls.Add(this.btnEdit);
			this.pMain.Controls.Add(this.btnAdd);
			this.pMain.Controls.Add(this.lbTitle);
			this.pMain.Controls.Add(this.gbControls);
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1064, 601);
			this.pMain.TabIndex = 0;
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(535, 317);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(75, 23);
			this.btnCancle.TabIndex = 9;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.UseVisualStyleBackColor = true;
			this.btnCancle.Visible = false;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(454, 317);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.QuestionID,
            this.SubjectID,
            this.ExamID,
            this.QContent,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer});
			this.dgvData.Location = new System.Drawing.Point(12, 374);
			this.dgvData.Name = "dgvData";
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(1040, 215);
			this.dgvData.TabIndex = 7;
			this.dgvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowEnter);
			this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle5;
			this.STT.FillWeight = 36.10833F;
			this.STT.HeaderText = "STT";
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			// 
			// QuestionID
			// 
			this.QuestionID.DataPropertyName = "QuestionID";
			this.QuestionID.FillWeight = 89.88013F;
			this.QuestionID.HeaderText = "Mã câu hỏi";
			this.QuestionID.Name = "QuestionID";
			this.QuestionID.ReadOnly = true;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			this.SubjectID.FillWeight = 93.85126F;
			this.SubjectID.HeaderText = "Mã môn thi";
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			// 
			// ExamID
			// 
			this.ExamID.DataPropertyName = "ExamID";
			this.ExamID.HeaderText = "Mã đề";
			this.ExamID.Name = "ExamID";
			this.ExamID.ReadOnly = true;
			// 
			// QContent
			// 
			this.QContent.DataPropertyName = "QContent";
			this.QContent.FillWeight = 185.3935F;
			this.QContent.HeaderText = "Nội dung câu hỏi";
			this.QContent.Name = "QContent";
			this.QContent.ReadOnly = true;
			// 
			// OptionA
			// 
			this.OptionA.DataPropertyName = "OptionA";
			this.OptionA.FillWeight = 84.1683F;
			this.OptionA.HeaderText = "Đáp án A";
			this.OptionA.Name = "OptionA";
			this.OptionA.ReadOnly = true;
			// 
			// OptionB
			// 
			this.OptionB.DataPropertyName = "OptionB";
			this.OptionB.FillWeight = 84.06059F;
			this.OptionB.HeaderText = "Đáp án B";
			this.OptionB.Name = "OptionB";
			this.OptionB.ReadOnly = true;
			// 
			// OptionC
			// 
			this.OptionC.DataPropertyName = "OptionC";
			this.OptionC.FillWeight = 85.71218F;
			this.OptionC.HeaderText = "Đáp án C";
			this.OptionC.Name = "OptionC";
			this.OptionC.ReadOnly = true;
			// 
			// OptionD
			// 
			this.OptionD.DataPropertyName = "OptionD";
			this.OptionD.FillWeight = 90.38728F;
			this.OptionD.HeaderText = "Đáp án D";
			this.OptionD.Name = "OptionD";
			this.OptionD.ReadOnly = true;
			// 
			// Answer
			// 
			this.Answer.DataPropertyName = "Answer";
			dataGridViewCellStyle6.Format = "d";
			dataGridViewCellStyle6.NullValue = "dd/MM/yyyy";
			this.Answer.DefaultCellStyle = dataGridViewCellStyle6;
			this.Answer.FillWeight = 150.4384F;
			this.Answer.HeaderText = "Đáp án đúng";
			this.Answer.Name = "Answer";
			this.Answer.ReadOnly = true;
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(365, 348);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(218, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập từ khóa ...";
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(589, 346);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(576, 316);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(494, 316);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(413, 317);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(438, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(188, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý câu hỏi";
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.cbExamID);
			this.gbControls.Controls.Add(this.label1);
			this.gbControls.Controls.Add(this.tbAnswerCorrect);
			this.gbControls.Controls.Add(this.lbAnswerC);
			this.gbControls.Controls.Add(this.lbContent);
			this.gbControls.Controls.Add(this.tbAnswerC);
			this.gbControls.Controls.Add(this.tbContent);
			this.gbControls.Controls.Add(this.lbAnswerB);
			this.gbControls.Controls.Add(this.lbAnswerA);
			this.gbControls.Controls.Add(this.lbAnswerD);
			this.gbControls.Controls.Add(this.tbAnswerB);
			this.gbControls.Controls.Add(this.tbAnswerA);
			this.gbControls.Controls.Add(this.tbAnswerD);
			this.gbControls.Controls.Add(this.lbAnswerCorrect);
			this.gbControls.Controls.Add(this.pBQuizTime);
			this.gbControls.Controls.Add(this.cbSubject);
			this.gbControls.Controls.Add(this.lbSubjectID);
			this.gbControls.Controls.Add(this.lbQuestionID);
			this.gbControls.Controls.Add(this.tbQuestionID);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(1040, 259);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin câu hỏi";
			// 
			// cbExamID
			// 
			this.cbExamID.FormattingEnabled = true;
			this.cbExamID.Location = new System.Drawing.Point(120, 78);
			this.cbExamID.Name = "cbExamID";
			this.cbExamID.Size = new System.Drawing.Size(159, 21);
			this.cbExamID.TabIndex = 56;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 55;
			this.label1.Text = "Mã đề:";
			// 
			// tbAnswerCorrect
			// 
			this.tbAnswerCorrect.Location = new System.Drawing.Point(415, 218);
			this.tbAnswerCorrect.Name = "tbAnswerCorrect";
			this.tbAnswerCorrect.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerCorrect.TabIndex = 54;
			// 
			// lbAnswerC
			// 
			this.lbAnswerC.AutoSize = true;
			this.lbAnswerC.Location = new System.Drawing.Point(328, 142);
			this.lbAnswerC.Name = "lbAnswerC";
			this.lbAnswerC.Size = new System.Drawing.Size(55, 13);
			this.lbAnswerC.TabIndex = 52;
			this.lbAnswerC.Text = "Đáp án C:";
			// 
			// lbContent
			// 
			this.lbContent.AutoSize = true;
			this.lbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.lbContent.Location = new System.Drawing.Point(328, 27);
			this.lbContent.Name = "lbContent";
			this.lbContent.Size = new System.Drawing.Size(53, 13);
			this.lbContent.TabIndex = 45;
			this.lbContent.Text = "Nội dung:";
			// 
			// tbAnswerC
			// 
			this.tbAnswerC.Location = new System.Drawing.Point(415, 139);
			this.tbAnswerC.Name = "tbAnswerC";
			this.tbAnswerC.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerC.TabIndex = 53;
			// 
			// tbContent
			// 
			this.tbContent.Location = new System.Drawing.Point(415, 24);
			this.tbContent.Multiline = true;
			this.tbContent.Name = "tbContent";
			this.tbContent.Size = new System.Drawing.Size(590, 57);
			this.tbContent.TabIndex = 46;
			// 
			// lbAnswerB
			// 
			this.lbAnswerB.AutoSize = true;
			this.lbAnswerB.Location = new System.Drawing.Point(328, 116);
			this.lbAnswerB.Name = "lbAnswerB";
			this.lbAnswerB.Size = new System.Drawing.Size(55, 13);
			this.lbAnswerB.TabIndex = 50;
			this.lbAnswerB.Text = "Đáp án B:";
			// 
			// lbAnswerA
			// 
			this.lbAnswerA.AutoSize = true;
			this.lbAnswerA.Location = new System.Drawing.Point(328, 90);
			this.lbAnswerA.Name = "lbAnswerA";
			this.lbAnswerA.Size = new System.Drawing.Size(55, 13);
			this.lbAnswerA.TabIndex = 47;
			this.lbAnswerA.Text = "Đáp án A:";
			// 
			// lbAnswerD
			// 
			this.lbAnswerD.AutoSize = true;
			this.lbAnswerD.Location = new System.Drawing.Point(328, 168);
			this.lbAnswerD.Name = "lbAnswerD";
			this.lbAnswerD.Size = new System.Drawing.Size(56, 13);
			this.lbAnswerD.TabIndex = 43;
			this.lbAnswerD.Text = "Đáp án D:";
			// 
			// tbAnswerB
			// 
			this.tbAnswerB.Location = new System.Drawing.Point(415, 113);
			this.tbAnswerB.Name = "tbAnswerB";
			this.tbAnswerB.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerB.TabIndex = 51;
			// 
			// tbAnswerA
			// 
			this.tbAnswerA.Location = new System.Drawing.Point(415, 87);
			this.tbAnswerA.Name = "tbAnswerA";
			this.tbAnswerA.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerA.TabIndex = 48;
			// 
			// tbAnswerD
			// 
			this.tbAnswerD.Location = new System.Drawing.Point(415, 165);
			this.tbAnswerD.Name = "tbAnswerD";
			this.tbAnswerD.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerD.TabIndex = 44;
			// 
			// lbAnswerCorrect
			// 
			this.lbAnswerCorrect.AutoSize = true;
			this.lbAnswerCorrect.Location = new System.Drawing.Point(328, 221);
			this.lbAnswerCorrect.Name = "lbAnswerCorrect";
			this.lbAnswerCorrect.Size = new System.Drawing.Size(73, 13);
			this.lbAnswerCorrect.TabIndex = 49;
			this.lbAnswerCorrect.Text = "Đáp án đúng:";
			// 
			// pBQuizTime
			// 
			this.pBQuizTime.BackgroundImage = global::Main.Properties.Resources.Quiz;
			this.pBQuizTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pBQuizTime.Location = new System.Drawing.Point(36, 110);
			this.pBQuizTime.Name = "pBQuizTime";
			this.pBQuizTime.Size = new System.Drawing.Size(243, 128);
			this.pBQuizTime.TabIndex = 19;
			this.pBQuizTime.TabStop = false;
			// 
			// cbSubject
			// 
			this.cbSubject.FormattingEnabled = true;
			this.cbSubject.Location = new System.Drawing.Point(120, 51);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(159, 21);
			this.cbSubject.TabIndex = 7;
			this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
			// 
			// lbSubjectID
			// 
			this.lbSubjectID.AutoSize = true;
			this.lbSubjectID.Location = new System.Drawing.Point(33, 54);
			this.lbSubjectID.Name = "lbSubjectID";
			this.lbSubjectID.Size = new System.Drawing.Size(45, 13);
			this.lbSubjectID.TabIndex = 6;
			this.lbSubjectID.Text = "Môn thi:";
			// 
			// lbQuestionID
			// 
			this.lbQuestionID.AutoSize = true;
			this.lbQuestionID.Location = new System.Drawing.Point(33, 28);
			this.lbQuestionID.Name = "lbQuestionID";
			this.lbQuestionID.Size = new System.Drawing.Size(63, 13);
			this.lbQuestionID.TabIndex = 0;
			this.lbQuestionID.Text = "Mã câu hỏi:";
			// 
			// tbQuestionID
			// 
			this.tbQuestionID.Location = new System.Drawing.Point(120, 25);
			this.tbQuestionID.Name = "tbQuestionID";
			this.tbQuestionID.ReadOnly = true;
			this.tbQuestionID.Size = new System.Drawing.Size(159, 20);
			this.tbQuestionID.TabIndex = 1;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// cbFilter
			// 
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(12, 347);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(220, 21);
			this.cbFilter.TabIndex = 10;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
			// 
			// cbExamIDFilter
			// 
			this.cbExamIDFilter.FormattingEnabled = true;
			this.cbExamIDFilter.Location = new System.Drawing.Point(238, 348);
			this.cbExamIDFilter.Name = "cbExamIDFilter";
			this.cbExamIDFilter.Size = new System.Drawing.Size(121, 21);
			this.cbExamIDFilter.TabIndex = 11;
			// 
			// FrmManageQuestion
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 601);
			this.Controls.Add(this.pMain);
			this.MinimumSize = new System.Drawing.Size(1080, 640);
			this.Name = "FrmManageQuestion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý môn thi";
			this.Load += new System.EventHandler(this.FrmManageUser_Load);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.gbControls.ResumeLayout(false);
			this.gbControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBQuizTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.GroupBox gbControls;
		private System.Windows.Forms.Label lbSubjectID;
		private System.Windows.Forms.Label lbQuestionID;
		private System.Windows.Forms.TextBox tbQuestionID;
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbSubject;
		private System.Windows.Forms.PictureBox pBQuizTime;
		private System.Windows.Forms.TextBox tbAnswerCorrect;
		private System.Windows.Forms.Label lbAnswerC;
		private System.Windows.Forms.Label lbContent;
		private System.Windows.Forms.TextBox tbAnswerC;
		private System.Windows.Forms.TextBox tbContent;
		private System.Windows.Forms.Label lbAnswerB;
		private System.Windows.Forms.Label lbAnswerA;
		private System.Windows.Forms.Label lbAnswerD;
		private System.Windows.Forms.TextBox tbAnswerB;
		private System.Windows.Forms.TextBox tbAnswerA;
		private System.Windows.Forms.TextBox tbAnswerD;
		private System.Windows.Forms.Label lbAnswerCorrect;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
		private System.Windows.Forms.DataGridViewTextBoxColumn QContent;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
		private System.Windows.Forms.ComboBox cbExamID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.ComboBox cbExamIDFilter;
	}
}