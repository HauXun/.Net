using DataAccessLayer;
using Entities;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class ExamBLL
    {
        private static ExamBLL instance;

        public static ExamBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ExamBLL();
                return instance;
            }
            private set => instance = value;
        }

        private ExamBLL() { }

        public void GetAllExam(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = ExamDAL.Instance.GetAllExam();
        }

        public void GetAllExam(ComboBox box)
        {
            box.DataSource = ExamDAL.Instance.GetAllExam();
        }

        public DataTable GetExamByIDSubject(string subjectID)
        {
            return ExamDAL.Instance.GetExamByIDSubject(subjectID);
        }


        public bool InsertExam(Exam subject)
		{
            return ExamDAL.Instance.InsertExam(subject);
		}

        public bool UpdateExam(Exam subject)
		{
            return ExamDAL.Instance.UpdateExam(subject);
		}

        public bool DeleteExam(string examID)
		{
            return ExamDAL.Instance.DeleteExam(examID);
		}

        public void SearchExam(DataGridView data, string keyword)
		{
            data.DataSource = ExamDAL.Instance.SearchExam(keyword);
		}
    }
}
