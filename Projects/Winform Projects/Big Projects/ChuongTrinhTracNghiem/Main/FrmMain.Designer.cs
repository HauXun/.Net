
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
			this.msAdmin = new System.Windows.Forms.MenuStrip();
			this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiRestoreData = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiManageUser = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiManageSubject = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiManageQuestion = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFunction = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTraining = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiTestQuiz = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGuide = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTraining = new System.Windows.Forms.Button();
			this.btnShowTop = new System.Windows.Forms.Button();
			this.btnGuide = new System.Windows.Forms.Button();
			this.btnTestQuiz = new System.Windows.Forms.Button();
			this.pNext = new System.Windows.Forms.Panel();
			this.lbNext = new System.Windows.Forms.Label();
			this.lbFunctionSelected = new System.Windows.Forms.Label();
			this.lbFunction = new System.Windows.Forms.Label();
			this.lbFIcon = new System.Windows.Forms.Label();
			this.lbDisplayname = new System.Windows.Forms.Label();
			this.lbID = new System.Windows.Forms.Label();
			this.gpInfoAccount = new System.Windows.Forms.GroupBox();
			this.tbID = new System.Windows.Forms.TextBox();
			this.tbDisplayname = new System.Windows.Forms.TextBox();
			this.pFunction = new System.Windows.Forms.Panel();
			this.tsmiManageExam = new System.Windows.Forms.ToolStripMenuItem();
			this.msAdmin.SuspendLayout();
			this.pNext.SuspendLayout();
			this.gpInfoAccount.SuspendLayout();
			this.pFunction.SuspendLayout();
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
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// tsmiCategory
			// 
			this.tsmiCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageSubject,
            this.tsmiManageQuestion,
            this.tsmiManageExam});
			this.tsmiCategory.Name = "tsmiCategory";
			this.tsmiCategory.Size = new System.Drawing.Size(74, 20);
			this.tsmiCategory.Text = "Danh mục";
			// 
			// tsmiManageSubject
			// 
			this.tsmiManageSubject.Name = "tsmiManageSubject";
			this.tsmiManageSubject.Size = new System.Drawing.Size(180, 22);
			this.tsmiManageSubject.Text = "Quản lý môn thi";
			this.tsmiManageSubject.Click += new System.EventHandler(this.tsmiManageSubject_Click);
			// 
			// tsmiManageQuestion
			// 
			this.tsmiManageQuestion.Name = "tsmiManageQuestion";
			this.tsmiManageQuestion.Size = new System.Drawing.Size(180, 22);
			this.tsmiManageQuestion.Text = "Quản lý câu hỏi";
			this.tsmiManageQuestion.Click += new System.EventHandler(this.tsmiManageQuestion_Click);
			// 
			// tsmiFunction
			// 
			this.tsmiFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTraining,
            this.toolStripSeparator1,
            this.tsmiTestQuiz,
            this.tsmiGuide});
			this.tsmiFunction.Name = "tsmiFunction";
			this.tsmiFunction.Size = new System.Drawing.Size(77, 20);
			this.tsmiFunction.Text = "Chức năng";
			// 
			// tsmiTraining
			// 
			this.tsmiTraining.Name = "tsmiTraining";
			this.tsmiTraining.Size = new System.Drawing.Size(180, 22);
			this.tsmiTraining.Text = "Thi thử luyện tập";
			this.tsmiTraining.Click += new System.EventHandler(this.tsmiTraining_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiTestQuiz
			// 
			this.tsmiTestQuiz.Name = "tsmiTestQuiz";
			this.tsmiTestQuiz.Size = new System.Drawing.Size(180, 22);
			this.tsmiTestQuiz.Text = "Thi ngay";
			this.tsmiTestQuiz.Click += new System.EventHandler(this.tsmiTestQuiz_Click);
			// 
			// tsmiGuide
			// 
			this.tsmiGuide.Name = "tsmiGuide";
			this.tsmiGuide.Size = new System.Drawing.Size(180, 22);
			this.tsmiGuide.Text = "Hướng dẫn thi";
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
			// btnTraining
			// 
			this.btnTraining.BackColor = System.Drawing.Color.OrangeRed;
			this.btnTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTraining.ForeColor = System.Drawing.Color.White;
			this.btnTraining.Location = new System.Drawing.Point(3, 3);
			this.btnTraining.Name = "btnTraining";
			this.btnTraining.Size = new System.Drawing.Size(444, 40);
			this.btnTraining.TabIndex = 0;
			this.btnTraining.Text = "Thi thử luyện tập";
			this.btnTraining.UseVisualStyleBackColor = false;
			this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
			this.btnTraining.Enter += new System.EventHandler(this.btnTraining_Enter);
			// 
			// btnShowTop
			// 
			this.btnShowTop.BackColor = System.Drawing.Color.OrangeRed;
			this.btnShowTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowTop.ForeColor = System.Drawing.Color.White;
			this.btnShowTop.Location = new System.Drawing.Point(3, 49);
			this.btnShowTop.Name = "btnShowTop";
			this.btnShowTop.Size = new System.Drawing.Size(444, 40);
			this.btnShowTop.TabIndex = 1;
			this.btnShowTop.Text = "Bảng xếp hạng";
			this.btnShowTop.UseVisualStyleBackColor = false;
			this.btnShowTop.Click += new System.EventHandler(this.btnTraining_Click);
			this.btnShowTop.Enter += new System.EventHandler(this.btnTraining_Enter);
			// 
			// btnGuide
			// 
			this.btnGuide.BackColor = System.Drawing.Color.OrangeRed;
			this.btnGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuide.ForeColor = System.Drawing.Color.White;
			this.btnGuide.Location = new System.Drawing.Point(3, 95);
			this.btnGuide.Name = "btnGuide";
			this.btnGuide.Size = new System.Drawing.Size(444, 40);
			this.btnGuide.TabIndex = 2;
			this.btnGuide.Text = "Hướng dẫn thi";
			this.btnGuide.UseVisualStyleBackColor = false;
			this.btnGuide.Click += new System.EventHandler(this.btnTraining_Click);
			this.btnGuide.Enter += new System.EventHandler(this.btnTraining_Enter);
			// 
			// btnTestQuiz
			// 
			this.btnTestQuiz.BackColor = System.Drawing.Color.Crimson;
			this.btnTestQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTestQuiz.ForeColor = System.Drawing.Color.White;
			this.btnTestQuiz.Location = new System.Drawing.Point(3, 141);
			this.btnTestQuiz.Name = "btnTestQuiz";
			this.btnTestQuiz.Size = new System.Drawing.Size(444, 40);
			this.btnTestQuiz.TabIndex = 3;
			this.btnTestQuiz.Text = "Bắt đầu thi";
			this.btnTestQuiz.UseVisualStyleBackColor = false;
			this.btnTestQuiz.Click += new System.EventHandler(this.btnTraining_Click);
			this.btnTestQuiz.Enter += new System.EventHandler(this.btnTraining_Enter);
			// 
			// pNext
			// 
			this.pNext.BackColor = System.Drawing.Color.Transparent;
			this.pNext.Controls.Add(this.lbNext);
			this.pNext.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pNext.Location = new System.Drawing.Point(938, 467);
			this.pNext.Name = "pNext";
			this.pNext.Size = new System.Drawing.Size(80, 30);
			this.pNext.TabIndex = 5;
			// 
			// lbNext
			// 
			this.lbNext.AutoSize = true;
			this.lbNext.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNext.ForeColor = System.Drawing.Color.White;
			this.lbNext.Location = new System.Drawing.Point(17, 5);
			this.lbNext.Name = "lbNext";
			this.lbNext.Size = new System.Drawing.Size(46, 22);
			this.lbNext.TabIndex = 0;
			this.lbNext.Text = "Next";
			// 
			// lbFunctionSelected
			// 
			this.lbFunctionSelected.AutoSize = true;
			this.lbFunctionSelected.BackColor = System.Drawing.Color.Transparent;
			this.lbFunctionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFunctionSelected.Location = new System.Drawing.Point(568, 472);
			this.lbFunctionSelected.Name = "lbFunctionSelected";
			this.lbFunctionSelected.Size = new System.Drawing.Size(192, 20);
			this.lbFunctionSelected.TabIndex = 4;
			this.lbFunctionSelected.Text = "Chọn đi chần chừ gì nữa ?";
			// 
			// lbFunction
			// 
			this.lbFunction.AutoSize = true;
			this.lbFunction.BackColor = System.Drawing.Color.Transparent;
			this.lbFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFunction.ForeColor = System.Drawing.Color.White;
			this.lbFunction.Location = new System.Drawing.Point(865, 122);
			this.lbFunction.Name = "lbFunction";
			this.lbFunction.Size = new System.Drawing.Size(112, 24);
			this.lbFunction.TabIndex = 1;
			this.lbFunction.Text = "Chức năng";
			// 
			// lbFIcon
			// 
			this.lbFIcon.AutoSize = true;
			this.lbFIcon.BackColor = System.Drawing.Color.Transparent;
			this.lbFIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFIcon.ForeColor = System.Drawing.Color.OrangeRed;
			this.lbFIcon.Location = new System.Drawing.Point(993, 125);
			this.lbFIcon.Name = "lbFIcon";
			this.lbFIcon.Size = new System.Drawing.Size(20, 20);
			this.lbFIcon.TabIndex = 2;
			this.lbFIcon.Text = "F";
			// 
			// lbDisplayname
			// 
			this.lbDisplayname.AutoSize = true;
			this.lbDisplayname.BackColor = System.Drawing.Color.Transparent;
			this.lbDisplayname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDisplayname.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbDisplayname.Location = new System.Drawing.Point(76, 23);
			this.lbDisplayname.Name = "lbDisplayname";
			this.lbDisplayname.Size = new System.Drawing.Size(79, 19);
			this.lbDisplayname.TabIndex = 0;
			this.lbDisplayname.Text = "Họ và tên:";
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.BackColor = System.Drawing.Color.Transparent;
			this.lbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbID.Location = new System.Drawing.Point(76, 50);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(32, 19);
			this.lbID.TabIndex = 2;
			this.lbID.Text = "ID:";
			// 
			// gpInfoAccount
			// 
			this.gpInfoAccount.BackColor = System.Drawing.Color.Transparent;
			this.gpInfoAccount.Controls.Add(this.tbID);
			this.gpInfoAccount.Controls.Add(this.tbDisplayname);
			this.gpInfoAccount.Controls.Add(this.lbDisplayname);
			this.gpInfoAccount.Controls.Add(this.lbID);
			this.gpInfoAccount.Location = new System.Drawing.Point(572, 161);
			this.gpInfoAccount.Name = "gpInfoAccount";
			this.gpInfoAccount.Size = new System.Drawing.Size(444, 77);
			this.gpInfoAccount.TabIndex = 6;
			this.gpInfoAccount.TabStop = false;
			this.gpInfoAccount.Text = "Thông tin cá nhân";
			// 
			// tbID
			// 
			this.tbID.Location = new System.Drawing.Point(161, 50);
			this.tbID.Name = "tbID";
			this.tbID.ReadOnly = true;
			this.tbID.Size = new System.Drawing.Size(192, 20);
			this.tbID.TabIndex = 3;
			this.tbID.TabStop = false;
			// 
			// tbDisplayname
			// 
			this.tbDisplayname.Location = new System.Drawing.Point(161, 24);
			this.tbDisplayname.Name = "tbDisplayname";
			this.tbDisplayname.ReadOnly = true;
			this.tbDisplayname.Size = new System.Drawing.Size(192, 20);
			this.tbDisplayname.TabIndex = 1;
			this.tbDisplayname.TabStop = false;
			// 
			// pFunction
			// 
			this.pFunction.BackColor = System.Drawing.Color.Transparent;
			this.pFunction.Controls.Add(this.btnTraining);
			this.pFunction.Controls.Add(this.btnShowTop);
			this.pFunction.Controls.Add(this.btnGuide);
			this.pFunction.Controls.Add(this.btnTestQuiz);
			this.pFunction.Location = new System.Drawing.Point(569, 244);
			this.pFunction.Name = "pFunction";
			this.pFunction.Size = new System.Drawing.Size(451, 184);
			this.pFunction.TabIndex = 3;
			// 
			// tsmiManageExam
			// 
			this.tsmiManageExam.Name = "tsmiManageExam";
			this.tsmiManageExam.Size = new System.Drawing.Size(180, 22);
			this.tsmiManageExam.Text = "Quản lý đề thi";
			this.tsmiManageExam.Click += new System.EventHandler(this.tsmiManageExam_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Main.Properties.Resources.QuizThumnails;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1064, 601);
			this.Controls.Add(this.pFunction);
			this.Controls.Add(this.lbFunction);
			this.Controls.Add(this.lbFIcon);
			this.Controls.Add(this.gpInfoAccount);
			this.Controls.Add(this.lbFunctionSelected);
			this.Controls.Add(this.pNext);
			this.Controls.Add(this.msAdmin);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.msAdmin;
			this.MinimumSize = new System.Drawing.Size(1080, 640);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hệ thống thi trắc nghiệm";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.msAdmin.ResumeLayout(false);
			this.msAdmin.PerformLayout();
			this.pNext.ResumeLayout(false);
			this.pNext.PerformLayout();
			this.gpInfoAccount.ResumeLayout(false);
			this.gpInfoAccount.PerformLayout();
			this.pFunction.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem tsmiManageSubject;
		private System.Windows.Forms.ToolStripMenuItem tsmiManageQuestion;
		private System.Windows.Forms.ToolStripMenuItem tsmiFunction;
		private System.Windows.Forms.ToolStripMenuItem tsmiReport;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
		private System.Windows.Forms.Button btnTraining;
		private System.Windows.Forms.Button btnShowTop;
		private System.Windows.Forms.Button btnGuide;
		private System.Windows.Forms.Button btnTestQuiz;
		private System.Windows.Forms.Panel pNext;
		private System.Windows.Forms.Label lbFunctionSelected;
		private System.Windows.Forms.Label lbFunction;
		private System.Windows.Forms.Label lbFIcon;
		private System.Windows.Forms.Label lbDisplayname;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.GroupBox gpInfoAccount;
		private System.Windows.Forms.Panel pFunction;
		private System.Windows.Forms.Label lbNext;
		private System.Windows.Forms.TextBox tbID;
		private System.Windows.Forms.TextBox tbDisplayname;
		private System.Windows.Forms.ToolStripMenuItem tsmiTraining;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiTestQuiz;
		private System.Windows.Forms.ToolStripMenuItem tsmiGuide;
		private System.Windows.Forms.ToolStripMenuItem tsmiManageExam;
	}
}

