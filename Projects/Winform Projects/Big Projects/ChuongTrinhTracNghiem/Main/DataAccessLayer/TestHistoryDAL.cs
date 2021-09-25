using Entities;
using System;
using System.Data;

namespace DataAccessLayer
{
	public class TestHistoryDAL
	{
		private static TestHistoryDAL instance;

		public static TestHistoryDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new TestHistoryDAL();
				return instance;
			}
			private set => instance = value;
		}

		private TestHistoryDAL() { }

		public void SaveTestHistory(TestHistory history)
		{
			try
			{
				string query = "EXEC dbo.USP_InsertTestHistory @ExamID , @SubjectID , @UserID , @SemesterID , @CorrectAnswer , @TotalQuestion , @MARK , @CreatedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						history.ExamID,
						history.SubjectID,
						history.UserID,
						history.SemesterID,
						history.CorrectAnswer,
						history.TotalQuestion,
						history.Mark,
						history.CreatedBy
					});
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable GetTestHistory(int userID)
		{
			try
			{
				string query = "EXEC dbo.USP_SelectTestHistory @UserID";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { userID });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable GetLeaderBoard()
		{
			try
			{
				string query = "EXEC dbo.USP_SelectLeaderBoard";
				DataTable data = DataProvider.Instance.ExcuteQuery(query);
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable SearchHistory(string keyword)
		{
			try
			{
				string query = "EXEC dbo.USP_SearchHistory @keyword";
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
