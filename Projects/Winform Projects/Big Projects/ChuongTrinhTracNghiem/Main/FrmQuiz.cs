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
	public partial class FrmQuiz : Form
	{
		private UserAccount account;
		private string subject;
		private string questionCount;
		private string timeQuiz;
		public UserAccount Account { get => account; set => account = value; }
		public string Subject { get => subject; set => subject = value; }
		public string QuestionCount { get => questionCount; set => questionCount = value; }
		public string TimeQuiz { get => timeQuiz; set => timeQuiz = value; }

		// (varchar|nvarchar|int|datetime|float)(\(\d+\))*
		public FrmQuiz(UserAccount account, object subject, object questionCount, string timeQuiz)
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			Account = account;
			Subject = subject.ToString();
			QuestionCount = questionCount == null ? "" : questionCount.ToString();
			TimeQuiz = timeQuiz;
		}

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(233, 30, 59), 90F))
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


		#endregion

		private void FrmQuiz_Load(object sender, EventArgs e)
		{
			tbDisplayname.Text = Account.FullName;
			tbQuestionCount.Text = QuestionCount;
			tbSubject.Text = Subject;
			tbDoB.Text = Account.Birthday.ToString("dd/MM/yyyy");
			lbTime.Text = TimeQuiz;
		}

		private void lbFlag_MouseEnter(object sender, EventArgs e)
		{
			lbFlag.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline);
		}

		private void lbFlag_MouseLeave(object sender, EventArgs e)
		{
			lbFlag.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
		}

		private void lbTime_TextChanged(object sender, EventArgs e)
		{
			lbTime.Padding = new Padding(2);
			lbTime.TextAlign = ContentAlignment.MiddleCenter;
			//lbTime.Left = (gbTime.ClientSize.Width - lbTime.Width) / 2;
			//lbTime.Top = (gbTime.ClientSize.Height - lbTime.Height) / 2;
		}
	}
}
