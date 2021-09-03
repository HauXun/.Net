using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
	public partial class TabPageDemo : Form
	{
		public TabPageDemo()
		{
			InitializeComponent();
		}

		#region Form
		FrmManageUser frmManageUser = new FrmManageUser();
		FrmChangePassword frmChangePassword = new FrmChangePassword();
		FrmManageSubject frmManageSubject = new FrmManageSubject();
		FrmManageQuestion frmManageQuestion = new FrmManageQuestion();
		FrmQuizOptions frmQuizOptions = new FrmQuizOptions();
		FrmManageExam frmManageExam = new FrmManageExam();
		FrmManageFaculty frmManageFaculty = new FrmManageFaculty();
		FrmManageCourse frmManageCourse = new FrmManageCourse();
		FrmManageClass frmManageClass = new FrmManageClass();
		FrmManageStatistical frmManageStatistical = new FrmManageStatistical();
		FrmTestHistory frmTestHistorys = new FrmTestHistory();
		FrmLeaderBoard frmLeaderBoard = new FrmLeaderBoard();
		FrmEduProg frmEduProg = new FrmEduProg();
		#endregion
	}
}
