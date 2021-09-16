
namespace Main
{
    partial class SelectExamForm
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlChonMonThi = new System.Windows.Forms.Panel();
			this.cbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnStartQuiz = new Guna.UI2.WinForms.Guna2Button();
			this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
			this.lbMonThi = new System.Windows.Forms.Label();
			this.lbInform = new System.Windows.Forms.Label();
			this.pnlChonMonThiShadow = new System.Windows.Forms.Panel();
			this.pbChonMonThi = new System.Windows.Forms.PictureBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlChonMonThi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbChonMonThi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(208, 14);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(192, 29);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "CHỌN MÔN THI";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.panel1.Controls.Add(this.lbTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 58);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.pnlChonMonThi);
			this.panel2.Controls.Add(this.pnlChonMonThiShadow);
			this.panel2.Controls.Add(this.pbChonMonThi);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(600, 236);
			this.panel2.TabIndex = 1;
			// 
			// pnlChonMonThi
			// 
			this.pnlChonMonThi.BackColor = System.Drawing.Color.White;
			this.pnlChonMonThi.Controls.Add(this.cbSubject);
			this.pnlChonMonThi.Controls.Add(this.btnStartQuiz);
			this.pnlChonMonThi.Controls.Add(this.btnThoat);
			this.pnlChonMonThi.Controls.Add(this.lbMonThi);
			this.pnlChonMonThi.Controls.Add(this.lbInform);
			this.pnlChonMonThi.Location = new System.Drawing.Point(196, 25);
			this.pnlChonMonThi.Name = "pnlChonMonThi";
			this.pnlChonMonThi.Size = new System.Drawing.Size(375, 190);
			this.pnlChonMonThi.TabIndex = 1;
			// 
			// cbSubject
			// 
			this.cbSubject.BackColor = System.Drawing.Color.White;
			this.cbSubject.BorderColor = System.Drawing.Color.Gray;
			this.cbSubject.BorderRadius = 5;
			this.cbSubject.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubject.FocusedState.Parent = this.cbSubject;
			this.cbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSubject.ForeColor = System.Drawing.Color.Black;
			this.cbSubject.HoverState.Parent = this.cbSubject;
			this.cbSubject.ItemHeight = 30;
			this.cbSubject.ItemsAppearance.Parent = this.cbSubject;
			this.cbSubject.Location = new System.Drawing.Point(87, 86);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.ShadowDecoration.Parent = this.cbSubject;
			this.cbSubject.Size = new System.Drawing.Size(267, 36);
			this.cbSubject.TabIndex = 2;
			this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
			// 
			// btnStartQuiz
			// 
			this.btnStartQuiz.Animated = true;
			this.btnStartQuiz.BackColor = System.Drawing.Color.Transparent;
			this.btnStartQuiz.BorderRadius = 5;
			this.btnStartQuiz.BorderThickness = 1;
			this.btnStartQuiz.CheckedState.Parent = this.btnStartQuiz;
			this.btnStartQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStartQuiz.CustomImages.Parent = this.btnStartQuiz;
			this.btnStartQuiz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnStartQuiz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnStartQuiz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnStartQuiz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnStartQuiz.DisabledState.Parent = this.btnStartQuiz;
			this.btnStartQuiz.FillColor = System.Drawing.Color.White;
			this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartQuiz.ForeColor = System.Drawing.Color.Black;
			this.btnStartQuiz.HoverState.Parent = this.btnStartQuiz;
			this.btnStartQuiz.Location = new System.Drawing.Point(87, 138);
			this.btnStartQuiz.Name = "btnStartQuiz";
			this.btnStartQuiz.ShadowDecoration.Parent = this.btnStartQuiz;
			this.btnStartQuiz.Size = new System.Drawing.Size(110, 35);
			this.btnStartQuiz.TabIndex = 0;
			this.btnStartQuiz.TabStop = false;
			this.btnStartQuiz.Text = "Bắt đầu thi";
			this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Animated = true;
			this.btnThoat.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat.BorderRadius = 5;
			this.btnThoat.BorderThickness = 1;
			this.btnThoat.CheckedState.Parent = this.btnThoat;
			this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThoat.CustomImages.Parent = this.btnThoat;
			this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThoat.DisabledState.Parent = this.btnThoat;
			this.btnThoat.FillColor = System.Drawing.Color.White;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.Black;
			this.btnThoat.HoverState.Parent = this.btnThoat;
			this.btnThoat.Location = new System.Drawing.Point(244, 138);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.ShadowDecoration.Parent = this.btnThoat;
			this.btnThoat.Size = new System.Drawing.Size(110, 35);
			this.btnThoat.TabIndex = 1;
			this.btnThoat.TabStop = false;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// lbMonThi
			// 
			this.lbMonThi.AutoSize = true;
			this.lbMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMonThi.Location = new System.Drawing.Point(10, 95);
			this.lbMonThi.Name = "lbMonThi";
			this.lbMonThi.Size = new System.Drawing.Size(73, 20);
			this.lbMonThi.TabIndex = 3;
			this.lbMonThi.Text = "Môn thi:";
			// 
			// lbInform
			// 
			this.lbInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbInform.Location = new System.Drawing.Point(19, 12);
			this.lbInform.Name = "lbInform";
			this.lbInform.Size = new System.Drawing.Size(337, 66);
			this.lbInform.TabIndex = 4;
			this.lbInform.Text = "Chào Cheems! Hãy lựa chọn môn thi của mình để bắt đầu luyện tập ngay nào! 🙇‍♂️🙇" +
    "‍♂️🙇‍♂️";
			// 
			// pnlChonMonThiShadow
			// 
			this.pnlChonMonThiShadow.BackColor = System.Drawing.Color.Gray;
			this.pnlChonMonThiShadow.Location = new System.Drawing.Point(198, 27);
			this.pnlChonMonThiShadow.Name = "pnlChonMonThiShadow";
			this.pnlChonMonThiShadow.Size = new System.Drawing.Size(375, 190);
			this.pnlChonMonThiShadow.TabIndex = 2;
			// 
			// pbChonMonThi
			// 
			this.pbChonMonThi.Image = global::Main.Properties.Resources.SelectExam;
			this.pbChonMonThi.Location = new System.Drawing.Point(27, 38);
			this.pbChonMonThi.Name = "pbChonMonThi";
			this.pbChonMonThi.Size = new System.Drawing.Size(150, 157);
			this.pbChonMonThi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbChonMonThi.TabIndex = 0;
			this.pbChonMonThi.TabStop = false;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// SelectExamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(600, 300);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SelectExamForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SelectExamForm";
			this.Load += new System.EventHandler(this.FrmSelectExam_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.pnlChonMonThi.ResumeLayout(false);
			this.pnlChonMonThi.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbChonMonThi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbChonMonThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlChonMonThi;
        private System.Windows.Forms.Label lbMonThi;
        private System.Windows.Forms.Label lbInform;
        private System.Windows.Forms.Panel pnlChonMonThiShadow;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        public Guna.UI2.WinForms.Guna2Button btnStartQuiz;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubject;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
	}
}