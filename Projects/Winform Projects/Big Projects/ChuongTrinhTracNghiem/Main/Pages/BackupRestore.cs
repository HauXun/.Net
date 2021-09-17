using Main.Partial;
using System;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;

namespace Main.Pages
{
	public partial class BackupRestore : UserControl
	{
		string selectedPath = "";
		DataTable instances;

		public BackupRestore()
		{
			InitializeComponent();
			RoundedControls();
			instances = SqlDataSourceEnumerator.Instance.GetDataSources();
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

		private void btnBrowser_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread((ThreadStart)(() =>
			{
				OpenFileDialog dialog = new OpenFileDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					if (dialog.FileName != null)
					{
						selectedPath = dialog.FileName;
					}
				}
			}));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			tbDatabase.Text = selectedPath;
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
			btnSaoLuu.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnSaoLuu.Width, btnSaoLuu.Height, 6, 6));
			btnPassword.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnPassword.Width, btnPassword.Height, 6, 6));
		}
		#endregion

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
						cbSever.Items.Add(ServerName + "\\" + instanceName);
					}
				}
			}
		}

		private void BackupRestore_Load(object sender, EventArgs e)
		{
			GetDataSources();
		}
	}
}
