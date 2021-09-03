using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmLogin());
		}

		public static bool IsInDesignMode(this ContainerControl container)
		{
			if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
			{
				container.Controls.Add(new Label()
				{
					Text = container.GetType().Name,
					AutoSize = false,
					TextAlign = ContentAlignment.MiddleCenter,
					Dock = DockStyle.Fill
				});
				return true;
			}
			return false;
		}
	}
}
