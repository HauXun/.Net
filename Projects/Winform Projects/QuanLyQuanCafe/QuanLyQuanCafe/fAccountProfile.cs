using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class fAccountProfile : Form
	{
		private Account account;

		public Account Account
		{
			get => account;
			set
			{
				account = value;
				ChangeAccount(account);
			}
		}

		public fAccountProfile(Account account)
		{
			InitializeComponent();
			Account = account;
		}

		void ChangeAccount(Account account)
		{
			tbLogin.Text = account.Username;
			tbDisplayName.Text = account.Displayname;
		}

		void UpdateAccount()
		{
			string username = tbLogin.Text;
			string displayname = tbDisplayName.Text;
			string password = tbPassword.Text;
			string newPassword = tbNewPassword.Text;
			string reenterPassword = tbRePassword.Text;

			if (!newPassword.Equals(reenterPassword))
			{
				MessageBox.Show("Nhập lại mật khẩu không đúng!");
			}
			else
			{
				if (AccountDAO.Instance.UpdateAccount(username, displayname, password, newPassword))
				{
					MessageBox.Show("Cập nhập thành công");
					if (updateAccountEvent != null)
					{
						updateAccountEvent(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
					}	
				}	
				else
				{
					MessageBox.Show("Vui lòng điền đúng mật khẩu");
				}	
			}
		}

		private event EventHandler<AccountEvent> updateAccountEvent;
		public event EventHandler<AccountEvent> UpdateAccountEvent
		{
			add
			{
				updateAccountEvent += value;
			}
			remove
			{
				updateAccountEvent -= value;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateAccount();
		}
	}

	public class AccountEvent : EventArgs
	{
		private Account account;

		public Account Account { get => account; set => account = value; }
		public AccountEvent(Account account)
		{
			Account = account;
		}
	}
}
