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

	public partial class TestHistory
    {
        public int TestID { get; set; }
		public string ExamID { get; set; }
		public string SubjectID { get; set; }
		public int UserID { get; set; }
        public byte SemesterID { get; set; }
        public int CorrectAnswer { get; set; }
        public int TotalQuestion { get; set; }
        public double Mark { get; set; }
		public bool Success { get; set; }
		public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
