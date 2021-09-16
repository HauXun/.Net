using System;
using System.Data;

namespace DataAccessLayer
{
    public class SemesterDAL
    {
        private static SemesterDAL instance;

        public static SemesterDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SemesterDAL();
                return instance;
            }
            private set => instance = value;
        }

        private SemesterDAL() { }

        public DataTable GetAllSemester()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllSemester";
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
