//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
	using System;
	using System.Data;

	public partial class UserAccount
    {
        public int UserID { get; set; }
        public string RoleID { get; set; }
        public string Username { get; set; }
		public string Password { get; set; }
		public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

		public UserAccount()
		{

		}

		public UserAccount(DataRow row)
		{
            Username = row["Username"].ToString();
            FullName = row["Fullname"].ToString();
            RoleID = row["RoleID"].ToString();
        }
    }
}
