
using System.Drawing;

namespace Main.Pages
{
	partial class MainMenu
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
			this.pbBackground = new System.Windows.Forms.PictureBox();
			this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTaiKhoanNguoiDung = new System.Windows.Forms.Label();
			this.pnlTopNguoiDung = new System.Windows.Forms.Panel();
			this.btnThongTinChiTiet = new Guna.UI2.WinForms.Guna2Button();
			this.lbDieuHuong = new System.Windows.Forms.Label();
			this.btnThiNgay = new FontAwesome.Sharp.IconButton();
			this.btnHuongDanThi = new FontAwesome.Sharp.IconButton();
			this.btnBangXepHang = new FontAwesome.Sharp.IconButton();
			this.pnlThongTinShadow = new System.Windows.Forms.Panel();
			this.pnlNguoiDung = new System.Windows.Forms.Panel();
			this.gbUser = new Guna.UI2.WinForms.Guna2GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDangXuatNguoiDung = new Guna.UI2.WinForms.Guna2Button();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.gbAdmin = new Guna.UI2.WinForms.Guna2GroupBox();
			this.tbAdmin = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTaiKhoanAdmin = new System.Windows.Forms.Label();
			this.btnQuanLyLop = new FontAwesome.Sharp.IconButton();
			this.btnQuanLyNguoiDung = new FontAwesome.Sharp.IconButton();
			this.btnQuanLyKhoa = new FontAwesome.Sharp.IconButton();
			this.btnQuanLyKhoaHoc = new FontAwesome.Sharp.IconButton();
			this.pnlBottomAdmin = new System.Windows.Forms.Panel();
			this.btnDangXuatAdmin = new Guna.UI2.WinForms.Guna2Button();
			this.pnlTopAdmin = new System.Windows.Forms.Panel();
			this.btnKhoiPhucDuLieu = new Guna.UI2.WinForms.Guna2Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlGiaoVien = new System.Windows.Forms.Panel();
			this.gbManager = new Guna.UI2.WinForms.Guna2GroupBox();
			this.lbTaiKhoanManager = new System.Windows.Forms.Label();
			this.btnStatiscicalMark = new FontAwesome.Sharp.IconButton();
			this.tbManager = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnQuanLyMonThi = new FontAwesome.Sharp.IconButton();
			this.btnQuanLyCauHoi = new FontAwesome.Sharp.IconButton();
			this.btnQuanLyDeThi = new FontAwesome.Sharp.IconButton();
			this.pnlBottomGiaoVien = new System.Windows.Forms.Panel();
			this.btnDangXuatGiaoVien = new Guna.UI2.WinForms.Guna2Button();
			this.pnlTopGiaoVien = new System.Windows.Forms.Panel();
			this.btnTroGiup = new Guna.UI2.WinForms.Guna2Button();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
			this.pnlTopNguoiDung.SuspendLayout();
			this.pnlNguoiDung.SuspendLayout();
			this.gbUser.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlAdmin.SuspendLayout();
			this.gbAdmin.SuspendLayout();
			this.pnlBottomAdmin.SuspendLayout();
			this.pnlTopAdmin.SuspendLayout();
			this.pnlGiaoVien.SuspendLayout();
			this.gbManager.SuspendLayout();
			this.pnlBottomGiaoVien.SuspendLayout();
			this.pnlTopGiaoVien.SuspendLayout();
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
			this.pbBackground.TabIndex = 0;
			this.pbBackground.TabStop = false;
			this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// tbID
			// 
			this.tbID.BorderColor = System.Drawing.Color.Gray;
			this.tbID.BorderRadius = 5;
			this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbID.DefaultText = "";
			this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbID.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbID.DisabledState.Parent = this.tbID;
			this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbID.Enabled = false;
			this.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbID.FocusedState.Parent = this.tbID;
			this.tbID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbID.ForeColor = System.Drawing.Color.Black;
			this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbID.HoverState.Parent = this.tbID;
			this.tbID.Location = new System.Drawing.Point(155, 132);
			this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbID.Name = "tbID";
			this.tbID.PasswordChar = '\0';
			this.tbID.PlaceholderText = "";
			this.tbID.ReadOnly = true;
			this.tbID.SelectedText = "";
			this.tbID.ShadowDecoration.Parent = this.tbID;
			this.tbID.Size = new System.Drawing.Size(300, 36);
			this.tbID.TabIndex = 16;
			this.tbID.TabStop = false;
			this.tbID.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// tbTaiKhoan
			// 
			this.tbTaiKhoan.BorderColor = System.Drawing.Color.Gray;
			this.tbTaiKhoan.BorderRadius = 5;
			this.tbTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbTaiKhoan.DefaultText = "";
			this.tbTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbTaiKhoan.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbTaiKhoan.DisabledState.Parent = this.tbTaiKhoan;
			this.tbTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbTaiKhoan.Enabled = false;
			this.tbTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbTaiKhoan.FocusedState.Parent = this.tbTaiKhoan;
			this.tbTaiKhoan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTaiKhoan.ForeColor = System.Drawing.Color.Black;
			this.tbTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbTaiKhoan.HoverState.Parent = this.tbTaiKhoan;
			this.tbTaiKhoan.Location = new System.Drawing.Point(155, 88);
			this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbTaiKhoan.Name = "tbTaiKhoan";
			this.tbTaiKhoan.PasswordChar = '\0';
			this.tbTaiKhoan.PlaceholderText = "";
			this.tbTaiKhoan.ReadOnly = true;
			this.tbTaiKhoan.SelectedText = "";
			this.tbTaiKhoan.ShadowDecoration.Parent = this.tbTaiKhoan;
			this.tbTaiKhoan.Size = new System.Drawing.Size(300, 36);
			this.tbTaiKhoan.TabIndex = 15;
			this.tbTaiKhoan.TabStop = false;
			this.tbTaiKhoan.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// lbTaiKhoanNguoiDung
			// 
			this.lbTaiKhoanNguoiDung.AutoSize = true;
			this.lbTaiKhoanNguoiDung.BackColor = System.Drawing.Color.Transparent;
			this.lbTaiKhoanNguoiDung.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTaiKhoanNguoiDung.ForeColor = System.Drawing.Color.Black;
			this.lbTaiKhoanNguoiDung.Location = new System.Drawing.Point(160, 59);
			this.lbTaiKhoanNguoiDung.Name = "lbTaiKhoanNguoiDung";
			this.lbTaiKhoanNguoiDung.Size = new System.Drawing.Size(125, 25);
			this.lbTaiKhoanNguoiDung.TabIndex = 12;
			this.lbTaiKhoanNguoiDung.Text = "Tài khoản:";
			this.lbTaiKhoanNguoiDung.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// pnlTopNguoiDung
			// 
			this.pnlTopNguoiDung.BackColor = System.Drawing.Color.White;
			this.pnlTopNguoiDung.Controls.Add(this.btnThongTinChiTiet);
			this.pnlTopNguoiDung.Controls.Add(this.lbDieuHuong);
			this.pnlTopNguoiDung.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlTopNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopNguoiDung.Location = new System.Drawing.Point(0, 0);
			this.pnlTopNguoiDung.Name = "pnlTopNguoiDung";
			this.pnlTopNguoiDung.Size = new System.Drawing.Size(650, 48);
			this.pnlTopNguoiDung.TabIndex = 18;
			this.pnlTopNguoiDung.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnThongTinChiTiet
			// 
			this.btnThongTinChiTiet.Animated = true;
			this.btnThongTinChiTiet.BackColor = System.Drawing.Color.Transparent;
			this.btnThongTinChiTiet.BorderColor = System.Drawing.Color.Transparent;
			this.btnThongTinChiTiet.BorderRadius = 5;
			this.btnThongTinChiTiet.BorderThickness = 1;
			this.btnThongTinChiTiet.CheckedState.Parent = this.btnThongTinChiTiet;
			this.btnThongTinChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThongTinChiTiet.CustomImages.Parent = this.btnThongTinChiTiet;
			this.btnThongTinChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThongTinChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThongTinChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThongTinChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThongTinChiTiet.DisabledState.Parent = this.btnThongTinChiTiet;
			this.btnThongTinChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnThongTinChiTiet.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongTinChiTiet.ForeColor = System.Drawing.Color.White;
			this.btnThongTinChiTiet.HoverState.Parent = this.btnThongTinChiTiet;
			this.btnThongTinChiTiet.Location = new System.Drawing.Point(464, 5);
			this.btnThongTinChiTiet.Name = "btnThongTinChiTiet";
			this.btnThongTinChiTiet.ShadowDecoration.Parent = this.btnThongTinChiTiet;
			this.btnThongTinChiTiet.Size = new System.Drawing.Size(163, 38);
			this.btnThongTinChiTiet.TabIndex = 0;
			this.btnThongTinChiTiet.TabStop = false;
			this.btnThongTinChiTiet.Text = "Thông tin chi tiết";
			this.btnThongTinChiTiet.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// lbDieuHuong
			// 
			this.lbDieuHuong.AutoSize = true;
			this.lbDieuHuong.BackColor = System.Drawing.Color.White;
			this.lbDieuHuong.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbDieuHuong.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDieuHuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbDieuHuong.Location = new System.Drawing.Point(25, 7);
			this.lbDieuHuong.Name = "lbDieuHuong";
			this.lbDieuHuong.Size = new System.Drawing.Size(174, 32);
			this.lbDieuHuong.TabIndex = 11;
			this.lbDieuHuong.Text = "Điều Hướng";
			this.lbDieuHuong.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnThiNgay
			// 
			this.btnThiNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnThiNgay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThiNgay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnThiNgay.FlatAppearance.BorderSize = 0;
			this.btnThiNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThiNgay.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThiNgay.ForeColor = System.Drawing.Color.White;
			this.btnThiNgay.IconChar = FontAwesome.Sharp.IconChar.Clock;
			this.btnThiNgay.IconColor = System.Drawing.Color.White;
			this.btnThiNgay.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnThiNgay.IconSize = 40;
			this.btnThiNgay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThiNgay.Location = new System.Drawing.Point(5, 191);
			this.btnThiNgay.Name = "btnThiNgay";
			this.btnThiNgay.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
			this.btnThiNgay.Size = new System.Drawing.Size(590, 55);
			this.btnThiNgay.TabIndex = 22;
			this.btnThiNgay.TabStop = false;
			this.btnThiNgay.Text = "Thi ngay";
			this.btnThiNgay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThiNgay.UseVisualStyleBackColor = false;
			this.btnThiNgay.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// btnHuongDanThi
			// 
			this.btnHuongDanThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnHuongDanThi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHuongDanThi.FlatAppearance.BorderSize = 0;
			this.btnHuongDanThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHuongDanThi.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuongDanThi.ForeColor = System.Drawing.Color.White;
			this.btnHuongDanThi.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
			this.btnHuongDanThi.IconColor = System.Drawing.Color.White;
			this.btnHuongDanThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnHuongDanThi.IconSize = 40;
			this.btnHuongDanThi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHuongDanThi.Location = new System.Drawing.Point(5, 313);
			this.btnHuongDanThi.Name = "btnHuongDanThi";
			this.btnHuongDanThi.Padding = new System.Windows.Forms.Padding(155, 0, 0, 0);
			this.btnHuongDanThi.Size = new System.Drawing.Size(590, 55);
			this.btnHuongDanThi.TabIndex = 24;
			this.btnHuongDanThi.TabStop = false;
			this.btnHuongDanThi.Text = "Hướng dẫn thi";
			this.btnHuongDanThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHuongDanThi.UseVisualStyleBackColor = false;
			this.btnHuongDanThi.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// btnBangXepHang
			// 
			this.btnBangXepHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(127)))), ((int)(((byte)(210)))));
			this.btnBangXepHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBangXepHang.FlatAppearance.BorderSize = 0;
			this.btnBangXepHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBangXepHang.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBangXepHang.ForeColor = System.Drawing.Color.White;
			this.btnBangXepHang.IconChar = FontAwesome.Sharp.IconChar.ListOl;
			this.btnBangXepHang.IconColor = System.Drawing.Color.White;
			this.btnBangXepHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnBangXepHang.IconSize = 40;
			this.btnBangXepHang.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBangXepHang.Location = new System.Drawing.Point(5, 252);
			this.btnBangXepHang.Name = "btnBangXepHang";
			this.btnBangXepHang.Padding = new System.Windows.Forms.Padding(160, 0, 0, 0);
			this.btnBangXepHang.Size = new System.Drawing.Size(590, 55);
			this.btnBangXepHang.TabIndex = 23;
			this.btnBangXepHang.TabStop = false;
			this.btnBangXepHang.Text = "Bảng xếp hạng";
			this.btnBangXepHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBangXepHang.UseVisualStyleBackColor = false;
			this.btnBangXepHang.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// pnlThongTinShadow
			// 
			this.pnlThongTinShadow.BackColor = System.Drawing.Color.Gray;
			this.pnlThongTinShadow.Location = new System.Drawing.Point(839, 165);
			this.pnlThongTinShadow.Name = "pnlThongTinShadow";
			this.pnlThongTinShadow.Size = new System.Drawing.Size(654, 492);
			this.pnlThongTinShadow.TabIndex = 2;
			this.pnlThongTinShadow.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// pnlNguoiDung
			// 
			this.pnlNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.pnlNguoiDung.Controls.Add(this.gbUser);
			this.pnlNguoiDung.Controls.Add(this.panel1);
			this.pnlNguoiDung.Controls.Add(this.pnlTopNguoiDung);
			this.pnlNguoiDung.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlNguoiDung.Location = new System.Drawing.Point(840, 166);
			this.pnlNguoiDung.Name = "pnlNguoiDung";
			this.pnlNguoiDung.Size = new System.Drawing.Size(650, 488);
			this.pnlNguoiDung.TabIndex = 1;
			this.pnlNguoiDung.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// gbUser
			// 
			this.gbUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.gbUser.BorderRadius = 5;
			this.gbUser.Controls.Add(this.tbID);
			this.gbUser.Controls.Add(this.tbTaiKhoan);
			this.gbUser.Controls.Add(this.lbTaiKhoanNguoiDung);
			this.gbUser.Controls.Add(this.btnThiNgay);
			this.gbUser.Controls.Add(this.btnHuongDanThi);
			this.gbUser.Controls.Add(this.btnBangXepHang);
			this.gbUser.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.gbUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.gbUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbUser.ForeColor = System.Drawing.Color.White;
			this.gbUser.Location = new System.Drawing.Point(25, 57);
			this.gbUser.Name = "gbUser";
			this.gbUser.ShadowDecoration.Parent = this.gbUser;
			this.gbUser.Size = new System.Drawing.Size(600, 374);
			this.gbUser.TabIndex = 29;
			this.gbUser.Text = "User";
			this.gbUser.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnDangXuatNguoiDung);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 440);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(650, 48);
			this.panel1.TabIndex = 28;
			this.panel1.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnDangXuatNguoiDung
			// 
			this.btnDangXuatNguoiDung.Animated = true;
			this.btnDangXuatNguoiDung.BackColor = System.Drawing.Color.Transparent;
			this.btnDangXuatNguoiDung.BorderColor = System.Drawing.Color.Transparent;
			this.btnDangXuatNguoiDung.BorderRadius = 5;
			this.btnDangXuatNguoiDung.BorderThickness = 1;
			this.btnDangXuatNguoiDung.CheckedState.Parent = this.btnDangXuatNguoiDung;
			this.btnDangXuatNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDangXuatNguoiDung.CustomImages.Parent = this.btnDangXuatNguoiDung;
			this.btnDangXuatNguoiDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuatNguoiDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuatNguoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDangXuatNguoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDangXuatNguoiDung.DisabledState.Parent = this.btnDangXuatNguoiDung;
			this.btnDangXuatNguoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnDangXuatNguoiDung.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangXuatNguoiDung.ForeColor = System.Drawing.Color.White;
			this.btnDangXuatNguoiDung.HoverState.Parent = this.btnDangXuatNguoiDung;
			this.btnDangXuatNguoiDung.Location = new System.Drawing.Point(523, 5);
			this.btnDangXuatNguoiDung.Name = "btnDangXuatNguoiDung";
			this.btnDangXuatNguoiDung.ShadowDecoration.Parent = this.btnDangXuatNguoiDung;
			this.btnDangXuatNguoiDung.Size = new System.Drawing.Size(104, 38);
			this.btnDangXuatNguoiDung.TabIndex = 0;
			this.btnDangXuatNguoiDung.TabStop = false;
			this.btnDangXuatNguoiDung.Text = "Đăng xuất";
			this.btnDangXuatNguoiDung.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// pnlAdmin
			// 
			this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.pnlAdmin.Controls.Add(this.gbAdmin);
			this.pnlAdmin.Controls.Add(this.pnlBottomAdmin);
			this.pnlAdmin.Controls.Add(this.pnlTopAdmin);
			this.pnlAdmin.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlAdmin.Location = new System.Drawing.Point(840, 166);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(650, 488);
			this.pnlAdmin.TabIndex = 37;
			this.pnlAdmin.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// gbAdmin
			// 
			this.gbAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.gbAdmin.BorderRadius = 5;
			this.gbAdmin.Controls.Add(this.tbAdmin);
			this.gbAdmin.Controls.Add(this.lbTaiKhoanAdmin);
			this.gbAdmin.Controls.Add(this.btnQuanLyLop);
			this.gbAdmin.Controls.Add(this.btnQuanLyNguoiDung);
			this.gbAdmin.Controls.Add(this.btnQuanLyKhoa);
			this.gbAdmin.Controls.Add(this.btnQuanLyKhoaHoc);
			this.gbAdmin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.gbAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.gbAdmin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAdmin.ForeColor = System.Drawing.Color.White;
			this.gbAdmin.Location = new System.Drawing.Point(25, 57);
			this.gbAdmin.Name = "gbAdmin";
			this.gbAdmin.ShadowDecoration.Parent = this.gbAdmin;
			this.gbAdmin.Size = new System.Drawing.Size(600, 374);
			this.gbAdmin.TabIndex = 28;
			this.gbAdmin.Text = "Admin";
			this.gbAdmin.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// tbAdmin
			// 
			this.tbAdmin.BorderColor = System.Drawing.Color.Gray;
			this.tbAdmin.BorderRadius = 5;
			this.tbAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAdmin.DefaultText = "";
			this.tbAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAdmin.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAdmin.DisabledState.Parent = this.tbAdmin;
			this.tbAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAdmin.Enabled = false;
			this.tbAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAdmin.FocusedState.Parent = this.tbAdmin;
			this.tbAdmin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAdmin.ForeColor = System.Drawing.Color.Black;
			this.tbAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAdmin.HoverState.Parent = this.tbAdmin;
			this.tbAdmin.Location = new System.Drawing.Point(150, 80);
			this.tbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbAdmin.Name = "tbAdmin";
			this.tbAdmin.PasswordChar = '\0';
			this.tbAdmin.PlaceholderText = "";
			this.tbAdmin.ReadOnly = true;
			this.tbAdmin.SelectedText = "";
			this.tbAdmin.ShadowDecoration.Parent = this.tbAdmin;
			this.tbAdmin.Size = new System.Drawing.Size(300, 36);
			this.tbAdmin.TabIndex = 14;
			this.tbAdmin.TabStop = false;
			this.tbAdmin.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// lbTaiKhoanAdmin
			// 
			this.lbTaiKhoanAdmin.AutoSize = true;
			this.lbTaiKhoanAdmin.BackColor = System.Drawing.Color.Transparent;
			this.lbTaiKhoanAdmin.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTaiKhoanAdmin.ForeColor = System.Drawing.Color.Black;
			this.lbTaiKhoanAdmin.Location = new System.Drawing.Point(155, 51);
			this.lbTaiKhoanAdmin.Name = "lbTaiKhoanAdmin";
			this.lbTaiKhoanAdmin.Size = new System.Drawing.Size(125, 25);
			this.lbTaiKhoanAdmin.TabIndex = 12;
			this.lbTaiKhoanAdmin.Text = "Tài khoản:";
			this.lbTaiKhoanAdmin.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnQuanLyLop
			// 
			this.btnQuanLyLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(87)))), ((int)(((byte)(170)))));
			this.btnQuanLyLop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyLop.FlatAppearance.BorderSize = 0;
			this.btnQuanLyLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyLop.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyLop.ForeColor = System.Drawing.Color.White;
			this.btnQuanLyLop.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
			this.btnQuanLyLop.IconColor = System.Drawing.Color.White;
			this.btnQuanLyLop.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnQuanLyLop.IconSize = 40;
			this.btnQuanLyLop.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnQuanLyLop.Location = new System.Drawing.Point(5, 313);
			this.btnQuanLyLop.Name = "btnQuanLyLop";
			this.btnQuanLyLop.Padding = new System.Windows.Forms.Padding(79, 0, 0, 0);
			this.btnQuanLyLop.Size = new System.Drawing.Size(590, 55);
			this.btnQuanLyLop.TabIndex = 25;
			this.btnQuanLyLop.TabStop = false;
			this.btnQuanLyLop.Text = "Quản lý lớp";
			this.btnQuanLyLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyLop.UseVisualStyleBackColor = false;
			this.btnQuanLyLop.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// btnQuanLyNguoiDung
			// 
			this.btnQuanLyNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnQuanLyNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyNguoiDung.FlatAppearance.BorderSize = 0;
			this.btnQuanLyNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyNguoiDung.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyNguoiDung.ForeColor = System.Drawing.Color.White;
			this.btnQuanLyNguoiDung.IconChar = FontAwesome.Sharp.IconChar.User;
			this.btnQuanLyNguoiDung.IconColor = System.Drawing.Color.White;
			this.btnQuanLyNguoiDung.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnQuanLyNguoiDung.IconSize = 40;
			this.btnQuanLyNguoiDung.Location = new System.Drawing.Point(5, 130);
			this.btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
			this.btnQuanLyNguoiDung.Padding = new System.Windows.Forms.Padding(110, 0, 0, 0);
			this.btnQuanLyNguoiDung.Size = new System.Drawing.Size(590, 55);
			this.btnQuanLyNguoiDung.TabIndex = 22;
			this.btnQuanLyNguoiDung.TabStop = false;
			this.btnQuanLyNguoiDung.Text = "Quản lý tài khoản";
			this.btnQuanLyNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyNguoiDung.UseVisualStyleBackColor = false;
			this.btnQuanLyNguoiDung.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// btnQuanLyKhoa
			// 
			this.btnQuanLyKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(127)))), ((int)(((byte)(210)))));
			this.btnQuanLyKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyKhoa.FlatAppearance.BorderSize = 0;
			this.btnQuanLyKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyKhoa.ForeColor = System.Drawing.Color.White;
			this.btnQuanLyKhoa.IconChar = FontAwesome.Sharp.IconChar.Landmark;
			this.btnQuanLyKhoa.IconColor = System.Drawing.Color.White;
			this.btnQuanLyKhoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnQuanLyKhoa.IconSize = 40;
			this.btnQuanLyKhoa.Location = new System.Drawing.Point(5, 191);
			this.btnQuanLyKhoa.Name = "btnQuanLyKhoa";
			this.btnQuanLyKhoa.Padding = new System.Windows.Forms.Padding(86, 0, 0, 0);
			this.btnQuanLyKhoa.Size = new System.Drawing.Size(590, 55);
			this.btnQuanLyKhoa.TabIndex = 23;
			this.btnQuanLyKhoa.TabStop = false;
			this.btnQuanLyKhoa.Text = "Quản lý khoa";
			this.btnQuanLyKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyKhoa.UseVisualStyleBackColor = false;
			this.btnQuanLyKhoa.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// btnQuanLyKhoaHoc
			// 
			this.btnQuanLyKhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnQuanLyKhoaHoc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyKhoaHoc.FlatAppearance.BorderSize = 0;
			this.btnQuanLyKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyKhoaHoc.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyKhoaHoc.ForeColor = System.Drawing.Color.White;
			this.btnQuanLyKhoaHoc.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
			this.btnQuanLyKhoaHoc.IconColor = System.Drawing.Color.White;
			this.btnQuanLyKhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnQuanLyKhoaHoc.IconSize = 40;
			this.btnQuanLyKhoaHoc.Location = new System.Drawing.Point(5, 252);
			this.btnQuanLyKhoaHoc.Name = "btnQuanLyKhoaHoc";
			this.btnQuanLyKhoaHoc.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
			this.btnQuanLyKhoaHoc.Size = new System.Drawing.Size(590, 55);
			this.btnQuanLyKhoaHoc.TabIndex = 24;
			this.btnQuanLyKhoaHoc.TabStop = false;
			this.btnQuanLyKhoaHoc.Text = "Quản lý khóa học";
			this.btnQuanLyKhoaHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyKhoaHoc.UseVisualStyleBackColor = false;
			this.btnQuanLyKhoaHoc.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// pnlBottomAdmin
			// 
			this.pnlBottomAdmin.BackColor = System.Drawing.Color.White;
			this.pnlBottomAdmin.Controls.Add(this.btnDangXuatAdmin);
			this.pnlBottomAdmin.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlBottomAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottomAdmin.Location = new System.Drawing.Point(0, 440);
			this.pnlBottomAdmin.Name = "pnlBottomAdmin";
			this.pnlBottomAdmin.Size = new System.Drawing.Size(650, 48);
			this.pnlBottomAdmin.TabIndex = 27;
			this.pnlBottomAdmin.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnDangXuatAdmin
			// 
			this.btnDangXuatAdmin.Animated = true;
			this.btnDangXuatAdmin.BackColor = System.Drawing.Color.Transparent;
			this.btnDangXuatAdmin.BorderColor = System.Drawing.Color.Transparent;
			this.btnDangXuatAdmin.BorderRadius = 5;
			this.btnDangXuatAdmin.BorderThickness = 1;
			this.btnDangXuatAdmin.CheckedState.Parent = this.btnDangXuatAdmin;
			this.btnDangXuatAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDangXuatAdmin.CustomImages.Parent = this.btnDangXuatAdmin;
			this.btnDangXuatAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuatAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuatAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDangXuatAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDangXuatAdmin.DisabledState.Parent = this.btnDangXuatAdmin;
			this.btnDangXuatAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnDangXuatAdmin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangXuatAdmin.ForeColor = System.Drawing.Color.White;
			this.btnDangXuatAdmin.HoverState.Parent = this.btnDangXuatAdmin;
			this.btnDangXuatAdmin.Location = new System.Drawing.Point(523, 5);
			this.btnDangXuatAdmin.Name = "btnDangXuatAdmin";
			this.btnDangXuatAdmin.ShadowDecoration.Parent = this.btnDangXuatAdmin;
			this.btnDangXuatAdmin.Size = new System.Drawing.Size(104, 38);
			this.btnDangXuatAdmin.TabIndex = 0;
			this.btnDangXuatAdmin.TabStop = false;
			this.btnDangXuatAdmin.Text = "Đăng xuất";
			this.btnDangXuatAdmin.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// pnlTopAdmin
			// 
			this.pnlTopAdmin.BackColor = System.Drawing.Color.White;
			this.pnlTopAdmin.Controls.Add(this.btnKhoiPhucDuLieu);
			this.pnlTopAdmin.Controls.Add(this.label2);
			this.pnlTopAdmin.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlTopAdmin.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopAdmin.Location = new System.Drawing.Point(0, 0);
			this.pnlTopAdmin.Name = "pnlTopAdmin";
			this.pnlTopAdmin.Size = new System.Drawing.Size(650, 48);
			this.pnlTopAdmin.TabIndex = 18;
			this.pnlTopAdmin.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnKhoiPhucDuLieu
			// 
			this.btnKhoiPhucDuLieu.Animated = true;
			this.btnKhoiPhucDuLieu.BackColor = System.Drawing.Color.Transparent;
			this.btnKhoiPhucDuLieu.BorderColor = System.Drawing.Color.Transparent;
			this.btnKhoiPhucDuLieu.BorderRadius = 5;
			this.btnKhoiPhucDuLieu.BorderThickness = 1;
			this.btnKhoiPhucDuLieu.CheckedState.Parent = this.btnKhoiPhucDuLieu;
			this.btnKhoiPhucDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKhoiPhucDuLieu.CustomImages.Parent = this.btnKhoiPhucDuLieu;
			this.btnKhoiPhucDuLieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnKhoiPhucDuLieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnKhoiPhucDuLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnKhoiPhucDuLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnKhoiPhucDuLieu.DisabledState.Parent = this.btnKhoiPhucDuLieu;
			this.btnKhoiPhucDuLieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnKhoiPhucDuLieu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhoiPhucDuLieu.ForeColor = System.Drawing.Color.White;
			this.btnKhoiPhucDuLieu.HoverState.Parent = this.btnKhoiPhucDuLieu;
			this.btnKhoiPhucDuLieu.Location = new System.Drawing.Point(464, 5);
			this.btnKhoiPhucDuLieu.Name = "btnKhoiPhucDuLieu";
			this.btnKhoiPhucDuLieu.ShadowDecoration.Parent = this.btnKhoiPhucDuLieu;
			this.btnKhoiPhucDuLieu.Size = new System.Drawing.Size(163, 38);
			this.btnKhoiPhucDuLieu.TabIndex = 0;
			this.btnKhoiPhucDuLieu.TabStop = false;
			this.btnKhoiPhucDuLieu.Text = "Khôi phục dữ liệu";
			this.btnKhoiPhucDuLieu.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.label2.Location = new System.Drawing.Point(25, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 32);
			this.label2.TabIndex = 11;
			this.label2.Text = "Điều Hướng";
			this.label2.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// pnlGiaoVien
			// 
			this.pnlGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.pnlGiaoVien.Controls.Add(this.gbManager);
			this.pnlGiaoVien.Controls.Add(this.pnlBottomGiaoVien);
			this.pnlGiaoVien.Controls.Add(this.pnlTopGiaoVien);
			this.pnlGiaoVien.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlGiaoVien.Location = new System.Drawing.Point(840, 166);
			this.pnlGiaoVien.Name = "pnlGiaoVien";
			this.pnlGiaoVien.Size = new System.Drawing.Size(650, 488);
			this.pnlGiaoVien.TabIndex = 38;
			this.pnlGiaoVien.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// gbManager
			// 
			this.gbManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.gbManager.BorderRadius = 5;
			this.gbManager.Controls.Add(this.lbTaiKhoanManager);
			this.gbManager.Controls.Add(this.btnStatiscicalMark);
			this.gbManager.Controls.Add(this.tbManager);
			this.gbManager.Controls.Add(this.btnQuanLyMonThi);
			this.gbManager.Controls.Add(this.btnQuanLyCauHoi);
			this.gbManager.Controls.Add(this.btnQuanLyDeThi);
			this.gbManager.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.gbManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.gbManager.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbManager.ForeColor = System.Drawing.Color.White;
			this.gbManager.Location = new System.Drawing.Point(25, 57);
			this.gbManager.Name = "gbManager";
			this.gbManager.ShadowDecoration.Parent = this.gbManager;
			this.gbManager.Size = new System.Drawing.Size(600, 374);
			this.gbManager.TabIndex = 39;
			this.gbManager.Text = "Manager";
			this.gbManager.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// lbTaiKhoanManager
			// 
			this.lbTaiKhoanManager.AutoSize = true;
			this.lbTaiKhoanManager.BackColor = System.Drawing.Color.Transparent;
			this.lbTaiKhoanManager.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTaiKhoanManager.ForeColor = System.Drawing.Color.Black;
			this.lbTaiKhoanManager.Location = new System.Drawing.Point(155, 51);
			this.lbTaiKhoanManager.Name = "lbTaiKhoanManager";
			this.lbTaiKhoanManager.Size = new System.Drawing.Size(125, 25);
			this.lbTaiKhoanManager.TabIndex = 14;
			this.lbTaiKhoanManager.Text = "Tài khoản:";
			this.lbTaiKhoanManager.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnStatiscicalMark
			// 
			this.btnStatiscicalMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(87)))), ((int)(((byte)(170)))));
			this.btnStatiscicalMark.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStatiscicalMark.FlatAppearance.BorderSize = 0;
			this.btnStatiscicalMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatiscicalMark.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatiscicalMark.ForeColor = System.Drawing.Color.White;
			this.btnStatiscicalMark.IconChar = FontAwesome.Sharp.IconChar.ListOl;
			this.btnStatiscicalMark.IconColor = System.Drawing.Color.White;
			this.btnStatiscicalMark.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnStatiscicalMark.IconSize = 40;
			this.btnStatiscicalMark.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnStatiscicalMark.Location = new System.Drawing.Point(5, 314);
			this.btnStatiscicalMark.Name = "btnStatiscicalMark";
			this.btnStatiscicalMark.Padding = new System.Windows.Forms.Padding(137, 0, 0, 0);
			this.btnStatiscicalMark.Size = new System.Drawing.Size(590, 55);
			this.btnStatiscicalMark.TabIndex = 28;
			this.btnStatiscicalMark.TabStop = false;
			this.btnStatiscicalMark.Text = "Thống kê điểm thi";
			this.btnStatiscicalMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnStatiscicalMark.UseVisualStyleBackColor = false;
			this.btnStatiscicalMark.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// tbManager
			// 
			this.tbManager.BorderColor = System.Drawing.Color.Gray;
			this.tbManager.BorderRadius = 5;
			this.tbManager.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbManager.DefaultText = "Cheems hôm nay bruh quá! ";
			this.tbManager.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbManager.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbManager.DisabledState.Parent = this.tbManager;
			this.tbManager.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbManager.Enabled = false;
			this.tbManager.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbManager.FocusedState.Parent = this.tbManager;
			this.tbManager.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbManager.ForeColor = System.Drawing.Color.Black;
			this.tbManager.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbManager.HoverState.Parent = this.tbManager;
			this.tbManager.Location = new System.Drawing.Point(150, 80);
			this.tbManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbManager.Name = "tbManager";
			this.tbManager.PasswordChar = '\0';
			this.tbManager.PlaceholderText = "";
			this.tbManager.ReadOnly = true;
			this.tbManager.SelectedText = "";
			this.tbManager.SelectionStart = 25;
			this.tbManager.ShadowDecoration.Parent = this.tbManager;
			this.tbManager.ShortcutsEnabled = false;
			this.tbManager.Size = new System.Drawing.Size(300, 36);
			this.tbManager.TabIndex = 13;
			this.tbManager.TabStop = false;
			this.tbManager.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnQuanLyMonThi
			// 
			this.btnQuanLyMonThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnQuanLyMonThi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyMonThi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnQuanLyMonThi.FlatAppearance.BorderSize = 0;
			this.btnQuanLyMonThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyMonThi.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyMonThi.ForeColor = System.Drawing.Color.White;
			this.btnQuanLyMonThi.IconChar = FontAwesome.Sharp.IconChar.Shapes;
			this.btnQuanLyMonThi.IconColor = System.Drawing.Color.White;
			this.btnQuanLyMonThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnQuanLyMonThi.IconSize = 40;
			this.btnQuanLyMonThi.Location = new System.Drawing.Point(5, 131);
			this.btnQuanLyMonThi.Name = "btnQuanLyMonThi";
			this.btnQuanLyMonThi.Padding = new System.Windows.Forms.Padding(125, 0, 0, 0);
			this.btnQuanLyMonThi.Size = new System.Drawing.Size(590, 55);
			this.btnQuanLyMonThi.TabIndex = 22;
			this.btnQuanLyMonThi.TabStop = false;
			this.btnQuanLyMonThi.Text = "Quản lý môn thi";
			this.btnQuanLyMonThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyMonThi.UseVisualStyleBackColor = false;
			this.btnQuanLyMonThi.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// btnQuanLyCauHoi
			// 
			this.btnQuanLyCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(127)))), ((int)(((byte)(210)))));
			this.btnQuanLyCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyCauHoi.FlatAppearance.BorderSize = 0;
			this.btnQuanLyCauHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyCauHoi.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyCauHoi.ForeColor = System.Drawing.Color.White;
			this.btnQuanLyCauHoi.IconChar = FontAwesome.Sharp.IconChar.Question;
			this.btnQuanLyCauHoi.IconColor = System.Drawing.Color.White;
			this.btnQuanLyCauHoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnQuanLyCauHoi.IconSize = 40;
			this.btnQuanLyCauHoi.Location = new System.Drawing.Point(5, 192);
			this.btnQuanLyCauHoi.Name = "btnQuanLyCauHoi";
			this.btnQuanLyCauHoi.Padding = new System.Windows.Forms.Padding(126, 0, 0, 0);
			this.btnQuanLyCauHoi.Size = new System.Drawing.Size(590, 55);
			this.btnQuanLyCauHoi.TabIndex = 23;
			this.btnQuanLyCauHoi.TabStop = false;
			this.btnQuanLyCauHoi.Text = "Quản lý câu hỏi";
			this.btnQuanLyCauHoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyCauHoi.UseVisualStyleBackColor = false;
			this.btnQuanLyCauHoi.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// btnQuanLyDeThi
			// 
			this.btnQuanLyDeThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnQuanLyDeThi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyDeThi.FlatAppearance.BorderSize = 0;
			this.btnQuanLyDeThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyDeThi.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyDeThi.ForeColor = System.Drawing.Color.White;
			this.btnQuanLyDeThi.IconChar = FontAwesome.Sharp.IconChar.Edit;
			this.btnQuanLyDeThi.IconColor = System.Drawing.Color.White;
			this.btnQuanLyDeThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnQuanLyDeThi.IconSize = 40;
			this.btnQuanLyDeThi.Location = new System.Drawing.Point(5, 253);
			this.btnQuanLyDeThi.Name = "btnQuanLyDeThi";
			this.btnQuanLyDeThi.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
			this.btnQuanLyDeThi.Size = new System.Drawing.Size(590, 55);
			this.btnQuanLyDeThi.TabIndex = 24;
			this.btnQuanLyDeThi.TabStop = false;
			this.btnQuanLyDeThi.Text = "Quản lý đề thi";
			this.btnQuanLyDeThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyDeThi.UseVisualStyleBackColor = false;
			this.btnQuanLyDeThi.Enter += new System.EventHandler(this.btnQuanLyDeThi_Enter);
			// 
			// pnlBottomGiaoVien
			// 
			this.pnlBottomGiaoVien.BackColor = System.Drawing.Color.White;
			this.pnlBottomGiaoVien.Controls.Add(this.btnDangXuatGiaoVien);
			this.pnlBottomGiaoVien.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlBottomGiaoVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottomGiaoVien.Location = new System.Drawing.Point(0, 440);
			this.pnlBottomGiaoVien.Name = "pnlBottomGiaoVien";
			this.pnlBottomGiaoVien.Size = new System.Drawing.Size(650, 48);
			this.pnlBottomGiaoVien.TabIndex = 27;
			this.pnlBottomGiaoVien.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnDangXuatGiaoVien
			// 
			this.btnDangXuatGiaoVien.Animated = true;
			this.btnDangXuatGiaoVien.BackColor = System.Drawing.Color.Transparent;
			this.btnDangXuatGiaoVien.BorderColor = System.Drawing.Color.Transparent;
			this.btnDangXuatGiaoVien.BorderRadius = 5;
			this.btnDangXuatGiaoVien.BorderThickness = 1;
			this.btnDangXuatGiaoVien.CheckedState.Parent = this.btnDangXuatGiaoVien;
			this.btnDangXuatGiaoVien.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDangXuatGiaoVien.CustomImages.Parent = this.btnDangXuatGiaoVien;
			this.btnDangXuatGiaoVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuatGiaoVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuatGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDangXuatGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDangXuatGiaoVien.DisabledState.Parent = this.btnDangXuatGiaoVien;
			this.btnDangXuatGiaoVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnDangXuatGiaoVien.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangXuatGiaoVien.ForeColor = System.Drawing.Color.White;
			this.btnDangXuatGiaoVien.HoverState.Parent = this.btnDangXuatGiaoVien;
			this.btnDangXuatGiaoVien.Location = new System.Drawing.Point(523, 5);
			this.btnDangXuatGiaoVien.Name = "btnDangXuatGiaoVien";
			this.btnDangXuatGiaoVien.ShadowDecoration.Parent = this.btnDangXuatGiaoVien;
			this.btnDangXuatGiaoVien.Size = new System.Drawing.Size(104, 38);
			this.btnDangXuatGiaoVien.TabIndex = 0;
			this.btnDangXuatGiaoVien.TabStop = false;
			this.btnDangXuatGiaoVien.Text = "Đăng xuất";
			this.btnDangXuatGiaoVien.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// pnlTopGiaoVien
			// 
			this.pnlTopGiaoVien.BackColor = System.Drawing.Color.White;
			this.pnlTopGiaoVien.Controls.Add(this.btnTroGiup);
			this.pnlTopGiaoVien.Controls.Add(this.label3);
			this.pnlTopGiaoVien.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlTopGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopGiaoVien.Location = new System.Drawing.Point(0, 0);
			this.pnlTopGiaoVien.Name = "pnlTopGiaoVien";
			this.pnlTopGiaoVien.Size = new System.Drawing.Size(650, 48);
			this.pnlTopGiaoVien.TabIndex = 18;
			this.pnlTopGiaoVien.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// btnTroGiup
			// 
			this.btnTroGiup.Animated = true;
			this.btnTroGiup.BackColor = System.Drawing.Color.Transparent;
			this.btnTroGiup.BorderColor = System.Drawing.Color.Transparent;
			this.btnTroGiup.BorderRadius = 5;
			this.btnTroGiup.BorderThickness = 1;
			this.btnTroGiup.CheckedState.Parent = this.btnTroGiup;
			this.btnTroGiup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTroGiup.CustomImages.Parent = this.btnTroGiup;
			this.btnTroGiup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTroGiup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTroGiup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTroGiup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTroGiup.DisabledState.Parent = this.btnTroGiup;
			this.btnTroGiup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(147)))), ((int)(((byte)(230)))));
			this.btnTroGiup.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTroGiup.ForeColor = System.Drawing.Color.White;
			this.btnTroGiup.HoverState.Parent = this.btnTroGiup;
			this.btnTroGiup.Location = new System.Drawing.Point(521, 5);
			this.btnTroGiup.Name = "btnTroGiup";
			this.btnTroGiup.ShadowDecoration.Parent = this.btnTroGiup;
			this.btnTroGiup.Size = new System.Drawing.Size(104, 38);
			this.btnTroGiup.TabIndex = 0;
			this.btnTroGiup.TabStop = false;
			this.btnTroGiup.Text = "Trợ giúp";
			this.btnTroGiup.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.label3.Location = new System.Drawing.Point(25, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 32);
			this.label3.TabIndex = 11;
			this.label3.Text = "Điều Hướng";
			this.label3.Click += new System.EventHandler(this.pbBackground_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
			this.Controls.Add(this.pnlGiaoVien);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.pnlNguoiDung);
			this.Controls.Add(this.pnlThongTinShadow);
			this.Controls.Add(this.pbBackground);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "MainMenu";
			this.Size = new System.Drawing.Size(1550, 822);
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
			this.pnlTopNguoiDung.ResumeLayout(false);
			this.pnlTopNguoiDung.PerformLayout();
			this.pnlNguoiDung.ResumeLayout(false);
			this.gbUser.ResumeLayout(false);
			this.gbUser.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.pnlAdmin.ResumeLayout(false);
			this.gbAdmin.ResumeLayout(false);
			this.gbAdmin.PerformLayout();
			this.pnlBottomAdmin.ResumeLayout(false);
			this.pnlTopAdmin.ResumeLayout(false);
			this.pnlTopAdmin.PerformLayout();
			this.pnlGiaoVien.ResumeLayout(false);
			this.gbManager.ResumeLayout(false);
			this.gbManager.PerformLayout();
			this.pnlBottomGiaoVien.ResumeLayout(false);
			this.pnlTopGiaoVien.ResumeLayout(false);
			this.pnlTopGiaoVien.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pbBackground;
		private System.Windows.Forms.Label lbTaiKhoanNguoiDung;
		private System.Windows.Forms.Label lbDieuHuong;
		private System.Windows.Forms.Panel pnlTopNguoiDung;
		public FontAwesome.Sharp.IconButton btnThiNgay;
		public FontAwesome.Sharp.IconButton btnHuongDanThi;
		public FontAwesome.Sharp.IconButton btnBangXepHang;
		private System.Windows.Forms.Panel pnlThongTinShadow;
		public Guna.UI2.WinForms.Guna2Button btnThongTinChiTiet;
		private System.Windows.Forms.Panel pnlBottomAdmin;
		public Guna.UI2.WinForms.Guna2Button btnDangXuatAdmin;
		public FontAwesome.Sharp.IconButton btnQuanLyLop;
		private System.Windows.Forms.Label lbTaiKhoanAdmin;
		private System.Windows.Forms.Panel pnlTopAdmin;
		public Guna.UI2.WinForms.Guna2Button btnKhoiPhucDuLieu;
		private System.Windows.Forms.Label label2;
		public FontAwesome.Sharp.IconButton btnQuanLyNguoiDung;
		public FontAwesome.Sharp.IconButton btnQuanLyKhoaHoc;
		public FontAwesome.Sharp.IconButton btnQuanLyKhoa;
		private System.Windows.Forms.Panel pnlBottomGiaoVien;
		public Guna.UI2.WinForms.Guna2Button btnDangXuatGiaoVien;
		private System.Windows.Forms.Panel pnlTopGiaoVien;
		public Guna.UI2.WinForms.Guna2Button btnTroGiup;
		private System.Windows.Forms.Label label3;
		public FontAwesome.Sharp.IconButton btnQuanLyMonThi;
		public FontAwesome.Sharp.IconButton btnQuanLyDeThi;
		public FontAwesome.Sharp.IconButton btnQuanLyCauHoi;
		public System.Windows.Forms.Panel pnlNguoiDung;
		public System.Windows.Forms.Panel pnlAdmin;
		public System.Windows.Forms.Panel pnlGiaoVien;
		private System.Windows.Forms.Panel panel1;
		public Guna.UI2.WinForms.Guna2Button btnDangXuatNguoiDung;
		public Guna.UI2.WinForms.Guna2TextBox tbID;
		public Guna.UI2.WinForms.Guna2TextBox tbTaiKhoan;
		public Guna.UI2.WinForms.Guna2TextBox tbAdmin;
		public Guna.UI2.WinForms.Guna2TextBox tbManager;
		public FontAwesome.Sharp.IconButton btnStatiscicalMark;
        private Guna.UI2.WinForms.Guna2GroupBox gbManager;
        private System.Windows.Forms.Label lbTaiKhoanManager;
        private Guna.UI2.WinForms.Guna2GroupBox gbAdmin;
        private Guna.UI2.WinForms.Guna2GroupBox gbUser;
    }
}