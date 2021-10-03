
namespace Main.Pages
{
	partial class ManageExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageExam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.iconTitle = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.aDgvdata = new ADGV.AdvancedDataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestFormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnCancle = new FontAwesome.Sharp.IconButton();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlInfo2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gbMark = new System.Windows.Forms.Panel();
            this.cbTestFormID = new Bunifu.UI.WinForms.BunifuDropdown();
            this.nudPercentMark = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbPercentMark = new System.Windows.Forms.Label();
            this.lbTestFormID = new System.Windows.Forms.Label();
            this.lbCheckStatus = new System.Windows.Forms.LinkLabel();
            this.nudExamTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ckbStatus = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lbSoLuongCauHoi = new System.Windows.Forms.Label();
            this.lbThoiGianLamBai = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.nudQCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuizTimes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnlInfo1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cbExamRole = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lbLoaiDe = new System.Windows.Forms.Label();
            this.lbMonThi = new System.Windows.Forms.Label();
            this.tbExamID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSubject = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lbMaDe = new System.Windows.Forms.Label();
            this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDataGridView = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlInfo2.SuspendLayout();
            this.gbMark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuizTimes)).BeginInit();
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
            this.lbTitle.Size = new System.Drawing.Size(220, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Quản lý đề thi";
            this.lbTitle.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatAppearance.BorderSize = 0;
            this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 35;
            this.iconTitle.Location = new System.Drawing.Point(70, 23);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(35, 37);
            this.iconTitle.TabIndex = 0;
            this.iconTitle.TabStop = false;
            this.iconTitle.UseVisualStyleBackColor = false;
            this.iconTitle.Click += new System.EventHandler(this.ManageExam_Click);
            this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.toolTip.SetToolTip(this.btnAdd, "Thêm đề thi");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Enter += new System.EventHandler(this.iconTitle_Enter);
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
            this.bScrollBar.Click += new System.EventHandler(this.ManageExam_Click);
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
            this.tbSearch.Click += new System.EventHandler(this.ManageExam_Click);
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
            this.ExamID,
            this.SubjectID,
            this.TestFormID,
            this.PercentMark,
            this.ExamRole,
            this.ExamTime,
            this.QuizTimes,
            this.QCount,
            this.QCurrentCount,
            this.Status});
            this.aDgvdata.DateWithTime = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle14;
            this.aDgvdata.EnableHeadersVisualStyles = false;
            this.aDgvdata.Location = new System.Drawing.Point(45, 56);
            this.aDgvdata.Name = "aDgvdata";
            this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.aDgvdata.RowHeadersVisible = false;
            this.aDgvdata.RowTemplate.Height = 50;
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
            this.aDgvdata.Click += new System.EventHandler(this.ManageExam_Click);
            this.aDgvdata.Enter += new System.EventHandler(this.aDgvdata_Enter);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.FillWeight = 60F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 22;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ExamID
            // 
            this.ExamID.DataPropertyName = "ExamID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExamID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExamID.FillWeight = 70F;
            this.ExamID.HeaderText = "Mã đề";
            this.ExamID.MinimumWidth = 22;
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            this.ExamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "NULL";
            this.SubjectID.DefaultCellStyle = dataGridViewCellStyle5;
            this.SubjectID.FillWeight = 70F;
            this.SubjectID.HeaderText = "Môn thi";
            this.SubjectID.MinimumWidth = 22;
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TestFormID
            // 
            this.TestFormID.DataPropertyName = "TestFormID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "NULL";
            this.TestFormID.DefaultCellStyle = dataGridViewCellStyle6;
            this.TestFormID.FillWeight = 70F;
            this.TestFormID.HeaderText = "Hình thức đề thi";
            this.TestFormID.MinimumWidth = 22;
            this.TestFormID.Name = "TestFormID";
            this.TestFormID.ReadOnly = true;
            this.TestFormID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PercentMark
            // 
            this.PercentMark.DataPropertyName = "PercentMark";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "NULL";
            this.PercentMark.DefaultCellStyle = dataGridViewCellStyle7;
            this.PercentMark.FillWeight = 70F;
            this.PercentMark.HeaderText = "Phần trăm điểm";
            this.PercentMark.MinimumWidth = 22;
            this.PercentMark.Name = "PercentMark";
            this.PercentMark.ReadOnly = true;
            this.PercentMark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ExamRole
            // 
            this.ExamRole.DataPropertyName = "ExamRole";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExamRole.DefaultCellStyle = dataGridViewCellStyle8;
            this.ExamRole.FillWeight = 50F;
            this.ExamRole.HeaderText = "Loại đề";
            this.ExamRole.MinimumWidth = 22;
            this.ExamRole.Name = "ExamRole";
            this.ExamRole.ReadOnly = true;
            this.ExamRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ExamTime
            // 
            this.ExamTime.DataPropertyName = "ExamTime";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExamTime.DefaultCellStyle = dataGridViewCellStyle9;
            this.ExamTime.FillWeight = 80F;
            this.ExamTime.HeaderText = "Thời gian làm bài";
            this.ExamTime.MinimumWidth = 22;
            this.ExamTime.Name = "ExamTime";
            this.ExamTime.ReadOnly = true;
            this.ExamTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // QuizTimes
            // 
            this.QuizTimes.DataPropertyName = "QuizTimes";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QuizTimes.DefaultCellStyle = dataGridViewCellStyle10;
            this.QuizTimes.FillWeight = 50F;
            this.QuizTimes.HeaderText = "Số lần thi";
            this.QuizTimes.MinimumWidth = 22;
            this.QuizTimes.Name = "QuizTimes";
            this.QuizTimes.ReadOnly = true;
            this.QuizTimes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // QCount
            // 
            this.QCount.DataPropertyName = "QCount";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QCount.DefaultCellStyle = dataGridViewCellStyle11;
            this.QCount.FillWeight = 80F;
            this.QCount.HeaderText = "Số lượng câu hỏi";
            this.QCount.MinimumWidth = 22;
            this.QCount.Name = "QCount";
            this.QCount.ReadOnly = true;
            this.QCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // QCurrentCount
            // 
            this.QCurrentCount.DataPropertyName = "QCurrentCount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QCurrentCount.DefaultCellStyle = dataGridViewCellStyle12;
            this.QCurrentCount.HeaderText = "Số lượng câu hỏi hiện tại";
            this.QCurrentCount.MinimumWidth = 22;
            this.QCurrentCount.Name = "QCurrentCount";
            this.QCurrentCount.ReadOnly = true;
            this.QCurrentCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle13;
            this.Status.FillWeight = 60F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 22;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.btnClearFilter.Location = new System.Drawing.Point(343, 12);
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
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEdit.TabIndex = 0;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnEdit, "Sửa đề thi");
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
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.toolTip.SetToolTip(this.btnDelete, "Xóa đề thi");
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
            this.btnCancle.Location = new System.Drawing.Point(1224, 10);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancle.Size = new System.Drawing.Size(110, 40);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.TabStop = false;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnCancle, "Hủy thao tác");
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Visible = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            this.btnCancle.Enter += new System.EventHandler(this.iconTitle_Enter);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.pnlInfo2);
            this.pnlControls.Controls.Add(this.pnlInfo1);
            this.pnlControls.Location = new System.Drawing.Point(25, 70);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1500, 210);
            this.pnlControls.TabIndex = 0;
            this.pnlControls.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // pnlInfo2
            // 
            this.pnlInfo2.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo2.Controls.Add(this.gbMark);
            this.pnlInfo2.Controls.Add(this.lbCheckStatus);
            this.pnlInfo2.Controls.Add(this.nudExamTime);
            this.pnlInfo2.Controls.Add(this.ckbStatus);
            this.pnlInfo2.Controls.Add(this.lbSoLuongCauHoi);
            this.pnlInfo2.Controls.Add(this.lbThoiGianLamBai);
            this.pnlInfo2.Controls.Add(this.lbStatus);
            this.pnlInfo2.Controls.Add(this.nudQCount);
            this.pnlInfo2.Controls.Add(this.label1);
            this.pnlInfo2.Controls.Add(this.nudQuizTimes);
            this.pnlInfo2.FillColor = System.Drawing.Color.White;
            this.pnlInfo2.Location = new System.Drawing.Point(792, 20);
            this.pnlInfo2.Name = "pnlInfo2";
            this.pnlInfo2.Radius = 5;
            this.pnlInfo2.ShadowColor = System.Drawing.Color.Black;
            this.pnlInfo2.ShadowDepth = 255;
            this.pnlInfo2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlInfo2.Size = new System.Drawing.Size(530, 170);
            this.pnlInfo2.TabIndex = 0;
            this.pnlInfo2.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // gbMark
            // 
            this.gbMark.Controls.Add(this.cbTestFormID);
            this.gbMark.Controls.Add(this.nudPercentMark);
            this.gbMark.Controls.Add(this.lbPercentMark);
            this.gbMark.Controls.Add(this.lbTestFormID);
            this.gbMark.Location = new System.Drawing.Point(28, 80);
            this.gbMark.Name = "gbMark";
            this.gbMark.Size = new System.Drawing.Size(305, 77);
            this.gbMark.TabIndex = 0;
            this.gbMark.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // cbTestFormID
            // 
            this.cbTestFormID.BackColor = System.Drawing.Color.Transparent;
            this.cbTestFormID.BorderRadius = 4;
            this.cbTestFormID.Color = System.Drawing.Color.Gray;
            this.cbTestFormID.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbTestFormID.DisabledColor = System.Drawing.Color.Gray;
            this.cbTestFormID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTestFormID.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbTestFormID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTestFormID.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbTestFormID.FillDropDown = false;
            this.cbTestFormID.FillIndicator = false;
            this.cbTestFormID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTestFormID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTestFormID.ForeColor = System.Drawing.Color.Black;
            this.cbTestFormID.FormattingEnabled = true;
            this.cbTestFormID.Icon = null;
            this.cbTestFormID.IndicatorColor = System.Drawing.Color.Black;
            this.cbTestFormID.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbTestFormID.ItemBackColor = System.Drawing.Color.White;
            this.cbTestFormID.ItemBorderColor = System.Drawing.Color.White;
            this.cbTestFormID.ItemForeColor = System.Drawing.Color.Black;
            this.cbTestFormID.ItemHeight = 30;
            this.cbTestFormID.ItemHighLightColor = System.Drawing.Color.GhostWhite;
            this.cbTestFormID.Location = new System.Drawing.Point(0, 31);
            this.cbTestFormID.Name = "cbTestFormID";
            this.cbTestFormID.Size = new System.Drawing.Size(139, 36);
            this.cbTestFormID.TabIndex = 0;
            this.cbTestFormID.TabStop = false;
            this.cbTestFormID.Text = null;
            this.cbTestFormID.SelectedIndexChanged += new System.EventHandler(this.cbTestFormID_SelectedIndexChanged);
            this.cbTestFormID.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // nudPercentMark
            // 
            this.nudPercentMark.BackColor = System.Drawing.Color.White;
            this.nudPercentMark.BorderColor = System.Drawing.Color.Gray;
            this.nudPercentMark.BorderRadius = 5;
            this.nudPercentMark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPercentMark.DisabledState.Parent = this.nudPercentMark;
            this.nudPercentMark.Enabled = false;
            this.nudPercentMark.FocusedState.Parent = this.nudPercentMark;
            this.nudPercentMark.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPercentMark.ForeColor = System.Drawing.Color.Black;
            this.nudPercentMark.Location = new System.Drawing.Point(166, 31);
            this.nudPercentMark.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudPercentMark.Name = "nudPercentMark";
            this.nudPercentMark.ShadowDecoration.Parent = this.nudPercentMark;
            this.nudPercentMark.Size = new System.Drawing.Size(139, 36);
            this.nudPercentMark.TabIndex = 0;
            this.nudPercentMark.TabStop = false;
            this.nudPercentMark.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
            this.nudPercentMark.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbPercentMark
            // 
            this.lbPercentMark.AutoSize = true;
            this.lbPercentMark.Enabled = false;
            this.lbPercentMark.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentMark.Location = new System.Drawing.Point(163, 9);
            this.lbPercentMark.Name = "lbPercentMark";
            this.lbPercentMark.Size = new System.Drawing.Size(134, 18);
            this.lbPercentMark.TabIndex = 0;
            this.lbPercentMark.Text = "Tỉ lệ điểm (%):";
            this.lbPercentMark.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbTestFormID
            // 
            this.lbTestFormID.AutoSize = true;
            this.lbTestFormID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestFormID.Location = new System.Drawing.Point(-3, 9);
            this.lbTestFormID.Name = "lbTestFormID";
            this.lbTestFormID.Size = new System.Drawing.Size(148, 18);
            this.lbTestFormID.TabIndex = 0;
            this.lbTestFormID.Text = "Hình thức đề thi:";
            this.lbTestFormID.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbCheckStatus
            // 
            this.lbCheckStatus.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbCheckStatus.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbCheckStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbCheckStatus.LinkColor = System.Drawing.Color.Black;
            this.lbCheckStatus.Location = new System.Drawing.Point(410, 121);
            this.lbCheckStatus.Name = "lbCheckStatus";
            this.lbCheckStatus.Size = new System.Drawing.Size(78, 18);
            this.lbCheckStatus.TabIndex = 0;
            this.lbCheckStatus.Text = "Đóng thi";
            this.lbCheckStatus.Click += new System.EventHandler(this.lbCheckStatus_Click);
            this.lbCheckStatus.MouseEnter += new System.EventHandler(this.lbCheckStatus_MouseEnter);
            this.lbCheckStatus.MouseLeave += new System.EventHandler(this.lbCheckStatus_MouseLeave);
            // 
            // nudExamTime
            // 
            this.nudExamTime.BackColor = System.Drawing.Color.White;
            this.nudExamTime.BorderColor = System.Drawing.Color.Gray;
            this.nudExamTime.BorderRadius = 5;
            this.nudExamTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudExamTime.DisabledState.Parent = this.nudExamTime;
            this.nudExamTime.FocusedState.Parent = this.nudExamTime;
            this.nudExamTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExamTime.ForeColor = System.Drawing.Color.Black;
            this.nudExamTime.Location = new System.Drawing.Point(28, 37);
            this.nudExamTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudExamTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExamTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExamTime.Name = "nudExamTime";
            this.nudExamTime.ShadowDecoration.Parent = this.nudExamTime;
            this.nudExamTime.Size = new System.Drawing.Size(139, 36);
            this.nudExamTime.TabIndex = 0;
            this.nudExamTime.TabStop = false;
            this.nudExamTime.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
            this.nudExamTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExamTime.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // ckbStatus
            // 
            this.ckbStatus.Animated = true;
            this.ckbStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbStatus.CheckedState.BorderRadius = 2;
            this.ckbStatus.CheckedState.BorderThickness = 0;
            this.ckbStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbStatus.CheckedState.Parent = this.ckbStatus;
            this.ckbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbStatus.Location = new System.Drawing.Point(359, 118);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.ShadowDecoration.Parent = this.ckbStatus;
            this.ckbStatus.Size = new System.Drawing.Size(25, 25);
            this.ckbStatus.TabIndex = 0;
            this.ckbStatus.TabStop = false;
            this.ckbStatus.Text = "guna2CustomCheckBox1";
            this.ckbStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbStatus.UncheckedState.BorderRadius = 2;
            this.ckbStatus.UncheckedState.BorderThickness = 0;
            this.ckbStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbStatus.UncheckedState.Parent = this.ckbStatus;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            this.ckbStatus.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbSoLuongCauHoi
            // 
            this.lbSoLuongCauHoi.AutoSize = true;
            this.lbSoLuongCauHoi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongCauHoi.Location = new System.Drawing.Point(191, 13);
            this.lbSoLuongCauHoi.Name = "lbSoLuongCauHoi";
            this.lbSoLuongCauHoi.Size = new System.Drawing.Size(152, 18);
            this.lbSoLuongCauHoi.TabIndex = 0;
            this.lbSoLuongCauHoi.Text = "Số lượng câu hỏi:";
            this.lbSoLuongCauHoi.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbThoiGianLamBai
            // 
            this.lbThoiGianLamBai.AutoSize = true;
            this.lbThoiGianLamBai.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianLamBai.Location = new System.Drawing.Point(25, 13);
            this.lbThoiGianLamBai.Name = "lbThoiGianLamBai";
            this.lbThoiGianLamBai.Size = new System.Drawing.Size(158, 18);
            this.lbThoiGianLamBai.TabIndex = 0;
            this.lbThoiGianLamBai.Text = "Thời gian làm bài:";
            this.lbThoiGianLamBai.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(387, 90);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(97, 18);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Trạng thái:";
            this.lbStatus.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // nudQCount
            // 
            this.nudQCount.BackColor = System.Drawing.Color.White;
            this.nudQCount.BorderColor = System.Drawing.Color.Gray;
            this.nudQCount.BorderRadius = 5;
            this.nudQCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQCount.DisabledState.Parent = this.nudQCount;
            this.nudQCount.FocusedState.Parent = this.nudQCount;
            this.nudQCount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQCount.ForeColor = System.Drawing.Color.Black;
            this.nudQCount.Location = new System.Drawing.Point(194, 37);
            this.nudQCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudQCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQCount.Name = "nudQCount";
            this.nudQCount.ShadowDecoration.Parent = this.nudQCount;
            this.nudQCount.Size = new System.Drawing.Size(139, 36);
            this.nudQCount.TabIndex = 0;
            this.nudQCount.TabStop = false;
            this.nudQCount.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
            this.nudQCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQCount.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lần thi:";
            this.label1.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // nudQuizTimes
            // 
            this.nudQuizTimes.BackColor = System.Drawing.Color.White;
            this.nudQuizTimes.BorderColor = System.Drawing.Color.Gray;
            this.nudQuizTimes.BorderRadius = 5;
            this.nudQuizTimes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuizTimes.DisabledState.Parent = this.nudQuizTimes;
            this.nudQuizTimes.FocusedState.Parent = this.nudQuizTimes;
            this.nudQuizTimes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuizTimes.ForeColor = System.Drawing.Color.Black;
            this.nudQuizTimes.Location = new System.Drawing.Point(360, 37);
            this.nudQuizTimes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudQuizTimes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuizTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuizTimes.Name = "nudQuizTimes";
            this.nudQuizTimes.ShadowDecoration.Parent = this.nudQuizTimes;
            this.nudQuizTimes.Size = new System.Drawing.Size(139, 36);
            this.nudQuizTimes.TabIndex = 0;
            this.nudQuizTimes.TabStop = false;
            this.nudQuizTimes.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
            this.nudQuizTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuizTimes.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // pnlInfo1
            // 
            this.pnlInfo1.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo1.Controls.Add(this.cbExamRole);
            this.pnlInfo1.Controls.Add(this.lbLoaiDe);
            this.pnlInfo1.Controls.Add(this.lbMonThi);
            this.pnlInfo1.Controls.Add(this.tbExamID);
            this.pnlInfo1.Controls.Add(this.cbSubject);
            this.pnlInfo1.Controls.Add(this.lbMaDe);
            this.pnlInfo1.FillColor = System.Drawing.Color.White;
            this.pnlInfo1.Location = new System.Drawing.Point(179, 20);
            this.pnlInfo1.Name = "pnlInfo1";
            this.pnlInfo1.Radius = 5;
            this.pnlInfo1.ShadowColor = System.Drawing.Color.Black;
            this.pnlInfo1.ShadowDepth = 255;
            this.pnlInfo1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlInfo1.Size = new System.Drawing.Size(530, 170);
            this.pnlInfo1.TabIndex = 0;
            this.pnlInfo1.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // cbExamRole
            // 
            this.cbExamRole.BackColor = System.Drawing.Color.Transparent;
            this.cbExamRole.BorderRadius = 4;
            this.cbExamRole.Color = System.Drawing.Color.Gray;
            this.cbExamRole.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbExamRole.DisabledColor = System.Drawing.Color.Gray;
            this.cbExamRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbExamRole.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbExamRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamRole.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbExamRole.FillDropDown = false;
            this.cbExamRole.FillIndicator = false;
            this.cbExamRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExamRole.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExamRole.ForeColor = System.Drawing.Color.Black;
            this.cbExamRole.FormattingEnabled = true;
            this.cbExamRole.Icon = null;
            this.cbExamRole.IndicatorColor = System.Drawing.Color.Black;
            this.cbExamRole.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbExamRole.ItemBackColor = System.Drawing.Color.White;
            this.cbExamRole.ItemBorderColor = System.Drawing.Color.White;
            this.cbExamRole.ItemForeColor = System.Drawing.Color.Black;
            this.cbExamRole.ItemHeight = 30;
            this.cbExamRole.ItemHighLightColor = System.Drawing.Color.GhostWhite;
            this.cbExamRole.Location = new System.Drawing.Point(275, 36);
            this.cbExamRole.Name = "cbExamRole";
            this.cbExamRole.Size = new System.Drawing.Size(215, 36);
            this.cbExamRole.TabIndex = 0;
            this.cbExamRole.TabStop = false;
            this.cbExamRole.Text = null;
            this.cbExamRole.SelectedIndexChanged += new System.EventHandler(this.cbExamRole_SelectedIndexChanged);
            this.cbExamRole.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbLoaiDe
            // 
            this.lbLoaiDe.AutoSize = true;
            this.lbLoaiDe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDe.Location = new System.Drawing.Point(282, 13);
            this.lbLoaiDe.Name = "lbLoaiDe";
            this.lbLoaiDe.Size = new System.Drawing.Size(75, 18);
            this.lbLoaiDe.TabIndex = 0;
            this.lbLoaiDe.Text = "Loại đề:";
            this.lbLoaiDe.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbMonThi
            // 
            this.lbMonThi.AutoSize = true;
            this.lbMonThi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonThi.Location = new System.Drawing.Point(47, 89);
            this.lbMonThi.Name = "lbMonThi";
            this.lbMonThi.Size = new System.Drawing.Size(76, 18);
            this.lbMonThi.TabIndex = 0;
            this.lbMonThi.Text = "Môn thi:";
            this.lbMonThi.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // tbExamID
            // 
            this.tbExamID.BorderColor = System.Drawing.Color.Gray;
            this.tbExamID.BorderRadius = 5;
            this.tbExamID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbExamID.DefaultText = "";
            this.tbExamID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbExamID.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbExamID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbExamID.DisabledState.Parent = this.tbExamID;
            this.tbExamID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbExamID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbExamID.FocusedState.Parent = this.tbExamID;
            this.tbExamID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExamID.ForeColor = System.Drawing.Color.Black;
            this.tbExamID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbExamID.HoverState.Parent = this.tbExamID;
            this.tbExamID.Location = new System.Drawing.Point(40, 36);
            this.tbExamID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbExamID.Name = "tbExamID";
            this.tbExamID.PasswordChar = '\0';
            this.tbExamID.PlaceholderText = "";
            this.tbExamID.SelectedText = "";
            this.tbExamID.ShadowDecoration.Parent = this.tbExamID;
            this.tbExamID.Size = new System.Drawing.Size(215, 36);
            this.tbExamID.TabIndex = 1;
            this.tbExamID.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cbSubject.BorderRadius = 4;
            this.cbSubject.Color = System.Drawing.Color.Gray;
            this.cbSubject.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbSubject.DisabledColor = System.Drawing.Color.Gray;
            this.cbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubject.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbSubject.FillDropDown = false;
            this.cbSubject.FillIndicator = false;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubject.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.ForeColor = System.Drawing.Color.Black;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Icon = null;
            this.cbSubject.IndicatorColor = System.Drawing.Color.Black;
            this.cbSubject.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbSubject.ItemBackColor = System.Drawing.Color.White;
            this.cbSubject.ItemBorderColor = System.Drawing.Color.White;
            this.cbSubject.ItemForeColor = System.Drawing.Color.Black;
            this.cbSubject.ItemHeight = 30;
            this.cbSubject.ItemHighLightColor = System.Drawing.Color.GhostWhite;
            this.cbSubject.Location = new System.Drawing.Point(40, 111);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(450, 36);
            this.cbSubject.TabIndex = 0;
            this.cbSubject.TabStop = false;
            this.cbSubject.Text = null;
            this.cbSubject.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // lbMaDe
            // 
            this.lbMaDe.AutoSize = true;
            this.lbMaDe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDe.Location = new System.Drawing.Point(47, 14);
            this.lbMaDe.Name = "lbMaDe";
            this.lbMaDe.Size = new System.Drawing.Size(64, 18);
            this.lbMaDe.TabIndex = 0;
            this.lbMaDe.Text = "Mã đề:";
            this.lbMaDe.Click += new System.EventHandler(this.ManageExam_Click);
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
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.Transparent;
            this.pnlDataGridView.Controls.Add(this.bScrollBar);
            this.pnlDataGridView.Controls.Add(this.btnEdit);
            this.pnlDataGridView.Controls.Add(this.tbSearch);
            this.pnlDataGridView.Controls.Add(this.btnCancle);
            this.pnlDataGridView.Controls.Add(this.aDgvdata);
            this.pnlDataGridView.Controls.Add(this.btnSave);
            this.pnlDataGridView.Controls.Add(this.btnClearFilter);
            this.pnlDataGridView.Controls.Add(this.btnDelete);
            this.pnlDataGridView.FillColor = System.Drawing.Color.White;
            this.pnlDataGridView.Location = new System.Drawing.Point(13, 309);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Radius = 5;
            this.pnlDataGridView.ShadowColor = System.Drawing.Color.Black;
            this.pnlDataGridView.ShadowDepth = 255;
            this.pnlDataGridView.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlDataGridView.Size = new System.Drawing.Size(1525, 500);
            this.pnlDataGridView.TabIndex = 0;
            this.pnlDataGridView.Click += new System.EventHandler(this.ManageExam_Click);
            // 
            // ManageExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.iconTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnlDataGridView);
            this.Name = "ManageExam";
            this.Size = new System.Drawing.Size(1550, 822);
            this.Load += new System.EventHandler(this.FrmManageExam_Load);
            this.Click += new System.EventHandler(this.ManageExam_Click);
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlInfo2.ResumeLayout(false);
            this.pnlInfo2.PerformLayout();
            this.gbMark.ResumeLayout(false);
            this.gbMark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuizTimes)).EndInit();
            this.pnlInfo1.ResumeLayout(false);
            this.pnlInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
            this.pnlDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton iconTitle;
        private FontAwesome.Sharp.IconButton btnAdd;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnDelete;
		public FontAwesome.Sharp.IconButton btnSave;
		public FontAwesome.Sharp.IconButton btnCancle;
		private System.Windows.Forms.Panel pnlControls;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudQCount;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudExamTime;
		private System.Windows.Forms.Label lbSoLuongCauHoi;
		private System.Windows.Forms.Label lbLoaiDe;
		private System.Windows.Forms.Label lbThoiGianLamBai;
		private Guna.UI2.WinForms.Guna2TextBox tbExamID;
		private System.Windows.Forms.Label lbMonThi;
		private System.Windows.Forms.Label lbMaDe;
		private Bunifu.UI.WinForms.BunifuDropdown cbExamRole;
		private Bunifu.UI.WinForms.BunifuDropdown cbSubject;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.ToolTip toolTip;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudQuizTimes;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
		private System.Windows.Forms.Label lbStatus;
		public ADGV.AdvancedDataGridView aDgvdata;
		private Guna.UI2.WinForms.Guna2CustomCheckBox ckbStatus;
		private System.Windows.Forms.LinkLabel lbCheckStatus;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TestFormID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PercentMark;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuizTimes;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCurrentCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.Panel gbMark;
		private Bunifu.UI.WinForms.BunifuDropdown cbTestFormID;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudPercentMark;
		private System.Windows.Forms.Label lbPercentMark;
		private System.Windows.Forms.Label lbTestFormID;
	}
}