using System;
using System.Data;

namespace DataAccessLayer
{
	public class UserClassDAL
    {
        private static UserClassDAL instance;

        public static UserClassDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserClassDAL();
                return instance;
            }
            private set => instance = value;
        }

		private UserClassDAL()
		{

		}

        public DataTable GetAllUserClass()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllUserClass";
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
