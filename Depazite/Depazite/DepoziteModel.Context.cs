﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Depazite
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DepoziteDbEntities1 : DbContext
    {
        public DepoziteDbEntities1()
            : base("name=DepoziteDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Credity> Credities { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<AllPeople> AllPeoples { get; set; }
        public virtual DbSet<usp_AllPerson> usp_AllPerson { get; set; }
        public virtual DbSet<uv_all> uv_all { get; set; }
    }
}
