
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
			this.pbBackground = new System.Windows.Forms.PictureBox();
			this.pnlHuongDanShadow = new System.Windows.Forms.Panel();
			this.pnlHuongDan = new System.Windows.Forms.Panel();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.lbTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
			this.SuspendLayout();
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
			this.pnlHuongDan.Location = new System.Drawing.Point(815, 75);
			this.pnlHuongDan.Name = "pnlHuongDan";
			this.pnlHuongDan.Size = new System.Drawing.Size(700, 700);
			this.pnlHuongDan.TabIndex = 3;
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
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(1100, 21);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(175, 37);
			this.lbTitle.TabIndex = 27;
			this.lbTitle.Text = "Hướng dẫn";
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
    }
}
