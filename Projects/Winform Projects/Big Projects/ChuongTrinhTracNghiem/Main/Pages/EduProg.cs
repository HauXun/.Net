using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class EduProg : UserControl
	{
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public Action CancleAction;

		public EduProg()
		{
			InitializeComponent();
			RoundedControls();
			((DataGridViewImageColumn)this.aDgvdata.Columns["Success"]).DefaultCellStyle.NullValue = imageList.Images[3];
			CancleAction = () =>
			{
				Session.Cancle = true;
			};
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

		//Bo tròn góc các Control
		#region Rounded Controls

		private void RoundedControls()
		{
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
					aDgvdata.AutoGenerateColumns = false;
					//BindingList<Script>  source = new BindingList<Script>();
					//List<Script> scripts = Enumerable.Cast<Script>(EduProgBLL.Instance.GetEduProgUser(Account.UserID)).ToList();
					IEnumerable<Script> a = EduProgBLL.Instance.GetEduProgUser(Account.UserID);
					foreach (var item in a)
					{
						if (!string.IsNullOrEmpty(item.TempSuccess.ToString()))
							item.Success = (bool)item.TempSuccess == true ? imageList.Images[1] : imageList.Images[0];
						else
							item.Success = imageList.Images[3];
						//source.Add(x);
						aDgvdata.Rows.Add(new object[]
							{
								item.SemesterID,
								item.SubjectID,
								item.SubjectName,
								item.RoleName,
								item.CourseID,
								item.FacultyID,
								item.FacultyName,
								item.TotalMark,
								item.Success
							});
					};

					//source.DataSource = scripts;
					//aDgvdata.DataSource = a;
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
			LoadData();
		}

		private void btnClearFilter_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
			try
			{
				if (!string.IsNullOrEmpty(tbSearch.Text))
					EduProgBLL.Instance.SearchEduProg(aDgvdata, "", imageList);
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
			(sender as FontAwesome.Sharp.IconButton).GotFocus += EduProg_GotFocus;
		}

		private void tbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSearch.Clear();
		}

		private void aDgvdata_Enter(object sender, EventArgs e)
		{
			(sender as DataGridView).GotFocus += EduProg_GotFocus;
		}

		private void EduProg_GotFocus(object sender, EventArgs e)
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
				EduProgBLL.Instance.SearchEduProg(aDgvdata, keyword, imageList);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage("Tìm kiếm thất bại! " + ex.Message, "Amazing Quiz Application",
			   MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void EduProg_Click(object sender, EventArgs e)
		{
			Session.ShowHideMenu?.Invoke();
		}

		#endregion
	}
}
