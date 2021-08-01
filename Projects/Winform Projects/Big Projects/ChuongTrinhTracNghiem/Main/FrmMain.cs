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
				ChangeRole(account.RoleID);
			}
		}

		public FrmMain(UserAccount account)
		{
			InitializeComponent();
			Account = account;
		}

		#region Methods

		private void ChangeRole(string roleID)
		{
			bool isAdmin = roleID.ToLower().Equals("admin");
			if (!isAdmin)
			{
				tsmiChangePassword.Enabled = false;
				tsmiRestoreData.Enabled = false;
				tsmiManageUser.Enabled = false;
				tsmiFunction.Enabled = false;
				tsmiManageTeacher.Enabled = false;
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
			FrmManageUser frm = new FrmManageUser();
			frm.Show();
		}

		private void tsmiChangePassword_Click(object sender, EventArgs e)
		{
			FrmChangePassword frm = new FrmChangePassword(Account);
			frm.UpdateAccountInfo += Frm_UpdateAccountInfo;
			frm.ShowDialog();
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
	}
}
