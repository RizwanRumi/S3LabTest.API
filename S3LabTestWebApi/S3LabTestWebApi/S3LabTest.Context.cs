﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S3LabTestWebApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class S3LabTestDBEntities : DbContext
    {
        public S3LabTestDBEntities()
            : base("name=S3LabTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblLanguage> tblLanguages { get; set; }
        public virtual DbSet<tblLevel> tblLevels { get; set; }
        public virtual DbSet<tblSyllabus> tblSyllabus1 { get; set; }
        public virtual DbSet<tblSyllabusLanguage> tblSyllabusLanguages { get; set; }
        public virtual DbSet<tblTrade> tblTrades { get; set; }
    }
}