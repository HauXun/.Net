
namespace QuanLyNhaHang
{
	partial class SuaMonAn
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
			this.tbSoLuong = new System.Windows.Forms.TextBox();
			this.tbGia = new System.Windows.Forms.TextBox();
			this.lbSoLuong = new System.Windows.Forms.Label();
			this.lbGia = new System.Windows.Forms.Label();
			this.lbMonAn = new System.Windows.Forms.Label();
			this.tbMonAn = new System.Windows.Forms.TextBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// tbSoLuong
			// 
			this.tbSoLuong.Location = new System.Drawing.Point(103, 97);
			this.tbSoLuong.Name = "tbSoLuong";
			this.tbSoLuong.Size = new System.Drawing.Size(252, 23);
			this.tbSoLuong.TabIndex = 15;
			// 
			// tbGia
			// 
			this.tbGia.Location = new System.Drawing.Point(103, 58);
			this.tbGia.Name = "tbGia";
			this.tbGia.Size = new System.Drawing.Size(252, 23);
			this.tbGia.TabIndex = 14;
			// 
			// lbSoLuong
			// 
			this.lbSoLuong.AutoSize = true;
			this.lbSoLuong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbSoLuong.Location = new System.Drawing.Point(12, 100);
			this.lbSoLuong.Name = "lbSoLuong";
			this.lbSoLuong.Size = new System.Drawing.Size(57, 15);
			this.lbSoLuong.TabIndex = 13;
			this.lbSoLuong.Text = "Số lượng:";
			// 
			// lbGia
			// 
			this.lbGia.AutoSize = true;
			this.lbGia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbGia.Location = new System.Drawing.Point(12, 61);
			this.lbGia.Name = "lbGia";
			this.lbGia.Size = new System.Drawing.Size(27, 15);
			this.lbGia.TabIndex = 12;
			this.lbGia.Text = "Giá:";
			// 
			// lbMonAn
			// 
			this.lbMonAn.AutoSize = true;
			this.lbMonAn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbMonAn.Location = new System.Drawing.Point(12, 20);
			this.lbMonAn.Name = "lbMonAn";
			this.lbMonAn.Size = new System.Drawing.Size(72, 15);
			this.lbMonAn.TabIndex = 11;
			this.lbMonAn.Text = "Tên món ăn:";
			// 
			// tbMonAn
			// 
			this.tbMonAn.Location = new System.Drawing.Point(103, 17);
			this.tbMonAn.Name = "tbMonAn";
			this.tbMonAn.Size = new System.Drawing.Size(252, 23);
			this.tbMonAn.TabIndex = 10;
			// 
			// btnXoa
			// 
			this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnXoa.Location = new System.Drawing.Point(280, 139);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 9;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSua.Location = new System.Drawing.Point(103, 139);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 8;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// SuaMonAn
			// 
			this.AcceptButton = this.btnSua;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnXoa;
			this.ClientSize = new System.Drawing.Size(367, 179);
			this.Controls.Add(this.tbSoLuong);
			this.Controls.Add(this.tbGia);
			this.Controls.Add(this.lbSoLuong);
			this.Controls.Add(this.lbGia);
			this.Controls.Add(this.lbMonAn);
			this.Controls.Add(this.tbMonAn);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Name = "SuaMonAn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sửa món ăn";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbSoLuong;
		private System.Windows.Forms.TextBox tbGia;
		private System.Windows.Forms.Label lbSoLuong;
		private System.Windows.Forms.Label lbGia;
		private System.Windows.Forms.Label lbMonAn;
		private System.Windows.Forms.TextBox tbMonAn;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
	}
}