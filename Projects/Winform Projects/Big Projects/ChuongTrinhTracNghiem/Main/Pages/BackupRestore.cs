using Main.Partial;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class BackupRestore : UserControl
	{
		public BackupRestore()
		{
			InitializeComponent();
			RoundedControls();
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
			FolderBrowserDialog brows = new FolderBrowserDialog();
			brows.ShowDialog();
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
	}
}
