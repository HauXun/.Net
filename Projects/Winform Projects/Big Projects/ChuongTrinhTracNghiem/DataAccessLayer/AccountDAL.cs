using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class AccountDAL
    {
        private static AccountDAL instance;

		public static AccountDAL Instance 
        {
            get
			{
                if (instance == null)
                    instance = new AccountDAL();
                return instance;
			}
            private set => instance = value; 
        }

        private AccountDAL() { }

		public bool IsExistAccount(UserAccount user)
		{
            int isExist = 0;

			try
			{
                string query = "EXEC dbo.USP_CheckExistAccount @Username , @Password";
                isExist = DataProvider.Instance.ExcuteScalar(query, new object[] { user.Username, user.Password }) == null ? 0 : 1;
                //sqlCommand.CommandType = CommandType.StoredProcedure;

                //SqlDataReader dataReader = sqlCommand.ExecuteReader();
                //if (dataReader.Read())
                //    isExist = true;
                //dataReader.Close();
            }
			catch (Exception e)
			{
				throw e;
			}
            return isExist > 0;
		}

        public UserAccount GetAccountByUserName(string Username)
		{
			try
			{
                string query = "EXEC dbo.USP_GetAccountByUserName @Username";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { Username });
				foreach (DataRow item in data.Rows)
				{
                    return new UserAccount(item);
				}
            }
			catch (Exception e)
			{
                throw e;
			}
            return null;
		}

        public bool UpdateAccount(string username, string displayname, string pass, string newPass)
		{
            int isAccess = 0;
			try
            {
                string query = "EXEC dbo.USP_UpdateAccount @username , @fullName , @password , @newpassword";
                isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username, displayname, pass, newPass });
            }
			catch (Exception e)
			{
                throw e;
			}
            return isAccess > 0;
        }
    }
}
