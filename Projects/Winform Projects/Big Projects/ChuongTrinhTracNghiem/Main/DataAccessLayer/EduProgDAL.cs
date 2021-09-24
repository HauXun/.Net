using Entities;
using Main.Partial;
using System;
using System.Collections;
using System.Collections.Generic;
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
			List<EduProg> eduProgs = new List<EduProg>();
			try
			{
				string query = "EXEC dbo.USP_SelectEduProg";
				DataTable data = DataProvider.Instance.ExcuteQuery(query);
				eduProgs=  Session.ConvertDataTable<EduProg>(data);
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
	}
}
