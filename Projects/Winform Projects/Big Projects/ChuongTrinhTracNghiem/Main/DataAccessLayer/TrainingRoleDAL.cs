using System;
using System.Data;

namespace DataAccessLayer
{
    public class TrainingRoleDAL
    {
        private static TrainingRoleDAL instance;

        public static TrainingRoleDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TrainingRoleDAL();
                return instance;
            }
            private set => instance = value;
        }

        private TrainingRoleDAL() { }

        public DataTable GetAllTrainingRole()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllTrainingRole";
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
