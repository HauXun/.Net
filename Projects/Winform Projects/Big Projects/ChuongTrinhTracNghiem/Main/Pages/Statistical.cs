using BusinessLogicLayer;
using Main.Partial;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class Statistical : UserControl
	{
		public Action CancleAction;

		public Statistical()
		{
			InitializeComponent();
			RoundedControls();
			CancleAction = () =>
			{
				Session.Cancle = true;
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
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 240F)) // 196, 232, 250 || //FromArgb(230, 110, 130)
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				tbSearch_IconRightClick(this, new EventArgs());
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		//Bo tròn góc các Control
		#region Rounded Controls

		private void RoundedControls()
		{
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
				EduProgBLL.Instance.GetAllEduProg(aDgvdata);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		#endregion

		#region Events

		public void FrmStatistical_Load(object sender, EventArgs e)
		{
			LoadData();
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
			Session.ShowHideMenu?.Invoke();
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

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += Statistical_GotFocus;
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as ADGV.AdvancedDataGridView).GotFocus += Statistical_GotFocus;
		}

		private void Statistical_GotFocus(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private void tbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_MouseLeave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSearch.Text))
			{
				tbSearch.Text = "Nhập từ khóa ...";
			}
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_IconRightClick(object sender, EventArgs e)
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

		private void Statistical_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
