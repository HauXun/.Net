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
                string query = "UserAccount_CheckExist @Username , @Password";
                isExist = (int)DataProvider.Instance.ExcuteScalar(query, new object[] { user.Username, user.Password });
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
    }
}
