
namespace Main.Pages
{
	partial class ManageQuestion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageQuestion));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitle = new System.Windows.Forms.Label();
			this.iconTitle = new FontAwesome.Sharp.IconButton();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.pnlInfo3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.tbAnswerCorrect = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbDapAnDung = new System.Windows.Forms.Label();
			this.pnlInfo2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.cbExamID = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbMaDe = new System.Windows.Forms.Label();
			this.cbSubject = new Bunifu.UI.WinForms.BunifuDropdown();
			this.lbMaCauHoi = new System.Windows.Forms.Label();
			this.tbQuestionID = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbMonThi = new System.Windows.Forms.Label();
			this.pnlInfo1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.tbAnswerD = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbNoiDung = new System.Windows.Forms.Label();
			this.tbAnswerC = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbDapAnD = new System.Windows.Forms.Label();
			this.tbAnswerB = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbDapAnC = new System.Windows.Forms.Label();
			this.tbAnswerA = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbDapAnB = new System.Windows.Forms.Label();
			this.tbContent = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbDapAnA = new System.Windows.Forms.Label();
			this.bScrollBar = new Bunifu.UI.WinForms.BunifuVSlider();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.aDgvdata = new ADGV.AdvancedDataGridView();
			this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClearFilter = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnCancle = new FontAwesome.Sharp.IconButton();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.btnImportFiles = new FontAwesome.Sharp.IconButton();
			this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pnlControls.SuspendLayout();
			this.pnlInfo3.SuspendLayout();
			this.pnlInfo2.SuspendLayout();
			this.pnlInfo1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.guna2ShadowPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.lbTitle.Location = new System.Drawing.Point(110, 20);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(242, 35);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Quản lý câu hỏi";
			this.lbTitle.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// iconTitle
			// 
			this.iconTitle.BackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.BorderSize = 0;
			this.iconTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.iconTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Question;
			this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconTitle.IconSize = 35;
			this.iconTitle.Location = new System.Drawing.Point(70, 23);
			this.iconTitle.Name = "iconTitle";
			this.iconTitle.Size = new System.Drawing.Size(35, 37);
			this.iconTitle.TabIndex = 0;
			this.iconTitle.TabStop = false;
			this.iconTitle.UseVisualStyleBackColor = false;
			this.iconTitle.Click += new System.EventHandler(this.ManageQuestion_Click);
			this.iconTitle.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.White;
			this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAdd.IconSize = 28;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdd.Location = new System.Drawing.Point(1365, 23);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnAdd.Size = new System.Drawing.Size(110, 40);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.TabStop = false;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnAdd, "Thêm câu hỏi");
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnAdd.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// pnlControls
			// 
			this.pnlControls.BackColor = System.Drawing.Color.Transparent;
			this.pnlControls.Controls.Add(this.pnlInfo3);
			this.pnlControls.Controls.Add(this.pnlInfo2);
			this.pnlControls.Controls.Add(this.pnlInfo1);
			this.pnlControls.Location = new System.Drawing.Point(25, 70);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(1500, 340);
			this.pnlControls.TabIndex = 0;
			this.pnlControls.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// pnlInfo3
			// 
			this.pnlInfo3.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfo3.Controls.Add(this.tbAnswerCorrect);
			this.pnlInfo3.Controls.Add(this.lbDapAnDung);
			this.pnlInfo3.FillColor = System.Drawing.Color.White;
			this.pnlInfo3.Location = new System.Drawing.Point(1055, 225);
			this.pnlInfo3.Name = "pnlInfo3";
			this.pnlInfo3.Radius = 5;
			this.pnlInfo3.ShadowColor = System.Drawing.Color.Black;
			this.pnlInfo3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlInfo3.Size = new System.Drawing.Size(400, 90);
			this.pnlInfo3.TabIndex = 0;
			this.pnlInfo3.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// tbAnswerCorrect
			// 
			this.tbAnswerCorrect.BorderColor = System.Drawing.Color.Gray;
			this.tbAnswerCorrect.BorderRadius = 5;
			this.tbAnswerCorrect.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAnswerCorrect.DefaultText = "";
			this.tbAnswerCorrect.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAnswerCorrect.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbAnswerCorrect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerCorrect.DisabledState.Parent = this.tbAnswerCorrect;
			this.tbAnswerCorrect.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerCorrect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerCorrect.FocusedState.Parent = this.tbAnswerCorrect;
			this.tbAnswerCorrect.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnswerCorrect.ForeColor = System.Drawing.Color.Black;
			this.tbAnswerCorrect.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerCorrect.HoverState.Parent = this.tbAnswerCorrect;
			this.tbAnswerCorrect.Location = new System.Drawing.Point(22, 33);
			this.tbAnswerCorrect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbAnswerCorrect.Name = "tbAnswerCorrect";
			this.tbAnswerCorrect.PasswordChar = '\0';
			this.tbAnswerCorrect.PlaceholderText = "";
			this.tbAnswerCorrect.SelectedText = "";
			this.tbAnswerCorrect.ShadowDecoration.Parent = this.tbAnswerCorrect;
			this.tbAnswerCorrect.Size = new System.Drawing.Size(350, 36);
			this.tbAnswerCorrect.TabIndex = 7;
			this.tbAnswerCorrect.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbDapAnDung
			// 
			this.lbDapAnDung.AutoSize = true;
			this.lbDapAnDung.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDapAnDung.Location = new System.Drawing.Point(29, 9);
			this.lbDapAnDung.Name = "lbDapAnDung";
			this.lbDapAnDung.Size = new System.Drawing.Size(119, 18);
			this.lbDapAnDung.TabIndex = 0;
			this.lbDapAnDung.Text = "Đáp án đúng:";
			this.lbDapAnDung.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// pnlInfo2
			// 
			this.pnlInfo2.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfo2.Controls.Add(this.cbExamID);
			this.pnlInfo2.Controls.Add(this.lbMaDe);
			this.pnlInfo2.Controls.Add(this.cbSubject);
			this.pnlInfo2.Controls.Add(this.lbMaCauHoi);
			this.pnlInfo2.Controls.Add(this.tbQuestionID);
			this.pnlInfo2.Controls.Add(this.lbMonThi);
			this.pnlInfo2.FillColor = System.Drawing.Color.White;
			this.pnlInfo2.Location = new System.Drawing.Point(1055, 20);
			this.pnlInfo2.Name = "pnlInfo2";
			this.pnlInfo2.Radius = 5;
			this.pnlInfo2.ShadowColor = System.Drawing.Color.Black;
			this.pnlInfo2.ShadowDepth = 150;
			this.pnlInfo2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlInfo2.Size = new System.Drawing.Size(400, 170);
			this.pnlInfo2.TabIndex = 0;
			this.pnlInfo2.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// cbExamID
			// 
			this.cbExamID.BackColor = System.Drawing.Color.Transparent;
			this.cbExamID.BorderRadius = 4;
			this.cbExamID.Color = System.Drawing.Color.Gray;
			this.cbExamID.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbExamID.DisabledColor = System.Drawing.Color.Gray;
			this.cbExamID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbExamID.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbExamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbExamID.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbExamID.FillDropDown = false;
			this.cbExamID.FillIndicator = false;
			this.cbExamID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbExamID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbExamID.ForeColor = System.Drawing.Color.Black;
			this.cbExamID.FormattingEnabled = true;
			this.cbExamID.Icon = null;
			this.cbExamID.IndicatorColor = System.Drawing.Color.Black;
			this.cbExamID.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbExamID.ItemBackColor = System.Drawing.Color.White;
			this.cbExamID.ItemBorderColor = System.Drawing.Color.White;
			this.cbExamID.ItemForeColor = System.Drawing.Color.Black;
			this.cbExamID.ItemHeight = 30;
			this.cbExamID.ItemHighLightColor = System.Drawing.Color.GhostWhite;
			this.cbExamID.Location = new System.Drawing.Point(212, 39);
			this.cbExamID.Name = "cbExamID";
			this.cbExamID.Size = new System.Drawing.Size(160, 36);
			this.cbExamID.TabIndex = 0;
			this.cbExamID.TabStop = false;
			this.cbExamID.Text = null;
			this.cbExamID.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbMaDe
			// 
			this.lbMaDe.AutoSize = true;
			this.lbMaDe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaDe.Location = new System.Drawing.Point(217, 15);
			this.lbMaDe.Name = "lbMaDe";
			this.lbMaDe.Size = new System.Drawing.Size(64, 18);
			this.lbMaDe.TabIndex = 0;
			this.lbMaDe.Text = "Mã đề:";
			this.lbMaDe.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// cbSubject
			// 
			this.cbSubject.BackColor = System.Drawing.Color.Transparent;
			this.cbSubject.BorderRadius = 4;
			this.cbSubject.Color = System.Drawing.Color.Gray;
			this.cbSubject.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbSubject.DisabledColor = System.Drawing.Color.Gray;
			this.cbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSubject.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubject.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbSubject.FillDropDown = false;
			this.cbSubject.FillIndicator = false;
			this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbSubject.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.cbSubject.Location = new System.Drawing.Point(22, 109);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.Size = new System.Drawing.Size(350, 36);
			this.cbSubject.TabIndex = 0;
			this.cbSubject.TabStop = false;
			this.cbSubject.Text = null;
			this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
			this.cbSubject.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbMaCauHoi
			// 
			this.lbMaCauHoi.AutoSize = true;
			this.lbMaCauHoi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaCauHoi.Location = new System.Drawing.Point(29, 15);
			this.lbMaCauHoi.Name = "lbMaCauHoi";
			this.lbMaCauHoi.Size = new System.Drawing.Size(103, 18);
			this.lbMaCauHoi.TabIndex = 0;
			this.lbMaCauHoi.Text = "Mã câu hỏi:";
			this.lbMaCauHoi.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// tbQuestionID
			// 
			this.tbQuestionID.BorderColor = System.Drawing.Color.Gray;
			this.tbQuestionID.BorderRadius = 5;
			this.tbQuestionID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbQuestionID.DefaultText = "";
			this.tbQuestionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbQuestionID.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbQuestionID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbQuestionID.DisabledState.Parent = this.tbQuestionID;
			this.tbQuestionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbQuestionID.Enabled = false;
			this.tbQuestionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbQuestionID.FocusedState.Parent = this.tbQuestionID;
			this.tbQuestionID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuestionID.ForeColor = System.Drawing.Color.Black;
			this.tbQuestionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbQuestionID.HoverState.Parent = this.tbQuestionID;
			this.tbQuestionID.Location = new System.Drawing.Point(22, 39);
			this.tbQuestionID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbQuestionID.Name = "tbQuestionID";
			this.tbQuestionID.PasswordChar = '\0';
			this.tbQuestionID.PlaceholderText = "";
			this.tbQuestionID.ReadOnly = true;
			this.tbQuestionID.SelectedText = "";
			this.tbQuestionID.ShadowDecoration.Parent = this.tbQuestionID;
			this.tbQuestionID.Size = new System.Drawing.Size(160, 36);
			this.tbQuestionID.TabIndex = 6;
			this.tbQuestionID.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbMonThi
			// 
			this.lbMonThi.AutoSize = true;
			this.lbMonThi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMonThi.Location = new System.Drawing.Point(29, 85);
			this.lbMonThi.Name = "lbMonThi";
			this.lbMonThi.Size = new System.Drawing.Size(76, 18);
			this.lbMonThi.TabIndex = 0;
			this.lbMonThi.Text = "Môn thi:";
			this.lbMonThi.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// pnlInfo1
			// 
			this.pnlInfo1.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfo1.Controls.Add(this.tbAnswerD);
			this.pnlInfo1.Controls.Add(this.lbNoiDung);
			this.pnlInfo1.Controls.Add(this.tbAnswerC);
			this.pnlInfo1.Controls.Add(this.lbDapAnD);
			this.pnlInfo1.Controls.Add(this.tbAnswerB);
			this.pnlInfo1.Controls.Add(this.lbDapAnC);
			this.pnlInfo1.Controls.Add(this.tbAnswerA);
			this.pnlInfo1.Controls.Add(this.lbDapAnB);
			this.pnlInfo1.Controls.Add(this.tbContent);
			this.pnlInfo1.Controls.Add(this.lbDapAnA);
			this.pnlInfo1.FillColor = System.Drawing.Color.White;
			this.pnlInfo1.Location = new System.Drawing.Point(45, 20);
			this.pnlInfo1.Name = "pnlInfo1";
			this.pnlInfo1.Radius = 5;
			this.pnlInfo1.ShadowColor = System.Drawing.Color.Black;
			this.pnlInfo1.ShadowDepth = 255;
			this.pnlInfo1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlInfo1.Size = new System.Drawing.Size(981, 295);
			this.pnlInfo1.TabIndex = 0;
			this.pnlInfo1.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// tbAnswerD
			// 
			this.tbAnswerD.BorderColor = System.Drawing.Color.Gray;
			this.tbAnswerD.BorderRadius = 5;
			this.tbAnswerD.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAnswerD.DefaultText = "";
			this.tbAnswerD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAnswerD.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbAnswerD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerD.DisabledState.Parent = this.tbAnswerD;
			this.tbAnswerD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerD.FocusedState.Parent = this.tbAnswerD;
			this.tbAnswerD.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnswerD.ForeColor = System.Drawing.Color.Black;
			this.tbAnswerD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerD.HoverState.Parent = this.tbAnswerD;
			this.tbAnswerD.Location = new System.Drawing.Point(596, 238);
			this.tbAnswerD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbAnswerD.Name = "tbAnswerD";
			this.tbAnswerD.PasswordChar = '\0';
			this.tbAnswerD.PlaceholderText = "";
			this.tbAnswerD.SelectedText = "";
			this.tbAnswerD.ShadowDecoration.Parent = this.tbAnswerD;
			this.tbAnswerD.Size = new System.Drawing.Size(350, 36);
			this.tbAnswerD.TabIndex = 5;
			this.tbAnswerD.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbNoiDung
			// 
			this.lbNoiDung.AutoSize = true;
			this.lbNoiDung.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNoiDung.Location = new System.Drawing.Point(42, 10);
			this.lbNoiDung.Name = "lbNoiDung";
			this.lbNoiDung.Size = new System.Drawing.Size(88, 18);
			this.lbNoiDung.TabIndex = 0;
			this.lbNoiDung.Text = "Nội dung:";
			this.lbNoiDung.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// tbAnswerC
			// 
			this.tbAnswerC.BorderColor = System.Drawing.Color.Gray;
			this.tbAnswerC.BorderRadius = 5;
			this.tbAnswerC.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAnswerC.DefaultText = "";
			this.tbAnswerC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAnswerC.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbAnswerC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerC.DisabledState.Parent = this.tbAnswerC;
			this.tbAnswerC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerC.FocusedState.Parent = this.tbAnswerC;
			this.tbAnswerC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnswerC.ForeColor = System.Drawing.Color.Black;
			this.tbAnswerC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerC.HoverState.Parent = this.tbAnswerC;
			this.tbAnswerC.Location = new System.Drawing.Point(596, 172);
			this.tbAnswerC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbAnswerC.Name = "tbAnswerC";
			this.tbAnswerC.PasswordChar = '\0';
			this.tbAnswerC.PlaceholderText = "";
			this.tbAnswerC.SelectedText = "";
			this.tbAnswerC.ShadowDecoration.Parent = this.tbAnswerC;
			this.tbAnswerC.Size = new System.Drawing.Size(350, 36);
			this.tbAnswerC.TabIndex = 4;
			this.tbAnswerC.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbDapAnD
			// 
			this.lbDapAnD.AutoSize = true;
			this.lbDapAnD.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDapAnD.Location = new System.Drawing.Point(602, 214);
			this.lbDapAnD.Name = "lbDapAnD";
			this.lbDapAnD.Size = new System.Drawing.Size(91, 18);
			this.lbDapAnD.TabIndex = 0;
			this.lbDapAnD.Text = "Đáp án D:";
			this.lbDapAnD.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// tbAnswerB
			// 
			this.tbAnswerB.BorderColor = System.Drawing.Color.Gray;
			this.tbAnswerB.BorderRadius = 5;
			this.tbAnswerB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAnswerB.DefaultText = "";
			this.tbAnswerB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAnswerB.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbAnswerB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerB.DisabledState.Parent = this.tbAnswerB;
			this.tbAnswerB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerB.FocusedState.Parent = this.tbAnswerB;
			this.tbAnswerB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnswerB.ForeColor = System.Drawing.Color.Black;
			this.tbAnswerB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerB.HoverState.Parent = this.tbAnswerB;
			this.tbAnswerB.Location = new System.Drawing.Point(596, 104);
			this.tbAnswerB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbAnswerB.Name = "tbAnswerB";
			this.tbAnswerB.PasswordChar = '\0';
			this.tbAnswerB.PlaceholderText = "";
			this.tbAnswerB.SelectedText = "";
			this.tbAnswerB.ShadowDecoration.Parent = this.tbAnswerB;
			this.tbAnswerB.Size = new System.Drawing.Size(350, 36);
			this.tbAnswerB.TabIndex = 3;
			this.tbAnswerB.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbDapAnC
			// 
			this.lbDapAnC.AutoSize = true;
			this.lbDapAnC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDapAnC.Location = new System.Drawing.Point(602, 148);
			this.lbDapAnC.Name = "lbDapAnC";
			this.lbDapAnC.Size = new System.Drawing.Size(90, 18);
			this.lbDapAnC.TabIndex = 0;
			this.lbDapAnC.Text = "Đáp án C:";
			this.lbDapAnC.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// tbAnswerA
			// 
			this.tbAnswerA.BorderColor = System.Drawing.Color.Gray;
			this.tbAnswerA.BorderRadius = 5;
			this.tbAnswerA.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAnswerA.DefaultText = "";
			this.tbAnswerA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAnswerA.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbAnswerA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerA.DisabledState.Parent = this.tbAnswerA;
			this.tbAnswerA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAnswerA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerA.FocusedState.Parent = this.tbAnswerA;
			this.tbAnswerA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnswerA.ForeColor = System.Drawing.Color.Black;
			this.tbAnswerA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAnswerA.HoverState.Parent = this.tbAnswerA;
			this.tbAnswerA.Location = new System.Drawing.Point(596, 34);
			this.tbAnswerA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbAnswerA.Name = "tbAnswerA";
			this.tbAnswerA.PasswordChar = '\0';
			this.tbAnswerA.PlaceholderText = "";
			this.tbAnswerA.SelectedText = "";
			this.tbAnswerA.ShadowDecoration.Parent = this.tbAnswerA;
			this.tbAnswerA.Size = new System.Drawing.Size(350, 36);
			this.tbAnswerA.TabIndex = 2;
			this.tbAnswerA.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbDapAnB
			// 
			this.lbDapAnB.AutoSize = true;
			this.lbDapAnB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDapAnB.Location = new System.Drawing.Point(602, 80);
			this.lbDapAnB.Name = "lbDapAnB";
			this.lbDapAnB.Size = new System.Drawing.Size(90, 18);
			this.lbDapAnB.TabIndex = 0;
			this.lbDapAnB.Text = "Đáp án B:";
			this.lbDapAnB.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// tbContent
			// 
			this.tbContent.BorderColor = System.Drawing.Color.Gray;
			this.tbContent.BorderRadius = 5;
			this.tbContent.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbContent.DefaultText = "";
			this.tbContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbContent.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbContent.DisabledState.Parent = this.tbContent;
			this.tbContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbContent.FocusedState.Parent = this.tbContent;
			this.tbContent.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbContent.ForeColor = System.Drawing.Color.Black;
			this.tbContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbContent.HoverState.Parent = this.tbContent;
			this.tbContent.Location = new System.Drawing.Point(35, 34);
			this.tbContent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbContent.Multiline = true;
			this.tbContent.Name = "tbContent";
			this.tbContent.PasswordChar = '\0';
			this.tbContent.PlaceholderText = "";
			this.tbContent.SelectedText = "";
			this.tbContent.ShadowDecoration.Parent = this.tbContent;
			this.tbContent.Size = new System.Drawing.Size(530, 240);
			this.tbContent.TabIndex = 1;
			this.tbContent.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// lbDapAnA
			// 
			this.lbDapAnA.AutoSize = true;
			this.lbDapAnA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDapAnA.Location = new System.Drawing.Point(602, 10);
			this.lbDapAnA.Name = "lbDapAnA";
			this.lbDapAnA.Size = new System.Drawing.Size(90, 18);
			this.lbDapAnA.TabIndex = 0;
			this.lbDapAnA.Text = "Đáp án A:";
			this.lbDapAnA.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// bScrollBar
			// 
			this.bScrollBar.AllowCursorChanges = true;
			this.bScrollBar.AllowHomeEndKeysDetection = false;
			this.bScrollBar.AllowIncrementalClickMoves = true;
			this.bScrollBar.AllowMouseDownEffects = false;
			this.bScrollBar.AllowMouseHoverEffects = false;
			this.bScrollBar.AllowScrollingAnimations = true;
			this.bScrollBar.AllowScrollKeysDetection = true;
			this.bScrollBar.AllowScrollOptionsMenu = true;
			this.bScrollBar.AllowShrinkingOnFocusLost = false;
			this.bScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bScrollBar.AutoScroll = true;
			this.bScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bScrollBar.BackgroundImage")));
			this.bScrollBar.BindingContainer = null;
			this.bScrollBar.BorderRadius = 2;
			this.bScrollBar.BorderThickness = 1;
			this.bScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bScrollBar.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
			this.bScrollBar.DrawThickBorder = false;
			this.bScrollBar.DurationBeforeShrink = 2000;
			this.bScrollBar.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.LargeChange = 10;
			this.bScrollBar.Location = new System.Drawing.Point(1481, 96);
			this.bScrollBar.Maximum = 100;
			this.bScrollBar.Minimum = 0;
			this.bScrollBar.MinimumSize = new System.Drawing.Size(31, 0);
			this.bScrollBar.MinimumThumbLength = 18;
			this.bScrollBar.Name = "bScrollBar";
			this.bScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
			this.bScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
			this.bScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
			this.bScrollBar.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
			this.bScrollBar.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
			this.bScrollBar.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
			this.bScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.ShrinkSizeLimit = 3;
			this.bScrollBar.Size = new System.Drawing.Size(31, 272);
			this.bScrollBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.bScrollBar.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
			this.bScrollBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
			this.bScrollBar.SmallChange = 1;
			this.bScrollBar.TabIndex = 0;
			this.bScrollBar.TabStop = false;
			this.bScrollBar.ThumbColor = System.Drawing.Color.DodgerBlue;
			this.bScrollBar.ThumbFillColor = System.Drawing.Color.White;
			this.bScrollBar.ThumbLength = 26;
			this.bScrollBar.ThumbMargin = 1;
			this.bScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
			this.bScrollBar.Value = 100;
			this.bScrollBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs>(this.bScrollBar_Scroll);
			this.bScrollBar.Click += new System.EventHandler(this.ManageQuestion_Click);
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
			this.tbSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.ForeColor = System.Drawing.Color.Black;
			this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.HoverState.Parent = this.tbSearch;
			this.tbSearch.IconRight = global::Main.Properties.Resources.searchIcon;
			this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.tbSearch.Location = new System.Drawing.Point(57, 12);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Nhập từ khóa ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
			this.tbSearch.Size = new System.Drawing.Size(281, 35);
			this.tbSearch.TabIndex = 0;
			this.tbSearch.TabStop = false;
			this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
			this.tbSearch.Click += new System.EventHandler(this.ManageQuestion_Click);
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			// 
			// aDgvdata
			// 
			this.aDgvdata.AllowUserToAddRows = false;
			this.aDgvdata.AllowUserToDeleteRows = false;
			this.aDgvdata.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
			this.aDgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.aDgvdata.AutoGenerateContextFilters = true;
			this.aDgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.aDgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
			this.aDgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aDgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.aDgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.aDgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.aDgvdata.ColumnHeadersHeight = 40;
			this.aDgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.aDgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionID,
            this.ExamID,
            this.SubjectID,
            this.QContent,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer});
			this.aDgvdata.DateWithTime = false;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.aDgvdata.DefaultCellStyle = dataGridViewCellStyle8;
			this.aDgvdata.EnableHeadersVisualStyles = false;
			this.aDgvdata.Location = new System.Drawing.Point(45, 56);
			this.aDgvdata.Name = "aDgvdata";
			this.aDgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.aDgvdata.RowHeadersVisible = false;
			this.aDgvdata.RowTemplate.Height = 50;
			this.aDgvdata.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.aDgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.aDgvdata.Size = new System.Drawing.Size(1430, 312);
			this.aDgvdata.TabIndex = 0;
			this.aDgvdata.TabStop = false;
			this.aDgvdata.TimeFilter = false;
			this.aDgvdata.SortStringChanged += new System.EventHandler(this.aDgvdata_SortStringChanged);
			this.aDgvdata.FilterStringChanged += new System.EventHandler(this.aDgvdata_FilterStringChanged);
			this.aDgvdata.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDgvdata_RowEnter);
			this.aDgvdata.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aDgvdata_RowsAdded);
			this.aDgvdata.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.aDgvdata_RowsRemoved);
			this.aDgvdata.Click += new System.EventHandler(this.ManageQuestion_Click);
			this.aDgvdata.Enter += new System.EventHandler(this.aDgvdata_Enter);
			// 
			// QuestionID
			// 
			this.QuestionID.DataPropertyName = "QuestionID";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.QuestionID.DefaultCellStyle = dataGridViewCellStyle3;
			this.QuestionID.FillWeight = 60F;
			this.QuestionID.HeaderText = "Mã câu hỏi";
			this.QuestionID.MinimumWidth = 22;
			this.QuestionID.Name = "QuestionID";
			this.QuestionID.ReadOnly = true;
			this.QuestionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ExamID
			// 
			this.ExamID.DataPropertyName = "ExamID";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.NullValue = "NULL";
			this.ExamID.DefaultCellStyle = dataGridViewCellStyle4;
			this.ExamID.FillWeight = 60F;
			this.ExamID.HeaderText = "Mã đề";
			this.ExamID.MinimumWidth = 22;
			this.ExamID.Name = "ExamID";
			this.ExamID.ReadOnly = true;
			this.ExamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// SubjectID
			// 
			this.SubjectID.DataPropertyName = "SubjectID";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.NullValue = "NULL";
			this.SubjectID.DefaultCellStyle = dataGridViewCellStyle5;
			this.SubjectID.FillWeight = 60F;
			this.SubjectID.HeaderText = "Mã môn thi";
			this.SubjectID.MinimumWidth = 22;
			this.SubjectID.Name = "SubjectID";
			this.SubjectID.ReadOnly = true;
			this.SubjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// QContent
			// 
			this.QContent.DataPropertyName = "QContent";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Format = "d";
			dataGridViewCellStyle6.NullValue = "dd/MM/yyyy";
			this.QContent.DefaultCellStyle = dataGridViewCellStyle6;
			this.QContent.HeaderText = "Nội dung câu hỏi";
			this.QContent.MinimumWidth = 22;
			this.QContent.Name = "QContent";
			this.QContent.ReadOnly = true;
			this.QContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionA
			// 
			this.OptionA.DataPropertyName = "OptionA";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.OptionA.DefaultCellStyle = dataGridViewCellStyle7;
			this.OptionA.FillWeight = 80F;
			this.OptionA.HeaderText = "Đáp án A";
			this.OptionA.MinimumWidth = 22;
			this.OptionA.Name = "OptionA";
			this.OptionA.ReadOnly = true;
			this.OptionA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionB
			// 
			this.OptionB.DataPropertyName = "OptionB";
			this.OptionB.FillWeight = 80F;
			this.OptionB.HeaderText = "Đáp án B";
			this.OptionB.MinimumWidth = 22;
			this.OptionB.Name = "OptionB";
			this.OptionB.ReadOnly = true;
			this.OptionB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionC
			// 
			this.OptionC.DataPropertyName = "OptionC";
			this.OptionC.FillWeight = 80F;
			this.OptionC.HeaderText = "Đáp án C";
			this.OptionC.MinimumWidth = 22;
			this.OptionC.Name = "OptionC";
			this.OptionC.ReadOnly = true;
			this.OptionC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// OptionD
			// 
			this.OptionD.DataPropertyName = "OptionD";
			this.OptionD.FillWeight = 80F;
			this.OptionD.HeaderText = "Đáp án D";
			this.OptionD.MinimumWidth = 22;
			this.OptionD.Name = "OptionD";
			this.OptionD.ReadOnly = true;
			this.OptionD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// Answer
			// 
			this.Answer.DataPropertyName = "Answer";
			this.Answer.FillWeight = 80F;
			this.Answer.HeaderText = "Đáp án đúng";
			this.Answer.MinimumWidth = 22;
			this.Answer.Name = "Answer";
			this.Answer.ReadOnly = true;
			this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			this.btnClearFilter.Location = new System.Drawing.Point(342, 12);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(35, 35);
			this.btnClearFilter.TabIndex = 0;
			this.btnClearFilter.TabStop = false;
			this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnClearFilter, "Hủy thao tác lọc dữ liệu");
			this.btnClearFilter.UseVisualStyleBackColor = false;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			this.btnClearFilter.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
			this.btnEdit.IconColor = System.Drawing.Color.White;
			this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEdit.IconSize = 28;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEdit.Location = new System.Drawing.Point(1224, 10);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnEdit.Size = new System.Drawing.Size(110, 40);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.TabStop = false;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnEdit, "Sửa câu hỏi");
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			this.btnEdit.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnDelete.IconColor = System.Drawing.Color.White;
			this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDelete.IconSize = 28;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDelete.Location = new System.Drawing.Point(1352, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnDelete.Size = new System.Drawing.Size(110, 40);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.TabStop = false;
			this.btnDelete.Text = " Xóa";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnDelete, "Xóa câu hỏi");
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnDelete.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Green;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
			this.btnSave.IconColor = System.Drawing.Color.White;
			this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSave.IconSize = 28;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Location = new System.Drawing.Point(1352, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 0;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnSave, "Lưu dữ liệu");
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// btnCancle
			// 
			this.btnCancle.BackColor = System.Drawing.Color.DarkGray;
			this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCancle.FlatAppearance.BorderSize = 0;
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnCancle.ForeColor = System.Drawing.Color.White;
			this.btnCancle.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
			this.btnCancle.IconColor = System.Drawing.Color.White;
			this.btnCancle.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancle.IconSize = 28;
			this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancle.Location = new System.Drawing.Point(1224, 10);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCancle.Size = new System.Drawing.Size(110, 40);
			this.btnCancle.TabIndex = 0;
			this.btnCancle.TabStop = false;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnCancle, "Hủy thao tác");
			this.btnCancle.UseVisualStyleBackColor = false;
			this.btnCancle.Visible = false;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			this.btnCancle.Enter += new System.EventHandler(this.iconTitle_Enter);
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
			// btnImportFiles
			// 
			this.btnImportFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnImportFiles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImportFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnImportFiles.FlatAppearance.BorderSize = 0;
			this.btnImportFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImportFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportFiles.ForeColor = System.Drawing.Color.White;
			this.btnImportFiles.IconChar = FontAwesome.Sharp.IconChar.Paste;
			this.btnImportFiles.IconColor = System.Drawing.Color.White;
			this.btnImportFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnImportFiles.IconSize = 28;
			this.btnImportFiles.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnImportFiles.Location = new System.Drawing.Point(1292, 23);
			this.btnImportFiles.Name = "btnImportFiles";
			this.btnImportFiles.Size = new System.Drawing.Size(55, 40);
			this.btnImportFiles.TabIndex = 1;
			this.btnImportFiles.TabStop = false;
			this.btnImportFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnImportFiles, "Tải lên danh sách câu hỏi từ tập tin");
			this.btnImportFiles.UseVisualStyleBackColor = false;
			this.btnImportFiles.Click += new System.EventHandler(this.btnImportFiles_Click);
			this.btnImportFiles.Enter += new System.EventHandler(this.iconTitle_Enter);
			// 
			// guna2ShadowPanel1
			// 
			this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel1.Controls.Add(this.bScrollBar);
			this.guna2ShadowPanel1.Controls.Add(this.tbSearch);
			this.guna2ShadowPanel1.Controls.Add(this.btnCancle);
			this.guna2ShadowPanel1.Controls.Add(this.aDgvdata);
			this.guna2ShadowPanel1.Controls.Add(this.btnSave);
			this.guna2ShadowPanel1.Controls.Add(this.btnClearFilter);
			this.guna2ShadowPanel1.Controls.Add(this.btnDelete);
			this.guna2ShadowPanel1.Controls.Add(this.btnEdit);
			this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
			this.guna2ShadowPanel1.Location = new System.Drawing.Point(13, 424);
			this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
			this.guna2ShadowPanel1.Radius = 5;
			this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
			this.guna2ShadowPanel1.ShadowDepth = 255;
			this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.guna2ShadowPanel1.Size = new System.Drawing.Size(1525, 385);
			this.guna2ShadowPanel1.TabIndex = 0;
			this.guna2ShadowPanel1.Click += new System.EventHandler(this.ManageQuestion_Click);
			// 
			// ManageQuestion
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.btnImportFiles);
			this.Controls.Add(this.pnlControls);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.iconTitle);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.guna2ShadowPanel1);
			this.Name = "ManageQuestion";
			this.Size = new System.Drawing.Size(1550, 822);
			this.Load += new System.EventHandler(this.FrmManageUser_Load);
			this.Click += new System.EventHandler(this.ManageQuestion_Click);
			this.pnlControls.ResumeLayout(false);
			this.pnlInfo3.ResumeLayout(false);
			this.pnlInfo3.PerformLayout();
			this.pnlInfo2.ResumeLayout(false);
			this.pnlInfo2.PerformLayout();
			this.pnlInfo1.ResumeLayout(false);
			this.pnlInfo1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.aDgvdata)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.guna2ShadowPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTitle;
		private FontAwesome.Sharp.IconButton iconTitle;
		private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.Panel pnlControls;
		private Guna.UI2.WinForms.Guna2TextBox tbAnswerCorrect;
		private System.Windows.Forms.Label lbDapAnDung;
		private Guna.UI2.WinForms.Guna2TextBox tbQuestionID;
		private System.Windows.Forms.Label lbMaDe;
		private System.Windows.Forms.Label lbMonThi;
		private System.Windows.Forms.Label lbMaCauHoi;
		private Guna.UI2.WinForms.Guna2TextBox tbAnswerD;
		private Guna.UI2.WinForms.Guna2TextBox tbAnswerC;
		private Guna.UI2.WinForms.Guna2TextBox tbAnswerB;
		private Guna.UI2.WinForms.Guna2TextBox tbAnswerA;
		private Guna.UI2.WinForms.Guna2TextBox tbContent;
		private System.Windows.Forms.Label lbDapAnA;
		private System.Windows.Forms.Label lbDapAnB;
		private System.Windows.Forms.Label lbDapAnC;
		private System.Windows.Forms.Label lbDapAnD;
		private System.Windows.Forms.Label lbNoiDung;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private FontAwesome.Sharp.IconButton btnClearFilter;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnDelete;
		public FontAwesome.Sharp.IconButton btnSave;
		public FontAwesome.Sharp.IconButton btnCancle;
		private Bunifu.UI.WinForms.BunifuDropdown cbSubject;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private Bunifu.UI.WinForms.BunifuDropdown cbExamID;
		private System.Windows.Forms.ToolTip toolTip;
		private Bunifu.UI.WinForms.BunifuVSlider bScrollBar;
		public ADGV.AdvancedDataGridView aDgvdata;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo3;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInfo2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn QContent;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
		private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
		private FontAwesome.Sharp.IconButton btnImportFiles;
	}
}