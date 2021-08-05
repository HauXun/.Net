
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
			this.pMain = new System.Windows.Forms.Panel();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gbControls = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.nudQCount = new System.Windows.Forms.NumericUpDown();
			this.nudQCurrentCount = new System.Windows.Forms.NumericUpDown();
			this.nudExamTime = new System.Windows.Forms.NumericUpDown();
			this.cbSubject = new System.Windows.Forms.ComboBox();
			this.lbQCurrentCount = new System.Windows.Forms.Label();
			this.tbExamID = new System.Windows.Forms.TextBox();
			this.lbExamTime = new System.Windows.Forms.Label();
			this.lbQCount = new System.Windows.Forms.Label();
			this.lbExamID = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QCurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQCurrentCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExamTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
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
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(892, 484);
			this.pMain.TabIndex = 0;
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(449, 181);
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
			this.btnSave.Location = new System.Drawing.Point(368, 181);
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ExamID,
            this.SubjectID,
            this.ExamTime,
            this.QCount,
            this.QCurrentCount});
			this.dgvData.Location = new System.Drawing.Point(12, 255);
			this.dgvData.Name = "dgvData";
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(868, 219);
			this.dgvData.TabIndex = 7;
			this.dgvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowEnter);
			this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(12, 228);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(178, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập mã đề thi/Mã môn ...";
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(196, 226);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(490, 180);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(408, 180);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(327, 181);
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
			this.lbTitle.Location = new System.Drawing.Point(361, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(170, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý đề thi";
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.label1);
			this.gbControls.Controls.Add(this.nudQCount);
			this.gbControls.Controls.Add(this.nudQCurrentCount);
			this.gbControls.Controls.Add(this.nudExamTime);
			this.gbControls.Controls.Add(this.cbSubject);
			this.gbControls.Controls.Add(this.lbQCurrentCount);
			this.gbControls.Controls.Add(this.tbExamID);
			this.gbControls.Controls.Add(this.lbExamTime);
			this.gbControls.Controls.Add(this.lbQCount);
			this.gbControls.Controls.Add(this.lbExamID);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(868, 123);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin môn thi";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(459, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Môn thi:";
			// 
			// nudQCount
			// 
			this.nudQCount.Location = new System.Drawing.Point(726, 72);
			this.nudQCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudQCount.Name = "nudQCount";
			this.nudQCount.Size = new System.Drawing.Size(66, 20);
			this.nudQCount.TabIndex = 15;
			// 
			// nudQCurrentCount
			// 
			this.nudQCurrentCount.Location = new System.Drawing.Point(468, 72);
			this.nudQCurrentCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudQCurrentCount.Name = "nudQCurrentCount";
			this.nudQCurrentCount.Size = new System.Drawing.Size(66, 20);
			this.nudQCurrentCount.TabIndex = 14;
			// 
			// nudExamTime
			// 
			this.nudExamTime.Location = new System.Drawing.Point(172, 70);
			this.nudExamTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudExamTime.Name = "nudExamTime";
			this.nudExamTime.Size = new System.Drawing.Size(66, 20);
			this.nudExamTime.TabIndex = 13;
			// 
			// cbSubject
			// 
			this.cbSubject.FormattingEnabled = true;
			this.cbSubject.Location = new System.Drawing.Point(527, 32);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(186, 21);
			this.cbSubject.TabIndex = 12;
			// 
			// lbQCurrentCount
			// 
			this.lbQCurrentCount.AutoSize = true;
			this.lbQCurrentCount.Location = new System.Drawing.Point(335, 74);
			this.lbQCurrentCount.Name = "lbQCurrentCount";
			this.lbQCurrentCount.Size = new System.Drawing.Size(127, 13);
			this.lbQCurrentCount.TabIndex = 8;
			this.lbQCurrentCount.Text = "Số lượng câu hỏi hiện tại:";
			// 
			// tbExamID
			// 
			this.tbExamID.Location = new System.Drawing.Point(203, 32);
			this.tbExamID.Name = "tbExamID";
			this.tbExamID.Size = new System.Drawing.Size(186, 20);
			this.tbExamID.TabIndex = 7;
			// 
			// lbExamTime
			// 
			this.lbExamTime.AutoSize = true;
			this.lbExamTime.Location = new System.Drawing.Point(76, 72);
			this.lbExamTime.Name = "lbExamTime";
			this.lbExamTime.Size = new System.Drawing.Size(90, 13);
			this.lbExamTime.TabIndex = 4;
			this.lbExamTime.Text = "Thời gian làm bài:";
			// 
			// lbQCount
			// 
			this.lbQCount.AutoSize = true;
			this.lbQCount.Location = new System.Drawing.Point(630, 74);
			this.lbQCount.Name = "lbQCount";
			this.lbQCount.Size = new System.Drawing.Size(90, 13);
			this.lbQCount.TabIndex = 2;
			this.lbQCount.Text = "Số lượng câu hỏi:";
			// 
			// lbExamID
			// 
			this.lbExamID.AutoSize = true;
			this.lbExamID.Location = new System.Drawing.Point(156, 35);
			this.lbExamID.Name = "lbExamID";
			this.lbExamID.Size = new System.Drawing.Size(41, 13);
			this.lbExamID.TabIndex = 0;
			this.lbExamID.Text = "Mã đề:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle2;
			this.STT.FillWeight = 53.39415F;
			this.STT.HeaderText = "STT";
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			// 
			// ExamID
			// 
			this.ExamID.DataPropertyName = "ExamID";
			this.ExamID.FillWeight = 92.19705F;
			this.ExamID.HeaderText = "Mã đề";
			this.ExamID.Name = "ExamID";
			this.ExamID.ReadOnly = true;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			this.SubjectID.FillWeight = 92.62172F;
			this.SubjectID.HeaderText = "Mã môn thi";
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			// 
			// ExamTime
			// 
			this.ExamTime.DataPropertyName = "ExamTime";
			this.ExamTime.FillWeight = 98.41006F;
			this.ExamTime.HeaderText = "Thời gian làm bài";
			this.ExamTime.Name = "ExamTime";
			this.ExamTime.ReadOnly = true;
			// 
			// QCount
			// 
			this.QCount.DataPropertyName = "QCount";
			this.QCount.FillWeight = 93.69563F;
			this.QCount.HeaderText = "Số lượng câu hỏi";
			this.QCount.Name = "QCount";
			this.QCount.ReadOnly = true;
			// 
			// QCurrentCount
			// 
			this.QCurrentCount.DataPropertyName = "QCurrentCount";
			this.QCurrentCount.FillWeight = 95.61374F;
			this.QCurrentCount.HeaderText = "Số lượng câu hỏi hiện tại";
			this.QCurrentCount.Name = "QCurrentCount";
			this.QCurrentCount.ReadOnly = true;
			// 
			// FrmManageExam
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 484);
			this.Controls.Add(this.pMain);
			this.MaximumSize = new System.Drawing.Size(908, 523);
			this.MinimumSize = new System.Drawing.Size(908, 523);
			this.Name = "FrmManageExam";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý đề thi";
			this.Load += new System.EventHandler(this.FrmManageExam_Load);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.gbControls.ResumeLayout(false);
			this.gbControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQCurrentCount)).EndInit();
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
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbExamID;
		private System.Windows.Forms.Label lbQCurrentCount;
		private System.Windows.Forms.NumericUpDown nudExamTime;
		private System.Windows.Forms.ComboBox cbSubject;
		private System.Windows.Forms.NumericUpDown nudQCount;
		private System.Windows.Forms.NumericUpDown nudQCurrentCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCurrentCount;
	}
}