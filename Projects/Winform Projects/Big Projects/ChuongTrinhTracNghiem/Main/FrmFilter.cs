using BusinessLogicLayer;
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
	public partial class FrmFilter : Form
	{
		private DataGridView data;

		public DataGridView Data { get => data; set => data = value; }

		public FrmFilter(DataGridView data)
		{
			InitializeComponent();
			Data = data;
		}

		#region Methods

		private void LoadData()
		{
			SubjectBLL.Instance.GetAllSubject(cbSubjectFilter);
			ExamBLL.Instance.GetAllExam(cbExamIDFilter);
			RoleBLL.Instance.GetAllRoleExam(cbExamRoleFilter);
		}

		private bool IsValidComboBoxControl()
		{
			errorProviderWar.SetError(cbSubjectFilter, "");
			errorProviderWar.SetError(cbExamIDFilter, "");
			errorProviderWar.SetError(cbExamRoleFilter, "");

			if (cbSubjectFilter.Items.Count == 0)
			{
				errorProviderWar.SetError(cbSubjectFilter, "Không có môn thi!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbSubjectFilter.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbSubjectFilter, "Vui lòng chọn môn thi cần lọc");
					return false;
				}
			}

			if (cbExamIDFilter.Items.Count == 0)
			{
				errorProviderWar.SetError(cbExamIDFilter, "Không có mã môn cho bộ môn này!\nVui lòng bổ sung");
				return false;
			}
			else
			{
				if (cbExamIDFilter.SelectedIndex == -1)
				{
					errorProviderWar.SetError(cbExamIDFilter, "Vui lòng chọn mã môn cần lọc");
					return false;
				}
			}

			if (cbExamRoleFilter.Enabled)
			{
				if (cbExamRoleFilter.Items.Count == 0)
				{
					errorProviderWar.SetError(cbExamRoleFilter, "Không có loại đề cho bộ môn và mã môn này!\nVui lòng bổ sung");
					return false;
				}
				else
				{
					if (cbExamRoleFilter.SelectedIndex == -1)
					{
						errorProviderWar.SetError(cbExamRoleFilter, "Vui lòng chọn loại đề cần lọc");
						return false;
					}
				}
			}

			return true;
		}

		private void ClearControl()
		{
			foreach (Control control in this.Controls)
			{
				if (control is ComboBox)
					(control as ComboBox).SelectedIndex = -1;
			}
		}

		#endregion

		#region Events

		private void FrmFilter_Load(object sender, EventArgs e)
		{
			LoadData();
			ClearControl();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			if (!IsValidComboBoxControl())
				return;
			if (cbExamRoleFilter.Enabled == false)
			{
				QuestionBLL.Instance.SearchQuestion(Data, "",
					cbSubjectFilter.SelectedValue.ToString().Trim(),
					cbExamIDFilter.SelectedValue.ToString().Trim());
			}
			else
			{
				ExamBLL.Instance.SearchExam(Data,
					cbExamIDFilter.SelectedValue.ToString().Trim(),
					cbSubjectFilter.SelectedValue.ToString().Trim(),
					cbExamRoleFilter.SelectedValue.ToString().Trim());
			}

			this.Close();
		}

		private void cbSubjectFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbExamIDFilter.Text = string.Empty;
			if (cbSubjectFilter.SelectedValue != null)
			{
				if (cbSubjectFilter.SelectedValue.ToString().Trim().Equals("ALL"))
				{
					ExamBLL.Instance.GetAllExam(cbExamIDFilter);
				}
				else
				{
					DataTable data = ExamBLL.Instance.GetExamByIDSubject(cbSubjectFilter.SelectedValue.ToString());
					cbExamIDFilter.DataSource = data;
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion
	}
}
