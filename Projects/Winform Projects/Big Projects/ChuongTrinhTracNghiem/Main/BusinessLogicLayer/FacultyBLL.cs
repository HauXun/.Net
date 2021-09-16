using DataAccessLayer;
using Entities;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class FacultyBLL
    {
        private static FacultyBLL instance;

        public static FacultyBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new FacultyBLL();
                return instance;
            }
            private set => instance = value;
        }

        private FacultyBLL() { }

        public void GetAllFaculty(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = FacultyDAL.Instance.GetAllFaculty();
        }

        public void GetAllFaculty(ComboBox box)
        {
            DataTable data = FacultyDAL.Instance.GetAllFaculty();
            if (data.Rows.Count > 0)
            {
                box.DisplayMember = "FacultyName";
                box.ValueMember = "FacultyID";
                box.DataSource = data;
            }
        }

        public bool InsertFaculty(Faculty subject)
		{
            return FacultyDAL.Instance.InsertFaculty(subject);
		}

        public bool UpdateFaculty(Faculty subject)
		{
            return FacultyDAL.Instance.UpdateFaculty(subject);
		}

        public bool DeleteFaculty(string facultyID)
		{
            return FacultyDAL.Instance.DeleteFaculty(facultyID);
		}

        public void SearchFaculty(DataGridView data, string keyword)
		{
            data.DataSource = FacultyDAL.Instance.SearchFaculty(keyword);
		}
    }
}
