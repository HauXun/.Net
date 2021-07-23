
namespace ShutDownTimer
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.nudGio = new System.Windows.Forms.NumericUpDown();
			this.nudGiay = new System.Windows.Forms.NumericUpDown();
			this.nudPhut = new System.Windows.Forms.NumericUpDown();
			this.lbGio = new System.Windows.Forms.Label();
			this.lbPhut = new System.Windows.Forms.Label();
			this.lbGiay = new System.Windows.Forms.Label();
			this.btnShutDown = new System.Windows.Forms.Button();
			this.btnResetart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nudGio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudGiay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPhut)).BeginInit();
			this.SuspendLayout();
			// 
			// nudGio
			// 
			this.nudGio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudGio.Location = new System.Drawing.Point(12, 12);
			this.nudGio.Name = "nudGio";
			this.nudGio.Size = new System.Drawing.Size(41, 23);
			this.nudGio.TabIndex = 1;
			// 
			// nudGiay
			// 
			this.nudGiay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudGiay.Location = new System.Drawing.Point(197, 12);
			this.nudGiay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.nudGiay.Name = "nudGiay";
			this.nudGiay.Size = new System.Drawing.Size(41, 23);
			this.nudGiay.TabIndex = 2;
			this.nudGiay.ValueChanged += new System.EventHandler(this.nudGiay_ValueChanged);
			// 
			// nudPhut
			// 
			this.nudPhut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPhut.Location = new System.Drawing.Point(101, 12);
			this.nudPhut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.nudPhut.Name = "nudPhut";
			this.nudPhut.Size = new System.Drawing.Size(41, 23);
			this.nudPhut.TabIndex = 3;
			this.nudPhut.ValueChanged += new System.EventHandler(this.nudPhut_ValueChanged);
			// 
			// lbGio
			// 
			this.lbGio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbGio.Location = new System.Drawing.Point(59, 20);
			this.lbGio.Name = "lbGio";
			this.lbGio.Size = new System.Drawing.Size(25, 15);
			this.lbGio.TabIndex = 4;
			this.lbGio.Text = "Giờ";
			// 
			// lbPhut
			// 
			this.lbPhut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbPhut.Location = new System.Drawing.Point(148, 21);
			this.lbPhut.Name = "lbPhut";
			this.lbPhut.Size = new System.Drawing.Size(32, 15);
			this.lbPhut.TabIndex = 5;
			this.lbPhut.Text = "Phút";
			// 
			// lbGiay
			// 
			this.lbGiay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbGiay.Location = new System.Drawing.Point(244, 21);
			this.lbGiay.Name = "lbGiay";
			this.lbGiay.Size = new System.Drawing.Size(30, 15);
			this.lbGiay.TabIndex = 6;
			this.lbGiay.Text = "Giây";
			// 
			// btnShutDown
			// 
			this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShutDown.Location = new System.Drawing.Point(12, 51);
			this.btnShutDown.Name = "btnShutDown";
			this.btnShutDown.Size = new System.Drawing.Size(75, 25);
			this.btnShutDown.TabIndex = 7;
			this.btnShutDown.Text = "ShutDown";
			this.btnShutDown.UseVisualStyleBackColor = true;
			this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
			// 
			// btnResetart
			// 
			this.btnResetart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetart.Location = new System.Drawing.Point(102, 51);
			this.btnResetart.Name = "btnResetart";
			this.btnResetart.Size = new System.Drawing.Size(75, 25);
			this.btnResetart.TabIndex = 8;
			this.btnResetart.Text = "Resetart";
			this.btnResetart.UseVisualStyleBackColor = true;
			this.btnResetart.Click += new System.EventHandler(this.btnResetart_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(192, 51);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 25);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 102);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnResetart);
			this.Controls.Add(this.btnShutDown);
			this.Controls.Add(this.lbGiay);
			this.Controls.Add(this.lbPhut);
			this.Controls.Add(this.lbGio);
			this.Controls.Add(this.nudPhut);
			this.Controls.Add(this.nudGiay);
			this.Controls.Add(this.nudGio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudGio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudGiay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPhut)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudGio;
		private System.Windows.Forms.NumericUpDown nudGiay;
		private System.Windows.Forms.NumericUpDown nudPhut;
		private System.Windows.Forms.Label lbGio;
		private System.Windows.Forms.Label lbPhut;
		private System.Windows.Forms.Label lbGiay;
		private System.Windows.Forms.Button btnShutDown;
		private System.Windows.Forms.Button btnResetart;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Timer timer1;
	}
}

