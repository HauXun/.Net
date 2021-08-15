
namespace Main
{
	partial class FrmManageUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pMain = new System.Windows.Forms.Panel();
			this.cbClassFilter = new System.Windows.Forms.ComboBox();
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gbControls = new System.Windows.Forms.GroupBox();
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
			this.lbUserID = new System.Windows.Forms.Label();
			this.tbAccount = new System.Windows.Forms.TextBox();
			this.tbUserID = new System.Windows.Forms.TextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnResetPassword = new System.Windows.Forms.Button();
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.btnResetPassword);
			this.pMain.Controls.Add(this.cbClassFilter);
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
			this.pMain.Size = new System.Drawing.Size(1264, 681);
			this.pMain.TabIndex = 0;
			// 
			// cbClassFilter
			// 
			this.cbClassFilter.FormattingEnabled = true;
			this.cbClassFilter.Location = new System.Drawing.Point(89, 297);
			this.cbClassFilter.Name = "cbClassFilter";
			this.cbClassFilter.Size = new System.Drawing.Size(71, 21);
			this.cbClassFilter.TabIndex = 11;
			// 
			// cbFilter
			// 
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(12, 297);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(71, 21);
			this.cbFilter.TabIndex = 10;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
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
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.FullName,
            this.ClassID,
            this.Username,
            this.Password,
            this.UserID,
            this.PhoneNumber,
            this.Email,
            this.Address,
            this.Birthday,
            this.UserRole,
            this.Note});
			this.dgvData.Location = new System.Drawing.Point(12, 324);
			this.dgvData.Name = "dgvData";
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(1240, 345);
			this.dgvData.TabIndex = 7;
			this.dgvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowEnter);
			this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle8;
			this.STT.FillWeight = 33.41687F;
			this.STT.HeaderText = "STT";
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			// 
			// FullName
			// 
			this.FullName.DataPropertyName = "FullName";
			this.FullName.FillWeight = 124.9134F;
			this.FullName.HeaderText = "Họ và tên";
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			// 
			// ClassID
			// 
			this.ClassID.DataPropertyName = "ClassID";
			this.ClassID.FillWeight = 82.98894F;
			this.ClassID.HeaderText = "Lớp";
			this.ClassID.Name = "ClassID";
			this.ClassID.ReadOnly = true;
			// 
			// Username
			// 
			this.Username.DataPropertyName = "Username";
			this.Username.FillWeight = 83.92313F;
			this.Username.HeaderText = "Tài khoản";
			this.Username.Name = "Username";
			this.Username.ReadOnly = true;
			// 
			// Password
			// 
			this.Password.DataPropertyName = "Password";
			this.Password.HeaderText = "Mật khẩu";
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			this.Password.Visible = false;
			// 
			// UserID
			// 
			this.UserID.DataPropertyName = "UserID";
			this.UserID.FillWeight = 83.36646F;
			this.UserID.HeaderText = "Mã định danh";
			this.UserID.Name = "UserID";
			this.UserID.ReadOnly = true;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.DataPropertyName = "PhoneNumber";
			this.PhoneNumber.FillWeight = 99.49841F;
			this.PhoneNumber.HeaderText = "Điện thoại";
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.ReadOnly = true;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.FillWeight = 123.7245F;
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			// 
			// Address
			// 
			this.Address.DataPropertyName = "Address";
			this.Address.FillWeight = 123.7788F;
			this.Address.HeaderText = "Địa chỉ";
			this.Address.Name = "Address";
			this.Address.ReadOnly = true;
			// 
			// Birthday
			// 
			this.Birthday.DataPropertyName = "Birthday";
			dataGridViewCellStyle9.Format = "d";
			dataGridViewCellStyle9.NullValue = "dd/MM/yyyy";
			this.Birthday.DefaultCellStyle = dataGridViewCellStyle9;
			this.Birthday.FillWeight = 84.47609F;
			this.Birthday.HeaderText = "Ngày sinh";
			this.Birthday.Name = "Birthday";
			this.Birthday.ReadOnly = true;
			// 
			// UserRole
			// 
			this.UserRole.DataPropertyName = "UserRole";
			this.UserRole.HeaderText = "Chức vụ";
			this.UserRole.Name = "UserRole";
			this.UserRole.ReadOnly = true;
			this.UserRole.Visible = false;
			// 
			// Note
			// 
			this.Note.DataPropertyName = "Note";
			this.Note.FillWeight = 159.9134F;
			this.Note.HeaderText = "Ghi chú";
			this.Note.Name = "Note";
			this.Note.ReadOnly = true;
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(166, 297);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(141, 20);
			this.tbSearch.TabIndex = 5;
			this.tbSearch.Text = "Nhập tên/Tài khoản/...";
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(313, 295);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(676, 253);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(594, 253);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(513, 254);
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
			this.lbTitle.Location = new System.Drawing.Point(517, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(231, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý người dùng";
			// 
			// gbControls
			// 
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
			this.gbControls.Controls.Add(this.lbUserID);
			this.gbControls.Controls.Add(this.tbAccount);
			this.gbControls.Controls.Add(this.tbUserID);
			this.gbControls.Location = new System.Drawing.Point(12, 52);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(1240, 178);
			this.gbControls.TabIndex = 1;
			this.gbControls.TabStop = false;
			this.gbControls.Text = "Thông tin người dùng";
			// 
			// cbClassID
			// 
			this.cbClassID.FormattingEnabled = true;
			this.cbClassID.Location = new System.Drawing.Point(247, 125);
			this.cbClassID.Name = "cbClassID";
			this.cbClassID.Size = new System.Drawing.Size(159, 21);
			this.cbClassID.TabIndex = 19;
			// 
			// lbClass
			// 
			this.lbClass.AutoSize = true;
			this.lbClass.Location = new System.Drawing.Point(160, 128);
			this.lbClass.Name = "lbClass";
			this.lbClass.Size = new System.Drawing.Size(28, 13);
			this.lbClass.TabIndex = 18;
			this.lbClass.Text = "Lớp:";
			// 
			// cbRole
			// 
			this.cbRole.FormattingEnabled = true;
			this.cbRole.Location = new System.Drawing.Point(247, 79);
			this.cbRole.Name = "cbRole";
			this.cbRole.Size = new System.Drawing.Size(159, 21);
			this.cbRole.TabIndex = 7;
			this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
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
			this.lbRole.Location = new System.Drawing.Point(160, 82);
			this.lbRole.Name = "lbRole";
			this.lbRole.Size = new System.Drawing.Size(50, 13);
			this.lbRole.TabIndex = 6;
			this.lbRole.Text = "Chức vụ:";
			// 
			// lbUserID
			// 
			this.lbUserID.AutoSize = true;
			this.lbUserID.Location = new System.Drawing.Point(160, 36);
			this.lbUserID.Name = "lbUserID";
			this.lbUserID.Size = new System.Drawing.Size(81, 13);
			this.lbUserID.TabIndex = 0;
			this.lbUserID.Text = "Mã người dùng:";
			// 
			// tbAccount
			// 
			this.tbAccount.Location = new System.Drawing.Point(589, 33);
			this.tbAccount.Name = "tbAccount";
			this.tbAccount.Size = new System.Drawing.Size(159, 20);
			this.tbAccount.TabIndex = 13;
			// 
			// tbUserID
			// 
			this.tbUserID.Location = new System.Drawing.Point(247, 33);
			this.tbUserID.Name = "tbUserID";
			this.tbUserID.ReadOnly = true;
			this.tbUserID.Size = new System.Drawing.Size(159, 20);
			this.tbUserID.TabIndex = 1;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// btnResetPassword
			// 
			this.btnResetPassword.AutoSize = true;
			this.btnResetPassword.Location = new System.Drawing.Point(1158, 295);
			this.btnResetPassword.Name = "btnResetPassword";
			this.btnResetPassword.Size = new System.Drawing.Size(94, 23);
			this.btnResetPassword.TabIndex = 12;
			this.btnResetPassword.Text = "Đặt lại mật khẩu";
			this.btnResetPassword.UseVisualStyleBackColor = true;
			this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
			// 
			// FrmManageUser
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.pMain);
			this.MinimumSize = new System.Drawing.Size(1080, 640);
			this.Name = "FrmManageUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý người dùng";
			this.Load += new System.EventHandler(this.FrmManageUser_Load);
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
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbFullName;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbFullName;
		private System.Windows.Forms.Label lbAccount;
		private System.Windows.Forms.Label lbRole;
		private System.Windows.Forms.Label lbUserID;
		private System.Windows.Forms.TextBox tbAccount;
		private System.Windows.Forms.TextBox tbUserID;
		private System.Windows.Forms.DateTimePicker dtpDob;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.Label lbDob;
		private System.Windows.Forms.Label lbPhone;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.DataGridView dgvData;
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
		private System.Windows.Forms.ComboBox cbClassFilter;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Username;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn Note;
		private System.Windows.Forms.Button btnResetPassword;
	}
}