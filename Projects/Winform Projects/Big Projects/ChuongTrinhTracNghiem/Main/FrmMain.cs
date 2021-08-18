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

		private void tsmiManageFaculty_Click(object sender, EventArgs e)
		{

			this.Hide();
			try
			{
				FrmManageFaculty frm = new FrmManageFaculty();
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void tsmiManageCourse_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmManageCourse frm = new FrmManageCourse();
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}

		private void tsmiManageUserClass_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmManageClass frm = new FrmManageClass(Account);
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
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

		private void tsmiStatisticalTrainingProg_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				FrmManageStatistical frm = new FrmManageStatistical();
				frm.ShowDialog();
			}
			catch
			{
				this.Show();
			}
			this.Show();
		}
	}
}
