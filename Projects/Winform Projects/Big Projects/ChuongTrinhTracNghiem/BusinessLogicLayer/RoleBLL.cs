using DataAccessLayer;
using System.Collections.Generic;
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

        public void GetAllRole(ComboBox box)
        {
			if (UserRoleDAL.Instance.GetAllRole().Rows.Count > 0)
			{
                DataTable data = UserRoleDAL.Instance.GetAllRole();
                if (box.Name == "cbRoleFilter")
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
    }
}
