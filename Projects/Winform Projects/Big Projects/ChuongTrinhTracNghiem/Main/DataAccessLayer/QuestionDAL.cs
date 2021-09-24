using Entities;
using System;
using System.Data;

namespace DataAccessLayer
{
	public class QuestionDAL
	{
		private static QuestionDAL instance;

		public static QuestionDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new QuestionDAL();
				return instance;
			}
			private set => instance = value;
		}

		private QuestionDAL() { }

		public Question GetQuestionByID(int questionID)
		{
			try
			{
				string query = "EXEC dbo.USP_SelectQuestionByID @QuestionID";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { questionID });
				foreach (DataRow row in data.Rows)
				{
					return new Question(row);
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return null;
		}

		public DataTable GetQuestionByRequest(string examID, string subjectID)
		{
			try
			{
				string query = "EXEC dbo.USP_SelectQuestionByRequest @ExamID , @SubjectID";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { examID, subjectID });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable GetAllQuestion()
		{
			try
			{
				string query = "EXEC dbo.USP_SelectAllQuestion";
				DataTable data = DataProvider.Instance.ExcuteQuery(query);
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public int GetIDMissing()
		{
			try
			{
				string query = "EXEC dbo.USP_GetQuestionIDMissing";
				int isAccess = (int)DataProvider.Instance.ExcuteScalar(query);
				return isAccess;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool InsertQuestion(Question question)
		{
			try
			{
				string query = "EXEC dbo.USP_InsertQuestion @QuestionID , @SubjectID , @ExamID , @QContent , @OptionA , @OptionB , @OptionC , @OptionD , @Answer , @CreatedBy , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						question.QuestionID,
						question.SubjectID,
						question.ExamID,
						question.QContent,
						question.OptionA,
						question.OptionB,
						question.OptionC,
						question.OptionD,
						question.Answer,
						question.CreatedBy,
						question.ModifiedBy
					});
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool UpdateQuestion(Question question)
		{
			try
			{
				string query = "EXEC dbo.USP_UpdateQuestion @QuestionID ,  @SubjectID , @ExamID , @QContent , @OptionA , @OptionB , @OptionC , @OptionD , @Answer , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						question.QuestionID,
						question.SubjectID,
						question.ExamID,
						question.QContent,
						question.OptionA,
						question.OptionB,
						question.OptionC,
						question.OptionD,
						question.Answer,
						question.ModifiedBy
					});
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool DeleteQuestion(int questionID)
		{
			try
			{
				string query = "EXEC dbo.USP_DeleteQuestion @QuestionID";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { questionID });
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable SearchQuestion(string keyword)
		{
			try
			{
				string query = "EXEC dbo.USP_SearchQuestion @keyword";
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
