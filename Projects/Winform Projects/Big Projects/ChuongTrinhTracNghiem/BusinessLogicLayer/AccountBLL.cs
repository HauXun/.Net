using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public bool IsExistAccount(UserAccount account)
        {
            return AccountDAL.Instance.IsExistAccount(account);
		}

        public bool UpdateAccount(string username, string displayname, string pass, string newPass)
		{
            return AccountDAL.Instance.UpdateAccount(username, displayname, pass, newPass);
		}

        public UserAccount GetAccountByUserName(string Username)
		{
            return AccountDAL.Instance.GetAccountByUserName(Username);
		}

        public bool InsertAccount(UserAccount account)
		{
            return AccountDAL.Instance.InsertAccount(account);
		}

        public void GetAllAccount(DataGridView data)
		{
            data.AutoGenerateColumns = false;
            data.DataSource = AccountDAL.Instance.GetAllAccount();
		}

        public bool UpdateUser(UserAccount account)
		{
            return AccountDAL.Instance.UpdateUser(account);
		}

        public bool DeleteAccount(int userID)
		{
            return AccountDAL.Instance.DeleteAccount(userID);
		}
    }
}
