﻿using BusinessLogicLayer;
using Main.Partial;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class LeaderBoard : UserControl
	{
		public Action HomeFunc;

		public LeaderBoard()
		{
			InitializeComponent();
            RoundedControls();
			HomeFunc = () =>
			{
				Session.bP.SetPage((int)Session.TabPage.MainMenu);
			};
        }

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				btnSearch_Click(this, new EventArgs());
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
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
				TestHistoryBLL.Instance.GetLeaderBoard(aDgvdata);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		#endregion

		#region Events

		public void FrmLeaderBoard_Load(object sender, EventArgs e)
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
			try
			{
				if (!string.IsNullOrEmpty(tbSearch.Text))
					TestHistoryBLL.Instance.SearchHistory(aDgvdata, "");
				aDgvdata.ClearFilter();
				aDgvdata_FilterStringChanged(sender, e);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string keyword = tbSearch.Text;
				if (keyword.Equals("Nhập từ khóa ..."))
					keyword = string.Empty;
				TestHistoryBLL.Instance.SearchHistory(aDgvdata, keyword);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void aDgvdata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 12;
			}
			catch { }
		}

		private void aDgvdata_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				bScrollBar.Maximum = aDgvdata.RowCount - 12;
			}
			catch { }
		}

		private void bScrollBar_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
		{
			try
			{
				if (e.Value > 11)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - e.Value - 11].Index;
				else if (e.Value == 0)
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1)].Index;
				else
					aDgvdata.FirstDisplayedScrollingRowIndex = aDgvdata.Rows[(aDgvdata.RowCount - 1) - 12].Index;
			}
			catch { }
		}

		private void btnClearFilter_Enter(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		#endregion
	}
}
