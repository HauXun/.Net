using System;
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
			Start();
		}

		//static void Main(string[] args)
		//{
		//	var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
		//	var filename = Path.Combine(path, "Main.exe");
		//	var assembly = Assembly.LoadFile(filename);
		//	var programType = assembly.GetTypes().FirstOrDefault(c => c.Name == "Program"); // <-- if you don't know the full namespace and when it is unique.
		//	var method = programType.GetMethod("Start", BindingFlags.Public | BindingFlags.Static);
		//	method.Invoke(null, new object[] { });
		//}

		public static void Start()
		{
			Application.Run(new LoginForm());
		}
	}
}
