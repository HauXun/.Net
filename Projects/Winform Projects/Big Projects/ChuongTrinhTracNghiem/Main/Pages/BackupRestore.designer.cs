
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
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.lbTitle = new System.Windows.Forms.Label();
			this.pnlSaoLuu = new System.Windows.Forms.Panel();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbSever = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbDatabase = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnSaoLuu = new FontAwesome.Sharp.IconButton();
			this.btnPassword = new FontAwesome.Sharp.IconButton();
			this.btnBrowser = new System.Windows.Forms.Button();
			this.lbProgress = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lbStatus = new System.Windows.Forms.Label();
			this.lbDatabase = new System.Windows.Forms.Label();
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbServer = new System.Windows.Forms.Label();
			this.pnlSaoLuuShadow = new System.Windows.Forms.Panel();
			this.pnlSaoLuu.SuspendLayout();
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
			this.pnlSaoLuu.Controls.Add(this.tbPassword);
			this.pnlSaoLuu.Controls.Add(this.tbUsername);
			this.pnlSaoLuu.Controls.Add(this.tbSever);
			this.pnlSaoLuu.Controls.Add(this.tbDatabase);
			this.pnlSaoLuu.Controls.Add(this.btnSaoLuu);
			this.pnlSaoLuu.Controls.Add(this.btnPassword);
			this.pnlSaoLuu.Controls.Add(this.btnBrowser);
			this.pnlSaoLuu.Controls.Add(this.lbProgress);
			this.pnlSaoLuu.Controls.Add(this.progressBar1);
			this.pnlSaoLuu.Controls.Add(this.lbStatus);
			this.pnlSaoLuu.Controls.Add(this.lbDatabase);
			this.pnlSaoLuu.Controls.Add(this.lbUsername);
			this.pnlSaoLuu.Controls.Add(this.lbPassword);
			this.pnlSaoLuu.Controls.Add(this.lbServer);
			this.pnlSaoLuu.Location = new System.Drawing.Point(45, 93);
			this.pnlSaoLuu.Name = "pnlSaoLuu";
			this.pnlSaoLuu.Size = new System.Drawing.Size(600, 473);
			this.pnlSaoLuu.TabIndex = 0;
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
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.FocusedState.Parent = this.tbPassword;
			this.tbPassword.Font = new System.Drawing.Font("Arial", 11.25F);
			this.tbPassword.ForeColor = System.Drawing.Color.Black;
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.HoverState.Parent = this.tbPassword;
			this.tbPassword.Location = new System.Drawing.Point(138, 202);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '\0';
			this.tbPassword.PlaceholderText = "";
			this.tbPassword.SelectedText = "";
			this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
			this.tbPassword.Size = new System.Drawing.Size(393, 39);
			this.tbPassword.TabIndex = 20;
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
			this.tbUsername.Location = new System.Drawing.Point(139, 144);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.PasswordChar = '\0';
			this.tbUsername.PlaceholderText = "(nếu có)";
			this.tbUsername.SelectedText = "";
			this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
			this.tbUsername.Size = new System.Drawing.Size(393, 39);
			this.tbUsername.TabIndex = 18;
			// 
			// tbSever
			// 
			this.tbSever.BorderColor = System.Drawing.Color.Gray;
			this.tbSever.BorderRadius = 5;
			this.tbSever.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSever.DefaultText = "";
			this.tbSever.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSever.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSever.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSever.DisabledState.Parent = this.tbSever;
			this.tbSever.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSever.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSever.FocusedState.Parent = this.tbSever;
			this.tbSever.Font = new System.Drawing.Font("Arial", 11.25F);
			this.tbSever.ForeColor = System.Drawing.Color.Black;
			this.tbSever.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSever.HoverState.Parent = this.tbSever;
			this.tbSever.Location = new System.Drawing.Point(141, 28);
			this.tbSever.Name = "tbSever";
			this.tbSever.PasswordChar = '\0';
			this.tbSever.PlaceholderText = "";
			this.tbSever.SelectedText = "";
			this.tbSever.ShadowDecoration.Parent = this.tbSever;
			this.tbSever.Size = new System.Drawing.Size(393, 39);
			this.tbSever.TabIndex = 15;
			// 
			// tbDatabase
			// 
			this.tbDatabase.BorderColor = System.Drawing.Color.Gray;
			this.tbDatabase.BorderRadius = 5;
			this.tbDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbDatabase.DefaultText = "";
			this.tbDatabase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDatabase.DisabledState.Parent = this.tbDatabase;
			this.tbDatabase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDatabase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDatabase.FocusedState.Parent = this.tbDatabase;
			this.tbDatabase.Font = new System.Drawing.Font("Arial", 11.25F);
			this.tbDatabase.ForeColor = System.Drawing.Color.Black;
			this.tbDatabase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDatabase.HoverState.Parent = this.tbDatabase;
			this.tbDatabase.Location = new System.Drawing.Point(140, 86);
			this.tbDatabase.Name = "tbDatabase";
			this.tbDatabase.PasswordChar = '\0';
			this.tbDatabase.PlaceholderText = "";
			this.tbDatabase.SelectedText = "";
			this.tbDatabase.ShadowDecoration.Parent = this.tbDatabase;
			this.tbDatabase.Size = new System.Drawing.Size(393, 39);
			this.tbDatabase.TabIndex = 13;
			// 
			// btnSaoLuu
			// 
			this.btnSaoLuu.BackColor = System.Drawing.Color.Firebrick;
			this.btnSaoLuu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaoLuu.FlatAppearance.BorderSize = 0;
			this.btnSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaoLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F);
			this.btnSaoLuu.ForeColor = System.Drawing.Color.White;
			this.btnSaoLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
			this.btnSaoLuu.IconColor = System.Drawing.Color.White;
			this.btnSaoLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSaoLuu.IconSize = 28;
			this.btnSaoLuu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSaoLuu.Location = new System.Drawing.Point(298, 359);
			this.btnSaoLuu.Name = "btnSaoLuu";
			this.btnSaoLuu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnSaoLuu.Size = new System.Drawing.Size(114, 40);
			this.btnSaoLuu.TabIndex = 4;
			this.btnSaoLuu.Text = "Sao lưu";
			this.btnSaoLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSaoLuu.UseVisualStyleBackColor = false;
			// 
			// btnPassword
			// 
			this.btnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPassword.FlatAppearance.BorderSize = 0;
			this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F);
			this.btnPassword.ForeColor = System.Drawing.Color.White;
			this.btnPassword.IconChar = FontAwesome.Sharp.IconChar.Recycle;
			this.btnPassword.IconColor = System.Drawing.Color.White;
			this.btnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPassword.IconSize = 25;
			this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPassword.Location = new System.Drawing.Point(418, 359);
			this.btnPassword.Name = "btnPassword";
			this.btnPassword.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnPassword.Size = new System.Drawing.Size(114, 40);
			this.btnPassword.TabIndex = 5;
			this.btnPassword.TabStop = false;
			this.btnPassword.Text = "Khôi phục";
			this.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPassword.UseVisualStyleBackColor = false;
			// 
			// btnBrowser
			// 
			this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowser.Location = new System.Drawing.Point(542, 91);
			this.btnBrowser.Name = "btnBrowser";
			this.btnBrowser.Size = new System.Drawing.Size(28, 24);
			this.btnBrowser.TabIndex = 6;
			this.btnBrowser.Text = "...";
			this.btnBrowser.UseVisualStyleBackColor = true;
			this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
			// 
			// lbProgress
			// 
			this.lbProgress.AutoSize = true;
			this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbProgress.Location = new System.Drawing.Point(264, 318);
			this.lbProgress.Name = "lbProgress";
			this.lbProgress.Size = new System.Drawing.Size(27, 16);
			this.lbProgress.TabIndex = 11;
			this.lbProgress.Text = "0%";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(39, 269);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(493, 35);
			this.progressBar1.TabIndex = 5;
			// 
			// lbStatus
			// 
			this.lbStatus.AutoSize = true;
			this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStatus.ForeColor = System.Drawing.Color.Black;
			this.lbStatus.Location = new System.Drawing.Point(35, 402);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(65, 24);
			this.lbStatus.TabIndex = 4;
			this.lbStatus.Text = "Status:";
			// 
			// lbDatabase
			// 
			this.lbDatabase.AutoSize = true;
			this.lbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDatabase.ForeColor = System.Drawing.Color.Black;
			this.lbDatabase.Location = new System.Drawing.Point(42, 91);
			this.lbDatabase.Name = "lbDatabase";
			this.lbDatabase.Size = new System.Drawing.Size(93, 24);
			this.lbDatabase.TabIndex = 3;
			this.lbDatabase.Text = "Database:";
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.ForeColor = System.Drawing.Color.Black;
			this.lbUsername.Location = new System.Drawing.Point(35, 149);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(102, 24);
			this.lbUsername.TabIndex = 2;
			this.lbUsername.Text = "Username:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPassword.ForeColor = System.Drawing.Color.Black;
			this.lbPassword.Location = new System.Drawing.Point(35, 207);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(97, 24);
			this.lbPassword.TabIndex = 1;
			this.lbPassword.Text = "Password:";
			// 
			// lbServer
			// 
			this.lbServer.AutoSize = true;
			this.lbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbServer.ForeColor = System.Drawing.Color.Black;
			this.lbServer.Location = new System.Drawing.Point(64, 33);
			this.lbServer.Name = "lbServer";
			this.lbServer.Size = new System.Drawing.Size(70, 24);
			this.lbServer.TabIndex = 0;
			this.lbServer.Text = "Server:";
			// 
			// pnlSaoLuuShadow
			// 
			this.pnlSaoLuuShadow.BackColor = System.Drawing.Color.Silver;
			this.pnlSaoLuuShadow.Location = new System.Drawing.Point(48, 96);
			this.pnlSaoLuuShadow.Name = "pnlSaoLuuShadow";
			this.pnlSaoLuuShadow.Size = new System.Drawing.Size(600, 473);
			this.pnlSaoLuuShadow.TabIndex = 33;
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
			this.pnlSaoLuu.ResumeLayout(false);
			this.pnlSaoLuu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel pnlSaoLuu;
		private System.Windows.Forms.Label lbProgress;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lbStatus;
		private System.Windows.Forms.Label lbDatabase;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbServer;
		private System.Windows.Forms.Button btnBrowser;
		private System.Windows.Forms.Panel pnlSaoLuuShadow;
		private FontAwesome.Sharp.IconButton btnSaoLuu;
		public FontAwesome.Sharp.IconButton btnPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbSever;
		private Guna.UI2.WinForms.Guna2TextBox tbDatabase;
		private Guna.UI2.WinForms.Guna2TextBox tbUsername;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
	}
}