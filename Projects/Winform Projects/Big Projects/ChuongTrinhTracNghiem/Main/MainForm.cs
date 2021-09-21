using Entities;
using FontAwesome.Sharp;
using Main.Partial;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
	public partial class MainForm : Form
	{
		#region Fields

		private bool isNavigation = true;

		private Color mainColor = Color.FromArgb(83, 107, 190);
		private Action MainAction;
		private Action Submit;
		private UserAccount account;
		public UserAccount Account
		{
			get => account;
			set
			{
				account = value;
				ChangeRole(account.UserRole);
			}
		}

		//Forms
		private SelectExamForm selectExamForm = new SelectExamForm();

		#endregion

		#region Constructor

		public MainForm(UserAccount account)
		{
			InitializeComponent();
			PushControl();
			this.Account = account;
		}

		#endregion

		#region CustomMode

		/// <summary>
		/// Chức năng tắt và thu nhỏ Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		#region ControlBox

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			btnThoat_Click(sender, e);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			if (MsgBox.ShowMessage("Thoát chương trình!", "Amazing Quiz Application",
			MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.Yes)
			{
				this.BeginInvoke((MethodInvoker)delegate
				{
					Environment.Exit(1);
				});
			}
		}

		/// <summary>
		/// Đăng xuất ra ngoài login
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnDangXuatNguoiDung_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Xác thực đóng chương trình
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(CancelEventArgs e)
		{
			if (quizTestUC.fLPdata.Controls.Count > 0)
			{
				MsgBox.ShowMessage("Đang làm thi. Không thể thoát", "Amazing Quiz Application",
				MessageBoxButtons.OK, MsgBox.MessageIcon.ExclamationTriangle);
				e.Cancel = true;
			}
			else if (MsgBox.ShowMessage("Thoát chương trình!", "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle) == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				//base.OnClosing(e);
				this.Dispose();
			}
		}

		#endregion

		/// <summary>
		/// Chức năng di chuyển Form bằng thanh ControlBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		#region Drag Form

		private void pnlControlBox_MouseDown(object sender, MouseEventArgs e)
		{
			Session.ReleaseCapture();
			Session.SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		#endregion

		/// <summary>
		/// Hiệu ứng cho Button
		/// </summary>
		/// <param name="mainButtonSender"></param>
		/// <param name="subButtonSender"></param>
		/// <param name="pnlMenuSender"></param>
		/// <param name="pnlStatusSender"></param>
		#region Button Effect

		/// <summary>
		/// Nhấn mạnh Button có Button con khi nhấn vào
		/// </summary>
		/// <param name="mainButtonSender"></param>
		/// <param name="subButtonSender"></param>
		/// <param name="pnlMenuSender"></param>
		/// <param name="pnlStatusSender"></param>
		private void ActivateDropDownButton(IconButton mainButtonSender, IconButton subButtonSender, Panel pnlMenuSender, Panel pnlStatusSender)
		{
			if (pnlMenuSender.Visible == false)
			{
				subButtonSender.IconChar = IconChar.ChevronUp;
				pnlStatusSender.BackColor = mainColor;
			}
			else
			{
				subButtonSender.IconChar = IconChar.ChevronDown;
				pnlStatusSender.BackColor = Color.Transparent;
			}
			pnlMenuSender.Visible = !pnlMenuSender.Visible;
		}

		/// <summary>
		/// Nhấn mạnh Button khi chỉ chuột vào Button có Button con
		/// </summary>
		/// <param name="mainButtonSender"></param>
		/// <param name="subButtonSender"></param>
		/// <param name="pnlMenuSender"></param>
		private void FocusDropDownButton(IconButton mainButtonSender, IconButton subButtonSender, Panel pnlMenuSender)
		{
			if (pnlMenuSender.Visible == false)
			{
				mainButtonSender.Padding = new Padding(mainButtonSender.Padding.Left + 5, 0, 0, 0);
				subButtonSender.Padding = new Padding(subButtonSender.Padding.Left + 5, 0, 0, 0);
			}
			subButtonSender.BackColor = Color.FromArgb(229, 229, 229);
		}

		/// <summary>
		/// Nhấn mạnh Button khi chỉ chuột vào Mũi tên của Button có Button con
		/// </summary>
		/// <param name="mainButtonSender"></param>
		/// <param name="subButtonSender"></param>
		/// <param name="pnlMenuSender"></param>
		private void FocusArrowButton(IconButton mainButtonSender, IconButton subButtonSender, Panel pnlMenuSender)
		{
			if (pnlMenuSender.Visible == false)
			{
				mainButtonSender.Padding = new Padding(mainButtonSender.Padding.Left + 5, 0, 0, 0);
				subButtonSender.Padding = new Padding(subButtonSender.Padding.Left + 5, 0, 0, 0);
			}
			mainButtonSender.BackColor = Color.FromArgb(229, 229, 229);
		}

		/// <summary>
		/// Hủy nhấn mạnh Button khi chỉ chuột ra khỏi Button
		/// </summary>
		/// <param name="mainButtonSender"></param>
		/// <param name="subButtonSender"></param>
		/// <param name="pnlMenuSender"></param>
		private void CancelFocusDropDownButton(IconButton mainButtonSender, IconButton subButtonSender, Panel pnlMenuSender)
		{
			if (pnlMenuSender.Visible == false)
			{
				mainButtonSender.Padding = new Padding(mainButtonSender.Padding.Left - 5, 0, 0, 0);
				subButtonSender.Padding = new Padding(subButtonSender.Padding.Left - 5, 0, 0, 0);
			}
			subButtonSender.BackColor = Color.Transparent;
			mainButtonSender.BackColor = Color.Transparent;
		}

		/// <summary>
		/// Nhấn mạnh Button không có Button con khi chỉ chuột vào
		/// </summary>
		/// <param name="btnSender"></param>
		/// <param name="e"></param>
		private void FocusNormalButton(object btnSender, EventArgs e)
		{
			IconButton btn = btnSender as IconButton;
			btn.Padding = new Padding(btn.Padding.Left + 5, 0, 0, 0);
			btn.IconColor = mainColor;
			btn.ForeColor = mainColor;
		}

		/// <summary>
		/// Hủy nhấn mạnh Button không có Button con
		/// </summary>
		/// <param name="btnSender"></param>
		/// <param name="e"></param>
		private void CancelFocusNormalButton(object btnSender, EventArgs e)
		{
			IconButton btn = btnSender as IconButton;
			btn.IconColor = Color.Black;
			btn.ForeColor = Color.Black;
			btn.Padding = new Padding(btn.Padding.Left - 5, 0, 0, 0);
		}

		#region ButtonHeThong

		/// <summary>
		/// Thu gọn menu quản lý khi thu gọn menu hệ thống
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHeThong_Click(object sender, EventArgs e)
		{
			if (pnlMenuHeThong.Visible && pnlMenuQuanLy.Visible)
			{
				pnlMenuQuanLy.Visible = false;
				if (btnQuanLy.Padding.Left > 30)
					btnQuanLy.Padding = new Padding(btnQuanLy.Padding.Left - 5, 0, 0, 0);
				if (btnArrowQuanLy.Padding.Left > 0)
					btnArrowQuanLy.Padding = new Padding(btnArrowQuanLy.Padding.Left - 5, 0, 0, 0);
				btnArrowQuanLy.IconChar = IconChar.ChevronDown;
				pnlQuanLyStatus.BackColor = Color.Transparent;
			}
			ActivateDropDownButton(btnHeThong, btnArrowHeThong, pnlMenuHeThong, pnlHeThongStatus);
		}

		/// <summary>
		/// Thu gọn menu quản lý khi thu gọn menu hệ thống
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnArrowHeThong_Click(object sender, EventArgs e)
		{
			if (pnlMenuHeThong.Visible && pnlMenuQuanLy.Visible)
			{
				pnlMenuQuanLy.Visible = false;
				if (btnQuanLy.Padding.Left > 30)
					btnQuanLy.Padding = new Padding(btnQuanLy.Padding.Left - 5, 0, 0, 0);
				if (btnArrowQuanLy.Padding.Left > 0)
					btnArrowQuanLy.Padding = new Padding(btnArrowQuanLy.Padding.Left - 5, 0, 0, 0);
				btnArrowQuanLy.IconChar = IconChar.ChevronDown;
				pnlQuanLyStatus.BackColor = Color.Transparent;
			}
			ActivateDropDownButton(btnHeThong, btnArrowHeThong, pnlMenuHeThong, pnlHeThongStatus);
		}

		private void btnHeThong_MouseEnter(object sender, EventArgs e)
		{
			FocusDropDownButton(btnHeThong, btnArrowHeThong, pnlMenuHeThong);
		}

		private void btnHeThong_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnHeThong, btnArrowHeThong, pnlMenuHeThong);
		}

		private void btnArrowHeThong_MouseEnter(object sender, EventArgs e)
		{
			FocusArrowButton(btnHeThong, btnArrowHeThong, pnlMenuHeThong);
		}

		private void btnArrowHeThong_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnHeThong, btnArrowHeThong, pnlMenuHeThong);
		}

		#endregion

		#region ButtonQuanLy

		private void btnQuanLy_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnQuanLy, btnArrowQuanLy, pnlMenuQuanLy, pnlQuanLyStatus);
		}

		private void btnArrowQuanLy_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnQuanLy, btnArrowQuanLy, pnlMenuQuanLy, pnlQuanLyStatus);
		}

		private void btnQuanLy_MouseEnter(object sender, EventArgs e)
		{
			FocusDropDownButton(btnQuanLy, btnArrowQuanLy, pnlMenuQuanLy);
		}

		private void btnQuanLy_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnQuanLy, btnArrowQuanLy, pnlMenuQuanLy);
		}

		private void btnArrowQuanLy_MouseEnter(object sender, EventArgs e)
		{
			FocusArrowButton(btnQuanLy, btnArrowQuanLy, pnlMenuQuanLy);
		}

		private void btnArrowQuanLy_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnQuanLy, btnArrowQuanLy, pnlMenuQuanLy);
		}

		#endregion

		#region ButtonDanhMuc
		private void btnDanhMuc_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnDanhMuc, btnArrowDanhMuc, pnlMenuDanhMuc, pnlDanhMucStatus);
		}

		private void btnArrowDanhMuc_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnDanhMuc, btnArrowDanhMuc, pnlMenuDanhMuc, pnlDanhMucStatus);
		}

		private void btnDanhMuc_MouseEnter(object sender, EventArgs e)
		{
			FocusDropDownButton(btnDanhMuc, btnArrowDanhMuc, pnlMenuDanhMuc);
		}

		private void btnDanhMuc_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnDanhMuc, btnArrowDanhMuc, pnlMenuDanhMuc);
		}

		private void btnArrowDanhMuc_MouseEnter(object sender, EventArgs e)
		{
			FocusArrowButton(btnDanhMuc, btnArrowDanhMuc, pnlMenuDanhMuc);
		}

		private void btnArrowDanhMuc_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnDanhMuc, btnArrowDanhMuc, pnlMenuDanhMuc);
		}
		#endregion

		#region ButtonChucNang

		private void btnChucNang_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnChucNang, btnArrowChucNang, pnlMenuChucNang, pnlChucNangStatus);
		}

		private void btnArrowChucNang_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnChucNang, btnArrowChucNang, pnlMenuChucNang, pnlChucNangStatus);
		}

		private void btnChucNang_MouseEnter(object sender, EventArgs e)
		{
			FocusDropDownButton(btnChucNang, btnArrowChucNang, pnlMenuChucNang);
		}

		private void btnChucNang_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnChucNang, btnArrowChucNang, pnlMenuChucNang);
		}

		private void btnArrowChucNang_MouseEnter(object sender, EventArgs e)
		{
			FocusArrowButton(btnChucNang, btnArrowChucNang, pnlMenuChucNang);
		}

		private void btnArrowChucNang_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnChucNang, btnArrowChucNang, pnlMenuChucNang);
		}

		#endregion

		#region ButtonThongKe
		private void btnThongKe_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnThongKe, btnArrowThongKe, pnlMenuThongKe, pnlThongKeStatus);
		}

		private void btnThongKeArrow_Click(object sender, EventArgs e)
		{
			ActivateDropDownButton(btnThongKe, btnArrowThongKe, pnlMenuThongKe, pnlThongKeStatus);
		}

		private void btnThongKe_MouseEnter(object sender, EventArgs e)
		{
			FocusDropDownButton(btnThongKe, btnArrowThongKe, pnlMenuThongKe);
		}

		private void btnThongKe_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnThongKe, btnArrowThongKe, pnlMenuThongKe);
		}

		private void btnThongKeArrow_MouseEnter(object sender, EventArgs e)
		{
			FocusArrowButton(btnThongKe, btnArrowThongKe, pnlMenuThongKe);
		}

		private void btnThongKeArrow_MouseLeave(object sender, EventArgs e)
		{
			CancelFocusDropDownButton(btnThongKe, btnArrowThongKe, pnlMenuThongKe);
		}
		#endregion

		/// <summary>
		/// Hủy nhấn mạnh 3 Button chính nhưng không có Button con
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnTroGiup_MouseLeave(object sender, EventArgs e)
		{
			btnTroGiup.Padding = new Padding(btnTroGiup.Padding.Left - 5, 0, 0, 0);
			btnTroGiup.ForeColor = mainColor;
			btnTroGiup.IconColor = mainColor;
		}

		private void btnThoat_MouseLeave(object sender, EventArgs e)
		{
			btnThoat.Padding = new Padding(btnThoat.Padding.Left - 5, 0, 0, 0);
			btnThoat.ForeColor = mainColor;
			btnThoat.IconColor = mainColor;
		}

		#endregion

		/// <summary>
		/// Chế độ menu thu gọn
		/// </summary>
		#region Short Menu Mode

		/// <summary>
		/// Phóng to / Thu gọn menu điều khiển
		/// </summary>
		private void ShowHideSubMenu()
		{
			if (pnlNavigation.Visible)
			{
				pnlNavigation.Visible = false;
				btnNav.IconChar = IconChar.CaretRight;
				btnNav.Location = new Point(0, 28);
				btnNav.BringToFront();
			}
			else if (!pnlNavigation.Visible && !isNavigation)
			{
				isNavigation = false;
				pnlNavigation.Show();
				btnNav.IconChar = IconChar.CaretLeft;
				btnNav.Location = new Point(350, 28);
			}
		}

		/// <summary>
		/// Nút thu phóng menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNav_Click(object sender, EventArgs e)
		{
			isNavigation = false;
			ShowHideSubMenu();
		}

		/// <summary>
		/// Đóng các menu khác khi ở chế độ menu thu gọn
		/// </summary>
		private void CloseAllPnlMenu()
		{
			if (pnlMenuHeThong.Visible)
			{
				ActivateDropDownButton(btnHeThong, btnArrowHeThong, pnlMenuHeThong, pnlHeThongStatus);
				btnHeThong.Padding = new Padding(5, 0, 0, 0);
				btnArrowHeThong.Padding = new Padding(0);
			}
			if (pnlMenuChucNang.Visible)
			{
				ActivateDropDownButton(btnChucNang, btnArrowChucNang, pnlMenuChucNang, pnlChucNangStatus);
				btnChucNang.Padding = new Padding(5, 0, 0, 0);
				btnArrowChucNang.Padding = new Padding(0);
			}
			if (pnlMenuDanhMuc.Visible)
			{
				ActivateDropDownButton(btnDanhMuc, btnArrowDanhMuc, pnlMenuDanhMuc, pnlDanhMucStatus);
				btnDanhMuc.Padding = new Padding(5, 0, 0, 0);
				btnArrowDanhMuc.Padding = new Padding(0);
			}
			if (pnlMenuThongKe.Visible)
			{
				ActivateDropDownButton(btnThongKe, btnArrowThongKe, pnlMenuThongKe, pnlThongKeStatus);
				btnThongKe.Padding = new Padding(5, 0, 0, 0);
				btnArrowThongKe.Padding = new Padding(0);
			}
		}

		/// <summary>
		/// Sự kiện click của các Button trong chế độ menu thu gọn
		/// </summary>
		/// <param name="mainButtonSender"></param>
		/// <param name="subButtonSender"></param>
		#region 4 Mini Drop Down Button

		private void btnInMiniNav_Click(IconButton mainButtonSender, IconButton subButtonSender)
		{
			pnlNavigation.Visible = true;
			CloseAllPnlMenu();
			mainButtonSender.Padding = new Padding(10, 0, 0, 0);
			subButtonSender.Padding = new Padding(5, 0, 0, 0);
			btnNav.IconChar = IconChar.CaretLeft;
			btnNav.Location = new Point(350, 28);
		}

		private void btnHTMini_Click(object sender, EventArgs e)
		{
			btnInMiniNav_Click(btnHeThong, btnArrowHeThong);
		}

		private void btnDMMini_Click(object sender, EventArgs e)
		{
			btnInMiniNav_Click(btnDanhMuc, btnArrowDanhMuc);
		}

		private void btnCNMini_Click(object sender, EventArgs e)
		{
			btnInMiniNav_Click(btnChucNang, btnArrowChucNang);
		}

		private void btnTKMini_Click(object sender, EventArgs e)
		{
			btnInMiniNav_Click(btnThongKe, btnArrowThongKe);
		}

		#endregion

		/// <summary>
		/// Nhấn mạnh các Button ở chế độ menu thu gọn
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		#region Focus Button

		private void btnHTMini_MouseEnter(object sender, EventArgs e)
		{
			pnlHTMiniStatus.BackColor = mainColor;
		}

		private void btnHTMini_MouseLeave(object sender, EventArgs e)
		{
			pnlHTMiniStatus.BackColor = Color.Transparent;
		}

		private void btnDMMini_MouseEnter(object sender, EventArgs e)
		{
			pnlDMMiniStatus.BackColor = mainColor;
		}

		private void btnDMMini_MouseLeave(object sender, EventArgs e)
		{
			pnlDMMiniStatus.BackColor = Color.Transparent;
		}

		private void btnCNMini_MouseEnter(object sender, EventArgs e)
		{
			pnlCNMiniStatus.BackColor = mainColor;
		}

		private void btnCNMini_MouseLeave(object sender, EventArgs e)
		{
			pnlCNMiniStatus.BackColor = Color.Transparent;
		}

		private void btnTKMini_MouseEnter(object sender, EventArgs e)
		{
			pnlTKBCMiniStatus.BackColor = mainColor;
		}

		private void btnTKMini_MouseLeave(object sender, EventArgs e)
		{
			pnlTKBCMiniStatus.BackColor = Color.Transparent;
		}

		private void btnTGMini_MouseEnter(object sender, EventArgs e)
		{
			pnlTGMiniStatus.BackColor = mainColor;
		}

		private void btnTGMini_MouseLeave(object sender, EventArgs e)
		{
			pnlTGMiniStatus.BackColor = Color.Transparent;
		}

		private void btnThoatMini_MouseEnter(object sender, EventArgs e)
		{
			pnlThoatMiniStatus.BackColor = mainColor;
		}

		private void btnThoatMini_MouseLeave(object sender, EventArgs e)
		{
			pnlThoatMiniStatus.BackColor = Color.Transparent;
		}

		#endregion

		#endregion

		#endregion

		#region Methods

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void SettingControls()
		{
			//Rounded Form
			Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

			Subscribe();
		}

		/// <summary>
		/// Đăng kí sự kiện cho các Button
		/// </summary>
		private void Subscribe()
		{
			btnPhucHoiDuLieu.MouseEnter += FocusNormalButton;
			btnPhucHoiDuLieu.MouseLeave += CancelFocusNormalButton;
			btnQLKhoa.MouseEnter += FocusNormalButton;
			btnQLKhoa.MouseLeave += CancelFocusNormalButton;
			btnQLKhoaHoc.MouseEnter += FocusNormalButton;
			btnQLKhoaHoc.MouseLeave += CancelFocusNormalButton;
			btnQLNguoiDung.MouseEnter += FocusNormalButton;
			btnQLNguoiDung.MouseLeave += CancelFocusNormalButton;
			btnQLLop.MouseEnter += FocusNormalButton;
			btnQLLop.MouseLeave += CancelFocusNormalButton;
			btnQuanLyCauHoi.MouseEnter += FocusNormalButton;
			btnQuanLyCauHoi.MouseLeave += CancelFocusNormalButton;
			btnQuanLyDeThi.MouseEnter += FocusNormalButton;
			btnQuanLyDeThi.MouseLeave += CancelFocusNormalButton;
			btnQuanLyMonThi.MouseEnter += FocusNormalButton;
			btnQuanLyMonThi.MouseLeave += CancelFocusNormalButton;
			btnThiThu.MouseEnter += FocusNormalButton;
			btnThiThu.MouseLeave += CancelFocusNormalButton;
			btnThiNgay.MouseEnter += FocusNormalButton;
			btnThiNgay.MouseLeave += CancelFocusNormalButton;
			btnHuongDanThi.MouseEnter += FocusNormalButton;
			btnHuongDanThi.MouseLeave += CancelFocusNormalButton;
			btnLichSuThi.MouseEnter += FocusNormalButton;
			btnLichSuThi.MouseLeave += CancelFocusNormalButton;
			btnThongTinCaNhan.MouseEnter += FocusNormalButton;
			btnThongTinCaNhan.MouseLeave += CancelFocusNormalButton;
			btnTroGiup.MouseEnter += FocusNormalButton;
			btnThoat.MouseEnter += FocusNormalButton;
			btnThongKeCTDT.MouseEnter += FocusNormalButton;
			btnThongKeCTDT.MouseLeave += CancelFocusNormalButton;
			btnXemTiemDoDaoTao.MouseEnter += FocusNormalButton;
			btnXemTiemDoDaoTao.MouseLeave += CancelFocusNormalButton;

			//Đăng kí sự kiện cho Button có Button con ở thanh Menu thu gọn
			btnHTMini.Click += btnHeThong_Click;
			btnDMMini.Click += btnDanhMuc_Click;
			btnCNMini.Click += btnChucNang_Click;
			btnTKMini.Click += btnThongKe_Click;
			btnThoatMini.Click += btnThoat_Click;

			//Sự kiện để mở các Form con từ các Button trong các Form con
			selectExamForm.btnStartQuiz.Click += BatDauThi;
			quizResultUC.btnTrangChu.Click += btnTrangChu_Click;
			quizTestUC.btnEnd.Click += btnNopBai_Click;
			mainMenuUC.btnBangXepHang.Click += btnBangXepHang_Click;
			mainMenuUC.btnThiThu.Click += BtnThiThu_Click;
			mainMenuUC.btnHuongDanThi.Click += BtnHuongDanThi_Click; ;
			mainMenuUC.btnThongTinChiTiet.Click += BtnThongTinChiTiet_Click; ;
			mainMenuUC.btnQuanLyMonThi.Click += BtnQuanLyMonThi_Click;
			mainMenuUC.btnQuanLyCauHoi.Click += BtnQuanLyCauHoi_Click;
			mainMenuUC.btnQuanLyDeThi.Click += BtnQuanLyDeThi_Click;
			mainMenuUC.btnTroGiup.Click += BtnTroGiup_Click;
			mainMenuUC.btnQuanLyNguoiDung.Click += BtnQuanLyNguoiDung_Click;
			mainMenuUC.btnQuanLyKhoaHoc.Click += BtnQuanLyKhoaHoc_Click;
			mainMenuUC.btnQuanLyKhoa.Click += BtnQuanLyKhoa_Click;
			mainMenuUC.btnQuanLyLop.Click += BtnQuanLyLop_Click;
			mainMenuUC.btnKhoiPhucDuLieu.Click += BtnKhoiPhucDuLieu_Click;
			mainMenuUC.btnDangXuatNguoiDung.Click += BtnDangXuatNguoiDung_Click;
			mainMenuUC.btnDangXuatGiaoVien.Click += BtnDangXuatNguoiDung_Click;
			mainMenuUC.btnDangXuatAdmin.Click += BtnDangXuatNguoiDung_Click;

			//Sự kiện ủy thác từ form con
			profileUC.UpdateAccountInfo += ProfileUC_UpdateAccountInfo;
		}

		/// <summary>
		/// Phân quyền tài khoản
		/// </summary>
		/// <param name="roleID"></param>
		private void ChangeRole(string roleID)
		{
			switch (roleID.ToLower())
			{
				case "admin":
					pnlButtonChucNang.Enabled = false;
					btnCNMini.Enabled = false;
					pnlButtonDanhMuc.Enabled = false;
					btnDMMini.Enabled = false;
					btnXemTiemDoDaoTao.Enabled = false;

					mainMenuUC.pnlGiaoVien.Visible = false;
					mainMenuUC.pnlNguoiDung.Visible = false;
					mainMenuUC.tbAdmin.Text = Account.FullName;
					break;
				case "user":
					pnlButtonHeThong.Enabled = false;
					btnHTMini.Enabled = false;
					pnlButtonDanhMuc.Enabled = false;
					btnDMMini.Enabled = false;
					pnlButtonChucNang.Enabled = true;
					btnCNMini.Enabled = true;
					pnlButtonThongKe.Enabled = true;
					btnTKMini.Enabled = true;
					btnThongKeCTDT.Enabled = false;

					mainMenuUC.tbTaiKhoan.Text = Account.FullName;
					mainMenuUC.tbID.Text = Account.UserID.ToString();
					mainMenuUC.pnlAdmin.Visible = false;
					mainMenuUC.pnlGiaoVien.Visible = false;
					break;
				case "teacher":
					pnlButtonHeThong.Enabled = false;
					btnHTMini.Enabled = false;
					pnlButtonChucNang.Enabled = false;
					btnCNMini.Enabled = false;
					pnlButtonThongKe.Enabled = false;
					btnTKMini.Enabled = false;

					mainMenuUC.tbManager.Text = Account.FullName;
					mainMenuUC.pnlAdmin.Visible = false;
					mainMenuUC.pnlNguoiDung.Visible = false;
					break;
			}
			btnTroGiup.Text = $"{btnTroGiup.Text} ({Account.FullName})";
		}

		/// <summary>
		/// Đẩy các control form vào trong tabpages
		/// </summary>
		private void PushControl()
		{
			////////////////////////////////////////////////////////////////////////////////////////

		
			this.mainMenuUC = new Main.Pages.MainMenu();
			this.manageUserUC = new Main.Pages.ManageUser();
			this.manageFacultyUC = new Main.Pages.ManageFaculty();
			this.manageCourseUC = new Main.Pages.ManageCourse();
			this.manageClassUC = new Main.Pages.ManageClass();
			this.manageSubjectUC = new Main.Pages.ManageSubject();
			this.manageQuestionUC = new Main.Pages.ManageQuestion();
			this.manageExamUC = new Main.Pages.ManageExam();
			this.backupRestoreUC = new Main.Pages.BackupRestore();
			this.quizTestUC = new Main.Pages.QuizTest();
			this.quizResultUC = new Main.Pages.QuizResult();
			this.testHistoryUC = new Main.Pages.TestHistory();
			this.leaderBoardUC = new Main.Pages.LeaderBoard();
			this.profileUC = new Main.Pages.Profile();
			this.statisticalUC = new Main.Pages.Statistical();
			this.eduProgUC = new Main.Pages.EduProg();

			/////////////////////////////////////////////////////////////////////

			// 
			// tPMainMenu
			// 
			this.tPMainMenu.BackColor = System.Drawing.Color.Gainsboro;
			this.tPMainMenu.Location = new System.Drawing.Point(4, 4);
			this.tPMainMenu.Name = "tPMainMenu";
			this.tPMainMenu.Padding = new System.Windows.Forms.Padding(3);
			this.tPMainMenu.Size = new System.Drawing.Size(1542, 793);
			this.tPMainMenu.TabIndex = 0;
			this.tPMainMenu.Text = "MainMenu";
			// 
			// tPManageUser
			// 
			this.tPManageUser.BackColor = System.Drawing.Color.Gainsboro;
			this.tPManageUser.Location = new System.Drawing.Point(4, 4);
			this.tPManageUser.Name = "tPManageUser";
			this.tPManageUser.Padding = new System.Windows.Forms.Padding(3);
			this.tPManageUser.Size = new System.Drawing.Size(1542, 793);
			this.tPManageUser.TabIndex = 1;
			this.tPManageUser.Text = "ManageUser";
			// 
			// tPManageFaculty
			// 
			this.tPManageFaculty.BackColor = System.Drawing.Color.Gainsboro;
			this.tPManageFaculty.Location = new System.Drawing.Point(4, 4);
			this.tPManageFaculty.Name = "tPManageFaculty";
			this.tPManageFaculty.Padding = new System.Windows.Forms.Padding(3);
			this.tPManageFaculty.Size = new System.Drawing.Size(1542, 793);
			this.tPManageFaculty.TabIndex = 2;
			this.tPManageFaculty.Text = "ManageFaculty";
			// 
			// tPManageCourse
			// 
			this.tPManageCourse.BackColor = System.Drawing.Color.Gainsboro;
			this.tPManageCourse.Location = new System.Drawing.Point(4, 4);
			this.tPManageCourse.Name = "tPManageCourse";
			this.tPManageCourse.Padding = new System.Windows.Forms.Padding(3);
			this.tPManageCourse.Size = new System.Drawing.Size(1542, 793);
			this.tPManageCourse.TabIndex = 3;
			this.tPManageCourse.Text = "ManageCourse";
			// 
			// tPManageClass
			// 
			this.tPManageClass.BackColor = System.Drawing.Color.Gainsboro;
			this.tPManageClass.Location = new System.Drawing.Point(4, 4);
			this.tPManageClass.Name = "tPManageClass";
			this.tPManageClass.Padding = new System.Windows.Forms.Padding(3);
			this.tPManageClass.Size = new System.Drawing.Size(1542, 793);
			this.tPManageClass.TabIndex = 4;
			this.tPManageClass.Text = "ManageClass";
			// 
			// tpManageSubject
			// 
			this.tpManageSubject.BackColor = System.Drawing.Color.Gainsboro;
			this.tpManageSubject.Location = new System.Drawing.Point(4, 4);
			this.tpManageSubject.Name = "tpManageSubject";
			this.tpManageSubject.Padding = new System.Windows.Forms.Padding(3);
			this.tpManageSubject.Size = new System.Drawing.Size(1542, 793);
			this.tpManageSubject.TabIndex = 5;
			this.tpManageSubject.Text = "ManageSubject";
			// 
			// tPManageQuestion
			// 
			this.tPManageQuestion.BackColor = System.Drawing.Color.Gainsboro;
			this.tPManageQuestion.Location = new System.Drawing.Point(4, 4);
			this.tPManageQuestion.Name = "tPManageQuestion";
			this.tPManageQuestion.Padding = new System.Windows.Forms.Padding(3);
			this.tPManageQuestion.Size = new System.Drawing.Size(1542, 793);
			this.tPManageQuestion.TabIndex = 6;
			this.tPManageQuestion.Text = "ManageQuestion";
			// 
			// tPManageExam
			// 
			this.tPManageExam.BackColor = System.Drawing.Color.Gainsboro;
			this.tPManageExam.Location = new System.Drawing.Point(4, 4);
			this.tPManageExam.Name = "tPManageExam";
			this.tPManageExam.Padding = new System.Windows.Forms.Padding(3);
			this.tPManageExam.Size = new System.Drawing.Size(1542, 793);
			this.tPManageExam.TabIndex = 7;
			this.tPManageExam.Text = "ManageExam";
			// 
			// tpBackupRestore
			// 
			this.tpBackupRestore.BackColor = System.Drawing.Color.Gainsboro;
			this.tpBackupRestore.Location = new System.Drawing.Point(4, 4);
			this.tpBackupRestore.Name = "tpBackupRestore";
			this.tpBackupRestore.Padding = new System.Windows.Forms.Padding(3);
			this.tpBackupRestore.Size = new System.Drawing.Size(1542, 793);
			this.tpBackupRestore.TabIndex = 8;
			this.tpBackupRestore.Text = "BackupRestore";
			// 
			// tPQuizTest
			// 
			this.tPQuizTest.BackColor = System.Drawing.Color.Gainsboro;
			this.tPQuizTest.Location = new System.Drawing.Point(4, 4);
			this.tPQuizTest.Name = "tPQuizTest";
			this.tPQuizTest.Padding = new System.Windows.Forms.Padding(3);
			this.tPQuizTest.Size = new System.Drawing.Size(1542, 793);
			this.tPQuizTest.TabIndex = 9;
			this.tPQuizTest.Text = "QuizTest";
			// 
			// tPQuizResult
			// 
			this.tPQuizResult.BackColor = System.Drawing.Color.Gainsboro;
			this.tPQuizResult.Location = new System.Drawing.Point(4, 4);
			this.tPQuizResult.Name = "tPQuizResult";
			this.tPQuizResult.Padding = new System.Windows.Forms.Padding(3);
			this.tPQuizResult.Size = new System.Drawing.Size(1542, 793);
			this.tPQuizResult.TabIndex = 10;
			this.tPQuizResult.Text = "QuizResult";
			// 
			// tPTestHistory
			// 
			this.tPTestHistory.BackColor = System.Drawing.Color.Gainsboro;
			this.tPTestHistory.Location = new System.Drawing.Point(4, 4);
			this.tPTestHistory.Name = "tPTestHistory";
			this.tPTestHistory.Padding = new System.Windows.Forms.Padding(3);
			this.tPTestHistory.Size = new System.Drawing.Size(1542, 793);
			this.tPTestHistory.TabIndex = 11;
			this.tPTestHistory.Text = "TestHistory";
			// 
			// tPLeaderBoard
			// 
			this.tPLeaderBoard.BackColor = System.Drawing.Color.Gainsboro;
			this.tPLeaderBoard.Location = new System.Drawing.Point(4, 4);
			this.tPLeaderBoard.Name = "tPLeaderBoard";
			this.tPLeaderBoard.Padding = new System.Windows.Forms.Padding(3);
			this.tPLeaderBoard.Size = new System.Drawing.Size(1542, 793);
			this.tPLeaderBoard.TabIndex = 12;
			this.tPLeaderBoard.Text = "LeaderBoard";
			// 
			// tPProfile
			// 
			this.tPProfile.BackColor = System.Drawing.Color.Gainsboro;
			this.tPProfile.Location = new System.Drawing.Point(4, 4);
			this.tPProfile.Name = "tPProfile";
			this.tPProfile.Padding = new System.Windows.Forms.Padding(3);
			this.tPProfile.Size = new System.Drawing.Size(1542, 793);
			this.tPProfile.TabIndex = 13;
			this.tPProfile.Text = "Profile";
			// 
			// tPStatistical
			// 
			this.tPStatistical.BackColor = System.Drawing.Color.Gainsboro;
			this.tPStatistical.Location = new System.Drawing.Point(4, 4);
			this.tPStatistical.Name = "tPStatistical";
			this.tPStatistical.Padding = new System.Windows.Forms.Padding(3);
			this.tPStatistical.Size = new System.Drawing.Size(1542, 793);
			this.tPStatistical.TabIndex = 14;
			this.tPStatistical.Text = "Statistical";
			// 
			// tPEduProg
			// 
			this.tPEduProg.BackColor = System.Drawing.Color.Gainsboro;
			this.tPEduProg.Location = new System.Drawing.Point(4, 4);
			this.tPEduProg.Name = "tPEduProg";
			this.tPEduProg.Padding = new System.Windows.Forms.Padding(3);
			this.tPEduProg.Size = new System.Drawing.Size(1542, 793);
			this.tPEduProg.TabIndex = 15;
			this.tPEduProg.Text = "EduProg";
			// 
			// tPGuide
			// 
			this.tPGuide.BackColor = System.Drawing.Color.Gainsboro;
			this.tPGuide.Location = new System.Drawing.Point(4, 4);
			this.tPGuide.Name = "tPGuide";
			this.tPGuide.Padding = new System.Windows.Forms.Padding(3);
			this.tPGuide.Size = new System.Drawing.Size(1542, 793);
			this.tPGuide.TabIndex = 16;
			this.tPGuide.Text = "Guide";
			// 
			// tPAbout
			// 
			this.tPAbout.BackColor = System.Drawing.Color.Gainsboro;
			this.tPAbout.Location = new System.Drawing.Point(4, 4);
			this.tPAbout.Name = "tPAbout";
			this.tPAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tPAbout.Size = new System.Drawing.Size(1542, 793);
			this.tPAbout.TabIndex = 17;
			this.tPAbout.Text = "About";

			// 
			// mainMenuUC
			// 
			this.mainMenuUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
			this.mainMenuUC.Cursor = System.Windows.Forms.Cursors.Default;
			this.mainMenuUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainMenuUC.Location = new System.Drawing.Point(3, 3);
			this.mainMenuUC.Name = "mainMenuUC";
			this.mainMenuUC.Size = new System.Drawing.Size(1536, 787);
			this.mainMenuUC.TabIndex = 0;
			// 
			// manageUserUC
			// 
			this.manageUserUC.BackColor = System.Drawing.SystemColors.Control;
			this.manageUserUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manageUserUC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.manageUserUC.Location = new System.Drawing.Point(3, 3);
			this.manageUserUC.Name = "manageUserUC";
			this.manageUserUC.Size = new System.Drawing.Size(1536, 787);
			this.manageUserUC.TabIndex = 0;
			// 
			// manageFacultyUC
			// 
			this.manageFacultyUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manageFacultyUC.Location = new System.Drawing.Point(3, 3);
			this.manageFacultyUC.Name = "manageFacultyUC";
			this.manageFacultyUC.Size = new System.Drawing.Size(1536, 787);
			this.manageFacultyUC.TabIndex = 0;
			// 
			// manageCourseUC
			// 
			this.manageCourseUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manageCourseUC.Location = new System.Drawing.Point(3, 3);
			this.manageCourseUC.Name = "manageCourseUC";
			this.manageCourseUC.Size = new System.Drawing.Size(1536, 787);
			this.manageCourseUC.TabIndex = 0;
			// 
			// manageClassUC
			// 
			this.manageClassUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manageClassUC.Location = new System.Drawing.Point(3, 3);
			this.manageClassUC.Name = "manageClassUC";
			this.manageClassUC.Size = new System.Drawing.Size(1536, 787);
			this.manageClassUC.TabIndex = 0;
			// 
			// manageSubjectUC
			// 
			this.manageSubjectUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manageSubjectUC.Location = new System.Drawing.Point(3, 3);
			this.manageSubjectUC.Name = "manageSubjectUC";
			this.manageSubjectUC.Size = new System.Drawing.Size(1536, 787);
			this.manageSubjectUC.TabIndex = 0;
			// 
			// manageQuestionUC
			// 
			this.manageQuestionUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manageQuestionUC.Location = new System.Drawing.Point(3, 3);
			this.manageQuestionUC.Name = "manageQuestionUC";
			this.manageQuestionUC.Size = new System.Drawing.Size(1536, 787);
			this.manageQuestionUC.TabIndex = 0;
			// 
			// manageExamUC
			// 
			this.manageExamUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.manageExamUC.Location = new System.Drawing.Point(3, 3);
			this.manageExamUC.Name = "manageExamUC";
			this.manageExamUC.Size = new System.Drawing.Size(1536, 787);
			this.manageExamUC.TabIndex = 0;
			// 
			// backupRestoreUC
			// 
			this.backupRestoreUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backupRestoreUC.Location = new System.Drawing.Point(3, 3);
			this.backupRestoreUC.Name = "backupRestoreUC";
			this.backupRestoreUC.Size = new System.Drawing.Size(1536, 787);
			this.backupRestoreUC.TabIndex = 0;
			// 
			// quizTestUC
			// 
			this.quizTestUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.quizTestUC.Location = new System.Drawing.Point(3, 3);
			this.quizTestUC.Name = "quizTestUC";
			this.quizTestUC.Size = new System.Drawing.Size(1536, 787);
			this.quizTestUC.TabIndex = 0;
			// 
			// quizResultUC
			// 
			this.quizResultUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.quizResultUC.Exam = null;
			this.quizResultUC.Location = new System.Drawing.Point(3, 3);
			this.quizResultUC.Name = "quizResultUC";
			this.quizResultUC.Size = new System.Drawing.Size(1536, 787);
			this.quizResultUC.TabIndex = 0;
			// 
			// testHistoryUC
			// 
			this.testHistoryUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.testHistoryUC.Location = new System.Drawing.Point(3, 3);
			this.testHistoryUC.Name = "testHistoryUC";
			this.testHistoryUC.Size = new System.Drawing.Size(1536, 787);
			this.testHistoryUC.TabIndex = 0;
			// 
			// leaderBoardUC
			// 
			this.leaderBoardUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leaderBoardUC.Location = new System.Drawing.Point(3, 3);
			this.leaderBoardUC.Name = "leaderBoardUC";
			this.leaderBoardUC.Size = new System.Drawing.Size(1536, 787);
			this.leaderBoardUC.TabIndex = 0;
			// 
			// profileUC
			// 
			this.profileUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.profileUC.Location = new System.Drawing.Point(3, 3);
			this.profileUC.Name = "profileUC";
			this.profileUC.Size = new System.Drawing.Size(1536, 787);
			this.profileUC.TabIndex = 0;
			// 
			// statisticalUC
			// 
			this.statisticalUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statisticalUC.Location = new System.Drawing.Point(3, 3);
			this.statisticalUC.Name = "statisticalUC";
			this.statisticalUC.Size = new System.Drawing.Size(1536, 787);
			this.statisticalUC.TabIndex = 0;
			// 
			// eduProgUC
			// 
			this.eduProgUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eduProgUC.Location = new System.Drawing.Point(3, 3);
			this.eduProgUC.Name = "eduProgUC";
			this.eduProgUC.Size = new System.Drawing.Size(1536, 787);
			this.eduProgUC.TabIndex = 0;

			this.tPMainMenu.Controls.Add(this.mainMenuUC);
			this.tPManageUser.Controls.Add(this.manageUserUC);
			this.tPManageFaculty.Controls.Add(this.manageFacultyUC);
			this.tPManageCourse.Controls.Add(this.manageCourseUC);
			this.tPManageClass.Controls.Add(this.manageClassUC);
			this.tpManageSubject.Controls.Add(this.manageSubjectUC);
			this.tPManageQuestion.Controls.Add(this.manageQuestionUC);
			this.tPManageExam.Controls.Add(this.manageExamUC);
			this.tpBackupRestore.Controls.Add(this.backupRestoreUC);
			this.tPQuizTest.Controls.Add(this.quizTestUC);
			this.tPQuizResult.Controls.Add(this.quizResultUC);
			this.tPTestHistory.Controls.Add(this.testHistoryUC);
			this.tPLeaderBoard.Controls.Add(this.leaderBoardUC);
			this.tPProfile.Controls.Add(this.profileUC);
			this.tPStatistical.Controls.Add(this.statisticalUC);
			this.tPEduProg.Controls.Add(this.eduProgUC);
			//Guide
			//About us
		}

		/// <summary>
		/// Chọn môn thi
		/// </summary>
		/// <param name="e"></param>
		private void SelectExam(EventArgs e)
		{
			selectExamForm.Account = this.Account;
			if (selectExamForm.Exam != null)
				selectExamForm.FrmSelectExam_Load(null, null);
			selectExamForm.ShowDialog();
		}

		#endregion
	}
}