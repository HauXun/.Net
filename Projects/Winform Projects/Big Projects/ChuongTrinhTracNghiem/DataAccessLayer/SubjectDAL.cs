using Entities;
using System;
using System.Data;

namespace DataAccessLayer
{
	public class SubjectDAL
    {
        private static SubjectDAL instance;

		public static SubjectDAL Instance 
        {
            get
			{
                if (instance == null)
                    instance = new SubjectDAL();
                return instance;
			}
            private set => instance = value; 
        }

        private SubjectDAL() { }

        public DataTable GetAllSubject()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllSubject";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool InsertSubject(Subject subject)
		{
            try
            {
                string query = "EXEC dbo.USP_Insertsubject @SubjectID , @SubjectName , @Description , @CreatedBy , @CreatedAt , @ModifiedBy , @ModifiedAt";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] 
                    { 
                        subject.SubjectID,
                        subject.SubjectName, 
                        subject.Description,
                        subject.CreatedBy,
                        subject.CreatedAt,
                        subject.ModifiedBy,
                        subject.ModifiedAt
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateSubject(Subject subject)
		{
            try
            {
                string query = "EXEC dbo.USP_UpdateSubject @SubjectID , @SubjectName , @Description , @CreatedBy , @CreatedAt , @ModifiedBy , @ModifiedAt";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        subject.SubjectID,
                        subject.SubjectName,
                        subject.Description,
                        subject.CreatedBy,
                        subject.CreatedAt,
                        subject.ModifiedBy,
                        subject.ModifiedAt
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteSubject(string subjectID)
		{
            try
            {
                string query = "EXEC dbo.USP_DeleteSubject @SubjectID";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { subjectID });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable SearchSubject(string keyword)
        {
            try
            {
                string query = "EXEC dbo.USP_Searchsubject @keyword";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { keyword });
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
