﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Araba_Takip
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AracEntities : DbContext
    {
        public AracEntities()
            : base("name=AracEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AracIslemleris> AracIslemleris { get; set; }
        public virtual DbSet<AracTanimlamas> AracTanimlamas { get; set; }
        public virtual DbSet<BakimOnarims> BakimOnarims { get; set; }
        public virtual DbSet<SurucuDetays> SurucuDetays { get; set; }
    }
}
