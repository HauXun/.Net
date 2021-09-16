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

		private UserClassBLL()
		{

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
				box.DisplayMember = "ClassID";
				box.ValueMember = "ClassID";
				box.DataSource = data;
			}
		}

		public void GetAllClassByCourseID(ComboBox box, string courseID)
		{
			DataTable data = UserClassDAL.Instance.GetAllClassByCourseID(courseID);
			box.DisplayMember = "ClassID";
			box.ValueMember = "ClassID";
			box.DataSource = data;
		}

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
