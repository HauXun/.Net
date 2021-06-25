using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
	public partial class MainForm : Form
	{
		MonAn monAn = null;
		private bool flags = false;
		private User loginUser;
		public MainForm(User user)
		{
			InitializeComponent();

			if (user == null)
			{
				loginUser = new User();
			}
			else
			{
				loginUser = user;
			}

			Load();
		}

		/// <summary>
		/// Load thông tin và binding
		/// </summary>
		void Load()
		{
			Binding dataBinding = new Binding("Text", loginUser, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
			tbUser.DataBindings.Add(dataBinding);

			PhanQuyen(loginUser.IsNhanVien);
			LoadThucDon();
		}

		/// <summary>
		/// Load thực đơn
		/// </summary>
		void LoadThucDon()
		{
			// Add Column
			lvMonAn.Columns.Add("Tên món ăn", 150);
			lvMonAn.Columns.Add(new ColumnHeader() { Text = "Đơn giá" });
			lvMonAn.Columns.Add(new ColumnHeader() { Text = "Số lượng" });

			foreach (MonAn item in ThucDon.Instance.Menu)
			{
				ListViewItem listView = new ListViewItem(item.Ten);
				listView.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Gia.ToString() });
				listView.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.SoLuong.ToString() });

				lvMonAn.Items.Add(listView);
			}

			// Add Column danh sách món đã chọn
			lvDaChon.Columns.Add(new ColumnHeader() { Text = "Tên món ăn" });
			lvDaChon.Columns.Add(new ColumnHeader() { Text = "Đơn giá" });
			lvDaChon.Columns.Add(new ColumnHeader() { Text = "Số lượng" });
			lvDaChon.Columns.Add(new ColumnHeader() { Text = "Thành tiền" });
		}

		/// <summary>
		/// Cho biết form có đang Show hay không
		/// </summary>
		public bool isShowing = true;

		/// <summary>
		/// Event thông báo đăng xuất
		/// </summary>
		public event EventHandler DangXuat;

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			if (lvDaChon.Items.Count > 0)
			{
				MessageBox.Show("Bạn chưa tính tiền, không thể đóng!");
				return;
			}
			else
				DangXuat(this, new EventArgs());
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			CloseForm();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			CloseForm();
		}

		/// <summary>
		/// Đóng form hiện tại
		/// </summary>
		void CloseForm()
		{
			if (lvDaChon.Items.Count > 0)
			{
				MessageBox.Show("Bạn chưa tính tiền, không thể đóng!");
				return;
			}
			else
			if (isShowing)
			{
				isShowing = false;
				Application.Exit();
			}
		}

		/// <summary>
		/// Set enable của các control theo giá trị truyền vào
		/// </summary>
		/// <param name="isEnable"></param>
		void PhanQuyen(bool isEnable)
		{
			btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = isEnable;
		}

		private void lvMonAn_DoubleClick(object sender, EventArgs e)
		{
			DoubleClickItem(sender as ListView, lvDaChon, 1);

			int tong = 0;
			foreach (ListViewItem item in lvDaChon.Items)
			{
				tong += int.Parse(item.SubItems[(int)ColumnIndex.ThanhTien].Text);
			}
			tbTongTien.Text = tong.ToString() + " VNĐ";
		}

		private void lvDaChon_DoubleClick(object sender, EventArgs e)
		{
			DoubleClickItem(sender as ListView, lvMonAn, 1);

			int tong = 0;
			foreach (ListViewItem item in lvDaChon.Items)
			{
				tong += int.Parse(item.SubItems[(int)ColumnIndex.ThanhTien].Text);
			}
			tbTongTien.Text = tong.ToString() + " VNĐ";
		}

		/// <summary>
		/// Chuyển qua lại các item được chọn giữa 2 listView
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="amount"></param>
		void DoubleClickItem(ListView from, ListView to, int amount)
		{
			if (loginUser.IsNhanVien)
				return;

			// Lấy ra item được chọn
			ListViewItem selected = from.SelectedItems[0];

			// Nếu không lựa chọn gì thì out
			if (selected == null)
				return;

			ListViewItem newItem = selected.Clone() as ListViewItem;

			bool isContain = false;
			int index = 0;
			foreach (ListViewItem item in to.Items)
			{
				if (item.Text == newItem.Text)
				{
					isContain = true;
					index = to.Items.IndexOf(item);
					newItem = item;
					break;
				}
			}

			if (!isContain)
			{
				int currentAmount = int.Parse(selected.SubItems[(int)ColumnIndex.SoLuong].Text);

				if (currentAmount - amount >= 0)
				{
					currentAmount -= amount;
					newItem.SubItems[(int)ColumnIndex.SoLuong].Text = amount.ToString();
				}
				else
				{
					newItem.SubItems[(int)ColumnIndex.SoLuong].Text = currentAmount.ToString();
					currentAmount = 0;
				}
				selected.SubItems[(int)ColumnIndex.SoLuong].Text = currentAmount.ToString();
				ThucDon.Instance.Menu[lvMonAn.SelectedIndices[0]].SoLuong = currentAmount;

				if (to.Name == lvDaChon.Name)
				{
					newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "0" });
				}

				to.Items.Add(newItem);
			}
			else
			{
				int currentAmount = int.Parse(selected.SubItems[(int)ColumnIndex.SoLuong].Text);

				if (currentAmount - amount >= 0)
				{
					currentAmount -= amount;
					int soluong = int.Parse(newItem.SubItems[(int)ColumnIndex.SoLuong].Text);
					newItem.SubItems[(int)ColumnIndex.SoLuong].Text = (soluong + amount).ToString();
				}
				else
				{
					int soluong = int.Parse(newItem.SubItems[(int)ColumnIndex.SoLuong].Text);
					newItem.SubItems[(int)ColumnIndex.SoLuong].Text = (soluong + currentAmount).ToString();
					currentAmount = 0;
				}
				selected.SubItems[(int)ColumnIndex.SoLuong].Text = currentAmount.ToString();
				ThucDon.Instance.Menu[lvMonAn.SelectedIndices[0]].SoLuong = currentAmount;
			}
			foreach (ListViewItem item in lvDaChon.Items)
			{
				item.SubItems[(int)ColumnIndex.ThanhTien].Text =
					(int.Parse(item.SubItems[(int)ColumnIndex.SoLuong].Text) * int.Parse(item.SubItems[(int)ColumnIndex.Gia].Text)).ToString();
			}
		}

		enum ColumnIndex
		{
			TenMonAn = 0,
			Gia = 1,
			SoLuong = 2,
			ThanhTien = 3
		}

		private void btnGoiMon_Click(object sender, EventArgs e)
		{
			if (lvDaChon.Items.Count == 0)
			{
				MessageBox.Show("Xin hãy chọn món ăn!");
			}
			else
			{
				flags = true;
			}
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			if (flags)
			{
				MessageBox.Show("Tổng hóa đơn của bạn là: " + tbTongTien.Text);
			}
			else
			{
			}
			lvDaChon.Items.Clear();
			btnExit_Click(this, new EventArgs());
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (lvDaChon.Items.Count > 0)
			{
				MessageBox.Show("Bạn chưa tính tiền, không thể đóng!");
				e.Cancel = true;
			}
			else
				base.OnClosing(e);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			ThemMonAn form = new ThemMonAn();
			form.FormClosed += ThemMonAn_FormClosed;
			form.FormClosing += Form_FormClosing;
			form.ShowDialog();
		}

		private void Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			monAn = (sender as ThemMonAn).MonAn;
		}

		private void ThemMonAn_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (monAn != null)
			{
				ThucDon.Instance.Menu.Add(monAn);
				ListViewItem newItem = new ListViewItem(monAn.Ten);
				newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = monAn.Gia.ToString() });
				newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = monAn.SoLuong.ToString() });
				lvMonAn.Items.Add(newItem);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvMonAn.SelectedItems[0];
			if (selectedItem == null)
				return;

			ThucDon.Instance.Menu.RemoveAt(lvMonAn.SelectedIndices[0]);
			lvMonAn.Items.Remove(selectedItem);
		}

		MonAn newMonAn;
		int indexMonAn;
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (lvMonAn.SelectedItems.Count == 0)
				return;

			ListViewItem selectedItem = lvMonAn.SelectedItems[0];

			if (selectedItem == null)
				return;

			newMonAn = new MonAn(selectedItem.Text,
				int.Parse(selectedItem.SubItems[(int)ColumnIndex.Gia].Text),
				int.Parse(selectedItem.SubItems[(int)ColumnIndex.SoLuong].Text));
			indexMonAn = lvMonAn.SelectedIndices[0];

			SuaMonAn formEdit = new SuaMonAn(newMonAn);
			formEdit.FormClosed += FormEdit_FormClosed;
			formEdit.ShowDialog();
		}

		private void FormEdit_FormClosed(object sender, FormClosedEventArgs e)
		{
			newMonAn = (sender as SuaMonAn).MonAn;
			if (newMonAn != null)
			{
				ThucDon.Instance.Menu[indexMonAn].Ten = newMonAn.Ten;
				ThucDon.Instance.Menu[indexMonAn].Gia = newMonAn.Gia;
				ThucDon.Instance.Menu[indexMonAn].SoLuong = newMonAn.SoLuong;

				ListViewItem mon = lvMonAn.Items[indexMonAn];
				mon.Text = newMonAn.Ten;
				mon.SubItems[(int)ColumnIndex.Gia].Text = newMonAn.Gia.ToString();
				mon.SubItems[(int)ColumnIndex.SoLuong].Text = newMonAn.SoLuong.ToString();
			}
		}
	}
}
