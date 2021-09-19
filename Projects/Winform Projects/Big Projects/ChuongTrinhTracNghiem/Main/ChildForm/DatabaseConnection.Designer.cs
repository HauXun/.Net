
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
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.formIcon = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.checkBoxPassword = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbServerName = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbAuthentication = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lbServerName = new System.Windows.Forms.Label();
            this.lbAuthentication = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbRememberPassword = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnTestConnect = new FontAwesome.Sharp.IconButton();
            this.btnConnect = new FontAwesome.Sharp.IconButton();
            this.tbUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnlTitleBar.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.pnlTitleBar.Controls.Add(this.lbFormTitle);
            this.pnlTitleBar.Controls.Add(this.formIcon);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
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
            this.lbFormTitle.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormTitle.ForeColor = System.Drawing.Color.White;
            this.lbFormTitle.Location = new System.Drawing.Point(25, 7);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(132, 15);
            this.lbFormTitle.TabIndex = 8;
            this.lbFormTitle.Text = "Database Connection";
            // 
            // formIcon
            // 
            this.formIcon.BackColor = System.Drawing.Color.Transparent;
            this.formIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.formIcon.FlatAppearance.BorderSize = 0;
            this.formIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.formIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.formIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formIcon.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formIcon.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.formIcon.IconColor = System.Drawing.Color.White;
            this.formIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.formIcon.IconSize = 20;
            this.formIcon.Location = new System.Drawing.Point(0, 0);
            this.formIcon.Name = "formIcon";
            this.formIcon.Size = new System.Drawing.Size(30, 30);
            this.formIcon.TabIndex = 0;
            this.formIcon.TabStop = false;
            this.formIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.formIcon.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(186)))), ((int)(((byte)(116)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(460, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(186)))), ((int)(((byte)(116)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbTitle.Font = new System.Drawing.Font("Helvetica Neue", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.lbTitle.Location = new System.Drawing.Point(146, 43);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 40);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "SQL Server";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxPassword.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxPassword.Checked = true;
            this.checkBoxPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxPassword.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.checkBoxPassword.Location = new System.Drawing.Point(153, 345);
            this.checkBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(20, 20);
            this.checkBoxPassword.TabIndex = 4;
            // 
            // cbServerName
            // 
            this.cbServerName.BackColor = System.Drawing.Color.White;
            this.cbServerName.BorderRadius = 3;
            this.cbServerName.Color = System.Drawing.Color.Gray;
            this.cbServerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbServerName.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbServerName.DisabledColor = System.Drawing.Color.Gray;
            this.cbServerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbServerName.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerName.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbServerName.FillDropDown = false;
            this.cbServerName.FillIndicator = false;
            this.cbServerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbServerName.Font = new System.Drawing.Font("Helvetica Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServerName.ForeColor = System.Drawing.Color.Black;
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.Icon = null;
            this.cbServerName.IndicatorColor = System.Drawing.Color.Black;
            this.cbServerName.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbServerName.ItemBackColor = System.Drawing.Color.White;
            this.cbServerName.ItemBorderColor = System.Drawing.Color.White;
            this.cbServerName.ItemForeColor = System.Drawing.Color.Black;
            this.cbServerName.ItemHeight = 28;
            this.cbServerName.ItemHighLightColor = System.Drawing.Color.Gainsboro;
            this.cbServerName.Location = new System.Drawing.Point(153, 123);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(277, 34);
            this.cbServerName.Sorted = true;
            this.cbServerName.TabIndex = 0;
            this.cbServerName.Text = null;
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
            this.cbAuthentication.Font = new System.Drawing.Font("Helvetica Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "ádf",
            "ádf",
            "ádfasdf",
            "ádfasdfasdf",
            "ákldjfalsdf",
            "sd",
            "sdf"});
            this.cbAuthentication.Location = new System.Drawing.Point(153, 180);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(277, 34);
            this.cbAuthentication.Sorted = true;
            this.cbAuthentication.TabIndex = 1;
            this.cbAuthentication.Text = null;
            // 
            // lbServerName
            // 
            this.lbServerName.AutoSize = true;
            this.lbServerName.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServerName.Location = new System.Drawing.Point(30, 129);
            this.lbServerName.Name = "lbServerName";
            this.lbServerName.Size = new System.Drawing.Size(103, 18);
            this.lbServerName.TabIndex = 0;
            this.lbServerName.Text = "Server name:";
            // 
            // lbAuthentication
            // 
            this.lbAuthentication.AutoSize = true;
            this.lbAuthentication.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthentication.Location = new System.Drawing.Point(30, 187);
            this.lbAuthentication.Name = "lbAuthentication";
            this.lbAuthentication.Size = new System.Drawing.Size(117, 18);
            this.lbAuthentication.TabIndex = 0;
            this.lbAuthentication.Text = "Authentication:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(30, 303);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(82, 18);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(30, 245);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(87, 18);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username:";
            // 
            // lbRememberPassword
            // 
            this.lbRememberPassword.AutoSize = true;
            this.lbRememberPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRememberPassword.Location = new System.Drawing.Point(175, 348);
            this.lbRememberPassword.Name = "lbRememberPassword";
            this.lbRememberPassword.Size = new System.Drawing.Size(138, 16);
            this.lbRememberPassword.TabIndex = 0;
            this.lbRememberPassword.Text = "Remember password";
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Gray;
            this.pnlLine.Location = new System.Drawing.Point(30, 381);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(400, 1);
            this.pnlLine.TabIndex = 7;
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.pnlLine);
            this.pnl1.Controls.Add(this.cbServerName);
            this.pnl1.Controls.Add(this.btnTestConnect);
            this.pnl1.Controls.Add(this.lbTitle);
            this.pnl1.Controls.Add(this.btnConnect);
            this.pnl1.Controls.Add(this.tbUsername);
            this.pnl1.Controls.Add(this.lbRememberPassword);
            this.pnl1.Controls.Add(this.tbPassword);
            this.pnl1.Controls.Add(this.lbUsername);
            this.pnl1.Controls.Add(this.checkBoxPassword);
            this.pnl1.Controls.Add(this.lbPassword);
            this.pnl1.Controls.Add(this.cbAuthentication);
            this.pnl1.Controls.Add(this.lbAuthentication);
            this.pnl1.Controls.Add(this.lbServerName);
            this.pnl1.Location = new System.Drawing.Point(30, 59);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(460, 480);
            this.pnl1.TabIndex = 8;
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestConnect.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnect.IconChar = FontAwesome.Sharp.IconChar.Unsplash;
            this.btnTestConnect.IconColor = System.Drawing.Color.Black;
            this.btnTestConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTestConnect.IconSize = 20;
            this.btnTestConnect.Location = new System.Drawing.Point(310, 402);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.btnTestConnect.Size = new System.Drawing.Size(120, 35);
            this.btnTestConnect.TabIndex = 6;
            this.btnTestConnect.Text = "Test connect";
            this.btnTestConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestConnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.IconChar = FontAwesome.Sharp.IconChar.Plug;
            this.btnConnect.IconColor = System.Drawing.Color.White;
            this.btnConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConnect.IconSize = 20;
            this.btnConnect.Location = new System.Drawing.Point(153, 402);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
            this.btnConnect.Size = new System.Drawing.Size(110, 35);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnect.UseVisualStyleBackColor = false;
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
            this.tbUsername.DefaultFont = new System.Drawing.Font("Helvetica Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.DefaultText = "";
            this.tbUsername.FillColor = System.Drawing.Color.White;
            this.tbUsername.HideSelection = true;
            this.tbUsername.IconLeft = null;
            this.tbUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.IconPadding = 10;
            this.tbUsername.IconRight = null;
            this.tbUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(153, 237);
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
            this.tbUsername.TabIndex = 2;
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
            this.tbPassword.DefaultFont = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.DefaultText = "";
            this.tbPassword.FillColor = System.Drawing.Color.White;
            this.tbPassword.HideSelection = true;
            this.tbPassword.IconLeft = null;
            this.tbPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.IconPadding = 10;
            this.tbPassword.IconRight = null;
            this.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(153, 295);
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
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TextMarginBottom = 0;
            this.tbPassword.TextMarginLeft = 5;
            this.tbPassword.TextMarginTop = 0;
            this.tbPassword.TextPlaceholder = "";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WordWrap = true;
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::Main.Properties.Resources.DatabaseConnectionBackground;
            this.pbBackground.Location = new System.Drawing.Point(0, 30);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(520, 540);
            this.pbBackground.TabIndex = 9;
            this.pbBackground.TabStop = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Gray;
            this.pnl2.Location = new System.Drawing.Point(33, 62);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(460, 480);
            this.pnl2.TabIndex = 10;
            // 
            // DatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 570);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatabaseConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseConnection";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lbTitle;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbUsername;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbPassword;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxPassword;
        private Bunifu.UI.WinForms.BunifuDropdown cbServerName;
        private Bunifu.UI.WinForms.BunifuDropdown cbAuthentication;
        private System.Windows.Forms.Label lbServerName;
        private System.Windows.Forms.Label lbAuthentication;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbRememberPassword;
        private FontAwesome.Sharp.IconButton btnConnect;
        private FontAwesome.Sharp.IconButton btnTestConnect;
        private FontAwesome.Sharp.IconButton formIcon;
        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Panel pnl2;
    }
}