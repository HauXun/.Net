using Entities;
using System;
using System.Data;

namespace DataAccessLayer
{
	public class ExamDAL
    {
        private static ExamDAL instance;

		public static ExamDAL Instance 
        {
            get
			{
                if (instance == null)
                    instance = new ExamDAL();
                return instance;
			}
            private set => instance = value; 
        }

        private ExamDAL() { }

        public DataTable GetAllExam()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllExam";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool InsertExam(Exam exam)
		{
            try
            {
                string query = "EXEC dbo.USP_InsertExam @ExamID , @SubjectID , @ExamTime , @QCount , @QCurrentCount , @CreatedBy , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        exam.ExamID,
                        exam.SubjectID,
                        exam.ExamTime, 
                        exam.QCount,
                        exam.QCurrentCount,
                        exam.CreatedBy,
                        exam.ModifiedBy
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateExam(Exam exam)
		{
            try
            {
                string query = "EXEC dbo.USP_UpdateExam @ExamID , @SubjectID , @ExamTime , @QCount , @QCurrentCount , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        exam.ExamID,
                        exam.SubjectID,
                        exam.ExamTime,
                        exam.QCount,
                        exam.QCurrentCount,
                        exam.ModifiedBy
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteExam(string examID)
		{
            try
            {
                string query = "EXEC dbo.USP_DeleteExam @ExamID";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { examID });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable SearchExam(string keyword)
        {
            try
            {
                string query = "EXEC dbo.USP_SearchExam @keyword";
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
