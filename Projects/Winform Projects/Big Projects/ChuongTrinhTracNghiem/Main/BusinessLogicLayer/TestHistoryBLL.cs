using DataAccessLayer;
using Entities;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class TestHistoryBLL
	{
		private static TestHistoryBLL instance;

		public static TestHistoryBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new TestHistoryBLL();
				return instance;
			}
			private set => instance = value;
		}

		private TestHistoryBLL()
		{

		}

		public void SaveTestHistory(TestHistory history)
		{
			TestHistoryDAL.Instance.SaveTestHistory(history);
		}

		public void GetTestHistory(DataGridView data, int userID)
		{
			data.AutoGenerateColumns = false;
			data.DataSource = TestHistoryDAL.Instance.GetTestHistory(userID);
		}

		public void GetLeaderBoard(DataGridView data)
		{
			data.AutoGenerateColumns = false;
			data.DataSource = TestHistoryDAL.Instance.GetLeaderBoard();
		}

		public void SearchHistory(DataGridView data, string keyword)
		{
			data.DataSource = TestHistoryDAL.Instance.SearchHistory(keyword);
		}
	}
}
