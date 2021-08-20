using DataAccessLayer;
using Entities;
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
                if (box.Name == "cbSubjectFilter")
                {
                    DataRow row = data.NewRow();
                    row["SubjectName"] = "Tất cả";
                    row["SubjectID"] = "ALL";
                    data.Rows.InsertAt(row, 0);
                }
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
