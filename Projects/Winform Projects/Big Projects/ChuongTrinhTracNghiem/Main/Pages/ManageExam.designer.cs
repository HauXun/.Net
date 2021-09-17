﻿
namespace Main.Pages
{
	partial class ManageExam
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitle = new System.Windows.Forms.Label();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.pnlDataGridView = new System.Windows.Forms.Panel();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QCurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClearFilter = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnCancle = new FontAwesome.Sharp.IconButton();
			this.btnSearch = new FontAwesome.Sharp.IconButton();
			this.pnlDataGridViewShadow = new System.Windows.Forms.Panel();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.pnlInfo2 = new System.Windows.Forms.Panel();
			this.cbSubject = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbExamRole = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbLoaiDe = new System.Windows.Forms.Label();
			this.lbMonThi = new System.Windows.Forms.Label();
			this.pnl2Shadow = new System.Windows.Forms.Panel();
			this.pnlInfo1 = new System.Windows.Forms.Panel();
			this.nudQCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.tbExamID = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbSoLuongCauHoi = new System.Windows.Forms.Label();
			this.lbThoiGianLamBai = new System.Windows.Forms.Label();
			this.nudExamTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.lbMaDe = new System.Windows.Forms.Label();
			this.pnl1Shadow = new System.Windows.Forms.Panel();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlDataGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			this.pnlControls.SuspendLayout();
			this.pnlInfo2.SuspendLayout();
			this.pnlInfo1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExamTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
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
			this.lbTitle.Size = new System.Drawing.Size(215, 37);
			this.lbTitle.TabIndex = 24;
			this.lbTitle.Text = "Quản lý đề thi";
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Edit;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(45, 23);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 0;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.White;
			this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAdd.IconSize = 28;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdd.Location = new System.Drawing.Point(1390, 23);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnAdd.Size = new System.Drawing.Size(110, 40);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnAdd, "Thêm đề thi");
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlDataGridView
			// 
			this.pnlDataGridView.BackColor = System.Drawing.Color.White;
			this.pnlDataGridView.Controls.Add(this.tbSearch);
			this.pnlDataGridView.Controls.Add(this.aDgvdata);
			this.pnlDataGridView.Controls.Add(this.btnClearFilter);
			this.pnlDataGridView.Controls.Add(this.btnEdit);
			this.pnlDataGridView.Controls.Add(this.btnDelete);
			this.pnlDataGridView.Controls.Add(this.btnSave);
			this.pnlDataGridView.Controls.Add(this.btnCancle);
			this.pnlDataGridView.Controls.Add(this.btnSearch);
			this.pnlDataGridView.Location = new System.Drawing.Point(11, 291);
			this.pnlDataGridView.Name = "pnlDataGridView";
			this.pnlDataGridView.Size = new System.Drawing.Size(1526, 518);
			this.pnlDataGridView.TabIndex = 25;
			// 
			// tbSearch
			// 
			this.tbSearch.BorderColor = System.Drawing.Color.Gray;
			this.tbSearch.BorderRadius = 5;
			this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearch.DefaultText = "";
			this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.DisabledState.Parent = this.tbSearch;
			this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.FocusedState.Parent = this.tbSearch;
			this.tbSearch.Font = new System.Drawing.Font("Arial", 12F);
			this.tbSearch.ForeColor = System.Drawing.Color.Black;
			this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.HoverState.Parent = this.tbSearch;
			this.tbSearch.Location = new System.Drawing.Point(39, 24);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Nhập từ khóa ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
			this.tbSearch.Size = new System.Drawing.Size(281, 35);
			this.tbSearch.TabIndex = 8;
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// aDgvdata
			// 
			this.aDgvdata.AllowUserToAddRows = false;
			this.aDgvdata.AllowUserToDeleteRows = false;
			this.aDgvdata.AllowUserToResizeRows = false;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
			this.aDgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.aDgvdata.AutoGenerateContextFilters = true;
			this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.aDgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
			this.aDgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aDgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.aDgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.aDgvdata.ColumnHeadersHeight = 40;
			this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.aDgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ExamID,
            this.SubjectID,
            this.ExamRole,
            this.ExamTime,
            this.QCount,
            this.QCurrentCount});
			this.aDgvdata.DateWithTime = false;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle20;
			this.aDgvdata.EnableHeadersVisualStyles = false;
			this.aDgvdata.Location = new System.Drawing.Point(14, 79);
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.aDgvdata.RowHeadersVisible = false;
			this.aDgvdata.RowTemplate.Height = 50;
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1498, 425);
			this.aDgvdata.TabIndex = 7;
			this.aDgvdata.TimeFilter = false;
			this.aDgvdata.SortStringChanged += new System.EventHandler(this.aDgvdata_SortStringChanged);
			this.aDgvdata.FilterStringChanged += new System.EventHandler(this.aDgvdata_FilterStringChanged);
			this.aDgvdata.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDgvdata_RowEnter);
			this.aDgvdata.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.aDgvdata_RowPrePaint);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STT.DefaultCellStyle = dataGridViewCellStyle13;
			this.STT.FillWeight = 60F;
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 22;
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamID
			// 
			this.ExamID.DataPropertyName = "ExamID";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ExamID.DefaultCellStyle = dataGridViewCellStyle14;
			this.ExamID.HeaderText = "Mã đề";
			this.ExamID.MinimumWidth = 22;
			this.ExamID.Name = "ExamID";
			this.ExamID.ReadOnly = true;
			this.ExamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SubjectID.DefaultCellStyle = dataGridViewCellStyle15;
			this.SubjectID.FillWeight = 200F;
			this.SubjectID.HeaderText = "Môn thi";
			this.SubjectID.MinimumWidth = 22;
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamRole
			// 
			this.ExamRole.DataPropertyName = "ExamRole";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ExamRole.DefaultCellStyle = dataGridViewCellStyle16;
			this.ExamRole.HeaderText = "Loại đề";
			this.ExamRole.MinimumWidth = 22;
			this.ExamRole.Name = "ExamRole";
			this.ExamRole.ReadOnly = true;
			this.ExamRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamTime
			// 
			this.ExamTime.DataPropertyName = "ExamTime";
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ExamTime.DefaultCellStyle = dataGridViewCellStyle17;
			this.ExamTime.HeaderText = "Thời gian làm bài";
			this.ExamTime.MinimumWidth = 22;
			this.ExamTime.Name = "ExamTime";
			this.ExamTime.ReadOnly = true;
			this.ExamTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// QCount
			// 
			this.QCount.DataPropertyName = "QCount";
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.QCount.DefaultCellStyle = dataGridViewCellStyle18;
			this.QCount.HeaderText = "Số lượng câu hỏi";
			this.QCount.MinimumWidth = 22;
			this.QCount.Name = "QCount";
			this.QCount.ReadOnly = true;
			this.QCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// QCurrentCount
			// 
			this.QCurrentCount.DataPropertyName = "QCurrentCount";
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.QCurrentCount.DefaultCellStyle = dataGridViewCellStyle19;
			this.QCurrentCount.HeaderText = "Số lượng câu hỏi hiện tại";
			this.QCurrentCount.MinimumWidth = 22;
			this.QCurrentCount.Name = "QCurrentCount";
			this.QCurrentCount.ReadOnly = true;
			this.QCurrentCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			this.btnClearFilter.IconSize = 28;
			this.btnClearFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClearFilter.Location = new System.Drawing.Point(325, 21);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(40, 40);
			this.btnClearFilter.TabIndex = 2;
			this.btnClearFilter.TabStop = false;
			this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnClearFilter, "Hủy thao tác lọc dữ liệu");
			this.btnClearFilter.UseVisualStyleBackColor = false;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
			this.btnEdit.IconColor = System.Drawing.Color.White;
			this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEdit.IconSize = 28;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEdit.Location = new System.Drawing.Point(1250, 21);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnEdit.Size = new System.Drawing.Size(110, 40);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.TabStop = false;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnEdit, "Sửa đề thi");
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnDelete.IconColor = System.Drawing.Color.White;
			this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDelete.IconSize = 28;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDelete.Location = new System.Drawing.Point(1378, 21);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnDelete.Size = new System.Drawing.Size(110, 40);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = " Xóa";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnDelete, "Xóa đề thi");
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Green;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
			this.btnSave.IconColor = System.Drawing.Color.White;
			this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSave.IconSize = 28;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Location = new System.Drawing.Point(1378, 21);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 4;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnSave, "Lưu dữ liệu");
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.BackColor = System.Drawing.Color.DarkGray;
			this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancle.FlatAppearance.BorderSize = 0;
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnCancle.ForeColor = System.Drawing.Color.White;
			this.btnCancle.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
			this.btnCancle.IconColor = System.Drawing.Color.White;
			this.btnCancle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancle.IconSize = 28;
			this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancle.Location = new System.Drawing.Point(1250, 21);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCancle.Size = new System.Drawing.Size(110, 40);
			this.btnCancle.TabIndex = 3;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnCancle, "Hủy thao tác");
			this.btnCancle.UseVisualStyleBackColor = false;
			this.btnCancle.Visible = false;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.Gray;
			this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSearch.IconSize = 30;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSearch.Location = new System.Drawing.Point(288, 26);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(30, 30);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.TabStop = false;
			this.toolTip.SetToolTip(this.btnSearch, "Tìm kiếm");
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// pnlDataGridViewShadow
			// 
			this.pnlDataGridViewShadow.BackColor = System.Drawing.Color.Silver;
			this.pnlDataGridViewShadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnlDataGridViewShadow.Location = new System.Drawing.Point(14, 294);
			this.pnlDataGridViewShadow.Name = "pnlDataGridViewShadow";
			this.pnlDataGridViewShadow.Size = new System.Drawing.Size(1526, 518);
			this.pnlDataGridViewShadow.TabIndex = 26;
			// 
			// pnlControls
			// 
			this.pnlControls.BackColor = System.Drawing.Color.Transparent;
			this.pnlControls.Controls.Add(this.pnlInfo2);
			this.pnlControls.Controls.Add(this.pnl2Shadow);
			this.pnlControls.Controls.Add(this.pnlInfo1);
			this.pnlControls.Controls.Add(this.pnl1Shadow);
			this.pnlControls.Location = new System.Drawing.Point(25, 69);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(1498, 216);
			this.pnlControls.TabIndex = 34;
			// 
			// pnlInfo2
			// 
			this.pnlInfo2.BackColor = System.Drawing.Color.White;
			this.pnlInfo2.Controls.Add(this.cbSubject);
			this.pnlInfo2.Controls.Add(this.cbExamRole);
			this.pnlInfo2.Controls.Add(this.lbLoaiDe);
			this.pnlInfo2.Controls.Add(this.lbMonThi);
			this.pnlInfo2.Location = new System.Drawing.Point(783, 23);
			this.pnlInfo2.Name = "pnlInfo2";
			this.pnlInfo2.Size = new System.Drawing.Size(498, 168);
			this.pnlInfo2.TabIndex = 23;
			// 
			// cbSubject
			// 
			this.cbSubject.BackColor = System.Drawing.Color.White;
			this.cbSubject.BorderRadius = 4;
			this.cbSubject.Color = System.Drawing.Color.Gray;
			this.cbSubject.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbSubject.DisabledColor = System.Drawing.Color.Gray;
			this.cbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSubject.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
			this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubject.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbSubject.FillDropDown = false;
			this.cbSubject.FillIndicator = false;
			this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbSubject.Font = new System.Drawing.Font("Arial", 14.25F);
			this.cbSubject.ForeColor = System.Drawing.Color.Black;
			this.cbSubject.FormattingEnabled = true;
			this.cbSubject.Icon = null;
			this.cbSubject.IndicatorColor = System.Drawing.Color.Black;
			this.cbSubject.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbSubject.ItemBackColor = System.Drawing.Color.White;
			this.cbSubject.ItemBorderColor = System.Drawing.Color.White;
			this.cbSubject.ItemForeColor = System.Drawing.Color.Black;
			this.cbSubject.ItemHeight = 30;
			this.cbSubject.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbSubject.Location = new System.Drawing.Point(25, 36);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(447, 36);
			this.cbSubject.TabIndex = 44;
			this.cbSubject.Text = null;
			// 
			// cbExamRole
			// 
			this.cbExamRole.BackColor = System.Drawing.Color.White;
			this.cbExamRole.BorderRadius = 4;
			this.cbExamRole.Color = System.Drawing.Color.Gray;
			this.cbExamRole.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbExamRole.DisabledColor = System.Drawing.Color.Gray;
			this.cbExamRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbExamRole.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
			this.cbExamRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbExamRole.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbExamRole.FillDropDown = false;
			this.cbExamRole.FillIndicator = false;
			this.cbExamRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbExamRole.Font = new System.Drawing.Font("Arial", 14.25F);
			this.cbExamRole.ForeColor = System.Drawing.Color.Black;
			this.cbExamRole.FormattingEnabled = true;
			this.cbExamRole.Icon = null;
			this.cbExamRole.IndicatorColor = System.Drawing.Color.Black;
			this.cbExamRole.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbExamRole.ItemBackColor = System.Drawing.Color.White;
			this.cbExamRole.ItemBorderColor = System.Drawing.Color.White;
			this.cbExamRole.ItemForeColor = System.Drawing.Color.Black;
			this.cbExamRole.ItemHeight = 30;
			this.cbExamRole.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbExamRole.Location = new System.Drawing.Point(25, 111);
			this.cbExamRole.Name = "cbExamRole";
			this.cbExamRole.Size = new System.Drawing.Size(447, 36);
			this.cbExamRole.TabIndex = 44;
			this.cbExamRole.Text = null;
			// 
			// lbLoaiDe
			// 
			this.lbLoaiDe.AutoSize = true;
			this.lbLoaiDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLoaiDe.Location = new System.Drawing.Point(32, 88);
			this.lbLoaiDe.Name = "lbLoaiDe";
			this.lbLoaiDe.Size = new System.Drawing.Size(65, 20);
			this.lbLoaiDe.TabIndex = 4;
			this.lbLoaiDe.Text = "Loại đề:";
			// 
			// lbMonThi
			// 
			this.lbMonThi.AutoSize = true;
			this.lbMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMonThi.Location = new System.Drawing.Point(32, 14);
			this.lbMonThi.Name = "lbMonThi";
			this.lbMonThi.Size = new System.Drawing.Size(65, 20);
			this.lbMonThi.TabIndex = 2;
			this.lbMonThi.Text = "Môn thi:";
			// 
			// pnl2Shadow
			// 
			this.pnl2Shadow.BackColor = System.Drawing.Color.Silver;
			this.pnl2Shadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnl2Shadow.Location = new System.Drawing.Point(786, 26);
			this.pnl2Shadow.Name = "pnl2Shadow";
			this.pnl2Shadow.Size = new System.Drawing.Size(498, 168);
			this.pnl2Shadow.TabIndex = 25;
			// 
			// pnlInfo1
			// 
			this.pnlInfo1.BackColor = System.Drawing.Color.White;
			this.pnlInfo1.Controls.Add(this.nudQCount);
			this.pnlInfo1.Controls.Add(this.tbExamID);
			this.pnlInfo1.Controls.Add(this.lbSoLuongCauHoi);
			this.pnlInfo1.Controls.Add(this.lbThoiGianLamBai);
			this.pnlInfo1.Controls.Add(this.nudExamTime);
			this.pnlInfo1.Controls.Add(this.lbMaDe);
			this.pnlInfo1.Location = new System.Drawing.Point(215, 23);
			this.pnlInfo1.Name = "pnlInfo1";
			this.pnlInfo1.Size = new System.Drawing.Size(498, 168);
			this.pnlInfo1.TabIndex = 22;
			// 
			// nudQCount
			// 
			this.nudQCount.BackColor = System.Drawing.Color.White;
			this.nudQCount.BorderColor = System.Drawing.Color.Gray;
			this.nudQCount.BorderRadius = 5;
			this.nudQCount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudQCount.DisabledState.Parent = this.nudQCount;
			this.nudQCount.FocusedState.Parent = this.nudQCount;
			this.nudQCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudQCount.ForeColor = System.Drawing.Color.Black;
			this.nudQCount.Location = new System.Drawing.Point(257, 112);
			this.nudQCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.nudQCount.Name = "nudQCount";
			this.nudQCount.ShadowDecoration.Parent = this.nudQCount;
			this.nudQCount.Size = new System.Drawing.Size(215, 36);
			this.nudQCount.TabIndex = 1;
			this.nudQCount.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
			// 
			// tbExamID
			// 
			this.tbExamID.BorderColor = System.Drawing.Color.Gray;
			this.tbExamID.BorderRadius = 5;
			this.tbExamID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbExamID.DefaultText = "";
			this.tbExamID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbExamID.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbExamID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbExamID.DisabledState.Parent = this.tbExamID;
			this.tbExamID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbExamID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbExamID.FocusedState.Parent = this.tbExamID;
			this.tbExamID.Font = new System.Drawing.Font("Arial", 14.25F);
			this.tbExamID.ForeColor = System.Drawing.Color.Black;
			this.tbExamID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbExamID.HoverState.Parent = this.tbExamID;
			this.tbExamID.Location = new System.Drawing.Point(25, 36);
			this.tbExamID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbExamID.Name = "tbExamID";
			this.tbExamID.PasswordChar = '\0';
			this.tbExamID.PlaceholderText = "";
			this.tbExamID.SelectedText = "";
			this.tbExamID.ShadowDecoration.Parent = this.tbExamID;
			this.tbExamID.Size = new System.Drawing.Size(447, 36);
			this.tbExamID.TabIndex = 4;
			// 
			// lbSoLuongCauHoi
			// 
			this.lbSoLuongCauHoi.AutoSize = true;
			this.lbSoLuongCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoLuongCauHoi.Location = new System.Drawing.Point(264, 88);
			this.lbSoLuongCauHoi.Name = "lbSoLuongCauHoi";
			this.lbSoLuongCauHoi.Size = new System.Drawing.Size(131, 20);
			this.lbSoLuongCauHoi.TabIndex = 2;
			this.lbSoLuongCauHoi.Text = "Số lượng câu hỏi:";
			// 
			// lbThoiGianLamBai
			// 
			this.lbThoiGianLamBai.AutoSize = true;
			this.lbThoiGianLamBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThoiGianLamBai.Location = new System.Drawing.Point(32, 88);
			this.lbThoiGianLamBai.Name = "lbThoiGianLamBai";
			this.lbThoiGianLamBai.Size = new System.Drawing.Size(131, 20);
			this.lbThoiGianLamBai.TabIndex = 0;
			this.lbThoiGianLamBai.Text = "Thời gian làm bài:";
			// 
			// nudExamTime
			// 
			this.nudExamTime.BackColor = System.Drawing.Color.White;
			this.nudExamTime.BorderColor = System.Drawing.Color.Gray;
			this.nudExamTime.BorderRadius = 5;
			this.nudExamTime.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudExamTime.DisabledState.Parent = this.nudExamTime;
			this.nudExamTime.FocusedState.Parent = this.nudExamTime;
			this.nudExamTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudExamTime.ForeColor = System.Drawing.Color.Black;
			this.nudExamTime.Location = new System.Drawing.Point(25, 112);
			this.nudExamTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.nudExamTime.Name = "nudExamTime";
			this.nudExamTime.ShadowDecoration.Parent = this.nudExamTime;
			this.nudExamTime.Size = new System.Drawing.Size(215, 36);
			this.nudExamTime.TabIndex = 0;
			this.nudExamTime.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
			// 
			// lbMaDe
			// 
			this.lbMaDe.AutoSize = true;
			this.lbMaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaDe.Location = new System.Drawing.Point(32, 14);
			this.lbMaDe.Name = "lbMaDe";
			this.lbMaDe.Size = new System.Drawing.Size(57, 20);
			this.lbMaDe.TabIndex = 0;
			this.lbMaDe.Text = "Mã đề:";
			// 
			// pnl1Shadow
			// 
			this.pnl1Shadow.BackColor = System.Drawing.Color.Silver;
			this.pnl1Shadow.ForeColor = System.Drawing.SystemColors.InfoText;
			this.pnl1Shadow.Location = new System.Drawing.Point(218, 26);
			this.pnl1Shadow.Name = "pnl1Shadow";
			this.pnl1Shadow.Size = new System.Drawing.Size(498, 168);
			this.pnl1Shadow.TabIndex = 24;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 0;
			this.toolTip.AutoPopDelay = 10000;
			this.toolTip.InitialDelay = 0;
			this.toolTip.ReshowDelay = 0;
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip.ToolTipTitle = "Suggest";
			// 
			// ManageExam
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlControls);
			this.Controls.Add(this.pnlDataGridView);
			this.Controls.Add(this.pnlDataGridViewShadow);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Name = "ManageExam";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmManageExam_Load);
			this.pnlDataGridView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			this.pnlControls.ResumeLayout(false);
			this.pnlInfo2.ResumeLayout(false);
			this.pnlInfo2.PerformLayout();
			this.pnlInfo1.ResumeLayout(false);
			this.pnlInfo1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExamTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton iconTitle;
        private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.Panel pnlDataGridView;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private ADGV.AdvancedDataGridView aDgvdata;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnDelete;
		public FontAwesome.Sharp.IconButton btnSave;
		public FontAwesome.Sharp.IconButton btnCancle;
		private FontAwesome.Sharp.IconButton btnSearch;
		private System.Windows.Forms.Panel pnlDataGridViewShadow;
		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Panel pnlInfo2;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudQCount;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudExamTime;
		private System.Windows.Forms.Label lbSoLuongCauHoi;
		private System.Windows.Forms.Label lbLoaiDe;
		private System.Windows.Forms.Label lbThoiGianLamBai;
		private System.Windows.Forms.Panel pnl2Shadow;
		private System.Windows.Forms.Panel pnlInfo1;
		private Guna.UI2.WinForms.Guna2TextBox tbExamID;
		private System.Windows.Forms.Label lbMonThi;
		private System.Windows.Forms.Label lbMaDe;
		private System.Windows.Forms.Panel pnl1Shadow;
		private Bunifu.UI.WinForms.BunifuDropdown cbExamRole;
		private Bunifu.UI.WinForms.BunifuDropdown cbSubject;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn QCurrentCount;
		private System.Windows.Forms.ToolTip toolTip;
	}
}