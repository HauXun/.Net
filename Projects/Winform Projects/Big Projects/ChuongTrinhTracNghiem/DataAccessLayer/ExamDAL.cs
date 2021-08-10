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
			try
			{
				string query = "EXEC dbo.USP_InsertExam @ExamID , @SubjectID , @ExamRole , @ExamTime , @QCount , @CreatedBy , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						exam.ExamID,
						exam.SubjectID,
						exam.ExamRole,
						exam.ExamTime,
						exam.QCount,
						exam.CreatedBy,
						exam.ModifiedBy
					});
				return isAccess > 0;
			}
			catch (SqlException se)
			{
				switch (se.Number)
				{
					case 2627:
						throw new Exception($"Khóa trùng lặp, mã đề {exam.ExamID} và môn thi {SubjectDAL.Instance.GetSubjectByID(exam.SubjectID).SubjectName.Trim()} đã tồn tại trước đó. Không thể thực hiện thao tác này!".Trim());
					default:
						throw;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool UpdateExam(Exam exam)
		{
			try
			{
				string query = "EXEC dbo.USP_UpdateExam @ExamID , @SubjectID , @ExamRole , @ExamTime , @QCount , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						exam.ExamID,
						exam.SubjectID,
						exam.ExamRole,
						exam.ExamTime,
						exam.QCount,
						exam.ModifiedBy
					});
				return isAccess > 0;
			}
			catch (SqlException se)
			{
				switch (se.Number)
				{
					case 2627:
						throw new Exception($"Khóa trùng lặp, mã đề {exam.ExamID} và môn thi {SubjectDAL.Instance.GetSubjectByID(exam.SubjectID).SubjectName.Trim()} đã tồn tại trước đó. Không thể thực hiện thao tác này!".Trim());
					default:
						throw;
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

		public DataTable SearchExam(string keyword, string subjectID = "", string examRole = "")
		{
			try
			{
				string query = "EXEC dbo.USP_SearchExam @keyword , @SubjectID , @ExamRole";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { keyword, subjectID, examRole });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
