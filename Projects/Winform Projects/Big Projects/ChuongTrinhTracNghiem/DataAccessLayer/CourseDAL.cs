using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

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

        public DataTable GetAllCourseByFaculty(string facultyID)
		{
            try
            {
                string query = "EXEC dbo.USP_SelectAllCourseByFaculty @FacultyID";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { facultyID });
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

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
            catch (SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        throw new Exception($"Khóa trùng lặp, mã Khóa {course.CourseID} và Khoa {FacultyDAL.Instance.GetFacultyByID(course.FacultyID).FacultyName} đã tồn tại trước đó. Không thể thực hiện thao tác này!");
                    default:
                        throw se;
                }
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
            catch (SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        throw new Exception($"Khóa trùng lặp, mã Khóa {course.CourseID} và Khoa {FacultyDAL.Instance.GetFacultyByID(course.FacultyID).FacultyName} đã tồn tại trước đó. Không thể thực hiện thao tác này!");
                    default:
                        throw se;
                }
            } 
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteCourse(string courseID, string facultyID)
        {
            try
            {
                string query = "EXEC dbo.USP_DeleteCourse @CourseID , @FacultyID";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { courseID, facultyID });
                return isAccess > 0;
            }
            catch (SqlException se)
            {
                switch (se.Number)
                {
                    case 547:
                        throw new Exception($"Không thể xóa Khóa {courseID} của Khoa {FacultyDAL.Instance.GetFacultyByID(facultyID).FacultyName} vì tồn tại dữ liệu ràng buộc liên quan!");
                    default:
                        throw se;
                }
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
