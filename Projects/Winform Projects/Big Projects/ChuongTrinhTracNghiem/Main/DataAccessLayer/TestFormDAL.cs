using System;
using System.Data;

namespace DataAccessLayer
{
    public class TestFormDAL
    {
        private static TestFormDAL instance;

        public static TestFormDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TestFormDAL();
                return instance;
            }
            private set => instance = value;
        }

        private TestFormDAL() { }

        public DataTable GetAllTestForm()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllTestForm";
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
