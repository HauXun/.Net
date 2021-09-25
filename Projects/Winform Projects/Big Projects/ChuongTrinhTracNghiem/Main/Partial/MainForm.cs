using BusinessLogicLayer;
using Main.Partial;
using System;
using System.Windows.Forms;

namespace Main
{
	partial class MainForm
	{
		/// <summary>
		/// Mở Form con theo tên form
		/// </summary>
		/// <param name="childForm">Tên Form cần mở</param>
		public void OpenChildForm(Form childForm)
		{
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			pnlForm.Controls.Add(childForm);
			pnlForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		/// <summary>
		/// Events mở Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		#region Open Form Events

		private void btnQLNguoiDung_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					manageUserUC.Account = this.Account;
					MainAction = manageUserUC.HomeFunc;
					if (manageUserUC.aDgvdata.Rows.Count > 0)
						manageUserUC.FrmManageUser_Load(manageUserUC, e);
					Session.bP.SetPage((int)Session.TabPage.ManageUser);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnQLKhoa_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					MainAction = manageFacultyUC.HomeFunc;
					if (manageFacultyUC.aDgvdata.Rows.Count > 0)
						manageFacultyUC.FrmManageFaculty_Load(manageFacultyUC, e);
					Session.bP.SetPage((int)Session.TabPage.ManageFaculty);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnQLKhoaHoc_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					MainAction = manageCourseUC.HomeFunc;
					if (manageCourseUC.aDgvdata.Rows.Count > 0)
						manageCourseUC.FrmManageCourse_Load(manageCourseUC, e);
					Session.bP.SetPage((int)Session.TabPage.ManageCourse);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnQLSinhVien_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					manageClassUC.Account = this.Account;
					MainAction = manageClassUC.HomeFunc;
					if (manageClassUC.aDgvdata.Rows.Count > 0)
						manageClassUC.ManageClass_Load(manageClassUC, e);
					Session.bP.SetPage((int)Session.TabPage.ManageClass);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnPhucHoiDuLieu_Click(object sender, EventArgs e)
		{
			#region MultiThreading
			this.BeginInvoke((MethodInvoker)delegate
			{
				MainAction = backupRestoreUC.HomeFunc;
				if (backupRestoreUC.DatabaseConnection != null)
					backupRestoreUC.BackupRestore_Load(backupRestoreUC, e);
				Session.bP.SetPage((int)Session.TabPage.BackupRestore);
			});
			#endregion
			ShowHideSubMenu();
		}

		private void btnThongKeCTDT_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					MainAction = statisticalUC.HomeFunc;
					if (statisticalUC.aDgvdata.Rows.Count > 0)
						statisticalUC.FrmStatistical_Load(statisticalUC, e);
					Session.bP.SetPage((int)Session.TabPage.Statistical);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnQuanLyMonThi_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					manageSubjectUC.Account = this.Account;
					MainAction = manageSubjectUC.HomeFunc;
					if (manageSubjectUC.aDgvdata.Rows.Count > 0)
						manageSubjectUC.FrmManageSubject_Load(manageSubjectUC, e);
					Session.bP.SetPage((int)Session.TabPage.ManageSubject);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnQuanLyCauHoi_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					manageQuestionUC.Account = this.Account;
					MainAction = manageQuestionUC.HomeFunc;
					if (manageQuestionUC.aDgvdata.Rows.Count > 0)
						manageQuestionUC.FrmManageUser_Load(manageQuestionUC, e);
					Session.bP.SetPage((int)Session.TabPage.ManageQuestion);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnQuanLyDeThi_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					manageExamUC.Account = this.Account;
					MainAction = manageExamUC.HomeFunc;
					if (manageExamUC.aDgvdata.Rows.Count > 0)
						manageExamUC.FrmManageExam_Load(manageExamUC, e);
					Session.bP.SetPage((int)Session.TabPage.ManageExam);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void BatDauThi(object sender, EventArgs e)
		{
			if (Session.Exam != null && selectExamForm.IsValidComboBoxControl())
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					quizTestUC.Account = this.Account;
					quizTestUC.Exam = Session.Exam;
					quizTestUC.Data = Session.Data;
					if (quizTestUC.fLPdata.Controls.Count > 0)
						quizTestUC.FrmQuiz_Load(quizTestUC, e);
					Session.bP.SetPage((int)Session.TabPage.QuizTest);
				});
				#endregion
				selectExamForm.Hide();
				if (!selectExamForm.isMockTest)
					ExamBLL.Instance.CancleQuizTimes(Session.Exam.ExamID, Session.Exam.SubjectID);
				if (pnlNavigation.Visible)
					ShowHideSubMenu();
				btnHome.Enabled = btnNav.Enabled = pnlNavigationMini.Enabled = selectExamForm.Visible = false;
			}
		}

		private void btnThiNgay_Click(object sender, EventArgs e)
		{
			try
			{
				selectExamForm.isMockTest = false;
				if (pnlNavigation.Visible)
					ShowHideSubMenu();
				SelectExam(e);
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnLichSuThi_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					testHistoryUC.Account = this.Account;
					MainAction = testHistoryUC.HomeFunc;
					if (testHistoryUC.aDgvdata.Rows.Count > 0)
						testHistoryUC.FrmTestHistory_Load(testHistoryUC, e);
					Session.bP.SetPage((int)Session.TabPage.TestHistory);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnXemTiemDoDaoTao_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					eduProgUC.Account = this.Account;
					MainAction = eduProgUC.HomeFunc;
					if (eduProgUC.aDgvdata.Rows.Count > 0)
						eduProgUC.FrmEduProg_Load(eduProgUC, e);
					Session.bP.SetPage((int)Session.TabPage.EduProg);
				});
				#endregion
				ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void btnThongTinCaNhan_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					profileUC.Account = this.Account;
					MainAction = profileUC.HomeFunc;
					Session.bP.SetPage((int)Session.TabPage.Profile);
				});
				#endregion
				if (pnlNavigation.Visible)
					ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		private void ProfileUC_UpdateAccountInfo(object sender, Pages.AccountChanged e)
		{
			btnTroGiup.Text = $"{"Trợ giúp"} ({e.Account.FullName})";
			Account = e.Account;
		}

		private void btnHuongDan_Click(object sender, EventArgs e)
		{
			#region MultiThreading
			this.BeginInvoke((MethodInvoker)delegate
			{
				Session.bP.SetPage((int)Session.TabPage.Guide);
			});
			#endregion
			if (pnlNavigation.Visible)
				ShowHideSubMenu();
		}

		private void btnAboutUs_Click(object sender, EventArgs e)
		{
			#region MultiThreading
			this.BeginInvoke((MethodInvoker)delegate
			{
				Session.bP.SetPage((int)Session.TabPage.About);
			});
			#endregion
			if (pnlNavigation.Visible)
				ShowHideSubMenu();
		}

		/// <summary>
		/// Quay trở lại trang chính
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHome_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					if (MainAction != null)
						MainAction.Invoke();
					else
						Session.bP.SetPage((int)Session.TabPage.MainMenu);
				});
				#endregion
				if (pnlNavigation.Visible)
					ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		/// <summary>
		/// Trở về trang chủ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnTrangChu_Click(object sender, EventArgs e)
		{
			try
			{
				#region MultiThreading
				this.BeginInvoke((MethodInvoker)delegate
				{
					Session.bP.SetPage((int)Session.TabPage.MainMenu);
					Session.Exam = null;
					Session.Data = null;
				});
				#endregion
				if (pnlNavigation.Visible)
					ShowHideSubMenu();
			}
			catch (Exception ex)
			{
				MsgBox.ShowMessage(ex.Message, "Amazing Quiz Application",
				MessageBoxButtons.YesNo, MsgBox.MessageIcon.QuestionCircle);
			}
		}

		/// <summary>
		/// Xác nhận nộp bài
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNopBai_Click(object sender, EventArgs e)
		{
			Submit?.Invoke();
		}

		#endregion

		/// <summary>
		/// Mở Form bằng các nút điều hướng nhanh trên Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		#region Menu Buttons

		private void BtnQuanLyDeThi_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnQuanLyDeThi_Click(sender, e);
		}

		private void BtnQuanLyCauHoi_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnQuanLyCauHoi_Click(sender, e);
		}

		private void BtnQuanLyMonThi_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnQuanLyMonThi_Click(sender, e);
		}

		private void BtnTroGiup_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnTroGiup_Click(sender, e);
		}

		private void BtnQuanLyLop_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnQLSinhVien_Click(sender, e);
		}

		private void BtnQuanLyKhoa_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnQLKhoa_Click(sender, e);
		}

		private void BtnQuanLyKhoaHoc_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnQLKhoaHoc_Click(sender, e);
		}

		private void BtnQuanLyNguoiDung_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnQLNguoiDung_Click(sender, e);
		}

		private void BtnKhoiPhucDuLieu_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnPhucHoiDuLieu_Click(sender, e);
		}

		private void btnBangXepHang_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			#region MultiThreading
			this.BeginInvoke((MethodInvoker)delegate
			{
				if (leaderBoardUC.aDgvdata.Rows.Count > 0)
					leaderBoardUC.FrmLeaderBoard_Load(leaderBoardUC, e);
				Session.bP.SetPage((int)Session.TabPage.LeaderBoard);
				MainAction = leaderBoardUC.HomeFunc;
				if (Account.UserRole.ToLower().Equals("user"))
					leaderBoardUC.lbTitle.Text = "Bảng xếp hạng";
				else
					leaderBoardUC.lbTitle.Text = "Thống kê điểm thi";
			});
			#endregion
			if (pnlNavigation.Visible)
				ShowHideSubMenu();
		}

		private void BtnHuongDanThi_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnHuongDan_Click(sender, e);
		}

		private void BtnThongTinChiTiet_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnThongTinCaNhan_Click(sender, e);
		}

		private void BtnThiThu_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			selectExamForm.isMockTest = true;
			if (pnlNavigation.Visible)
				ShowHideSubMenu();
			SelectExam(e);
		}

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
			btnTGMini.Click += btnTroGiup_Click;
			btnThoatMini.Click += btnThoat_Click;

			//Sự kiện để mở các Form con từ các Button trong các Form con
			selectExamForm.btnStartQuiz.Click += BatDauThi;
			quizResultUC.btnTrangChu.Click += btnTrangChu_Click;
			quizTestUC.btnEnd.Click += btnNopBai_Click;
			mainMenuUC.btnBangXepHang.Click += btnBangXepHang_Click;
			mainMenuUC.btnThiNgay.Click += btnThiNgay_Click;
			mainMenuUC.btnHuongDanThi.Click += BtnHuongDanThi_Click; ;
			mainMenuUC.btnThongTinChiTiet.Click += BtnThongTinChiTiet_Click; ;
			mainMenuUC.btnQuanLyMonThi.Click += BtnQuanLyMonThi_Click;
			mainMenuUC.btnQuanLyCauHoi.Click += BtnQuanLyCauHoi_Click;
			mainMenuUC.btnQuanLyDeThi.Click += BtnQuanLyDeThi_Click;
			mainMenuUC.btnStatiscicalMark.Click += btnBangXepHang_Click;
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

			this.aboutUC = new Main.Pages.About();
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
			this.guideUC = new Main.Pages.Guide();

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
			// 
			// aboutUC
			// 
			this.aboutUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aboutUC.Location = new System.Drawing.Point(3, 3);
			this.aboutUC.Name = "aboutUC";
			this.aboutUC.Size = new System.Drawing.Size(1536, 787);
			this.aboutUC.TabIndex = 0;
			// 
			// guideUC
			// 
			this.guideUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guideUC.Location = new System.Drawing.Point(3, 3);
			this.guideUC.Name = "guideUC";
			this.guideUC.Size = new System.Drawing.Size(1536, 787);
			this.guideUC.TabIndex = 0;

			this.tPAbout.Controls.Add(this.aboutUC);
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
			this.tPGuide.Controls.Add(this.guideUC);
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

		#region Events

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.BeginInvoke((MethodInvoker)delegate
			{
				SettingControls();
				Session.bP = this.bP;
			});

			Submit = () =>
			{
				if (Session.Data != null)
				{
					#region MultiThreading
					this.BeginInvoke((MethodInvoker)delegate
					{
						quizResultUC.cPBCountDownTime.Text = (!quizTestUC.timer.MustStop) ? quizTestUC.cPBCountDownTime.Text : "Finished";
						quizResultUC.Data = Session.Data;
						quizResultUC.Exam = Session.Exam;
						if (quizResultUC.fLPdata.Controls.Count > 0)
							quizResultUC.FrmQuizResult_Load(quizResultUC, e);
						Session.bP.SetPage((int)Session.TabPage.QuizResult);
					});
					#endregion
					pnlNavigationMini.Enabled = btnHome.Enabled = btnNav.Enabled = true;
				}
			};
			Session.Submit = this.Submit;
		}

		private void btnHeThong_Enter(object sender, EventArgs e)
		{
			pbIcon.Focus();
		}

		#endregion
	}
}
