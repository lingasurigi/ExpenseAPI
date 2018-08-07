//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersChit
    {
        public UsersChit()
        {
            this.ChitDetails = new HashSet<ChitDetail>();
        }
    
        public int UsersChitsId { get; set; }
        public int AgentId { get; set; }
        public int CustomerId { get; set; }
        public int ChitId { get; set; }
        public decimal PerMonthAmount { get; set; }
        public bool IsLiftedOrNot { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<ChitDetail> ChitDetails { get; set; }
        public virtual Chit Chit { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}