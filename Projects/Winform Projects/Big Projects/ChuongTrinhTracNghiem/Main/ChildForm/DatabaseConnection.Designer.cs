﻿
namespace Main
{
    partial class DatabaseConnection
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnection));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties41 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties42 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties43 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties44 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties45 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties46 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties47 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties48 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.lbFormTitle = new System.Windows.Forms.Label();
			this.formIcon = new FontAwesome.Sharp.IconButton();
			this.btnClose = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.cbServer = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbAuthentication = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbServerName = new System.Windows.Forms.Label();
			this.lbAuthentication = new System.Windows.Forms.Label();
			this.pnlLine = new System.Windows.Forms.Panel();
			this.pnl1 = new System.Windows.Forms.Panel();
			this.pnlAccount = new System.Windows.Forms.Panel();
			this.tbUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.tbPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.btnTestConnect = new FontAwesome.Sharp.IconButton();
			this.btnConnect = new FontAwesome.Sharp.IconButton();
			this.pnl2 = new System.Windows.Forms.Panel();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbRememberPassword = new System.Windows.Forms.Label();
			this.wP = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
			this.pnlTitleBar.SuspendLayout();
			this.pnl1.SuspendLayout();
			this.pnlAccount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
			this.pnlTitleBar.Controls.Add(this.lbFormTitle);
			this.pnlTitleBar.Controls.Add(this.formIcon);
			this.pnlTitleBar.Controls.Add(this.btnClose);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(520, 30);
			this.pnlTitleBar.TabIndex = 0;
			// 
			// lbFormTitle
			// 
			this.lbFormTitle.AutoSize = true;
			this.lbFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFormTitle.ForeColor = System.Drawing.Color.White;
			this.lbFormTitle.Location = new System.Drawing.Point(25, 7);
			this.lbFormTitle.Name = "lbFormTitle";
			this.lbFormTitle.Size = new System.Drawing.Size(114, 16);
			this.lbFormTitle.TabIndex = 8;
			this.lbFormTitle.Text = "Connect to Server";
			// 
			// formIcon
			// 
			this.formIcon.BackColor = System.Drawing.Color.Transparent;
			this.formIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.formIcon.FlatAppearance.BorderSize = 0;
			this.formIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
			this.formIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
			this.formIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.formIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.formIcon.IconChar = FontAwesome.Sharp.IconChar.Coins;
			this.formIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
			this.formIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.formIcon.IconSize = 20;
			this.formIcon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.formIcon.Location = new System.Drawing.Point(0, 0);
			this.formIcon.Name = "formIcon";
			this.formIcon.Size = new System.Drawing.Size(30, 30);
			this.formIcon.TabIndex = 0;
			this.formIcon.TabStop = false;
			this.formIcon.UseVisualStyleBackColor = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(186)))), ((int)(((byte)(116)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(490, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(30, 30);
			this.btnClose.TabIndex = 0;
			this.btnClose.TabStop = false;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(141, 17);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(198, 39);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "SQL Server";
			// 
			// cbServer
			// 
			this.cbServer.BackColor = System.Drawing.Color.White;
			this.cbServer.BorderRadius = 3;
			this.cbServer.Color = System.Drawing.Color.Gray;
			this.cbServer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbServer.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbServer.DisabledColor = System.Drawing.Color.Gray;
			this.cbServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbServer.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbServer.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbServer.FillDropDown = false;
			this.cbServer.FillIndicator = false;
			this.cbServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbServer.ForeColor = System.Drawing.Color.Black;
			this.cbServer.FormattingEnabled = true;
			this.cbServer.Icon = null;
			this.cbServer.IndicatorColor = System.Drawing.Color.Black;
			this.cbServer.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbServer.ItemBackColor = System.Drawing.Color.White;
			this.cbServer.ItemBorderColor = System.Drawing.Color.White;
			this.cbServer.ItemForeColor = System.Drawing.Color.Black;
			this.cbServer.ItemHeight = 28;
			this.cbServer.ItemHighLightColor = System.Drawing.Color.Gainsboro;
			this.cbServer.Items.AddRange(new object[] {
            "(local)",
            ".",
            ".\\SQLEXPRESS"});
			this.cbServer.Location = new System.Drawing.Point(153, 88);
			this.cbServer.Name = "cbServer";
			this.cbServer.Size = new System.Drawing.Size(277, 34);
			this.cbServer.Sorted = true;
			this.cbServer.TabIndex = 0;
			this.cbServer.Text = null;
			// 
			// cbAuthentication
			// 
			this.cbAuthentication.BackColor = System.Drawing.Color.White;
			this.cbAuthentication.BorderRadius = 3;
			this.cbAuthentication.Color = System.Drawing.Color.Gray;
			this.cbAuthentication.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbAuthentication.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbAuthentication.DisabledColor = System.Drawing.Color.Gray;
			this.cbAuthentication.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbAuthentication.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAuthentication.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbAuthentication.FillDropDown = false;
			this.cbAuthentication.FillIndicator = false;
			this.cbAuthentication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbAuthentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAuthentication.ForeColor = System.Drawing.Color.Black;
			this.cbAuthentication.FormattingEnabled = true;
			this.cbAuthentication.Icon = null;
			this.cbAuthentication.IndicatorColor = System.Drawing.Color.Black;
			this.cbAuthentication.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbAuthentication.ItemBackColor = System.Drawing.Color.White;
			this.cbAuthentication.ItemBorderColor = System.Drawing.Color.White;
			this.cbAuthentication.ItemForeColor = System.Drawing.Color.Black;
			this.cbAuthentication.ItemHeight = 28;
			this.cbAuthentication.ItemHighLightColor = System.Drawing.Color.Gainsboro;
			this.cbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
			this.cbAuthentication.Location = new System.Drawing.Point(153, 145);
			this.cbAuthentication.Name = "cbAuthentication";
			this.cbAuthentication.Size = new System.Drawing.Size(277, 34);
			this.cbAuthentication.TabIndex = 1;
			this.cbAuthentication.Text = null;
			this.cbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbAuthentication_SelectedIndexChanged);
			// 
			// lbServerName
			// 
			this.lbServerName.AutoSize = true;
			this.lbServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbServerName.Location = new System.Drawing.Point(30, 94);
			this.lbServerName.Name = "lbServerName";
			this.lbServerName.Size = new System.Drawing.Size(103, 20);
			this.lbServerName.TabIndex = 0;
			this.lbServerName.Text = "Server name:";
			// 
			// lbAuthentication
			// 
			this.lbAuthentication.AutoSize = true;
			this.lbAuthentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAuthentication.Location = new System.Drawing.Point(30, 152);
			this.lbAuthentication.Name = "lbAuthentication";
			this.lbAuthentication.Size = new System.Drawing.Size(116, 20);
			this.lbAuthentication.TabIndex = 0;
			this.lbAuthentication.Text = "Authentication:";
			// 
			// pnlLine
			// 
			this.pnlLine.BackColor = System.Drawing.Color.Gray;
			this.pnlLine.Location = new System.Drawing.Point(30, 346);
			this.pnlLine.Name = "pnlLine";
			this.pnlLine.Size = new System.Drawing.Size(400, 1);
			this.pnlLine.TabIndex = 7;
			// 
			// pnl1
			// 
			this.pnl1.BackColor = System.Drawing.Color.White;
			this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl1.Controls.Add(this.wP);
			this.pnl1.Controls.Add(this.panel1);
			this.pnl1.Controls.Add(this.pnlAccount);
			this.pnl1.Controls.Add(this.pnlLine);
			this.pnl1.Controls.Add(this.cbServer);
			this.pnl1.Controls.Add(this.btnTestConnect);
			this.pnl1.Controls.Add(this.lbTitle);
			this.pnl1.Controls.Add(this.btnConnect);
			this.pnl1.Controls.Add(this.cbAuthentication);
			this.pnl1.Controls.Add(this.lbAuthentication);
			this.pnl1.Controls.Add(this.lbServerName);
			this.pnl1.Location = new System.Drawing.Point(30, 59);
			this.pnl1.Name = "pnl1";
			this.pnl1.Size = new System.Drawing.Size(460, 431);
			this.pnl1.TabIndex = 8;
			// 
			// pnlAccount
			// 
			this.pnlAccount.Controls.Add(this.lbRememberPassword);
			this.pnlAccount.Controls.Add(this.tbUsername);
			this.pnlAccount.Controls.Add(this.tbPassword);
			this.pnlAccount.Controls.Add(this.lbUsername);
			this.pnlAccount.Controls.Add(this.lbPassword);
			this.pnlAccount.Location = new System.Drawing.Point(5, 185);
			this.pnlAccount.Name = "pnlAccount";
			this.pnlAccount.Size = new System.Drawing.Size(450, 146);
			this.pnlAccount.TabIndex = 8;
			// 
			// tbUsername
			// 
			this.tbUsername.AcceptsReturn = false;
			this.tbUsername.AcceptsTab = false;
			this.tbUsername.AnimationSpeed = 200;
			this.tbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.tbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.tbUsername.BackColor = System.Drawing.Color.Transparent;
			this.tbUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbUsername.BackgroundImage")));
			this.tbUsername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.tbUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.tbUsername.BorderColorHover = System.Drawing.Color.Gray;
			this.tbUsername.BorderColorIdle = System.Drawing.Color.Gray;
			this.tbUsername.BorderRadius = 5;
			this.tbUsername.BorderThickness = 1;
			this.tbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsername.DefaultText = "";
			this.tbUsername.FillColor = System.Drawing.Color.White;
			this.tbUsername.HideSelection = true;
			this.tbUsername.IconLeft = null;
			this.tbUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.IconPadding = 10;
			this.tbUsername.IconRight = null;
			this.tbUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.Lines = new string[0];
			this.tbUsername.Location = new System.Drawing.Point(148, 13);
			this.tbUsername.MaxLength = 32767;
			this.tbUsername.MinimumSize = new System.Drawing.Size(100, 35);
			this.tbUsername.Modified = false;
			this.tbUsername.Multiline = false;
			this.tbUsername.Name = "tbUsername";
			stateProperties41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			stateProperties41.FillColor = System.Drawing.Color.Empty;
			stateProperties41.ForeColor = System.Drawing.Color.Empty;
			stateProperties41.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbUsername.OnActiveState = stateProperties41;
			stateProperties42.BorderColor = System.Drawing.Color.Empty;
			stateProperties42.FillColor = System.Drawing.Color.White;
			stateProperties42.ForeColor = System.Drawing.Color.Empty;
			stateProperties42.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbUsername.OnDisabledState = stateProperties42;
			stateProperties43.BorderColor = System.Drawing.Color.Gray;
			stateProperties43.FillColor = System.Drawing.Color.Empty;
			stateProperties43.ForeColor = System.Drawing.Color.Empty;
			stateProperties43.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbUsername.OnHoverState = stateProperties43;
			stateProperties44.BorderColor = System.Drawing.Color.Gray;
			stateProperties44.FillColor = System.Drawing.Color.White;
			stateProperties44.ForeColor = System.Drawing.Color.Empty;
			stateProperties44.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbUsername.OnIdleState = stateProperties44;
			this.tbUsername.PasswordChar = '\0';
			this.tbUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbUsername.PlaceholderText = "";
			this.tbUsername.ReadOnly = false;
			this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbUsername.SelectedText = "";
			this.tbUsername.SelectionLength = 0;
			this.tbUsername.SelectionStart = 0;
			this.tbUsername.ShortcutsEnabled = true;
			this.tbUsername.Size = new System.Drawing.Size(277, 35);
			this.tbUsername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.tbUsername.TabIndex = 6;
			this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.tbUsername.TextMarginBottom = 0;
			this.tbUsername.TextMarginLeft = 5;
			this.tbUsername.TextMarginTop = 0;
			this.tbUsername.TextPlaceholder = "";
			this.tbUsername.UseSystemPasswordChar = false;
			this.tbUsername.WordWrap = true;
			// 
			// tbPassword
			// 
			this.tbPassword.AcceptsReturn = false;
			this.tbPassword.AcceptsTab = false;
			this.tbPassword.AnimationSpeed = 200;
			this.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.tbPassword.BackColor = System.Drawing.Color.Transparent;
			this.tbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPassword.BackgroundImage")));
			this.tbPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.tbPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.tbPassword.BorderColorHover = System.Drawing.Color.Gray;
			this.tbPassword.BorderColorIdle = System.Drawing.Color.Gray;
			this.tbPassword.BorderRadius = 5;
			this.tbPassword.BorderThickness = 1;
			this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.DefaultText = "";
			this.tbPassword.FillColor = System.Drawing.Color.White;
			this.tbPassword.HideSelection = true;
			this.tbPassword.IconLeft = null;
			this.tbPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.IconPadding = 10;
			this.tbPassword.IconRight = null;
			this.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.Lines = new string[0];
			this.tbPassword.Location = new System.Drawing.Point(148, 71);
			this.tbPassword.MaxLength = 32767;
			this.tbPassword.MinimumSize = new System.Drawing.Size(100, 35);
			this.tbPassword.Modified = false;
			this.tbPassword.Multiline = false;
			this.tbPassword.Name = "tbPassword";
			stateProperties45.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			stateProperties45.FillColor = System.Drawing.Color.Empty;
			stateProperties45.ForeColor = System.Drawing.Color.Empty;
			stateProperties45.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbPassword.OnActiveState = stateProperties45;
			stateProperties46.BorderColor = System.Drawing.Color.Empty;
			stateProperties46.FillColor = System.Drawing.Color.White;
			stateProperties46.ForeColor = System.Drawing.Color.Empty;
			stateProperties46.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbPassword.OnDisabledState = stateProperties46;
			stateProperties47.BorderColor = System.Drawing.Color.Gray;
			stateProperties47.FillColor = System.Drawing.Color.Empty;
			stateProperties47.ForeColor = System.Drawing.Color.Empty;
			stateProperties47.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbPassword.OnHoverState = stateProperties47;
			stateProperties48.BorderColor = System.Drawing.Color.Gray;
			stateProperties48.FillColor = System.Drawing.Color.White;
			stateProperties48.ForeColor = System.Drawing.Color.Empty;
			stateProperties48.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbPassword.OnIdleState = stateProperties48;
			this.tbPassword.PasswordChar = '●';
			this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbPassword.PlaceholderText = "";
			this.tbPassword.ReadOnly = false;
			this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbPassword.SelectedText = "";
			this.tbPassword.SelectionLength = 0;
			this.tbPassword.SelectionStart = 0;
			this.tbPassword.ShortcutsEnabled = true;
			this.tbPassword.Size = new System.Drawing.Size(277, 35);
			this.tbPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.tbPassword.TabIndex = 7;
			this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.tbPassword.TextMarginBottom = 0;
			this.tbPassword.TextMarginLeft = 5;
			this.tbPassword.TextMarginTop = 0;
			this.tbPassword.TextPlaceholder = "";
			this.tbPassword.UseSystemPasswordChar = true;
			this.tbPassword.WordWrap = true;
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(25, 21);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(87, 20);
			this.lbUsername.TabIndex = 4;
			this.lbUsername.Text = "Username:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPassword.Location = new System.Drawing.Point(25, 79);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(82, 20);
			this.lbPassword.TabIndex = 5;
			this.lbPassword.Text = "Password:";
			// 
			// btnTestConnect
			// 
			this.btnTestConnect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTestConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTestConnect.IconChar = FontAwesome.Sharp.IconChar.Unsplash;
			this.btnTestConnect.IconColor = System.Drawing.Color.Black;
			this.btnTestConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnTestConnect.IconSize = 20;
			this.btnTestConnect.Location = new System.Drawing.Point(310, 367);
			this.btnTestConnect.Name = "btnTestConnect";
			this.btnTestConnect.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
			this.btnTestConnect.Size = new System.Drawing.Size(120, 35);
			this.btnTestConnect.TabIndex = 6;
			this.btnTestConnect.Text = "Test connect";
			this.btnTestConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTestConnect.UseVisualStyleBackColor = true;
			this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.ForeColor = System.Drawing.Color.White;
			this.btnConnect.IconChar = FontAwesome.Sharp.IconChar.Plug;
			this.btnConnect.IconColor = System.Drawing.Color.White;
			this.btnConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnConnect.IconSize = 20;
			this.btnConnect.Location = new System.Drawing.Point(153, 367);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.btnConnect.Size = new System.Drawing.Size(110, 35);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Connect";
			this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// pnl2
			// 
			this.pnl2.BackColor = System.Drawing.Color.Gray;
			this.pnl2.Location = new System.Drawing.Point(33, 62);
			this.pnl2.Name = "pnl2";
			this.pnl2.Size = new System.Drawing.Size(460, 431);
			this.pnl2.TabIndex = 10;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Location = new System.Drawing.Point(29, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 1);
			this.panel1.TabIndex = 9;
			// 
			// lbRememberPassword
			// 
			this.lbRememberPassword.AutoSize = true;
			this.lbRememberPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRememberPassword.Location = new System.Drawing.Point(170, 116);
			this.lbRememberPassword.Name = "lbRememberPassword";
			this.lbRememberPassword.Size = new System.Drawing.Size(138, 16);
			this.lbRememberPassword.TabIndex = 8;
			this.lbRememberPassword.Text = "Remember password";
			// 
			// wP
			// 
			this.wP.AutoStart = true;
			this.wP.CircleSize = 0.1F;
			this.wP.Location = new System.Drawing.Point(30, 360);
			this.wP.Name = "wP";
			this.wP.ShadowDecoration.Parent = this.wP;
			this.wP.Size = new System.Drawing.Size(50, 50);
			this.wP.TabIndex = 10;
			// 
			// DatabaseConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(520, 518);
			this.Controls.Add(this.pnl1);
			this.Controls.Add(this.pnl2);
			this.Controls.Add(this.pnlTitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DatabaseConnection";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DatabaseConnection";
			this.Shown += new System.EventHandler(this.DatabaseConnection_Shown);
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			this.pnl1.ResumeLayout(false);
			this.pnl1.PerformLayout();
			this.pnlAccount.ResumeLayout(false);
			this.pnlAccount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTitle;
        private Bunifu.UI.WinForms.BunifuDropdown cbAuthentication;
        private System.Windows.Forms.Label lbServerName;
        private System.Windows.Forms.Label lbAuthentication;
        private FontAwesome.Sharp.IconButton btnTestConnect;
        private FontAwesome.Sharp.IconButton formIcon;
        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Panel pnlAccount;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbUsername;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbPassword;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Label lbPassword;
		public Bunifu.UI.WinForms.BunifuDropdown cbServer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbRememberPassword;
		private Guna.UI2.WinForms.Guna2WinProgressIndicator wP;
		public FontAwesome.Sharp.IconButton btnConnect;
	}
}