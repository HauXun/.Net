using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Account
	{
		private string username;
		private string displayname;
		private string password;
		private int type;

		public string Username { get => username; set => username = value; }
		public string Displayname { get => displayname; set => displayname = value; }
		public string Password { get => password; set => password = value; }
		public int Type { get => type; set => type = value; }

		public Account(string username, string displayname, int type, string password = null)
		{
			Username = username;
			Displayname = displayname;
			Type = type;
			Password = password;
		}

		public Account(DataRow row)
		{
			Username = row["username"].ToString();
			Displayname = row["displayname"].ToString();
			Type = (int)row["type"];
			Password = row["password"].ToString();
		}
	}
}
