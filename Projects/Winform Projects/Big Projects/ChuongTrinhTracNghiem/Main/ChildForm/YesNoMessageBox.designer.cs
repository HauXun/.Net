
namespace Main
{
	partial class YesNoMessageBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesNoMessageBox));
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btnYes = new FontAwesome.Sharp.IconButton();
			this.btnNo = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.iconMessage = new FontAwesome.Sharp.IconPictureBox();
			this.lbMessage = new System.Windows.Forms.Label();
			this.guna2ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.pnlTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconMessage)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitle
			// 
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.pnlTitle.Controls.Add(this.lbTitle);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(450, 35);
			this.pnlTitle.TabIndex = 2;
			this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControlBox_MouseDown);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(19, 8);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(0, 18);
			this.lbTitle.TabIndex = 0;
			// 
			// btnYes
			// 
			this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnYes.BackColor = System.Drawing.Color.White;
			this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnYes.ForeColor = System.Drawing.Color.Green;
			this.btnYes.IconChar = FontAwesome.Sharp.IconChar.Check;
			this.btnYes.IconColor = System.Drawing.Color.Green;
			this.btnYes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnYes.IconSize = 25;
			this.btnYes.Location = new System.Drawing.Point(272, 158);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(80, 30);
			this.btnYes.TabIndex = 1;
			this.btnYes.TabStop = false;
			this.btnYes.Text = "Yes";
			this.btnYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnYes.UseVisualStyleBackColor = false;
			this.btnYes.Enter += new System.EventHandler(this.btnNo_Enter);
			// 
			// btnNo
			// 
			this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnNo.BackColor = System.Drawing.Color.White;
			this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNo.ForeColor = System.Drawing.Color.Firebrick;
			this.btnNo.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.btnNo.IconColor = System.Drawing.Color.Firebrick;
			this.btnNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnNo.IconSize = 25;
			this.btnNo.Location = new System.Drawing.Point(358, 158);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(80, 30);
			this.btnNo.TabIndex = 0;
			this.btnNo.TabStop = false;
			this.btnNo.Text = "No";
			this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Enter += new System.EventHandler(this.btnNo_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(71, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Thông báo!";
			// 
			// iconMessage
			// 
			this.iconMessage.BackColor = System.Drawing.Color.Transparent;
			this.iconMessage.ForeColor = System.Drawing.Color.DimGray;
			this.iconMessage.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
			this.iconMessage.IconColor = System.Drawing.Color.DimGray;
			this.iconMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconMessage.Location = new System.Drawing.Point(23, 44);
			this.iconMessage.Name = "iconMessage";
			this.iconMessage.Size = new System.Drawing.Size(32, 32);
			this.iconMessage.TabIndex = 11;
			this.iconMessage.TabStop = false;
			// 
			// lbMessage
			// 
			this.lbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lbMessage.BackColor = System.Drawing.Color.Transparent;
			this.lbMessage.Font = new System.Drawing.Font("Arial", 12F);
			this.lbMessage.ForeColor = System.Drawing.Color.Black;
			this.lbMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbMessage.Location = new System.Drawing.Point(12, 90);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.lbMessage.Size = new System.Drawing.Size(426, 55);
			this.lbMessage.TabIndex = 4;
			// 
			// guna2ShadowForm
			// 
			this.guna2ShadowForm.TargetForm = this;
			// 
			// YesNoMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(450, 200);
			this.Controls.Add(this.btnYes);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.iconMessage);
			this.Controls.Add(this.lbMessage);
			this.Controls.Add(this.pnlTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "YesNoMessageBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Amazing Quiz Application";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.YesNoMessageBox_Shown);
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconMessage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Panel pnlTitle;
		public System.Windows.Forms.Label lbTitle;
		public FontAwesome.Sharp.IconButton btnYes;
		public FontAwesome.Sharp.IconButton btnNo;
		private System.Windows.Forms.Label label1;
		public FontAwesome.Sharp.IconPictureBox iconMessage;
		public System.Windows.Forms.Label lbMessage;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm;
	}
}