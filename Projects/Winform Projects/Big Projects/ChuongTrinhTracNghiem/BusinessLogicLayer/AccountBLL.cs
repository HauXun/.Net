﻿using DataAccessLayer;
using Entities;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class AccountBLL
    {
        private static AccountBLL instance;

        public static AccountBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBLL();
                return instance;
            }
            private set => instance = value;
        }

        private AccountBLL() { }

        public int GetIDMissing()
        {
            return AccountDAL.Instance.GetIDMissing();
        }

        public bool IsExistAccount(UserAccount account)
        {
            return AccountDAL.Instance.IsExistAccount(account);
		}

        public bool ChangeInfoAccount(string username, string displayname, string pass, string newPass)
		{
            return AccountDAL.Instance.ChangeInfoAccount(username, displayname, pass, newPass);
		}

        public UserAccount GetAccountByUserName(string Username)
		{
            return AccountDAL.Instance.GetAccountByUserName(Username);
		}

        public void GetAllAccount(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = AccountDAL.Instance.GetAllAccount();
        }

        public bool InsertAccount(UserAccount account)
		{
            return AccountDAL.Instance.InsertAccount(account);
		}

        public bool UpdateAccount(UserAccount account)
		{
            return AccountDAL.Instance.UpdateAccount(account);
		}

        public bool DeleteAccount(int userID)
		{
            return AccountDAL.Instance.DeleteAccount(userID);
		}

        public void SearchAccount(DataGridView data, string keyword, string roleFilter = null)
		{
            data.DataSource = AccountDAL.Instance.SearchAccount(keyword, roleFilter);
		}
    }
}
