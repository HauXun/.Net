﻿
namespace Main.Pages
{
	partial class Statistical
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitle = new System.Windows.Forms.Label();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.pnlDataGridView = new System.Windows.Forms.Panel();
			this.pnlDataGridViewShadow = new System.Windows.Forms.Panel();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.btnClearFilter = new FontAwesome.Sharp.IconButton();
			this.SemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlDataGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(85, 20);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(456, 37);
			this.lbTitle.TabIndex = 14;
			this.lbTitle.Text = "Thống kê chương trình đào tạo";
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(45, 23);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 30;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			// 
			// pnlDataGridView
			// 
			this.pnlDataGridView.BackColor = System.Drawing.Color.White;
			this.pnlDataGridView.Controls.Add(this.aDgvdata);
			this.pnlDataGridView.Controls.Add(this.btnClearFilter);
			this.pnlDataGridView.Location = new System.Drawing.Point(11, 80);
			this.pnlDataGridView.Name = "pnlDataGridView";
			this.pnlDataGridView.Size = new System.Drawing.Size(1526, 729);
			this.pnlDataGridView.TabIndex = 38;
			// 
			// pnlDataGridViewShadow
			// 
			this.pnlDataGridViewShadow.BackColor = System.Drawing.Color.Silver;
			this.pnlDataGridViewShadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnlDataGridViewShadow.Location = new System.Drawing.Point(14, 83);
			this.pnlDataGridViewShadow.Name = "pnlDataGridViewShadow";
			this.pnlDataGridViewShadow.Size = new System.Drawing.Size(1526, 729);
			this.pnlDataGridViewShadow.TabIndex = 39;
			// 
			// aDgvdata
			// 
			this.aDgvdata.AllowUserToAddRows = false;
			this.aDgvdata.AllowUserToDeleteRows = false;
			this.aDgvdata.AllowUserToResizeRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
			this.aDgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.aDgvdata.AutoGenerateContextFilters = true;
			this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.aDgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
			this.aDgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aDgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.aDgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.aDgvdata.ColumnHeadersHeight = 40;
			this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.aDgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SemesterID,
            this.SubjectName,
            this.SubjectID,
            this.RoleName,
            this.FacultyName,
            this.CourseID});
			this.aDgvdata.DateWithTime = false;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle16;
			this.aDgvdata.EnableHeadersVisualStyles = false;
			this.aDgvdata.Location = new System.Drawing.Point(14, 55);
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.aDgvdata.RowHeadersVisible = false;
			this.aDgvdata.RowTemplate.Height = 50;
			this.aDgvdata.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1498, 665);
			this.aDgvdata.TabIndex = 12;
			this.aDgvdata.TimeFilter = false;
			this.aDgvdata.SortStringChanged += new System.EventHandler(this.aDgvdata_SortStringChanged);
			this.aDgvdata.FilterStringChanged += new System.EventHandler(this.aDgvdata_FilterStringChanged);
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.BackColor = System.Drawing.Color.Gainsboro;
			this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClearFilter.FlatAppearance.BorderSize = 0;
			this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFilter.ForeColor = System.Drawing.Color.White;
			this.btnClearFilter.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
			this.btnClearFilter.IconColor = System.Drawing.SystemColors.WindowText;
			this.btnClearFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnClearFilter.IconSize = 25;
			this.btnClearFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClearFilter.Location = new System.Drawing.Point(1456, 9);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(40, 40);
			this.btnClearFilter.TabIndex = 11;
			this.btnClearFilter.TabStop = false;
			this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClearFilter.UseVisualStyleBackColor = false;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			// 
			// SemesterID
			// 
			this.SemesterID.DataPropertyName = "SemesterID";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SemesterID.DefaultCellStyle = dataGridViewCellStyle11;
			this.SemesterID.FillWeight = 40F;
			this.SemesterID.HeaderText = "Học kì";
			this.SemesterID.MinimumWidth = 22;
			this.SemesterID.Name = "SemesterID";
			this.SemesterID.ReadOnly = true;
			this.SemesterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectName
			// 
			this.SubjectName.DataPropertyName = "SubjectName";
			this.SubjectName.FillWeight = 190F;
			this.SubjectName.HeaderText = "Tên môn thi";
			this.SubjectName.MinimumWidth = 22;
			this.SubjectName.Name = "SubjectName";
			this.SubjectName.ReadOnly = true;
			this.SubjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SubjectID.DefaultCellStyle = dataGridViewCellStyle12;
			this.SubjectID.FillWeight = 60F;
			this.SubjectID.HeaderText = "Mã môn";
			this.SubjectID.MinimumWidth = 22;
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// RoleName
			// 
			this.RoleName.DataPropertyName = "RoleName";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.RoleName.DefaultCellStyle = dataGridViewCellStyle13;
			this.RoleName.FillWeight = 60F;
			this.RoleName.HeaderText = "Kiểu môn";
			this.RoleName.MinimumWidth = 22;
			this.RoleName.Name = "RoleName";
			this.RoleName.ReadOnly = true;
			this.RoleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// FacultyName
			// 
			this.FacultyName.DataPropertyName = "FacultyName";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FacultyName.DefaultCellStyle = dataGridViewCellStyle14;
			this.FacultyName.FillWeight = 150F;
			this.FacultyName.HeaderText = "Học phần cho sinh viên khoa";
			this.FacultyName.MinimumWidth = 22;
			this.FacultyName.Name = "FacultyName";
			this.FacultyName.ReadOnly = true;
			this.FacultyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// CourseID
			// 
			this.CourseID.DataPropertyName = "CourseID";
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.CourseID.DefaultCellStyle = dataGridViewCellStyle15;
			this.CourseID.FillWeight = 50F;
			this.CourseID.HeaderText = "Dành cho khóa";
			this.CourseID.MinimumWidth = 22;
			this.CourseID.Name = "CourseID";
			this.CourseID.ReadOnly = true;
			this.CourseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Statistical
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlDataGridView);
			this.Controls.Add(this.pnlDataGridViewShadow);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Name = "Statistical";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmStatistical_Load);
			this.pnlDataGridView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton iconTitle;
		private System.Windows.Forms.Panel pnlDataGridView;
		private System.Windows.Forms.Panel pnlDataGridViewShadow;
		private ADGV.AdvancedDataGridView aDgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn SemesterID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
		private FontAwesome.Sharp.IconButton btnClearFilter;
	}
}