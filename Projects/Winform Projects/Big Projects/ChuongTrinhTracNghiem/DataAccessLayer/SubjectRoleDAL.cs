using System;
using System.Data;

namespace DataAccessLayer
{
    public class SubjectRoleDAL
    {
        private static SubjectRoleDAL instance;

        public static SubjectRoleDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SubjectRoleDAL();
                return instance;
            }
            private set => instance = value;
        }

        private SubjectRoleDAL() { }

        public DataTable GetAllSubjectRole()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllSubjectRole";
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
