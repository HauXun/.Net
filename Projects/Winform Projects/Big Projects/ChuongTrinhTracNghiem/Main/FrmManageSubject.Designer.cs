
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
			this.lbDescription = new System.Windows.Forms.Label();
			this.lbSubjectName = new System.Windows.Forms.Label();
			this.tbSubjectName = new System.Windows.Forms.TextBox();
			this.lbSubjectID = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.tbSubjectID = new System.Windows.Forms.TextBox();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1064, 601);
			this.pMain.TabIndex = 0;
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(535, 140);
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
			this.btnSave.Location = new System.Drawing.Point(454, 140);
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
            this.SubjectName,
            this.SubjectID,
            this.Description});
			this.dgvData.Location = new System.Drawing.Point(12, 198);
			this.dgvData.Name = "dgvData";
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(1040, 391);
			this.dgvData.TabIndex = 7;
			this.dgvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowEnter);
			this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(12, 171);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(225, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập tên môn ...";
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(243, 169);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(576, 139);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(494, 139);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(413, 140);
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
			this.lbTitle.Location = new System.Drawing.Point(436, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(192, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý môn thi";
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.tbSubjectID);
			this.gbControls.Controls.Add(this.tbDescription);
			this.gbControls.Controls.Add(this.lbDescription);
			this.gbControls.Controls.Add(this.lbSubjectName);
			this.gbControls.Controls.Add(this.tbSubjectName);
			this.gbControls.Controls.Add(this.lbSubjectID);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(1040, 82);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin người dùng";
			// 
			// lbDescription
			// 
			this.lbDescription.AutoSize = true;
			this.lbDescription.Location = new System.Drawing.Point(752, 36);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(37, 13);
			this.lbDescription.TabIndex = 4;
			this.lbDescription.Text = "Mô tả:";
			// 
			// lbSubjectName
			// 
			this.lbSubjectName.AutoSize = true;
			this.lbSubjectName.Location = new System.Drawing.Point(365, 36);
			this.lbSubjectName.Name = "lbSubjectName";
			this.lbSubjectName.Size = new System.Drawing.Size(66, 13);
			this.lbSubjectName.TabIndex = 2;
			this.lbSubjectName.Text = "Tên môn thi:";
			// 
			// tbSubjectName
			// 
			this.tbSubjectName.Location = new System.Drawing.Point(437, 33);
			this.tbSubjectName.Name = "tbSubjectName";
			this.tbSubjectName.Size = new System.Drawing.Size(239, 20);
			this.tbSubjectName.TabIndex = 3;
			// 
			// lbSubjectID
			// 
			this.lbSubjectID.AutoSize = true;
			this.lbSubjectID.Location = new System.Drawing.Point(6, 36);
			this.lbSubjectID.Name = "lbSubjectID";
			this.lbSubjectID.Size = new System.Drawing.Size(48, 13);
			this.lbSubjectID.TabIndex = 0;
			this.lbSubjectID.Text = "Mã môn:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// tbDescription
			// 
			this.tbDescription.Location = new System.Drawing.Point(795, 33);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(239, 20);
			this.tbDescription.TabIndex = 6;
			// 
			// tbSubjectID
			// 
			this.tbSubjectID.Location = new System.Drawing.Point(60, 33);
			this.tbSubjectID.Name = "tbSubjectID";
			this.tbSubjectID.Size = new System.Drawing.Size(239, 20);
			this.tbSubjectID.TabIndex = 7;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.FillWeight = 139.8907F;
			this.Description.HeaderText = "Mô tả";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			this.SubjectID.FillWeight = 43.52628F;
			this.SubjectID.HeaderText = "Mã môn";
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			// 
			// SubjectName
			// 
			this.SubjectName.DataPropertyName = "SubjectName";
			this.SubjectName.FillWeight = 109.8239F;
			this.SubjectName.HeaderText = "Tên môn thi";
			this.SubjectName.Name = "SubjectName";
			this.SubjectName.ReadOnly = true;
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle2;
			this.STT.FillWeight = 32.69129F;
			this.STT.HeaderText = "STT";
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			// 
			// FrmManageSubject
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 601);
			this.Controls.Add(this.pMain);
			this.MinimumSize = new System.Drawing.Size(1080, 640);
			this.Name = "FrmManageSubject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý môn thi";
			this.Load += new System.EventHandler(this.FrmManageSubject_Load);
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
		private System.Windows.Forms.Label lbSubjectName;
		private System.Windows.Forms.TextBox tbSubjectName;
		private System.Windows.Forms.Label lbSubjectID;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.DataGridView dgvData;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
	}
}