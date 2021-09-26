﻿using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Main.Pages
{
	public partial class EduProg : UserControl
	{
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public Action HomeFunc;

		public EduProg()
		{
			InitializeComponent();
			RoundedControls();
			HomeFunc = () =>
			{
				Session.bP.SetPage((int)Session.TabPage.MainMenu);
			};
			((DataGridViewImageColumn)this.aDgvdata.Columns["Status"]).DefaultCellStyle.NullValue = imageList.Images[3];
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
				if (Account != null)
				{
					if (aDgvdata.Rows.Count > 0)
						aDgvdata.Rows.Clear();
					var success = imageList.Images[3];
					aDgvdata.AutoGenerateColumns = false;
					DataColumn column = new DataColumn("Status");
					DataTable data = EduProgBLL.Instance.GetEduProgUser(Account.UserID);
					data.Columns.Add(column);
					aDgvdata.DataSource = data;
					int i = 0;
					foreach (DataRow item in data.Rows)
					{
						if (!string.IsNullOrEmpty(item["Success"].ToString()))
							data.Rows[i++]["Status"] = (bool)item["Success"] == true ? imageList.Images[1] : imageList.Images[0];
						else
							data.Rows[i++]["Status"] = imageList.Images[3];
					}
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		#endregion

		#region Events

		public void FrmEduProg_Load(object sender, EventArgs e)
		{
			try
			{
				if (Account != null)
				{
					if (aDgvdata.Rows.Count > 0)
						aDgvdata.Rows.Clear();
					var success = imageList.Images[3];
					aDgvdata.AutoGenerateColumns = false;
					DataColumn column = new DataColumn("Status");
					DataTable data = EduProgBLL.Instance.GetEduProgUser(Account.UserID);
					data.Columns.Add(column);
					aDgvdata.DataSource = data;
					int i = 0;
					foreach (DataRow item in data.Rows)
					{
						if (!string.IsNullOrEmpty(item["Success"].ToString()))
							data.Rows[i++]["Status"] = (bool)item["Success"] == true ? imageList.Images[1] : imageList.Images[0];
						else
							data.Rows[i++]["Status"] = imageList.Images[3];
					}
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
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
					EduProgBLL.Instance.SearchEduProg(aDgvdata, "");
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
				EduProgBLL.Instance.SearchEduProg(aDgvdata, keyword);
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
