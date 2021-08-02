using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DataTable GetAllRole()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllRoleUser";
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
