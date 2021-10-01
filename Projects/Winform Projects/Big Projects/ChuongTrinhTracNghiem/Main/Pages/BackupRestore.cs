using DataAccessLayer;
using Main.Partial;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class BackupRestore : UserControl
	{
		public Action CancleAction;
		public DatabaseConnection DatabaseConnection;
		SqlConnection connection;
		string database;

		private bool isRestore = false;
		private bool isEnable = false;
		private string selectedPath = "";

		public BackupRestore()
		{
			InitializeComponent();
			RoundedControls();
			DatabaseConnection = new DatabaseConnection(new SqlConnection(DataProvider.connectionString).Database);
			CancleAction = () =>
			{
				if (btnSave.Visible && MsgBox.ShowMessage("Dữ liệu chưa được lưu!. Tiếp tục thoát ?", "Amazing Quiz Application",
					   MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
				{
					if (!DatabaseConnection.IsDisposed)
						DatabaseConnection.Dispose();
					btnCancle_Click(this, new EventArgs());
					Session.Cancle = true;
				}
				else if (!btnSave.Visible)
				{
					if (!DatabaseConnection.IsDisposed)
						DatabaseConnection.Dispose();
					Session.Cancle = true;
				}
				else
					Session.Cancle = false;
			};
		}

		//Bo tròn góc các Control
		#region Rounded Controls

		private void RoundedControls()
		{
			//Button
			btnBackup.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnBackup.Width, btnBackup.Height, 6, 6));
			btnRestore.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnRestore.Width, btnRestore.Height, 6, 6));
			btnSave.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 6, 6));
			btnCancle.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnCancle.Width, btnCancle.Height, 6, 6));
			btnConnect.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnConnect.Width, btnConnect.Height, 6, 6));
			btnDisconnect.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnDisconnect.Width, btnDisconnect.Height, 6, 6));
			btnBrowser.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnBrowser.Width, btnBrowser.Height, 6, 6));
		}

		#endregion

		#region Method

		private void Backup()
		{
			if (!IsValidData())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (!string.IsNullOrEmpty(tbServer.Text))
				{
					EnableProcess();
					Server dbServer = new Server(new ServerConnection(connection));
					Microsoft.SqlServer.Management.Smo.Backup dbBackup = new Backup()
					{
						Action = BackupActionType.Database,
						Database = database
					};
					dbBackup.Devices.AddDevice($"{tbFunc.Text.Trim()}\\{database}_BACKUP({RandomString(5)}).bak", DeviceType.File);
					dbBackup.Initialize = true;
					dbBackup.PercentComplete += DbBackup_PercentComplete;
					dbBackup.Complete += DbBackup_Complete;
					dbBackup.SqlBackupAsync(dbServer);
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				EnableProcess(false);
			}
		}

		private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
		{
			if (e.Error != null)
			{
				lbStatus.Invoke((MethodInvoker)delegate
				{
					lbStatus.Text = $"Status: {e.Error.Message}";
				});
			}
		}

		private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
		{
			barFunc.Invoke((MethodInvoker)delegate
			{
				barFunc.Value = e.Percent;
				barFunc.Update();
			});
			lbPercent.Invoke((MethodInvoker)delegate
			{
				lbPercent.Text = $"{e.Percent}%";
			});
		}

		private void Restore()
		{
			if (!IsValidData())
			{
				isEnable = true;
				return;
			}

			try
			{
				if (!string.IsNullOrEmpty(tbServer.Text))
				{
					EnableProcess();

					Server dbServer = new Server(new ServerConnection(connection));
					Microsoft.SqlServer.Management.Smo.Restore dbRestore = new Restore()
					{
						Action = RestoreActionType.Database,
						Database = database,
						ReplaceDatabase = true,
						NoRecovery = false
					};
					dbRestore.Devices.AddDevice($"{tbFunc.Text.Trim()}", DeviceType.File);
					dbRestore.PercentComplete += DbRestore_PercentComplete;
					dbRestore.Complete += DbRestore_Complete;
					dbRestore.SqlRestoreAsync(dbServer);
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
				EnableProcess(false);
			}
		}

		private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
		{
			if (e.Error != null)
			{
				lbStatus.Invoke((MethodInvoker)delegate
				{
					lbStatus.Text = $"Status: {e.Error.Message}";
				});
			}
		}

		private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
		{
			barFunc.Invoke((MethodInvoker)delegate
			{
				barFunc.Value = e.Percent;
				barFunc.Update();
			});
			lbPercent.Invoke((MethodInvoker)delegate
			{
				lbPercent.Text = $"{e.Percent}%";
			});
		}

		public string RandomString(int size, bool lowerCase = false)
		{

			Random _random = new Random();
			var builder = new StringBuilder(size);

			// Unicode/ASCII Letters are divided into two blocks
			// (Letters 65–90 / 97–122):   
			// The first group containing the uppercase letters and
			// the second group containing the lowercase.  

			// char is a single Unicode character  
			char offset = lowerCase ? 'a' : 'A';
			const int lettersOffset = 26; // A...Z or a..z: length = 26  

			for (var i = 0; i < size; i++)
			{
				var @char = (char)_random.Next(offset, offset + lettersOffset);
				builder.Append(@char);
			}

			return lowerCase ? builder.ToString().ToLower() : builder.ToString();
		}

		private void DefaultSettings()
		{
			tbServer.Text = string.Empty;
			DatabaseConnection.Connected = false;
			tbFunc.Text = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup";
		}

		private void VisibleButton(bool isVisibleButton = false)
		{
			btnSave.Visible = btnCancle.Visible = isVisibleButton;
			btnBackup.Visible = btnRestore.Visible = !isVisibleButton;
		}

		private void EnableControl(bool isEnable = true)
		{
			gpDB.Enabled = isEnable;
		}

		private void EnableProcess(bool isEnable = true)
		{
			barFunc.Visible = lbPercent.Visible = isEnable;
			barFunc.Value = 0;
			lbPercent.Text = "0%";
			lbStatus.Text = "Status: ";
		}

		private void ClearControl()
		{
			tbFunc.Text = string.Empty;
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbFunc, "");
		}

		private bool IsValidData()
		{
			ClearError();

			if (isRestore)
			{
				// Kiểm tra file không được để trống
				if (string.IsNullOrEmpty(tbFunc.Text))
				{
					errorProviderWar.SetError(tbFunc, "Vui lòng chọn file khôi phục dữ liệu!");
					return false;
				}
			}
			else
			{
				// Kiểm tra đường dẫn lưu file không được để trống
				if (string.IsNullOrEmpty(tbFunc.Text))
				{
					errorProviderWar.SetError(tbFunc, "Vui lòng chọn đường dẫn lưu file!");
					return false;
				}
			}

			return true;
		}

		#endregion

		#region Events

		private void btnRestore_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (!DatabaseConnection.Connected)
			{
				btnConnect_Click(this, e);
				if (DatabaseConnection.Connected)
					btnRestore_Click(sender, e);
			}
			else
			{
				isRestore = true;
				VisibleButton(true);
				EnableControl(true);
				EnableProcess(false);
				lbFunc.Text = "Database Path:";
			}
		}

		private void btnSaoLuu_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			if (!DatabaseConnection.Connected)
			{
				btnConnect_Click(this, e);
				if (DatabaseConnection.Connected)
					btnSaoLuu_Click(sender, e);
			}
			else
			{
				VisibleButton(true);
				EnableControl(true);
				EnableProcess(false);
				lbFunc.Text = "Backup Path:";
			}
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isRestore = false;
			VisibleButton(false);
			ClearControl();
			EnableControl(false);
			ClearError();
		}

		private void btnBrowser_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			Thread thread = new Thread((ThreadStart)(() =>
			{
				if (isRestore)
				{
					OpenFileDialog dialog = new OpenFileDialog();
					dialog.InitialDirectory = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup";
					dialog.CheckFileExists = true;
					dialog.CheckPathExists = true;
					dialog.DefaultExt = "BAK";
					dialog.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)| (*.*)";
					dialog.Title = "Database Restore";
					dialog.FilterIndex = 0;
					dialog.RestoreDirectory = true;
					dialog.ReadOnlyChecked = true;
					dialog.ShowReadOnly = true;
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						if (dialog.FileName != null)
						{
							selectedPath = dialog.FileName;
						}
					}
				}
				else
				{
					FolderBrowserDialog dialog = new FolderBrowserDialog();
					dialog.SelectedPath = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup";
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						if (dialog.SelectedPath != null)
						{
							selectedPath = dialog.SelectedPath;
						}
					}
				}
			}));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			tbFunc.Text = selectedPath;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			isEnable = false;
			try
			{
				if (isRestore)
					Restore();
				else
					Backup();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
			VisibleButton(isEnable);
			EnableControl(isEnable);
		}

		public void BackupRestore_Load(object sender, EventArgs e)
		{
			EnableControl(false);
			EnableProcess(false);
			DefaultSettings();
			if (!DatabaseConnection.IsDisposed)
				DatabaseConnection.Dispose();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			try
			{
				if (DatabaseConnection != null)
					DatabaseConnection = new DatabaseConnection(new SqlConnection(DataProvider.connectionString).Database);
				DatabaseConnection.ShowDialog();
				if (DatabaseConnection.Connected)
				{
					tbServer.Text = DatabaseConnection.cbServer.SelectedItem.ToString();
					connection = new SqlConnection(DatabaseConnection.ConnectionString);
					database = connection.Database;
					EnableControl();
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			ClearControl();
			EnableControl(false);
			ClearError();
			DefaultSettings();
			btnCancle_Click(this, e);
		}

		private void btnRestore_Enter(object sender, EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += BackupRestore_GotFocus;
		}

		private void BackupRestore_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void pbBackground_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
