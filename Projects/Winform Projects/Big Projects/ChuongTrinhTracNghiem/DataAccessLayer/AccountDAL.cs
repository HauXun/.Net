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
			try
			{
                string query = "EXEC dbo.USP_CheckExistAccount @Username , @Password";
                int isExist = DataProvider.Instance.ExcuteScalar(query, new object[] { user.Username, user.Password }) == null ? 0 : 1;
                //sqlCommand.CommandType = CommandType.StoredProcedure;

                //SqlDataReader dataReader = sqlCommand.ExecuteReader();
                //if (dataReader.Read())
                //    isExist = true;
                //dataReader.Close();
                return isExist > 0;
            }
			catch (Exception e)
			{
				throw e;
			}
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
			try
            {
                string query = "EXEC dbo.USP_UpdateAccount @username , @fullName , @password , @newpassword";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username, displayname, pass, newPass });
                return isAccess > 0;
            }
			catch (Exception e)
			{
                throw e;
			}
        }

        public bool InsertAccount(UserAccount account)
		{
            try
            {
                string query = "EXEC dbo.USP_InsertAccount @RoleID , @Username , @Password , @FullName , @Email , @PhoneNumber , @Address , @Birthday , @Note , @CreatedBy , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] 
                    { 
                        account.RoleID, 
                        account.Username, 
                        account.Password, 
                        account.FullName, 
                        account.Email, 
                        account.PhoneNumber, 
                        account.Address, 
                        account.Birthday, 
                        account.Note, 
                        account.CreatedBy, 
                        account.ModifiedBy 
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetAllAccount()
		{
			try
			{
                string query = "EXEC dbo.USP_SelectAllAccount";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                return data;
            }
			catch (Exception e)
			{
                throw e;
			}
		}

        public bool UpdateUser(UserAccount account)
		{
            try
            {
                string query = "EXEC dbo.USP_UpdateUserAccount @UserID , @RoleID , @Username , @Password , @FullName , @Email , @PhoneNumber , @Address , @Birthday , @Note , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        account.UserID,
                        account.RoleID,
                        account.Username,
                        account.Password,
                        account.FullName,
                        account.Email,
                        account.PhoneNumber,
                        account.Address,
                        account.Birthday,
                        account.Note,
                        account.ModifiedBy
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteAccount(int userID)
		{
            try
            {
                string query = "EXEC dbo.USP_DeleteAccount @UserID";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userID });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
