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
					Session.bP.SetPage((int)Session.TabPage.ManageUser);
					manageUserUC.Account = this.Account;
					MainAction = manageUserUC.HomeFunc;
					manageUserUC.FrmManageUser_Load(manageUserUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.ManageFaculty);
					MainAction = manageFacultyUC.HomeFunc;
					manageFacultyUC.FrmManageFaculty_Load(manageFacultyUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.ManageCourse);
					MainAction = manageCourseUC.HomeFunc;
					manageCourseUC.FrmManageCourse_Load(manageCourseUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.ManageClass);
					MainAction = manageClassUC.HomeFunc;
					manageClassUC.ManageClass_Load(manageClassUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.Statistical);
					MainAction = statisticalUC.HomeFunc;
					statisticalUC.FrmStatistical_Load(statisticalUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.ManageSubject);
					manageSubjectUC.Account = this.Account;
					MainAction = manageSubjectUC.HomeFunc;
					manageSubjectUC.FrmManageSubject_Load(manageSubjectUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.ManageQuestion);
					manageQuestionUC.Account = this.Account;
					MainAction = manageQuestionUC.HomeFunc;
					manageQuestionUC.FrmManageUser_Load(manageQuestionUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.ManageExam);
					manageExamUC.Account = this.Account;
					MainAction = manageExamUC.HomeFunc;
					manageExamUC.FrmManageExam_Load(manageExamUC, e);
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
					EduProgBLL.Instance.CancleQuizTimes(this.Account.UserID, Session.Exam.SubjectID);
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
					Session.bP.SetPage((int)Session.TabPage.TestHistory);
					testHistoryUC.Account = this.Account;
					MainAction = testHistoryUC.HomeFunc;
					testHistoryUC.FrmTestHistory_Load(testHistoryUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.EduProg);
					eduProgUC.Account = this.Account;
					MainAction = eduProgUC.HomeFunc;
					eduProgUC.FrmEduProg_Load(eduProgUC, e);
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
					Session.bP.SetPage((int)Session.TabPage.Profile);
					profileUC.Account = this.Account;
					MainAction = profileUC.HomeFunc;
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

		private void btnHuongDanThi_Click(object sender, EventArgs e)
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

		private void btnTroGiup_Click(object sender, EventArgs e)
		{
			//OpenChildForm(helpForm);
			//ShowHideSubMenu();
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

		#region Điều hướng

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
				Session.bP.SetPage((int)Session.TabPage.LeaderBoard);
				MainAction = leaderBoardUC.HomeFunc;
				leaderBoardUC.FrmLeaderBoard_Load(leaderBoardUC, e);
			});
			#endregion
			if (pnlNavigation.Visible)
				ShowHideSubMenu();
		}

		private void BtnHuongDanThi_Click(object sender, EventArgs e)
		{
			isNavigation = true;
			btnHuongDanThi_Click(sender, e);
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
			SelectExam(e);
		}

		#endregion

		private void btnTGMini_Click(object sender, EventArgs e)
		{

		}

		#endregion


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
	}
}
