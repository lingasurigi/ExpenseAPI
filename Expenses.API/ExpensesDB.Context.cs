﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Expenses_ExcelEntities : DbContext
    {
        public Expenses_ExcelEntities()
            : base("name=Expenses_ExcelEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Arrear> Arrears { get; set; }
        public DbSet<ChitDetail> ChitDetails { get; set; }
        public DbSet<Chit> Chits { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersChit> UsersChits { get; set; }
        public DbSet<UsersUtility> UsersUtilities { get; set; }
        public DbSet<Utility> Utilities { get; set; }
        public DbSet<UtilityPayment> UtilityPayments { get; set; }
    }
}
