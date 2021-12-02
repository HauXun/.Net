using Main.Partial;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	public static class MsgBox
    {
        public enum MessageIcon
        {
            ExclamationCircle,
            ExclamationTriangle,
            TimesCircle,
            QuestionCircle
        }

        public static DialogResult ShowMessage(string message, string caption, MessageBoxButtons button, MessageIcon icon)
        {
            DialogResult result = DialogResult.None;
            int msgLine;
            msgLine = message.Length / 59;

            switch(button)
            {
                case MessageBoxButtons.OK:
                    using (OkMessageBox msgOk = new OkMessageBox())
                    {
                        if (msgLine > 2)
                            msgOk.Size = new Size(msgOk.Size.Width, msgOk.Size.Height + msgLine * 16);
                        msgOk.lbTitle.Text = caption;
                        msgOk.lbMessage.Text = message;
                        switch (icon)
                        {
                            case MessageIcon.ExclamationCircle:
                                msgOk.iconMessage.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                                msgOk.iconMessage.IconColor = Color.DodgerBlue;
                                break;
                            case MessageIcon.ExclamationTriangle:
                                msgOk.iconMessage.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                                msgOk.iconMessage.IconColor = Color.FromArgb(192, 192, 0);
                                break;
                            case MessageIcon.TimesCircle:
                                msgOk.iconMessage.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                                msgOk.iconMessage.IconColor = Color.FromArgb(192, 0, 0);
                                break;
                            case MessageIcon.QuestionCircle:
                                msgOk.iconMessage.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
                                msgOk.iconMessage.IconColor = Color.DimGray;
                                break;
                        }
						Session.AntiPopup?.Invoke(true);
						result = msgOk.ShowDialog();
                        if (result == DialogResult.No || result == DialogResult.OK || result == DialogResult.Yes)
						{
                            Session.AntiPopup?.Invoke(false);
                        }
                    }
                    break;
                case MessageBoxButtons.YesNo:
                    using (YesNoMessageBox msgYesNo = new YesNoMessageBox())
                    {
                        if (msgLine > 2)
                            msgYesNo.Size = new Size(msgYesNo.Size.Width, msgYesNo.Size.Height - 5 + msgLine * 13);
                        msgYesNo.lbTitle.Text = caption;
                        msgYesNo.lbMessage.Text = message;
                        switch (icon)
                        {
                            case MessageIcon.ExclamationCircle:
                                msgYesNo.iconMessage.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                                msgYesNo.iconMessage.IconColor = Color.DodgerBlue;
                                break;
                            case MessageIcon.ExclamationTriangle:
                                msgYesNo.iconMessage.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                                msgYesNo.iconMessage.IconColor = Color.FromArgb(192, 192, 0);
                                break;
                            case MessageIcon.TimesCircle:
                                msgYesNo.iconMessage.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                                msgYesNo.iconMessage.IconColor = Color.FromArgb(192, 0, 0);
                                break;
                            case MessageIcon.QuestionCircle:
                                msgYesNo.iconMessage.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
                                msgYesNo.iconMessage.IconColor = Color.DimGray;
                                break;
                        }
                        Session.AntiPopup?.Invoke(true);
                        result = msgYesNo.ShowDialog();
                        if (result == DialogResult.No || result == DialogResult.OK || result == DialogResult.Yes)
                        {
                            Session.AntiPopup?.Invoke(false);
                        }
                    }
                    break;
            }

            return result;
        }
    }
}
