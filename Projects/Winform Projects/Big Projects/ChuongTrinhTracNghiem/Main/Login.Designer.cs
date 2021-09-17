﻿
using System.Windows.Forms;

namespace Main
{
	partial class LoginForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnlPassword = new System.Windows.Forms.Panel();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.passwordIcon = new FontAwesome.Sharp.IconButton();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.pnlUsername = new System.Windows.Forms.Panel();
			this.usernameIcon = new FontAwesome.Sharp.IconButton();
			this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.background = new System.Windows.Forms.PictureBox();
			this.wPB = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
			this.pControl = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.pnlPassword.SuspendLayout();
			this.pnlUsername.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
			this.pControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Location = new System.Drawing.Point(343, 259);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(221, 42);
			this.panel1.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.Animated = true;
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
			this.btnLogin.BorderRadius = 5;
			this.btnLogin.BorderThickness = 1;
			this.btnLogin.CheckedState.Parent = this.btnLogin;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.CustomImages.Parent = this.btnLogin;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.DisabledState.Parent = this.btnLogin;
			this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.Parent = this.btnLogin;
			this.btnLogin.Location = new System.Drawing.Point(0, 0);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
			this.btnLogin.Size = new System.Drawing.Size(217, 38);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// pnlPassword
			// 
			this.pnlPassword.Controls.Add(this.tbPassword);
			this.pnlPassword.Controls.Add(this.passwordIcon);
			this.pnlPassword.Location = new System.Drawing.Point(307, 193);
			this.pnlPassword.Name = "pnlPassword";
			this.pnlPassword.Size = new System.Drawing.Size(274, 42);
			this.pnlPassword.TabIndex = 2;
			// 
			// tbPassword
			// 
			this.tbPassword.Animated = true;
			this.tbPassword.BorderRadius = 5;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "P@ssw0rd";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.Parent = this.tbPassword;
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.FocusedState.Parent = this.tbPassword;
			this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.HoverState.Parent = this.tbPassword;
			this.tbPassword.Location = new System.Drawing.Point(49, 3);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '\0';
			this.tbPassword.PlaceholderText = "Coi chừng lộ mật khẩu á ...";
			this.tbPassword.SelectedText = "";
			this.tbPassword.SelectionStart = 8;
			this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
			this.tbPassword.Size = new System.Drawing.Size(222, 36);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// passwordIcon
			// 
			this.passwordIcon.FlatAppearance.BorderSize = 0;
			this.passwordIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.passwordIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.passwordIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
			this.passwordIcon.IconColor = System.Drawing.Color.Gray;
			this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.passwordIcon.IconSize = 20;
			this.passwordIcon.Location = new System.Drawing.Point(10, 5);
			this.passwordIcon.Name = "passwordIcon";
			this.passwordIcon.Size = new System.Drawing.Size(33, 33);
			this.passwordIcon.TabIndex = 1;
			this.passwordIcon.TabStop = false;
			this.passwordIcon.UseVisualStyleBackColor = true;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.lbTitle.ForeColor = System.Drawing.Color.Black;
			this.lbTitle.Location = new System.Drawing.Point(401, 92);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(116, 30);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Đăng nhập";
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.ForeColor = System.Drawing.Color.Black;
			this.btnExit.Location = new System.Drawing.Point(570, 4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(25, 25);
			this.btnExit.TabIndex = 0;
			this.btnExit.TabStop = false;
			this.btnExit.Text = "X";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pnlUsername
			// 
			this.pnlUsername.Controls.Add(this.usernameIcon);
			this.pnlUsername.Location = new System.Drawing.Point(307, 145);
			this.pnlUsername.Name = "pnlUsername";
			this.pnlUsername.Size = new System.Drawing.Size(274, 42);
			this.pnlUsername.TabIndex = 1;
			// 
			// usernameIcon
			// 
			this.usernameIcon.FlatAppearance.BorderSize = 0;
			this.usernameIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.usernameIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.usernameIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.usernameIcon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
			this.usernameIcon.IconColor = System.Drawing.Color.Gray;
			this.usernameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.usernameIcon.IconSize = 20;
			this.usernameIcon.Location = new System.Drawing.Point(10, 5);
			this.usernameIcon.Name = "usernameIcon";
			this.usernameIcon.Size = new System.Drawing.Size(33, 33);
			this.usernameIcon.TabIndex = 0;
			this.usernameIcon.TabStop = false;
			this.usernameIcon.UseVisualStyleBackColor = true;
			// 
			// tbUsername
			// 
			this.tbUsername.Animated = true;
			this.tbUsername.BorderRadius = 5;
			this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.DefaultText = "2011379";
			this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.DisabledState.Parent = this.tbUsername;
			this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.FocusedState.Parent = this.tbUsername;
			this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
			this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.HoverState.Parent = this.tbUsername;
			this.tbUsername.Location = new System.Drawing.Point(356, 148);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.PasswordChar = '\0';
			this.tbUsername.PlaceholderText = "Nhập tài khoản đi ...";
			this.tbUsername.SelectedText = "";
			this.tbUsername.SelectionStart = 7;
			this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
			this.tbUsername.Size = new System.Drawing.Size(222, 36);
			this.tbUsername.TabIndex = 1;
			// 
			// background
			// 
			this.background.Image = global::Main.Properties.Resources.LoginBackground;
			this.background.Location = new System.Drawing.Point(0, 0);
			this.background.Name = "background";
			this.background.Size = new System.Drawing.Size(600, 400);
			this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.background.TabIndex = 0;
			this.background.TabStop = false;
			// 
			// wPB
			// 
			this.wPB.AnimationSpeed = 80;
			this.wPB.AutoStart = true;
			this.wPB.Location = new System.Drawing.Point(255, 155);
			this.wPB.Name = "wPB";
			this.wPB.ShadowDecoration.Parent = this.wPB;
			this.wPB.Size = new System.Drawing.Size(90, 90);
			this.wPB.TabIndex = 4;
			// 
			// pControl
			// 
			this.pControl.Controls.Add(this.tbUsername);
			this.pControl.Controls.Add(this.panel1);
			this.pControl.Controls.Add(this.pnlUsername);
			this.pControl.Controls.Add(this.pnlPassword);
			this.pControl.Controls.Add(this.btnExit);
			this.pControl.Controls.Add(this.lbTitle);
			this.pControl.Controls.Add(this.background);
			this.pControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pControl.Location = new System.Drawing.Point(0, 0);
			this.pControl.Name = "pControl";
			this.pControl.Size = new System.Drawing.Size(600, 400);
			this.pControl.TabIndex = 5;
			// 
			// LoginForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.pControl);
			this.Controls.Add(this.wPB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.pnlPassword.ResumeLayout(false);
			this.pnlUsername.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
			this.pControl.ResumeLayout(false);
			this.pControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Button btnExit;
		private Guna.UI2.WinForms.Guna2TextBox tbUsername;
		private System.Windows.Forms.Panel pnlPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private FontAwesome.Sharp.IconButton passwordIcon;
		private System.Windows.Forms.Panel pnlUsername;
		private FontAwesome.Sharp.IconButton usernameIcon;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.PictureBox background;
		private Guna.UI2.WinForms.Guna2WinProgressIndicator wPB;
		private Panel pControl;
	}
}
