using DataAccessLayer;
using Entities;
using System.Data;
using System.Linq;
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

		public Exam GetExamByRequest(string subjectID, bool isMockTest)
		{
			return ExamDAL.Instance.GetExamByRequest(subjectID, isMockTest);
		}

		public void GetAllExam(DataGridView data)
		{
			data.AutoGenerateColumns = false;
			data.DataSource = ExamDAL.Instance.GetAllExam();
		}

		public void GetAllExam(ComboBox box)
		{
			DataTable data = ExamDAL.Instance.GetAllExam();
			if (data.Rows.Count > 0)
			{
				data = data.AsEnumerable().GroupBy(x => x.Field<string>("ExamID")).Select(y => y.First()).CopyToDataTable();
				box.DisplayMember = "ExamID";
				box.ValueMember = "ExamID";
				box.DataSource = data;
			}
		}

		public DataTable GetExamByIDSubject(string subjectID)
		{
			DataTable data = ExamDAL.Instance.GetExamByIDSubject(subjectID);
			return data;
		}

		public bool InsertExam(Exam subject)
		{
			return ExamDAL.Instance.InsertExam(subject);
		}

		public bool UpdateExam(Exam subject)
		{
			return ExamDAL.Instance.UpdateExam(subject);
		}

		public bool DeleteExam(string examID, string subjectID)
		{
			return ExamDAL.Instance.DeleteExam(examID, subjectID);
		}

		public void SearchExam(DataGridView data, string keyword)
		{
			data.DataSource = ExamDAL.Instance.SearchExam(keyword);
		}

		public bool CancleQuizTimes(int userID, string examID, string subjectID)
		{
			return ExamDAL.Instance.CancleQuizTimes(userID, examID, subjectID);
		}
	}
}
