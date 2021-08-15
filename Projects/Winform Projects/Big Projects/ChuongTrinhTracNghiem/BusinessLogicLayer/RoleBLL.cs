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
            DataTable data = UserRoleDAL.Instance.GetAllRoleUser();
            if (data.Rows.Count > 0)
			{
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
            DataTable data = ExamRoleDAL.Instance.GetAllRoleExam();
            if (data.Rows.Count > 0)
            {
                box.DisplayMember = "RoleName";
                box.ValueMember = "RoleID";
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
