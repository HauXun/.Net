using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentMail
{
	public partial class Form1 : Form
	{
		Attachment attachment;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAttach_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				tbxAttach.Text = dialog.FileName;
			}	
		}

		private void btnSent_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(() =>
			{
				attachment = null;
				try
				{
					FileInfo file = new FileInfo(tbxAttach.Text);
					attachment = new Attachment(tbxAttach.Text);
				}
				catch { }

				StreamReader sr = new StreamReader(tbxTo.Text);
				string mail;
				while ((mail = sr.ReadLine()) != null)
				{
					SentMail(tbxLogin.Text, mail, tbxSubject.Text, tbxMessage.Text, attachment);
				}
				sr.Close();
			});
		}

		/// <summary>
		/// Gửi mail theo các thông tin truyền vào
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="subject"></param>
		/// <param name="message"></param>
		/// <param name="file"></param>
		void SentMail(string from, string to, string subject, string message, Attachment file = null)
		{
			MailMessage msg = new MailMessage(from, to, subject, message);
			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Credentials = new NetworkCredential(tbxLogin.Text, tbxPassword.Text);
			client.Send(msg);
		}

		private void btnListMail_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				tbxTo.Text = dialog.FileName;
			}
		}
	}
}
