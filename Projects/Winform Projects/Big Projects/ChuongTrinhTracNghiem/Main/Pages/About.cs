using Main.Partial;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class About : UserControl
	{
		public About()
		{
			InitializeComponent();
			pictureBox.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pictureBox.Width, pictureBox.Height, 6, 6));
		}

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += About_GotFocus;
		}

		private void About_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void pbBackground_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}
	}
}
