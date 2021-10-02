using DataAccessLayer;
using Main.Partial;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class EduProgBLL
	{
		private static EduProgBLL instance;

		public static EduProgBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new EduProgBLL();
				return instance;
			}
			private set => instance = value;
		}

		private EduProgBLL() { }

		public void GetAllEduProg(DataGridView data)
		{
			data.AutoGenerateColumns = false;
			data.DataSource = EduProgDAL.Instance.GetAllEduProg();
		}

		public IEnumerable<Script> GetEduProgUser(int userID)
		{
			return EduProgDAL.Instance.GetEduProgUser(userID);
		}

		public void SearchEduProg(DataGridView data, string keyword, ImageList imageList = null)
		{
			if (imageList != null)
			{
				if (data.Rows.Count > 0)
					data.Rows.Clear();
				IEnumerable<Script> a = EduProgDAL.Instance.SearchEduProg(keyword);
				foreach (var item in a)
				{
					if (!string.IsNullOrEmpty(item.TempSuccess.ToString()))
						item.Success = (bool)item.TempSuccess == true ? imageList.Images[1] : imageList.Images[0];
					else
						item.Success = imageList.Images[3];
					data.Rows.Add(new object[]
						{
								item.SemesterID,
								item.SubjectID,
								item.SubjectName,
								item.RoleName,
								item.CourseID,
								item.FacultyID,
								item.FacultyName,
								item.TotalMark,
								item.Success
						});
				};
			}
			else
			{
				BindingSource scripts = new BindingSource();
				List<Script> list = Enumerable.Cast<Script>(EduProgDAL.Instance.SearchEduProg(keyword)).ToList();
				scripts.DataSource = list;
				data.DataSource = scripts;
			}
		}
	}
}
