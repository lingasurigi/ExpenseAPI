//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpensesProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Debit
    {
        public int DebitsId { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public decimal DebitedAmount { get; set; }
        public string TransactionNumber { get; set; }
        public string OrderNumber { get; set; }
        public string CheckNumber { get; set; }
        public int StatusId { get; set; }
        public string Reason { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}