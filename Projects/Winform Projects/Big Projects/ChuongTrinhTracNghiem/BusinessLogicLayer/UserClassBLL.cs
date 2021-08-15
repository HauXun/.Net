using DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class UserClassBLL
    {
        private static UserClassBLL instance;

        public static UserClassBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserClassBLL();
                return instance;
            }
            private set => instance = value;
        }

        public void GetAllUserClass(ComboBox box)
        {
            DataTable data = UserClassDAL.Instance.GetAllUserClass();
            if (data.Rows.Count > 0)
            {
                if (box.Name == "cbClassFilter")
                {
                    DataRow row = data.NewRow();
                    row["ClassID"] = "Tất cả";
                    data.Rows.InsertAt(row, 0);
                }
                box.DataSource = data;
                box.DisplayMember = "ClassID";
                box.ValueMember = "ClassID";
            }
        }
    }
}
