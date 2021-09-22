
namespace Main.Pages
{
	partial class ManageSubject
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubject));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.pnlInfo3 = new System.Windows.Forms.Panel();
			this.cbSemesterID = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbSubjectRole = new Bunifu.UI.WinForms.BunifuDropdown();
			this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbMoTa = new System.Windows.Forms.Label();
			this.lbThuocHocKy = new System.Windows.Forms.Label();
			this.lbKieuMon = new System.Windows.Forms.Label();
			this.pnlInfo2 = new System.Windows.Forms.Panel();
			this.cbCourseID = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbFacultyID = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbDanhChoKhoa = new System.Windows.Forms.Label();
			this.lbThuocKhoa = new System.Windows.Forms.Label();
			this.pnlInfo1 = new System.Windows.Forms.Panel();
			this.tbSubjectName = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbSubjectID = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbMaMon = new System.Windows.Forms.Label();
			this.lbTenMonThi = new System.Windows.Forms.Label();
			this.pnl1Shadow = new System.Windows.Forms.Panel();
			this.pnl2Shadow = new System.Windows.Forms.Panel();
			this.pnl3Shadow = new System.Windows.Forms.Panel();
			this.pnlDataGridView = new System.Windows.Forms.Panel();
			this.iconSearch = new FontAwesome.Sharp.IconButton();
			this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClearFilter = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnCancle = new FontAwesome.Sharp.IconButton();
			this.btnSearch = new FontAwesome.Sharp.IconButton();
			this.pnlDataGridViewShadow = new System.Windows.Forms.Panel();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlControls.SuspendLayout();
			this.pnlInfo3.SuspendLayout();
			this.pnlInfo2.SuspendLayout();
			this.pnlInfo1.SuspendLayout();
			this.pnlDataGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(85, 20);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(242, 37);
			this.lbTitle.TabIndex = 14;
			this.lbTitle.Text = "Quản lý môn thi";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.White;
			this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAdd.IconSize = 28;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdd.Location = new System.Drawing.Point(1390, 23);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnAdd.Size = new System.Drawing.Size(110, 40);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnAdd, "Thêm môn thi");
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnAdd.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Shapes;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(45, 21);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 0;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// pnlControls
			// 
			this.pnlControls.BackColor = System.Drawing.Color.Transparent;
			this.pnlControls.Controls.Add(this.pnlInfo3);
			this.pnlControls.Controls.Add(this.pnlInfo2);
			this.pnlControls.Controls.Add(this.pnlInfo1);
			this.pnlControls.Controls.Add(this.pnl1Shadow);
			this.pnlControls.Controls.Add(this.pnl2Shadow);
			this.pnlControls.Controls.Add(this.pnl3Shadow);
			this.pnlControls.Location = new System.Drawing.Point(26, 69);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(1498, 216);
			this.pnlControls.TabIndex = 36;
			// 
			// pnlInfo3
			// 
			this.pnlInfo3.BackColor = System.Drawing.Color.White;
			this.pnlInfo3.Controls.Add(this.cbSemesterID);
			this.pnlInfo3.Controls.Add(this.cbSubjectRole);
			this.pnlInfo3.Controls.Add(this.tbDescription);
			this.pnlInfo3.Controls.Add(this.lbMoTa);
			this.pnlInfo3.Controls.Add(this.lbThuocHocKy);
			this.pnlInfo3.Controls.Add(this.lbKieuMon);
			this.pnlInfo3.Location = new System.Drawing.Point(1016, 23);
			this.pnlInfo3.Name = "pnlInfo3";
			this.pnlInfo3.Size = new System.Drawing.Size(454, 168);
			this.pnlInfo3.TabIndex = 23;
			// 
			// cbSemesterID
			// 
			this.cbSemesterID.BackColor = System.Drawing.Color.White;
			this.cbSemesterID.BorderRadius = 4;
			this.cbSemesterID.Color = System.Drawing.Color.Gray;
			this.cbSemesterID.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbSemesterID.DisabledColor = System.Drawing.Color.Gray;
			this.cbSemesterID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSemesterID.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbSemesterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSemesterID.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbSemesterID.FillDropDown = false;
			this.cbSemesterID.FillIndicator = false;
			this.cbSemesterID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbSemesterID.Font = new System.Drawing.Font("Arial", 14.25F);
			this.cbSemesterID.ForeColor = System.Drawing.Color.Black;
			this.cbSemesterID.FormattingEnabled = true;
			this.cbSemesterID.Icon = null;
			this.cbSemesterID.IndicatorColor = System.Drawing.Color.Black;
			this.cbSemesterID.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbSemesterID.ItemBackColor = System.Drawing.Color.White;
			this.cbSemesterID.ItemBorderColor = System.Drawing.Color.White;
			this.cbSemesterID.ItemForeColor = System.Drawing.Color.Black;
			this.cbSemesterID.ItemHeight = 30;
			this.cbSemesterID.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbSemesterID.Location = new System.Drawing.Point(237, 41);
			this.cbSemesterID.Name = "cbSemesterID";
			this.cbSemesterID.Size = new System.Drawing.Size(190, 36);
			this.cbSemesterID.TabIndex = 48;
			this.cbSemesterID.Text = null;
			// 
			// cbSubjectRole
			// 
			this.cbSubjectRole.BackColor = System.Drawing.Color.White;
			this.cbSubjectRole.BorderRadius = 4;
			this.cbSubjectRole.Color = System.Drawing.Color.Gray;
			this.cbSubjectRole.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbSubjectRole.DisabledColor = System.Drawing.Color.Gray;
			this.cbSubjectRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSubjectRole.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbSubjectRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubjectRole.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbSubjectRole.FillDropDown = false;
			this.cbSubjectRole.FillIndicator = false;
			this.cbSubjectRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbSubjectRole.Font = new System.Drawing.Font("Arial", 14.25F);
			this.cbSubjectRole.ForeColor = System.Drawing.Color.Black;
			this.cbSubjectRole.FormattingEnabled = true;
			this.cbSubjectRole.Icon = null;
			this.cbSubjectRole.IndicatorColor = System.Drawing.Color.Black;
			this.cbSubjectRole.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbSubjectRole.ItemBackColor = System.Drawing.Color.White;
			this.cbSubjectRole.ItemBorderColor = System.Drawing.Color.White;
			this.cbSubjectRole.ItemForeColor = System.Drawing.Color.Black;
			this.cbSubjectRole.ItemHeight = 30;
			this.cbSubjectRole.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbSubjectRole.Location = new System.Drawing.Point(27, 41);
			this.cbSubjectRole.Name = "cbSubjectRole";
			this.cbSubjectRole.Size = new System.Drawing.Size(190, 36);
			this.cbSubjectRole.TabIndex = 47;
			this.cbSubjectRole.Text = null;
			// 
			// tbDescription
			// 
			this.tbDescription.BorderColor = System.Drawing.Color.Gray;
			this.tbDescription.BorderRadius = 5;
			this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbDescription.DefaultText = "";
			this.tbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbDescription.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDescription.DisabledState.Parent = this.tbDescription;
			this.tbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDescription.FocusedState.Parent = this.tbDescription;
			this.tbDescription.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbDescription.ForeColor = System.Drawing.Color.Black;
			this.tbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDescription.HoverState.Parent = this.tbDescription;
			this.tbDescription.Location = new System.Drawing.Point(27, 115);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.PasswordChar = '\0';
			this.tbDescription.PlaceholderText = "";
			this.tbDescription.SelectedText = "";
			this.tbDescription.ShadowDecoration.Parent = this.tbDescription;
			this.tbDescription.Size = new System.Drawing.Size(400, 35);
			this.tbDescription.TabIndex = 7;
			// 
			// lbMoTa
			// 
			this.lbMoTa.AutoSize = true;
			this.lbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMoTa.Location = new System.Drawing.Point(34, 92);
			this.lbMoTa.Name = "lbMoTa";
			this.lbMoTa.Size = new System.Drawing.Size(53, 20);
			this.lbMoTa.TabIndex = 4;
			this.lbMoTa.Text = "Mô tả:";
			// 
			// lbThuocHocKy
			// 
			this.lbThuocHocKy.AutoSize = true;
			this.lbThuocHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThuocHocKy.Location = new System.Drawing.Point(243, 18);
			this.lbThuocHocKy.Name = "lbThuocHocKy";
			this.lbThuocHocKy.Size = new System.Drawing.Size(106, 20);
			this.lbThuocHocKy.TabIndex = 6;
			this.lbThuocHocKy.Text = "Thuộc học kỳ:";
			// 
			// lbKieuMon
			// 
			this.lbKieuMon.AutoSize = true;
			this.lbKieuMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKieuMon.Location = new System.Drawing.Point(34, 18);
			this.lbKieuMon.Name = "lbKieuMon";
			this.lbKieuMon.Size = new System.Drawing.Size(79, 20);
			this.lbKieuMon.TabIndex = 4;
			this.lbKieuMon.Text = "Kiểu môn:";
			// 
			// pnlInfo2
			// 
			this.pnlInfo2.BackColor = System.Drawing.Color.White;
			this.pnlInfo2.Controls.Add(this.cbCourseID);
			this.pnlInfo2.Controls.Add(this.cbFacultyID);
			this.pnlInfo2.Controls.Add(this.lbDanhChoKhoa);
			this.pnlInfo2.Controls.Add(this.lbThuocKhoa);
			this.pnlInfo2.Location = new System.Drawing.Point(520, 23);
			this.pnlInfo2.Name = "pnlInfo2";
			this.pnlInfo2.Size = new System.Drawing.Size(454, 168);
			this.pnlInfo2.TabIndex = 22;
			// 
			// cbCourseID
			// 
			this.cbCourseID.BackColor = System.Drawing.Color.White;
			this.cbCourseID.BorderRadius = 4;
			this.cbCourseID.Color = System.Drawing.Color.Gray;
			this.cbCourseID.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbCourseID.DisabledColor = System.Drawing.Color.Gray;
			this.cbCourseID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbCourseID.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCourseID.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbCourseID.FillDropDown = false;
			this.cbCourseID.FillIndicator = false;
			this.cbCourseID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCourseID.Font = new System.Drawing.Font("Arial", 14.25F);
			this.cbCourseID.ForeColor = System.Drawing.Color.Black;
			this.cbCourseID.FormattingEnabled = true;
			this.cbCourseID.Icon = null;
			this.cbCourseID.IndicatorColor = System.Drawing.Color.Black;
			this.cbCourseID.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbCourseID.ItemBackColor = System.Drawing.Color.White;
			this.cbCourseID.ItemBorderColor = System.Drawing.Color.White;
			this.cbCourseID.ItemForeColor = System.Drawing.Color.Black;
			this.cbCourseID.ItemHeight = 30;
			this.cbCourseID.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbCourseID.Location = new System.Drawing.Point(27, 115);
			this.cbCourseID.Name = "cbCourseID";
			this.cbCourseID.Size = new System.Drawing.Size(400, 36);
			this.cbCourseID.TabIndex = 46;
			this.cbCourseID.Text = null;
			// 
			// cbFacultyID
			// 
			this.cbFacultyID.BackColor = System.Drawing.Color.White;
			this.cbFacultyID.BorderRadius = 4;
			this.cbFacultyID.Color = System.Drawing.Color.Gray;
			this.cbFacultyID.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbFacultyID.DisabledColor = System.Drawing.Color.Gray;
			this.cbFacultyID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbFacultyID.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbFacultyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFacultyID.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbFacultyID.FillDropDown = false;
			this.cbFacultyID.FillIndicator = false;
			this.cbFacultyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbFacultyID.Font = new System.Drawing.Font("Arial", 14.25F);
			this.cbFacultyID.ForeColor = System.Drawing.Color.Black;
			this.cbFacultyID.FormattingEnabled = true;
			this.cbFacultyID.Icon = null;
			this.cbFacultyID.IndicatorColor = System.Drawing.Color.Black;
			this.cbFacultyID.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbFacultyID.ItemBackColor = System.Drawing.Color.White;
			this.cbFacultyID.ItemBorderColor = System.Drawing.Color.White;
			this.cbFacultyID.ItemForeColor = System.Drawing.Color.Black;
			this.cbFacultyID.ItemHeight = 30;
			this.cbFacultyID.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbFacultyID.Location = new System.Drawing.Point(27, 41);
			this.cbFacultyID.Name = "cbFacultyID";
			this.cbFacultyID.Size = new System.Drawing.Size(400, 36);
			this.cbFacultyID.TabIndex = 45;
			this.cbFacultyID.Text = null;
			this.cbFacultyID.SelectedIndexChanged += new System.EventHandler(this.cbFacultyID_SelectedIndexChanged);
			// 
			// lbDanhChoKhoa
			// 
			this.lbDanhChoKhoa.AutoSize = true;
			this.lbDanhChoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDanhChoKhoa.Location = new System.Drawing.Point(34, 92);
			this.lbDanhChoKhoa.Name = "lbDanhChoKhoa";
			this.lbDanhChoKhoa.Size = new System.Drawing.Size(117, 20);
			this.lbDanhChoKhoa.TabIndex = 6;
			this.lbDanhChoKhoa.Text = "Dành cho khóa";
			// 
			// lbThuocKhoa
			// 
			this.lbThuocKhoa.AutoSize = true;
			this.lbThuocKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThuocKhoa.Location = new System.Drawing.Point(34, 18);
			this.lbThuocKhoa.Name = "lbThuocKhoa";
			this.lbThuocKhoa.Size = new System.Drawing.Size(96, 20);
			this.lbThuocKhoa.TabIndex = 2;
			this.lbThuocKhoa.Text = "Thuộc khoa:";
			// 
			// pnlInfo1
			// 
			this.pnlInfo1.BackColor = System.Drawing.Color.White;
			this.pnlInfo1.Controls.Add(this.tbSubjectName);
			this.pnlInfo1.Controls.Add(this.tbSubjectID);
			this.pnlInfo1.Controls.Add(this.lbMaMon);
			this.pnlInfo1.Controls.Add(this.lbTenMonThi);
			this.pnlInfo1.Location = new System.Drawing.Point(24, 23);
			this.pnlInfo1.Name = "pnlInfo1";
			this.pnlInfo1.Size = new System.Drawing.Size(454, 168);
			this.pnlInfo1.TabIndex = 21;
			// 
			// tbSubjectName
			// 
			this.tbSubjectName.BorderColor = System.Drawing.Color.Gray;
			this.tbSubjectName.BorderRadius = 5;
			this.tbSubjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSubjectName.DefaultText = "";
			this.tbSubjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSubjectName.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbSubjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSubjectName.DisabledState.Parent = this.tbSubjectName;
			this.tbSubjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSubjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSubjectName.FocusedState.Parent = this.tbSubjectName;
			this.tbSubjectName.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbSubjectName.ForeColor = System.Drawing.Color.Black;
			this.tbSubjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSubjectName.HoverState.Parent = this.tbSubjectName;
			this.tbSubjectName.Location = new System.Drawing.Point(27, 115);
			this.tbSubjectName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbSubjectName.Name = "tbSubjectName";
			this.tbSubjectName.PasswordChar = '\0';
			this.tbSubjectName.PlaceholderText = "";
			this.tbSubjectName.SelectedText = "";
			this.tbSubjectName.ShadowDecoration.Parent = this.tbSubjectName;
			this.tbSubjectName.Size = new System.Drawing.Size(400, 35);
			this.tbSubjectName.TabIndex = 6;
			// 
			// tbSubjectID
			// 
			this.tbSubjectID.BorderColor = System.Drawing.Color.Gray;
			this.tbSubjectID.BorderRadius = 5;
			this.tbSubjectID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSubjectID.DefaultText = "";
			this.tbSubjectID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSubjectID.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbSubjectID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSubjectID.DisabledState.Parent = this.tbSubjectID;
			this.tbSubjectID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSubjectID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSubjectID.FocusedState.Parent = this.tbSubjectID;
			this.tbSubjectID.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbSubjectID.ForeColor = System.Drawing.Color.Black;
			this.tbSubjectID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSubjectID.HoverState.Parent = this.tbSubjectID;
			this.tbSubjectID.Location = new System.Drawing.Point(27, 41);
			this.tbSubjectID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbSubjectID.Name = "tbSubjectID";
			this.tbSubjectID.PasswordChar = '\0';
			this.tbSubjectID.PlaceholderText = "";
			this.tbSubjectID.SelectedText = "";
			this.tbSubjectID.ShadowDecoration.Parent = this.tbSubjectID;
			this.tbSubjectID.Size = new System.Drawing.Size(400, 35);
			this.tbSubjectID.TabIndex = 5;
			// 
			// lbMaMon
			// 
			this.lbMaMon.AutoSize = true;
			this.lbMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaMon.Location = new System.Drawing.Point(34, 18);
			this.lbMaMon.Name = "lbMaMon";
			this.lbMaMon.Size = new System.Drawing.Size(70, 20);
			this.lbMaMon.TabIndex = 0;
			this.lbMaMon.Text = "Mã môn:";
			// 
			// lbTenMonThi
			// 
			this.lbTenMonThi.AutoSize = true;
			this.lbTenMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenMonThi.Location = new System.Drawing.Point(34, 92);
			this.lbTenMonThi.Name = "lbTenMonThi";
			this.lbTenMonThi.Size = new System.Drawing.Size(96, 20);
			this.lbTenMonThi.TabIndex = 4;
			this.lbTenMonThi.Text = "Tên môn thi:";
			// 
			// pnl1Shadow
			// 
			this.pnl1Shadow.BackColor = System.Drawing.Color.Silver;
			this.pnl1Shadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnl1Shadow.Location = new System.Drawing.Point(27, 26);
			this.pnl1Shadow.Name = "pnl1Shadow";
			this.pnl1Shadow.Size = new System.Drawing.Size(454, 168);
			this.pnl1Shadow.TabIndex = 24;
			// 
			// pnl2Shadow
			// 
			this.pnl2Shadow.BackColor = System.Drawing.Color.Silver;
			this.pnl2Shadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnl2Shadow.Location = new System.Drawing.Point(523, 26);
			this.pnl2Shadow.Name = "pnl2Shadow";
			this.pnl2Shadow.Size = new System.Drawing.Size(454, 168);
			this.pnl2Shadow.TabIndex = 25;
			// 
			// pnl3Shadow
			// 
			this.pnl3Shadow.BackColor = System.Drawing.Color.Silver;
			this.pnl3Shadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnl3Shadow.Location = new System.Drawing.Point(1020, 26);
			this.pnl3Shadow.Name = "pnl3Shadow";
			this.pnl3Shadow.Size = new System.Drawing.Size(454, 168);
			this.pnl3Shadow.TabIndex = 26;
			// 
			// pnlDataGridView
			// 
			this.pnlDataGridView.BackColor = System.Drawing.Color.White;
			this.pnlDataGridView.Controls.Add(this.iconSearch);
			this.pnlDataGridView.Controls.Add(this.bScrollBar);
			this.pnlDataGridView.Controls.Add(this.tbSearch);
			this.pnlDataGridView.Controls.Add(this.aDgvdata);
			this.pnlDataGridView.Controls.Add(this.btnClearFilter);
			this.pnlDataGridView.Controls.Add(this.btnEdit);
			this.pnlDataGridView.Controls.Add(this.btnDelete);
			this.pnlDataGridView.Controls.Add(this.btnSave);
			this.pnlDataGridView.Controls.Add(this.btnCancle);
			this.pnlDataGridView.Controls.Add(this.btnSearch);
			this.pnlDataGridView.Location = new System.Drawing.Point(11, 291);
			this.pnlDataGridView.Name = "pnlDataGridView";
			this.pnlDataGridView.Size = new System.Drawing.Size(1526, 518);
			this.pnlDataGridView.TabIndex = 38;
			// 
			// iconSearch
			// 
			this.iconSearch.BackColor = System.Drawing.Color.Transparent;
			this.iconSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.iconSearch.FlatAppearance.BorderSize = 0;
			this.iconSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.iconSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconSearch.IconSize = 30;
			this.iconSearch.Location = new System.Drawing.Point(283, 27);
			this.iconSearch.Name = "iconSearch";
			this.iconSearch.Size = new System.Drawing.Size(35, 30);
			this.iconSearch.TabIndex = 16;
			this.iconSearch.TabStop = false;
			this.iconSearch.UseVisualStyleBackColor = false;
			this.iconSearch.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// bScrollBar
			// 
			this.bScrollBar.AllowCursorChanges = true;
			this.bScrollBar.AllowHomeEndKeysDetection = false;
			this.bScrollBar.AllowIncrementalClickMoves = true;
			this.bScrollBar.AllowMouseDownEffects = false;
			this.bScrollBar.AllowMouseHoverEffects = false;
			this.bScrollBar.AllowScrollingAnimations = true;
			this.bScrollBar.AllowScrollKeysDetection = true;
			this.bScrollBar.AllowScrollOptionsMenu = true;
			this.bScrollBar.AllowShrinkingOnFocusLost = false;
			this.bScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bScrollBar.AutoScroll = true;
			this.bScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bScrollBar.BackgroundImage")));
			this.bScrollBar.BindingContainer = null;
			this.bScrollBar.BorderRadius = 2;
			this.bScrollBar.BorderThickness = 1;
			this.bScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bScrollBar.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
			this.bScrollBar.DrawThickBorder = false;
			this.bScrollBar.DurationBeforeShrink = 2000;
			this.bScrollBar.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.LargeChange = 10;
			this.bScrollBar.Location = new System.Drawing.Point(1492, 119);
			this.bScrollBar.Maximum = 100;
			this.bScrollBar.Minimum = 0;
			this.bScrollBar.MinimumSize = new System.Drawing.Size(31, 0);
			this.bScrollBar.MinimumThumbLength = 18;
			this.bScrollBar.Name = "bScrollBar";
			this.bScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
			this.bScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
			this.bScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
			this.bScrollBar.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
			this.bScrollBar.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
			this.bScrollBar.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
			this.bScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.ShrinkSizeLimit = 3;
			this.bScrollBar.Size = new System.Drawing.Size(31, 385);
			this.bScrollBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
			this.bScrollBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
			this.bScrollBar.SmallChange = 1;
			this.bScrollBar.TabIndex = 11;
			this.bScrollBar.ThumbColor = System.Drawing.Color.DodgerBlue;
			this.bScrollBar.ThumbFillColor = System.Drawing.Color.White;
			this.bScrollBar.ThumbLength = 38;
			this.bScrollBar.ThumbMargin = 1;
			this.bScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
			this.bScrollBar.Value = 100;
			this.bScrollBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs>(this.bScrollBar_Scroll);
			// 
			// tbSearch
			// 
			this.tbSearch.BorderColor = System.Drawing.Color.Gray;
			this.tbSearch.BorderRadius = 5;
			this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearch.DefaultText = "";
			this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.DisabledState.Parent = this.tbSearch;
			this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.FocusedState.Parent = this.tbSearch;
			this.tbSearch.Font = new System.Drawing.Font("Arial", 12F);
			this.tbSearch.ForeColor = System.Drawing.Color.Black;
			this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.HoverState.Parent = this.tbSearch;
			this.tbSearch.Location = new System.Drawing.Point(39, 24);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Nhập từ khóa ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
			this.tbSearch.Size = new System.Drawing.Size(281, 35);
			this.tbSearch.TabIndex = 8;
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// aDgvdata
			// 
			this.aDgvdata.AllowUserToAddRows = false;
			this.aDgvdata.AllowUserToDeleteRows = false;
			this.aDgvdata.AllowUserToResizeRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
			this.aDgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.aDgvdata.AutoGenerateContextFilters = true;
			this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.aDgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
			this.aDgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aDgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.aDgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.aDgvdata.ColumnHeadersHeight = 40;
			this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle16;
			this.aDgvdata.EnableHeadersVisualStyles = false;
			this.aDgvdata.Location = new System.Drawing.Point(34, 79);
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.aDgvdata.RowHeadersVisible = false;
			this.aDgvdata.RowTemplate.Height = 50;
			this.aDgvdata.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1455, 425);
			this.aDgvdata.TabIndex = 7;
			this.aDgvdata.TimeFilter = false;
			this.aDgvdata.SortStringChanged += new System.EventHandler(this.aDgvdata_SortStringChanged);
			this.aDgvdata.FilterStringChanged += new System.EventHandler(this.aDgvdata_FilterStringChanged);
			this.aDgvdata.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDgvdata_RowEnter);
			this.aDgvdata.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.aDgvdata_RowPrePaint);
			this.aDgvdata.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aDgvdata_RowsAdded);
			this.aDgvdata.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.aDgvdata_RowsRemoved);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle11;
			this.STT.FillWeight = 40F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectName
			// 
			this.SubjectName.DataPropertyName = "SubjectName";
			this.SubjectName.FillWeight = 110F;
			this.SubjectName.HeaderText = "Tên môn thi";
			this.SubjectName.MinimumWidth = 22;
			this.SubjectName.Name = "SubjectName";
			this.SubjectName.ReadOnly = true;
			this.SubjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SubjectID.DefaultCellStyle = dataGridViewCellStyle12;
			this.SubjectID.FillWeight = 50F;
			this.SubjectID.HeaderText = "Mã môn thi";
			this.SubjectID.MinimumWidth = 22;
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectRole
			// 
			this.SubjectRole.DataPropertyName = "SubjectRole";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.Format = "d";
			dataGridViewCellStyle13.NullValue = "dd/MM/yyyy";
			this.SubjectRole.DefaultCellStyle = dataGridViewCellStyle13;
			this.SubjectRole.FillWeight = 50F;
			this.SubjectRole.HeaderText = "Kiểu môn";
			this.SubjectRole.MinimumWidth = 22;
			this.SubjectRole.Name = "SubjectRole";
			this.SubjectRole.ReadOnly = true;
			this.SubjectRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// FacultyID
			// 
			this.FacultyID.DataPropertyName = "FacultyID";
			this.FacultyID.FillWeight = 50F;
			this.FacultyID.HeaderText = "Thuộc khoa";
			this.FacultyID.MinimumWidth = 22;
			this.FacultyID.Name = "FacultyID";
			this.FacultyID.ReadOnly = true;
			this.FacultyID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// CourseID
			// 
			this.CourseID.DataPropertyName = "CourseID";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.CourseID.DefaultCellStyle = dataGridViewCellStyle14;
			this.CourseID.FillWeight = 50F;
			this.CourseID.HeaderText = "Dành cho khóa";
			this.CourseID.MinimumWidth = 22;
			this.CourseID.Name = "CourseID";
			this.CourseID.ReadOnly = true;
			this.CourseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SemesterID
			// 
			this.SemesterID.DataPropertyName = "SemesterID";
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SemesterID.DefaultCellStyle = dataGridViewCellStyle15;
			this.SemesterID.FillWeight = 40F;
			this.SemesterID.HeaderText = "Thuộc học kì";
			this.SemesterID.MinimumWidth = 22;
			this.SemesterID.Name = "SemesterID";
			this.SemesterID.ReadOnly = true;
			this.SemesterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.FillWeight = 130F;
			this.Description.HeaderText = "Mô tả";
			this.Description.MinimumWidth = 22;
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.BackColor = System.Drawing.Color.Gainsboro;
			this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClearFilter.FlatAppearance.BorderSize = 0;
			this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFilter.ForeColor = System.Drawing.Color.White;
			this.btnClearFilter.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
			this.btnClearFilter.IconColor = System.Drawing.SystemColors.WindowText;
			this.btnClearFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnClearFilter.IconSize = 28;
			this.btnClearFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClearFilter.Location = new System.Drawing.Point(325, 21);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(40, 40);
			this.btnClearFilter.TabIndex = 2;
			this.btnClearFilter.TabStop = false;
			this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnClearFilter, "Hủy thao tác lọc dữ liệu");
			this.btnClearFilter.UseVisualStyleBackColor = false;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			this.btnClearFilter.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
			this.btnEdit.IconColor = System.Drawing.Color.White;
			this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEdit.IconSize = 28;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEdit.Location = new System.Drawing.Point(1250, 21);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnEdit.Size = new System.Drawing.Size(110, 40);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.TabStop = false;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnEdit, "Sửa môn thi");
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			this.btnEdit.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnDelete.IconColor = System.Drawing.Color.White;
			this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDelete.IconSize = 28;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDelete.Location = new System.Drawing.Point(1378, 21);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnDelete.Size = new System.Drawing.Size(110, 40);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = " Xóa";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnDelete, "Xóa môn thi");
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnDelete.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Green;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
			this.btnSave.IconColor = System.Drawing.Color.White;
			this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSave.IconSize = 28;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Location = new System.Drawing.Point(1378, 21);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 4;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnSave, "Lưu dữ liệu");
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnCancle
			// 
			this.btnCancle.BackColor = System.Drawing.Color.DarkGray;
			this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCancle.FlatAppearance.BorderSize = 0;
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnCancle.ForeColor = System.Drawing.Color.White;
			this.btnCancle.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
			this.btnCancle.IconColor = System.Drawing.Color.White;
			this.btnCancle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancle.IconSize = 28;
			this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancle.Location = new System.Drawing.Point(1250, 21);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCancle.Size = new System.Drawing.Size(110, 40);
			this.btnCancle.TabIndex = 3;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnCancle, "Hủy thao tác");
			this.btnCancle.UseVisualStyleBackColor = false;
			this.btnCancle.Visible = false;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			this.btnCancle.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.Gray;
			this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSearch.IconSize = 30;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSearch.Location = new System.Drawing.Point(289, 26);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(30, 30);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.TabStop = false;
			this.toolTip.SetToolTip(this.btnSearch, "Tìm kiếm");
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnSearch.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// pnlDataGridViewShadow
			// 
			this.pnlDataGridViewShadow.BackColor = System.Drawing.Color.Silver;
			this.pnlDataGridViewShadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnlDataGridViewShadow.Location = new System.Drawing.Point(14, 294);
			this.pnlDataGridViewShadow.Name = "pnlDataGridViewShadow";
			this.pnlDataGridViewShadow.Size = new System.Drawing.Size(1526, 518);
			this.pnlDataGridViewShadow.TabIndex = 39;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 0;
			this.toolTip.AutoPopDelay = 10000;
			this.toolTip.InitialDelay = 0;
			this.toolTip.ReshowDelay = 0;
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip.ToolTipTitle = "Suggest";
			// 
			// ManageSubject
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlDataGridView);
			this.Controls.Add(this.pnlDataGridViewShadow);
			this.Controls.Add(this.pnlControls);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Name = "ManageSubject";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmManageSubject_Load);
			this.pnlControls.ResumeLayout(false);
			this.pnlInfo3.ResumeLayout(false);
			this.pnlInfo3.PerformLayout();
			this.pnlInfo2.ResumeLayout(false);
			this.pnlInfo2.PerformLayout();
			this.pnlInfo1.ResumeLayout(false);
			this.pnlInfo1.PerformLayout();
			this.pnlDataGridView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton btnAdd;
		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Panel pnlInfo3;
		private Guna.UI2.WinForms.Guna2TextBox tbDescription;
		private System.Windows.Forms.Label lbMoTa;
		private System.Windows.Forms.Label lbThuocHocKy;
		private System.Windows.Forms.Label lbKieuMon;
		private System.Windows.Forms.Panel pnlInfo2;
		private System.Windows.Forms.Label lbDanhChoKhoa;
		private System.Windows.Forms.Label lbThuocKhoa;
		private System.Windows.Forms.Panel pnlInfo1;
		private Guna.UI2.WinForms.Guna2TextBox tbSubjectName;
		private Guna.UI2.WinForms.Guna2TextBox tbSubjectID;
		private System.Windows.Forms.Label lbMaMon;
		private System.Windows.Forms.Label lbTenMonThi;
		private System.Windows.Forms.Panel pnl1Shadow;
		private System.Windows.Forms.Panel pnl2Shadow;
		private System.Windows.Forms.Panel pnl3Shadow;
		private System.Windows.Forms.Panel pnlDataGridView;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private ADGV.AdvancedDataGridView aDgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SemesterID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnDelete;
		public FontAwesome.Sharp.IconButton btnSave;
		public FontAwesome.Sharp.IconButton btnCancle;
		private FontAwesome.Sharp.IconButton btnSearch;
		private System.Windows.Forms.Panel pnlDataGridViewShadow;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private Bunifu.UI.WinForms.BunifuDropdown cbSemesterID;
		private Bunifu.UI.WinForms.BunifuDropdown cbSubjectRole;
		private Bunifu.UI.WinForms.BunifuDropdown cbCourseID;
		private Bunifu.UI.WinForms.BunifuDropdown cbFacultyID;
		private System.Windows.Forms.ToolTip toolTip;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
        private FontAwesome.Sharp.IconButton iconSearch;
    }
}