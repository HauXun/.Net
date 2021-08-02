using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void GetAllAccount(ComboBox box)
        {
   //         if (UserRoleDAL.Instance.GetAllRole().Rows.Count > 0)
   //         {
   //             box.DataSource = UserRoleDAL.Instance.GetAllRole();
   //             box.DisplayMember = "RoleName";
   //             box.ValueMember = "RoleID";
   //         }
			//else
			{
                List<string> role = new List<string>() { "Admin", "Teacher", "User" };
                box.DataSource = role;
			}
        }
    }
}
