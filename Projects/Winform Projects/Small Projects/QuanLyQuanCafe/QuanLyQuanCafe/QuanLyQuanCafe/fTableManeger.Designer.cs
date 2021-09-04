
namespace QuanLyQuanCafe
{
	partial class fTableManeger
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nudFoodCount = new System.Windows.Forms.NumericUpDown();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.cbFood = new System.Windows.Forms.ComboBox();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lvBill = new System.Windows.Forms.ListView();
			this.clFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbTotalPrice = new System.Windows.Forms.TextBox();
			this.cbSwitchTable = new System.Windows.Forms.ComboBox();
			this.btnSwitchTable = new System.Windows.Forms.Button();
			this.nudDiscount = new System.Windows.Forms.NumericUpDown();
			this.btnCheck = new System.Windows.Forms.Button();
			this.lbDiscount = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(939, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// thôngTinCáNhânToolStripMenuItem
			// 
			this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
			this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
			this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.nudFoodCount);
			this.panel2.Controls.Add(this.btnAddFood);
			this.panel2.Controls.Add(this.cbFood);
			this.panel2.Controls.Add(this.cbCategory);
			this.panel2.Location = new System.Drawing.Point(541, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(386, 55);
			this.panel2.TabIndex = 2;
			// 
			// nudFoodCount
			// 
			this.nudFoodCount.Location = new System.Drawing.Point(330, 4);
			this.nudFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudFoodCount.Name = "nudFoodCount";
			this.nudFoodCount.Size = new System.Drawing.Size(53, 20);
			this.nudFoodCount.TabIndex = 3;
			this.nudFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAddFood
			// 
			this.btnAddFood.AutoSize = true;
			this.btnAddFood.Location = new System.Drawing.Point(249, 2);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(75, 23);
			this.btnAddFood.TabIndex = 2;
			this.btnAddFood.Text = "Thêm món";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// cbFood
			// 
			this.cbFood.FormattingEnabled = true;
			this.cbFood.Location = new System.Drawing.Point(3, 30);
			this.cbFood.Name = "cbFood";
			this.cbFood.Size = new System.Drawing.Size(240, 21);
			this.cbFood.TabIndex = 1;
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(3, 3);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(240, 21);
			this.cbCategory.TabIndex = 0;
			this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lvBill);
			this.panel4.Location = new System.Drawing.Point(541, 88);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(389, 432);
			this.panel4.TabIndex = 3;
			// 
			// lvBill
			// 
			this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clFoodName,
            this.clCount,
            this.clPrice,
            this.clTotalPrice});
			this.lvBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvBill.GridLines = true;
			this.lvBill.HideSelection = false;
			this.lvBill.Location = new System.Drawing.Point(0, 0);
			this.lvBill.Name = "lvBill";
			this.lvBill.Size = new System.Drawing.Size(389, 432);
			this.lvBill.TabIndex = 0;
			this.lvBill.UseCompatibleStateImageBehavior = false;
			this.lvBill.View = System.Windows.Forms.View.Details;
			// 
			// clFoodName
			// 
			this.clFoodName.Text = "Tên món";
			this.clFoodName.Width = 192;
			// 
			// clCount
			// 
			this.clCount.Text = "Số lượng";
			this.clCount.Width = 54;
			// 
			// clPrice
			// 
			this.clPrice.Text = "Giá";
			this.clPrice.Width = 51;
			// 
			// clTotalPrice
			// 
			this.clTotalPrice.Text = "Thành tiền";
			this.clTotalPrice.Width = 63;
			// 
			// flpTable
			// 
			this.flpTable.AutoScroll = true;
			this.flpTable.Location = new System.Drawing.Point(12, 33);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(523, 548);
			this.flpTable.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbDiscount);
			this.panel1.Controls.Add(this.tbTotalPrice);
			this.panel1.Controls.Add(this.cbSwitchTable);
			this.panel1.Controls.Add(this.btnSwitchTable);
			this.panel1.Controls.Add(this.nudDiscount);
			this.panel1.Controls.Add(this.btnCheck);
			this.panel1.Location = new System.Drawing.Point(541, 526);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(386, 55);
			this.panel1.TabIndex = 4;
			// 
			// tbTotalPrice
			// 
			this.tbTotalPrice.Location = new System.Drawing.Point(283, 29);
			this.tbTotalPrice.Name = "tbTotalPrice";
			this.tbTotalPrice.ReadOnly = true;
			this.tbTotalPrice.Size = new System.Drawing.Size(100, 20);
			this.tbTotalPrice.TabIndex = 5;
			this.tbTotalPrice.Text = "0đ";
			this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cbSwitchTable
			// 
			this.cbSwitchTable.FormattingEnabled = true;
			this.cbSwitchTable.Location = new System.Drawing.Point(4, 32);
			this.cbSwitchTable.Name = "cbSwitchTable";
			this.cbSwitchTable.Size = new System.Drawing.Size(75, 21);
			this.cbSwitchTable.TabIndex = 4;
			// 
			// btnSwitchTable
			// 
			this.btnSwitchTable.AutoSize = true;
			this.btnSwitchTable.Location = new System.Drawing.Point(4, 2);
			this.btnSwitchTable.Name = "btnSwitchTable";
			this.btnSwitchTable.Size = new System.Drawing.Size(75, 23);
			this.btnSwitchTable.TabIndex = 3;
			this.btnSwitchTable.Text = "Chuyển bàn";
			this.btnSwitchTable.UseVisualStyleBackColor = true;
			this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
			// 
			// nudDiscount
			// 
			this.nudDiscount.Location = new System.Drawing.Point(283, 3);
			this.nudDiscount.Name = "nudDiscount";
			this.nudDiscount.Size = new System.Drawing.Size(100, 20);
			this.nudDiscount.TabIndex = 2;
			this.nudDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCheck
			// 
			this.btnCheck.AutoSize = true;
			this.btnCheck.Location = new System.Drawing.Point(202, 29);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 0;
			this.btnCheck.Text = "Thanh toán";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// lbDiscount
			// 
			this.lbDiscount.AutoSize = true;
			this.lbDiscount.Location = new System.Drawing.Point(199, 5);
			this.lbDiscount.Name = "lbDiscount";
			this.lbDiscount.Size = new System.Drawing.Size(51, 13);
			this.lbDiscount.TabIndex = 6;
			this.lbDiscount.Text = "Giảm giá:";
			// 
			// fTableManeger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 593);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flpTable);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "fTableManeger";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý quán Cafe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.NumericUpDown nudFoodCount;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.ComboBox cbFood;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ListView lvBill;
		private System.Windows.Forms.FlowLayoutPanel flpTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown nudDiscount;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.ComboBox cbSwitchTable;
		private System.Windows.Forms.Button btnSwitchTable;
		private System.Windows.Forms.ColumnHeader clFoodName;
		private System.Windows.Forms.ColumnHeader clCount;
		private System.Windows.Forms.ColumnHeader clPrice;
		private System.Windows.Forms.ColumnHeader clTotalPrice;
		private System.Windows.Forms.TextBox tbTotalPrice;
		private System.Windows.Forms.Label lbDiscount;
	}
}