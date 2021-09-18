using Main.Partial;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Text;
using Guna.UI2.WinForms;
using Bunifu.UI.WinForms;
using System.Linq;
using System.Data.SqlClient;

namespace Main.Pages
{
	public partial class BackupRestore : UserControl
	{
		private string server;
		private string database;

		private bool isRestore = false;
		private bool isEnable = false;
		private string selectedPath = "";

		public BackupRestore()
		{
			InitializeComponent();
			RoundedControls();
			SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder(Session.connectionString);
			SqlConnection sqlConnection = new SqlConnection(Session.connectionString);
			

			server = sqlConnection.DataSource;           //-> this gives you the Server name.
			database = sqlConnection.Database;     //-> this gives you the Db name.
		}

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 90F)) // 196, 232, 250 || //FromArgb(230, 110, 130)
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		//Bo tròn góc các Control
		#region Rounded Controls
		private void RoundedControls()
		{
			//Panel
			pnlSaoLuu.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlSaoLuu.Width, pnlSaoLuu.Height, 10, 10));
			//Panel Shadow
			pnlSaoLuuShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlSaoLuuShadow.Width, pnlSaoLuuShadow.Height, 10, 10));
			//Button
			btnBackup.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnBackup.Width, btnBackup.Height, 6, 6));
			btnRestore.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnRestore.Width, btnRestore.Height, 6, 6));
		}
		#endregion

		private void btnBrowser_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread((ThreadStart)(() =>
			{
				if (isRestore)
				{
					OpenFileDialog dialog = new OpenFileDialog();
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

		private void GetDataSources()
		{
			string ServerName = Environment.MachineName;
			RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
			using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
			{
				RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
				if (instanceKey != null)
				{
					foreach (var instanceName in instanceKey.GetValueNames())
					{
						cbSever.Items.Add($@"{ServerName}\{instanceName}");
					}
				}
				cbSever.Items.Add(server);
			}
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

		private void btnRestore_Click(object sender, EventArgs e)
		{
			isRestore = true;
			VisibleButton(true);
			EnableControl(true);
			ClearControl();
			lbFunc.Text = "Database:";
		}

		private void btnSaoLuu_Click(object sender, EventArgs e)
		{
			VisibleButton(true);
			EnableControl(true);
			ClearControl();
			lbFunc.Text = "Save As:";
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			isRestore = false;
			VisibleButton(false);
			ClearControl();
			EnableControl(false);
			ClearError();
		}

		private void VisibleButton(bool isVisibleButton = false)
		{
			btnSave.Visible = btnCancle.Visible = isVisibleButton;
			btnBackup.Visible = btnRestore.Visible = !isVisibleButton;
		}

		private void EnableControl(bool isEnable = true)
		{
			pnlControls.Enabled = isEnable;
		}

		private void EnableProcess(bool isEnable = true)
		{
			barFunc.Visible = lbFunc.Visible = isEnable;
			barFunc.Value = 0;
			lbPercent.Text = "0%";
		}

		private void ClearControl()
		{
			foreach (Control control in pnlControls.Controls)
			{
				if (control is Guna2TextBox)
				{
					(control as Guna2TextBox).Text = "";
				}
				if (control is BunifuDropdown)
				{
					(control as BunifuDropdown).SelectedIndex = -1;
				}
			}
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(cbSever, "");
			errorProviderWar.SetError(tbFunc, "");
			errorProviderWar.SetError(tbUsername, "");
			errorProviderWar.SetError(tbPassword, "");
		}

		private bool IsValidData()
		{
			ClearError();

			if (cbSever.Items.Count == 0)
			{
				errorProviderWar.SetError(cbSever, "Không có server để thực hiện thao tác!\n Cài đặt trình cơ sở dữ liệu trước\nkhi thực hiện thao tác này");
				return false;
			}
			else
			{
				if (cbSever.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbSever, "Vui lòng chọn server\nđể thực hiện thao tác!");
					return false;
				}
			}
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

			// Kiểm tra tài khoản
			if (!string.IsNullOrEmpty(tbUsername.Text))
			{
				if (IsUnicode(tbUsername.Text))
				{
					errorProviderWar.SetError(tbUsername, "Tài khoản không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpaceCharacters(tbUsername.Text))
					{
						errorProviderWar.SetError(tbUsername, "Tài khoản không được chứa khoảng trắng!");
						return false;
					}

					if (IsSpecialCharacters(tbUsername.Text))
					{
						errorProviderWar.SetError(tbUsername, "Tài khoản không được chứa ký tự đặc biệt!");
						return false;
					}
				}

				if (IsUnicode(tbPassword.Text))
				{
					errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống!");
					return false;
				}
			}

			return true;
		}

		private bool IsUnicode(string input)
		{
			var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
			var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
			return asciiBytesCount != unicodBytesCount;
		}

		private bool IsSpecialCharacters(string input) => input.Any(p => !char.IsLetterOrDigit(p));

		private bool IsSpaceCharacters(string input) => input.Any(char.IsWhiteSpace);

		private bool IsDigit(string input) => input.All(char.IsDigit);

		private void Backup()
		{
			//if (!IsValidData())
			//{
			//	isEnable = true;
			//	return;
			//}

			//try
			//{
			//	if (cbSever.SelectedItem != null)
			//	{
			//		EnableProcess();
			//		string cmd = $"BACKUP DATABASE [{database}] TO DISK '{selectedPath}\\database-{DateTime.Now.ToString("yyyy-MM-dd--HH--mm--ss")}.bak'";
			//		Server dbServer = new Server(server);
			//		Backup dbBackup = new Backup()
			//		{
			//			Action = BackupActionType.Database,
			//			Database = database
			//		};
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			//}

			MsgBox.ShowMessage($"Server = {server}, Database = {database}", "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
		}

		private void Restore()
		{
			if (!IsValidData())
			{
				isEnable = true;
				return;
			}

			//EnableProcess();
			//try
			//{
			//	if (cbSever.SelectedItem != null)
			//	{
			//		Server dbServer = new Server(new ServerConnection(cbSever.SelectedItem.ToString(), tbUsername.Text, tbPassword.Text));
			//		Restore dbRestore = new Restore()
			//		{
			//			Action = RestoreActionType.Database,
			//			Database = database,
			//			ReplaceDatabase = true,
			//			NoRecovery = false
			//		};
			//		dbRestore.Devices.AddDevice(selectedPath, DeviceType.File);
			//		dbRestore.PercentComplete += DbRestore_PercentComplete;
			//		dbRestore.Complete += DbRestore_Complete;
			//		dbRestore.SqlRestoreAsync(dbServer);
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			//}
			MsgBox.ShowMessage("OK", "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
		}

		private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
		{
			if (e.Error != null)
			{
				lbStatus.Invoke((MethodInvoker)delegate
				{
					lbStatus.Text = e.Error.Message;
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
				lbPercent.Text = $"Status: {e.Percent}%";
			});
			if (lbPercent.Text.Equals("100%"))
			{
				MsgBox.ShowMessage("Khôi phục dữ liệu thành công", "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
				EnableProcess(false);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
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

		private void tbUsername_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbUsername.Text))
				tbPassword.Enabled = true;
			else
				tbPassword.Enabled = false;
		}

		private void BackupRestore_Load(object sender, EventArgs e)
		{
			GetDataSources();
			EnableControl(false);
		}
	}
}
