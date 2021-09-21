using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class TestHistory : UserControl
	{
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public Action HomeFunc;
		public TestHistory()
		{
			InitializeComponent();
			RoundedControls();
			HomeFunc = () =>
			{
				Session.bP.SetPage((int)Session.TabPage.MainMenu);
			};
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

		//Bo tròn góc các Control
		#region Rounded Controls

		private void RoundedControls()
		{
			//Panels
			pnlDataGridView.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlDataGridView.Width, pnlDataGridView.Height, 10, 10));
			//Panels Shadow
			pnlDataGridViewShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlDataGridViewShadow.Width, pnlDataGridViewShadow.Height, 10, 10));
			//DataGridView
			aDgvdata.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, aDgvdata.Width, aDgvdata.Height, 15, 15));
			//Button
			btnClearFilter.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnClearFilter.Width, btnClearFilter.Height, 6, 6));
		}

		#endregion

		#region Methods

		private void LoadData()
		{
			try
			{
				if (Account != null)
					TestHistoryBLL.Instance.GetTestHistory(aDgvdata, Account.UserID);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion

		#region Events

		public void FrmTestHistory_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void aDgvdata_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			aDgvdata["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
		}

		private void aDgvdata_SortStringChanged(object sender, EventArgs e)
		{
			BindingSource source = new BindingSource() { DataSource = aDgvdata.DataSource, Sort = aDgvdata.SortString };
			aDgvdata.DataSource = source.DataSource;
		}

		private void aDgvdata_FilterStringChanged(object sender, EventArgs e)
		{
			BindingSource source = new BindingSource() { DataSource = aDgvdata.DataSource, Filter = aDgvdata.FilterString };
			aDgvdata.DataSource = source.DataSource;
		}

		private void btnClearFilter_Click(object sender, EventArgs e)
		{
			aDgvdata.ClearFilter();
			aDgvdata_FilterStringChanged(sender, e);
		}

		private void aDgvdata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 7;
			}
			catch { }
		}

		private void aDgvdata_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 11;
			}
			catch { }
		}

		private void bScrollBar_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
		{
			try
			{
				if (e.Value > 10)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - e.Value - 10].Index;
				else if (e.Value == 0)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1)].Index;
				else
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - 11].Index;
			}
			catch { }
		}

		#endregion
	}
}
