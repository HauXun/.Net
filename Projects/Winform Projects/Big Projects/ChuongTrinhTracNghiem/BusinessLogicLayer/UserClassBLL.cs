using DataAccessLayer;
using Entities;
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

        public void GetAllClass(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = UserClassDAL.Instance.GetAllClass();
        }

        public void GetAllClass(ComboBox box)
        {
            DataTable data = UserClassDAL.Instance.GetAllClass();
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

        //public Class GetClassByID(string subjectID)
        //{
        //    return ClassDAL.Instance.GetClassByID(subjectID);
        //}

        public bool InsertClass(UserClass subject)
		{
            return UserClassDAL.Instance.InsertClass(subject);
		}

        public bool UpdateClass(UserClass subject)
		{
            return UserClassDAL.Instance.UpdateClass(subject);
		}

        public bool DeleteClass(string facultyID)
		{
            return UserClassDAL.Instance.DeleteClass(facultyID);
		}

        public void SearchClass(DataGridView data, string keyword)
		{
            data.DataSource = UserClassDAL.Instance.SearchClass(keyword);
		}
    }
}
