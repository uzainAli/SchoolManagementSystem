﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolManagementEntities : DbContext
    {
        public SchoolManagementEntities()
            : base("name=SchoolManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<basic_user_role> basic_user_role { get; set; }
        public virtual DbSet<basic_users> basic_users { get; set; }
        public virtual DbSet<role_type> role_type { get; set; }
    }
}
