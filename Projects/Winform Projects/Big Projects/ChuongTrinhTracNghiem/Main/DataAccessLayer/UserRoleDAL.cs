using System;
using System.Data;

namespace DataAccessLayer
{
	public class UserRoleDAL
	{
        private static UserRoleDAL instance;

        public static UserRoleDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserRoleDAL();
                return instance;
            }
            private set => instance = value;
        }

        private UserRoleDAL() { }

        public DataTable GetAllRoleUser()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllUserRole";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
