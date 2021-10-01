using Main.Partial;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Main
{
	public partial class OkMessageBox : Form
    {
        public OkMessageBox()
        {
            InitializeComponent();
        }

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 90F)) // 196, 232, 250 || //FromArgb(230, 110, 130)
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

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

		private void btnOk_Enter(object sender, System.EventArgs e)
		{
			(sender as FontAwesome.Sharp.IconButton).GotFocus += OkMessageBox_GotFocus;
		}

		private void OkMessageBox_GotFocus(object sender, System.EventArgs e)
		{
			lbTitle.Focus();
		}

		private void OkMessageBox_Shown(object sender, System.EventArgs e)
		{
			this.Activate();
			btnOk.Focus();
		}
	}
}
