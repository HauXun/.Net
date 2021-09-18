﻿
namespace Main.Pages
{
	partial class BackupRestore
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRestore));
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.lbTitle = new System.Windows.Forms.Label();
			this.pnlSaoLuu = new System.Windows.Forms.Panel();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.btnBrowser = new System.Windows.Forms.Button();
			this.cbSever = new Bunifu.UI.WinForms.BunifuDropdown();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbFunc = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbFunc = new System.Windows.Forms.Label();
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbServer = new System.Windows.Forms.Label();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnCancle = new FontAwesome.Sharp.IconButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.barFunc = new Bunifu.UI.Winforms.BunifuProgressBar();
			this.lbPercent = new System.Windows.Forms.Label();
			this.btnBackup = new FontAwesome.Sharp.IconButton();
			this.btnRestore = new FontAwesome.Sharp.IconButton();
			this.lbStatus = new System.Windows.Forms.Label();
			this.pnlSaoLuuShadow = new System.Windows.Forms.Panel();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnlSaoLuu.SuspendLayout();
			this.pnlControls.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Redo;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(45, 23);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 0;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(85, 20);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(263, 37);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Khôi phục dữ liệu";
			// 
			// pnlSaoLuu
			// 
			this.pnlSaoLuu.BackColor = System.Drawing.Color.White;
			this.pnlSaoLuu.Controls.Add(this.pnlControls);
			this.pnlSaoLuu.Controls.Add(this.btnSave);
			this.pnlSaoLuu.Controls.Add(this.btnCancle);
			this.pnlSaoLuu.Controls.Add(this.panel1);
			this.pnlSaoLuu.Controls.Add(this.label1);
			this.pnlSaoLuu.Controls.Add(this.barFunc);
			this.pnlSaoLuu.Controls.Add(this.lbPercent);
			this.pnlSaoLuu.Controls.Add(this.btnBackup);
			this.pnlSaoLuu.Controls.Add(this.btnRestore);
			this.pnlSaoLuu.Controls.Add(this.lbStatus);
			this.pnlSaoLuu.Location = new System.Drawing.Point(45, 93);
			this.pnlSaoLuu.Name = "pnlSaoLuu";
			this.pnlSaoLuu.Size = new System.Drawing.Size(651, 465);
			this.pnlSaoLuu.TabIndex = 0;
			// 
			// pnlControls
			// 
			this.pnlControls.Controls.Add(this.btnBrowser);
			this.pnlControls.Controls.Add(this.cbSever);
			this.pnlControls.Controls.Add(this.tbPassword);
			this.pnlControls.Controls.Add(this.tbUsername);
			this.pnlControls.Controls.Add(this.tbFunc);
			this.pnlControls.Controls.Add(this.lbFunc);
			this.pnlControls.Controls.Add(this.lbUsername);
			this.pnlControls.Controls.Add(this.lbPassword);
			this.pnlControls.Controls.Add(this.lbServer);
			this.pnlControls.Location = new System.Drawing.Point(6, 53);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(642, 223);
			this.pnlControls.TabIndex = 30;
			// 
			// btnBrowser
			// 
			this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.btnBrowser.Location = new System.Drawing.Point(581, 68);
			this.btnBrowser.Name = "btnBrowser";
			this.btnBrowser.Size = new System.Drawing.Size(28, 24);
			this.btnBrowser.TabIndex = 36;
			this.btnBrowser.Text = "...";
			this.btnBrowser.UseVisualStyleBackColor = true;
			this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
			// 
			// cbSever
			// 
			this.cbSever.BackColor = System.Drawing.Color.White;
			this.cbSever.BorderRadius = 4;
			this.cbSever.Color = System.Drawing.Color.Gray;
			this.cbSever.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbSever.DisabledColor = System.Drawing.Color.Gray;
			this.cbSever.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSever.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
			this.cbSever.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSever.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbSever.FillDropDown = false;
			this.cbSever.FillIndicator = false;
			this.cbSever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbSever.ForeColor = System.Drawing.Color.Black;
			this.cbSever.FormattingEnabled = true;
			this.cbSever.Icon = null;
			this.cbSever.IndicatorColor = System.Drawing.Color.Gray;
			this.cbSever.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbSever.ItemBackColor = System.Drawing.Color.White;
			this.cbSever.ItemBorderColor = System.Drawing.Color.White;
			this.cbSever.ItemForeColor = System.Drawing.Color.DimGray;
			this.cbSever.ItemHeight = 30;
			this.cbSever.ItemHighLightColor = System.Drawing.Color.Gainsboro;
			this.cbSever.Location = new System.Drawing.Point(164, 4);
			this.cbSever.Name = "cbSever";
			this.cbSever.Size = new System.Drawing.Size(392, 36);
			this.cbSever.Sorted = true;
			this.cbSever.TabIndex = 35;
			this.cbSever.Text = null;
			// 
			// tbPassword
			// 
			this.tbPassword.BorderColor = System.Drawing.Color.Gray;
			this.tbPassword.BorderRadius = 5;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.Parent = this.tbPassword;
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.Enabled = false;
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.FocusedState.Parent = this.tbPassword;
			this.tbPassword.Font = new System.Drawing.Font("Arial", 11.25F);
			this.tbPassword.ForeColor = System.Drawing.Color.Black;
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.HoverState.Parent = this.tbPassword;
			this.tbPassword.Location = new System.Drawing.Point(162, 182);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '\0';
			this.tbPassword.PlaceholderText = "";
			this.tbPassword.SelectedText = "";
			this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
			this.tbPassword.Size = new System.Drawing.Size(393, 36);
			this.tbPassword.TabIndex = 34;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbUsername
			// 
			this.tbUsername.BorderColor = System.Drawing.Color.Gray;
			this.tbUsername.BorderRadius = 5;
			this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.DefaultText = "";
			this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.DisabledState.Parent = this.tbUsername;
			this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.FocusedState.Parent = this.tbUsername;
			this.tbUsername.Font = new System.Drawing.Font("Arial", 11.25F);
			this.tbUsername.ForeColor = System.Drawing.Color.Black;
			this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.HoverState.Parent = this.tbUsername;
			this.tbUsername.Location = new System.Drawing.Point(163, 122);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.PasswordChar = '\0';
			this.tbUsername.PlaceholderText = "(nếu có)";
			this.tbUsername.SelectedText = "";
			this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
			this.tbUsername.Size = new System.Drawing.Size(393, 36);
			this.tbUsername.TabIndex = 33;
			this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
			// 
			// tbFunc
			// 
			this.tbFunc.BorderColor = System.Drawing.Color.Gray;
			this.tbFunc.BorderRadius = 5;
			this.tbFunc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFunc.DefaultText = "";
			this.tbFunc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFunc.DisabledState.Parent = this.tbFunc;
			this.tbFunc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFunc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFunc.FocusedState.Parent = this.tbFunc;
			this.tbFunc.Font = new System.Drawing.Font("Arial", 11.25F);
			this.tbFunc.ForeColor = System.Drawing.Color.Black;
			this.tbFunc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFunc.HoverState.Parent = this.tbFunc;
			this.tbFunc.Location = new System.Drawing.Point(164, 62);
			this.tbFunc.Name = "tbFunc";
			this.tbFunc.PasswordChar = '\0';
			this.tbFunc.PlaceholderText = "";
			this.tbFunc.SelectedText = "";
			this.tbFunc.ShadowDecoration.Parent = this.tbFunc;
			this.tbFunc.Size = new System.Drawing.Size(391, 36);
			this.tbFunc.TabIndex = 32;
			// 
			// lbFunc
			// 
			this.lbFunc.AutoSize = true;
			this.lbFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFunc.ForeColor = System.Drawing.Color.Black;
			this.lbFunc.Location = new System.Drawing.Point(53, 68);
			this.lbFunc.Name = "lbFunc";
			this.lbFunc.Size = new System.Drawing.Size(93, 24);
			this.lbFunc.TabIndex = 31;
			this.lbFunc.Text = "Database:";
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.ForeColor = System.Drawing.Color.Black;
			this.lbUsername.Location = new System.Drawing.Point(53, 128);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(102, 24);
			this.lbUsername.TabIndex = 30;
			this.lbUsername.Text = "Username:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPassword.ForeColor = System.Drawing.Color.Black;
			this.lbPassword.Location = new System.Drawing.Point(53, 188);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(97, 24);
			this.lbPassword.TabIndex = 29;
			this.lbPassword.Text = "Password:";
			// 
			// lbServer
			// 
			this.lbServer.AutoSize = true;
			this.lbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbServer.ForeColor = System.Drawing.Color.Black;
			this.lbServer.Location = new System.Drawing.Point(53, 8);
			this.lbServer.Name = "lbServer";
			this.lbServer.Size = new System.Drawing.Size(70, 24);
			this.lbServer.TabIndex = 28;
			this.lbServer.Text = "Server:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Green;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
			this.btnSave.IconColor = System.Drawing.Color.White;
			this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSave.IconSize = 28;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Location = new System.Drawing.Point(464, 333);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 29;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.BackColor = System.Drawing.Color.DarkGray;
			this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancle.FlatAppearance.BorderSize = 0;
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnCancle.ForeColor = System.Drawing.Color.White;
			this.btnCancle.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
			this.btnCancle.IconColor = System.Drawing.Color.White;
			this.btnCancle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancle.IconSize = 28;
			this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancle.Location = new System.Drawing.Point(348, 333);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCancle.Size = new System.Drawing.Size(110, 40);
			this.btnCancle.TabIndex = 28;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancle.UseVisualStyleBackColor = false;
			this.btnCancle.Visible = false;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(651, 5);
			this.panel1.TabIndex = 25;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(200, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 1);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(651, 44);
			this.label1.TabIndex = 24;
			this.label1.Text = "Backup && Restore";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// barFunc
			// 
			this.barFunc.Animation = 100;
			this.barFunc.AnimationStep = 5;
			this.barFunc.BackColor = System.Drawing.Color.Transparent;
			this.barFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barFunc.BackgroundImage")));
			this.barFunc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barFunc.BorderRadius = 10;
			this.barFunc.BorderThickness = 5;
			this.barFunc.Location = new System.Drawing.Point(72, 304);
			this.barFunc.MaximumValue = 100;
			this.barFunc.MinimumValue = 0;
			this.barFunc.Name = "barFunc";
			this.barFunc.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
			this.barFunc.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.barFunc.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.barFunc.Size = new System.Drawing.Size(502, 23);
			this.barFunc.TabIndex = 22;
			this.barFunc.Value = 100;
			this.barFunc.Visible = false;
			// 
			// lbPercent
			// 
			this.lbPercent.AutoSize = true;
			this.lbPercent.Font = new System.Drawing.Font("Arial", 14F);
			this.lbPercent.ForeColor = System.Drawing.Color.DimGray;
			this.lbPercent.Location = new System.Drawing.Point(298, 279);
			this.lbPercent.Name = "lbPercent";
			this.lbPercent.Size = new System.Drawing.Size(38, 22);
			this.lbPercent.TabIndex = 23;
			this.lbPercent.Text = "0%";
			this.lbPercent.Visible = false;
			// 
			// btnBackup
			// 
			this.btnBackup.BackColor = System.Drawing.Color.Firebrick;
			this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBackup.FlatAppearance.BorderSize = 0;
			this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F);
			this.btnBackup.ForeColor = System.Drawing.Color.White;
			this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.Save;
			this.btnBackup.IconColor = System.Drawing.Color.White;
			this.btnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnBackup.IconSize = 28;
			this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBackup.Location = new System.Drawing.Point(200, 333);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnBackup.Size = new System.Drawing.Size(114, 40);
			this.btnBackup.TabIndex = 4;
			this.btnBackup.Text = "Sao lưu";
			this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBackup.UseVisualStyleBackColor = false;
			this.btnBackup.Click += new System.EventHandler(this.btnSaoLuu_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRestore.FlatAppearance.BorderSize = 0;
			this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F);
			this.btnRestore.ForeColor = System.Drawing.Color.White;
			this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.Recycle;
			this.btnRestore.IconColor = System.Drawing.Color.White;
			this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnRestore.IconSize = 25;
			this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnRestore.Location = new System.Drawing.Point(76, 333);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnRestore.Size = new System.Drawing.Size(114, 40);
			this.btnRestore.TabIndex = 5;
			this.btnRestore.TabStop = false;
			this.btnRestore.Text = "Khôi phục";
			this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRestore.UseVisualStyleBackColor = false;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// lbStatus
			// 
			this.lbStatus.BackColor = System.Drawing.Color.Transparent;
			this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStatus.ForeColor = System.Drawing.Color.Black;
			this.lbStatus.Location = new System.Drawing.Point(72, 393);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(506, 49);
			this.lbStatus.TabIndex = 4;
			this.lbStatus.Text = "Status:";
			// 
			// pnlSaoLuuShadow
			// 
			this.pnlSaoLuuShadow.BackColor = System.Drawing.Color.Silver;
			this.pnlSaoLuuShadow.Location = new System.Drawing.Point(48, 96);
			this.pnlSaoLuuShadow.Name = "pnlSaoLuuShadow";
			this.pnlSaoLuuShadow.Size = new System.Drawing.Size(651, 465);
			this.pnlSaoLuuShadow.TabIndex = 33;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// BackupRestore
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlSaoLuu);
			this.Controls.Add(this.pnlSaoLuuShadow);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Name = "BackupRestore";
			this.Size = new System.Drawing.Size(1670, 882);
			this.Load += new System.EventHandler(this.BackupRestore_Load);
			this.pnlSaoLuu.ResumeLayout(false);
			this.pnlSaoLuu.PerformLayout();
			this.pnlControls.ResumeLayout(false);
			this.pnlControls.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel pnlSaoLuu;
		private System.Windows.Forms.Label lbStatus;
		private System.Windows.Forms.Panel pnlSaoLuuShadow;
		private FontAwesome.Sharp.IconButton btnBackup;
		public FontAwesome.Sharp.IconButton btnRestore;
		private Bunifu.UI.Winforms.BunifuProgressBar barFunc;
		private System.Windows.Forms.Label lbPercent;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public FontAwesome.Sharp.IconButton btnCancle;
		public FontAwesome.Sharp.IconButton btnSave;
		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Button btnBrowser;
		private Bunifu.UI.WinForms.BunifuDropdown cbSever;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbUsername;
		private Guna.UI2.WinForms.Guna2TextBox tbFunc;
		private System.Windows.Forms.Label lbFunc;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbServer;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
	}
}