using Main.Partial;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
	public partial class DatabaseConnection : Form
	{
		public string ConnectionString { get; set; }
		public bool Connected { get; set; }
		public string Database { get; set; }

		public DatabaseConnection(string database)
		{
			InitializeComponent();
			RoundedControl();
			GetDataSources();
			Connected = false;
			Database = database;
		}

		private void Pnl1_Paint(object sender, PaintEventArgs e)
		{
			Rectangle rectangle = pnl1.ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 90F)) // 196, 232, 250 || //FromArgb(230, 110, 130)
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		//Bo tròn góc các control
		#region RoundedControls

		private void RoundedControl()
		{
			btnConnect.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnConnect.Width, btnConnect.Height, 5, 5));
			btnTestConnect.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnTestConnect.Width, btnTestConnect.Height, 5, 5));
			this.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
			pnl1.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnl1.Width, pnl1.Height, 5, 5));
			pnl2.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnl2.Width, pnl2.Height, 5, 5));
		}

		#endregion

		#region Methods

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
						cbServer.Items.Add($@"{ServerName}\{instanceName}");
					}
				}
			}
		}

		private void TestConnection()
		{
			EnableControl(false);
			if (cbAuthentication.SelectedIndex == 0)
				ConnectionString = $@"Data Source = {cbServer.SelectedItem}; Initial Catalog = {Database}; Integrated Security = True;";
			else
				ConnectionString = $@"Data Source = {cbServer.SelectedItem}; Initial Catalog = {Database}; User Id = {tbUsername.Text.Trim()}; Password = {tbPassword.Text.Trim()};";
			wP.Visible = true;
			Task.Run(() =>
			{
				try
				{
					SqlHelper sqlHelper = new SqlHelper(ConnectionString);
					if (sqlHelper.IsConnection)
					{
						this.BeginInvoke((MethodInvoker)delegate
						{
							if (Connected)
								this.Close();
							else
							{
								MsgBox.ShowMessage("Test Connection Succeeded", "Sql Connect", MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
								Connected = false;
							}
							wP.Visible = false;
							EnableControl();
						});
					}
				}
				catch (Exception e)
				{
					if (InvokeRequired)
						this.BeginInvoke((MethodInvoker)delegate
						{
							MsgBox.ShowMessage(e.Message, "Sql Connect", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
							EnableControl();
							wP.Visible = Connected = false;
						});
				}
			});
		}

		private void EnableControl(bool isEnable = true)
		{
			btnConnect.Enabled = btnTestConnect.Enabled = btnExit.Enabled = isEnable;
		}

		private void DefaultSettings()
		{
			cbServer.SelectedIndex = 0;
			//cbServer.Text = Dns.GetHostName().ToUpper() + @"\SQLEXPRESS";
			cbAuthentication.SelectedIndex = 0;
			wP.Visible = false;
			tbUsername.Text = tbPassword.Text = string.Empty;
		}

		private void ClearError()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(cbServer, "");
			errorProviderWar.SetError(cbAuthentication, "");
			errorProviderWar.SetError(tbUsername, "");
			errorProviderWar.SetError(tbPassword, "");
		}

		private bool IsValidData()
		{
			ClearError();

			if (cbServer.Items.Count == 0)
			{
				errorProviderWar.SetError(cbServer, "Không có server để thực hiện thao tác!\n Cài đặt trình cơ sở dữ liệu trước\nkhi thực hiện thao tác này");
				return false;
			}
			else
			{
				if (cbServer.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbServer, "Vui lòng chọn server\nđể thực hiện thao tác!");
					return false;
				}
			}


			if (cbAuthentication.SelectedIndex == -1)
			{
				errorProviderWar.SetError(cbAuthentication, "Vui lòng chọn server xác thực\nđể thực hiện thao tác!");
				return false;
			}

			// Kiểm tra tài khoản
			if (cbAuthentication.SelectedIndex == 1)
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
					errorProviderWar.SetError(tbPassword, "Mật khẩu không được có dấu!");
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

		#endregion

		#region Events

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DatabaseConnection_Shown(object sender, EventArgs e)
		{
			DefaultSettings();
		}

		private void cbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbPassword.Text = tbUsername.Text = string.Empty;
			pnlAccount.Enabled = cbAuthentication.SelectedIndex == 1 ? true : false;
		}

		private void btnTestConnect_Click(object sender, EventArgs e)
		{
			if (!IsValidData())
				return;
			Connected = false;
			TestConnection();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			if (!IsValidData())
				return;

			Connected = true;
			TestConnection();
		}

		private void btnTestConnect_Enter(object sender, EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += DatabaseConnection_GotFocus;
		}

		private void DatabaseConnection_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		#endregion
	}
}
