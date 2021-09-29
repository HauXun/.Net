
namespace Main.Pages
{
	partial class Guide
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guide));
			this.pnlHuongDanShadow = new System.Windows.Forms.Panel();
			this.pnlHuongDan = new System.Windows.Forms.Panel();
			this.btnPreviousHelp = new FontAwesome.Sharp.IconButton();
			this.btnNextHelp = new FontAwesome.Sharp.IconButton();
			this.bP = new Bunifu.UI.WinForms.BunifuPages();
			this.addAdmin = new System.Windows.Forms.TabPage();
			this.editAdmin = new System.Windows.Forms.TabPage();
			this.bkPage1 = new System.Windows.Forms.TabPage();
			this.bkPage2 = new System.Windows.Forms.TabPage();
			this.addManager = new System.Windows.Forms.TabPage();
			this.editManager = new System.Windows.Forms.TabPage();
			this.guide1 = new System.Windows.Forms.TabPage();
			this.guide2 = new System.Windows.Forms.TabPage();
			this.guide3 = new System.Windows.Forms.TabPage();
			this.guide4 = new System.Windows.Forms.TabPage();
			this.lbTitle = new System.Windows.Forms.Label();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.pbBackground = new System.Windows.Forms.PictureBox();
			this.pnlHuongDan.SuspendLayout();
			this.bP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlHuongDanShadow
			// 
			this.pnlHuongDanShadow.BackColor = System.Drawing.Color.DarkGray;
			this.pnlHuongDanShadow.Location = new System.Drawing.Point(818, 78);
			this.pnlHuongDanShadow.Name = "pnlHuongDanShadow";
			this.pnlHuongDanShadow.Size = new System.Drawing.Size(700, 700);
			this.pnlHuongDanShadow.TabIndex = 2;
			// 
			// pnlHuongDan
			// 
			this.pnlHuongDan.BackColor = System.Drawing.Color.White;
			this.pnlHuongDan.Controls.Add(this.btnPreviousHelp);
			this.pnlHuongDan.Controls.Add(this.btnNextHelp);
			this.pnlHuongDan.Controls.Add(this.bP);
			this.pnlHuongDan.Location = new System.Drawing.Point(815, 75);
			this.pnlHuongDan.Name = "pnlHuongDan";
			this.pnlHuongDan.Size = new System.Drawing.Size(700, 700);
			this.pnlHuongDan.TabIndex = 3;
			// 
			// btnPreviousHelp
			// 
			this.btnPreviousHelp.BackColor = System.Drawing.Color.Gray;
			this.btnPreviousHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPreviousHelp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPreviousHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnPreviousHelp.FlatAppearance.BorderSize = 0;
			this.btnPreviousHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPreviousHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
			this.btnPreviousHelp.ForeColor = System.Drawing.Color.White;
			this.btnPreviousHelp.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
			this.btnPreviousHelp.IconColor = System.Drawing.Color.White;
			this.btnPreviousHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPreviousHelp.IconSize = 25;
			this.btnPreviousHelp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPreviousHelp.Location = new System.Drawing.Point(297, 641);
			this.btnPreviousHelp.Name = "btnPreviousHelp";
			this.btnPreviousHelp.Size = new System.Drawing.Size(50, 40);
			this.btnPreviousHelp.TabIndex = 2;
			this.btnPreviousHelp.TabStop = false;
			this.btnPreviousHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPreviousHelp.UseVisualStyleBackColor = false;
			this.btnPreviousHelp.Click += new System.EventHandler(this.btnPreviousHelp_Click);
			this.btnPreviousHelp.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnNextHelp
			// 
			this.btnNextHelp.BackColor = System.Drawing.Color.Gray;
			this.btnNextHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNextHelp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNextHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnNextHelp.FlatAppearance.BorderSize = 0;
			this.btnNextHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNextHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
			this.btnNextHelp.ForeColor = System.Drawing.Color.White;
			this.btnNextHelp.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
			this.btnNextHelp.IconColor = System.Drawing.Color.White;
			this.btnNextHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnNextHelp.IconSize = 25;
			this.btnNextHelp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNextHelp.Location = new System.Drawing.Point(353, 641);
			this.btnNextHelp.Name = "btnNextHelp";
			this.btnNextHelp.Size = new System.Drawing.Size(50, 40);
			this.btnNextHelp.TabIndex = 3;
			this.btnNextHelp.TabStop = false;
			this.btnNextHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnNextHelp.UseVisualStyleBackColor = false;
			this.btnNextHelp.Click += new System.EventHandler(this.btnNextHelp_Click);
			this.btnNextHelp.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// bP
			// 
			this.bP.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.bP.AllowTransitions = false;
			this.bP.Controls.Add(this.addAdmin);
			this.bP.Controls.Add(this.editAdmin);
			this.bP.Controls.Add(this.bkPage1);
			this.bP.Controls.Add(this.bkPage2);
			this.bP.Controls.Add(this.addManager);
			this.bP.Controls.Add(this.editManager);
			this.bP.Controls.Add(this.guide1);
			this.bP.Controls.Add(this.guide2);
			this.bP.Controls.Add(this.guide3);
			this.bP.Controls.Add(this.guide4);
			this.bP.Location = new System.Drawing.Point(6, 6);
			this.bP.Multiline = true;
			this.bP.Name = "bP";
			this.bP.Page = this.addAdmin;
			this.bP.PageIndex = 0;
			this.bP.PageName = "addAdmin";
			this.bP.PageTitle = "AddAdmin";
			this.bP.SelectedIndex = 0;
			this.bP.Size = new System.Drawing.Size(691, 629);
			this.bP.TabIndex = 0;
			animation1.AnimateOnlyDifferences = false;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.bP.Transition = animation1;
			this.bP.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
			// 
			// addAdmin
			// 
			this.addAdmin.BackgroundImage = global::Main.Properties.Resources.AddAdmin;
			this.addAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.addAdmin.Location = new System.Drawing.Point(4, 4);
			this.addAdmin.Name = "addAdmin";
			this.addAdmin.Padding = new System.Windows.Forms.Padding(3);
			this.addAdmin.Size = new System.Drawing.Size(683, 603);
			this.addAdmin.TabIndex = 0;
			this.addAdmin.Text = "AddAdmin";
			this.addAdmin.UseVisualStyleBackColor = true;
			// 
			// editAdmin
			// 
			this.editAdmin.BackgroundImage = global::Main.Properties.Resources.EditAdmin;
			this.editAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.editAdmin.Location = new System.Drawing.Point(4, 4);
			this.editAdmin.Name = "editAdmin";
			this.editAdmin.Padding = new System.Windows.Forms.Padding(3);
			this.editAdmin.Size = new System.Drawing.Size(683, 603);
			this.editAdmin.TabIndex = 1;
			this.editAdmin.Text = "EditAdmin";
			this.editAdmin.UseVisualStyleBackColor = true;
			// 
			// bkPage1
			// 
			this.bkPage1.BackgroundImage = global::Main.Properties.Resources.Backup1;
			this.bkPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bkPage1.Location = new System.Drawing.Point(4, 4);
			this.bkPage1.Name = "bkPage1";
			this.bkPage1.Padding = new System.Windows.Forms.Padding(3);
			this.bkPage1.Size = new System.Drawing.Size(683, 603);
			this.bkPage1.TabIndex = 4;
			this.bkPage1.Text = "BkPage1";
			this.bkPage1.UseVisualStyleBackColor = true;
			// 
			// bkPage2
			// 
			this.bkPage2.BackgroundImage = global::Main.Properties.Resources.Backup2;
			this.bkPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bkPage2.Location = new System.Drawing.Point(4, 4);
			this.bkPage2.Name = "bkPage2";
			this.bkPage2.Padding = new System.Windows.Forms.Padding(3);
			this.bkPage2.Size = new System.Drawing.Size(683, 603);
			this.bkPage2.TabIndex = 5;
			this.bkPage2.Text = "BkPage2";
			this.bkPage2.UseVisualStyleBackColor = true;
			// 
			// addManager
			// 
			this.addManager.BackgroundImage = global::Main.Properties.Resources.AddManager;
			this.addManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.addManager.Location = new System.Drawing.Point(4, 4);
			this.addManager.Name = "addManager";
			this.addManager.Padding = new System.Windows.Forms.Padding(3);
			this.addManager.Size = new System.Drawing.Size(683, 603);
			this.addManager.TabIndex = 2;
			this.addManager.Text = "AddManager";
			this.addManager.UseVisualStyleBackColor = true;
			// 
			// editManager
			// 
			this.editManager.BackgroundImage = global::Main.Properties.Resources.EditAdmin;
			this.editManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.editManager.Location = new System.Drawing.Point(4, 4);
			this.editManager.Name = "editManager";
			this.editManager.Padding = new System.Windows.Forms.Padding(3);
			this.editManager.Size = new System.Drawing.Size(683, 603);
			this.editManager.TabIndex = 3;
			this.editManager.Text = "EditManager";
			this.editManager.UseVisualStyleBackColor = true;
			// 
			// guide1
			// 
			this.guide1.BackgroundImage = global::Main.Properties.Resources.Tutorial1;
			this.guide1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.guide1.Location = new System.Drawing.Point(4, 4);
			this.guide1.Name = "guide1";
			this.guide1.Padding = new System.Windows.Forms.Padding(3);
			this.guide1.Size = new System.Drawing.Size(683, 603);
			this.guide1.TabIndex = 6;
			this.guide1.Text = "Guide1";
			this.guide1.UseVisualStyleBackColor = true;
			// 
			// guide2
			// 
			this.guide2.BackgroundImage = global::Main.Properties.Resources.Tutorial2;
			this.guide2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.guide2.Location = new System.Drawing.Point(4, 4);
			this.guide2.Name = "guide2";
			this.guide2.Padding = new System.Windows.Forms.Padding(3);
			this.guide2.Size = new System.Drawing.Size(683, 603);
			this.guide2.TabIndex = 7;
			this.guide2.Text = "Guide2";
			this.guide2.UseVisualStyleBackColor = true;
			// 
			// guide3
			// 
			this.guide3.BackgroundImage = global::Main.Properties.Resources.Tutorial3;
			this.guide3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.guide3.Location = new System.Drawing.Point(4, 4);
			this.guide3.Name = "guide3";
			this.guide3.Padding = new System.Windows.Forms.Padding(3);
			this.guide3.Size = new System.Drawing.Size(683, 603);
			this.guide3.TabIndex = 8;
			this.guide3.Text = "Guide3";
			this.guide3.UseVisualStyleBackColor = true;
			// 
			// guide4
			// 
			this.guide4.BackgroundImage = global::Main.Properties.Resources.Tutorial4;
			this.guide4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.guide4.Location = new System.Drawing.Point(4, 4);
			this.guide4.Name = "guide4";
			this.guide4.Padding = new System.Windows.Forms.Padding(3);
			this.guide4.Size = new System.Drawing.Size(683, 603);
			this.guide4.TabIndex = 9;
			this.guide4.Text = "Guide4";
			this.guide4.UseVisualStyleBackColor = true;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.lbTitle.Font = new System.Drawing.Font("Verdana", 24F);
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(1100, 20);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(191, 38);
			this.lbTitle.TabIndex = 27;
			this.lbTitle.Text = "Hướng dẫn";
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(1060, 24);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 26;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// pbBackground
			// 
			this.pbBackground.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbBackground.Image = global::Main.Properties.Resources.Background;
			this.pbBackground.Location = new System.Drawing.Point(0, 0);
			this.pbBackground.Name = "pbBackground";
			this.pbBackground.Size = new System.Drawing.Size(1550, 822);
			this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbBackground.TabIndex = 1;
			this.pbBackground.TabStop = false;
			// 
			// Guide
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pnlHuongDan);
			this.Controls.Add(this.pnlHuongDanShadow);
			this.Controls.Add(this.pbBackground);
			this.Name = "Guide";
			this.Size = new System.Drawing.Size(1550, 822);
			this.pnlHuongDan.ResumeLayout(false);
			this.bP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Panel pnlHuongDanShadow;
        private System.Windows.Forms.Panel pnlHuongDan;
        private FontAwesome.Sharp.IconButton iconTitle;
        private System.Windows.Forms.Label lbTitle;
		private Bunifu.UI.WinForms.BunifuPages bP;
		private System.Windows.Forms.TabPage addAdmin;
		private System.Windows.Forms.TabPage editAdmin;
		private System.Windows.Forms.TabPage addManager;
		private System.Windows.Forms.TabPage editManager;
		private System.Windows.Forms.TabPage bkPage1;
		private System.Windows.Forms.TabPage bkPage2;
		private System.Windows.Forms.TabPage guide1;
		private System.Windows.Forms.TabPage guide2;
		private System.Windows.Forms.TabPage guide3;
		private System.Windows.Forms.TabPage guide4;
		private FontAwesome.Sharp.IconButton btnPreviousHelp;
		private FontAwesome.Sharp.IconButton btnNextHelp;
	}
}
