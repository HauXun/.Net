using System;
using System.Data;

namespace DataAccessLayer
{
	public class ExamRoleDAL
    {
        private static ExamRoleDAL instance;

        public static ExamRoleDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ExamRoleDAL();
                return instance;
            }
            private set => instance = value;
        }

        private ExamRoleDAL() { }

        public DataTable GetAllRoleExam()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllRoleExam";
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
