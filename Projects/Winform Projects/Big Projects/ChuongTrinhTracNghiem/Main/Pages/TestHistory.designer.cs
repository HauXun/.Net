
namespace Main.Pages
{
	partial class TestHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconTitle = new FontAwesome.Sharp.IconButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
            this.aDgvdata = new ADGV.AdvancedDataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDataGridView = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
            this.pnlDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatAppearance.BorderSize = 0;
            this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.History;
            this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 35;
            this.iconTitle.Location = new System.Drawing.Point(45, 21);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(35, 37);
            this.iconTitle.TabIndex = 0;
            this.iconTitle.TabStop = false;
            this.iconTitle.UseVisualStyleBackColor = false;
            this.iconTitle.Click += new System.EventHandler(this.TestHistory_Click);
            this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.lbTitle.Location = new System.Drawing.Point(85, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(165, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Lịch sử thi";
            this.lbTitle.Click += new System.EventHandler(this.TestHistory_Click);
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
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TabStop = false;
            this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
            this.tbSearch.Click += new System.EventHandler(this.TestHistory_Click);
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
            this.bScrollBar.TabIndex = 0;
            this.bScrollBar.TabStop = false;
            this.bScrollBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bScrollBar.ThumbFillColor = System.Drawing.Color.White;
            this.bScrollBar.ThumbLength = 61;
            this.bScrollBar.ThumbMargin = 1;
            this.bScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
            this.bScrollBar.Value = 100;
            this.bScrollBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs>(this.bScrollBar_Scroll);
            this.bScrollBar.Click += new System.EventHandler(this.TestHistory_Click);
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
            this.SubjectName,
            this.SubjectID,
            this.CreatedAt,
            this.CorrectAnswer,
            this.TotalQuestion,
            this.Mark});
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
            this.aDgvdata.Location = new System.Drawing.Point(45, 53);
            this.aDgvdata.Name = "aDgvdata";
            this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.aDgvdata.RowHeadersVisible = false;
            this.aDgvdata.RowTemplate.Height = 50;
            this.aDgvdata.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aDgvdata.Size = new System.Drawing.Size(1429, 660);
            this.aDgvdata.TabIndex = 0;
            this.aDgvdata.TabStop = false;
            this.aDgvdata.TimeFilter = false;
            this.aDgvdata.SortStringChanged += new System.EventHandler(this.aDgvdata_SortStringChanged);
            this.aDgvdata.FilterStringChanged += new System.EventHandler(this.aDgvdata_FilterStringChanged);
            this.aDgvdata.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.aDgvdata_RowPrePaint);
            this.aDgvdata.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aDgvdata_RowsAdded);
            this.aDgvdata.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.aDgvdata_RowsRemoved);
            this.aDgvdata.Click += new System.EventHandler(this.TestHistory_Click);
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
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.FillWeight = 190F;
            this.SubjectName.HeaderText = "Tên môn thi";
            this.SubjectName.MinimumWidth = 22;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubjectID.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubjectID.FillWeight = 80F;
            this.SubjectID.HeaderText = "Mã môn";
            this.SubjectID.MinimumWidth = 22;
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "dd/MM/yyyy";
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle5;
            this.CreatedAt.FillWeight = 80F;
            this.CreatedAt.HeaderText = "Ngày thi";
            this.CreatedAt.MinimumWidth = 22;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.DataPropertyName = "CorrectAnswer";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CorrectAnswer.DefaultCellStyle = dataGridViewCellStyle6;
            this.CorrectAnswer.FillWeight = 60F;
            this.CorrectAnswer.HeaderText = "Số câu đúng";
            this.CorrectAnswer.MinimumWidth = 22;
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.ReadOnly = true;
            this.CorrectAnswer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TotalQuestion
            // 
            this.TotalQuestion.DataPropertyName = "TotalQuestion";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalQuestion.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalQuestion.FillWeight = 60F;
            this.TotalQuestion.HeaderText = "Tổng số câu";
            this.TotalQuestion.MinimumWidth = 22;
            this.TotalQuestion.Name = "TotalQuestion";
            this.TotalQuestion.ReadOnly = true;
            this.TotalQuestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Mark
            // 
            this.Mark.DataPropertyName = "Mark";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mark.DefaultCellStyle = dataGridViewCellStyle8;
            this.Mark.FillWeight = 60F;
            this.Mark.HeaderText = "Điểm";
            this.Mark.MinimumWidth = 22;
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.btnClearFilter.Location = new System.Drawing.Point(350, 10);
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
            this.pnlDataGridView.Controls.Add(this.tbSearch);
            this.pnlDataGridView.Controls.Add(this.bScrollBar);
            this.pnlDataGridView.Controls.Add(this.btnClearFilter);
            this.pnlDataGridView.Controls.Add(this.aDgvdata);
            this.pnlDataGridView.FillColor = System.Drawing.Color.White;
            this.pnlDataGridView.Location = new System.Drawing.Point(13, 80);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Radius = 5;
            this.pnlDataGridView.ShadowColor = System.Drawing.Color.Black;
            this.pnlDataGridView.ShadowDepth = 255;
            this.pnlDataGridView.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlDataGridView.Size = new System.Drawing.Size(1525, 730);
            this.pnlDataGridView.TabIndex = 0;
            this.pnlDataGridView.Click += new System.EventHandler(this.TestHistory_Click);
            // 
            // TestHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.iconTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnlDataGridView);
            this.Name = "TestHistory";
            this.Size = new System.Drawing.Size(1550, 822);
            this.Load += new System.EventHandler(this.FrmTestHistory_Load);
            this.Click += new System.EventHandler(this.TestHistory_Click);
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
            this.pnlDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
		private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswer;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuestion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
		private System.Windows.Forms.ToolTip toolTip;
		public ADGV.AdvancedDataGridView aDgvdata;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDataGridView;
    }
}