﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoParcial2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_LENG4TA_2DOPARCIALEntities : DbContext
    {
        public BD_LENG4TA_2DOPARCIALEntities()
            : base("name=BD_LENG4TA_2DOPARCIALEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLiente> CLientes { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<producto> productoes { get; set; }
        public virtual DbSet<tipo> tipoes { get; set; }
    }
}
