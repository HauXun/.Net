using Entities;
using System;
using System.Data;

namespace DataAccessLayer
{
    public class CourseDAL
    {
        private static CourseDAL instance;

        public static CourseDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CourseDAL();
                return instance;
            }
            private set => instance = value;
        }

        private CourseDAL() { }

        public DataTable GetAllCourse()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllCourse";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public Course GetCourseByID(string subjectID)
        //{
        //    try
        //    {
        //        string query = "EXEC dbo.USP_SelectCourseByID @CourseID";
        //        DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { subjectID });
        //        foreach (DataRow row in data.Rows)
        //        {
        //            return new Course(row);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    return null;
        //}

        public bool InsertCourse(CourseOrder course)
        {
            try
            {
                string query = "EXEC dbo.USP_InsertCourse @CourseID , @FacultyID , @TrainingRole , @Description";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        course.CourseID,
                        course.FacultyID,
                        course.TrainingID,
                        course.Description
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateCourse(CourseOrder course)
        {
            try
            {
                string query = "EXEC dbo.USP_UpdateCourse @CourseID , @FacultyID , @TrainingRole , @Description";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        course.CourseID,
                        course.FacultyID,
                        course.TrainingID,
                        course.Description
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteCourse(string courseID)
        {
            try
            {
                string query = "EXEC dbo.USP_DeleteCourse @CourseID";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { courseID });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable SearchCourse(string keyword)
        {
            try
            {
                string query = "EXEC dbo.USP_SearchCourse @keyword";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { keyword });
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
