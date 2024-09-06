using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownTimer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadStatusStrip();
		}

		decimal downTime;
		ToolStripLabel downTimePanel = new ToolStripLabel();
		ToolStripLabel barPanel = new ToolStripLabel();

		void LoadStatusStrip()
		{
			StatusStrip statusStrip = new StatusStrip();
			statusStrip.Items.Add(downTimePanel);
			statusStrip.Items.Add(barPanel);
			downTimePanel.Text = "";
			barPanel.Text = "Waiting...";
			this.Controls.Add(statusStrip);
		}

		private void nudGiay_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numeric = sender as NumericUpDown;
			if (numeric.Value >= 60)
			{
				nudPhut.Value++;
				numeric.Value = 0;
			}
		}

		private void nudPhut_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numeric = sender as NumericUpDown;
			if (numeric.Value >= 60)
			{
				nudGio.Value++;
				numeric.Value = 0;
			}
		}

		/// <summary>
		/// Shut down theo command
		/// </summary>
		/// <param name="command"></param>
		void ShutDown(string command)
		{
			System.Diagnostics.Process.Start("shutdown", command);
		}

		void CalculatorDownTime()
		{
			downTime = nudGiay.Value + nudPhut.Value * 60 + nudGio.Value * 60 * 60;
		}

		private void btnShutDown_Click(object sender, EventArgs e)
		{
			CalculatorDownTime();
			ShutDown("-s -t " + downTime.ToString());
			barPanel.Text = "Shutting down...";
			timer1.Start();
		}

		private void btnResetart_Click(object sender, EventArgs e)
		{
			CalculatorDownTime();
			ShutDown("-r -t " + downTime.ToString());
			barPanel.Text = "Restarting down...";
			timer1.Start();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Hủy lệnh là -a
			ShutDown("-a");
			barPanel.Text = "Waiting...";
			timer1.Stop();
			downTimePanel.Text = "";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			downTime--;
			downTimePanel.Text = downTime.ToString();
		}
	}
}