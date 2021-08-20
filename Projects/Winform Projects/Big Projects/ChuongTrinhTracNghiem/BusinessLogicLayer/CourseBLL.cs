using DataAccessLayer;
using Entities;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class CourseBLL
	{
		private static CourseBLL instance;

		public static CourseBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new CourseBLL();
				return instance;
			}
			private set => instance = value;
		}

		private CourseBLL() { }

		public void GetAllCourseByFaculty(ComboBox box, string facultyID)
		{
			DataTable data = CourseDAL.Instance.GetAllCourseByFaculty(facultyID);
			box.DisplayMember = "CourseID";
			box.ValueMember = "CourseID";
			box.DataSource = data;
		}

		public void GetAllCourse(DataGridView data)
		{
			data.AutoGenerateColumns = false;
			data.DataSource = CourseDAL.Instance.GetAllCourse();
		}

		public void GetAllCourse(ComboBox box)
		{
			DataTable data = CourseDAL.Instance.GetAllCourse();
			if (data.Rows.Count > 0)
			{
				if (box.Name == "cbCourseFilter")
				{
					DataRow row = data.NewRow();
					row["CourseID"] = "Tất cả";
					data.Rows.InsertAt(row, 0);
				}
				data = data.AsEnumerable().GroupBy(x => x.Field<string>("CourseID")).Select(y => y.First()).CopyToDataTable();
				box.DisplayMember = "CourseID";
				box.ValueMember = "CourseID";
				box.DataSource = data;
			}
		}

		public bool InsertCourse(CourseOrder subject)
		{
			return CourseDAL.Instance.InsertCourse(subject);
		}

		public bool UpdateCourse(CourseOrder subject)
		{
			return CourseDAL.Instance.UpdateCourse(subject);
		}

		public bool DeleteCourse(string courseID)
		{
			return CourseDAL.Instance.DeleteCourse(courseID);
		}

		public void SearchCourse(DataGridView data, string keyword)
		{
			data.DataSource = CourseDAL.Instance.SearchCourse(keyword);
		}
	}
}
