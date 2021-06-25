
namespace QuanLyNhaHang
{
	partial class MainForm
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
			this.btnLogOut = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.btnGoiMon = new System.Windows.Forms.Button();
			this.lvDaChon = new System.Windows.Forms.ListView();
			this.lvMonAn = new System.Windows.Forms.ListView();
			this.tbTongTien = new System.Windows.Forms.TextBox();
			this.lbTongTien = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(713, 12);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(75, 23);
			this.btnLogOut.TabIndex = 0;
			this.btnLogOut.Text = "Đăng xuất";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(713, 415);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(546, 13);
			this.tbUser.Name = "tbUser";
			this.tbUser.ReadOnly = true;
			this.tbUser.Size = new System.Drawing.Size(161, 23);
			this.tbUser.TabIndex = 2;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(713, 85);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(713, 142);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(713, 199);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 5;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(713, 256);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
			this.btnTinhTien.TabIndex = 6;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// btnGoiMon
			// 
			this.btnGoiMon.Location = new System.Drawing.Point(713, 313);
			this.btnGoiMon.Name = "btnGoiMon";
			this.btnGoiMon.Size = new System.Drawing.Size(75, 23);
			this.btnGoiMon.TabIndex = 7;
			this.btnGoiMon.Text = "Gọi món";
			this.btnGoiMon.UseVisualStyleBackColor = true;
			this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
			// 
			// lvDaChon
			// 
			this.lvDaChon.FullRowSelect = true;
			this.lvDaChon.HideSelection = false;
			this.lvDaChon.Location = new System.Drawing.Point(375, 42);
			this.lvDaChon.MultiSelect = false;
			this.lvDaChon.Name = "lvDaChon";
			this.lvDaChon.Size = new System.Drawing.Size(332, 367);
			this.lvDaChon.TabIndex = 8;
			this.lvDaChon.UseCompatibleStateImageBehavior = false;
			this.lvDaChon.View = System.Windows.Forms.View.Details;
			this.lvDaChon.DoubleClick += new System.EventHandler(this.lvDaChon_DoubleClick);
			// 
			// lvMonAn
			// 
			this.lvMonAn.FullRowSelect = true;
			this.lvMonAn.HideSelection = false;
			this.lvMonAn.Location = new System.Drawing.Point(12, 42);
			this.lvMonAn.MultiSelect = false;
			this.lvMonAn.Name = "lvMonAn";
			this.lvMonAn.Size = new System.Drawing.Size(332, 367);
			this.lvMonAn.TabIndex = 9;
			this.lvMonAn.UseCompatibleStateImageBehavior = false;
			this.lvMonAn.View = System.Windows.Forms.View.Details;
			this.lvMonAn.DoubleClick += new System.EventHandler(this.lvMonAn_DoubleClick);
			// 
			// tbTongTien
			// 
			this.tbTongTien.Location = new System.Drawing.Point(546, 415);
			this.tbTongTien.Name = "tbTongTien";
			this.tbTongTien.ReadOnly = true;
			this.tbTongTien.Size = new System.Drawing.Size(161, 23);
			this.tbTongTien.TabIndex = 10;
			this.tbTongTien.Text = "0 VNĐ";
			this.tbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbTongTien
			// 
			this.lbTongTien.AutoSize = true;
			this.lbTongTien.Location = new System.Drawing.Point(375, 418);
			this.lbTongTien.Name = "lbTongTien";
			this.lbTongTien.Size = new System.Drawing.Size(60, 15);
			this.lbTongTien.TabIndex = 11;
			this.lbTongTien.Text = "Tổng tiền:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbTongTien);
			this.Controls.Add(this.tbTongTien);
			this.Controls.Add(this.lvMonAn);
			this.Controls.Add(this.lvDaChon);
			this.Controls.Add(this.btnGoiMon);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogOut);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Button btnGoiMon;
		private System.Windows.Forms.ListView lvDaChon;
		private System.Windows.Forms.ListView lvMonAn;
		private System.Windows.Forms.TextBox tbTongTien;
		private System.Windows.Forms.Label lbTongTien;
	}
}