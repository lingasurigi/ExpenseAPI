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
    
    public partial class Utility
    {
        public Utility()
        {
            this.UsersUtilities = new HashSet<UsersUtility>();
            this.UtilityPayments = new HashSet<UtilityPayment>();
        }
    
        public int UtilityId { get; set; }
        public string UtitlityName { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<UsersUtility> UsersUtilities { get; set; }
        public virtual ICollection<UtilityPayment> UtilityPayments { get; set; }
    }
}
