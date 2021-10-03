
namespace Main.Pages
{
	partial class EduProg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EduProg));
            this.lbTitle = new System.Windows.Forms.Label();
            this.iconTitle = new FontAwesome.Sharp.IconButton();
            this.aDgvdata = new System.Windows.Forms.DataGridView();
            this.SemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlDataGridView = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
            this.pnlDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.lbTitle.Location = new System.Drawing.Point(85, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(242, 35);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Tiến độ đào tạo";
            this.lbTitle.Click += new System.EventHandler(this.EduProg_Click);
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatAppearance.BorderSize = 0;
            this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 35;
            this.iconTitle.Location = new System.Drawing.Point(45, 22);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(35, 37);
            this.iconTitle.TabIndex = 30;
            this.iconTitle.TabStop = false;
            this.iconTitle.UseVisualStyleBackColor = false;
            this.iconTitle.Click += new System.EventHandler(this.EduProg_Click);
            this.iconTitle.Enter += new System.EventHandler(this.btnClearFilter_Enter);
            // 
            // aDgvdata
            // 
            this.aDgvdata.AllowUserToAddRows = false;
            this.aDgvdata.AllowUserToDeleteRows = false;
            this.aDgvdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.aDgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.SemesterID,
            this.SubjectID,
            this.SubjectName,
            this.RoleName,
            this.CourseID,
            this.FacultyID,
            this.FacultyName,
            this.TotalMark,
            this.Success});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle10;
            this.aDgvdata.EnableHeadersVisualStyles = false;
            this.aDgvdata.Location = new System.Drawing.Point(45, 53);
            this.aDgvdata.Name = "aDgvdata";
            this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aDgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.aDgvdata.RowHeadersVisible = false;
            this.aDgvdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.aDgvdata.RowTemplate.Height = 50;
            this.aDgvdata.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aDgvdata.Size = new System.Drawing.Size(1429, 660);
            this.aDgvdata.TabIndex = 18;
            this.aDgvdata.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aDgvdata_RowsAdded);
            this.aDgvdata.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.aDgvdata_RowsRemoved);
            this.aDgvdata.Click += new System.EventHandler(this.EduProg_Click);
            this.aDgvdata.Enter += new System.EventHandler(this.aDgvdata_Enter);
            // 
            // SemesterID
            // 
            this.SemesterID.DataPropertyName = "SemesterID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SemesterID.DefaultCellStyle = dataGridViewCellStyle3;
            this.SemesterID.FillWeight = 30F;
            this.SemesterID.HeaderText = "  Học kì";
            this.SemesterID.Name = "SemesterID";
            this.SemesterID.ReadOnly = true;
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubjectID.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubjectID.FillWeight = 50F;
            this.SubjectID.HeaderText = "Mã môn";
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.FillWeight = 110F;
            this.SubjectName.HeaderText = "Tên môn";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RoleName.DefaultCellStyle = dataGridViewCellStyle5;
            this.RoleName.FillWeight = 50F;
            this.RoleName.HeaderText = "Loại môn";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CourseID.DefaultCellStyle = dataGridViewCellStyle6;
            this.CourseID.FillWeight = 50F;
            this.CourseID.HeaderText = "Khóa";
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            // 
            // FacultyID
            // 
            this.FacultyID.DataPropertyName = "FacultyID";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FacultyID.DefaultCellStyle = dataGridViewCellStyle7;
            this.FacultyID.FillWeight = 50F;
            this.FacultyID.HeaderText = "Mã khoa";
            this.FacultyID.Name = "FacultyID";
            this.FacultyID.ReadOnly = true;
            // 
            // FacultyName
            // 
            this.FacultyName.DataPropertyName = "FacultyName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FacultyName.DefaultCellStyle = dataGridViewCellStyle8;
            this.FacultyName.FillWeight = 110F;
            this.FacultyName.HeaderText = "Tên khoa";
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            // 
            // TotalMark
            // 
            this.TotalMark.DataPropertyName = "TotalMark";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalMark.DefaultCellStyle = dataGridViewCellStyle9;
            this.TotalMark.FillWeight = 40F;
            this.TotalMark.HeaderText = "Tổng điểm";
            this.TotalMark.Name = "TotalMark";
            this.TotalMark.ReadOnly = true;
            // 
            // Success
            // 
            this.Success.DataPropertyName = "Success";
            this.Success.FillWeight = 50F;
            this.Success.HeaderText = "Trạng thái";
            this.Success.Name = "Success";
            this.Success.ReadOnly = true;
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
            this.tbSearch.Location = new System.Drawing.Point(65, 10);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Nhập từ khóa ...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(281, 35);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.TabStop = false;
            this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
            this.tbSearch.Click += new System.EventHandler(this.EduProg_Click);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
            this.tbSearch.MouseLeave += new System.EventHandler(this.tbSearch_MouseLeave);
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
            this.bScrollBar.Location = new System.Drawing.Point(1480, 93);
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
            this.bScrollBar.Size = new System.Drawing.Size(31, 620);
            this.bScrollBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bScrollBar.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
            this.bScrollBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
            this.bScrollBar.SmallChange = 1;
            this.bScrollBar.TabIndex = 12;
            this.bScrollBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bScrollBar.ThumbFillColor = System.Drawing.Color.White;
            this.bScrollBar.ThumbLength = 61;
            this.bScrollBar.ThumbMargin = 1;
            this.bScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
            this.bScrollBar.Value = 100;
            this.bScrollBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs>(this.bScrollBar_Scroll);
            this.bScrollBar.Click += new System.EventHandler(this.EduProg_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            this.btnClearFilter.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnClearFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearFilter.IconSize = 25;
            this.btnClearFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearFilter.Location = new System.Drawing.Point(350, 10);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(35, 35);
            this.btnClearFilter.TabIndex = 0;
            this.btnClearFilter.TabStop = false;
            this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnClearFilter, "Hủy thao tác lọc dữ liệu");
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            this.btnClearFilter.Enter += new System.EventHandler(this.btnClearFilter_Enter);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 1000;
            this.toolTip.InitialDelay = 0;
            this.toolTip.ReshowDelay = 0;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Suggest";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "cancel.png");
            this.imageList.Images.SetKeyName(1, "checked.png");
            this.imageList.Images.SetKeyName(2, "warning.png");
            this.imageList.Images.SetKeyName(3, "information.png");
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.Transparent;
            this.pnlDataGridView.Controls.Add(this.aDgvdata);
            this.pnlDataGridView.Controls.Add(this.btnClearFilter);
            this.pnlDataGridView.Controls.Add(this.tbSearch);
            this.pnlDataGridView.Controls.Add(this.bScrollBar);
            this.pnlDataGridView.FillColor = System.Drawing.Color.White;
            this.pnlDataGridView.Location = new System.Drawing.Point(13, 80);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Radius = 5;
            this.pnlDataGridView.ShadowColor = System.Drawing.Color.Black;
            this.pnlDataGridView.ShadowDepth = 255;
            this.pnlDataGridView.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlDataGridView.Size = new System.Drawing.Size(1525, 730);
            this.pnlDataGridView.TabIndex = 40;
            this.pnlDataGridView.Click += new System.EventHandler(this.EduProg_Click);
            // 
            // EduProg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.iconTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnlDataGridView);
            this.Name = "EduProg";
            this.Size = new System.Drawing.Size(1550, 822);
            this.Load += new System.EventHandler(this.FrmEduProg_Load);
            this.Click += new System.EventHandler(this.EduProg_Click);
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
            this.pnlDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton iconTitle;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private System.Windows.Forms.ToolTip toolTip;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
        private System.Windows.Forms.ImageList imageList;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		public System.Windows.Forms.DataGridView aDgvdata;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn SemesterID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalMark;
		private System.Windows.Forms.DataGridViewImageColumn Success;
	}
}