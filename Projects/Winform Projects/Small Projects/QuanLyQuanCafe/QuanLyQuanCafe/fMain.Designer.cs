
namespace QuanLyQuanCafe
{
	partial class fMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.AutoSize = true;
			this.btnLogin.Location = new System.Drawing.Point(48, 128);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(70, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(206, 128);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(114, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Đăng nhập hệ thống";
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(96, 44);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(198, 20);
			this.tbUserName.TabIndex = 0;
			this.tbUserName.Text = "admin";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(96, 83);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(198, 20);
			this.tbPassword.TabIndex = 1;
			this.tbPassword.Text = "admin";
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(32, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tài khoản:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(32, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mật khẩu:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// bunifuButton1
			// 
			this.bunifuButton1.AllowToggling = false;
			this.bunifuButton1.AnimationSpeed = 200;
			this.bunifuButton1.AutoGenerateColors = false;
			this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
			this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
			this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.ButtonText = "bunifuButton1";
			this.bunifuButton1.ButtonTextMarginLeft = 0;
			this.bunifuButton1.ColorContrastOnClick = 45;
			this.bunifuButton1.ColorContrastOnHover = 45;
			this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.bunifuButton1.CustomizableEdges = borderEdges1;
			this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
			this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
			this.bunifuButton1.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuButton1.IconMarginLeft = 11;
			this.bunifuButton1.IconPadding = 10;
			this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.bunifuButton1.IdleBorderRadius = 3;
			this.bunifuButton1.IdleBorderThickness = 1;
			this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
			this.bunifuButton1.IdleIconLeftImage = null;
			this.bunifuButton1.IdleIconRightImage = null;
			this.bunifuButton1.IndicateFocus = false;
			this.bunifuButton1.Location = new System.Drawing.Point(60, 47);
			this.bunifuButton1.Name = "bunifuButton1";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties1.BorderRadius = 3;
			stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			stateProperties1.BorderThickness = 1;
			stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties1.ForeColor = System.Drawing.Color.White;
			stateProperties1.IconLeftImage = null;
			stateProperties1.IconRightImage = null;
			this.bunifuButton1.onHoverState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties2.BorderRadius = 3;
			stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			stateProperties2.BorderThickness = 1;
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties2.ForeColor = System.Drawing.Color.White;
			stateProperties2.IconLeftImage = null;
			stateProperties2.IconRightImage = null;
			this.bunifuButton1.OnPressedState = stateProperties2;
			this.bunifuButton1.Size = new System.Drawing.Size(210, 45);
			this.bunifuButton1.TabIndex = 7;
			this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuButton1.TextMarginLeft = 0;
			this.bunifuButton1.UseDefaultRadiusAndThickness = true;
			// 
			// fMain
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(327, 172);
			this.Controls.Add(this.bunifuButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbUserName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(343, 211);
			this.MinimumSize = new System.Drawing.Size(343, 211);
			this.Name = "fMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hệ thống thi trắc nghiệm";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
	}
}