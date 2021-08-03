﻿using Entities;
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
                string query = "EXEC dbo.USP_InsertQuestion @SubjectID , @QContent , @OptionA , @OptionB , @OptionC , @OptionD , @Answer , @CreatedBy , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] 
                    { 
                        question.SubjectID,
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
                string query = "EXEC dbo.USP_UpdateQuestion  @SubjectID , @QContent , @OptionA , @OptionB , @OptionC , @OptionD , @Answer , @ModifiedBy";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        question.SubjectID,
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