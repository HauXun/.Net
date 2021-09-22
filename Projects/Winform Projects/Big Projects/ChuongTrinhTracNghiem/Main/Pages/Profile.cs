using BusinessLogicLayer;
using Entities;
using Guna.UI2.WinForms;
using Main.Partial;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class Profile : UserControl
	{
		#region Fields

		private bool isSuccess = false;
		private UserAccount account;

		public UserAccount Account
		{
			get => account;
			set
			{
				account = value;
				ChangeRole(account);
			}
		}

		public Action HomeFunc;

		#endregion

		public Profile()
		{
			InitializeComponent();
			RoundedControl();
			HomeFunc = () =>
			{
				if ((btnLuuMatKhau.Visible || btnLuuThongTin.Visible) && MsgBox.ShowMessage("Dữ liệu chưa được lưu!. Tiếp tục thoát ?", "Amazing Quiz Application",
					MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
				{
					Session.bP.SetPage((int)Session.TabPage.MainMenu);
					if (!btnChinhSua.Enabled)
					{
						btnHuyLuu_Click(this, new EventArgs());
						DisableRemainFunc(true);
					}
					if (!btnDoiMatKhau.Enabled)
					{
						btnHuyMatKhau_Click(this, new EventArgs());
						DisableRemainFunc(false);
					}
				}
				else if (!btnLuuMatKhau.Visible && !btnLuuThongTin.Visible)
				{
					Session.bP.SetPage((int)Session.TabPage.MainMenu);
				}
			};
		}

		#region Methods

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void RoundedControl()
		{
			//Panel
			pnlThongTin.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlThongTin.Width, pnlThongTin.Height, 10, 10));
			//Panel Shadow
			pnlThongTinShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlThongTinShadow.Width, pnlThongTinShadow.Height, 10, 10));
			//Buttons
			btnChinhSua.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnChinhSua.Width, btnChinhSua.Height, 6, 6));
			btnLuuThongTin.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnLuuThongTin.Width, btnLuuThongTin.Height, 6, 6));
			btnHuyThongTin.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnHuyThongTin.Width, btnHuyThongTin.Height, 6, 6));
			btnLuuMatKhau.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnLuuMatKhau.Width, btnLuuMatKhau.Height, 6, 6));
			btnHuyMatKhau.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnHuyMatKhau.Width, btnHuyMatKhau.Height, 6, 6));
		}

		/// <summary>
		/// Cập nhập tài khoản
		/// </summary>
		private void UpdateInfo()
		{
			UserAccount account = new UserAccount()
			{
				Username = tbTaiKhoan.Text,
				FullName = tbFullName.Text,
				Address = tbDiaChi.Text,
				PhoneNumber = tbSoDienThoai.Text,
				Email = tbEmail.Text,
				Birthday = dtpNgaySinh.Value
			};
			string password = tbMatKhau.Text;

			if (!IsValidUpdateInfo())
				return;

			Update(password, account);
		}

		/// <summary>
		/// Cập nhập mật khẩu
		/// </summary>
		private void UpdatePassword()
		{
			UserAccount account = new UserAccount()
			{
				Username = tbTaiKhoan.Text
			};
			string password = tbMatKhau.Text;
			string newPassword = tbMatKhauMoi.Text;

			if (!IsValidUpdatePassword())
				return;

			Update(password, account, newPassword);
		}

		/// <summary>
		/// Cập nhập tài khoản
		/// </summary>
		/// <param name="username"></param>
		/// <param name="displayname"></param>
		/// <param name="diachi"></param>
		/// <param name="sdt"></param>
		/// <param name="email"></param>
		/// <param name="ngaysinh"></param>
		/// <param name="password"></param>
		/// <param name="newPassword"></param>
		private void Update(string password, UserAccount account = null, string newPassword = "")
		{
			try
			{
				if (AccountBLL.Instance.ChangeInfoAccount(password, account, newPassword))
				{
					MsgBox.ShowMessage("Cập nhập thành công!", "Amazing Quiz Application",
						MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationCircle);
					Account = AccountBLL.Instance.GetAccountByUserName(account.Username);
					isSuccess = !isSuccess;
					if (updateAccountInfo != null)
					{
						updateAccountInfo(this, new AccountChanged(Account));
					}
				}
				else
				{
					MsgBox.ShowMessage("Cập nhập không thành công! Vui lòng kiểm tra lại dữ liệu!", "Amazing Quiz Application",
						MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				}
			}
			catch (Exception e)
			{
				MsgBox.ShowMessage(e.Message, "Amazing Quiz Application",
					MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		/// <summary>
		/// Đưa dữ liệu từ dưới lên
		/// </summary>
		/// <param name="account"></param>
		private void ChangeRole(UserAccount account)
		{
			tbID.Text = account.UserID.ToString();
			tbTaiKhoan.Text = account.Username;
			tbFullName.Text = account.FullName;
			tbDiaChi.Text = account.Address;
			tbClass.Text = account.ClassID;
			tbSoDienThoai.Text = account.PhoneNumber;
			tbEmail.Text = account.Email;
			dtpNgaySinh.Value = account.Birthday;
		}

		/// <summary>
		/// Xóa hết những thông báo lỗi
		/// </summary>
		private void ClearError()
		{
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbFullName, "");
			errorProviderWar.SetError(tbDiaChi, "");
			errorProviderWar.SetError(tbSoDienThoai, "");
			errorProviderWar.SetError(tbEmail, "");
			errorProviderWar.SetError(tbMatKhau, "");
			errorProviderWar.SetError(tbMatKhauMoi, "");
			errorProviderWar.SetError(tbNhapLaiMatKhauMoi, "");
		}

		/// <summary>
		/// Xóa dữ liệu các control
		/// </summary>
		private void ClearControlData()
		{
			foreach (Control control in pnlThongTin.Controls)
			{
				if (control is Guna2TextBox)
				{
					(control as Guna2TextBox).Text = string.Empty;
				}
				if (control is Guna2DateTimePicker)
				{
					(control as Guna2DateTimePicker).Value = DateTime.Today;
				}
			}
		}

		/// <summary>
		/// Đóng mở các control (textbox)
		/// </summary>
		/// <param name="isEnable"></param>
		private void EnableControlInfo(bool isEnable)
		{
			foreach (Control control in pnlInfo.Controls)
			{
				if (control is Guna2TextBox || control is Guna2DateTimePicker)
					control.Enabled = isEnable;
			}
			btnLuuThongTin.Visible = btnHuyThongTin.Visible = isEnable;
			btnChinhSua.Enabled = !btnChinhSua.Enabled;
		}

		/// <summary>
		/// Đóng mở các control (textbox)
		/// </summary>
		/// <param name="isEnable"></param>
		private void EnableControlPassword(bool isEnable)
		{
			tbMatKhau.Enabled = pnlPassword.Visible = isEnable;
			tbMatKhau.Text = tbMatKhauMoi.Text = tbNhapLaiMatKhauMoi.Text = string.Empty;
			btnLuuMatKhau.Visible = btnHuyMatKhau.Visible = isEnable;
			btnDoiMatKhau.Enabled = !btnDoiMatKhau.Enabled;
		}

		/// <summary>
		/// 2 tính năng không được hoạt động cung 1 lúc
		/// </summary>
		/// <param name="isFunc1"></param>
		private void DisableRemainFunc(bool isFunc1)
		{
			if (isFunc1)
			{
				tbMatKhau.Text = string.Empty;
				tbMatKhau.Enabled = !tbMatKhau.Enabled;
				btnDoiMatKhau.Enabled = !btnDoiMatKhau.Enabled;
			}
			else
			{
				btnChinhSua.Enabled = !btnChinhSua.Enabled;
			}
		}

		/// <summary>
		/// Kiểm tra dữ liệu nhập
		/// </summary>
		/// <returns></returns>
		private bool IsValidUpdatePassword()
		{
			ClearError();

			// Kiểm tra xem thông tin hợp lệ chưa?
			// Kiểm tra mật khẩu không được để trống
			if (string.IsNullOrEmpty(tbMatKhau.Text))
			{
				errorProviderWar.SetError(tbMatKhau, "Mật khẩu không được để trống!");
				return false;
			}

			// Kiểm tra mật khẩu mới không được để trống
			if (string.IsNullOrEmpty(tbMatKhauMoi.Text))
			{
				errorProviderWar.SetError(tbMatKhauMoi, "Mật khẩu không được để trống!");
				return false;
			}
			else
			{
				// Kiểm tra mật khẩu nhập lại không được để trống
				if (string.IsNullOrEmpty(tbNhapLaiMatKhauMoi.Text))
				{
					errorProviderWar.SetError(tbNhapLaiMatKhauMoi, "Mật khẩu không được để trống!");
					return false;
				}
				// Kiểm tra mật khẩu nhập lại phải đúng với mật khẩu mới đã nhập ở trên
				else if (!tbNhapLaiMatKhauMoi.Text.Equals(tbMatKhauMoi.Text))
				{
					errorProviderWar.SetError(tbNhapLaiMatKhauMoi, "Mật khẩu nhập lại phải\ntrùng khớp với mật khẩu mới!");
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Kiểm tra dữ liệu nhập
		/// </summary>
		/// <returns></returns>
		private bool IsValidUpdateInfo()
		{
			ClearError();

			// Kiểm tra xem thông tin hợp lệ chưa?

			// Kiểm tra	tên hiển thị không được để trống
			if (string.IsNullOrEmpty(tbFullName.Text))
			{
				errorProviderWar.SetError(tbFullName, "Tên hiển thị không\nđược để trống!");
				return false;
			}
			else
			{
				string[] arr = tbFullName.Text.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
				foreach (var item in arr)
				{
					if (IsSpecialCharacters(item))
					{
						errorProviderWar.SetError(tbFullName, "Tên hiển thị không được\nchứa ký tự đặc biệt!");
						return false;
					}
				}

			}

			// Kiểm tra địa chỉ không được để trống
			if (string.IsNullOrEmpty(tbDiaChi.Text))
			{
				errorProviderWar.SetError(tbDiaChi, "Địa chỉ không\nđược để trống!");
				return false;
			}
			else
			{
				string[] arr = tbFullName.Text.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
				foreach (var item in arr)
				{
					if (IsSpecialCharacters(item))
					{
						errorProviderWar.SetError(tbDiaChi, "Địa chỉ không\nđược chứa ký tự đặc biệt!");
						return false;
					}
				}

			}

			// Kiểm tra email không được để trống
			if (string.IsNullOrEmpty(tbEmail.Text))
			{
				errorProviderWar.SetError(tbEmail, "Email không được để trống!");
				return false;
			}
			else
			{
				if (IsSpaceCharacters(tbEmail.Text))
				{
					errorProviderWar.SetError(tbEmail, "Email không được chứa khoảng trắng!");
					return false;
				}
				else
				{
					if (IsUnicode(tbEmail.Text))
					{
						errorProviderWar.SetError(tbEmail, "Email không được có dấu!");
						return false;
					}
					else if (IsSpecialCharacters(tbEmail.Text.Trim()))
					{
						if (!tbEmail.Text.Contains("@"))
						{
							errorProviderWar.SetError(tbEmail, "Email không được chứa ký tự đặc biệt!");
							return false;
						}
					}
				}
			}

			// Kiểm tra số điện thoại khoản không được để trống
			if (string.IsNullOrEmpty(tbSoDienThoai.Text))
			{
				errorProviderWar.SetError(tbSoDienThoai, "Số điện thoại không được để trống!");
				return false;
			}
			else
			{
				if (IsSpaceCharacters(tbSoDienThoai.Text))
				{
					errorProviderWar.SetError(tbSoDienThoai, "Số điện thoại không\nđược chứa khoảng trắng!");
					return false;
				}
				else
				{
					if (!IsDigit(tbSoDienThoai.Text))
					{
						errorProviderWar.SetError(tbSoDienThoai, "Số điện thoại không được\nchứa ký tự khác ngoài số!");
						return false;
					}
				}
			}

			// Kiểm tra mật khẩu không được để trống
			if (string.IsNullOrEmpty(tbMatKhau.Text))
			{
				errorProviderWar.SetError(tbMatKhau, "Mật khẩu không được để trống!");
				return false;
			}

			// Kiểm tra ngày sinh toàn vẹn giá trị
			if (dtpNgaySinh.Value.Year >= DateTime.Now.Year)
			{
				errorProviderWar.SetError(dtpNgaySinh, "Ngày tháng năm sinh có vấn đề!");
				return false;
			}

			return true;
		}

		/// <summary>
		/// Kiểm tra chuỗi Unicode
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsUnicode(string input)
		{
			var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
			var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
			return asciiBytesCount != unicodBytesCount;
		}

		/// <summary>
		/// Kiểm tra kí tự đặc biệt
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsSpecialCharacters(string input) => input.Any(p => !char.IsLetterOrDigit(p));

		/// <summary>
		/// Kiểm tra chuỗi chứa khoảng trắng
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsSpaceCharacters(string input) => input.Any(char.IsWhiteSpace);

		/// <summary>
		/// Kiểm tra chuỗi chứa số
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private bool IsDigit(string input) => input.All(char.IsDigit);

		#endregion

		//Sự kiện của các Button chỉnh sửa thông tin
		#region Edit Buttons

		private void btnChinhSua_Click(object sender, EventArgs e)
		{
			if (btnChinhSua.Enabled)
			{
				EnableControlInfo(true);
				EnableControlPassword(false);
				tbID.Enabled = tbClass.Enabled = btnDoiMatKhau.Enabled = false;
				tbMatKhau.Enabled = true;
			}
		}

		private void btnLuuThongTin_Click(object sender, EventArgs e)
		{
			UpdateInfo();
			if (!btnChinhSua.Enabled && isSuccess)
			{
				EnableControlInfo(false);
				DisableRemainFunc(true);
			}
		}

		private void btnHuyLuu_Click(object sender, EventArgs e)
		{
			if (!btnChinhSua.Enabled)
			{
				EnableControlInfo(false);
				DisableRemainFunc(true);
				ClearControlData();
				ClearError();
				ChangeRole(Account);
			}
		}

		private void btnDoiMatKhau_Click(object sender, EventArgs e)
		{
			if (btnDoiMatKhau.Enabled)
			{
				EnableControlPassword(true);
				DisableRemainFunc(false);
			}
		}

		private void btnLuuMatKhau_Click(object sender, EventArgs e)
		{
			UpdatePassword();
			if (!btnDoiMatKhau.Enabled && isSuccess)
			{
				EnableControlPassword(false);
				DisableRemainFunc(false);
			}
		}

		private void btnHuyMatKhau_Click(object sender, EventArgs e)
		{
			if (!btnDoiMatKhau.Enabled)
			{
				EnableControlPassword(false);
				DisableRemainFunc(false);
				ClearControlData();
				ClearError();
				ChangeRole(Account);
			}
		}

		private void iconTitle_Enter(object sender, EventArgs e)
		{
			lbTitle.Focus();
		}

		private event EventHandler<AccountChanged> updateAccountInfo;
		public event EventHandler<AccountChanged> UpdateAccountInfo
		{
			add
			{
				updateAccountInfo += value;
			}
			remove
			{
				updateAccountInfo -= value;
			}
		}

		#endregion
	}

	public class AccountChanged : EventArgs
	{
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }
		public AccountChanged(UserAccount account)
		{
			Account = account;
		}
	}
}
