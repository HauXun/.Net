using Bunifu.UI.WinForms;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Main.Partial
{
	public static class Session
	{
		public static Action Submit;
		public static Action CancleAction;
		public static Action ShowHideMenu;
		public static Action<bool> AntiPopup;
		public static bool Cancle = true;

		public static DataTable Data;
		public static Exam Exam;
		public static BunifuPages bP;

		public enum TabPage
		{
			MainMenu = 0,
			ManageUser,
			ManageFaculty,
			ManageCourse,
			ManageClass,
			ManageSubject,
			ManageQuestion,
			ManageExam,
			BackupRestore,
			QuizTest,
			QuizResult,
			TestHistory,
			LeaderBoard,
			Profile,
			Statistical,
			EduProg,
			Guide,
			About
		}

		//Bo tròn góc các Control
		#region Rounded Form
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		public static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);
		#endregion

		//Chức năng di chuyển Form bằng thanh ControlBox
		#region Drag Form
		[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
		public extern static void ReleaseCapture();

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		#endregion

		public static List<T> ConvertDataTable<T>(DataTable dt)
		{
			List<T> data = new List<T>();
			foreach (DataRow row in dt.Rows)
			{
				T item = GetItem<T>(row);
				data.Add(item);
			}
			return data;
		}

		private static T GetItem<T>(DataRow dr)
		{
			Type temp = typeof(T);
			T obj = Activator.CreateInstance<T>();

			foreach (DataColumn column in dr.Table.Columns)
			{
				foreach (PropertyInfo pro in temp.GetProperties())
				{
					if (pro.Name == column.ColumnName)
						pro.SetValue(obj, dr[column.ColumnName], null);
					else
						continue;
				}
			}
			return obj;
		}

		public static DataTable ConvertToDataTable<T>(IList<T> data)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
			DataTable table = new DataTable();
			foreach (PropertyDescriptor prop in properties)
			{
				table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			}
			foreach (T item in data)
			{
				DataRow row = table.NewRow();
				foreach (PropertyDescriptor prop in properties)
				{
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				}
				table.Rows.Add(row);
			}
			return table;
		}
	}
}
