using System;
using Entities;
using System.Data;

namespace DataAccessLayer
{
	public class UserClassDAL
	{
		private static UserClassDAL instance;

		public static UserClassDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new UserClassDAL();
				return instance;
			}
			private set => instance = value;
		}

		private UserClassDAL()
		{

		}

		public DataTable GetAllClassByCourseID(string courseID)
		{
			try
			{
				string query = "EXEC dbo.USP_SelectClassByCourseID @CourseID";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { courseID });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable GetAllClass()
		{
			try
			{
				string query = "EXEC dbo.USP_SelectAllClass";
				DataTable data = DataProvider.Instance.ExcuteQuery(query);
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool InsertClass(UserClass userClass)
		{
			try
			{
				string query = "EXEC dbo.USP_InsertClass @ClassID , @CourseID , @FacultyID , @Description , @CreatedBy , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						userClass.ClassID,
						userClass.CourseID,
						userClass.FacultyID,
						userClass.Description,
						userClass.CreatedBy,
						userClass.ModifiedBy
					});
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool UpdateClass(UserClass userClass)
		{
			try
			{
				string query = "EXEC dbo.USP_UpdateClass @ClassID , @CourseID , @FacultyID , @Description , @ModifiedBy";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
					{
						userClass.ClassID,
						userClass.CourseID,
						userClass.FacultyID,
						userClass.Description,
						userClass.ModifiedBy
					});
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public bool DeleteClass(string classID)
		{
			try
			{
				string query = "EXEC dbo.USP_DeleteClass @ClassID";
				int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { classID });
				return isAccess > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public DataTable SearchClass(string keyword)
		{
			try
			{
				string query = "EXEC dbo.USP_SearchClass @keyword";
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
