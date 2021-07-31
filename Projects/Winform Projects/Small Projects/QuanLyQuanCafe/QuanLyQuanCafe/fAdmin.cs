using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class fAdmin : Form
	{
		BindingSource bindingFood = new BindingSource();
		BindingSource accountList = new BindingSource();
		public Account loginAccount;

		public fAdmin()
		{
			InitializeComponent();
			Load();
		}
		#region Methods
		void Load()
		{
			dgvFood.DataSource = bindingFood;
			dgvAccount.DataSource = accountList;
			LoadDTPTunover();
			LoadBillListByDate(dtpFromDate.Value, dtpToDate.Value);
			// LoadAccountList();
			LoadListFood();
			LoadAccount();
			LoadFoodBinding();
			GetCategory(cbCategoryFood);
			LoadAccountBinding();
		}

		void LoadAccountList()
		{
			string query = "EXEC dbo.USE_GetAccountByUsername @userName";
			dgvAccount.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] { "Trời trên" });
		}

		void LoadBillListByDate(DateTime dateCheckIn, DateTime dateCheckOut)
		{
			dgvTunover.DataSource = BillDAO.Instance.GetBillListByDate(dateCheckIn, dateCheckOut);
		}

		void LoadDTPTunover()
		{
			DateTime today = DateTime.Now;
			dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
			dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
		}

		void LoadListFood()
		{
			bindingFood.DataSource = FoodDAO.Instance.GetListFood();
		}

		void LoadFoodBinding()
		{
			tbFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
			tbIDFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
			nudPriceFood.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
		}

		void LoadAccountBinding()
		{
			tbAccountName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
			tbAccountNameDisplay.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Displayname", true, DataSourceUpdateMode.Never));
			nudAccountType.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
		}

		void LoadAccount()
		{
			accountList.DataSource = AccountDAO.Instance.GetListAccount();
		}

		void AddAccount(string name, string displayname, int type)
		{
			if (AccountDAO.Instance.InsertAccount(name, displayname, type))
			{
				MessageBox.Show("Thêm tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Thêm tài khoản không thành công");
			}
			LoadAccount();
		}
		void EditAccount(string name, string displayname, int type)
		{
			if (AccountDAO.Instance.UpdateAccount(name, displayname, type))
			{
				MessageBox.Show("Sửa tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Sửa tài khoản không thành công");
			}
			LoadAccount();
		}

		void DeleteAccount(string name)
		{
			if (loginAccount.Username.Equals(name))
			{
				MessageBox.Show("Không thể xóa tài khoản đang hiện hành");
				return;
			}	

			if (AccountDAO.Instance.DeleteAccount(name))
			{
				MessageBox.Show("Xóa tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Xóa tài khoản không thành công");
			}
			LoadAccount();
		}

		void ResetPassword(string username)
		{
			if (AccountDAO.Instance.ResetPassword(username))
			{
				MessageBox.Show("Cập nhập mật khẩu tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Cập nhập mật khẩu tài khoản không thành công");
			}
		}

		void GetCategory(ComboBox comboBox)
		{
			comboBox.DataSource = CategoryDAO.Instance.GetListCategory();
			comboBox.DisplayMember = "Name";
		}

		List<Food> GetListFoodByName(string name)
		{
			List<Food> foods = FoodDAO.Instance.GetListFoodByName(name);
			return foods;
		}

		#endregion

		#region Events
		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadBillListByDate(dtpFromDate.Value, dtpToDate.Value);
		}

		private void btnViewFood_Click(object sender, EventArgs e)
		{
			LoadListFood();
		}

		private void tbIDFood_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;

				Category category = CategoryDAO.Instance.GetCategoryByID(id);

				int index = 0;
				foreach (Category item in cbCategoryFood.Items)
				{
					if (item.Id == category.Id)
					{
						break;
					}
					index++;
				}
				cbCategoryFood.SelectedIndex = index;
			}
			catch { }
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			string name = tbFoodName.Text;
			int categoryId = (cbCategoryFood.SelectedItem as Category).Id;
			float price = (float)nudPriceFood.Value;
			if (FoodDAO.Instance.InsertFood(name, categoryId, price))
			{
				MessageBox.Show("Thêm món thành công!");
				LoadListFood();
				if (insertFood != null)
					insertFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm thức ăn");
			}
		}

		private void btnEditFood_Click(object sender, EventArgs e)
		{
			int id = int.Parse(tbIDFood.Text);
			string name = tbFoodName.Text;
			int categoryId = (cbCategoryFood.SelectedItem as Category).Id;
			float price = (float)nudPriceFood.Value;
			if (FoodDAO.Instance.UpdateFood(id, name, categoryId, price))
			{
				MessageBox.Show("Sửa món thành công!");
				LoadListFood();
				if (updateFood != null)
					updateFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa thức ăn");
			}
		}

		private void btnDeleteFood_Click(object sender, EventArgs e)
		{
			int id = int.Parse(tbIDFood.Text);
			if (FoodDAO.Instance.DeleteFood(id))
			{
				MessageBox.Show("Xóa món thành công!");
				LoadListFood();
				if (deleteFood != null)
					deleteFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa thức ăn");
			}
		}

		private void btnSearchFood_Click(object sender, EventArgs e)
		{
			dgvFood.DataSource = GetListFoodByName(tbSearchFood.Text);
		}

		private void btnViewAccount_Click(object sender, EventArgs e)
		{
			LoadAccount();
		}

		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			string username = tbAccountName.Text;
			string displayname = tbAccountNameDisplay.Text;
			int type = (int)nudAccountType.Value;

			AddAccount(username, displayname, type);
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			string username = tbAccountName.Text;
			DeleteAccount(username);
		}

		private void btnEditAccount_Click(object sender, EventArgs e)
		{
			string username = tbAccountName.Text;
			string displayname = tbAccountNameDisplay.Text;
			int type = (int)nudAccountType.Value;

			EditAccount(username, displayname, type);
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			string username = tbAccountName.Text;
			ResetPassword(username);
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			tbPage.Text = "1";
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			int sumRecord = BillDAO.Instance.GetNumberBillListByDate(dtpFromDate.Value, dtpToDate.Value);
			int lastPage = sumRecord / 10;

			if (sumRecord % 10 != 0)
				lastPage++;
			tbPage.Text = lastPage.ToString();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			int page = int.Parse(tbPage.Text);
			if (page > 1)
				page--;
			tbPage.Text = page.ToString();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			int page = int.Parse(tbPage.Text);
			int sumRecord = BillDAO.Instance.GetNumberBillListByDate(dtpFromDate.Value, dtpToDate.Value);
			
			if (page < sumRecord)
				page++;
			tbPage.Text = page.ToString();
		}

		private void tbPage_TextChanged(object sender, EventArgs e)
		{
			dgvTunover.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(tbPage.Text));
		}
		#endregion

		private event EventHandler insertFood;
		public event EventHandler InsertFood
		{
			add
			{
				insertFood += value;
			}
			remove
			{
				insertFood -= value;
			}
		}

		private event EventHandler deleteFood;
		public event EventHandler DeleteFood
		{
			add
			{
				deleteFood += value;
			}
			remove
			{
				deleteFood -= value;
			}
		}

		private event EventHandler updateFood;
		public event EventHandler UpdateFood
		{
			add
			{
				updateFood += value;
			}
			remove
			{
				updateFood -= value;
			}
		}
	}
}
