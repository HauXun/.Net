
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.barFunc = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.lbPercent = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnCancle = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackup = new FontAwesome.Sharp.IconButton();
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnDisconnect = new FontAwesome.Sharp.IconButton();
            this.btnConnect = new FontAwesome.Sharp.IconButton();
            this.btnBrowser = new FontAwesome.Sharp.IconButton();
            this.iconTitle = new FontAwesome.Sharp.IconButton();
            this.pnlSaoLuu = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gpDB = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbFunc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFunc = new System.Windows.Forms.Label();
            this.gpServer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbServer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
            this.pnlSaoLuu.SuspendLayout();
            this.gpDB.SuspendLayout();
            this.gpServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.lbTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.lbTitle.Location = new System.Drawing.Point(1076, 77);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(269, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Khôi phục dữ liệu";
            this.lbTitle.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // barFunc
            // 
            this.barFunc.Animation = 0;
            this.barFunc.AnimationStep = 5;
            this.barFunc.BackColor = System.Drawing.Color.Transparent;
            this.barFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barFunc.BackgroundImage")));
            this.barFunc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.barFunc.BorderRadius = 10;
            this.barFunc.BorderThickness = 5;
            this.barFunc.Location = new System.Drawing.Point(168, 377);
            this.barFunc.MaximumValue = 100;
            this.barFunc.MinimumValue = 0;
            this.barFunc.Name = "barFunc";
            this.barFunc.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.barFunc.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barFunc.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barFunc.Size = new System.Drawing.Size(318, 23);
            this.barFunc.TabIndex = 49;
            this.barFunc.Value = 100;
            this.barFunc.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.ForeColor = System.Drawing.Color.DimGray;
            this.lbPercent.Location = new System.Drawing.Point(300, 352);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(63, 23);
            this.lbPercent.TabIndex = 50;
            this.lbPercent.Text = "-10%";
            this.lbPercent.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 28;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Location = new System.Drawing.Point(466, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancle.FlatAppearance.BorderSize = 0;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancle.IconColor = System.Drawing.Color.White;
            this.btnCancle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancle.IconSize = 28;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancle.Location = new System.Drawing.Point(350, 414);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancle.Size = new System.Drawing.Size(110, 40);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.TabStop = false;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Visible = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            this.btnCancle.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(50, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 5);
            this.panel1.TabIndex = 25;
            this.panel1.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(155, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(50, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "Backup && Restore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Firebrick;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnBackup.IconColor = System.Drawing.Color.White;
            this.btnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackup.IconSize = 28;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackup.Location = new System.Drawing.Point(202, 414);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBackup.Size = new System.Drawing.Size(114, 40);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.TabStop = false;
            this.btnBackup.Text = "Sao lưu";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnSaoLuu_Click);
            this.btnBackup.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.btnRestore.IconColor = System.Drawing.Color.White;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestore.IconSize = 25;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestore.Location = new System.Drawing.Point(78, 414);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRestore.Size = new System.Drawing.Size(114, 40);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.TabStop = false;
            this.btnRestore.Text = "Khôi phục";
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.btnRestore.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(74, 473);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(506, 49);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Status:";
            this.lbStatus.Click += new System.EventHandler(this.pbBackground_Click);
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
            // btnDisconnect
            // 
            this.btnDisconnect.IconChar = FontAwesome.Sharp.IconChar.Unsplash;
            this.btnDisconnect.IconColor = System.Drawing.Color.Black;
            this.btnDisconnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisconnect.IconSize = 23;
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisconnect.Location = new System.Drawing.Point(534, 86);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(36, 36);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.TabStop = false;
            this.toolTip.SetToolTip(this.btnDisconnect, "Disconnect");
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            this.btnDisconnect.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // btnConnect
            // 
            this.btnConnect.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btnConnect.IconColor = System.Drawing.Color.Black;
            this.btnConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConnect.IconSize = 23;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConnect.Location = new System.Drawing.Point(576, 86);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(36, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.TabStop = false;
            this.toolTip.SetToolTip(this.btnConnect, "Connect");
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // btnBrowser
            // 
            this.btnBrowser.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnBrowser.IconColor = System.Drawing.Color.Black;
            this.btnBrowser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowser.IconSize = 23;
            this.btnBrowser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrowser.Location = new System.Drawing.Point(534, 84);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(36, 36);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.TabStop = false;
            this.toolTip.SetToolTip(this.btnBrowser, "Browser");
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            this.btnBrowser.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.iconTitle.FlatAppearance.BorderSize = 0;
            this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 35;
            this.iconTitle.Location = new System.Drawing.Point(1035, 79);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(35, 37);
            this.iconTitle.TabIndex = 0;
            this.iconTitle.TabStop = false;
            this.iconTitle.UseVisualStyleBackColor = false;
            this.iconTitle.Click += new System.EventHandler(this.pbBackground_Click);
            this.iconTitle.Enter += new System.EventHandler(this.btnRestore_Enter);
            // 
            // pnlSaoLuu
            // 
            this.pnlSaoLuu.BackColor = System.Drawing.Color.Transparent;
            this.pnlSaoLuu.Controls.Add(this.panel1);
            this.pnlSaoLuu.Controls.Add(this.barFunc);
            this.pnlSaoLuu.Controls.Add(this.label1);
            this.pnlSaoLuu.Controls.Add(this.btnSave);
            this.pnlSaoLuu.Controls.Add(this.lbPercent);
            this.pnlSaoLuu.Controls.Add(this.lbStatus);
            this.pnlSaoLuu.Controls.Add(this.gpDB);
            this.pnlSaoLuu.Controls.Add(this.btnRestore);
            this.pnlSaoLuu.Controls.Add(this.gpServer);
            this.pnlSaoLuu.Controls.Add(this.btnBackup);
            this.pnlSaoLuu.Controls.Add(this.btnCancle);
            this.pnlSaoLuu.FillColor = System.Drawing.Color.White;
            this.pnlSaoLuu.Location = new System.Drawing.Point(840, 136);
            this.pnlSaoLuu.Name = "pnlSaoLuu";
            this.pnlSaoLuu.Radius = 5;
            this.pnlSaoLuu.ShadowColor = System.Drawing.Color.Black;
            this.pnlSaoLuu.ShadowDepth = 255;
            this.pnlSaoLuu.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlSaoLuu.Size = new System.Drawing.Size(660, 550);
            this.pnlSaoLuu.TabIndex = 34;
            this.pnlSaoLuu.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // gpDB
            // 
            this.gpDB.BorderRadius = 5;
            this.gpDB.Controls.Add(this.btnBrowser);
            this.gpDB.Controls.Add(this.tbFunc);
            this.gpDB.Controls.Add(this.lbFunc);
            this.gpDB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpDB.Location = new System.Drawing.Point(6, 211);
            this.gpDB.Name = "gpDB";
            this.gpDB.ShadowDecoration.Parent = this.gpDB;
            this.gpDB.Size = new System.Drawing.Size(643, 138);
            this.gpDB.TabIndex = 1;
            this.gpDB.Text = "Database Section:";
            this.gpDB.Click += new System.EventHandler(this.pbBackground_Click);
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
            this.tbFunc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFunc.ForeColor = System.Drawing.Color.Black;
            this.tbFunc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFunc.HoverState.Parent = this.tbFunc;
            this.tbFunc.Location = new System.Drawing.Point(126, 84);
            this.tbFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFunc.Name = "tbFunc";
            this.tbFunc.PasswordChar = '\0';
            this.tbFunc.PlaceholderText = "";
            this.tbFunc.SelectedText = "";
            this.tbFunc.ShadowDecoration.Parent = this.tbFunc;
            this.tbFunc.Size = new System.Drawing.Size(391, 36);
            this.tbFunc.TabIndex = 0;
            this.tbFunc.TabStop = false;
            this.tbFunc.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // lbFunc
            // 
            this.lbFunc.AutoSize = true;
            this.lbFunc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunc.ForeColor = System.Drawing.Color.Black;
            this.lbFunc.Location = new System.Drawing.Point(131, 57);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(136, 23);
            this.lbFunc.TabIndex = 40;
            this.lbFunc.Text = "Backup Path:";
            this.lbFunc.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // gpServer
            // 
            this.gpServer.BorderRadius = 5;
            this.gpServer.Controls.Add(this.tbServer);
            this.gpServer.Controls.Add(this.btnConnect);
            this.gpServer.Controls.Add(this.btnDisconnect);
            this.gpServer.Controls.Add(this.lbServer);
            this.gpServer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpServer.Location = new System.Drawing.Point(6, 67);
            this.gpServer.Name = "gpServer";
            this.gpServer.ShadowDecoration.Parent = this.gpServer;
            this.gpServer.Size = new System.Drawing.Size(643, 138);
            this.gpServer.TabIndex = 0;
            this.gpServer.Text = "SQL Server Authentication";
            this.gpServer.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // tbServer
            // 
            this.tbServer.BorderColor = System.Drawing.Color.Gray;
            this.tbServer.BorderRadius = 5;
            this.tbServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbServer.DefaultText = "";
            this.tbServer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbServer.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbServer.DisabledState.Parent = this.tbServer;
            this.tbServer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbServer.Enabled = false;
            this.tbServer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbServer.FocusedState.Parent = this.tbServer;
            this.tbServer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServer.ForeColor = System.Drawing.Color.Black;
            this.tbServer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbServer.HoverState.Parent = this.tbServer;
            this.tbServer.Location = new System.Drawing.Point(126, 86);
            this.tbServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbServer.Name = "tbServer";
            this.tbServer.PasswordChar = '\0';
            this.tbServer.PlaceholderText = "";
            this.tbServer.ReadOnly = true;
            this.tbServer.SelectedText = "";
            this.tbServer.ShadowDecoration.Parent = this.tbServer;
            this.tbServer.Size = new System.Drawing.Size(391, 36);
            this.tbServer.TabIndex = 0;
            this.tbServer.TabStop = false;
            this.tbServer.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.ForeColor = System.Drawing.Color.Black;
            this.lbServer.Location = new System.Drawing.Point(131, 59);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(81, 23);
            this.lbServer.TabIndex = 37;
            this.lbServer.Text = "Server:";
            this.lbServer.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.pbBackground.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::Main.Properties.Resources.Background;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1550, 822);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 35;
            this.pbBackground.TabStop = false;
            this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // BackupRestore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.pnlSaoLuu);
            this.Controls.Add(this.iconTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbBackground);
            this.Location = new System.Drawing.Point(1076, 21);
            this.Name = "BackupRestore";
            this.Size = new System.Drawing.Size(1550, 822);
            this.Load += new System.EventHandler(this.BackupRestore_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
            this.pnlSaoLuu.ResumeLayout(false);
            this.pnlSaoLuu.PerformLayout();
            this.gpDB.ResumeLayout(false);
            this.gpDB.PerformLayout();
            this.gpServer.ResumeLayout(false);
            this.gpServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Label lbStatus;
		private FontAwesome.Sharp.IconButton btnBackup;
		public FontAwesome.Sharp.IconButton btnRestore;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public FontAwesome.Sharp.IconButton btnCancle;
		public FontAwesome.Sharp.IconButton btnSave;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.ToolTip toolTip;
		private Bunifu.UI.Winforms.BunifuProgressBar barFunc;
		private System.Windows.Forms.Label lbPercent;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlSaoLuu;
		private Guna.UI2.WinForms.Guna2GroupBox gpDB;
		private FontAwesome.Sharp.IconButton btnBrowser;
		private Guna.UI2.WinForms.Guna2TextBox tbFunc;
		private System.Windows.Forms.Label lbFunc;
		private Guna.UI2.WinForms.Guna2GroupBox gpServer;
		private Guna.UI2.WinForms.Guna2TextBox tbServer;
		private FontAwesome.Sharp.IconButton btnConnect;
		private FontAwesome.Sharp.IconButton btnDisconnect;
		private System.Windows.Forms.Label lbServer;
		private System.Windows.Forms.PictureBox pbBackground;
	}
}