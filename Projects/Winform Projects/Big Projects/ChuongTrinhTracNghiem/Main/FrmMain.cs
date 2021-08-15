using Entities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmMain : Form
	{
		private UserAccount account;

		public UserAccount Account
		{ 
			get => account;
			set
			{
				account = value;
				ChangeRole(account.UserRole);
			}
		}

		public FrmMain(UserAccount account)
		{
			InitializeComponent();
			Account = account;
			this.Shown += new EventHandler(BaseForm_Shown);
			this.LoadCompleted += new LoadCompletedEventHandler(FrmMain_LoadCompleted);
		}

		#region Methods

		private void ChangeRole(string roleID)
		{
			bool isAdmin = roleID.ToLower().Equals("admin");
			if (!isAdmin)
			{
				tsmiRestoreData.Enabled = false;
				tsmiManageUser.Enabled = false;
				if (roleID.ToLower().Equals("user"))
				{
					tsmiReport.Enabled = false;
					tsmiCategory.Enabled = false;
				}
				tsmiHelp.Text = $"{"Trợ giúp"} ({Account.FullName})";
			}
		}

		#endregion

		#region Events

		private void FrmMain_Load(object sender, EventArgs e)
		{
			if (Account.UserRole.ToLower().Trim().Equals("user"))
			{
				tbDisplayname.Text = Account.FullName;
				tbID.Text = Account.UserID.ToString();
			}
		}

		private void tsmiManageUser_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmManageUser frm = new FrmManageUser(Account);
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void tsmiChangePassword_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmChangePassword frm = new FrmChangePassword(Account);
				frm.UpdateAccountInfo += Frm_UpdateAccountInfo;
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void Frm_UpdateAccountInfo(object sender, AccountChanged e)
		{
			tsmiHelp.Text = $"{"Trợ giúp"} ({e.Account.FullName})";
			Account = e.Account;
		}

		private void tsmiManageSubject_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmManageSubject frm = new FrmManageSubject(Account);
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void tsmiManageQuestion_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmManageQuestion frm = new FrmManageQuestion(Account);
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void tsmiTraining_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmQuizOptions frm = new FrmQuizOptions(Account);
				frm.isMockTest = false;
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void tsmiTestQuiz_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmQuizOptions frm = new FrmQuizOptions(Account);
				frm.isMockTest = true;
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void tsmiManageExam_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmManageExam frm = new FrmManageExam(Account);
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void btnTraining_Enter(object sender, EventArgs e)
		{
			if (!(sender as Button).Focused)
			{
				lbFunctionSelected.Text = (sender as Button).Text;
			}
		}

		private void btnTraining_Click(object sender, EventArgs e)
		{
			if ((sender as Button).Focused)
			{
				lbFunctionSelected.Text = (sender as Button).Text;
			}
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			DialogResult result = MessageBox.Show("Thoát chương trình!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
				base.OnClosing(e);
		}

		[System.ComponentModel.Browsable(false)]
		public delegate void LoadCompletedEventHandler();
		public event LoadCompletedEventHandler LoadCompleted;

		void BaseForm_Shown(object sender, EventArgs e)
		{
			Application.DoEvents();
			if (LoadCompleted != null)
				LoadCompleted();
		}

		private void FrmMain_LoadCompleted()
		{
			//GlassyPanel panel1 = new GlassyPanel();
			//panel1.BackColor = System.Drawing.Color.Transparent;
			//panel1.Opacity = 50;
			//panel1.Dock = DockStyle.Fill;
			//panel1.BackColor = Color.FromArgb(125, Color.Black);
			//this.Controls.Add(panel1);
		}

		#endregion
	}

	public class GlassyPanel : Panel
	{
		const int WS_EX_TRANSPARENT = 0x20;

		int opacity = 50;

		public int Opacity
		{
			get
			{
				return opacity;
			}
			set
			{
				if (value < 0 || value > 100) throw new ArgumentException("Value must be between 0 and 100");
				opacity = value;
			}
		}

		protected override CreateParams CreateParams
		{
			get
			{
				var cp = base.CreateParams;
				cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;

				return cp;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			using (var b = new SolidBrush(Color.FromArgb(opacity * 255 / 100, BackColor)))
			{
				e.Graphics.FillRectangle(b, ClientRectangle);
			}

			base.OnPaint(e);
		}
	}

	public class RJButton : Button
	{
		//Fields
		private int borderSize = 0;
		private int borderRadius = 0;
		private Color borderColor = Color.PaleVioletRed;

		//Properties
		[Category("RJ Code Advance")]
		public int BorderSize
		{
			get { return borderSize; }
			set
			{
				borderSize = value;
				this.Invalidate();
			}
		}

		[Category("RJ Code Advance")]
		public int BorderRadius
		{
			get { return borderRadius; }
			set
			{
				borderRadius = value;
				this.Invalidate();
			}
		}

		[Category("RJ Code Advance")]
		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}

		[Category("RJ Code Advance")]
		public Color BackgroundColor
		{
			get { return this.BackColor; }
			set { this.BackColor = value; }
		}

		[Category("RJ Code Advance")]
		public Color TextColor
		{
			get { return this.ForeColor; }
			set { this.ForeColor = value; }
		}

		//Constructor
		public RJButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.Size = new Size(150, 40);
			this.BackColor = Color.MediumSlateBlue;
			this.ForeColor = Color.White;
			this.Resize += new EventHandler(Button_Resize);
		}

		//Methods
		private GraphicsPath GetFigurePath(Rectangle rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);


			Rectangle rectSurface = this.ClientRectangle;
			Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
			int smoothSize = 2;
			if (borderSize > 0)
				smoothSize = borderSize;

			if (borderRadius > 2) //Rounded button
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
				using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
				using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					//Button surface
					this.Region = new Region(pathSurface);
					//Draw surface border for HD result
					pevent.Graphics.DrawPath(penSurface, pathSurface);

					//Button border                    
					if (borderSize >= 1)
						//Draw control border
						pevent.Graphics.DrawPath(penBorder, pathBorder);
				}
			}
			else //Normal button
			{
				pevent.Graphics.SmoothingMode = SmoothingMode.None;
				//Button surface
				this.Region = new Region(rectSurface);
				//Button border
				if (borderSize >= 1)
				{
					using (Pen penBorder = new Pen(borderColor, borderSize))
					{
						penBorder.Alignment = PenAlignment.Inset;
						pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
					}
				}
			}
		}
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
		}

		private void Container_BackColorChanged(object sender, EventArgs e)
		{
			this.Invalidate();
		}
		private void Button_Resize(object sender, EventArgs e)
		{
			if (borderRadius > this.Height)
				borderRadius = this.Height;
		}
	}

	[DefaultEvent("_TextChanged")]
	public partial class RJTextBox : UserControl
	{
		#region -> Fields
		//Fields
		private Color borderColor = Color.MediumSlateBlue;
		private Color borderFocusColor = Color.HotPink;
		private int borderSize = 2;
		private bool underlinedStyle = false;
		private bool isFocused = false;

		private int borderRadius = 0;
		private Color placeholderColor = Color.DarkGray;
		private string placeholderText = "";
		private bool isPlaceholder = false;
		private bool isPasswordChar = false;

		//Events
		public event EventHandler _TextChanged;

		#endregion

		//-> Constructor
		public RJTextBox()
		{
			//Created by designer
			InitializeComponent();
		}

		#region -> Properties
		[Category("RJ Code Advance")]
		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}

		[Category("RJ Code Advance")]
		public Color BorderFocusColor
		{
			get { return borderFocusColor; }
			set { borderFocusColor = value; }
		}

		[Category("RJ Code Advance")]
		public int BorderSize
		{
			get { return borderSize; }
			set
			{
				if (value >= 1)
				{
					borderSize = value;
					this.Invalidate();
				}
			}
		}

		[Category("RJ Code Advance")]
		public bool UnderlinedStyle
		{
			get { return underlinedStyle; }
			set
			{
				underlinedStyle = value;
				this.Invalidate();
			}
		}

		[Category("RJ Code Advance")]
		public bool PasswordChar
		{
			get { return isPasswordChar; }
			set
			{
				isPasswordChar = value;
				if (!isPlaceholder)
					textBox1.UseSystemPasswordChar = value;
			}
		}

		[Category("RJ Code Advance")]
		public bool Multiline
		{
			get { return textBox1.Multiline; }
			set { textBox1.Multiline = value; }
		}

		[Category("RJ Code Advance")]
		public override Color BackColor
		{
			get { return base.BackColor; }
			set
			{
				base.BackColor = value;
				textBox1.BackColor = value;
			}
		}

		[Category("RJ Code Advance")]
		public override Color ForeColor
		{
			get { return base.ForeColor; }
			set
			{
				base.ForeColor = value;
				textBox1.ForeColor = value;
			}
		}

		[Category("RJ Code Advance")]
		public override Font Font
		{
			get { return base.Font; }
			set
			{
				base.Font = value;
				textBox1.Font = value;
				if (this.DesignMode)
					UpdateControlHeight();
			}
		}

		[Category("RJ Code Advance")]
		public string Texts
		{
			get
			{
				if (isPlaceholder) return "";
				else return textBox1.Text;
			}
			set
			{
				textBox1.Text = value;
				SetPlaceholder();
			}
		}

		[Category("RJ Code Advance")]
		public int BorderRadius
		{
			get { return borderRadius; }
			set
			{
				if (value >= 0)
				{
					borderRadius = value;
					this.Invalidate();//Redraw control
				}
			}
		}

		[Category("RJ Code Advance")]
		public Color PlaceholderColor
		{
			get { return placeholderColor; }
			set
			{
				placeholderColor = value;
				if (isPlaceholder)
					textBox1.ForeColor = value;
			}
		}

		[Category("RJ Code Advance")]
		public string PlaceholderText
		{
			get { return placeholderText; }
			set
			{
				placeholderText = value;
				textBox1.Text = "";
				SetPlaceholder();
			}
		}



		#endregion

		#region -> Overridden methods
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.DesignMode)
				UpdateControlHeight();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			UpdateControlHeight();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graph = e.Graphics;

			if (borderRadius > 1)//Rounded TextBox
			{
				//-Fields
				var rectBorderSmooth = this.ClientRectangle;
				var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
				int smoothSize = borderSize > 0 ? borderSize : 1;

				using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
				using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
				using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					//-Drawing
					this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
					if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
					graph.SmoothingMode = SmoothingMode.AntiAlias;
					penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
					if (isFocused) penBorder.Color = borderFocusColor;

					if (underlinedStyle) //Line Style
					{
						//Draw border smoothing
						graph.DrawPath(penBorderSmooth, pathBorderSmooth);
						//Draw border
						graph.SmoothingMode = SmoothingMode.None;
						graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
					}
					else //Normal Style
					{
						//Draw border smoothing
						graph.DrawPath(penBorderSmooth, pathBorderSmooth);
						//Draw border
						graph.DrawPath(penBorder, pathBorder);
					}
				}
			}
			else //Square/Normal TextBox
			{
				//Draw border
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					this.Region = new Region(this.ClientRectangle);
					penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
					if (isFocused) penBorder.Color = borderFocusColor;

					if (underlinedStyle) //Line Style
						graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
					else //Normal Style
						graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
				}
			}
		}
		#endregion

		#region -> Private methods
		private void SetPlaceholder()
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
			{
				isPlaceholder = true;
				textBox1.Text = placeholderText;
				textBox1.ForeColor = placeholderColor;
				if (isPasswordChar)
					textBox1.UseSystemPasswordChar = false;
			}
		}
		private void RemovePlaceholder()
		{
			if (isPlaceholder && placeholderText != "")
			{
				isPlaceholder = false;
				textBox1.Text = "";
				textBox1.ForeColor = this.ForeColor;
				if (isPasswordChar)
					textBox1.UseSystemPasswordChar = true;
			}
		}
		private GraphicsPath GetFigurePath(Rectangle rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}
		private void SetTextBoxRoundedRegion()
		{
			GraphicsPath pathTxt;
			if (Multiline)
			{
				pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
				textBox1.Region = new Region(pathTxt);
			}
			else
			{
				pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
				textBox1.Region = new Region(pathTxt);
			}
			pathTxt.Dispose();
		}
		private void UpdateControlHeight()
		{
			if (textBox1.Multiline == false)
			{
				int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
				textBox1.Multiline = true;
				textBox1.MinimumSize = new Size(0, txtHeight);
				textBox1.Multiline = false;

				this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
			}
		}
		#endregion

		#region -> TextBox events
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (_TextChanged != null)
				_TextChanged.Invoke(sender, e);
		}
		private void textBox1_Click(object sender, EventArgs e)
		{
			this.OnClick(e);
		}
		private void textBox1_MouseEnter(object sender, EventArgs e)
		{
			this.OnMouseEnter(e);
		}
		private void textBox1_MouseLeave(object sender, EventArgs e)
		{
			this.OnMouseLeave(e);
		}
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.OnKeyPress(e);
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			isFocused = true;
			this.Invalidate();
			RemovePlaceholder();
		}
		private void textBox1_Leave(object sender, EventArgs e)
		{
			isFocused = false;
			this.Invalidate();
			SetPlaceholder();
		}
		///::::+
		#endregion
	}

	partial class RJTextBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(10, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(230, 15);
			this.textBox1.TabIndex = 0;
			this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
			this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
			// 
			// RJTextBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RJTextBox";
			this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.Size = new System.Drawing.Size(250, 30);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
	}
}
