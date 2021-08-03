using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
	public partial class FrmManageSubject : Form
	{
		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		private bool isAddnew = false;
		private int rowIndex = 0;
		private UserAccount account;

		public UserAccount Account { get => account; set => account = value; }

		public FrmManageSubject(UserAccount account)
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			Account = account;
		}

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(196, 232, 250), 90F))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		protected override void WndProc(ref Message m)
		{
			const int WM_SYSCOMMAND = 0x0112;
			const int SC_MOVE = 0xF010;

			switch (m.Msg)
			{
				case WM_SYSCOMMAND:
					int command = m.WParam.ToInt32() & 0xfff0;
					if (command == SC_MOVE)
						return;
					break;
			}
			base.WndProc(ref m);
		}

		#region Methods

		private void LoadData()
		{
			SubjectBLL.Instance.GetAllSubject(dgvData);
		}

		private Subject GetSubjectInfo()
		{
			Subject subject = new Subject();
			subject.SubjectID = tbSubjectID.Text.Trim();
			subject.SubjectName = tbSubjectName.Text.Trim();
			subject.Description = tbDescription.Text.Trim();
			subject.CreatedBy = $"{Account.RoleID} - {Account.FullName}";
			subject.ModifiedBy = $"{Account.RoleID} - {Account.FullName}";
			return subject;
		}

		private void AddSubject()
		{
			Subject subject = GetSubjectInfo();
			if (!IsValidSubject())
				return;

			if (SubjectBLL.Instance.InsertSubject(subject))
			{
				MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				LoadData();
			}
			else
			{
				MessageBox.Show("Thêm không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void UpdateSubject()
		{
			Subject subject = GetSubjectInfo();
			if (!IsValidSubject())
				return;

			if (SubjectBLL.Instance.UpdateSubject(subject))
			{
				MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				LoadData();
			}
			else
			{
				MessageBox.Show("Cập nhập không thành công!\nVui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		private void DetailData(int rowIndex)
		{
			try
			{
				DataGridViewRow row = dgvData.Rows[rowIndex];
				tbSubjectID.Text = row.Cells["SubjectID"].Value.ToString();
				tbSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
				tbDescription.Text = row.Cells["Description"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void VisibleButton(bool isVisibleButton = false)
		{
			btnSave.Visible = btnCancle.Visible = isVisibleButton;
			btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = !isVisibleButton;
		}

		private void EnableControl(bool isEnable = true)
		{
			foreach (Control item in gbControls.Controls)
			{
				item.Enabled = isEnable;
			}
		}

		private bool IsValidSubject()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbSubjectID, "");
			errorProviderWar.SetError(tbSubjectName, "");

			// Kiểm tra mã môn thi không được để trống
			if (tbSubjectID.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbSubjectID, "Mã môn thi không được để trống!");
				return false;
			}
			else
			{
				if (IsUnicode(tbSubjectID.Text.Trim()))
				{
					errorProviderWar.SetError(tbSubjectID, "Mã môn thi không được có dấu!");
					return false;
				}
				else
				{
					if (IsSpecialCharacters(tbSubjectID.Text.Trim()))
					{
						errorProviderWar.SetError(tbSubjectID, "Mã môn thi không được chứa ký tự đặc biệt!");
						return false;
					}
				}
			}

			// Kiểm tra tên môn thi không được để trống
			if (tbSubjectName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbSubjectName, "Tên môn thi không được để trống!");
				return false;
			}
			else if (IsSpecialCharacters(tbSubjectName.Text.Trim()))
			{
				errorProviderWar.SetError(tbSubjectName, "Tên môn thi không được chứa ký tự đặc biệt!");
				return false;
			}

			return true;
		}

		private bool IsUnicode(string input)
		{
			var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
			var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
			return asciiBytesCount != unicodBytesCount;
		}

		private bool IsSpecialCharacters(string input) => input.Any(p => !char.IsLetterOrDigit(p));

		private bool IsSpaceCharacters(string input) => input.Any(char.IsWhiteSpace);

		private bool IsDigit(string input) => input.All(char.IsDigit);

		#endregion

		#region Events

		private void btnAdd_Click(object sender, EventArgs e)
		{
			isAddnew = true;
			VisibleButton(true);
			EnableControl(true);
		}

		private void FrmManageSubject_Load(object sender, EventArgs e)
		{
			LoadData();
			EnableControl(false);
		}

		private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			dgvData["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
		}

		private void dgvData_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			rowIndex = e.RowIndex;
			DetailData(rowIndex);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isAddnew = false;
			VisibleButton(true);
			EnableControl(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string subjectID = tbSubjectID.Text.Trim();
			if (!IsValidSubject())
				return;
			if (string.IsNullOrEmpty(subjectID) || rowIndex < 0)
			{
				MessageBox.Show("Vui lòng chọn môn thi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				if (SubjectBLL.Instance.DeleteSubject(subjectID))
				{
					MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					LoadData();
				}
				else
				{
					MessageBox.Show("Xóa không thành công!\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = tbSearch.Text.Trim();
			if (keyword.Equals("Nhập tên môn ..."))
				keyword = string.Empty;
			SubjectBLL.Instance.SearchSubject(dgvData, keyword);
		}

		private void tbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
			{
				tbSearch.Text = "Nhập tên môn ...";
			}
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			VisibleButton(false);
			// Restore
			DetailData(rowIndex);
			EnableControl(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (isAddnew)
				AddSubject();
			else
				UpdateSubject();
			VisibleButton(false);
			EnableControl(false);
		}

		#endregion
	}
}
