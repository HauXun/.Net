using DataAccessLayer;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class SemesterBLL
    {
        private static SemesterBLL instance;

        public static SemesterBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SemesterBLL();
                return instance;
            }
            private set => instance = value;
        }

        private SemesterBLL() { }

        public void GetAllSemester(ComboBox box)
		{
            DataTable data = SemesterDAL.Instance.GetAllSemester();
            if (data.Rows.Count > 0)
			{
                box.DisplayMember = "SemesterName";
                box.ValueMember = "SemesterID";
                box.DataSource = data;
			}                
		}
    }
}
