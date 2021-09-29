using Main.Partial;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class Guide : UserControl
	{
		byte minPage = 0;
		byte maxPage = 0;

		private string role;
		public string Role
		{
			get => role;
			set
			{
				role = value;
				ChangeRole(role);
			}
		}

		public Guide()
		{
			InitializeComponent();
			RoundedControl();
		}

		private void RoundedControl()
		{
			btnPreviousHelp.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnPreviousHelp.Width, btnPreviousHelp.Height, 6, 6));
			btnNextHelp.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnNextHelp.Width, btnNextHelp.Height, 6, 6));
		}

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void ChangeRole(string Role)
		{
			switch (Role)
			{
				case "Admin":
					minPage = 0;
					maxPage = 3;
					break;
				case "Teacher":
					minPage = 4;
					maxPage = 5;
					break;
				case "User":
					minPage = 6;
					maxPage = 9;
					break;
			}
			this.bP.SelectedIndex = minPage;
		}

		private void btnPreviousHelp_Click(object sender, EventArgs e)
		{
			if (this.bP.SelectedIndex > minPage)
				this.bP.SelectedIndex -= 1;
		}

		private void btnNextHelp_Click(object sender, EventArgs e)
		{
			if (this.bP.SelectedIndex < maxPage)
				this.bP.SelectedIndex += 1;
		}
	}
}
