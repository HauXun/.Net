﻿
namespace Main.Pages
{
	partial class ManageCourse
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourse));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.lbTitle = new System.Windows.Forms.Label();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.pnlDataGridView = new System.Windows.Forms.Panel();
			this.iconSearch = new FontAwesome.Sharp.IconButton();
			this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrainingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClearFilter = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnCancle = new FontAwesome.Sharp.IconButton();
			this.btnSearch = new FontAwesome.Sharp.IconButton();
			this.pnlDataGridViewShadow = new System.Windows.Forms.Panel();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.pnlInfo2 = new System.Windows.Forms.Panel();
			this.cbTrainingRole = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbFaculty = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbHinhThucDaoTao = new System.Windows.Forms.Label();
			this.lbKhoa = new System.Windows.Forms.Label();
			this.pnl2Shadow = new System.Windows.Forms.Panel();
			this.pnlInfo1 = new System.Windows.Forms.Panel();
			this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbCourseID = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbMoTa = new System.Windows.Forms.Label();
			this.lbMaKhoa = new System.Windows.Forms.Label();
			this.pnl1Shadow = new System.Windows.Forms.Panel();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlDataGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.pnlControls.SuspendLayout();
			this.pnlInfo2.SuspendLayout();
			this.pnlInfo1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
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
			this.toolTip.SetToolTip(this.btnAdd, "Thêm khóa sinh viên");
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnAdd.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(85, 20);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(267, 37);
			this.lbTitle.TabIndex = 13;
			this.lbTitle.Text = "Quản lý khóa học";
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(45, 22);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 0;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
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
			this.pnlDataGridView.TabIndex = 18;
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
			this.iconSearch.TabIndex = 12;
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
            this.CourseID,
            this.FacultyID,
            this.TrainingID,
            this.Description});
			this.aDgvdata.DateWithTime = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle7;
			this.aDgvdata.EnableHeadersVisualStyles = false;
			this.aDgvdata.Location = new System.Drawing.Point(34, 79);
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.aDgvdata.RowHeadersVisible = false;
			this.aDgvdata.RowTemplate.Height = 50;
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle3;
			this.STT.FillWeight = 40F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// CourseID
			// 
			this.CourseID.DataPropertyName = "CourseID";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.CourseID.DefaultCellStyle = dataGridViewCellStyle4;
			this.CourseID.FillWeight = 60F;
			this.CourseID.HeaderText = "Mã khóa";
			this.CourseID.MinimumWidth = 22;
			this.CourseID.Name = "CourseID";
			this.CourseID.ReadOnly = true;
			this.CourseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// FacultyID
			// 
			this.FacultyID.DataPropertyName = "FacultyID";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FacultyID.DefaultCellStyle = dataGridViewCellStyle5;
			this.FacultyID.FillWeight = 60F;
			this.FacultyID.HeaderText = "Mã khoa";
			this.FacultyID.MinimumWidth = 22;
			this.FacultyID.Name = "FacultyID";
			this.FacultyID.ReadOnly = true;
			this.FacultyID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// TrainingID
			// 
			this.TrainingID.DataPropertyName = "TrainingID";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TrainingID.DefaultCellStyle = dataGridViewCellStyle6;
			this.TrainingID.FillWeight = 60F;
			this.TrainingID.HeaderText = "Hình thức đào tạo";
			this.TrainingID.MinimumWidth = 22;
			this.TrainingID.Name = "TrainingID";
			this.TrainingID.ReadOnly = true;
			this.TrainingID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			this.toolTip.SetToolTip(this.btnEdit, "Sửa thông tin khóa sinh viên");
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
			this.toolTip.SetToolTip(this.btnDelete, "Xóa khóa sinh viên");
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
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
			this.pnlDataGridViewShadow.TabIndex = 19;
			// 
			// pnlControls
			// 
			this.pnlControls.BackColor = System.Drawing.Color.Transparent;
			this.pnlControls.Controls.Add(this.pnlInfo2);
			this.pnlControls.Controls.Add(this.pnl2Shadow);
			this.pnlControls.Controls.Add(this.pnlInfo1);
			this.pnlControls.Controls.Add(this.pnl1Shadow);
			this.pnlControls.Location = new System.Drawing.Point(25, 69);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(1498, 216);
			this.pnlControls.TabIndex = 33;
			// 
			// pnlInfo2
			// 
			this.pnlInfo2.BackColor = System.Drawing.Color.White;
			this.pnlInfo2.Controls.Add(this.cbTrainingRole);
			this.pnlInfo2.Controls.Add(this.cbFaculty);
			this.pnlInfo2.Controls.Add(this.lbHinhThucDaoTao);
			this.pnlInfo2.Controls.Add(this.lbKhoa);
			this.pnlInfo2.Location = new System.Drawing.Point(783, 23);
			this.pnlInfo2.Name = "pnlInfo2";
			this.pnlInfo2.Size = new System.Drawing.Size(498, 168);
			this.pnlInfo2.TabIndex = 19;
			// 
			// cbTrainingRole
			// 
			this.cbTrainingRole.BackColor = System.Drawing.Color.White;
			this.cbTrainingRole.BorderRadius = 4;
			this.cbTrainingRole.Color = System.Drawing.Color.Gray;
			this.cbTrainingRole.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbTrainingRole.DisabledColor = System.Drawing.Color.Gray;
			this.cbTrainingRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbTrainingRole.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbTrainingRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTrainingRole.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbTrainingRole.FillDropDown = false;
			this.cbTrainingRole.FillIndicator = false;
			this.cbTrainingRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbTrainingRole.Font = new System.Drawing.Font("Arial", 14.25F);
			this.cbTrainingRole.ForeColor = System.Drawing.Color.Black;
			this.cbTrainingRole.FormattingEnabled = true;
			this.cbTrainingRole.Icon = null;
			this.cbTrainingRole.IndicatorColor = System.Drawing.Color.Black;
			this.cbTrainingRole.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbTrainingRole.ItemBackColor = System.Drawing.Color.White;
			this.cbTrainingRole.ItemBorderColor = System.Drawing.Color.White;
			this.cbTrainingRole.ItemForeColor = System.Drawing.Color.Black;
			this.cbTrainingRole.ItemHeight = 30;
			this.cbTrainingRole.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbTrainingRole.Location = new System.Drawing.Point(24, 115);
			this.cbTrainingRole.Name = "cbTrainingRole";
			this.cbTrainingRole.Size = new System.Drawing.Size(450, 36);
			this.cbTrainingRole.TabIndex = 42;
			this.cbTrainingRole.Text = null;
			// 
			// cbFaculty
			// 
			this.cbFaculty.BackColor = System.Drawing.Color.White;
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
			this.cbFaculty.Font = new System.Drawing.Font("Arial", 14.25F);
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
			this.cbFaculty.Location = new System.Drawing.Point(24, 42);
			this.cbFaculty.Name = "cbFaculty";
			this.cbFaculty.Size = new System.Drawing.Size(450, 36);
			this.cbFaculty.TabIndex = 41;
			this.cbFaculty.Text = null;
			// 
			// lbHinhThucDaoTao
			// 
			this.lbHinhThucDaoTao.AutoSize = true;
			this.lbHinhThucDaoTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHinhThucDaoTao.Location = new System.Drawing.Point(31, 92);
			this.lbHinhThucDaoTao.Name = "lbHinhThucDaoTao";
			this.lbHinhThucDaoTao.Size = new System.Drawing.Size(139, 20);
			this.lbHinhThucDaoTao.TabIndex = 2;
			this.lbHinhThucDaoTao.Text = "Hình thức đào tạo:";
			// 
			// lbKhoa
			// 
			this.lbKhoa.AutoSize = true;
			this.lbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKhoa.Location = new System.Drawing.Point(31, 18);
			this.lbKhoa.Name = "lbKhoa";
			this.lbKhoa.Size = new System.Drawing.Size(50, 20);
			this.lbKhoa.TabIndex = 0;
			this.lbKhoa.Text = "Khoa:";
			// 
			// pnl2Shadow
			// 
			this.pnl2Shadow.BackColor = System.Drawing.Color.Silver;
			this.pnl2Shadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnl2Shadow.Location = new System.Drawing.Point(786, 26);
			this.pnl2Shadow.Name = "pnl2Shadow";
			this.pnl2Shadow.Size = new System.Drawing.Size(498, 168);
			this.pnl2Shadow.TabIndex = 21;
			// 
			// pnlInfo1
			// 
			this.pnlInfo1.BackColor = System.Drawing.Color.White;
			this.pnlInfo1.Controls.Add(this.tbDescription);
			this.pnlInfo1.Controls.Add(this.tbCourseID);
			this.pnlInfo1.Controls.Add(this.lbMoTa);
			this.pnlInfo1.Controls.Add(this.lbMaKhoa);
			this.pnlInfo1.Location = new System.Drawing.Point(215, 23);
			this.pnlInfo1.Name = "pnlInfo1";
			this.pnlInfo1.Size = new System.Drawing.Size(498, 168);
			this.pnlInfo1.TabIndex = 18;
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
			this.tbDescription.Location = new System.Drawing.Point(24, 116);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.PasswordChar = '\0';
			this.tbDescription.PlaceholderText = "";
			this.tbDescription.SelectedText = "";
			this.tbDescription.ShadowDecoration.Parent = this.tbDescription;
			this.tbDescription.Size = new System.Drawing.Size(450, 35);
			this.tbDescription.TabIndex = 5;
			// 
			// tbCourseID
			// 
			this.tbCourseID.BorderColor = System.Drawing.Color.Gray;
			this.tbCourseID.BorderRadius = 5;
			this.tbCourseID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbCourseID.DefaultText = "";
			this.tbCourseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbCourseID.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbCourseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbCourseID.DisabledState.Parent = this.tbCourseID;
			this.tbCourseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbCourseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbCourseID.FocusedState.Parent = this.tbCourseID;
			this.tbCourseID.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbCourseID.ForeColor = System.Drawing.Color.Black;
			this.tbCourseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbCourseID.HoverState.Parent = this.tbCourseID;
			this.tbCourseID.Location = new System.Drawing.Point(24, 42);
			this.tbCourseID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbCourseID.Name = "tbCourseID";
			this.tbCourseID.PasswordChar = '\0';
			this.tbCourseID.PlaceholderText = "";
			this.tbCourseID.SelectedText = "";
			this.tbCourseID.ShadowDecoration.Parent = this.tbCourseID;
			this.tbCourseID.Size = new System.Drawing.Size(450, 35);
			this.tbCourseID.TabIndex = 4;
			// 
			// lbMoTa
			// 
			this.lbMoTa.AutoSize = true;
			this.lbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMoTa.Location = new System.Drawing.Point(31, 92);
			this.lbMoTa.Name = "lbMoTa";
			this.lbMoTa.Size = new System.Drawing.Size(53, 20);
			this.lbMoTa.TabIndex = 2;
			this.lbMoTa.Text = "Mô tả:";
			// 
			// lbMaKhoa
			// 
			this.lbMaKhoa.AutoSize = true;
			this.lbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaKhoa.Location = new System.Drawing.Point(31, 18);
			this.lbMaKhoa.Name = "lbMaKhoa";
			this.lbMaKhoa.Size = new System.Drawing.Size(74, 20);
			this.lbMaKhoa.TabIndex = 0;
			this.lbMaKhoa.Text = "Mã khóa:";
			// 
			// pnl1Shadow
			// 
			this.pnl1Shadow.BackColor = System.Drawing.Color.Silver;
			this.pnl1Shadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnl1Shadow.Location = new System.Drawing.Point(218, 26);
			this.pnl1Shadow.Name = "pnl1Shadow";
			this.pnl1Shadow.Size = new System.Drawing.Size(498, 168);
			this.pnl1Shadow.TabIndex = 20;
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
			// ManageCourse
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlControls);
			this.Controls.Add(this.pnlDataGridView);
			this.Controls.Add(this.pnlDataGridViewShadow);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.btnAdd);
			this.Name = "ManageCourse";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmManageCourse_Load);
			this.pnlDataGridView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			this.pnlControls.ResumeLayout(false);
			this.pnlInfo2.ResumeLayout(false);
			this.pnlInfo2.PerformLayout();
			this.pnlInfo1.ResumeLayout(false);
			this.pnlInfo1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Panel pnlDataGridView;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnDelete;
		public FontAwesome.Sharp.IconButton btnSave;
		public FontAwesome.Sharp.IconButton btnCancle;
		private FontAwesome.Sharp.IconButton btnSearch;
		private System.Windows.Forms.Panel pnlDataGridViewShadow;
		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Panel pnlInfo2;
		private System.Windows.Forms.Label lbHinhThucDaoTao;
		private System.Windows.Forms.Label lbKhoa;
		private System.Windows.Forms.Panel pnl2Shadow;
		private System.Windows.Forms.Panel pnlInfo1;
		private Guna.UI2.WinForms.Guna2TextBox tbDescription;
		private Guna.UI2.WinForms.Guna2TextBox tbCourseID;
		private System.Windows.Forms.Label lbMoTa;
		private System.Windows.Forms.Label lbMaKhoa;
		private System.Windows.Forms.Panel pnl1Shadow;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrainingID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private Bunifu.UI.WinForms.BunifuDropdown cbTrainingRole;
		private Bunifu.UI.WinForms.BunifuDropdown cbFaculty;
		private System.Windows.Forms.ToolTip toolTip;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
        private FontAwesome.Sharp.IconButton iconSearch;
		public ADGV.AdvancedDataGridView aDgvdata;
	}
}