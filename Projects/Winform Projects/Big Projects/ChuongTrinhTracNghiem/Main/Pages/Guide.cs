using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class Guide : UserControl
	{
		public Guide()
		{
			InitializeComponent();
		}

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}
	}
}
