
namespace QuanLyQuanCafe
{
	partial class fAccountProfile
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbDisplayName = new System.Windows.Forms.TextBox();
			this.lbLogin = new System.Windows.Forms.Label();
			this.lbDisplayName = new System.Windows.Forms.Label();
			this.lbRePassword = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbNewPassword = new System.Windows.Forms.Label();
			this.tbNewPassword = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbRePassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.AutoSize = true;
			this.btnUpdate.Location = new System.Drawing.Point(142, 177);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(93, 28);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Cập nhập";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(320, 177);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 28);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(142, 9);
			this.tbLogin.Margin = new System.Windows.Forms.Padding(4);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(263, 23);
			this.tbLogin.TabIndex = 0;
			// 
			// tbDisplayName
			// 
			this.tbDisplayName.Location = new System.Drawing.Point(142, 40);
			this.tbDisplayName.Margin = new System.Windows.Forms.Padding(4);
			this.tbDisplayName.Name = "tbDisplayName";
			this.tbDisplayName.Size = new System.Drawing.Size(263, 23);
			this.tbDisplayName.TabIndex = 1;
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.BackColor = System.Drawing.Color.Transparent;
			this.lbLogin.Location = new System.Drawing.Point(13, 12);
			this.lbLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(109, 17);
			this.lbLogin.TabIndex = 4;
			this.lbLogin.Text = "Tên đăng nhập:";
			// 
			// lbDisplayName
			// 
			this.lbDisplayName.AutoSize = true;
			this.lbDisplayName.BackColor = System.Drawing.Color.Transparent;
			this.lbDisplayName.Location = new System.Drawing.Point(13, 43);
			this.lbDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbDisplayName.Name = "lbDisplayName";
			this.lbDisplayName.Size = new System.Drawing.Size(87, 17);
			this.lbDisplayName.TabIndex = 6;
			this.lbDisplayName.Text = "Tên hiển thị:";
			// 
			// lbRePassword
			// 
			this.lbRePassword.AutoSize = true;
			this.lbRePassword.BackColor = System.Drawing.Color.Transparent;
			this.lbRePassword.Location = new System.Drawing.Point(13, 140);
			this.lbRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbRePassword.Name = "lbRePassword";
			this.lbRePassword.Size = new System.Drawing.Size(126, 17);
			this.lbRePassword.TabIndex = 8;
			this.lbRePassword.Text = "Nhập lại mật khẩu:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbPassword.Location = new System.Drawing.Point(13, 74);
			this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(70, 17);
			this.lbPassword.TabIndex = 7;
			this.lbPassword.Text = "Mật khẩu:";
			// 
			// lbNewPassword
			// 
			this.lbNewPassword.AutoSize = true;
			this.lbNewPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbNewPassword.Location = new System.Drawing.Point(13, 109);
			this.lbNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNewPassword.Name = "lbNewPassword";
			this.lbNewPassword.Size = new System.Drawing.Size(96, 17);
			this.lbNewPassword.TabIndex = 9;
			this.lbNewPassword.Text = "Mật khẩu mới:";
			// 
			// tbNewPassword
			// 
			this.tbNewPassword.Location = new System.Drawing.Point(142, 106);
			this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbNewPassword.Name = "tbNewPassword";
			this.tbNewPassword.Size = new System.Drawing.Size(263, 23);
			this.tbNewPassword.TabIndex = 11;
			this.tbNewPassword.UseSystemPasswordChar = true;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(142, 71);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(263, 23);
			this.tbPassword.TabIndex = 10;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbRePassword
			// 
			this.tbRePassword.Location = new System.Drawing.Point(142, 137);
			this.tbRePassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbRePassword.Name = "tbRePassword";
			this.tbRePassword.Size = new System.Drawing.Size(263, 23);
			this.tbRePassword.TabIndex = 12;
			// 
			// fAccountProfile
			// 
			this.AcceptButton = this.btnUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(416, 216);
			this.Controls.Add(this.tbRePassword);
			this.Controls.Add(this.tbNewPassword);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.lbNewPassword);
			this.Controls.Add(this.lbRePassword);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.lbDisplayName);
			this.Controls.Add(this.tbDisplayName);
			this.Controls.Add(this.lbLogin);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnUpdate);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "fAccountProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin cá nhân";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbDisplayName;
		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.Label lbDisplayName;
		private System.Windows.Forms.Label lbNewPassword;
		private System.Windows.Forms.Label lbRePassword;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.TextBox tbRePassword;
		private System.Windows.Forms.TextBox tbNewPassword;
		private System.Windows.Forms.TextBox tbPassword;
	}
}