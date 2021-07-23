
namespace FlyingBird
{
	partial class Main
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
			this.pbBird1 = new System.Windows.Forms.PictureBox();
			this.PlayerAnimation = new System.Windows.Forms.Timer(this.components);
			this.RocketMoverment = new System.Windows.Forms.Timer(this.components);
			this.AutoSpawn = new System.Windows.Forms.Timer(this.components);
			this.lbScore = new System.Windows.Forms.Label();
			this.Point = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbBird1)).BeginInit();
			this.SuspendLayout();
			// 
			// pbBird1
			// 
			this.pbBird1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbBird1.BackColor = System.Drawing.Color.Transparent;
			this.pbBird1.Image = global::FlyingBird.Properties.Resources.Bird;
			this.pbBird1.Location = new System.Drawing.Point(377, 264);
			this.pbBird1.Name = "pbBird1";
			this.pbBird1.Size = new System.Drawing.Size(73, 67);
			this.pbBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbBird1.TabIndex = 0;
			this.pbBird1.TabStop = false;
			// 
			// PlayerAnimation
			// 
			this.PlayerAnimation.Enabled = true;
			this.PlayerAnimation.Interval = 50;
			this.PlayerAnimation.Tick += new System.EventHandler(this.PlayerAnimation_Tick);
			// 
			// RocketMoverment
			// 
			this.RocketMoverment.Enabled = true;
			this.RocketMoverment.Tick += new System.EventHandler(this.RocketMoverment_Tick);
			// 
			// AutoSpawn
			// 
			this.AutoSpawn.Enabled = true;
			this.AutoSpawn.Interval = 2000;
			this.AutoSpawn.Tick += new System.EventHandler(this.AutoSpawn_Tick);
			// 
			// lbScore
			// 
			this.lbScore.AutoSize = true;
			this.lbScore.Location = new System.Drawing.Point(840, 9);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(13, 13);
			this.lbScore.TabIndex = 1;
			this.lbScore.Text = "0";
			// 
			// Point
			// 
			this.Point.Enabled = true;
			this.Point.Interval = 1000;
			this.Point.Tick += new System.EventHandler(this.Point_Tick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FlyingBird.Properties.Resources.SkySprite;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(887, 519);
			this.Controls.Add(this.lbScore);
			this.Controls.Add(this.pbBird1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Main";
			this.Text = "Flying Bird";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pbBird1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbBird1;
		private System.Windows.Forms.Timer PlayerAnimation;
		private System.Windows.Forms.Timer RocketMoverment;
		private System.Windows.Forms.Timer AutoSpawn;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Timer Point;
	}
}