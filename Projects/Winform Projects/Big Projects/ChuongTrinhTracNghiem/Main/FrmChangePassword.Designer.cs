
namespace Main
{
	partial class FrmChangePassword
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lbAccount = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.lbNewPassword = new System.Windows.Forms.Label();
			this.tbNewPassword = new System.Windows.Forms.TextBox();
			this.lbRePassword = new System.Windows.Forms.Label();
			this.tbRePassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFullName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.AutoSize = true;
			this.btnUpdate.Location = new System.Drawing.Point(91, 215);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(93, 28);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Cập nhập";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(302, 215);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 28);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(149, 15);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(182, 25);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Cập nhập tài khoản";
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(174, 57);
			this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.ReadOnly = true;
			this.tbUserName.Size = new System.Drawing.Size(263, 23);
			this.tbUserName.TabIndex = 2;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(174, 119);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(263, 23);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// lbAccount
			// 
			this.lbAccount.AutoSize = true;
			this.lbAccount.BackColor = System.Drawing.Color.Transparent;
			this.lbAccount.Location = new System.Drawing.Point(44, 60);
			this.lbAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbAccount.Name = "lbAccount";
			this.lbAccount.Size = new System.Drawing.Size(75, 17);
			this.lbAccount.TabIndex = 1;
			this.lbAccount.Text = "Tài khoản:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbPassword.Location = new System.Drawing.Point(44, 122);
			this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(70, 17);
			this.lbPassword.TabIndex = 2;
			this.lbPassword.Text = "Mật khẩu:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// lbNewPassword
			// 
			this.lbNewPassword.AutoSize = true;
			this.lbNewPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbNewPassword.Location = new System.Drawing.Point(44, 153);
			this.lbNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNewPassword.Name = "lbNewPassword";
			this.lbNewPassword.Size = new System.Drawing.Size(96, 17);
			this.lbNewPassword.TabIndex = 4;
			this.lbNewPassword.Text = "Mật khẩu mới:";
			// 
			// tbNewPassword
			// 
			this.tbNewPassword.Location = new System.Drawing.Point(174, 150);
			this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbNewPassword.Name = "tbNewPassword";
			this.tbNewPassword.Size = new System.Drawing.Size(263, 23);
			this.tbNewPassword.TabIndex = 5;
			this.tbNewPassword.UseSystemPasswordChar = true;
			// 
			// lbRePassword
			// 
			this.lbRePassword.AutoSize = true;
			this.lbRePassword.BackColor = System.Drawing.Color.Transparent;
			this.lbRePassword.Location = new System.Drawing.Point(44, 184);
			this.lbRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbRePassword.Name = "lbRePassword";
			this.lbRePassword.Size = new System.Drawing.Size(122, 17);
			this.lbRePassword.TabIndex = 6;
			this.lbRePassword.Text = "Nhập lại mật khẩu";
			// 
			// tbRePassword
			// 
			this.tbRePassword.Location = new System.Drawing.Point(174, 181);
			this.tbRePassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbRePassword.Name = "tbRePassword";
			this.tbRePassword.Size = new System.Drawing.Size(263, 23);
			this.tbRePassword.TabIndex = 7;
			this.tbRePassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(44, 91);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên hiển thị:";
			// 
			// tbFullName
			// 
			this.tbFullName.Location = new System.Drawing.Point(174, 88);
			this.tbFullName.Margin = new System.Windows.Forms.Padding(4);
			this.tbFullName.Name = "tbFullName";
			this.tbFullName.Size = new System.Drawing.Size(263, 23);
			this.tbFullName.TabIndex = 1;
			// 
			// FrmChangePassword
			// 
			this.AcceptButton = this.btnUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(481, 256);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbFullName);
			this.Controls.Add(this.lbRePassword);
			this.Controls.Add(this.tbRePassword);
			this.Controls.Add(this.lbNewPassword);
			this.Controls.Add(this.tbNewPassword);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.lbAccount);
			this.Controls.Add(this.tbUserName);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnUpdate);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(497, 295);
			this.MinimumSize = new System.Drawing.Size(497, 295);
			this.Name = "FrmChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cập nhập thông tin tài khoản";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lbAccount;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Label lbRePassword;
		private System.Windows.Forms.TextBox tbRePassword;
		private System.Windows.Forms.Label lbNewPassword;
		private System.Windows.Forms.TextBox tbNewPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFullName;
	}
}