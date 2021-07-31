using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool IsExistAccount(UserAccount user)
        {
            return AccountDAL.Instance.IsExistAccount(user);
        }

        public bool UpdateAccount(string username, string displayname, string pass, string newPass)
		{
            return AccountDAL.Instance.UpdateAccount(username, displayname, pass, newPass);
		}

        public UserAccount GetAccountByUserName(string Username)
		{
            return AccountDAL.Instance.GetAccountByUserName(Username);
		}
    }
}
