using DataAccessLayer;
using Entities;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class QuestionBLL
    {
        private static QuestionBLL instance;

        public static QuestionBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuestionBLL();
                return instance;
            }
            private set => instance = value;
        }

        private QuestionBLL() { }

        public Question GetQuestionByID(int questionID)
		{
            return QuestionDAL.Instance.GetQuestionByID(questionID);
		}

        public DataTable GetQuestionByRequest(string examID, string subjectID)
        {
            return QuestionDAL.Instance.GetQuestionByRequest(examID, subjectID);
        }

        public void GetAllQuestion(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = QuestionDAL.Instance.GetAllQuestion();
        }

        public int GetIDMissing()
        {
            return QuestionDAL.Instance.GetIDMissing();
        }

        public bool InsertQuestion(Question subject)
		{
            return QuestionDAL.Instance.InsertQuestion(subject);
		}

        public bool UpdateQuestion(Question subject)
		{
            return QuestionDAL.Instance.UpdateQuestion(subject);
		}

        public bool DeleteQuestion(int questionID)
		{
            return QuestionDAL.Instance.DeleteQuestion(questionID);
		}

        public void SearchQuestion(DataGridView data, string keyword)
		{
            data.DataSource = QuestionDAL.Instance.SearchQuestion(keyword);
		}
    }
}
