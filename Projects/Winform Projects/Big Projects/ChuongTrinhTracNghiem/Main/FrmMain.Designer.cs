
namespace Main
{
	partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.msAdmin = new System.Windows.Forms.MenuStrip();
			this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiRestoreData = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiManageUser = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýMônThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýCâuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFunction = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.msAdmin.SuspendLayout();
			this.SuspendLayout();
			// 
			// msAdmin
			// 
			this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiCategory,
            this.tsmiFunction,
            this.tsmiReport,
            this.tsmiHelp});
			this.msAdmin.Location = new System.Drawing.Point(0, 0);
			this.msAdmin.Name = "msAdmin";
			this.msAdmin.Size = new System.Drawing.Size(1064, 24);
			this.msAdmin.TabIndex = 0;
			this.msAdmin.Text = "menuStrip1";
			// 
			// tsmiSystem
			// 
			this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePassword,
            this.tsmiRestoreData,
            this.tsmiManageUser,
            this.tsmiExit});
			this.tsmiSystem.Name = "tsmiSystem";
			this.tsmiSystem.Size = new System.Drawing.Size(69, 20);
			this.tsmiSystem.Text = "Hệ thống";
			// 
			// tsmiChangePassword
			// 
			this.tsmiChangePassword.Name = "tsmiChangePassword";
			this.tsmiChangePassword.Size = new System.Drawing.Size(180, 22);
			this.tsmiChangePassword.Text = "Đổi mật khẩu";
			this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
			// 
			// tsmiRestoreData
			// 
			this.tsmiRestoreData.Name = "tsmiRestoreData";
			this.tsmiRestoreData.Size = new System.Drawing.Size(180, 22);
			this.tsmiRestoreData.Text = "Phục hồi dữ liệu";
			// 
			// tsmiManageUser
			// 
			this.tsmiManageUser.Name = "tsmiManageUser";
			this.tsmiManageUser.Size = new System.Drawing.Size(180, 22);
			this.tsmiManageUser.Text = "Quản lý người dùng";
			this.tsmiManageUser.Click += new System.EventHandler(this.tsmiManageUser_Click);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.tsmiExit.Size = new System.Drawing.Size(180, 22);
			this.tsmiExit.Text = "Thoát";
			// 
			// tsmiCategory
			// 
			this.tsmiCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMônThiToolStripMenuItem,
            this.quảnLýCâuHỏiToolStripMenuItem,
            this.quảnLýGiáoViênToolStripMenuItem});
			this.tsmiCategory.Name = "tsmiCategory";
			this.tsmiCategory.Size = new System.Drawing.Size(74, 20);
			this.tsmiCategory.Text = "Danh mục";
			// 
			// quảnLýMônThiToolStripMenuItem
			// 
			this.quảnLýMônThiToolStripMenuItem.Name = "quảnLýMônThiToolStripMenuItem";
			this.quảnLýMônThiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.quảnLýMônThiToolStripMenuItem.Text = "Quản lý môn thi";
			// 
			// quảnLýCâuHỏiToolStripMenuItem
			// 
			this.quảnLýCâuHỏiToolStripMenuItem.Name = "quảnLýCâuHỏiToolStripMenuItem";
			this.quảnLýCâuHỏiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.quảnLýCâuHỏiToolStripMenuItem.Text = "Quản lý câu hỏi";
			// 
			// quảnLýGiáoViênToolStripMenuItem
			// 
			this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
			this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.quảnLýGiáoViênToolStripMenuItem.Text = "Quản lý giáo viên";
			// 
			// tsmiFunction
			// 
			this.tsmiFunction.Name = "tsmiFunction";
			this.tsmiFunction.Size = new System.Drawing.Size(77, 20);
			this.tsmiFunction.Text = "Chức năng";
			// 
			// tsmiReport
			// 
			this.tsmiReport.Name = "tsmiReport";
			this.tsmiReport.Size = new System.Drawing.Size(113, 20);
			this.tsmiReport.Text = "Thống kê báo cáo";
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(62, 20);
			this.tsmiHelp.Text = "Trợ giúp";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1064, 601);
			this.Controls.Add(this.msAdmin);
			this.MainMenuStrip = this.msAdmin;
			this.MinimumSize = new System.Drawing.Size(1080, 640);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hệ thống thi trắc nghiệm";
			this.msAdmin.ResumeLayout(false);
			this.msAdmin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msAdmin;
		private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
		private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
		private System.Windows.Forms.ToolStripMenuItem tsmiRestoreData;
		private System.Windows.Forms.ToolStripMenuItem tsmiManageUser;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem tsmiCategory;
		private System.Windows.Forms.ToolStripMenuItem quảnLýMônThiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýCâuHỏiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiFunction;
		private System.Windows.Forms.ToolStripMenuItem tsmiReport;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
	}
}

