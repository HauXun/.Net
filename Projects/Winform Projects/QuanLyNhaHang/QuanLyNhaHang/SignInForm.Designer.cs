
namespace QuanLyNhaHang
{
	partial class SignInForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnGuest = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lbId = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(33, 125);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnGuest
			// 
			this.btnGuest.Location = new System.Drawing.Point(136, 125);
			this.btnGuest.Name = "btnGuest";
			this.btnGuest.Size = new System.Drawing.Size(75, 23);
			this.btnGuest.TabIndex = 1;
			this.btnGuest.Text = "Khách";
			this.btnGuest.UseVisualStyleBackColor = true;
			this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(228, 125);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.Location = new System.Drawing.Point(48, 36);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(60, 15);
			this.lbId.TabIndex = 3;
			this.lbId.Text = "Tài khoản:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Location = new System.Drawing.Point(48, 75);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(60, 15);
			this.lbPassword.TabIndex = 4;
			this.lbPassword.Text = "Mật khẩu:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(114, 33);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(189, 23);
			this.tbName.TabIndex = 5;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(114, 72);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(189, 23);
			this.tbPassword.TabIndex = 6;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// SignInForm
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(359, 175);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGuest);
			this.Controls.Add(this.btnLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SignInForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnGuest;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
	}
}

