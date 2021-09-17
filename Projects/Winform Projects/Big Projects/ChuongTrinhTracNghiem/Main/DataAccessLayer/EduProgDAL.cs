﻿using System;
using System.Data;

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

		public DataTable GetEduProgUser(int userID)
		{
			try
			{
				string query = "EXEC dbo.USP_SelectEduProgUser @UserID";
				DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { userID });
				return data;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void CancleQuizTimes(int userID, string subjetID)
		{
			try
			{
				string query = "EXEC dbo.USP_CancleQuizTimes @UserID , @SubjectID";
				DataProvider.Instance.ExcuteQuery(query, new object[] { userID, subjetID });
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}