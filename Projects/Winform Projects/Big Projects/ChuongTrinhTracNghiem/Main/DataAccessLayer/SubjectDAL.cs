using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

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

        public DataTable GetSubjectFromEduProg(int userID, bool isMockTest)
		{
            try
            {
                string query = "EXEC dbo.USP_SelectSubjectFromEduProg @UserID , @IsMockTest";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { userID, isMockTest });
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
				foreach (DataRow item in data.Rows)
				{
                    return new Subject(item);
				}
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }

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
                string query = "EXEC dbo.USP_InsertSubject @SubjectID , @SubjectRole , @CourseID , @FacultyID , @SemesterID , @SubjectName , @Description , @CreatedBy , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] 
                    { 
                        subject.SubjectID,
                        subject.SubjectRole,
                        subject.CourseID,
                        subject.FacultyID,
                        subject.SemesterID,
                        subject.SubjectName, 
                        subject.Description,
                        subject.CreatedBy,
                        subject.ModifiedBy
                    });
                return isAccess > 0;
            }
            catch (SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        throw new Exception($"Khóa trùng lặp, mã môn thi {subject.SubjectID} đã tồn tại trước đó, các môn thi không thể mang các khoa trùng nhau. Không thể thực hiện thao tác này!");
                    default:
                        throw se;
                }
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
                string query = "EXEC dbo.USP_UpdateSubject @SubjectID , @SubjectRole , @CourseID , @FacultyID , @SemesterID , @SubjectName , @Description , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        subject.SubjectID,
                        subject.SubjectRole,
                        subject.CourseID,
                        subject.FacultyID,
                        subject.SemesterID,
                        subject.SubjectName,
                        subject.Description,
                        subject.ModifiedBy
                    });
                return isAccess > 0;
            }
            catch (SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        throw new Exception($"Khóa trùng lặp, mã môn thi {subject.SubjectID} đã tồn tại trước đó, các môn thi không thể mang các khoa trùng nhau. Không thể thực hiện thao tác này!");
                    default:
                        throw se;
                }
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
