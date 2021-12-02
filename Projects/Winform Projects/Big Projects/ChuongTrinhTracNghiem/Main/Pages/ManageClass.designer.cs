
namespace Main.Pages
{
	partial class ManageClass
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageClass));
			this.lbTitle = new System.Windows.Forms.Label();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AdmissionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NofTrainingSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
			this.btnClearFilter = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnCancle = new FontAwesome.Sharp.IconButton();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.pnlInfo3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.cbNumberOfTrainingSemester = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbNamNhapHoc = new System.Windows.Forms.Label();
			this.nudAdmissionYear = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.lbSoHKDaoTao = new System.Windows.Forms.Label();
			this.pnlInfo2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.cbFaculty = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbCourseID = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbTenKhoa = new System.Windows.Forms.Label();
			this.lbKhoa = new System.Windows.Forms.Label();
			this.pnlInfo1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbClassID = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbMaLop = new System.Windows.Forms.Label();
			this.lbMoTa = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlDataGridView = new Guna.UI2.WinForms.Guna2ShadowPanel();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.pnlControls.SuspendLayout();
			this.pnlInfo3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAdmissionYear)).BeginInit();
			this.pnlInfo2.SuspendLayout();
			this.pnlInfo1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.pnlDataGridView.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(110, 22);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(182, 35);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý lớp";
			this.lbTitle.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// aDgvdata
			// 
			this.aDgvdata.AllowUserToAddRows = false;
			this.aDgvdata.AllowUserToDeleteRows = false;
			this.aDgvdata.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
			this.aDgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.aDgvdata.AutoGenerateContextFilters = true;
			this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.aDgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
			this.aDgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aDgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.aDgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.aDgvdata.ColumnHeadersHeight = 40;
			this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.aDgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ClassID,
            this.FacultyID,
            this.CourseID,
            this.AdmissionYear,
            this.NofTrainingSemester,
            this.Description});
			this.aDgvdata.DateWithTime = false;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle9;
			this.aDgvdata.EnableHeadersVisualStyles = false;
			this.aDgvdata.Location = new System.Drawing.Point(45, 56);
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.aDgvdata.RowHeadersVisible = false;
			this.aDgvdata.RowTemplate.Height = 50;
			this.aDgvdata.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1430, 427);
			this.aDgvdata.TabIndex = 0;
			this.aDgvdata.TabStop = false;
			this.aDgvdata.TimeFilter = false;
			this.aDgvdata.SortStringChanged += new System.EventHandler(this.aDgvdata_SortStringChanged);
			this.aDgvdata.FilterStringChanged += new System.EventHandler(this.aDgvdata_FilterStringChanged);
			this.aDgvdata.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDgvdata_RowEnter);
			this.aDgvdata.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.aDgvdata_RowPrePaint);
			this.aDgvdata.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aDgvdata_RowsAdded);
			this.aDgvdata.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.aDgvdata_RowsRemoved);
			this.aDgvdata.Click += new System.EventHandler(this.ManageClass_Click);
			this.aDgvdata.Enter += new System.EventHandler(this.aDgvdata_Enter);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle3;
			this.STT.FillWeight = 40F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ClassID
			// 
			this.ClassID.DataPropertyName = "ClassID";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ClassID.DefaultCellStyle = dataGridViewCellStyle4;
			this.ClassID.FillWeight = 60F;
			this.ClassID.HeaderText = "Mã lớp";
			this.ClassID.MinimumWidth = 22;
			this.ClassID.Name = "ClassID";
			this.ClassID.ReadOnly = true;
			this.ClassID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// FacultyID
			// 
			this.FacultyID.DataPropertyName = "FacultyID";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.NullValue = "NULL";
			this.FacultyID.DefaultCellStyle = dataGridViewCellStyle5;
			this.FacultyID.FillWeight = 60F;
			this.FacultyID.HeaderText = "Mã khoa";
			this.FacultyID.MinimumWidth = 22;
			this.FacultyID.Name = "FacultyID";
			this.FacultyID.ReadOnly = true;
			this.FacultyID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// CourseID
			// 
			this.CourseID.DataPropertyName = "CourseID";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.NullValue = "NULL";
			this.CourseID.DefaultCellStyle = dataGridViewCellStyle6;
			this.CourseID.FillWeight = 60F;
			this.CourseID.HeaderText = "Khóa";
			this.CourseID.MinimumWidth = 22;
			this.CourseID.Name = "CourseID";
			this.CourseID.ReadOnly = true;
			this.CourseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// AdmissionYear
			// 
			this.AdmissionYear.DataPropertyName = "AdmissionYear";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.AdmissionYear.DefaultCellStyle = dataGridViewCellStyle7;
			this.AdmissionYear.FillWeight = 60F;
			this.AdmissionYear.HeaderText = "Năm nhập học";
			this.AdmissionYear.MinimumWidth = 22;
			this.AdmissionYear.Name = "AdmissionYear";
			this.AdmissionYear.ReadOnly = true;
			this.AdmissionYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// NofTrainingSemester
			// 
			this.NofTrainingSemester.DataPropertyName = "NofTrainingSemester";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.NofTrainingSemester.DefaultCellStyle = dataGridViewCellStyle8;
			this.NofTrainingSemester.FillWeight = 40F;
			this.NofTrainingSemester.HeaderText = "Số học kì đào tạo";
			this.NofTrainingSemester.MinimumWidth = 22;
			this.NofTrainingSemester.Name = "NofTrainingSemester";
			this.NofTrainingSemester.ReadOnly = true;
			this.NofTrainingSemester.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "Mô tả";
			this.Description.MinimumWidth = 22;
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			this.tbSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.ForeColor = System.Drawing.Color.Black;
			this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.HoverState.Parent = this.tbSearch;
			this.tbSearch.IconRight = global::Main.Properties.Resources.searchIcon;
			this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.tbSearch.Location = new System.Drawing.Point(57, 12);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Nhập từ khóa ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
			this.tbSearch.Size = new System.Drawing.Size(281, 35);
			this.tbSearch.TabIndex = 0;
			this.tbSearch.TabStop = false;
			this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
			this.tbSearch.Click += new System.EventHandler(this.ManageClass_Click);
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			this.tbSearch.MouseLeave += new System.EventHandler(this.tbSearch_Leave);
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
			this.bScrollBar.Location = new System.Drawing.Point(1481, 96);
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
			this.bScrollBar.Size = new System.Drawing.Size(31, 387);
			this.bScrollBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
			this.bScrollBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
			this.bScrollBar.SmallChange = 1;
			this.bScrollBar.TabIndex = 0;
			this.bScrollBar.TabStop = false;
			this.bScrollBar.ThumbColor = System.Drawing.Color.DodgerBlue;
			this.bScrollBar.ThumbFillColor = System.Drawing.Color.White;
			this.bScrollBar.ThumbLength = 38;
			this.bScrollBar.ThumbMargin = 1;
			this.bScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
			this.bScrollBar.Value = 100;
			this.bScrollBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs>(this.bScrollBar_Scroll);
			this.bScrollBar.Click += new System.EventHandler(this.ManageClass_Click);
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
			this.btnClearFilter.IconSize = 25;
			this.btnClearFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClearFilter.Location = new System.Drawing.Point(342, 12);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(35, 35);
			this.btnClearFilter.TabIndex = 0;
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
			this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
			this.btnEdit.IconColor = System.Drawing.Color.White;
			this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEdit.IconSize = 28;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEdit.Location = new System.Drawing.Point(1224, 10);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnEdit.Size = new System.Drawing.Size(110, 40);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.TabStop = false;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnEdit, "Sửa lớp học");
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
			this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnDelete.IconColor = System.Drawing.Color.White;
			this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDelete.IconSize = 28;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDelete.Location = new System.Drawing.Point(1352, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnDelete.Size = new System.Drawing.Size(110, 40);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.TabStop = false;
			this.btnDelete.Text = " Xóa";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnDelete, "Xóa lớp học");
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
			this.btnSave.Location = new System.Drawing.Point(1352, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 0;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
			this.btnCancle.Location = new System.Drawing.Point(1224, 10);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCancle.Size = new System.Drawing.Size(110, 40);
			this.btnCancle.TabIndex = 0;
			this.btnCancle.TabStop = false;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancle.UseVisualStyleBackColor = false;
			this.btnCancle.Visible = false;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			this.btnCancle.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// pnlControls
			// 
			this.pnlControls.BackColor = System.Drawing.Color.Transparent;
			this.pnlControls.Controls.Add(this.pnlInfo3);
			this.pnlControls.Controls.Add(this.pnlInfo2);
			this.pnlControls.Controls.Add(this.pnlInfo1);
			this.pnlControls.Location = new System.Drawing.Point(25, 70);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(1500, 210);
			this.pnlControls.TabIndex = 0;
			this.pnlControls.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// pnlInfo3
			// 
			this.pnlInfo3.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfo3.Controls.Add(this.cbNumberOfTrainingSemester);
			this.pnlInfo3.Controls.Add(this.lbNamNhapHoc);
			this.pnlInfo3.Controls.Add(this.nudAdmissionYear);
			this.pnlInfo3.Controls.Add(this.lbSoHKDaoTao);
			this.pnlInfo3.FillColor = System.Drawing.Color.White;
			this.pnlInfo3.Location = new System.Drawing.Point(1005, 20);
			this.pnlInfo3.Name = "pnlInfo3";
			this.pnlInfo3.Radius = 5;
			this.pnlInfo3.ShadowColor = System.Drawing.Color.Black;
			this.pnlInfo3.ShadowDepth = 255;
			this.pnlInfo3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlInfo3.Size = new System.Drawing.Size(450, 170);
			this.pnlInfo3.TabIndex = 2;
			this.pnlInfo3.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// cbNumberOfTrainingSemester
			// 
			this.cbNumberOfTrainingSemester.BackColor = System.Drawing.Color.Transparent;
			this.cbNumberOfTrainingSemester.BorderRadius = 4;
			this.cbNumberOfTrainingSemester.Color = System.Drawing.Color.Gray;
			this.cbNumberOfTrainingSemester.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbNumberOfTrainingSemester.DisabledColor = System.Drawing.Color.Gray;
			this.cbNumberOfTrainingSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbNumberOfTrainingSemester.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbNumberOfTrainingSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNumberOfTrainingSemester.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbNumberOfTrainingSemester.FillDropDown = false;
			this.cbNumberOfTrainingSemester.FillIndicator = false;
			this.cbNumberOfTrainingSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbNumberOfTrainingSemester.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbNumberOfTrainingSemester.ForeColor = System.Drawing.Color.Black;
			this.cbNumberOfTrainingSemester.FormattingEnabled = true;
			this.cbNumberOfTrainingSemester.Icon = null;
			this.cbNumberOfTrainingSemester.IndicatorColor = System.Drawing.Color.Black;
			this.cbNumberOfTrainingSemester.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbNumberOfTrainingSemester.ItemBackColor = System.Drawing.Color.White;
			this.cbNumberOfTrainingSemester.ItemBorderColor = System.Drawing.Color.White;
			this.cbNumberOfTrainingSemester.ItemForeColor = System.Drawing.Color.Black;
			this.cbNumberOfTrainingSemester.ItemHeight = 30;
			this.cbNumberOfTrainingSemester.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbNumberOfTrainingSemester.Location = new System.Drawing.Point(35, 111);
			this.cbNumberOfTrainingSemester.Name = "cbNumberOfTrainingSemester";
			this.cbNumberOfTrainingSemester.Size = new System.Drawing.Size(380, 36);
			this.cbNumberOfTrainingSemester.TabIndex = 0;
			this.cbNumberOfTrainingSemester.TabStop = false;
			this.cbNumberOfTrainingSemester.Text = null;
			this.cbNumberOfTrainingSemester.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// lbNamNhapHoc
			// 
			this.lbNamNhapHoc.AutoSize = true;
			this.lbNamNhapHoc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNamNhapHoc.Location = new System.Drawing.Point(42, 13);
			this.lbNamNhapHoc.Name = "lbNamNhapHoc";
			this.lbNamNhapHoc.Size = new System.Drawing.Size(132, 18);
			this.lbNamNhapHoc.TabIndex = 0;
			this.lbNamNhapHoc.Text = "Năm nhập học:";
			this.lbNamNhapHoc.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// nudAdmissionYear
			// 
			this.nudAdmissionYear.BackColor = System.Drawing.Color.White;
			this.nudAdmissionYear.BorderColor = System.Drawing.Color.Gray;
			this.nudAdmissionYear.BorderRadius = 5;
			this.nudAdmissionYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudAdmissionYear.DisabledState.FillColor = System.Drawing.Color.White;
			this.nudAdmissionYear.DisabledState.Parent = this.nudAdmissionYear;
			this.nudAdmissionYear.FocusedState.Parent = this.nudAdmissionYear;
			this.nudAdmissionYear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudAdmissionYear.ForeColor = System.Drawing.Color.Black;
			this.nudAdmissionYear.Location = new System.Drawing.Point(35, 37);
			this.nudAdmissionYear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.nudAdmissionYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.nudAdmissionYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
			this.nudAdmissionYear.Name = "nudAdmissionYear";
			this.nudAdmissionYear.ShadowDecoration.Parent = this.nudAdmissionYear;
			this.nudAdmissionYear.Size = new System.Drawing.Size(380, 35);
			this.nudAdmissionYear.TabIndex = 0;
			this.nudAdmissionYear.TabStop = false;
			this.nudAdmissionYear.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
			this.nudAdmissionYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
			this.nudAdmissionYear.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// lbSoHKDaoTao
			// 
			this.lbSoHKDaoTao.AutoSize = true;
			this.lbSoHKDaoTao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoHKDaoTao.Location = new System.Drawing.Point(42, 87);
			this.lbSoHKDaoTao.Name = "lbSoHKDaoTao";
			this.lbSoHKDaoTao.Size = new System.Drawing.Size(158, 18);
			this.lbSoHKDaoTao.TabIndex = 0;
			this.lbSoHKDaoTao.Text = "Số học kì đào tạo:";
			this.lbSoHKDaoTao.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// pnlInfo2
			// 
			this.pnlInfo2.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfo2.Controls.Add(this.cbFaculty);
			this.pnlInfo2.Controls.Add(this.cbCourseID);
			this.pnlInfo2.Controls.Add(this.lbTenKhoa);
			this.pnlInfo2.Controls.Add(this.lbKhoa);
			this.pnlInfo2.FillColor = System.Drawing.Color.White;
			this.pnlInfo2.Location = new System.Drawing.Point(525, 20);
			this.pnlInfo2.Name = "pnlInfo2";
			this.pnlInfo2.Radius = 5;
			this.pnlInfo2.ShadowColor = System.Drawing.Color.Black;
			this.pnlInfo2.ShadowDepth = 255;
			this.pnlInfo2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlInfo2.Size = new System.Drawing.Size(450, 170);
			this.pnlInfo2.TabIndex = 1;
			this.pnlInfo2.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// cbFaculty
			// 
			this.cbFaculty.BackColor = System.Drawing.Color.Transparent;
			this.cbFaculty.BorderRadius = 4;
			this.cbFaculty.Color = System.Drawing.Color.Gray;
			this.cbFaculty.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbFaculty.DisabledColor = System.Drawing.Color.Gray;
			this.cbFaculty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbFaculty.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFaculty.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbFaculty.FillDropDown = false;
			this.cbFaculty.FillIndicator = false;
			this.cbFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbFaculty.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFaculty.ForeColor = System.Drawing.Color.Black;
			this.cbFaculty.FormattingEnabled = true;
			this.cbFaculty.Icon = null;
			this.cbFaculty.IndicatorColor = System.Drawing.Color.Black;
			this.cbFaculty.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbFaculty.ItemBackColor = System.Drawing.Color.White;
			this.cbFaculty.ItemBorderColor = System.Drawing.Color.White;
			this.cbFaculty.ItemForeColor = System.Drawing.Color.Black;
			this.cbFaculty.ItemHeight = 30;
			this.cbFaculty.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbFaculty.Location = new System.Drawing.Point(35, 37);
			this.cbFaculty.Name = "cbFaculty";
			this.cbFaculty.Size = new System.Drawing.Size(380, 36);
			this.cbFaculty.TabIndex = 0;
			this.cbFaculty.TabStop = false;
			this.cbFaculty.Text = null;
			this.cbFaculty.SelectedIndexChanged += new System.EventHandler(this.cbFaculty_SelectedIndexChanged);
			this.cbFaculty.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// cbCourseID
			// 
			this.cbCourseID.BackColor = System.Drawing.Color.Transparent;
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
			this.cbCourseID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.cbCourseID.Location = new System.Drawing.Point(35, 111);
			this.cbCourseID.Name = "cbCourseID";
			this.cbCourseID.Size = new System.Drawing.Size(380, 36);
			this.cbCourseID.TabIndex = 0;
			this.cbCourseID.TabStop = false;
			this.cbCourseID.Text = null;
			this.cbCourseID.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// lbTenKhoa
			// 
			this.lbTenKhoa.AutoSize = true;
			this.lbTenKhoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenKhoa.Location = new System.Drawing.Point(42, 13);
			this.lbTenKhoa.Name = "lbTenKhoa";
			this.lbTenKhoa.Size = new System.Drawing.Size(56, 18);
			this.lbTenKhoa.TabIndex = 0;
			this.lbTenKhoa.Text = "Khoa:";
			this.lbTenKhoa.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// lbKhoa
			// 
			this.lbKhoa.AutoSize = true;
			this.lbKhoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKhoa.Location = new System.Drawing.Point(42, 87);
			this.lbKhoa.Name = "lbKhoa";
			this.lbKhoa.Size = new System.Drawing.Size(56, 18);
			this.lbKhoa.TabIndex = 0;
			this.lbKhoa.Text = "Khóa:";
			this.lbKhoa.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// pnlInfo1
			// 
			this.pnlInfo1.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfo1.Controls.Add(this.tbDescription);
			this.pnlInfo1.Controls.Add(this.tbClassID);
			this.pnlInfo1.Controls.Add(this.lbMaLop);
			this.pnlInfo1.Controls.Add(this.lbMoTa);
			this.pnlInfo1.FillColor = System.Drawing.Color.White;
			this.pnlInfo1.Location = new System.Drawing.Point(45, 20);
			this.pnlInfo1.Name = "pnlInfo1";
			this.pnlInfo1.Radius = 5;
			this.pnlInfo1.ShadowColor = System.Drawing.Color.Black;
			this.pnlInfo1.ShadowDepth = 255;
			this.pnlInfo1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlInfo1.Size = new System.Drawing.Size(450, 170);
			this.pnlInfo1.TabIndex = 0;
			this.pnlInfo1.Click += new System.EventHandler(this.ManageClass_Click);
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
			this.tbDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescription.ForeColor = System.Drawing.Color.Black;
			this.tbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDescription.HoverState.Parent = this.tbDescription;
			this.tbDescription.Location = new System.Drawing.Point(35, 112);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.PasswordChar = '\0';
			this.tbDescription.PlaceholderText = "";
			this.tbDescription.SelectedText = "";
			this.tbDescription.ShadowDecoration.Parent = this.tbDescription;
			this.tbDescription.Size = new System.Drawing.Size(380, 35);
			this.tbDescription.TabIndex = 2;
			this.tbDescription.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// tbClassID
			// 
			this.tbClassID.BorderColor = System.Drawing.Color.Gray;
			this.tbClassID.BorderRadius = 5;
			this.tbClassID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbClassID.DefaultText = "";
			this.tbClassID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbClassID.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbClassID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbClassID.DisabledState.Parent = this.tbClassID;
			this.tbClassID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbClassID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbClassID.FocusedState.Parent = this.tbClassID;
			this.tbClassID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbClassID.ForeColor = System.Drawing.Color.Black;
			this.tbClassID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbClassID.HoverState.Parent = this.tbClassID;
			this.tbClassID.Location = new System.Drawing.Point(35, 38);
			this.tbClassID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbClassID.Name = "tbClassID";
			this.tbClassID.PasswordChar = '\0';
			this.tbClassID.PlaceholderText = "";
			this.tbClassID.SelectedText = "";
			this.tbClassID.ShadowDecoration.Parent = this.tbClassID;
			this.tbClassID.Size = new System.Drawing.Size(380, 35);
			this.tbClassID.TabIndex = 1;
			this.tbClassID.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// lbMaLop
			// 
			this.lbMaLop.AutoSize = true;
			this.lbMaLop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaLop.Location = new System.Drawing.Point(42, 14);
			this.lbMaLop.Name = "lbMaLop";
			this.lbMaLop.Size = new System.Drawing.Size(69, 18);
			this.lbMaLop.TabIndex = 0;
			this.lbMaLop.Text = "Mã lớp:";
			this.lbMaLop.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// lbMoTa
			// 
			this.lbMoTa.AutoSize = true;
			this.lbMoTa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMoTa.Location = new System.Drawing.Point(42, 88);
			this.lbMoTa.Name = "lbMoTa";
			this.lbMoTa.Size = new System.Drawing.Size(61, 18);
			this.lbMoTa.TabIndex = 2;
			this.lbMoTa.Text = "Mô tả:";
			this.lbMoTa.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(70, 23);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 0;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			this.iconTitle.Click += new System.EventHandler(this.ManageClass_Click);
			this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.White;
			this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAdd.IconSize = 28;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdd.Location = new System.Drawing.Point(1365, 23);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnAdd.Size = new System.Drawing.Size(110, 40);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.TabStop = false;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnAdd, "Thêm lớp học");
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnAdd.Enter += new System.EventHandler(this.iconTitle_Enter);
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
			// pnlDataGridView
			// 
			this.pnlDataGridView.BackColor = System.Drawing.Color.Transparent;
			this.pnlDataGridView.Controls.Add(this.bScrollBar);
			this.pnlDataGridView.Controls.Add(this.btnClearFilter);
			this.pnlDataGridView.Controls.Add(this.tbSearch);
			this.pnlDataGridView.Controls.Add(this.btnCancle);
			this.pnlDataGridView.Controls.Add(this.aDgvdata);
			this.pnlDataGridView.Controls.Add(this.btnSave);
			this.pnlDataGridView.Controls.Add(this.btnDelete);
			this.pnlDataGridView.Controls.Add(this.btnEdit);
			this.pnlDataGridView.FillColor = System.Drawing.Color.White;
			this.pnlDataGridView.Location = new System.Drawing.Point(13, 309);
			this.pnlDataGridView.Name = "pnlDataGridView";
			this.pnlDataGridView.Radius = 5;
			this.pnlDataGridView.ShadowColor = System.Drawing.Color.Black;
			this.pnlDataGridView.ShadowDepth = 255;
			this.pnlDataGridView.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlDataGridView.Size = new System.Drawing.Size(1525, 500);
			this.pnlDataGridView.TabIndex = 0;
			this.pnlDataGridView.Click += new System.EventHandler(this.ManageClass_Click);
			// 
			// ManageClass
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlControls);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlDataGridView);
			this.Name = "ManageClass";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.ManageClass_Load);
			this.Click += new System.EventHandler(this.ManageClass_Click);
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			this.pnlControls.ResumeLayout(false);
			this.pnlInfo3.ResumeLayout(false);
			this.pnlInfo3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAdmissionYear)).EndInit();
			this.pnlInfo2.ResumeLayout(false);
			this.pnlInfo2.PerformLayout();
			this.pnlInfo1.ResumeLayout(false);
			this.pnlInfo1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.pnlDataGridView.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton iconTitle;
		public FontAwesome.Sharp.IconButton btnCancle;
		public FontAwesome.Sharp.IconButton btnSave;
		private FontAwesome.Sharp.IconButton btnDelete;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private System.Windows.Forms.Panel pnlControls;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudAdmissionYear;
		private System.Windows.Forms.Label lbSoHKDaoTao;
		private System.Windows.Forms.Label lbNamNhapHoc;
		private System.Windows.Forms.Label lbKhoa;
		private System.Windows.Forms.Label lbTenKhoa;
		private Guna.UI2.WinForms.Guna2TextBox tbDescription;
		private Guna.UI2.WinForms.Guna2TextBox tbClassID;
		private System.Windows.Forms.Label lbMoTa;
		private System.Windows.Forms.Label lbMaLop;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private Bunifu.UI.WinForms.BunifuDropdown cbNumberOfTrainingSemester;
		private Bunifu.UI.WinForms.BunifuDropdown cbFaculty;
		private Bunifu.UI.WinForms.BunifuDropdown cbCourseID;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
		public ADGV.AdvancedDataGridView aDgvdata;
		private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo3;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn NofTrainingSemester;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
	}
}