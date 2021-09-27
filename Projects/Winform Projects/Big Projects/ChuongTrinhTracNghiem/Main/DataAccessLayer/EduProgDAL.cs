using System;
using System.Linq;
using System.Data;
using System.Collections;
using Main.Partial;
using System.Collections.Generic;

namespace DataAccessLayer
{
	public class EduProgDAL
	{
		private static EduProgDAL instance;

		public static EduProgDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new EduProgDAL();
				return instance;
			}
			private set => instance = value;
		}

		private EduProgDAL() { }

		public DataTable GetAllEduProg()
		{
			try
			{
				string query = "EXEC dbo.USP_SelectEduProg";
				DataTable data = DataProvider.Instance.ExcuteQuery(query);
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public IEnumerable<Script> GetEduProgUser(int userID)
		{
			try
			{
				string query = "EXEC dbo.USP_SelectEduProgUser @UserID";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { userID });
				var a = (from DataRow dr in data.Rows
						 select new Script()
						 {
							 SemesterID = Convert.ToByte(dr["SemesterID"]),
							 SubjectID = dr["SubjectID"].ToString(),
							 SubjectName = dr["SubjectName"].ToString(),
							 RoleName = dr["RoleName"].ToString(),
							 CourseID = dr["CourseID"].ToString(),
							 FacultyID = dr["FacultyID"].ToString(),
							 FacultyName = dr["FacultyName"].ToString(),
							 TotalMark = dr["TotalMark"].ToString(),
							 TempSuccess = dr["Success"]
						 });
				return a;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public IEnumerable<Script> SearchEduProg(string keyword)
		{
			try
			{
				string query = "EXEC dbo.USP_SearchEduProg @keyword";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { keyword });
				var a = (from DataRow dr in data.Rows
						 select new Script()
						 {
							 SemesterID = Convert.ToByte(dr["SemesterID"]),
							 SubjectID = dr["SubjectID"].ToString(),
							 SubjectName = dr["SubjectName"].ToString(),
							 RoleName = dr["RoleName"].ToString(),
							 CourseID = dr["CourseID"].ToString(),
							 FacultyID = dr["FacultyID"].ToString(),
							 FacultyName = dr["FacultyName"].ToString(),
							 TotalMark = dr["TotalMark"].ToString(),
							 TempSuccess = dr["Success"]
						 });
				return a;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
