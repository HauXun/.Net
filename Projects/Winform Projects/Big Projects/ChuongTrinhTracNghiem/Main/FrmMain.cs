﻿using Entities;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmMain : Form
	{
		[System.ComponentModel.Browsable(false)]
		public delegate void LoadCompletedEventHandler();
		public event LoadCompletedEventHandler LoadCompleted;

		void BaseForm_Shown(object sender, EventArgs e)
		{
			Application.DoEvents();
			if (LoadCompleted != null)
				LoadCompleted();
		}

		private UserAccount account;

		public UserAccount Account
		{ 
			get => account;
			set
			{
				account = value;
				ChangeRole(account.RoleID);
			}
		}

		public FrmMain(UserAccount account)
		{
			InitializeComponent();
			Account = account;
			this.Shown += new EventHandler(BaseForm_Shown);
			this.LoadCompleted += new LoadCompletedEventHandler(FrmMain_LoadCompleted);
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

		private void tsmiManageUser_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmManageUser frm = new FrmManageUser(Account);
			frm.ShowDialog();
			this.Show();
		}

		private void tsmiChangePassword_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmChangePassword frm = new FrmChangePassword(Account);
			frm.UpdateAccountInfo += Frm_UpdateAccountInfo;
			frm.ShowDialog();
			this.Show();
		}

		private void tsmiManageSubject_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmManageSubject frm = new FrmManageSubject(Account);
			frm.ShowDialog();
			this.Show();
		}

		private void Frm_UpdateAccountInfo(object sender, AccountChanged e)
		{
			tsmiHelp.Text = $"{"Trợ giúp"} ({e.Account.FullName})";
			Account = e.Account;
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		private void tsmiManageQuestion_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmManageQuestion frm = new FrmManageQuestion(Account);
			frm.ShowDialog();
			this.Show();
		}

		private void btnTraining_Enter(object sender, EventArgs e)
		{
			if (!(sender as Button).Focused)
			{
				lbFunctionSelected.Text = (sender as Button).Text;
			}	
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			if (Account.RoleID.ToLower().Trim().Equals("user"))
			{
				tbDisplayname.Text = Account.FullName;
				tbID.Text = Account.UserID.ToString();
			}
		}

		private void btnTraining_Click(object sender, EventArgs e)
		{
			if ((sender as Button).Focused)
			{
				lbFunctionSelected.Text = (sender as Button).Text;
			}
		}

		private void tsmiTraining_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmQuizOptions frm = new FrmQuizOptions(Account);
			frm.ShowDialog();
			this.Show();
		}

		private void tsmiTestQuiz_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmQuizOptions frm = new FrmQuizOptions(Account);
			frm.tbQuizTime.Enabled = false;
			frm.cbQuestionCount.Enabled = false;
			frm.lbTitle.Text = "LÀM BÀI THI";
			frm.lbTitle.Location = new Point(174, 19);
			frm.ShowDialog();
			this.Show();
		}

		private void tsmiManageExam_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmManageExam frm = new FrmManageExam(Account);
			frm.ShowDialog();
			this.Show();
		}
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
}
