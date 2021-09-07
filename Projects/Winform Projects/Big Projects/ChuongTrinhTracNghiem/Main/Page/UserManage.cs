using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Page
{
	public partial class UserManage : UserControl
	{
		public UserManage()
		{
			if (this.IsInDesignMode())
				return;
			InitializeComponent();

			for (int i = 0; i < 10; i++)
			{
				dataGridView1.Rows.Add(new object[]
					{
						$"A00{i}",
						"",
						"Item name",
						"Item description here",
						"Electronics",
						DateTime.Now.ToLongDateString()
					});
			}
		}
	}
}
