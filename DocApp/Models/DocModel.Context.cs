﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DoctorSearchEntities : DbContext
    {
        public DoctorSearchEntities()
            : base("name=DoctorSearchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RemedyTable> RemedyTables { get; set; }
        public virtual DbSet<symptomtable> symptomtables { get; set; }
        public virtual DbSet<Userdata> Userdatas { get; set; }
        public virtual DbSet<DocRegistraton> DocRegistratons { get; set; }
        public virtual DbSet<DocRemedy> DocRemedies { get; set; }
        public virtual DbSet<DocCategory> DocCategories { get; set; }
        public virtual DbSet<DocHospital> DocHospitals { get; set; }
        public virtual DbSet<UserAppoint> UserAppoints { get; set; }
        public virtual DbSet<UserMedHistory> UserMedHistories { get; set; }
        public virtual DbSet<FrontPage> FrontPages { get; set; }
    }
}
