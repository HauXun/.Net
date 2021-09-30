using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

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

		public Exam GetExamByRequest(string subjectID, bool isMockTest)
		{
			try
			{
				string query = "EXEC dbo.USP_SelectExamByRequest @SubjectID , @IsMockTest";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { subjectID, isMockTest });
				foreach (DataRow row in data.Rows)
				{
					return new Exam(row);
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return null;
		}

		public DataTable GetExamByIDSubject(string subjectID)
		{
			try
			{
				string query = "EXEC dbo.USP_GetExamByIDSubject @SubjectID";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { subjectID });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool InsertExam(Exam exam)
		{
			string query = string.Empty;
			if (string.IsNullOrEmpty(exam.TestFormID))
			{
				query = $"EXEC dbo.USP_InsertExam '{exam.ExamID}' , '{exam.SubjectID}' , NULL , NULL , '{exam.ExamRole}' , '{exam.ExamTime}' , '{exam.QCount}' , '{exam.QuizTimes}' , '{exam.Status}' , N'{exam.CreatedBy}' , N'{exam.ModifiedBy}'";
			}
			else
			{
				query = $"EXEC dbo.USP_InsertExam '{exam.ExamID}' , '{exam.SubjectID}' , '{exam.TestFormID}' , '{exam.PercentMark}' , '{exam.ExamRole}' , '{exam.ExamTime}' , '{exam.QCount}' , '{exam.QuizTimes}' , '{exam.Status}' , N'{exam.CreatedBy}' , N'{exam.ModifiedBy}'";
			}
			try
			{
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query);
				return isAccess > 0;
			}
			catch (SqlException se)
			{
				switch (se.Number)
				{
					case 2627:
						throw new Exception($"Khóa trùng lặp, mã đề {exam.ExamID} và môn thi {SubjectDAL.Instance.GetSubjectByID(exam.SubjectID).SubjectName} đã tồn tại trước đó, mã đề và môn thi không thể mang các khóa trùng nhau. Không thể thực hiện thao tác này!");
					default:
						throw se;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool UpdateExam(Exam exam)
		{
			string query = string.Empty;
			if (string.IsNullOrEmpty(exam.TestFormID))
			{
				query = $"EXEC dbo.USP_UpdateExam '{exam.ExamID}' , '{exam.SubjectID}' , NULL , NULL , '{exam.ExamRole}' , '{exam.ExamTime}' , '{exam.QCount}' , '{exam.QuizTimes}' , '{exam.Status}' , N'{exam.ModifiedBy}'";
			}
			else
			{
				query = $"EXEC dbo.USP_UpdateExam '{exam.ExamID}' , '{exam.SubjectID}' , '{exam.TestFormID}' , '{exam.PercentMark}' , '{exam.ExamRole}' , '{exam.ExamTime}' , '{exam.QCount}' , '{exam.QuizTimes}' , '{exam.Status}' , N'{exam.ModifiedBy}'";
			}
			try
			{
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query);
				return isAccess > 0;
			}
			catch (SqlException se)
			{
				switch (se.Number)
				{
					case 2627:
						throw new Exception($"Khóa trùng lặp, mã đề {exam.ExamID} và môn thi {SubjectDAL.Instance.GetSubjectByID(exam.SubjectID).SubjectName} đã tồn tại trước đó, mã đề và môn thi không thể mang các khóa trùng nhau. Không thể thực hiện thao tác này!");
					default:
						throw se;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool DeleteExam(string examID, string subjectID)
		{
			try
			{
				string query = "EXEC dbo.USP_DeleteExam @ExamID , @SubjectID";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { examID, subjectID });
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

		public bool CancleQuizTimes(int userID, string examID, string subjectID)
		{
			try
			{
				string query = "EXEC dbo.USP_CancleQuizTimes @UserID , @ExamID , @SubjectID";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userID, examID, subjectID });
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
