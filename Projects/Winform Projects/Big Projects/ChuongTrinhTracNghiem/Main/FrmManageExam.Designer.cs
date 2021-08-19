
namespace Main
{
	partial class FrmManageExam
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pMain = new System.Windows.Forms.Panel();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QCurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gbControls = new System.Windows.Forms.GroupBox();
			this.lbExamRole = new System.Windows.Forms.Label();
			this.cbExamRole = new System.Windows.Forms.ComboBox();
			this.lbSubject = new System.Windows.Forms.Label();
			this.nudQCount = new System.Windows.Forms.NumericUpDown();
			this.nudExamTime = new System.Windows.Forms.NumericUpDown();
			this.cbSubject = new System.Windows.Forms.ComboBox();
			this.tbExamID = new System.Windows.Forms.TextBox();
			this.lbExamTime = new System.Windows.Forms.Label();
			this.lbQCount = new System.Windows.Forms.Label();
			this.lbExamID = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExamTime)).BeginInit();
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
			this.btnClearFilter.Location = new System.Drawing.Point(277, 258);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
			this.btnClearFilter.TabIndex = 12;
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
            this.ExamID,
            this.SubjectID,
            this.ExamRole,
            this.ExamTime,
            this.QCount,
            this.QCurrentCount});
			this.aDgvdata.DateWithTime = false;
			this.aDgvdata.Location = new System.Drawing.Point(12, 287);
			this.aDgvdata.MultiSelect = false;
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1240, 382);
			this.aDgvdata.TabIndex = 11;
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
			this.STT.FillWeight = 35.08772F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamID
			// 
			this.ExamID.DataPropertyName = "ExamID";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ExamID.DefaultCellStyle = dataGridViewCellStyle3;
			this.ExamID.FillWeight = 105.9323F;
			this.ExamID.HeaderText = "Mã đề";
			this.ExamID.MinimumWidth = 22;
			this.ExamID.Name = "ExamID";
			this.ExamID.ReadOnly = true;
			this.ExamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SubjectID.DefaultCellStyle = dataGridViewCellStyle4;
			this.SubjectID.FillWeight = 101.6086F;
			this.SubjectID.HeaderText = "Môn thi";
			this.SubjectID.MinimumWidth = 22;
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamRole
			// 
			this.ExamRole.DataPropertyName = "ExamRole";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ExamRole.DefaultCellStyle = dataGridViewCellStyle5;
			this.ExamRole.FillWeight = 98.90372F;
			this.ExamRole.HeaderText = "Loại đề";
			this.ExamRole.MinimumWidth = 22;
			this.ExamRole.Name = "ExamRole";
			this.ExamRole.ReadOnly = true;
			this.ExamRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamTime
			// 
			this.ExamTime.DataPropertyName = "ExamTime";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ExamTime.DefaultCellStyle = dataGridViewCellStyle6;
			this.ExamTime.FillWeight = 98.84013F;
			this.ExamTime.HeaderText = "Thời gian làm bài";
			this.ExamTime.MinimumWidth = 22;
			this.ExamTime.Name = "ExamTime";
			this.ExamTime.ReadOnly = true;
			this.ExamTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// QCount
			// 
			this.QCount.DataPropertyName = "QCount";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.QCount.DefaultCellStyle = dataGridViewCellStyle7;
			this.QCount.FillWeight = 108.2887F;
			this.QCount.HeaderText = "Số lượng câu hỏi";
			this.QCount.MinimumWidth = 22;
			this.QCount.Name = "QCount";
			this.QCount.ReadOnly = true;
			this.QCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// QCurrentCount
			// 
			this.QCurrentCount.DataPropertyName = "QCurrentCount";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.QCurrentCount.DefaultCellStyle = dataGridViewCellStyle8;
			this.QCurrentCount.FillWeight = 151.3388F;
			this.QCurrentCount.HeaderText = "Số lượng câu hỏi hiên tại";
			this.QCurrentCount.MinimumWidth = 22;
			this.QCurrentCount.Name = "QCurrentCount";
			this.QCurrentCount.ReadOnly = true;
			this.QCurrentCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(635, 225);
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
			this.btnSave.Location = new System.Drawing.Point(554, 225);
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
			this.tbSearch.Location = new System.Drawing.Point(12, 260);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(178, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập từ khóa ...";
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(196, 258);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(676, 224);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(594, 224);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(513, 225);
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
			this.lbTitle.Location = new System.Drawing.Point(547, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(170, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý đề thi";
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.lbExamRole);
			this.gbControls.Controls.Add(this.cbExamRole);
			this.gbControls.Controls.Add(this.lbSubject);
			this.gbControls.Controls.Add(this.nudQCount);
			this.gbControls.Controls.Add(this.nudExamTime);
			this.gbControls.Controls.Add(this.cbSubject);
			this.gbControls.Controls.Add(this.tbExamID);
			this.gbControls.Controls.Add(this.lbExamTime);
			this.gbControls.Controls.Add(this.lbQCount);
			this.gbControls.Controls.Add(this.lbExamID);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(1240, 159);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin môn thi";
			// 
			// lbExamRole
			// 
			this.lbExamRole.AutoSize = true;
			this.lbExamRole.Location = new System.Drawing.Point(297, 106);
			this.lbExamRole.Name = "lbExamRole";
			this.lbExamRole.Size = new System.Drawing.Size(46, 13);
			this.lbExamRole.TabIndex = 17;
			this.lbExamRole.Text = "Loại đề:";
			// 
			// cbExamRole
			// 
			this.cbExamRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbExamRole.FormattingEnabled = true;
			this.cbExamRole.Location = new System.Drawing.Point(349, 103);
			this.cbExamRole.Name = "cbExamRole";
			this.cbExamRole.Size = new System.Drawing.Size(186, 21);
			this.cbExamRole.TabIndex = 13;
			// 
			// lbSubject
			// 
			this.lbSubject.AutoSize = true;
			this.lbSubject.Location = new System.Drawing.Point(298, 74);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(45, 13);
			this.lbSubject.TabIndex = 16;
			this.lbSubject.Text = "Môn thi:";
			// 
			// nudQCount
			// 
			this.nudQCount.Location = new System.Drawing.Point(757, 67);
			this.nudQCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudQCount.Name = "nudQCount";
			this.nudQCount.Size = new System.Drawing.Size(186, 20);
			this.nudQCount.TabIndex = 15;
			// 
			// nudExamTime
			// 
			this.nudExamTime.Location = new System.Drawing.Point(757, 39);
			this.nudExamTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudExamTime.Name = "nudExamTime";
			this.nudExamTime.Size = new System.Drawing.Size(186, 20);
			this.nudExamTime.TabIndex = 13;
			// 
			// cbSubject
			// 
			this.cbSubject.BackColor = System.Drawing.Color.White;
			this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubject.FormattingEnabled = true;
			this.cbSubject.Location = new System.Drawing.Point(349, 71);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(186, 21);
			this.cbSubject.TabIndex = 12;
			// 
			// tbExamID
			// 
			this.tbExamID.Location = new System.Drawing.Point(349, 38);
			this.tbExamID.Name = "tbExamID";
			this.tbExamID.Size = new System.Drawing.Size(186, 20);
			this.tbExamID.TabIndex = 7;
			// 
			// lbExamTime
			// 
			this.lbExamTime.AutoSize = true;
			this.lbExamTime.Location = new System.Drawing.Point(661, 41);
			this.lbExamTime.Name = "lbExamTime";
			this.lbExamTime.Size = new System.Drawing.Size(90, 13);
			this.lbExamTime.TabIndex = 4;
			this.lbExamTime.Text = "Thời gian làm bài:";
			// 
			// lbQCount
			// 
			this.lbQCount.AutoSize = true;
			this.lbQCount.Location = new System.Drawing.Point(661, 69);
			this.lbQCount.Name = "lbQCount";
			this.lbQCount.Size = new System.Drawing.Size(90, 13);
			this.lbQCount.TabIndex = 2;
			this.lbQCount.Text = "Số lượng câu hỏi:";
			// 
			// lbExamID
			// 
			this.lbExamID.AutoSize = true;
			this.lbExamID.Location = new System.Drawing.Point(302, 41);
			this.lbExamID.Name = "lbExamID";
			this.lbExamID.Size = new System.Drawing.Size(41, 13);
			this.lbExamID.TabIndex = 0;
			this.lbExamID.Text = "Mã đề:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// FrmManageExam
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.pMain);
			this.Name = "FrmManageExam";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý đề thi";
			this.Load += new System.EventHandler(this.FrmManageExam_Load);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			this.gbControls.ResumeLayout(false);
			this.gbControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExamTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.GroupBox gbControls;
		private System.Windows.Forms.Label lbQCount;
		private System.Windows.Forms.Label lbExamID;
		private System.Windows.Forms.Label lbExamTime;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbExamID;
		private System.Windows.Forms.NumericUpDown nudExamTime;
		private System.Windows.Forms.ComboBox cbSubject;
		private System.Windows.Forms.NumericUpDown nudQCount;
		private System.Windows.Forms.Label lbSubject;
		private System.Windows.Forms.Label lbExamRole;
		private System.Windows.Forms.ComboBox cbExamRole;
		private ADGV.AdvancedDataGridView aDgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCurrentCount;
		private System.Windows.Forms.Button btnClearFilter;
	}
}