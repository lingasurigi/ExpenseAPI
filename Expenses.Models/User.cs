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
    
    public partial class User
    {
        public User()
        {
            this.Arrears = new HashSet<Arrear>();
            this.Arrears1 = new HashSet<Arrear>();
            this.Debits = new HashSet<Debit>();
            this.Debits1 = new HashSet<Debit>();
            this.UsersUtilities = new HashSet<UsersUtility>();
            this.UsersChits = new HashSet<UsersChit>();
            this.UsersChits1 = new HashSet<UsersChit>();
            this.UtilityPayments = new HashSet<UtilityPayment>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<Arrear> Arrears { get; set; }
        public virtual ICollection<Arrear> Arrears1 { get; set; }
        public virtual ICollection<Debit> Debits { get; set; }
        public virtual ICollection<Debit> Debits1 { get; set; }
        public virtual ICollection<UsersUtility> UsersUtilities { get; set; }
        public virtual ICollection<UsersChit> UsersChits { get; set; }
        public virtual ICollection<UsersChit> UsersChits1 { get; set; }
        public virtual ICollection<UtilityPayment> UtilityPayments { get; set; }
    }
}
