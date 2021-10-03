
namespace Main.Pages
{
	partial class ManageFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFaculty));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.iconTitle = new FontAwesome.Sharp.IconButton();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlInfo2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tbFacultyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpFoundingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.lbNgayThanhLap = new System.Windows.Forms.Label();
            this.pnlInfo1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.tbFacultyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMoTa = new System.Windows.Forms.Label();
            this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.aDgvdata = new ADGV.AdvancedDataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoundingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnCancle = new FontAwesome.Sharp.IconButton();
            this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDataGridView = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlControls.SuspendLayout();
            this.pnlInfo2.SuspendLayout();
            this.pnlInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
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
            this.lbTitle.Size = new System.Drawing.Size(207, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Quản lý khoa";
            this.lbTitle.Click += new System.EventHandler(this.ManageFaculty_Click);
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
            this.toolTip.SetToolTip(this.btnAdd, "Thêm khoa");
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
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 35;
            this.iconTitle.Location = new System.Drawing.Point(70, 23);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(35, 37);
            this.iconTitle.TabIndex = 0;
            this.iconTitle.TabStop = false;
            this.iconTitle.UseVisualStyleBackColor = false;
            this.iconTitle.Click += new System.EventHandler(this.ManageFaculty_Click);
            this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
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
            this.pnlControls.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // pnlInfo2
            // 
            this.pnlInfo2.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo2.Controls.Add(this.tbFacultyName);
            this.pnlInfo2.Controls.Add(this.dtpFoundingDate);
            this.pnlInfo2.Controls.Add(this.lbTenKhoa);
            this.pnlInfo2.Controls.Add(this.lbNgayThanhLap);
            this.pnlInfo2.FillColor = System.Drawing.Color.White;
            this.pnlInfo2.Location = new System.Drawing.Point(822, 20);
            this.pnlInfo2.Name = "pnlInfo2";
            this.pnlInfo2.Radius = 5;
            this.pnlInfo2.ShadowColor = System.Drawing.Color.Black;
            this.pnlInfo2.ShadowDepth = 255;
            this.pnlInfo2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlInfo2.Size = new System.Drawing.Size(500, 170);
            this.pnlInfo2.TabIndex = 1;
            this.pnlInfo2.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // tbFacultyName
            // 
            this.tbFacultyName.BorderColor = System.Drawing.Color.Gray;
            this.tbFacultyName.BorderRadius = 5;
            this.tbFacultyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFacultyName.DefaultText = "";
            this.tbFacultyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFacultyName.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbFacultyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFacultyName.DisabledState.Parent = this.tbFacultyName;
            this.tbFacultyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFacultyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFacultyName.FocusedState.Parent = this.tbFacultyName;
            this.tbFacultyName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacultyName.ForeColor = System.Drawing.Color.Black;
            this.tbFacultyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFacultyName.HoverState.Parent = this.tbFacultyName;
            this.tbFacultyName.Location = new System.Drawing.Point(35, 36);
            this.tbFacultyName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbFacultyName.Name = "tbFacultyName";
            this.tbFacultyName.PasswordChar = '\0';
            this.tbFacultyName.PlaceholderText = "";
            this.tbFacultyName.SelectedText = "";
            this.tbFacultyName.ShadowDecoration.Parent = this.tbFacultyName;
            this.tbFacultyName.Size = new System.Drawing.Size(430, 35);
            this.tbFacultyName.TabIndex = 3;
            this.tbFacultyName.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // dtpFoundingDate
            // 
            this.dtpFoundingDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpFoundingDate.BorderRadius = 5;
            this.dtpFoundingDate.BorderThickness = 1;
            this.dtpFoundingDate.CheckedState.Parent = this.dtpFoundingDate;
            this.dtpFoundingDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFoundingDate.FillColor = System.Drawing.Color.White;
            this.dtpFoundingDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFoundingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFoundingDate.HoverState.Parent = this.dtpFoundingDate;
            this.dtpFoundingDate.Location = new System.Drawing.Point(35, 110);
            this.dtpFoundingDate.MaxDate = new System.DateTime(9998, 12, 12, 0, 0, 0, 0);
            this.dtpFoundingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFoundingDate.Name = "dtpFoundingDate";
            this.dtpFoundingDate.ShadowDecoration.Parent = this.dtpFoundingDate;
            this.dtpFoundingDate.Size = new System.Drawing.Size(430, 35);
            this.dtpFoundingDate.TabIndex = 1;
            this.dtpFoundingDate.TabStop = false;
            this.dtpFoundingDate.Value = new System.DateTime(2021, 9, 6, 0, 2, 13, 728);
            this.dtpFoundingDate.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhoa.Location = new System.Drawing.Point(42, 13);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(90, 18);
            this.lbTenKhoa.TabIndex = 0;
            this.lbTenKhoa.Text = "Tên khoa:";
            this.lbTenKhoa.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // lbNgayThanhLap
            // 
            this.lbNgayThanhLap.AutoSize = true;
            this.lbNgayThanhLap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThanhLap.Location = new System.Drawing.Point(42, 87);
            this.lbNgayThanhLap.Name = "lbNgayThanhLap";
            this.lbNgayThanhLap.Size = new System.Drawing.Size(140, 18);
            this.lbNgayThanhLap.TabIndex = 0;
            this.lbNgayThanhLap.Text = "Ngày thành lập:";
            this.lbNgayThanhLap.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // pnlInfo1
            // 
            this.pnlInfo1.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo1.Controls.Add(this.tbDescription);
            this.pnlInfo1.Controls.Add(this.lbMaKhoa);
            this.pnlInfo1.Controls.Add(this.tbFacultyID);
            this.pnlInfo1.Controls.Add(this.lbMoTa);
            this.pnlInfo1.FillColor = System.Drawing.Color.White;
            this.pnlInfo1.Location = new System.Drawing.Point(179, 20);
            this.pnlInfo1.Name = "pnlInfo1";
            this.pnlInfo1.Radius = 5;
            this.pnlInfo1.ShadowColor = System.Drawing.Color.Black;
            this.pnlInfo1.ShadowDepth = 255;
            this.pnlInfo1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlInfo1.Size = new System.Drawing.Size(500, 170);
            this.pnlInfo1.TabIndex = 0;
            this.pnlInfo1.Click += new System.EventHandler(this.ManageFaculty_Click);
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
            this.tbDescription.Size = new System.Drawing.Size(430, 35);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhoa.Location = new System.Drawing.Point(42, 15);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(83, 18);
            this.lbMaKhoa.TabIndex = 0;
            this.lbMaKhoa.Text = "Mã khoa:";
            this.lbMaKhoa.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // tbFacultyID
            // 
            this.tbFacultyID.BorderColor = System.Drawing.Color.Gray;
            this.tbFacultyID.BorderRadius = 5;
            this.tbFacultyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFacultyID.DefaultText = "";
            this.tbFacultyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFacultyID.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbFacultyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFacultyID.DisabledState.Parent = this.tbFacultyID;
            this.tbFacultyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFacultyID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFacultyID.FocusedState.Parent = this.tbFacultyID;
            this.tbFacultyID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacultyID.ForeColor = System.Drawing.Color.Black;
            this.tbFacultyID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFacultyID.HoverState.Parent = this.tbFacultyID;
            this.tbFacultyID.Location = new System.Drawing.Point(35, 38);
            this.tbFacultyID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbFacultyID.Name = "tbFacultyID";
            this.tbFacultyID.PasswordChar = '\0';
            this.tbFacultyID.PlaceholderText = "";
            this.tbFacultyID.SelectedText = "";
            this.tbFacultyID.ShadowDecoration.Parent = this.tbFacultyID;
            this.tbFacultyID.Size = new System.Drawing.Size(430, 35);
            this.tbFacultyID.TabIndex = 1;
            this.tbFacultyID.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // lbMoTa
            // 
            this.lbMoTa.AutoSize = true;
            this.lbMoTa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTa.Location = new System.Drawing.Point(42, 89);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(61, 18);
            this.lbMoTa.TabIndex = 0;
            this.lbMoTa.Text = "Mô tả:";
            this.lbMoTa.Click += new System.EventHandler(this.ManageFaculty_Click);
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
            this.bScrollBar.Click += new System.EventHandler(this.ManageFaculty_Click);
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
            this.tbSearch.Click += new System.EventHandler(this.ManageFaculty_Click);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
            // 
            // aDgvdata
            // 
            this.aDgvdata.AllowUserToAddRows = false;
            this.aDgvdata.AllowUserToDeleteRows = false;
            this.aDgvdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.aDgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.aDgvdata.AutoGenerateContextFilters = true;
            this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aDgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.aDgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aDgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.aDgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.aDgvdata.ColumnHeadersHeight = 40;
            this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.aDgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.FacultyName,
            this.FacultyID,
            this.FoundingDate,
            this.Description});
            this.aDgvdata.DateWithTime = false;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle32;
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
            this.aDgvdata.Click += new System.EventHandler(this.ManageFaculty_Click);
            this.aDgvdata.Enter += new System.EventHandler(this.aDgvdata_Enter);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle27;
            this.STT.FillWeight = 40F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 22;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FacultyName
            // 
            this.FacultyName.DataPropertyName = "FacultyName";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FacultyName.DefaultCellStyle = dataGridViewCellStyle28;
            this.FacultyName.HeaderText = "Tên khoa";
            this.FacultyName.MinimumWidth = 22;
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            this.FacultyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FacultyID
            // 
            this.FacultyID.DataPropertyName = "FacultyID";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FacultyID.DefaultCellStyle = dataGridViewCellStyle29;
            this.FacultyID.FillWeight = 60F;
            this.FacultyID.HeaderText = "Mã khoa";
            this.FacultyID.MinimumWidth = 22;
            this.FacultyID.Name = "FacultyID";
            this.FacultyID.ReadOnly = true;
            this.FacultyID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FoundingDate
            // 
            this.FoundingDate.DataPropertyName = "FoundingDate";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.Format = "d";
            dataGridViewCellStyle30.NullValue = "dd/MM/yyyy";
            this.FoundingDate.DefaultCellStyle = dataGridViewCellStyle30;
            this.FoundingDate.FillWeight = 60F;
            this.FoundingDate.HeaderText = "Ngày thành lập";
            this.FoundingDate.MinimumWidth = 22;
            this.FoundingDate.Name = "FoundingDate";
            this.FoundingDate.ReadOnly = true;
            this.FoundingDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Description.DefaultCellStyle = dataGridViewCellStyle31;
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
            this.btnEdit.TabIndex = 0;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnEdit, "Sửa thông tin khoa");
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
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = " Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnDelete, "Xóa khoa");
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
            this.btnCancle.TabIndex = 0;
            this.btnCancle.TabStop = false;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnCancle, "Hủy thao tác");
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Visible = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            this.btnCancle.Enter += new System.EventHandler(this.iconTitle_Enter);
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
            this.pnlDataGridView.Controls.Add(this.tbSearch);
            this.pnlDataGridView.Controls.Add(this.btnCancle);
            this.pnlDataGridView.Controls.Add(this.aDgvdata);
            this.pnlDataGridView.Controls.Add(this.btnSave);
            this.pnlDataGridView.Controls.Add(this.btnClearFilter);
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
            this.pnlDataGridView.Click += new System.EventHandler(this.ManageFaculty_Click);
            // 
            // ManageFaculty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.iconTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnlDataGridView);
            this.Name = "ManageFaculty";
            this.Size = new System.Drawing.Size(1550, 822);
            this.Load += new System.EventHandler(this.FrmManageFaculty_Load);
            this.Click += new System.EventHandler(this.ManageFaculty_Click);
            this.pnlControls.ResumeLayout(false);
            this.pnlInfo2.ResumeLayout(false);
            this.pnlInfo2.PerformLayout();
            this.pnlInfo1.ResumeLayout(false);
            this.pnlInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
            this.pnlDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton btnAdd;
		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Panel pnlControls;
		private Guna.UI2.WinForms.Guna2TextBox tbFacultyName;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpFoundingDate;
		private System.Windows.Forms.Label lbNgayThanhLap;
		private System.Windows.Forms.Label lbTenKhoa;
		private Guna.UI2.WinForms.Guna2TextBox tbDescription;
		private Guna.UI2.WinForms.Guna2TextBox tbFacultyID;
		private System.Windows.Forms.Label lbMoTa;
		private System.Windows.Forms.Label lbMaKhoa;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnDelete;
		public FontAwesome.Sharp.IconButton btnSave;
		public FontAwesome.Sharp.IconButton btnCancle;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FoundingDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.ToolTip toolTip;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
		public ADGV.AdvancedDataGridView aDgvdata;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDataGridView;
    }
}