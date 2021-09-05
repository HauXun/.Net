using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.Page;
using System.Threading;

namespace Main
{
	public partial class FrmTestPages : Form
	{
		private UserAccount account;
		public UserAccount Account { get => account; set => account = value; }
		ChangePassword changePassword;
		UserManage userManage;

		#region Form
		//FrmManageUser frmManageUser = new FrmManageUser();
		//FrmChangePassword frmChangePassword = new FrmChangePassword();
		//FrmManageSubject frmManageSubject = new FrmManageSubject();
		//FrmManageQuestion frmManageQuestion = new FrmManageQuestion();
		//FrmQuizOptions frmQuizOptions = new FrmQuizOptions();
		//FrmManageExam frmManageExam = new FrmManageExam();
		//FrmManageFaculty frmManageFaculty = new FrmManageFaculty();
		//FrmManageCourse frmManageCourse = new FrmManageCourse();
		//FrmManageClass frmManageClass = new FrmManageClass();
		//FrmManageStatistical frmManageStatistical = new FrmManageStatistical();
		//FrmTestHistory frmTestHistorys = new FrmTestHistory();
		//FrmLeaderBoard frmLeaderBoard = new FrmLeaderBoard();
		//FrmEduProg frmEduProg = new FrmEduProg();
		#endregion

		public FrmTestPages()
		{
			userManage = new UserManage();
			changePassword = new ChangePassword();
			InitializeComponent();
			//this.Load += FrmTestPages_Load;
		}

		private void FrmTestPages_Load(object sender, EventArgs e)
		{
			//new Thread(() =>
			//{
			//	bP.Invoke((MethodInvoker)delegate
			//	{
			//		this.SuspendLayout();
			//		bP.SelectedIndex = 1;
			//		bP.TabPages[0].Controls.Add(changePassword);
			//		bP.TabPages[1].Controls.Add(userManage);
			//		this.Refresh();
			//		foreach (Control control in this.Controls)
			//		{
			//			control.Refresh();
			//		}
			//		foreach (Control control in bP.TabPages)
			//		{
			//			control.Refresh();
			//		}
			//	});
			//}).Start();
			//Thread.Sleep(1);
			//this.ResumeLayout();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			int index = bP.SelectedIndex;
			if (index > 0)
			{
				new Thread(() =>
				{
					this.SuspendLayout();
					bP.Invoke((MethodInvoker)delegate
					{
						bP.Hide();
						bP.SelectedIndex = index - 1;
						this.Refresh();
						foreach (Control control in this.Controls)
						{
							control.Refresh();
						}
						foreach (Control control in bP.TabPages)
						{
							control.Refresh();
						}
						Thread.Sleep(1);
						bP.Show();
					});
				}).Start();
				Thread.Sleep(1);
				this.ResumeLayout();
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			int index = bP.SelectedIndex;
			if (index < bP.TabPages.Count - 1)
			{
				new Thread(() =>
				{
					this.SuspendLayout();
					bP.Invoke((MethodInvoker)delegate
					{
						bP.Hide();
						bP.SelectedIndex = index + 1;
						this.Refresh();
						foreach (Control control in this.Controls)
						{
							control.Refresh();

						}
						foreach (Control control in bP.TabPages)
						{
							control.Refresh();
						}
						Thread.Sleep(1);
						bP.Show();
					});
				}).Start();
				Thread.Sleep(1);
				this.ResumeLayout();
			}
		}
	}
}
