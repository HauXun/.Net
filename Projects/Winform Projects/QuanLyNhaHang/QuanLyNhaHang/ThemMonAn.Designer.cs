
namespace QuanLyNhaHang
{
	partial class ThemMonAn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemMonAn));
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.tbMonAn = new System.Windows.Forms.TextBox();
			this.lbMonAn = new System.Windows.Forms.Label();
			this.lbGia = new System.Windows.Forms.Label();
			this.lbSoLuong = new System.Windows.Forms.Label();
			this.tbGia = new System.Windows.Forms.TextBox();
			this.tbSoLuong = new System.Windows.Forms.TextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			resources.ApplyResources(this.btnThem, "btnThem");
			this.btnThem.Name = "btnThem";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			resources.ApplyResources(this.btnXoa, "btnXoa");
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// tbMonAn
			// 
			resources.ApplyResources(this.tbMonAn, "tbMonAn");
			this.tbMonAn.Name = "tbMonAn";
			// 
			// lbMonAn
			// 
			resources.ApplyResources(this.lbMonAn, "lbMonAn");
			this.lbMonAn.Name = "lbMonAn";
			// 
			// lbGia
			// 
			resources.ApplyResources(this.lbGia, "lbGia");
			this.lbGia.Name = "lbGia";
			// 
			// lbSoLuong
			// 
			resources.ApplyResources(this.lbSoLuong, "lbSoLuong");
			this.lbSoLuong.Name = "lbSoLuong";
			// 
			// tbGia
			// 
			resources.ApplyResources(this.tbGia, "tbGia");
			this.tbGia.Name = "tbGia";
			// 
			// tbSoLuong
			// 
			resources.ApplyResources(this.tbSoLuong, "tbSoLuong");
			this.tbSoLuong.Name = "tbSoLuong";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// ThemMonAn
			// 
			this.AcceptButton = this.btnThem;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnXoa;
			this.Controls.Add(this.tbSoLuong);
			this.Controls.Add(this.tbGia);
			this.Controls.Add(this.lbSoLuong);
			this.Controls.Add(this.lbGia);
			this.Controls.Add(this.lbMonAn);
			this.Controls.Add(this.tbMonAn);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ThemMonAn";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.TextBox tbMonAn;
		private System.Windows.Forms.Label lbMonAn;
		private System.Windows.Forms.Label lbGia;
		private System.Windows.Forms.Label lbSoLuong;
		private System.Windows.Forms.TextBox tbGia;
		private System.Windows.Forms.TextBox tbSoLuong;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
	}
}