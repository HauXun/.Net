using DataAccessLayer;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class RoleBLL
	{
        private static RoleBLL instance;

        public static RoleBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleBLL();
                return instance;
            }
            private set => instance = value;
        }

        private RoleBLL() { }

        public void GetAllRoleUser(ComboBox box)
        {
			if (UserRoleDAL.Instance.GetAllRoleUser().Rows.Count > 0)
			{
                DataTable data = UserRoleDAL.Instance.GetAllRoleUser();
                if (box.Name == "cbFilter")
                {
                    DataRow row = data.NewRow();
                    row["RoleName"] = "Tất cả";
                    row["RoleID"] = "ALL";
                    data.Rows.InsertAt(row, 0);
                }
                box.DataSource = data;
				box.DisplayMember = "RoleName";
				box.ValueMember = "RoleID";             
			}
        }

        public void GetAllRoleExam(ComboBox box)
        {
            if (ExamRoleDAL.Instance.GetAllRoleExam().Rows.Count > 0)
            {
                box.DisplayMember = "RoleName";
                box.ValueMember = "RoleID";
                DataTable data = ExamRoleDAL.Instance.GetAllRoleExam();
                if (box.Name == "cbExamRoleFilter")
                {
                    DataRow row = data.NewRow();
                    row["RoleName"] = "Tất cả";
                    row["RoleID"] = "ALL";
                    data.Rows.InsertAt(row, 0);
                }
                box.DataSource = data;
            }
        }
    }
}
