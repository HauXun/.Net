using DataAccessLayer;
using Entities;
using System.Data;
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

        public void GetAllCourse(DataGridView data)
        {
            data.AutoGenerateColumns = false;
            data.DataSource = CourseDAL.Instance.GetAllCourse();
        }

        //public Course GetCourseByID(string subjectID)
        //{
        //    return CourseDAL.Instance.GetCourseByID(subjectID);
        //}

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
