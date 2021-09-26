using DataAccessLayer;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class EduProgBLL
    {
        private static EduProgBLL instance;

        public static EduProgBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new EduProgBLL();
                return instance;
            }
            private set => instance = value;
        }

        private EduProgBLL() { }

        public void GetAllEduProg(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = EduProgDAL.Instance.GetAllEduProg();
        }

        public DataTable GetEduProgUser(int userID)
        {
            return EduProgDAL.Instance.GetEduProgUser(userID);
        }

        public void SearchEduProg(DataGridView data, string keyword)
        {
            data.DataSource = EduProgDAL.Instance.SearchEduProg(keyword);
        }
    }
}
