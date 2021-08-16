using Entities;
using System;
using System.Data;

namespace DataAccessLayer
{
    public class FacultyDAL
    {
        private static FacultyDAL instance;

        public static FacultyDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new FacultyDAL();
                return instance;
            }
            private set => instance = value;
        }

        private FacultyDAL() { }

        public DataTable GetAllFaculty()
        {
            try
            {
                string query = "EXEC dbo.USP_SelectAllFaculty";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public Faculty GetFacultyByID(string subjectID)
        //{
        //    try
        //    {
        //        string query = "EXEC dbo.USP_SelectFacultyByID @FacultyID";
        //        DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { subjectID });
        //        foreach (DataRow row in data.Rows)
        //        {
        //            return new Faculty(row);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    return null;
        //}

        public bool InsertFaculty(Faculty faculty)
        {
            try
            {
                string query = "EXEC dbo.USP_InsertFaculty @FacultyID , @FacultyName , @FoundingDate , @Description";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        faculty.FacultyID,
                        faculty.FacultyName,
                        faculty.FoundingDate,
                        faculty.Description
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            try
            {
                string query = "EXEC dbo.USP_UpdateFaculty @FacultyID , @FacultyName , @FoundingDate , @Description";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[]
                    {
                        faculty.FacultyID,
                        faculty.FacultyName,
                        faculty.FoundingDate,
                        faculty.Description
                    });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteFaculty(string facultyID)
        {
            try
            {
                string query = "EXEC dbo.USP_DeleteFaculty @FacultyID";
                int isAccess = DataProvider.Instance.ExcuteNonQuery(query, new object[] { facultyID });
                return isAccess > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable SearchFaculty(string keyword)
        {
            try
            {
                string query = "EXEC dbo.USP_SearchFaculty @keyword";
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
