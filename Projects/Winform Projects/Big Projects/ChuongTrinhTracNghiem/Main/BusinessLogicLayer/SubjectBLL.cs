using DataAccessLayer;
using Entities;
using Guna.UI2.WinForms;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class SubjectBLL
    {
        private static SubjectBLL instance;

        public static SubjectBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SubjectBLL();
                return instance;
            }
            private set => instance = value;
        }

        private SubjectBLL() { }

        public void GetSubjectFromEduProg(Guna2ComboBox box, int userID, bool isMockTest)
        {
            DataTable data = SubjectDAL.Instance.GetSubjectFromEduProg(userID, isMockTest);
            if (data.Rows.Count > 0)
            {
                box.DisplayMember = "SubjectName";
                box.ValueMember = "SubjectID";
                box.DataSource = data;
            }
			else
			{
                box.DataSource = null;
			}
        }

        public Subject GetSubjectByID(string subjectID)
        {
            return SubjectDAL.Instance.GetSubjectByID(subjectID);
        }

        public void GetAllSubject(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = SubjectDAL.Instance.GetAllSubject();
        }

        public void GetAllSubject(ComboBox box)
        {
            DataTable data = SubjectDAL.Instance.GetAllSubject();
            if (data.Rows.Count > 0)
            {
                box.DisplayMember = "SubjectName";
                box.ValueMember = "SubjectID";
                box.DataSource = data;
            }
        }

        public bool InsertSubject(Subject subject)
		{
            return SubjectDAL.Instance.InsertSubject(subject);
		}

        public bool UpdateSubject(Subject subject)
		{
            return SubjectDAL.Instance.UpdateSubject(subject);
		}

        public bool DeleteSubject(string subjectID)
		{
            return SubjectDAL.Instance.DeleteSubject(subjectID);
		}

        public void SearchSubject(DataGridView data, string keyword)
		{
            data.DataSource = SubjectDAL.Instance.SearchSubject(keyword);
		}
    }
}
