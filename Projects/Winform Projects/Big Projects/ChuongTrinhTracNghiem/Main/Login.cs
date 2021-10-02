using BusinessLogicLayer;
using Entities;
using Main.Partial;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Main
{
	public partial class LoginForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public LoginForm()
		{
			InitializeComponent();
			GetRounded();
		}

		#region Methods

		/// <summary>
		/// Load dữ liệu
		/// </summary>
		private void GetRounded()
		{
			Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
			btnExit.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 6, 6));
		}

		/// <summary>
		/// Kiểm tra toàn vẹn dữ liệu nhập
		/// </summary>
		/// <returns></returns>
		private bool IsValidUser()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbUsername, "");
			errorProviderWar.SetError(tbPassword, "");

			// Kiểm tra	tên đăng nhập không được để trống
			if (tbUsername.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbUsername, "Tên đăng nhập\nkhông được để trống!");
				return false;
			}

			// Kiểm tra mật khẩu không được để trống
			if (tbPassword.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống!");
				return false;
			}
			return true;
		}

		#endregion

		#region Events

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Lấy thông tin từ giao diện
			string username = tbUsername.Text.Trim();
			string password = tbPassword.Text.Trim();
			UserAccount user = new UserAccount()
			{
				Username = username,
				Password = password
			};

			// Kiểm tra đầu vào
			if (!IsValidUser())
				return;

			// Kiểm tra tài khoản đăng nhập:
			// Kết nối tới cơ sở dữ liệu
			try
			{
				if (AccountBLL.Instance.IsExistAccount(user))
				{
					pControl.Visible = btnLogin.Enabled = false;
					//Task.Run(() =>
					new Thread(() =>
					{
						UserAccount account = AccountBLL.Instance.GetAccountByUserName(username);
						MainForm frm = new MainForm(account);
						frm.Shown += Frm_Shown;
						frm.FormClosed += Frm_FormClosed;
						Thread.Sleep(200);
						frm.ShowDialog();
					}).Start();
				}
				else
				{
					MsgBox.ShowMessage("Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!",
					"Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				}
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage($"Có lỗi phát sinh. Vui lòng kiểm tra lại!\n{ex.Message}",
				"Amazing Quiz Application", MessageBoxButtons.OK, MsgBox.MessageIcon.TimesCircle);
			}
		}

		private void Frm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.BeginInvoke((MethodInvoker)delegate
			{
				pControl.Visible = btnLogin.Enabled = true;
				tbUsername.Text = string.Empty;
				tbPassword.Text = string.Empty;
				this.Show();
				this.Activate();
			});
		}

		private void Frm_Shown(object sender, EventArgs e)
		{
			this.BeginInvoke((MethodInvoker)delegate
			{
				this.Hide();
			});
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (MsgBox.ShowMessage("Thoát chương trình!", "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
				this.Dispose();
			//base.OnClosing(e);
		}

		private void btnLogin_Enter(object sender, EventArgs e)
		{
			background.Focus();
		}

		#endregion
	}
}