﻿//------------------------------------------------------------------------------
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

    public partial class Exam
    {
        public string ExamID { get; set; }
		public string SubjectID { get; set; }
		public int ExamTime { get; set; }
        public int QCount { get; set; }
        public int QCurrentCount { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
