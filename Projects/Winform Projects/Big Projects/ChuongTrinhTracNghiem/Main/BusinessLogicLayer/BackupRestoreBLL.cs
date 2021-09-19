using Bunifu.UI.WinForms;
using Main.DataAccessLayer;

namespace Main.BusinessLogicLayer
{
	class BackupRestoreBLL
	{
		private static BackupRestoreBLL instance;

		public static BackupRestoreBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new BackupRestoreBLL();
				return instance;
			}
			private set => instance = value;
		}

		public void BackupDatabase(string selectedPath, string name)
		{
			BackupRestoreDAL.Instance.BackupDatabase(selectedPath, name);
		}

		public void RestoreDatabase(string selectedPath)
		{
			BackupRestoreDAL.Instance.RestoreDatabase(selectedPath);
		}

		public void ListOfDatabase(BunifuDropdown box)
		{
			BackupRestoreDAL.Instance.ListOfDatabase(box);
		}
	}
}
