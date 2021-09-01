using DataAccessLayer;
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

        public void GetEduProgUser(DataGridView data, int userID)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = EduProgDAL.Instance.GetEduProgUser(userID);
        }
    }
}
