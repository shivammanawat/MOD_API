//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOD_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainingDtl
    {
        public int id { get; set; }
        public string status { get; set; }
        public Nullable<int> progress { get; set; }
        public Nullable<double> commisionAmount { get; set; }
        public Nullable<int> rating { get; set; }
        public Nullable<double> avaRating { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<System.DateTime> startTime { get; set; }
        public Nullable<System.DateTime> endTime { get; set; }
        public Nullable<double> amountReceived { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public int mentorId { get; set; }
        public string mentorName { get; set; }
        public int skillId { get; set; }
        public string skillname { get; set; }
        public Nullable<double> fees { get; set; }
    
        public virtual SkillDtl SkillDtl { get; set; }
    }
}
