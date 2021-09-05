
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pMain = new System.Windows.Forms.Panel();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.gbControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.btnClearFilter);
			this.pMain.Controls.Add(this.aDgvdata);
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
			// aDgvdata
			// 
			this.aDgvdata.AllowUserToAddRows = false;
			this.aDgvdata.AutoGenerateContextFilters = true;
			this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.aDgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.UserRole,
            this.FullName,
            this.ClassID,
            this.Username,
            this.UserID,
            this.PhoneNumber,
            this.Email,
            this.Address,
            this.Birthday,
            this.Note});
			this.aDgvdata.DateWithTime = false;
			this.aDgvdata.Location = new System.Drawing.Point(12, 324);
			this.aDgvdata.MultiSelect = false;
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1253, 382);
			this.aDgvdata.TabIndex = 13;
			this.aDgvdata.TimeFilter = false;
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.STT.DefaultCellStyle = dataGridViewCellStyle11;
			this.STT.FillWeight = 50.12531F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// UserRole
			// 
			this.UserRole.DataPropertyName = "UserRole";
			this.UserRole.HeaderText = "Vai trò";
			this.UserRole.MinimumWidth = 22;
			this.UserRole.Name = "UserRole";
			this.UserRole.ReadOnly = true;
			this.UserRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.UserRole.Visible = false;
			// 
			// FullName
			// 
			this.FullName.DataPropertyName = "FullName";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.FullName.DefaultCellStyle = dataGridViewCellStyle12;
			this.FullName.FillWeight = 97.65189F;
			this.FullName.HeaderText = "Họ và tên";
			this.FullName.MinimumWidth = 22;
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ClassID
			// 
			this.ClassID.DataPropertyName = "ClassID";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ClassID.DefaultCellStyle = dataGridViewCellStyle13;
			this.ClassID.FillWeight = 99.65179F;
			this.ClassID.HeaderText = "Lớp";
			this.ClassID.MinimumWidth = 22;
			this.ClassID.Name = "ClassID";
			this.ClassID.ReadOnly = true;
			this.ClassID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Username
			// 
			this.Username.DataPropertyName = "Username";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.Format = "d";
			dataGridViewCellStyle14.NullValue = "dd/MM/yyyy";
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Username.DefaultCellStyle = dataGridViewCellStyle14;
			this.Username.FillWeight = 93.53768F;
			this.Username.HeaderText = "Tài khoản";
			this.Username.MinimumWidth = 22;
			this.Username.Name = "Username";
			this.Username.ReadOnly = true;
			this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// UserID
			// 
			this.UserID.DataPropertyName = "UserID";
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.UserID.DefaultCellStyle = dataGridViewCellStyle15;
			this.UserID.FillWeight = 90.15208F;
			this.UserID.HeaderText = "Mã định danh";
			this.UserID.MinimumWidth = 22;
			this.UserID.Name = "UserID";
			this.UserID.ReadOnly = true;
			this.UserID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.DataPropertyName = "PhoneNumber";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle16;
			this.PhoneNumber.FillWeight = 105.437F;
			this.PhoneNumber.HeaderText = "Điện thoại";
			this.PhoneNumber.MinimumWidth = 22;
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.ReadOnly = true;
			this.PhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.FillWeight = 103.6769F;
			this.Email.HeaderText = "Email";
			this.Email.MinimumWidth = 22;
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Address
			// 
			this.Address.DataPropertyName = "Address";
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Address.DefaultCellStyle = dataGridViewCellStyle17;
			this.Address.FillWeight = 103.8357F;
			this.Address.HeaderText = "Địa chỉ";
			this.Address.MinimumWidth = 22;
			this.Address.Name = "Address";
			this.Address.ReadOnly = true;
			this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Birthday
			// 
			this.Birthday.DataPropertyName = "Birthday";
			dataGridViewCellStyle18.Format = "d";
			dataGridViewCellStyle18.NullValue = "dd/MM/yyyy";
			this.Birthday.DefaultCellStyle = dataGridViewCellStyle18;
			this.Birthday.FillWeight = 103.1073F;
			this.Birthday.HeaderText = "Ngày sinh";
			this.Birthday.MinimumWidth = 22;
			this.Birthday.Name = "Birthday";
			this.Birthday.ReadOnly = true;
			this.Birthday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Note
			// 
			this.Note.DataPropertyName = "Note";
			this.Note.FillWeight = 152.8243F;
			this.Note.HeaderText = "Ghi chú";
			this.Note.MinimumWidth = 22;
			this.Note.Name = "Note";
			this.Note.ReadOnly = true;
			this.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
		private ADGV.AdvancedDataGridView aDgvdata;
		private System.Windows.Forms.Button btnClearFilter;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Username;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Note;
		private System.Windows.Forms.ComboBox cbCourseID;
		private System.Windows.Forms.Label label1;
	}
}