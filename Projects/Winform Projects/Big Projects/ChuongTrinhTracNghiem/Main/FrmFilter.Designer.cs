
namespace Main
{
	partial class FrmFilter
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
			this.btnFilter = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbSubject = new System.Windows.Forms.Label();
			this.lbExamRole = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.lbExamID = new System.Windows.Forms.Label();
			this.cbSubjectFilter = new System.Windows.Forms.ComboBox();
			this.cbExamIDFilter = new System.Windows.Forms.ComboBox();
			this.cbExamRoleFilter = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFilter
			// 
			this.btnFilter.AutoSize = true;
			this.btnFilter.Location = new System.Drawing.Point(92, 180);
			this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(93, 28);
			this.btnFilter.TabIndex = 8;
			this.btnFilter.Text = "Lọc";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(303, 180);
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
			this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(62, 19);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(356, 23);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "TÙY CHỌN CẤU TRÚC LỌC TÌM KIẾM";
			// 
			// lbSubject
			// 
			this.lbSubject.AutoSize = true;
			this.lbSubject.BackColor = System.Drawing.Color.Transparent;
			this.lbSubject.Location = new System.Drawing.Point(76, 60);
			this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(58, 17);
			this.lbSubject.TabIndex = 1;
			this.lbSubject.Text = "Môn thi:";
			// 
			// lbExamRole
			// 
			this.lbExamRole.AutoSize = true;
			this.lbExamRole.BackColor = System.Drawing.Color.Transparent;
			this.lbExamRole.Location = new System.Drawing.Point(76, 141);
			this.lbExamRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbExamRole.Name = "lbExamRole";
			this.lbExamRole.Size = new System.Drawing.Size(59, 17);
			this.lbExamRole.TabIndex = 2;
			this.lbExamRole.Text = "Loại đề:";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// lbExamID
			// 
			this.lbExamID.AutoSize = true;
			this.lbExamID.BackColor = System.Drawing.Color.Transparent;
			this.lbExamID.Location = new System.Drawing.Point(76, 100);
			this.lbExamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbExamID.Name = "lbExamID";
			this.lbExamID.Size = new System.Drawing.Size(51, 17);
			this.lbExamID.TabIndex = 0;
			this.lbExamID.Text = "Mã đề:";
			// 
			// cbSubjectFilter
			// 
			this.cbSubjectFilter.FormattingEnabled = true;
			this.cbSubjectFilter.Location = new System.Drawing.Point(142, 57);
			this.cbSubjectFilter.Name = "cbSubjectFilter";
			this.cbSubjectFilter.Size = new System.Drawing.Size(263, 24);
			this.cbSubjectFilter.TabIndex = 10;
			this.cbSubjectFilter.SelectedIndexChanged += new System.EventHandler(this.cbSubjectFilter_SelectedIndexChanged);
			// 
			// cbExamIDFilter
			// 
			this.cbExamIDFilter.FormattingEnabled = true;
			this.cbExamIDFilter.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
			this.cbExamIDFilter.Location = new System.Drawing.Point(142, 97);
			this.cbExamIDFilter.Name = "cbExamIDFilter";
			this.cbExamIDFilter.Size = new System.Drawing.Size(263, 24);
			this.cbExamIDFilter.TabIndex = 11;
			// 
			// cbExamRoleFilter
			// 
			this.cbExamRoleFilter.FormattingEnabled = true;
			this.cbExamRoleFilter.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
			this.cbExamRoleFilter.Location = new System.Drawing.Point(142, 138);
			this.cbExamRoleFilter.Name = "cbExamRoleFilter";
			this.cbExamRoleFilter.Size = new System.Drawing.Size(263, 24);
			this.cbExamRoleFilter.TabIndex = 12;
			// 
			// FrmFilter
			// 
			this.AcceptButton = this.btnFilter;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(481, 227);
			this.Controls.Add(this.cbExamRoleFilter);
			this.Controls.Add(this.cbExamIDFilter);
			this.Controls.Add(this.cbSubjectFilter);
			this.Controls.Add(this.lbExamID);
			this.Controls.Add(this.lbExamRole);
			this.Controls.Add(this.lbSubject);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnFilter);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(497, 266);
			this.MinimumSize = new System.Drawing.Size(497, 266);
			this.Name = "FrmFilter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lọc tìm kiếm";
			this.Load += new System.EventHandler(this.FrmFilter_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lbSubject;
		private System.Windows.Forms.Label lbExamRole;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Label lbExamID;
		private System.Windows.Forms.ComboBox cbSubjectFilter;
		public System.Windows.Forms.ComboBox cbExamIDFilter;
		public System.Windows.Forms.Label lbTitle;
		public System.Windows.Forms.ComboBox cbExamRoleFilter;
	}
}