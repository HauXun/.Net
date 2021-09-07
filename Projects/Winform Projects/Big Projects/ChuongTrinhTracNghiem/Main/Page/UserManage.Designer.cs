
namespace Main.Page
{
	partial class UserManage
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
			this.pMain = new System.Windows.Forms.Panel();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.btnResetPassword = new System.Windows.Forms.Button();
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gbControls = new System.Windows.Forms.GroupBox();
			this.cbCourseID = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbClassID = new System.Windows.Forms.ComboBox();
			this.lbClass = new System.Windows.Forms.Label();
			this.cbRole = new System.Windows.Forms.ComboBox();
			this.dtpDob = new System.Windows.Forms.DateTimePicker();
			this.lbAddress = new System.Windows.Forms.Label();
			this.lbDob = new System.Windows.Forms.Label();
			this.lbPhone = new System.Windows.Forms.Label();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.lbEmail = new System.Windows.Forms.Label();
			this.lbFullName = new System.Windows.Forms.Label();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbFullName = new System.Windows.Forms.TextBox();
			this.lbAccount = new System.Windows.Forms.Label();
			this.lbRole = new System.Windows.Forms.Label();
			this.tbAccount = new System.Windows.Forms.TextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pMain.SuspendLayout();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.dataGridView1);
			this.pMain.Controls.Add(this.btnClearFilter);
			this.pMain.Controls.Add(this.btnResetPassword);
			this.pMain.Controls.Add(this.cbFilter);
			this.pMain.Controls.Add(this.btnCancle);
			this.pMain.Controls.Add(this.btnSave);
			this.pMain.Controls.Add(this.tbSearch);
			this.pMain.Controls.Add(this.btnSearch);
			this.pMain.Controls.Add(this.btnDelete);
			this.pMain.Controls.Add(this.btnEdit);
			this.pMain.Controls.Add(this.btnAdd);
			this.pMain.Controls.Add(this.lbTitle);
			this.pMain.Controls.Add(this.gbControls);
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1280, 720);
			this.pMain.TabIndex = 0;
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.Location = new System.Drawing.Point(317, 295);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
			this.btnClearFilter.TabIndex = 15;
			this.btnClearFilter.Text = "Clear Filter";
			this.btnClearFilter.UseVisualStyleBackColor = true;
			// 
			// btnResetPassword
			// 
			this.btnResetPassword.AutoSize = true;
			this.btnResetPassword.Location = new System.Drawing.Point(1171, 295);
			this.btnResetPassword.Name = "btnResetPassword";
			this.btnResetPassword.Size = new System.Drawing.Size(94, 23);
			this.btnResetPassword.TabIndex = 12;
			this.btnResetPassword.Text = "Đặt lại mật khẩu";
			this.btnResetPassword.UseVisualStyleBackColor = true;
			// 
			// cbFilter
			// 
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(12, 297);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(71, 21);
			this.cbFilter.TabIndex = 10;
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(635, 254);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(75, 23);
			this.btnCancle.TabIndex = 9;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.UseVisualStyleBackColor = true;
			this.btnCancle.Visible = false;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(554, 254);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Visible = false;
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(89, 297);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(141, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập từ khóa ...";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(236, 295);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(676, 253);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(594, 253);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(513, 254);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(517, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(231, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý người dùng";
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.cbCourseID);
			this.gbControls.Controls.Add(this.label1);
			this.gbControls.Controls.Add(this.cbClassID);
			this.gbControls.Controls.Add(this.lbClass);
			this.gbControls.Controls.Add(this.cbRole);
			this.gbControls.Controls.Add(this.dtpDob);
			this.gbControls.Controls.Add(this.lbAddress);
			this.gbControls.Controls.Add(this.lbDob);
			this.gbControls.Controls.Add(this.lbPhone);
			this.gbControls.Controls.Add(this.tbAddress);
			this.gbControls.Controls.Add(this.tbPhone);
			this.gbControls.Controls.Add(this.lbEmail);
			this.gbControls.Controls.Add(this.lbFullName);
			this.gbControls.Controls.Add(this.tbEmail);
			this.gbControls.Controls.Add(this.tbFullName);
			this.gbControls.Controls.Add(this.lbAccount);
			this.gbControls.Controls.Add(this.lbRole);
			this.gbControls.Controls.Add(this.tbAccount);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(1240, 178);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin người dùng";
			// 
			// cbCourseID
			// 
			this.cbCourseID.FormattingEnabled = true;
			this.cbCourseID.Location = new System.Drawing.Point(247, 80);
			this.cbCourseID.Name = "cbCourseID";
			this.cbCourseID.Size = new System.Drawing.Size(159, 21);
			this.cbCourseID.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(160, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Khóa:";
			// 
			// cbClassID
			// 
			this.cbClassID.FormattingEnabled = true;
			this.cbClassID.Location = new System.Drawing.Point(247, 127);
			this.cbClassID.Name = "cbClassID";
			this.cbClassID.Size = new System.Drawing.Size(159, 21);
			this.cbClassID.TabIndex = 19;
			// 
			// lbClass
			// 
			this.lbClass.AutoSize = true;
			this.lbClass.Location = new System.Drawing.Point(160, 130);
			this.lbClass.Name = "lbClass";
			this.lbClass.Size = new System.Drawing.Size(28, 13);
			this.lbClass.TabIndex = 18;
			this.lbClass.Text = "Lớp:";
			// 
			// cbRole
			// 
			this.cbRole.FormattingEnabled = true;
			this.cbRole.Location = new System.Drawing.Point(247, 33);
			this.cbRole.Name = "cbRole";
			this.cbRole.Size = new System.Drawing.Size(159, 21);
			this.cbRole.TabIndex = 7;
			// 
			// dtpDob
			// 
			this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDob.Location = new System.Drawing.Point(921, 78);
			this.dtpDob.Name = "dtpDob";
			this.dtpDob.Size = new System.Drawing.Size(159, 20);
			this.dtpDob.TabIndex = 11;
			// 
			// lbAddress
			// 
			this.lbAddress.AutoSize = true;
			this.lbAddress.Location = new System.Drawing.Point(834, 130);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(43, 13);
			this.lbAddress.TabIndex = 16;
			this.lbAddress.Text = "Địa chỉ:";
			// 
			// lbDob
			// 
			this.lbDob.AutoSize = true;
			this.lbDob.Location = new System.Drawing.Point(834, 82);
			this.lbDob.Name = "lbDob";
			this.lbDob.Size = new System.Drawing.Size(57, 13);
			this.lbDob.TabIndex = 10;
			this.lbDob.Text = "Ngày sinh:";
			// 
			// lbPhone
			// 
			this.lbPhone.AutoSize = true;
			this.lbPhone.Location = new System.Drawing.Point(834, 36);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Size = new System.Drawing.Size(58, 13);
			this.lbPhone.TabIndex = 4;
			this.lbPhone.Text = "Điện thoại:";
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(921, 127);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(159, 20);
			this.tbAddress.TabIndex = 17;
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(921, 33);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(159, 20);
			this.tbPhone.TabIndex = 5;
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Location = new System.Drawing.Point(502, 130);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(35, 13);
			this.lbEmail.TabIndex = 14;
			this.lbEmail.Text = "Email:";
			// 
			// lbFullName
			// 
			this.lbFullName.AutoSize = true;
			this.lbFullName.Location = new System.Drawing.Point(502, 83);
			this.lbFullName.Name = "lbFullName";
			this.lbFullName.Size = new System.Drawing.Size(57, 13);
			this.lbFullName.TabIndex = 2;
			this.lbFullName.Text = "Họ và tên:";
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(589, 127);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(159, 20);
			this.tbEmail.TabIndex = 15;
			// 
			// tbFullName
			// 
			this.tbFullName.Location = new System.Drawing.Point(589, 80);
			this.tbFullName.Name = "tbFullName";
			this.tbFullName.Size = new System.Drawing.Size(159, 20);
			this.tbFullName.TabIndex = 3;
			// 
			// lbAccount
			// 
			this.lbAccount.AutoSize = true;
			this.lbAccount.Location = new System.Drawing.Point(502, 36);
			this.lbAccount.Name = "lbAccount";
			this.lbAccount.Size = new System.Drawing.Size(58, 13);
			this.lbAccount.TabIndex = 12;
			this.lbAccount.Text = "Tài khoản:";
			// 
			// lbRole
			// 
			this.lbRole.AutoSize = true;
			this.lbRole.Location = new System.Drawing.Point(160, 36);
			this.lbRole.Name = "lbRole";
			this.lbRole.Size = new System.Drawing.Size(50, 13);
			this.lbRole.TabIndex = 6;
			this.lbRole.Text = "Chức vụ:";
			// 
			// tbAccount
			// 
			this.tbAccount.Location = new System.Drawing.Point(589, 33);
			this.tbAccount.Name = "tbAccount";
			this.tbAccount.Size = new System.Drawing.Size(159, 20);
			this.tbAccount.TabIndex = 13;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(12, 324);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 50;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1253, 393);
			this.dataGridView1.TabIndex = 16;
			// 
			// Column1
			// 
			this.Column1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(183)))), ((int)(((byte)(144)))));
			this.Column1.FillWeight = 30F;
			this.Column1.HeaderText = "ID";
			this.Column1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(183)))), ((int)(((byte)(144)))));
			this.Column1.Name = "Column1";
			this.Column1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(183)))), ((int)(((byte)(144)))));
			// 
			// Column2
			// 
			this.Column2.FillWeight = 200F;
			this.Column2.HeaderText = "CODE";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.FillWeight = 200F;
			this.Column3.HeaderText = "CATEGORY";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "NAME";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.FillWeight = 200F;
			this.Column5.HeaderText = "DESCRIPTION";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.FillWeight = 200F;
			this.Column6.HeaderText = "CREATED AT";
			this.Column6.Name = "Column6";
			// 
			// UserManage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.pMain);
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "UserManage";
			this.Size = new System.Drawing.Size(1280, 720);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.gbControls.ResumeLayout(false);
			this.gbControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.GroupBox gbControls;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbFullName;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbFullName;
		private System.Windows.Forms.Label lbAccount;
		private System.Windows.Forms.Label lbRole;
		private System.Windows.Forms.TextBox tbAccount;
		private System.Windows.Forms.DateTimePicker dtpDob;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.Label lbDob;
		private System.Windows.Forms.Label lbPhone;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbRole;
		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.ComboBox cbClassID;
		private System.Windows.Forms.Label lbClass;
		private System.Windows.Forms.Button btnResetPassword;
		private System.Windows.Forms.Button btnClearFilter;
		private System.Windows.Forms.ComboBox cbCourseID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewLinkColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}