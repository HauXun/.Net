
namespace Main
{
	partial class FrmManageSubject
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
			this.pMain = new System.Windows.Forms.Panel();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gbControls = new System.Windows.Forms.GroupBox();
			this.lbSemesterID = new System.Windows.Forms.Label();
			this.cbSemesterID = new System.Windows.Forms.ComboBox();
			this.lbCourseID = new System.Windows.Forms.Label();
			this.cbCourseID = new System.Windows.Forms.ComboBox();
			this.lbFacultyID = new System.Windows.Forms.Label();
			this.cbFacultyID = new System.Windows.Forms.ComboBox();
			this.lbSubjectRole = new System.Windows.Forms.Label();
			this.cbSubjectRole = new System.Windows.Forms.ComboBox();
			this.tbSubjectID = new System.Windows.Forms.TextBox();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.lbDescription = new System.Windows.Forms.Label();
			this.lbSubjectName = new System.Windows.Forms.Label();
			this.tbSubjectName = new System.Windows.Forms.TextBox();
			this.lbSubjectID = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.aDgvdata);
			this.pMain.Controls.Add(this.btnClearFilter);
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
            this.SubjectName,
            this.SubjectID,
            this.SubjectRole,
            this.FacultyID,
            this.CourseID,
            this.SemesterID,
            this.Description});
			this.aDgvdata.DateWithTime = false;
			this.aDgvdata.Location = new System.Drawing.Point(12, 349);
			this.aDgvdata.MultiSelect = false;
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1240, 320);
			this.aDgvdata.TabIndex = 16;
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
			this.STT.FillWeight = 48.21364F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectName
			// 
			this.SubjectName.DataPropertyName = "SubjectName";
			this.SubjectName.FillWeight = 199.8646F;
			this.SubjectName.HeaderText = "Tên môn thi";
			this.SubjectName.MinimumWidth = 22;
			this.SubjectName.Name = "SubjectName";
			this.SubjectName.ReadOnly = true;
			this.SubjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SubjectID.DefaultCellStyle = dataGridViewCellStyle3;
			this.SubjectID.FillWeight = 68.20206F;
			this.SubjectID.HeaderText = "Mã môn thi";
			this.SubjectID.MinimumWidth = 22;
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectRole
			// 
			this.SubjectRole.DataPropertyName = "SubjectRole";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SubjectRole.DefaultCellStyle = dataGridViewCellStyle4;
			this.SubjectRole.FillWeight = 64.41651F;
			this.SubjectRole.HeaderText = "Kiểu môn";
			this.SubjectRole.MinimumWidth = 22;
			this.SubjectRole.Name = "SubjectRole";
			this.SubjectRole.ReadOnly = true;
			this.SubjectRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// FacultyID
			// 
			this.FacultyID.DataPropertyName = "FacultyID";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.FacultyID.DefaultCellStyle = dataGridViewCellStyle5;
			this.FacultyID.FillWeight = 68.10554F;
			this.FacultyID.HeaderText = "Thuộc khoa";
			this.FacultyID.MinimumWidth = 22;
			this.FacultyID.Name = "FacultyID";
			this.FacultyID.ReadOnly = true;
			this.FacultyID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// CourseID
			// 
			this.CourseID.DataPropertyName = "CourseID";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CourseID.DefaultCellStyle = dataGridViewCellStyle6;
			this.CourseID.FillWeight = 75.93941F;
			this.CourseID.HeaderText = "Dành cho khóa";
			this.CourseID.MinimumWidth = 22;
			this.CourseID.Name = "CourseID";
			this.CourseID.ReadOnly = true;
			this.CourseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SemesterID
			// 
			this.SemesterID.DataPropertyName = "SemesterID";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SemesterID.DefaultCellStyle = dataGridViewCellStyle7;
			this.SemesterID.FillWeight = 74.77821F;
			this.SemesterID.HeaderText = "Thuộc học kì";
			this.SemesterID.MinimumWidth = 22;
			this.SemesterID.Name = "SemesterID";
			this.SemesterID.ReadOnly = true;
			this.SemesterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.FillWeight = 224.9333F;
			this.Description.HeaderText = "Mô tả";
			this.Description.MinimumWidth = 22;
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.Location = new System.Drawing.Point(324, 320);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
			this.btnClearFilter.TabIndex = 15;
			this.btnClearFilter.Text = "Clear Filter";
			this.btnClearFilter.UseVisualStyleBackColor = true;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(635, 284);
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
			this.btnSave.Location = new System.Drawing.Point(554, 284);
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
			this.tbSearch.Location = new System.Drawing.Point(12, 322);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(225, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập từ khóa ...";
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(243, 320);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(676, 283);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(594, 283);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(513, 284);
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
			this.lbTitle.Location = new System.Drawing.Point(536, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(192, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý môn thi";
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.lbSemesterID);
			this.gbControls.Controls.Add(this.cbSemesterID);
			this.gbControls.Controls.Add(this.lbCourseID);
			this.gbControls.Controls.Add(this.cbCourseID);
			this.gbControls.Controls.Add(this.lbFacultyID);
			this.gbControls.Controls.Add(this.cbFacultyID);
			this.gbControls.Controls.Add(this.lbSubjectRole);
			this.gbControls.Controls.Add(this.cbSubjectRole);
			this.gbControls.Controls.Add(this.tbSubjectID);
			this.gbControls.Controls.Add(this.tbDescription);
			this.gbControls.Controls.Add(this.lbDescription);
			this.gbControls.Controls.Add(this.lbSubjectName);
			this.gbControls.Controls.Add(this.tbSubjectName);
			this.gbControls.Controls.Add(this.lbSubjectID);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(1240, 210);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin môn thi";
			// 
			// lbSemesterID
			// 
			this.lbSemesterID.AutoSize = true;
			this.lbSemesterID.Location = new System.Drawing.Point(836, 100);
			this.lbSemesterID.Name = "lbSemesterID";
			this.lbSemesterID.Size = new System.Drawing.Size(73, 13);
			this.lbSemesterID.TabIndex = 15;
			this.lbSemesterID.Text = "Thuộc học kì:";
			// 
			// cbSemesterID
			// 
			this.cbSemesterID.FormattingEnabled = true;
			this.cbSemesterID.Location = new System.Drawing.Point(915, 97);
			this.cbSemesterID.Name = "cbSemesterID";
			this.cbSemesterID.Size = new System.Drawing.Size(239, 21);
			this.cbSemesterID.TabIndex = 14;
			// 
			// lbCourseID
			// 
			this.lbCourseID.AutoSize = true;
			this.lbCourseID.Location = new System.Drawing.Point(457, 100);
			this.lbCourseID.Name = "lbCourseID";
			this.lbCourseID.Size = new System.Drawing.Size(84, 13);
			this.lbCourseID.TabIndex = 13;
			this.lbCourseID.Text = "Dành cho khóa:";
			// 
			// cbCourseID
			// 
			this.cbCourseID.FormattingEnabled = true;
			this.cbCourseID.Location = new System.Drawing.Point(547, 97);
			this.cbCourseID.Name = "cbCourseID";
			this.cbCourseID.Size = new System.Drawing.Size(239, 21);
			this.cbCourseID.TabIndex = 12;
			// 
			// lbFacultyID
			// 
			this.lbFacultyID.AutoSize = true;
			this.lbFacultyID.Location = new System.Drawing.Point(86, 100);
			this.lbFacultyID.Name = "lbFacultyID";
			this.lbFacultyID.Size = new System.Drawing.Size(68, 13);
			this.lbFacultyID.TabIndex = 11;
			this.lbFacultyID.Text = "Thuộc khoa:";
			// 
			// cbFacultyID
			// 
			this.cbFacultyID.FormattingEnabled = true;
			this.cbFacultyID.Location = new System.Drawing.Point(160, 97);
			this.cbFacultyID.Name = "cbFacultyID";
			this.cbFacultyID.Size = new System.Drawing.Size(239, 21);
			this.cbFacultyID.TabIndex = 10;
			this.cbFacultyID.SelectedIndexChanged += new System.EventHandler(this.cbFacultyID_SelectedIndexChanged);
			// 
			// lbSubjectRole
			// 
			this.lbSubjectRole.AutoSize = true;
			this.lbSubjectRole.Location = new System.Drawing.Point(855, 49);
			this.lbSubjectRole.Name = "lbSubjectRole";
			this.lbSubjectRole.Size = new System.Drawing.Size(54, 13);
			this.lbSubjectRole.TabIndex = 9;
			this.lbSubjectRole.Text = "Kiểu môn:";
			// 
			// cbSubjectRole
			// 
			this.cbSubjectRole.FormattingEnabled = true;
			this.cbSubjectRole.Location = new System.Drawing.Point(915, 46);
			this.cbSubjectRole.Name = "cbSubjectRole";
			this.cbSubjectRole.Size = new System.Drawing.Size(239, 21);
			this.cbSubjectRole.TabIndex = 8;
			// 
			// tbSubjectID
			// 
			this.tbSubjectID.Location = new System.Drawing.Point(160, 46);
			this.tbSubjectID.Name = "tbSubjectID";
			this.tbSubjectID.Size = new System.Drawing.Size(239, 20);
			this.tbSubjectID.TabIndex = 7;
			// 
			// tbDescription
			// 
			this.tbDescription.Location = new System.Drawing.Point(547, 145);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(239, 20);
			this.tbDescription.TabIndex = 6;
			// 
			// lbDescription
			// 
			this.lbDescription.AutoSize = true;
			this.lbDescription.Location = new System.Drawing.Point(504, 148);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(37, 13);
			this.lbDescription.TabIndex = 4;
			this.lbDescription.Text = "Mô tả:";
			// 
			// lbSubjectName
			// 
			this.lbSubjectName.AutoSize = true;
			this.lbSubjectName.Location = new System.Drawing.Point(474, 49);
			this.lbSubjectName.Name = "lbSubjectName";
			this.lbSubjectName.Size = new System.Drawing.Size(66, 13);
			this.lbSubjectName.TabIndex = 2;
			this.lbSubjectName.Text = "Tên môn thi:";
			// 
			// tbSubjectName
			// 
			this.tbSubjectName.Location = new System.Drawing.Point(547, 46);
			this.tbSubjectName.Name = "tbSubjectName";
			this.tbSubjectName.Size = new System.Drawing.Size(239, 20);
			this.tbSubjectName.TabIndex = 3;
			// 
			// lbSubjectID
			// 
			this.lbSubjectID.AutoSize = true;
			this.lbSubjectID.Location = new System.Drawing.Point(106, 49);
			this.lbSubjectID.Name = "lbSubjectID";
			this.lbSubjectID.Size = new System.Drawing.Size(48, 13);
			this.lbSubjectID.TabIndex = 0;
			this.lbSubjectID.Text = "Mã môn:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// FrmManageSubject
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.pMain);
			this.MinimumSize = new System.Drawing.Size(1080, 640);
			this.Name = "FrmManageSubject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý môn thi";
			this.Load += new System.EventHandler(this.FrmManageSubject_Load);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			this.gbControls.ResumeLayout(false);
			this.gbControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.GroupBox gbControls;
		private System.Windows.Forms.Label lbSubjectName;
		private System.Windows.Forms.TextBox tbSubjectName;
		private System.Windows.Forms.Label lbSubjectID;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbSubjectID;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label lbSemesterID;
		private System.Windows.Forms.ComboBox cbSemesterID;
		private System.Windows.Forms.Label lbCourseID;
		private System.Windows.Forms.ComboBox cbCourseID;
		private System.Windows.Forms.Label lbFacultyID;
		private System.Windows.Forms.ComboBox cbFacultyID;
		private System.Windows.Forms.Label lbSubjectRole;
		private System.Windows.Forms.ComboBox cbSubjectRole;
		private System.Windows.Forms.Button btnClearFilter;
		private ADGV.AdvancedDataGridView aDgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SemesterID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
	}
}