
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pMain = new System.Windows.Forms.Panel();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
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
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBQuizTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.btnClearFilter);
			this.pMain.Controls.Add(this.aDgvdata);
			this.pMain.Controls.Add(this.btnCancle);
			this.pMain.Controls.Add(this.btnSave);
			this.pMain.Controls.Add(this.tbSearch);
			this.pMain.Controls.Add(this.btnSearch);
			this.pMain.Controls.Add(this.btnDelete);
			this.pMain.Controls.Add(this.btnEdit);
			this.pMain.Controls.Add(this.btnAdd);
			this.pMain.Controls.Add(this.lbTitle);
			this.pMain.Controls.Add(this.gbControls);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1264, 681);
			this.pMain.TabIndex = 0;
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.Location = new System.Drawing.Point(317, 346);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
			this.btnClearFilter.TabIndex = 15;
			this.btnClearFilter.Text = "Clear Filter";
			this.btnClearFilter.UseVisualStyleBackColor = true;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			// 
			// aDgvdata
			// 
			this.aDgvdata.AllowUserToAddRows = false;
			this.aDgvdata.AutoGenerateContextFilters = true;
			this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.aDgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.QuestionID,
            this.ExamID,
            this.SubjectID,
            this.QContent,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer});
			this.aDgvdata.DateWithTime = false;
			this.aDgvdata.Location = new System.Drawing.Point(12, 374);
			this.aDgvdata.MultiSelect = false;
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1240, 295);
			this.aDgvdata.TabIndex = 12;
			this.aDgvdata.TimeFilter = false;
			this.aDgvdata.SortStringChanged += new System.EventHandler(this.aDgvdata_SortStringChanged);
			this.aDgvdata.FilterStringChanged += new System.EventHandler(this.aDgvdata_FilterStringChanged);
			this.aDgvdata.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDgvdata_RowEnter);
			this.aDgvdata.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.aDgvdata_RowPrePaint);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.STT.DefaultCellStyle = dataGridViewCellStyle2;
			this.STT.FillWeight = 50.12531F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// QuestionID
			// 
			this.QuestionID.DataPropertyName = "QuestionID";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.QuestionID.DefaultCellStyle = dataGridViewCellStyle3;
			this.QuestionID.FillWeight = 88.00108F;
			this.QuestionID.HeaderText = "Mã câu hỏi";
			this.QuestionID.MinimumWidth = 22;
			this.QuestionID.Name = "QuestionID";
			this.QuestionID.ReadOnly = true;
			this.QuestionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamID
			// 
			this.ExamID.DataPropertyName = "ExamID";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ExamID.DefaultCellStyle = dataGridViewCellStyle4;
			this.ExamID.FillWeight = 94.60631F;
			this.ExamID.HeaderText = "Mã đề";
			this.ExamID.MinimumWidth = 22;
			this.ExamID.Name = "ExamID";
			this.ExamID.ReadOnly = true;
			this.ExamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Format = "d";
			dataGridViewCellStyle5.NullValue = "dd/MM/yyyy";
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SubjectID.DefaultCellStyle = dataGridViewCellStyle5;
			this.SubjectID.FillWeight = 96.78584F;
			this.SubjectID.HeaderText = "Mã môn thi";
			this.SubjectID.MinimumWidth = 22;
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// QContent
			// 
			this.QContent.DataPropertyName = "QContent";
			this.QContent.FillWeight = 171.2383F;
			this.QContent.HeaderText = "Nội dung câu hỏi";
			this.QContent.MinimumWidth = 22;
			this.QContent.Name = "QContent";
			this.QContent.ReadOnly = true;
			this.QContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionA
			// 
			this.OptionA.DataPropertyName = "OptionA";
			this.OptionA.FillWeight = 84.15929F;
			this.OptionA.HeaderText = "Đáp án A";
			this.OptionA.MinimumWidth = 22;
			this.OptionA.Name = "OptionA";
			this.OptionA.ReadOnly = true;
			this.OptionA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionB
			// 
			this.OptionB.DataPropertyName = "OptionB";
			this.OptionB.FillWeight = 86.47492F;
			this.OptionB.HeaderText = "Đáp án B";
			this.OptionB.MinimumWidth = 22;
			this.OptionB.Name = "OptionB";
			this.OptionB.ReadOnly = true;
			this.OptionB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionC
			// 
			this.OptionC.DataPropertyName = "OptionC";
			this.OptionC.FillWeight = 89.49125F;
			this.OptionC.HeaderText = "Đáp án C";
			this.OptionC.MinimumWidth = 22;
			this.OptionC.Name = "OptionC";
			this.OptionC.ReadOnly = true;
			this.OptionC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionD
			// 
			this.OptionD.DataPropertyName = "OptionD";
			this.OptionD.FillWeight = 94.93061F;
			this.OptionD.HeaderText = "Đáp án D";
			this.OptionD.MinimumWidth = 22;
			this.OptionD.Name = "OptionD";
			this.OptionD.ReadOnly = true;
			this.OptionD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Answer
			// 
			this.Answer.DataPropertyName = "Answer";
			this.Answer.FillWeight = 144.187F;
			this.Answer.HeaderText = "Đáp án đúng";
			this.Answer.MinimumWidth = 22;
			this.Answer.Name = "Answer";
			this.Answer.ReadOnly = true;
			this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(635, 319);
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
			this.btnSave.Location = new System.Drawing.Point(554, 319);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(12, 348);
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
			this.btnSearch.Location = new System.Drawing.Point(236, 346);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(676, 318);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(594, 318);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(513, 319);
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
			this.lbTitle.Location = new System.Drawing.Point(538, 14);
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
			this.gbControls.Size = new System.Drawing.Size(1240, 259);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin câu hỏi";
			// 
			// cbExamID
			// 
			this.cbExamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbExamID.FormattingEnabled = true;
			this.cbExamID.Location = new System.Drawing.Point(221, 78);
			this.cbExamID.Name = "cbExamID";
			this.cbExamID.Size = new System.Drawing.Size(159, 21);
			this.cbExamID.TabIndex = 56;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(134, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 55;
			this.label1.Text = "Mã đề:";
			// 
			// tbAnswerCorrect
			// 
			this.tbAnswerCorrect.Location = new System.Drawing.Point(516, 218);
			this.tbAnswerCorrect.Name = "tbAnswerCorrect";
			this.tbAnswerCorrect.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerCorrect.TabIndex = 54;
			// 
			// lbAnswerC
			// 
			this.lbAnswerC.AutoSize = true;
			this.lbAnswerC.Location = new System.Drawing.Point(429, 142);
			this.lbAnswerC.Name = "lbAnswerC";
			this.lbAnswerC.Size = new System.Drawing.Size(55, 13);
			this.lbAnswerC.TabIndex = 52;
			this.lbAnswerC.Text = "Đáp án C:";
			// 
			// lbContent
			// 
			this.lbContent.AutoSize = true;
			this.lbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.lbContent.Location = new System.Drawing.Point(429, 27);
			this.lbContent.Name = "lbContent";
			this.lbContent.Size = new System.Drawing.Size(53, 13);
			this.lbContent.TabIndex = 45;
			this.lbContent.Text = "Nội dung:";
			// 
			// tbAnswerC
			// 
			this.tbAnswerC.Location = new System.Drawing.Point(516, 139);
			this.tbAnswerC.Name = "tbAnswerC";
			this.tbAnswerC.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerC.TabIndex = 53;
			// 
			// tbContent
			// 
			this.tbContent.Location = new System.Drawing.Point(516, 24);
			this.tbContent.Multiline = true;
			this.tbContent.Name = "tbContent";
			this.tbContent.Size = new System.Drawing.Size(590, 57);
			this.tbContent.TabIndex = 46;
			// 
			// lbAnswerB
			// 
			this.lbAnswerB.AutoSize = true;
			this.lbAnswerB.Location = new System.Drawing.Point(429, 116);
			this.lbAnswerB.Name = "lbAnswerB";
			this.lbAnswerB.Size = new System.Drawing.Size(55, 13);
			this.lbAnswerB.TabIndex = 50;
			this.lbAnswerB.Text = "Đáp án B:";
			// 
			// lbAnswerA
			// 
			this.lbAnswerA.AutoSize = true;
			this.lbAnswerA.Location = new System.Drawing.Point(429, 90);
			this.lbAnswerA.Name = "lbAnswerA";
			this.lbAnswerA.Size = new System.Drawing.Size(55, 13);
			this.lbAnswerA.TabIndex = 47;
			this.lbAnswerA.Text = "Đáp án A:";
			// 
			// lbAnswerD
			// 
			this.lbAnswerD.AutoSize = true;
			this.lbAnswerD.Location = new System.Drawing.Point(429, 168);
			this.lbAnswerD.Name = "lbAnswerD";
			this.lbAnswerD.Size = new System.Drawing.Size(56, 13);
			this.lbAnswerD.TabIndex = 43;
			this.lbAnswerD.Text = "Đáp án D:";
			// 
			// tbAnswerB
			// 
			this.tbAnswerB.Location = new System.Drawing.Point(516, 113);
			this.tbAnswerB.Name = "tbAnswerB";
			this.tbAnswerB.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerB.TabIndex = 51;
			// 
			// tbAnswerA
			// 
			this.tbAnswerA.Location = new System.Drawing.Point(516, 87);
			this.tbAnswerA.Name = "tbAnswerA";
			this.tbAnswerA.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerA.TabIndex = 48;
			// 
			// tbAnswerD
			// 
			this.tbAnswerD.Location = new System.Drawing.Point(516, 165);
			this.tbAnswerD.Name = "tbAnswerD";
			this.tbAnswerD.Size = new System.Drawing.Size(590, 20);
			this.tbAnswerD.TabIndex = 44;
			// 
			// lbAnswerCorrect
			// 
			this.lbAnswerCorrect.AutoSize = true;
			this.lbAnswerCorrect.Location = new System.Drawing.Point(429, 221);
			this.lbAnswerCorrect.Name = "lbAnswerCorrect";
			this.lbAnswerCorrect.Size = new System.Drawing.Size(73, 13);
			this.lbAnswerCorrect.TabIndex = 49;
			this.lbAnswerCorrect.Text = "Đáp án đúng:";
			// 
			// pBQuizTime
			// 
			this.pBQuizTime.BackgroundImage = global::Main.Properties.Resources.Quiz;
			this.pBQuizTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pBQuizTime.Location = new System.Drawing.Point(137, 110);
			this.pBQuizTime.Name = "pBQuizTime";
			this.pBQuizTime.Size = new System.Drawing.Size(243, 128);
			this.pBQuizTime.TabIndex = 19;
			this.pBQuizTime.TabStop = false;
			// 
			// cbSubject
			// 
			this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubject.FormattingEnabled = true;
			this.cbSubject.Location = new System.Drawing.Point(221, 51);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(159, 21);
			this.cbSubject.TabIndex = 7;
			this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
			// 
			// lbSubjectID
			// 
			this.lbSubjectID.AutoSize = true;
			this.lbSubjectID.Location = new System.Drawing.Point(134, 54);
			this.lbSubjectID.Name = "lbSubjectID";
			this.lbSubjectID.Size = new System.Drawing.Size(45, 13);
			this.lbSubjectID.TabIndex = 6;
			this.lbSubjectID.Text = "Môn thi:";
			// 
			// lbQuestionID
			// 
			this.lbQuestionID.AutoSize = true;
			this.lbQuestionID.Location = new System.Drawing.Point(134, 28);
			this.lbQuestionID.Name = "lbQuestionID";
			this.lbQuestionID.Size = new System.Drawing.Size(63, 13);
			this.lbQuestionID.TabIndex = 0;
			this.lbQuestionID.Text = "Mã câu hỏi:";
			// 
			// tbQuestionID
			// 
			this.tbQuestionID.Location = new System.Drawing.Point(221, 25);
			this.tbQuestionID.Name = "tbQuestionID";
			this.tbQuestionID.ReadOnly = true;
			this.tbQuestionID.Size = new System.Drawing.Size(159, 20);
			this.tbQuestionID.TabIndex = 1;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// FrmManageQuestion
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.pMain);
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "FrmManageQuestion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý câu hỏi";
			this.Load += new System.EventHandler(this.FrmManageUser_Load);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
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
		private System.Windows.Forms.ComboBox cbExamID;
		private System.Windows.Forms.Label label1;
		private ADGV.AdvancedDataGridView aDgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn QContent;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
		private System.Windows.Forms.Button btnClearFilter;
	}
}