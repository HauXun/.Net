using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace QuanLyQuanCafe
{
	public partial class fTableManeger : Form
	{
		private Account account;

		public Account Account
		{ 
			get => account; 
			set
			{
				account = value;
				ChangeAccount(account.Type);
			}
		}

		public fTableManeger(Account account)
		{
			InitializeComponent();
			this.Account = account;
			LoadTable();
			LoadCategory();
			LoadComboBoxTable(cbSwitchTable);
		}

		#region Methods
		void ChangeAccount(int type)
		{
			adminToolStripMenuItem.Enabled = type == 1;
			thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + Account.Displayname + ")";
		}

		void LoadTable()
		{
			flpTable.Controls.Clear();
			List<Table> tables = TableDAO.Instance.LoadTableList();
			foreach (var item in tables)
			{
				Button button = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
				button.Text = item.Name + Environment.NewLine + item.Status;
				button.Tag = item;
				button.Click += Button_Click;
				switch (item.Status)
				{
					case "Trống":
						button.BackColor = Color.WhiteSmoke;
						break;
					default:
						button.BackColor = Color.Aqua;
						break;
				}
				flpTable.Controls.Add(button);
			}
		}

		void ShowBill(int id)
		{
			lvBill.Items.Clear();
			float totalPrice = 0;

			//List<BillInfo> billInfos = BillInfoDAO.Instance.GetListBillInfo(
			//	BillDAO.Instance.GetUncheckBillIdByTableId(id));
			//foreach (BillInfo item in billInfos)
			//{
			//	ListViewItem viewItem = new ListViewItem() { Text = item.FoodId.ToString() };
			//	viewItem.SubItems.Add(new ListViewSubItem() { Text = item.Count.ToString() });
			//	lvBill.Items.Add(viewItem);
			//}

			List<DTO.Menu> menus = MenuDAO.Instance.GetListMenuByTable(id);
			foreach (DTO.Menu item in menus)
			{
				ListViewItem viewItem = new ListViewItem() { Text = item.FoodName.ToString() };
				viewItem.SubItems.Add(new ListViewSubItem() { Text = item.Count.ToString() });
				viewItem.SubItems.Add(new ListViewSubItem() { Text = item.Price.ToString() });
				viewItem.SubItems.Add(new ListViewSubItem() { Text = item.TotalPrice.ToString() });
				lvBill.Items.Add(viewItem);
				totalPrice += item.TotalPrice;
			}
			CultureInfo culture = new CultureInfo("vi-VN");
			//Thread.CurrentThread.CurrentCulture = culture;
			tbTotalPrice.Text = totalPrice.ToString("c", culture);
		}

		void LoadCategory()
		{
			List<Category> categories = CategoryDAO.Instance.GetListCategory();
			cbCategory.DataSource = categories;
			cbCategory.DisplayMember = "Name";
		}

		void LoadComboBoxTable(ComboBox comboBox)
		{
			comboBox.DataSource = TableDAO.Instance.LoadTableList();
			comboBox.DisplayMember = "Name";
		}

		void LoadFoodListByCategory(int id)
		{
			List<Food> foods = FoodDAO.Instance.GetListFoodByCategoryID(id);
			cbFood.DataSource = foods;
			cbFood.DisplayMember = "Name";
		}
		#endregion

		#region Events
		private void Button_Click(object sender, EventArgs e)
		{
			int idTable = ((sender as Button).Tag as Table).Id;
			lvBill.Tag = (sender as Button).Tag;
			ShowBill(idTable);
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAccountProfile fAccount = new fAccountProfile(Account);
			fAccount.UpdateAccountEvent += FAccount_UpdateAccountEvent;
			fAccount.ShowDialog();
		}

		private void FAccount_UpdateAccountEvent(object sender, AccountEvent e)
		{
			thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + e.Account.Displayname + ")";
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAdmin admin = new fAdmin();
			admin.loginAccount = Account;
			admin.InsertFood += Admin_InsertFood;
			admin.DeleteFood += Admin_DeleteFood;
			admin.UpdateFood += Admin_UpdateFood;
			admin.ShowDialog();
		}

		private void Admin_UpdateFood(object sender, EventArgs e)
		{
			LoadFoodListByCategory((cbCategory.SelectedItem as Category).Id);
			if (lvBill.Tag != null)
				ShowBill((lvBill.Tag as Table).Id);
		}

		private void Admin_DeleteFood(object sender, EventArgs e)
		{
			LoadFoodListByCategory((cbCategory.SelectedItem as Category).Id);
			if (lvBill.Tag != null)
				ShowBill((lvBill.Tag as Table).Id);
			LoadTable();
		}

		private void Admin_InsertFood(object sender, EventArgs e)
		{
			LoadFoodListByCategory((cbCategory.SelectedItem as Category).Id);
			if (lvBill.Tag != null)
				ShowBill((lvBill.Tag as Table).Id);
		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox.SelectedItem == null)
				return;
			Category category = comboBox.SelectedItem as Category;
			LoadFoodListByCategory(category.Id);
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			Table table = lvBill.Tag as Table;
			if (table == null)
			{
				MessageBox.Show("Hãy chọn bàn");
				return;
			}
			int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);
			int foodID = (cbFood.SelectedItem as Food).Id;
			int count = (int)nudFoodCount.Value;

			if (idBill == -1)
			{
				BillDAO.Instance.InsertBill(table.Id);
				BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxBillId(), foodID, count);
			}
			else
			{
				BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
			}
			ShowBill(table.Id);
			LoadTable();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			Table table = lvBill.Tag as Table;
			int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);
			int discount = (int)nudDiscount.Value;
			decimal totalPrice = Convert.ToDecimal(tbTotalPrice.Text.Split(',')[0]);
			decimal finaltotalPrice = totalPrice - (totalPrice / 100) * discount;
			if (idBill != -1)
			{
				if (MessageBox.Show($"Thanh toán hóa đơn cho bàn {table.Name}\n" +
					$"Tổng tiền - (Tổng tiền / 100) x Giảm giá = " +
					$"{totalPrice} - ({totalPrice} / 100) x {discount}% = {finaltotalPrice}",
					"Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
				{
					BillDAO.Instance.CheckOut(idBill, discount, finaltotalPrice);
					ShowBill(table.Id);
					LoadTable();
				}
			}
		}

		private void btnSwitchTable_Click(object sender, EventArgs e)
		{
			int idTable1 = (lvBill.Tag as Table).Id;
			int idTable2 = (cbSwitchTable.SelectedItem as Table).Id;
			if (MessageBox.Show($"Bạn có thực sự muốn chuyển bàn {(lvBill.Tag as Table).Name} qua bàn {(cbSwitchTable.SelectedItem as Table).Name}",
				"Chuyển bàn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				TableDAO.Instance.SwitchTable(idTable1, idTable2);
				LoadTable();
			}
		}
		#endregion
	}
}
