﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bibliotecaASP_MVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bibliotekaNoemiEntities : DbContext
    {
        public bibliotekaNoemiEntities()
            : base("name=bibliotekaNoemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TAutor> TAutor { get; set; }
        public virtual DbSet<TAutor_Titulo> TAutor_Titulo { get; set; }
        public virtual DbSet<TFormato> TFormato { get; set; }
        public virtual DbSet<TIdioma> TIdioma { get; set; }
        public virtual DbSet<TImagen> TImagen { get; set; }
        public virtual DbSet<TObjecto_Imagen> TObjecto_Imagen { get; set; }
        public virtual DbSet<TPersonaje> TPersonaje { get; set; }
        public virtual DbSet<TPersonaje_Titulo> TPersonaje_Titulo { get; set; }
        public virtual DbSet<TSaga> TSaga { get; set; }
        public virtual DbSet<TTipoObjeto> TTipoObjeto { get; set; }
        public virtual DbSet<TTitulo> TTitulo { get; set; }
        public virtual DbSet<TUbicacion> TUbicacion { get; set; }
    }
}
