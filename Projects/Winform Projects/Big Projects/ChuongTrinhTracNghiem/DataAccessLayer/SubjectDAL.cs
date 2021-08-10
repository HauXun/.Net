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

        public Subject GetSubjectByID(string subjectID)
		{
            try
            {
                string query = "EXEC dbo.USP_SelectSubjectByID @SubjectID";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { subjectID });
				foreach (DataRow row in data.Rows)
				{
                    return new Subject(row);
				}
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }

        public bool InsertSubject(Subject subject)
		{
            try
            {
                string query = "EXEC dbo.USP_InsertSubject @SubjectID , @SubjectName , @Description , @CreatedBy , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] 
                    { 
                        subject.SubjectID,
                        subject.SubjectName, 
                        subject.Description,
                        subject.CreatedBy,
                        subject.ModifiedBy
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
                string query = "EXEC dbo.USP_UpdateSubject @SubjectID , @SubjectName , @Description , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        subject.SubjectID,
                        subject.SubjectName,
                        subject.Description,
                        subject.ModifiedBy
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
                string query = "EXEC dbo.USP_SearchSubject @keyword";
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
