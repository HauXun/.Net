using System;
using System.Data;

namespace DataAccessLayer
{
    public class EduProgDAL
    {
        private static EduProgDAL instance;

        public static EduProgDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new EduProgDAL();
                return instance;
            }
            private set => instance = value;
        }

        private EduProgDAL() { }

        public DataTable GetAllEduProg()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectEduProg";
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
