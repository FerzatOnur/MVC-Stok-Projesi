﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCSTOKPROJESİ.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVC_STOK_VERİTABANIEntities1 : DbContext
    {
        public MVC_STOK_VERİTABANIEntities1()
            : base("name=MVC_STOK_VERİTABANIEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KATEGORI_TABLOSU> KATEGORI_TABLOSU { get; set; }
        public virtual DbSet<MUSTERI_TABLOSU> MUSTERI_TABLOSU { get; set; }
        public virtual DbSet<SATIS_TABLOSU> SATIS_TABLOSU { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<URUN_TABLOSU> URUN_TABLOSU { get; set; }
    }
}
