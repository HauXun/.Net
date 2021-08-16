
namespace Main
{
	partial class FrmManageFaculty
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
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FoundingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gbControls = new System.Windows.Forms.GroupBox();
			this.lbDescription = new System.Windows.Forms.Label();
			this.dtpFoundingDate = new System.Windows.Forms.DateTimePicker();
			this.tbFacultyID = new System.Windows.Forms.TextBox();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.lbFoudingDate = new System.Windows.Forms.Label();
			this.lbFacultyName = new System.Windows.Forms.Label();
			this.tbFacultyName = new System.Windows.Forms.TextBox();
			this.lbFacultyID = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.gbControls.SuspendLayout();
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
			this.pMain.Size = new System.Drawing.Size(1264, 681);
			this.pMain.TabIndex = 0;
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(635, 216);
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
			this.btnSave.Location = new System.Drawing.Point(554, 216);
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
            this.FacultyName,
            this.FacultyID,
            this.FoundingDate,
            this.Description});
			this.dgvData.Location = new System.Drawing.Point(12, 288);
			this.dgvData.Name = "dgvData";
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(1240, 381);
			this.dgvData.TabIndex = 7;
			this.dgvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowEnter);
			this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle2;
			this.STT.FillWeight = 14.10371F;
			this.STT.HeaderText = "STT";
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			// 
			// FacultyName
			// 
			this.FacultyName.DataPropertyName = "FacultyName";
			this.FacultyName.FillWeight = 103.3898F;
			this.FacultyName.HeaderText = "Tên khoa";
			this.FacultyName.Name = "FacultyName";
			this.FacultyName.ReadOnly = true;
			// 
			// FacultyID
			// 
			this.FacultyID.DataPropertyName = "FacultyID";
			this.FacultyID.FillWeight = 46.87724F;
			this.FacultyID.HeaderText = "Mã khoa";
			this.FacultyID.Name = "FacultyID";
			this.FacultyID.ReadOnly = true;
			// 
			// FoundingDate
			// 
			this.FoundingDate.DataPropertyName = "FoundingDate";
			this.FoundingDate.FillWeight = 49.80535F;
			this.FoundingDate.HeaderText = "Ngày thành lập";
			this.FoundingDate.Name = "FoundingDate";
			this.FoundingDate.ReadOnly = true;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.FillWeight = 211.756F;
			this.Description.HeaderText = "Mô tả";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(12, 261);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(225, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập tên khoa/Mã khoa ...";
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(243, 259);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(676, 215);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(594, 215);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(513, 216);
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
			this.lbTitle.Location = new System.Drawing.Point(552, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(161, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý khoa";
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.lbDescription);
			this.gbControls.Controls.Add(this.dtpFoundingDate);
			this.gbControls.Controls.Add(this.tbFacultyID);
			this.gbControls.Controls.Add(this.tbDescription);
			this.gbControls.Controls.Add(this.lbFoudingDate);
			this.gbControls.Controls.Add(this.lbFacultyName);
			this.gbControls.Controls.Add(this.tbFacultyName);
			this.gbControls.Controls.Add(this.lbFacultyID);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(1240, 145);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin môn thi";
			// 
			// lbDescription
			// 
			this.lbDescription.AutoSize = true;
			this.lbDescription.Location = new System.Drawing.Point(759, 97);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(37, 13);
			this.lbDescription.TabIndex = 9;
			this.lbDescription.Text = "Mô tả:";
			// 
			// dtpFoundingDate
			// 
			this.dtpFoundingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFoundingDate.Location = new System.Drawing.Point(858, 36);
			this.dtpFoundingDate.Name = "dtpFoundingDate";
			this.dtpFoundingDate.Size = new System.Drawing.Size(239, 20);
			this.dtpFoundingDate.TabIndex = 8;
			// 
			// tbFacultyID
			// 
			this.tbFacultyID.Location = new System.Drawing.Point(215, 46);
			this.tbFacultyID.Name = "tbFacultyID";
			this.tbFacultyID.ReadOnly = true;
			this.tbFacultyID.Size = new System.Drawing.Size(239, 20);
			this.tbFacultyID.TabIndex = 7;
			// 
			// tbDescription
			// 
			this.tbDescription.Location = new System.Drawing.Point(858, 94);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(239, 20);
			this.tbDescription.TabIndex = 6;
			// 
			// lbFoudingDate
			// 
			this.lbFoudingDate.AutoSize = true;
			this.lbFoudingDate.Location = new System.Drawing.Point(759, 39);
			this.lbFoudingDate.Name = "lbFoudingDate";
			this.lbFoudingDate.Size = new System.Drawing.Size(82, 13);
			this.lbFoudingDate.TabIndex = 4;
			this.lbFoudingDate.Text = "Ngày thành lập:";
			// 
			// lbFacultyName
			// 
			this.lbFacultyName.AutoSize = true;
			this.lbFacultyName.Location = new System.Drawing.Point(143, 97);
			this.lbFacultyName.Name = "lbFacultyName";
			this.lbFacultyName.Size = new System.Drawing.Size(56, 13);
			this.lbFacultyName.TabIndex = 2;
			this.lbFacultyName.Text = "Tên khoa:";
			// 
			// tbFacultyName
			// 
			this.tbFacultyName.Location = new System.Drawing.Point(215, 94);
			this.tbFacultyName.Name = "tbFacultyName";
			this.tbFacultyName.Size = new System.Drawing.Size(239, 20);
			this.tbFacultyName.TabIndex = 3;
			// 
			// lbFacultyID
			// 
			this.lbFacultyID.AutoSize = true;
			this.lbFacultyID.Location = new System.Drawing.Point(143, 49);
			this.lbFacultyID.Name = "lbFacultyID";
			this.lbFacultyID.Size = new System.Drawing.Size(52, 13);
			this.lbFacultyID.TabIndex = 0;
			this.lbFacultyID.Text = "Mã khoa:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// FrmManageFaculty
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.pMain);
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "FrmManageFaculty";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý khoa";
			this.Load += new System.EventHandler(this.FrmManageFaculty_Load);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.gbControls.ResumeLayout(false);
			this.gbControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.GroupBox gbControls;
		private System.Windows.Forms.Label lbFacultyName;
		private System.Windows.Forms.TextBox tbFacultyName;
		private System.Windows.Forms.Label lbFacultyID;
		private System.Windows.Forms.Label lbFoudingDate;
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbFacultyID;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.DateTimePicker dtpFoundingDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FoundingDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
	}
}