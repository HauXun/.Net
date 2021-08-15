using Entities;
using System;
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

		public int GetIDMissing()
		{
			try
			{
				string query = "EXEC dbo.USP_GetAccountIDMissing";
				int isAccess = (int)DataProvider.Instance.ExcuteScalar(query);
				return isAccess;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

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

		public bool ChangeInfoAccount(string username, string displayname, string pass, string newPass)
		{
			try
			{
				string query = "EXEC dbo.USP_ChangeInfoAccount @username , @fullName , @password , @newpassword";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username, displayname, pass, newPass });
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool ResetPassword(string username)
		{
			try
			{
				string query = "EXEC dbo.USP_ResetPassword @username";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username });
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
				string query = "EXEC dbo.USP_InsertAccount @UserID , @UserRole , @ClassID , @Username , @FullName , @Email , @PhoneNumber , @Address , @Birthday , @Note , @CreatedBy , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						GetIDMissing(),
						account.UserRole,
						account.ClassID,
						account.Username,
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

		public bool UpdateAccount(UserAccount account)
		{
			try
			{
				string query = "EXEC dbo.USP_UpdateAccount @UserID , @UserRole , @ClassID , @Username , @FullName , @Email , @PhoneNumber , @Address , @Birthday , @Note , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						account.UserID,
						account.UserRole,
						account.ClassID,
						account.Username,
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

		public DataTable SearchAccount(string keyword, string roleFilter = null, string classFilter = null)
		{
			try
			{
				string query = "EXEC dbo.USP_SearchAccount @keyword , @roleFilter , @classFilter";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { keyword, roleFilter, classFilter });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
