using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class AccountDAO
	{
		private static AccountDAO instance;

		public static AccountDAO Instance
		{
			get
			{
				if (instance == null)
					instance = new AccountDAO();
				return instance;
			}
			private set => instance = value;
		}

		private AccountDAO() { }

		public bool IsExistAccount(string username, string password)
		{
			byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
			byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

			string hashStr = "";
			foreach (byte item in hashData)
			{
				hashStr += item;
			}

			string query = $"EXEC dbo.USE_Login @userName , @passWord";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { username, password /*hashStr*/ });
			return data.Rows.Count > 0;
		}

		public Account GetAccountByUserName(string username)
		{
			DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Account WhERE Username = N'" + username + "'");
			foreach (DataRow item in data.Rows)
			{
				return new Account(item);
			}
			return null;
		}

		public bool UpdateAccount(string username, string displayname, string pass, string newpass)
		{
			string query = "EXEC USP_UpdateAccount @username , @displayname , @password , @newpassword";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username, displayname, pass, newpass });
			return result > 0;
		}

		public DataTable GetListAccount()
		{
			return DataProvider.Instance.ExcuteQuery("SELECT UserName, DisplayName, Type FROM dbo.Account");
		}

		public bool InsertAccount(string name, string displayname, int type)
		{
			string query = $"INSERT dbo.Account ( Username, Displayname, Type, Password ) VALUES ( N'{name}', N'{displayname}', {type}, N'{"1962026656160185351301320480154111117132155"}' )";
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool UpdateAccount(string name, string displayname, int type)
		{
			string query = $"UPDATE dbo.Account SET Displayname = N'{displayname}', Type = {type} WHERE Username = N'{name}'";
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool DeleteAccount(string username)
		{
			string query = $"DELETE dbo.Account WHERE Username = N'{username}'";
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}

		public bool ResetPassword(string name)
		{
			string query = $"UPDATE dbo.Account SET Password = N'1962026656160185351301320480154111117132155' WHERE Username = N'{name}'";
			int result = DataProvider.Instance.ExcuteNonQuery(query);
			return result > 0;
		}
	}
}
