﻿
namespace Main.Pages
{
	partial class Profile
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
			this.pnlThongTin = new System.Windows.Forms.Panel();
			this.tbMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbMatKhau = new System.Windows.Forms.Label();
			this.lbTaiKhoan = new System.Windows.Forms.Label();
			this.pnlPassword = new System.Windows.Forms.Panel();
			this.tbNhapLaiMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbNhapLaiMatKhau = new System.Windows.Forms.Label();
			this.lbMatKhauMoi = new System.Windows.Forms.Label();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbClass = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbFullName = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbLop = new System.Windows.Forms.Label();
			this.lbID = new System.Windows.Forms.Label();
			this.lbDiaChi = new System.Windows.Forms.Label();
			this.lbEmail = new System.Windows.Forms.Label();
			this.lbSoDienThoai = new System.Windows.Forms.Label();
			this.lbNgaySinh = new System.Windows.Forms.Label();
			this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.lbHoVaTen = new System.Windows.Forms.Label();
			this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
			this.btnHuyMatKhau = new FontAwesome.Sharp.IconButton();
			this.btnLuuThongTin = new FontAwesome.Sharp.IconButton();
			this.btnHuyThongTin = new FontAwesome.Sharp.IconButton();
			this.btnLuuMatKhau = new FontAwesome.Sharp.IconButton();
			this.btnChinhSua = new FontAwesome.Sharp.IconButton();
			this.lbThongTinTaiKhoan = new System.Windows.Forms.Label();
			this.pnlThongTinShadow = new System.Windows.Forms.Panel();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.pbBackground = new System.Windows.Forms.PictureBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnlThongTin.SuspendLayout();
			this.pnlPassword.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(1076, 21);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(276, 37);
			this.lbTitle.TabIndex = 25;
			this.lbTitle.Text = "Thông tin cá nhân";
			// 
			// pnlThongTin
			// 
			this.pnlThongTin.BackColor = System.Drawing.Color.White;
			this.pnlThongTin.Controls.Add(this.tbMatKhau);
			this.pnlThongTin.Controls.Add(this.tbTaiKhoan);
			this.pnlThongTin.Controls.Add(this.lbMatKhau);
			this.pnlThongTin.Controls.Add(this.lbTaiKhoan);
			this.pnlThongTin.Controls.Add(this.pnlPassword);
			this.pnlThongTin.Controls.Add(this.pnlInfo);
			this.pnlThongTin.Controls.Add(this.btnDoiMatKhau);
			this.pnlThongTin.Controls.Add(this.btnHuyMatKhau);
			this.pnlThongTin.Controls.Add(this.btnLuuThongTin);
			this.pnlThongTin.Controls.Add(this.btnHuyThongTin);
			this.pnlThongTin.Controls.Add(this.btnLuuMatKhau);
			this.pnlThongTin.Controls.Add(this.btnChinhSua);
			this.pnlThongTin.Controls.Add(this.lbThongTinTaiKhoan);
			this.pnlThongTin.Location = new System.Drawing.Point(814, 75);
			this.pnlThongTin.Name = "pnlThongTin";
			this.pnlThongTin.Size = new System.Drawing.Size(700, 700);
			this.pnlThongTin.TabIndex = 0;
			// 
			// tbMatKhau
			// 
			this.tbMatKhau.BorderColor = System.Drawing.Color.Gray;
			this.tbMatKhau.BorderRadius = 5;
			this.tbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbMatKhau.DefaultText = "";
			this.tbMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbMatKhau.DisabledState.Parent = this.tbMatKhau;
			this.tbMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbMatKhau.Enabled = false;
			this.tbMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbMatKhau.FocusedState.Parent = this.tbMatKhau;
			this.tbMatKhau.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbMatKhau.ForeColor = System.Drawing.Color.Black;
			this.tbMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbMatKhau.HoverState.Parent = this.tbMatKhau;
			this.tbMatKhau.Location = new System.Drawing.Point(40, 567);
			this.tbMatKhau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbMatKhau.Name = "tbMatKhau";
			this.tbMatKhau.PasswordChar = '\0';
			this.tbMatKhau.PlaceholderText = "";
			this.tbMatKhau.SelectedText = "";
			this.tbMatKhau.ShadowDecoration.Parent = this.tbMatKhau;
			this.tbMatKhau.Size = new System.Drawing.Size(295, 39);
			this.tbMatKhau.TabIndex = 45;
			this.tbMatKhau.UseSystemPasswordChar = true;
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
			this.tbTaiKhoan.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbTaiKhoan.ForeColor = System.Drawing.Color.Black;
			this.tbTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbTaiKhoan.HoverState.Parent = this.tbTaiKhoan;
			this.tbTaiKhoan.Location = new System.Drawing.Point(39, 469);
			this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbTaiKhoan.Name = "tbTaiKhoan";
			this.tbTaiKhoan.PasswordChar = '\0';
			this.tbTaiKhoan.PlaceholderText = "";
			this.tbTaiKhoan.SelectedText = "";
			this.tbTaiKhoan.ShadowDecoration.Parent = this.tbTaiKhoan;
			this.tbTaiKhoan.Size = new System.Drawing.Size(295, 39);
			this.tbTaiKhoan.TabIndex = 44;
			// 
			// lbMatKhau
			// 
			this.lbMatKhau.AutoSize = true;
			this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMatKhau.Location = new System.Drawing.Point(50, 535);
			this.lbMatKhau.Name = "lbMatKhau";
			this.lbMatKhau.Size = new System.Drawing.Size(91, 24);
			this.lbMatKhau.TabIndex = 43;
			this.lbMatKhau.Text = "Mật khẩu:";
			// 
			// lbTaiKhoan
			// 
			this.lbTaiKhoan.AutoSize = true;
			this.lbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTaiKhoan.Location = new System.Drawing.Point(50, 438);
			this.lbTaiKhoan.Name = "lbTaiKhoan";
			this.lbTaiKhoan.Size = new System.Drawing.Size(98, 24);
			this.lbTaiKhoan.TabIndex = 42;
			this.lbTaiKhoan.Text = "Tài khoản:";
			// 
			// pnlPassword
			// 
			this.pnlPassword.BackColor = System.Drawing.Color.White;
			this.pnlPassword.Controls.Add(this.tbNhapLaiMatKhauMoi);
			this.pnlPassword.Controls.Add(this.tbMatKhauMoi);
			this.pnlPassword.Controls.Add(this.lbNhapLaiMatKhau);
			this.pnlPassword.Controls.Add(this.lbMatKhauMoi);
			this.pnlPassword.Location = new System.Drawing.Point(343, 423);
			this.pnlPassword.Name = "pnlPassword";
			this.pnlPassword.Size = new System.Drawing.Size(354, 199);
			this.pnlPassword.TabIndex = 31;
			this.pnlPassword.Visible = false;
			// 
			// tbNhapLaiMatKhauMoi
			// 
			this.tbNhapLaiMatKhauMoi.BorderColor = System.Drawing.Color.Gray;
			this.tbNhapLaiMatKhauMoi.BorderRadius = 5;
			this.tbNhapLaiMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNhapLaiMatKhauMoi.DefaultText = "";
			this.tbNhapLaiMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbNhapLaiMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbNhapLaiMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNhapLaiMatKhauMoi.DisabledState.Parent = this.tbNhapLaiMatKhauMoi;
			this.tbNhapLaiMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNhapLaiMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNhapLaiMatKhauMoi.FocusedState.Parent = this.tbNhapLaiMatKhauMoi;
			this.tbNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbNhapLaiMatKhauMoi.ForeColor = System.Drawing.Color.Black;
			this.tbNhapLaiMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNhapLaiMatKhauMoi.HoverState.Parent = this.tbNhapLaiMatKhauMoi;
			this.tbNhapLaiMatKhauMoi.Location = new System.Drawing.Point(22, 144);
			this.tbNhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbNhapLaiMatKhauMoi.Name = "tbNhapLaiMatKhauMoi";
			this.tbNhapLaiMatKhauMoi.PasswordChar = '\0';
			this.tbNhapLaiMatKhauMoi.PlaceholderText = "";
			this.tbNhapLaiMatKhauMoi.SelectedText = "";
			this.tbNhapLaiMatKhauMoi.ShadowDecoration.Parent = this.tbNhapLaiMatKhauMoi;
			this.tbNhapLaiMatKhauMoi.Size = new System.Drawing.Size(295, 39);
			this.tbNhapLaiMatKhauMoi.TabIndex = 42;
			this.tbNhapLaiMatKhauMoi.UseSystemPasswordChar = true;
			// 
			// tbMatKhauMoi
			// 
			this.tbMatKhauMoi.BorderColor = System.Drawing.Color.Gray;
			this.tbMatKhauMoi.BorderRadius = 5;
			this.tbMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbMatKhauMoi.DefaultText = "";
			this.tbMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbMatKhauMoi.DisabledState.Parent = this.tbMatKhauMoi;
			this.tbMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbMatKhauMoi.FocusedState.Parent = this.tbMatKhauMoi;
			this.tbMatKhauMoi.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbMatKhauMoi.ForeColor = System.Drawing.Color.Black;
			this.tbMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbMatKhauMoi.HoverState.Parent = this.tbMatKhauMoi;
			this.tbMatKhauMoi.Location = new System.Drawing.Point(22, 46);
			this.tbMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbMatKhauMoi.Name = "tbMatKhauMoi";
			this.tbMatKhauMoi.PasswordChar = '\0';
			this.tbMatKhauMoi.PlaceholderText = "";
			this.tbMatKhauMoi.SelectedText = "";
			this.tbMatKhauMoi.ShadowDecoration.Parent = this.tbMatKhauMoi;
			this.tbMatKhauMoi.Size = new System.Drawing.Size(295, 39);
			this.tbMatKhauMoi.TabIndex = 40;
			this.tbMatKhauMoi.UseSystemPasswordChar = true;
			// 
			// lbNhapLaiMatKhau
			// 
			this.lbNhapLaiMatKhau.AutoSize = true;
			this.lbNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhapLaiMatKhau.Location = new System.Drawing.Point(35, 112);
			this.lbNhapLaiMatKhau.Name = "lbNhapLaiMatKhau";
			this.lbNhapLaiMatKhau.Size = new System.Drawing.Size(201, 24);
			this.lbNhapLaiMatKhau.TabIndex = 38;
			this.lbNhapLaiMatKhau.Text = "Nhập lại mật khẩu mới:";
			// 
			// lbMatKhauMoi
			// 
			this.lbMatKhauMoi.AutoSize = true;
			this.lbMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMatKhauMoi.Location = new System.Drawing.Point(35, 15);
			this.lbMatKhauMoi.Name = "lbMatKhauMoi";
			this.lbMatKhauMoi.Size = new System.Drawing.Size(127, 24);
			this.lbMatKhauMoi.TabIndex = 37;
			this.lbMatKhauMoi.Text = "Mật khẩu mới:";
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.Color.White;
			this.pnlInfo.Controls.Add(this.tbEmail);
			this.pnlInfo.Controls.Add(this.tbSoDienThoai);
			this.pnlInfo.Controls.Add(this.tbClass);
			this.pnlInfo.Controls.Add(this.tbID);
			this.pnlInfo.Controls.Add(this.tbDiaChi);
			this.pnlInfo.Controls.Add(this.tbFullName);
			this.pnlInfo.Controls.Add(this.lbLop);
			this.pnlInfo.Controls.Add(this.lbID);
			this.pnlInfo.Controls.Add(this.lbDiaChi);
			this.pnlInfo.Controls.Add(this.lbEmail);
			this.pnlInfo.Controls.Add(this.lbSoDienThoai);
			this.pnlInfo.Controls.Add(this.lbNgaySinh);
			this.pnlInfo.Controls.Add(this.dtpNgaySinh);
			this.pnlInfo.Controls.Add(this.lbHoVaTen);
			this.pnlInfo.Location = new System.Drawing.Point(6, 6);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(691, 312);
			this.pnlInfo.TabIndex = 35;
			// 
			// tbEmail
			// 
			this.tbEmail.BorderColor = System.Drawing.Color.Gray;
			this.tbEmail.BorderRadius = 5;
			this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbEmail.DefaultText = "";
			this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbEmail.DisabledState.Parent = this.tbEmail;
			this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbEmail.Enabled = false;
			this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbEmail.FocusedState.Parent = this.tbEmail;
			this.tbEmail.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbEmail.ForeColor = System.Drawing.Color.Black;
			this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbEmail.HoverState.Parent = this.tbEmail;
			this.tbEmail.Location = new System.Drawing.Point(35, 253);
			this.tbEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.PasswordChar = '\0';
			this.tbEmail.PlaceholderText = "";
			this.tbEmail.SelectedText = "";
			this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
			this.tbEmail.Size = new System.Drawing.Size(402, 39);
			this.tbEmail.TabIndex = 44;
			// 
			// tbSoDienThoai
			// 
			this.tbSoDienThoai.BorderColor = System.Drawing.Color.Gray;
			this.tbSoDienThoai.BorderRadius = 5;
			this.tbSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSoDienThoai.DefaultText = "";
			this.tbSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSoDienThoai.DisabledState.Parent = this.tbSoDienThoai;
			this.tbSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSoDienThoai.Enabled = false;
			this.tbSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSoDienThoai.FocusedState.Parent = this.tbSoDienThoai;
			this.tbSoDienThoai.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbSoDienThoai.ForeColor = System.Drawing.Color.Black;
			this.tbSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSoDienThoai.HoverState.Parent = this.tbSoDienThoai;
			this.tbSoDienThoai.Location = new System.Drawing.Point(382, 149);
			this.tbSoDienThoai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbSoDienThoai.Name = "tbSoDienThoai";
			this.tbSoDienThoai.PasswordChar = '\0';
			this.tbSoDienThoai.PlaceholderText = "";
			this.tbSoDienThoai.SelectedText = "";
			this.tbSoDienThoai.ShadowDecoration.Parent = this.tbSoDienThoai;
			this.tbSoDienThoai.Size = new System.Drawing.Size(273, 39);
			this.tbSoDienThoai.TabIndex = 43;
			// 
			// tbClass
			// 
			this.tbClass.BorderColor = System.Drawing.Color.Gray;
			this.tbClass.BorderRadius = 5;
			this.tbClass.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbClass.DefaultText = "";
			this.tbClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbClass.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbClass.DisabledState.Parent = this.tbClass;
			this.tbClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbClass.Enabled = false;
			this.tbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbClass.FocusedState.Parent = this.tbClass;
			this.tbClass.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbClass.ForeColor = System.Drawing.Color.Black;
			this.tbClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbClass.HoverState.Parent = this.tbClass;
			this.tbClass.Location = new System.Drawing.Point(226, 149);
			this.tbClass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbClass.Name = "tbClass";
			this.tbClass.PasswordChar = '\0';
			this.tbClass.PlaceholderText = "";
			this.tbClass.SelectedText = "";
			this.tbClass.ShadowDecoration.Parent = this.tbClass;
			this.tbClass.Size = new System.Drawing.Size(122, 39);
			this.tbClass.TabIndex = 42;
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
			this.tbID.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbID.ForeColor = System.Drawing.Color.Black;
			this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbID.HoverState.Parent = this.tbID;
			this.tbID.Location = new System.Drawing.Point(35, 149);
			this.tbID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbID.Name = "tbID";
			this.tbID.PasswordChar = '\0';
			this.tbID.PlaceholderText = "";
			this.tbID.SelectedText = "";
			this.tbID.ShadowDecoration.Parent = this.tbID;
			this.tbID.Size = new System.Drawing.Size(181, 39);
			this.tbID.TabIndex = 41;
			// 
			// tbDiaChi
			// 
			this.tbDiaChi.BorderColor = System.Drawing.Color.Gray;
			this.tbDiaChi.BorderRadius = 5;
			this.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbDiaChi.DefaultText = "";
			this.tbDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDiaChi.DisabledState.Parent = this.tbDiaChi;
			this.tbDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDiaChi.Enabled = false;
			this.tbDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDiaChi.FocusedState.Parent = this.tbDiaChi;
			this.tbDiaChi.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbDiaChi.ForeColor = System.Drawing.Color.Black;
			this.tbDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDiaChi.HoverState.Parent = this.tbDiaChi;
			this.tbDiaChi.Location = new System.Drawing.Point(474, 51);
			this.tbDiaChi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbDiaChi.Name = "tbDiaChi";
			this.tbDiaChi.PasswordChar = '\0';
			this.tbDiaChi.PlaceholderText = "";
			this.tbDiaChi.SelectedText = "";
			this.tbDiaChi.ShadowDecoration.Parent = this.tbDiaChi;
			this.tbDiaChi.Size = new System.Drawing.Size(181, 39);
			this.tbDiaChi.TabIndex = 40;
			// 
			// tbFullName
			// 
			this.tbFullName.BorderColor = System.Drawing.Color.Gray;
			this.tbFullName.BorderRadius = 5;
			this.tbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFullName.DefaultText = "";
			this.tbFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFullName.DisabledState.Parent = this.tbFullName;
			this.tbFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFullName.Enabled = false;
			this.tbFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFullName.FocusedState.Parent = this.tbFullName;
			this.tbFullName.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbFullName.ForeColor = System.Drawing.Color.Black;
			this.tbFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFullName.HoverState.Parent = this.tbFullName;
			this.tbFullName.Location = new System.Drawing.Point(35, 51);
			this.tbFullName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbFullName.Name = "tbFullName";
			this.tbFullName.PasswordChar = '\0';
			this.tbFullName.PlaceholderText = "";
			this.tbFullName.SelectedText = "";
			this.tbFullName.ShadowDecoration.Parent = this.tbFullName;
			this.tbFullName.Size = new System.Drawing.Size(402, 39);
			this.tbFullName.TabIndex = 39;
			// 
			// lbLop
			// 
			this.lbLop.AutoSize = true;
			this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLop.Location = new System.Drawing.Point(236, 119);
			this.lbLop.Name = "lbLop";
			this.lbLop.Size = new System.Drawing.Size(47, 24);
			this.lbLop.TabIndex = 38;
			this.lbLop.Text = "Lớp:";
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbID.Location = new System.Drawing.Point(46, 119);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(32, 24);
			this.lbID.TabIndex = 34;
			this.lbID.Text = "ID:";
			// 
			// lbDiaChi
			// 
			this.lbDiaChi.AutoSize = true;
			this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiaChi.Location = new System.Drawing.Point(491, 20);
			this.lbDiaChi.Name = "lbDiaChi";
			this.lbDiaChi.Size = new System.Drawing.Size(72, 24);
			this.lbDiaChi.TabIndex = 37;
			this.lbDiaChi.Text = "Địa chỉ:";
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmail.Location = new System.Drawing.Point(46, 222);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(62, 24);
			this.lbEmail.TabIndex = 35;
			this.lbEmail.Text = "Email:";
			// 
			// lbSoDienThoai
			// 
			this.lbSoDienThoai.AutoSize = true;
			this.lbSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoDienThoai.Location = new System.Drawing.Point(393, 119);
			this.lbSoDienThoai.Name = "lbSoDienThoai";
			this.lbSoDienThoai.Size = new System.Drawing.Size(126, 24);
			this.lbSoDienThoai.TabIndex = 33;
			this.lbSoDienThoai.Text = "Số điện thoại:";
			// 
			// lbNgaySinh
			// 
			this.lbNgaySinh.AutoSize = true;
			this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNgaySinh.Location = new System.Drawing.Point(491, 222);
			this.lbNgaySinh.Name = "lbNgaySinh";
			this.lbNgaySinh.Size = new System.Drawing.Size(99, 24);
			this.lbNgaySinh.TabIndex = 32;
			this.lbNgaySinh.Text = "Ngày sinh:";
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.BorderColor = System.Drawing.Color.Gray;
			this.dtpNgaySinh.BorderRadius = 5;
			this.dtpNgaySinh.BorderThickness = 1;
			this.dtpNgaySinh.CheckedState.Parent = this.dtpNgaySinh;
			this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtpNgaySinh.Enabled = false;
			this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
			this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.HoverState.Parent = this.dtpNgaySinh;
			this.dtpNgaySinh.Location = new System.Drawing.Point(474, 253);
			this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.ShadowDecoration.Parent = this.dtpNgaySinh;
			this.dtpNgaySinh.Size = new System.Drawing.Size(181, 39);
			this.dtpNgaySinh.TabIndex = 36;
			this.dtpNgaySinh.Value = new System.DateTime(2021, 9, 1, 17, 50, 13, 305);
			// 
			// lbHoVaTen
			// 
			this.lbHoVaTen.AutoSize = true;
			this.lbHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHoVaTen.Location = new System.Drawing.Point(46, 20);
			this.lbHoVaTen.Name = "lbHoVaTen";
			this.lbHoVaTen.Size = new System.Drawing.Size(115, 24);
			this.lbHoVaTen.TabIndex = 31;
			this.lbHoVaTen.Text = "Tên hiển thị:";
			// 
			// btnDoiMatKhau
			// 
			this.btnDoiMatKhau.Animated = true;
			this.btnDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
			this.btnDoiMatKhau.BorderColor = System.Drawing.Color.Transparent;
			this.btnDoiMatKhau.BorderRadius = 5;
			this.btnDoiMatKhau.BorderThickness = 1;
			this.btnDoiMatKhau.CheckedState.Parent = this.btnDoiMatKhau;
			this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDoiMatKhau.CustomImages.Parent = this.btnDoiMatKhau;
			this.btnDoiMatKhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDoiMatKhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDoiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDoiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDoiMatKhau.DisabledState.Parent = this.btnDoiMatKhau;
			this.btnDoiMatKhau.FillColor = System.Drawing.Color.Gray;
			this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
			this.btnDoiMatKhau.HoverState.Parent = this.btnDoiMatKhau;
			this.btnDoiMatKhau.Location = new System.Drawing.Point(40, 628);
			this.btnDoiMatKhau.Name = "btnDoiMatKhau";
			this.btnDoiMatKhau.ShadowDecoration.Parent = this.btnDoiMatKhau;
			this.btnDoiMatKhau.Size = new System.Drawing.Size(124, 38);
			this.btnDoiMatKhau.TabIndex = 14;
			this.btnDoiMatKhau.Text = "Đổi mật khẩu";
			this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
			// 
			// btnHuyMatKhau
			// 
			this.btnHuyMatKhau.BackColor = System.Drawing.Color.DarkGray;
			this.btnHuyMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHuyMatKhau.FlatAppearance.BorderSize = 0;
			this.btnHuyMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHuyMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnHuyMatKhau.ForeColor = System.Drawing.Color.White;
			this.btnHuyMatKhau.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
			this.btnHuyMatKhau.IconColor = System.Drawing.Color.White;
			this.btnHuyMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnHuyMatKhau.IconSize = 28;
			this.btnHuyMatKhau.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHuyMatKhau.Location = new System.Drawing.Point(568, 628);
			this.btnHuyMatKhau.Name = "btnHuyMatKhau";
			this.btnHuyMatKhau.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnHuyMatKhau.Size = new System.Drawing.Size(92, 40);
			this.btnHuyMatKhau.TabIndex = 16;
			this.btnHuyMatKhau.Text = "Hủy";
			this.btnHuyMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHuyMatKhau.UseVisualStyleBackColor = false;
			this.btnHuyMatKhau.Visible = false;
			this.btnHuyMatKhau.Click += new System.EventHandler(this.btnHuyMatKhau_Click);
			// 
			// btnLuuThongTin
			// 
			this.btnLuuThongTin.BackColor = System.Drawing.Color.Green;
			this.btnLuuThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLuuThongTin.FlatAppearance.BorderSize = 0;
			this.btnLuuThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLuuThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnLuuThongTin.ForeColor = System.Drawing.Color.White;
			this.btnLuuThongTin.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
			this.btnLuuThongTin.IconColor = System.Drawing.Color.White;
			this.btnLuuThongTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnLuuThongTin.IconSize = 28;
			this.btnLuuThongTin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLuuThongTin.Location = new System.Drawing.Point(460, 324);
			this.btnLuuThongTin.Name = "btnLuuThongTin";
			this.btnLuuThongTin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnLuuThongTin.Size = new System.Drawing.Size(92, 40);
			this.btnLuuThongTin.TabIndex = 8;
			this.btnLuuThongTin.Text = "Lưu";
			this.btnLuuThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLuuThongTin.UseVisualStyleBackColor = false;
			this.btnLuuThongTin.Visible = false;
			this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
			// 
			// btnHuyThongTin
			// 
			this.btnHuyThongTin.BackColor = System.Drawing.Color.DarkGray;
			this.btnHuyThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHuyThongTin.FlatAppearance.BorderSize = 0;
			this.btnHuyThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHuyThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnHuyThongTin.ForeColor = System.Drawing.Color.White;
			this.btnHuyThongTin.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
			this.btnHuyThongTin.IconColor = System.Drawing.Color.White;
			this.btnHuyThongTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnHuyThongTin.IconSize = 28;
			this.btnHuyThongTin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHuyThongTin.Location = new System.Drawing.Point(568, 324);
			this.btnHuyThongTin.Name = "btnHuyThongTin";
			this.btnHuyThongTin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnHuyThongTin.Size = new System.Drawing.Size(92, 40);
			this.btnHuyThongTin.TabIndex = 9;
			this.btnHuyThongTin.Text = "Hủy";
			this.btnHuyThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHuyThongTin.UseVisualStyleBackColor = false;
			this.btnHuyThongTin.Visible = false;
			this.btnHuyThongTin.Click += new System.EventHandler(this.btnHuyLuu_Click);
			// 
			// btnLuuMatKhau
			// 
			this.btnLuuMatKhau.BackColor = System.Drawing.Color.Green;
			this.btnLuuMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLuuMatKhau.FlatAppearance.BorderSize = 0;
			this.btnLuuMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLuuMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnLuuMatKhau.ForeColor = System.Drawing.Color.White;
			this.btnLuuMatKhau.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
			this.btnLuuMatKhau.IconColor = System.Drawing.Color.White;
			this.btnLuuMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnLuuMatKhau.IconSize = 28;
			this.btnLuuMatKhau.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLuuMatKhau.Location = new System.Drawing.Point(462, 628);
			this.btnLuuMatKhau.Name = "btnLuuMatKhau";
			this.btnLuuMatKhau.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnLuuMatKhau.Size = new System.Drawing.Size(92, 40);
			this.btnLuuMatKhau.TabIndex = 15;
			this.btnLuuMatKhau.Text = "Lưu";
			this.btnLuuMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLuuMatKhau.UseVisualStyleBackColor = false;
			this.btnLuuMatKhau.Visible = false;
			this.btnLuuMatKhau.Click += new System.EventHandler(this.btnLuuMatKhau_Click);
			// 
			// btnChinhSua
			// 
			this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
			this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChinhSua.FlatAppearance.BorderSize = 0;
			this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChinhSua.ForeColor = System.Drawing.Color.White;
			this.btnChinhSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
			this.btnChinhSua.IconColor = System.Drawing.Color.White;
			this.btnChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnChinhSua.IconSize = 20;
			this.btnChinhSua.Location = new System.Drawing.Point(40, 324);
			this.btnChinhSua.Name = "btnChinhSua";
			this.btnChinhSua.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnChinhSua.Size = new System.Drawing.Size(113, 40);
			this.btnChinhSua.TabIndex = 7;
			this.btnChinhSua.Text = "Chỉnh sửa";
			this.btnChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnChinhSua.UseVisualStyleBackColor = false;
			this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
			// 
			// lbThongTinTaiKhoan
			// 
			this.lbThongTinTaiKhoan.AutoSize = true;
			this.lbThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThongTinTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbThongTinTaiKhoan.Location = new System.Drawing.Point(36, 395);
			this.lbThongTinTaiKhoan.Name = "lbThongTinTaiKhoan";
			this.lbThongTinTaiKhoan.Size = new System.Drawing.Size(202, 25);
			this.lbThongTinTaiKhoan.TabIndex = 10;
			this.lbThongTinTaiKhoan.Text = "Thông tin tài khoản:";
			// 
			// pnlThongTinShadow
			// 
			this.pnlThongTinShadow.BackColor = System.Drawing.Color.DarkGray;
			this.pnlThongTinShadow.Location = new System.Drawing.Point(817, 78);
			this.pnlThongTinShadow.Name = "pnlThongTinShadow";
			this.pnlThongTinShadow.Size = new System.Drawing.Size(700, 700);
			this.pnlThongTinShadow.TabIndex = 1;
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.IdCard;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(1036, 24);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 0;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			// 
			// pbBackground
			// 
			this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbBackground.Image = global::Main.Properties.Resources.Background;
			this.pbBackground.Location = new System.Drawing.Point(0, 0);
			this.pbBackground.Name = "pbBackground";
			this.pbBackground.Size = new System.Drawing.Size(1550, 822);
			this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbBackground.TabIndex = 30;
			this.pbBackground.TabStop = false;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// Profile
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlThongTin);
			this.Controls.Add(this.pnlThongTinShadow);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pbBackground);
			this.Name = "Profile";
			this.Size = new System.Drawing.Size(1550, 822);
			this.pnlThongTin.ResumeLayout(false);
			this.pnlThongTin.PerformLayout();
			this.pnlPassword.ResumeLayout(false);
			this.pnlPassword.PerformLayout();
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel pnlThongTin;
		private System.Windows.Forms.Label lbThongTinTaiKhoan;
		private FontAwesome.Sharp.IconButton btnChinhSua;
		private System.Windows.Forms.PictureBox pbBackground;
		private System.Windows.Forms.Panel pnlThongTinShadow;
		public FontAwesome.Sharp.IconButton btnLuuMatKhau;
		public FontAwesome.Sharp.IconButton btnLuuThongTin;
		public FontAwesome.Sharp.IconButton btnHuyThongTin;
		public FontAwesome.Sharp.IconButton btnHuyMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnDoiMatKhau;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Panel pnlPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbNhapLaiMatKhauMoi;
		private Guna.UI2.WinForms.Guna2TextBox tbMatKhauMoi;
		private System.Windows.Forms.Label lbNhapLaiMatKhau;
		private System.Windows.Forms.Label lbMatKhauMoi;
		private System.Windows.Forms.Panel pnlInfo;
		private Guna.UI2.WinForms.Guna2TextBox tbEmail;
		private Guna.UI2.WinForms.Guna2TextBox tbSoDienThoai;
		private Guna.UI2.WinForms.Guna2TextBox tbClass;
		private Guna.UI2.WinForms.Guna2TextBox tbID;
		private Guna.UI2.WinForms.Guna2TextBox tbDiaChi;
		private Guna.UI2.WinForms.Guna2TextBox tbFullName;
		private System.Windows.Forms.Label lbLop;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.Label lbDiaChi;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbSoDienThoai;
		private System.Windows.Forms.Label lbNgaySinh;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.Label lbHoVaTen;
		private Guna.UI2.WinForms.Guna2TextBox tbMatKhau;
		private Guna.UI2.WinForms.Guna2TextBox tbTaiKhoan;
		private System.Windows.Forms.Label lbMatKhau;
		private System.Windows.Forms.Label lbTaiKhoan;
	}
}