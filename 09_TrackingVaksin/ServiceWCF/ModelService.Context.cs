﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceWCF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrackingVaksinEntities : DbContext
    {
        public TrackingVaksinEntities()
            : base("name=TrackingVaksinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CekValid> CekValid { get; set; }
        public virtual DbSet<Data_Penduduk> Data_Penduduk { get; set; }
        public virtual DbSet<LaporTerimaVaksin> LaporTerimaVaksin { get; set; }
        public virtual DbSet<LaporValidasiVaksin> LaporValidasiVaksin { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<PenggunaanVaksin> PenggunaanVaksin { get; set; }
        public virtual DbSet<Reg_Vaksin> Reg_Vaksin { get; set; }
        public virtual DbSet<Vaksin> Vaksin { get; set; }
        public virtual DbSet<ValidasiVaksin> ValidasiVaksin { get; set; }
    }
}
