
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
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.btnExit = new FontAwesome.Sharp.IconButton();
			this.lbFormTitle = new System.Windows.Forms.Label();
			this.formIcon = new FontAwesome.Sharp.IconButton();
			this.lbTitle = new System.Windows.Forms.Label();
			this.cbServer = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbAuthentication = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbServerName = new System.Windows.Forms.Label();
			this.lbAuthentication = new System.Windows.Forms.Label();
			this.pnlLine = new System.Windows.Forms.Panel();
			this.pnl1 = new System.Windows.Forms.Panel();
			this.wP = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlAccount = new System.Windows.Forms.Panel();
			this.tbUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.tbPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.btnTestConnect = new FontAwesome.Sharp.IconButton();
			this.btnConnect = new FontAwesome.Sharp.IconButton();
			this.pnl2 = new System.Windows.Forms.Panel();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.guna2ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.pnlTitleBar.SuspendLayout();
			this.pnl1.SuspendLayout();
			this.pnlAccount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
			this.pnlTitleBar.Controls.Add(this.btnExit);
			this.pnlTitleBar.Controls.Add(this.lbFormTitle);
			this.pnlTitleBar.Controls.Add(this.formIcon);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(520, 30);
			this.pnlTitleBar.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.btnExit.IconColor = System.Drawing.Color.White;
			this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnExit.IconSize = 20;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.Location = new System.Drawing.Point(492, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.btnExit.Size = new System.Drawing.Size(25, 25);
			this.btnExit.TabIndex = 11;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
			this.btnExit.Enter += new System.EventHandler(this.btnTestConnect_Enter);
			// 
			// lbFormTitle
			// 
			this.lbFormTitle.AutoSize = true;
			this.lbFormTitle.Font = new System.Drawing.Font("Verdana", 9.749999F);
			this.lbFormTitle.ForeColor = System.Drawing.Color.White;
			this.lbFormTitle.Location = new System.Drawing.Point(25, 7);
			this.lbFormTitle.Name = "lbFormTitle";
			this.lbFormTitle.Size = new System.Drawing.Size(130, 16);
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
			this.formIcon.Enter += new System.EventHandler(this.btnTestConnect_Enter);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Verdana", 26.25F);
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(120, 15);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(218, 42);
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
			this.lbServerName.BackColor = System.Drawing.Color.Transparent;
			this.lbServerName.Font = new System.Drawing.Font("Verdana", 10F);
			this.lbServerName.Location = new System.Drawing.Point(30, 97);
			this.lbServerName.Name = "lbServerName";
			this.lbServerName.Size = new System.Drawing.Size(103, 17);
			this.lbServerName.TabIndex = 0;
			this.lbServerName.Text = "Server name:";
			// 
			// lbAuthentication
			// 
			this.lbAuthentication.AutoSize = true;
			this.lbAuthentication.BackColor = System.Drawing.Color.Transparent;
			this.lbAuthentication.Font = new System.Drawing.Font("Verdana", 10F);
			this.lbAuthentication.Location = new System.Drawing.Point(30, 154);
			this.lbAuthentication.Name = "lbAuthentication";
			this.lbAuthentication.Size = new System.Drawing.Size(116, 17);
			this.lbAuthentication.TabIndex = 0;
			this.lbAuthentication.Text = "Authentication:";
			// 
			// pnlLine
			// 
			this.pnlLine.BackColor = System.Drawing.Color.Gray;
			this.pnlLine.Location = new System.Drawing.Point(30, 309);
			this.pnlLine.Name = "pnlLine";
			this.pnlLine.Size = new System.Drawing.Size(400, 1);
			this.pnlLine.TabIndex = 7;
			// 
			// pnl1
			// 
			this.pnl1.BackColor = System.Drawing.Color.White;
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
			this.pnl1.Location = new System.Drawing.Point(30, 64);
			this.pnl1.Name = "pnl1";
			this.pnl1.Size = new System.Drawing.Size(460, 380);
			this.pnl1.TabIndex = 8;
			this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl1_Paint);
			// 
			// wP
			// 
			this.wP.AutoStart = true;
			this.wP.BackColor = System.Drawing.Color.Transparent;
			this.wP.CircleSize = 0.1F;
			this.wP.Location = new System.Drawing.Point(30, 323);
			this.wP.Name = "wP";
			this.wP.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.wP.ShadowDecoration.Parent = this.wP;
			this.wP.Size = new System.Drawing.Size(50, 50);
			this.wP.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Location = new System.Drawing.Point(30, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 1);
			this.panel1.TabIndex = 9;
			// 
			// pnlAccount
			// 
			this.pnlAccount.BackColor = System.Drawing.Color.Transparent;
			this.pnlAccount.Controls.Add(this.tbUsername);
			this.pnlAccount.Controls.Add(this.tbPassword);
			this.pnlAccount.Controls.Add(this.lbUsername);
			this.pnlAccount.Controls.Add(this.lbPassword);
			this.pnlAccount.Location = new System.Drawing.Point(5, 185);
			this.pnlAccount.Name = "pnlAccount";
			this.pnlAccount.Size = new System.Drawing.Size(450, 118);
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
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbUsername.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbUsername.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.Gray;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbUsername.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Gray;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbUsername.OnIdleState = stateProperties4;
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
			stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbPassword.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.Empty;
			stateProperties6.FillColor = System.Drawing.Color.White;
			stateProperties6.ForeColor = System.Drawing.Color.Empty;
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbPassword.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.Gray;
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbPassword.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Gray;
			stateProperties8.FillColor = System.Drawing.Color.White;
			stateProperties8.ForeColor = System.Drawing.Color.Empty;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.tbPassword.OnIdleState = stateProperties8;
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
			this.lbUsername.BackColor = System.Drawing.Color.Transparent;
			this.lbUsername.Font = new System.Drawing.Font("Verdana", 10F);
			this.lbUsername.Location = new System.Drawing.Point(25, 22);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(84, 17);
			this.lbUsername.TabIndex = 4;
			this.lbUsername.Text = "Username:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbPassword.Font = new System.Drawing.Font("Verdana", 10F);
			this.lbPassword.Location = new System.Drawing.Point(25, 80);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(81, 17);
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
			this.btnTestConnect.Location = new System.Drawing.Point(310, 330);
			this.btnTestConnect.Name = "btnTestConnect";
			this.btnTestConnect.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
			this.btnTestConnect.Size = new System.Drawing.Size(120, 35);
			this.btnTestConnect.TabIndex = 6;
			this.btnTestConnect.Text = "Test connect";
			this.btnTestConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTestConnect.UseVisualStyleBackColor = true;
			this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
			this.btnTestConnect.Enter += new System.EventHandler(this.btnTestConnect_Enter);
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
			this.btnConnect.Location = new System.Drawing.Point(153, 330);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.btnConnect.Size = new System.Drawing.Size(110, 35);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Connect";
			this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			this.btnConnect.Enter += new System.EventHandler(this.btnTestConnect_Enter);
			// 
			// pnl2
			// 
			this.pnl2.BackColor = System.Drawing.Color.Gray;
			this.pnl2.Location = new System.Drawing.Point(33, 67);
			this.pnl2.Name = "pnl2";
			this.pnl2.Size = new System.Drawing.Size(460, 380);
			this.pnl2.TabIndex = 10;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// guna2ShadowForm
			// 
			this.guna2ShadowForm.TargetForm = this;
			// 
			// DatabaseConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::Main.Properties.Resources.TestConnectionBackgound;
			this.ClientSize = new System.Drawing.Size(520, 475);
			this.Controls.Add(this.pnl1);
			this.Controls.Add(this.pnl2);
			this.Controls.Add(this.pnlTitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DatabaseConnection";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database Connection";
			this.TopMost = true;
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
		private Guna.UI2.WinForms.Guna2WinProgressIndicator wP;
		public FontAwesome.Sharp.IconButton btnConnect;
		private FontAwesome.Sharp.IconButton btnExit;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm;
	}
}