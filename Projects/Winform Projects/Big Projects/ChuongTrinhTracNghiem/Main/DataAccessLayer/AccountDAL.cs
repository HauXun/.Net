using Entities;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

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
				byte[] temp = ASCIIEncoding.ASCII.GetBytes(user.Password);
				byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

				string pass = string.Join("", hasData);

				string query = "EXEC dbo.USP_CheckExistAccount @Username , @Password";
				int isExist = DataProvider.Instance.ExcuteScalar(query, new object[] { user.Username, pass }) == null ? 0 : 1;
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

		public bool ChangeInfoAccount(string pass, UserAccount account, string newPass = "")
		{
			try
			{
				byte[] bytePass = ASCIIEncoding.ASCII.GetBytes(pass);
				byte[] hasPass = new MD5CryptoServiceProvider().ComputeHash(bytePass);
				byte[] byteNewPass = ASCIIEncoding.ASCII.GetBytes(newPass);
				byte[] hasNewPass = new MD5CryptoServiceProvider().ComputeHash(byteNewPass);

				string password = string.Join("", hasPass);
				string newPassword = "";
				if (!newPass.Equals(""))
				{
					newPassword = string.Join("", hasNewPass);
				}	
				string query = "EXEC dbo.USP_ChangeInfoAccount @username , @fullName , @address , @phonenumber , @email , @birthday , @password , @newpassword";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
				{
					account.Username,
					account.FullName,
					account.Address,
					account.PhoneNumber,
					account.Email,
					account.Birthday,
					password,
					newPassword
				});
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
			string query = string.Empty;
			if (string.IsNullOrEmpty(account.ClassID))
			{
				query = $"EXEC dbo.USP_InsertAccount {account.UserID} , '{account.UserRole}' , NULL , '{account.Username}' , N'{account.FullName}' , '{account.Email}' , '{account.PhoneNumber}' , N'{account.Address}' , '{account.Birthday}' , N'{account.Note}' , N'{account.CreatedBy}' , N'{account.ModifiedBy}'";
			}
			else
			{
				query = $"EXEC dbo.USP_InsertAccount {account.UserID} , '{account.UserRole}' , '{account.ClassID}' , '{account.Username}' , N'{account.FullName}' , '{account.Email}' , '{account.PhoneNumber}' , N'{account.Address}' , '{account.Birthday}' , N'{account.Note}' , N'{account.CreatedBy}' , N'{account.ModifiedBy}'";
			}
			try
			{
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query);
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool UpdateAccount(UserAccount account)
		{
			string query = string.Empty;
			if (string.IsNullOrEmpty(account.ClassID))
			{
				query = $"EXEC dbo.USP_UpdateAccount {account.UserID} , '{account.UserRole}' , NULL , '{account.Username}' , N'{account.FullName}' , '{account.Email}' , '{account.PhoneNumber}' , N'{account.Address}' , '{account.Birthday}' , N'{account.Note}' , N'{account.ModifiedBy}'";
			}
			else
			{
				query = $"EXEC dbo.USP_UpdateAccount {account.UserID} , '{account.UserRole}' , '{account.ClassID}' , '{account.Username}' , N'{account.FullName}' , '{account.Email}' , '{account.PhoneNumber}' , N'{account.Address}' , '{account.Birthday}' , N'{account.Note}' , N'{account.ModifiedBy}'";
			}
			try
			{
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query);
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

		public DataTable SearchAccount(string keyword, string roleFilter = null)
		{
			try
			{
				string query = "EXEC dbo.USP_SearchAccount @keyword , @roleFilter";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { keyword, roleFilter });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
