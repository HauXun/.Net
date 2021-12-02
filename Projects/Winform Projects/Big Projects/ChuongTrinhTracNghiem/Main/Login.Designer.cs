
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnlPassword = new System.Windows.Forms.Panel();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.passwordIcon = new FontAwesome.Sharp.IconButton();
			this.lbTitle = new System.Windows.Forms.Label();
			this.pnlUsername = new System.Windows.Forms.Panel();
			this.usernameIcon = new FontAwesome.Sharp.IconButton();
			this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.background = new System.Windows.Forms.PictureBox();
			this.wPB = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
			this.pControl = new System.Windows.Forms.Panel();
			this.btnExit = new FontAwesome.Sharp.IconButton();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.pnlPassword.SuspendLayout();
			this.pnlUsername.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
			this.pControl.SuspendLayout();
			this.SuspendLayout();
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
			this.pnlPassword.Size = new System.Drawing.Size(290, 42);
			this.pnlPassword.TabIndex = 0;
			// 
			// tbPassword
			// 
			this.tbPassword.Animated = true;
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
			this.tbPassword.Font = new System.Drawing.Font("Verdana", 11.25F);
			this.tbPassword.ForeColor = System.Drawing.Color.Gray;
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.HoverState.Parent = this.tbPassword;
			this.tbPassword.Location = new System.Drawing.Point(49, 3);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '•';
			this.tbPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tbPassword.PlaceholderText = "Mật khẩu";
			this.tbPassword.SelectedText = "";
			this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
			this.tbPassword.Size = new System.Drawing.Size(222, 36);
			this.tbPassword.TabIndex = 1;
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
			this.passwordIcon.TabIndex = 0;
			this.passwordIcon.TabStop = false;
			this.passwordIcon.UseVisualStyleBackColor = true;
			this.passwordIcon.Enter += new System.EventHandler(this.btnLogin_Enter);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.Black;
			this.lbTitle.Location = new System.Drawing.Point(402, 92);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(126, 25);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "Đăng nhập";
			// 
			// pnlUsername
			// 
			this.pnlUsername.Controls.Add(this.usernameIcon);
			this.pnlUsername.Location = new System.Drawing.Point(307, 145);
			this.pnlUsername.Name = "pnlUsername";
			this.pnlUsername.Size = new System.Drawing.Size(290, 42);
			this.pnlUsername.TabIndex = 0;
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
			this.usernameIcon.Enter += new System.EventHandler(this.btnLogin_Enter);
			// 
			// tbUsername
			// 
			this.tbUsername.Animated = true;
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
			this.tbUsername.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsername.ForeColor = System.Drawing.Color.Gray;
			this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.HoverState.Parent = this.tbUsername;
			this.tbUsername.Location = new System.Drawing.Point(356, 148);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.PasswordChar = '\0';
			this.tbUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbUsername.PlaceholderText = "Tài khoản";
			this.tbUsername.SelectedText = "";
			this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
			this.tbUsername.Size = new System.Drawing.Size(222, 36);
			this.tbUsername.TabIndex = 0;
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
			this.wPB.TabIndex = 10;
			this.wPB.TabStop = false;
			this.wPB.Enter += new System.EventHandler(this.btnLogin_Enter);
			// 
			// pControl
			// 
			this.pControl.Controls.Add(this.btnExit);
			this.pControl.Controls.Add(this.btnLogin);
			this.pControl.Controls.Add(this.tbUsername);
			this.pControl.Controls.Add(this.pnlUsername);
			this.pControl.Controls.Add(this.pnlPassword);
			this.pControl.Controls.Add(this.lbTitle);
			this.pControl.Controls.Add(this.background);
			this.pControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pControl.Location = new System.Drawing.Point(0, 0);
			this.pControl.Name = "pControl";
			this.pControl.Size = new System.Drawing.Size(600, 400);
			this.pControl.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.btnExit.IconColor = System.Drawing.Color.DarkGray;
			this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnExit.IconSize = 20;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.Location = new System.Drawing.Point(572, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(25, 25);
			this.btnExit.TabIndex = 0;
			this.btnExit.TabStop = false;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnExit.Enter += new System.EventHandler(this.btnLogin_Enter);
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
			this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.Parent = this.btnLogin;
			this.btnLogin.Location = new System.Drawing.Point(358, 251);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
			this.btnLogin.Size = new System.Drawing.Size(217, 38);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.TabStop = false;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.pControl);
			this.Controls.Add(this.wPB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Amazing Quiz Application";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.pnlPassword.ResumeLayout(false);
			this.pnlUsername.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
			this.pControl.ResumeLayout(false);
			this.pControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private Guna.UI2.WinForms.Guna2TextBox tbUsername;
		private System.Windows.Forms.Panel pnlPassword;
		private FontAwesome.Sharp.IconButton passwordIcon;
		private System.Windows.Forms.Panel pnlUsername;
		private FontAwesome.Sharp.IconButton usernameIcon;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.PictureBox background;
		private Guna.UI2.WinForms.Guna2WinProgressIndicator wPB;
		private Panel pControl;
		private FontAwesome.Sharp.IconButton btnExit;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
	}
}

