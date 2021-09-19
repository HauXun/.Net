using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.Partial;

namespace Main
{
    public partial class DatabaseConnection : Form
    {
        public DatabaseConnection()
        {
            InitializeComponent();
            RoundedControl();
        }

        //Bo tròn góc các control
        #region RoundedControls
        private void RoundedControl()
        {
            btnConnect.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnConnect.Width, btnConnect.Height, 5, 5));
            this.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            pnl1.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnl1.Width, pnl1.Height, 5, 5));
            pnl2.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnl2.Width, pnl2.Height, 5, 5));
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
