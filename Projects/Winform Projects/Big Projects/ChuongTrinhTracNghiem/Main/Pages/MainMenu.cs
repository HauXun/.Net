using Main.Partial;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Pages
{
	public partial class MainMenu : UserControl
	{
		public MainMenu()
		{
			InitializeComponent();

            RoundedControl();
        }

        //Bo tròn góc các Control
        #region Rounded Controls
        private void RoundedControl()
        {
            //Panel
            pnlNguoiDung.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlNguoiDung.Width, pnlNguoiDung.Height, 10, 10));
            pnlGiaoVien.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlGiaoVien.Width, pnlGiaoVien.Height, 10, 10));
            pnlAdmin.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlAdmin.Width, pnlAdmin.Height, 10, 10));

            //Panel Shadow
            pnlThongTinShadow.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlThongTinShadow.Width, pnlThongTinShadow.Height, 10, 10));

            //Buttons
            btnThiNgay.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnThiNgay.Width, btnThiNgay.Height, 10, 10));
            btnHuongDanThi.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnHuongDanThi.Width, btnHuongDanThi.Height, 10, 10));
            btnBangXepHang.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnBangXepHang.Width, btnBangXepHang.Height, 10, 10));

            btnQuanLyNguoiDung.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnQuanLyNguoiDung.Width, btnQuanLyNguoiDung.Height, 10, 10));
            btnQuanLyKhoa.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnQuanLyKhoa.Width, btnQuanLyKhoa.Height, 10, 10));
            btnQuanLyKhoaHoc.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnQuanLyKhoaHoc.Width, btnQuanLyKhoaHoc.Height, 10, 10));
            btnQuanLyLop.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnQuanLyLop.Width, btnQuanLyLop.Height, 10, 10));

            btnQuanLyMonThi.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnQuanLyMonThi.Width, btnQuanLyMonThi.Height, 10, 10));
            btnQuanLyDeThi.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnQuanLyDeThi.Width, btnQuanLyDeThi.Height, 10, 10));
            btnQuanLyCauHoi.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnQuanLyCauHoi.Width, btnQuanLyCauHoi.Height, 10, 10));
            btnStatiscicalMark.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnStatiscicalMark.Width, btnStatiscicalMark.Height, 10, 10));
        }
		#endregion

		private void btnQuanLyDeThi_Enter(object sender, System.EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += MainMenu_GotFocus;
		}

		private void MainMenu_GotFocus(object sender, System.EventArgs e)
        {
			pbBackground.Focus();
		}

		private void pbBackground_Click(object sender, System.EventArgs e)
		{
            Session.ShowHideMenu?.Invoke();
		}
	}
}
