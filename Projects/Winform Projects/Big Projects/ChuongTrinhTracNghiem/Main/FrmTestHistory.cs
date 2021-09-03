using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmTestHistory : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }

		public FrmTestHistory(UserAccount account)
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			Account = account;
		}

		public FrmTestHistory()
		{

		}

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(233, 30, 59), 90F))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		#region Methods

		private void LoadData()
		{
			try
			{
				TestHistoryBLL.Instance.GetTestHistory(aDgvdata, Account.UserID);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion

		#region Events

		private void FrmTestHistory_Load(object sender, EventArgs e)
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

		#endregion
	}
}
