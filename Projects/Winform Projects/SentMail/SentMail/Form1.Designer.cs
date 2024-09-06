
namespace SentMail
{
	partial class Form1
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
			this.btnAttach = new System.Windows.Forms.Button();
			this.btnSent = new System.Windows.Forms.Button();
			this.lbTo = new System.Windows.Forms.Label();
			this.lbSubject = new System.Windows.Forms.Label();
			this.lbLogin = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbMessage = new System.Windows.Forms.Label();
			this.tbxAttach = new System.Windows.Forms.TextBox();
			this.tbxTo = new System.Windows.Forms.TextBox();
			this.tbxSubject = new System.Windows.Forms.TextBox();
			this.tbxLogin = new System.Windows.Forms.TextBox();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.tbxMessage = new System.Windows.Forms.TextBox();
			this.btnListMail = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAttach
			// 
			this.btnAttach.Location = new System.Drawing.Point(388, 12);
			this.btnAttach.Name = "btnAttach";
			this.btnAttach.Size = new System.Drawing.Size(75, 23);
			this.btnAttach.TabIndex = 0;
			this.btnAttach.Text = "Attach";
			this.btnAttach.UseVisualStyleBackColor = true;
			this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
			// 
			// btnSent
			// 
			this.btnSent.Location = new System.Drawing.Point(107, 216);
			this.btnSent.Name = "btnSent";
			this.btnSent.Size = new System.Drawing.Size(75, 23);
			this.btnSent.TabIndex = 1;
			this.btnSent.Text = "Sent";
			this.btnSent.UseVisualStyleBackColor = true;
			this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
			// 
			// lbTo
			// 
			this.lbTo.AutoSize = true;
			this.lbTo.Location = new System.Drawing.Point(12, 53);
			this.lbTo.Name = "lbTo";
			this.lbTo.Size = new System.Drawing.Size(23, 13);
			this.lbTo.TabIndex = 2;
			this.lbTo.Text = "To:";
			// 
			// lbSubject
			// 
			this.lbSubject.AutoSize = true;
			this.lbSubject.Location = new System.Drawing.Point(12, 97);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(46, 13);
			this.lbSubject.TabIndex = 3;
			this.lbSubject.Text = "Subject:";
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.Location = new System.Drawing.Point(12, 138);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(84, 13);
			this.lbLogin.TabIndex = 4;
			this.lbLogin.Text = "Tên đăng nhập:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Location = new System.Drawing.Point(12, 182);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(55, 13);
			this.lbPassword.TabIndex = 5;
			this.lbPassword.Text = "Mật khẩu:";
			// 
			// lbMessage
			// 
			this.lbMessage.AutoSize = true;
			this.lbMessage.Location = new System.Drawing.Point(12, 221);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Size = new System.Drawing.Size(53, 13);
			this.lbMessage.TabIndex = 6;
			this.lbMessage.Text = "Message:";
			// 
			// tbxAttach
			// 
			this.tbxAttach.Location = new System.Drawing.Point(12, 14);
			this.tbxAttach.Name = "tbxAttach";
			this.tbxAttach.ReadOnly = true;
			this.tbxAttach.Size = new System.Drawing.Size(370, 20);
			this.tbxAttach.TabIndex = 8;
			// 
			// tbxTo
			// 
			this.tbxTo.Location = new System.Drawing.Point(107, 50);
			this.tbxTo.Name = "tbxTo";
			this.tbxTo.Size = new System.Drawing.Size(275, 20);
			this.tbxTo.TabIndex = 9;
			// 
			// tbxSubject
			// 
			this.tbxSubject.Location = new System.Drawing.Point(107, 94);
			this.tbxSubject.Name = "tbxSubject";
			this.tbxSubject.Size = new System.Drawing.Size(356, 20);
			this.tbxSubject.TabIndex = 10;
			// 
			// tbxLogin
			// 
			this.tbxLogin.Location = new System.Drawing.Point(107, 135);
			this.tbxLogin.Name = "tbxLogin";
			this.tbxLogin.Size = new System.Drawing.Size(356, 20);
			this.tbxLogin.TabIndex = 11;
			// 
			// tbxPassword
			// 
			this.tbxPassword.Location = new System.Drawing.Point(107, 179);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.Size = new System.Drawing.Size(356, 20);
			this.tbxPassword.TabIndex = 12;
			this.tbxPassword.UseSystemPasswordChar = true;
			// 
			// tbxMessage
			// 
			this.tbxMessage.Location = new System.Drawing.Point(15, 245);
			this.tbxMessage.Multiline = true;
			this.tbxMessage.Name = "tbxMessage";
			this.tbxMessage.Size = new System.Drawing.Size(448, 193);
			this.tbxMessage.TabIndex = 13;
			this.tbxMessage.UseSystemPasswordChar = true;
			// 
			// btnListMail
			// 
			this.btnListMail.Location = new System.Drawing.Point(388, 48);
			this.btnListMail.Name = "btnListMail";
			this.btnListMail.Size = new System.Drawing.Size(75, 23);
			this.btnListMail.TabIndex = 14;
			this.btnListMail.Text = "Get List Mail";
			this.btnListMail.UseVisualStyleBackColor = true;
			this.btnListMail.Click += new System.EventHandler(this.btnListMail_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnListMail);
			this.Controls.Add(this.tbxMessage);
			this.Controls.Add(this.tbxPassword);
			this.Controls.Add(this.tbxLogin);
			this.Controls.Add(this.tbxSubject);
			this.Controls.Add(this.tbxTo);
			this.Controls.Add(this.tbxAttach);
			this.Controls.Add(this.lbMessage);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.lbLogin);
			this.Controls.Add(this.lbSubject);
			this.Controls.Add(this.lbTo);
			this.Controls.Add(this.btnSent);
			this.Controls.Add(this.btnAttach);
			this.Name = "Form1";
			this.Text = "Sent Mail";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAttach;
		private System.Windows.Forms.Button btnSent;
		private System.Windows.Forms.Label lbTo;
		private System.Windows.Forms.Label lbSubject;
		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbMessage;
		private System.Windows.Forms.TextBox tbxAttach;
		private System.Windows.Forms.TextBox tbxTo;
		private System.Windows.Forms.TextBox tbxSubject;
		private System.Windows.Forms.TextBox tbxLogin;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.TextBox tbxMessage;
		private System.Windows.Forms.Button btnListMail;
	}
}

