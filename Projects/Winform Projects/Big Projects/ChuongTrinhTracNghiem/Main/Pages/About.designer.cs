
namespace Main.Pages
{
	partial class About
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlAboutUs = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.iconTitle = new FontAwesome.Sharp.IconButton();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pnlAboutUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.lbTitle.Location = new System.Drawing.Point(1108, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(145, 37);
            this.lbTitle.TabIndex = 29;
            this.lbTitle.Text = "About us";
            this.lbTitle.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // pnlAboutUs
            // 
            this.pnlAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.pnlAboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAboutUs.Controls.Add(this.pictureBox);
            this.pnlAboutUs.FillColor = System.Drawing.Color.White;
            this.pnlAboutUs.Location = new System.Drawing.Point(815, 75);
            this.pnlAboutUs.Name = "pnlAboutUs";
            this.pnlAboutUs.Radius = 5;
            this.pnlAboutUs.ShadowColor = System.Drawing.Color.Black;
            this.pnlAboutUs.ShadowDepth = 255;
            this.pnlAboutUs.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlAboutUs.Size = new System.Drawing.Size(700, 700);
            this.pnlAboutUs.TabIndex = 30;
            this.pnlAboutUs.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Main.Properties.Resources.AboutUs;
            this.pictureBox.Location = new System.Drawing.Point(2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(690, 690);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.iconTitle.FlatAppearance.BorderSize = 0;
            this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Rocketchat;
            this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 35;
            this.iconTitle.Location = new System.Drawing.Point(1068, 24);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(35, 37);
            this.iconTitle.TabIndex = 28;
            this.iconTitle.TabStop = false;
            this.iconTitle.UseVisualStyleBackColor = false;
            this.iconTitle.Click += new System.EventHandler(this.pbBackground_Click);
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
            this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // About
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnlAboutUs);
            this.Controls.Add(this.iconTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbBackground);
            this.Name = "About";
            this.Size = new System.Drawing.Size(1550, 822);
            this.pnlAboutUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private FontAwesome.Sharp.IconButton iconTitle;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlAboutUs;
		private System.Windows.Forms.PictureBox pictureBox;
	}
}
