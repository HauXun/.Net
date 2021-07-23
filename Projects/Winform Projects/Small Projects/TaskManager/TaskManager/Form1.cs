using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			GetProcess();
		}

		/// <summary>
		/// Danh sách process
		/// </summary>
		Process[] process;

		/// <summary>
		/// Lấy ra danh sách các process
		/// Đồng thời đưa vào list view
		/// </summary>
		void GetProcess()
		{
			process = Process.GetProcesses();
			foreach (var item in process)
			{
				ListViewItem newItem = new ListViewItem() { Text = item.ProcessName };
				newItem.SubItems.Add(new ListViewItem.ListViewSubItem()
				{ Text = item.NonpagedSystemMemorySize64.ToString() });
				listView1.Items.Add(newItem);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (process.Length != Process.GetProcesses().Length)
			{
				GetProcess();
			}
		}

		private void endTaskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				int index = 0;
				foreach (var item in process)
				{
					if (item.ProcessName == listView1.SelectedItems[0].Text)
					{
						index = process.ToList().IndexOf(item);
						break;
					}	
				}
				process[index].Kill();
			}	
		}

		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
			listView1.Sort();
		}
	}
}
