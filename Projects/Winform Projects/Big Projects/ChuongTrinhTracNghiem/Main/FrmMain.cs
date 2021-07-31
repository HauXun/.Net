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

		private void tsmiManageUser_Click(object sender, EventArgs e)
		{
			FrmManageUser frm = new FrmManageUser();
			frm.Show();
		}

		private void ChangeRole(string roleID)
		{
			bool isAdmin = roleID.ToLower().Equals("admin");
			if (!isAdmin)
			{
				foreach (ToolStripMenuItem item in msAdmin.Items)
				{
					item.Visible = false;
				}
			}
		}

		private void tsmiChangePassword_Click(object sender, EventArgs e)
		{
			FrmChangePassword frm = new FrmChangePassword(Account);
			frm.ShowDialog();
		}
	}
}
