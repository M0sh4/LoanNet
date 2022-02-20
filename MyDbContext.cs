﻿using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LoanNet
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empleado>()
                .HasOne(x => x.empresa)
                .WithMany(x => x.empleados)
                .HasForeignKey(x => x.cRuc)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Empleado>()
                .HasOne(x => x.usuario)
                .WithMany(x => x.empleados)
                .HasForeignKey(x => x.nIdUsu)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Prestamo>()
                .HasOne(x => x.cliente)
                .WithMany(x => x.prestamos)
                .HasForeignKey(x => x.cDni)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Prestamo>()
                .HasOne(x => x.tipoPrestamo)
                .WithMany(x => x.prestamos)
                .HasForeignKey(x => x.nIdTipoPrestamo)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Cliente>()
                .HasOne(x => x.usuario)
                .WithMany(x => x.clientes)
                .HasForeignKey(x => x.nIdUsu)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Empresa>()
                .HasOne(x => x.usuario)
                .WithMany(x => x.empresas)
                .HasForeignKey(x => x.nIdUsu)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Pago>()
                .HasOne(x => x.prestamo)
                .WithMany(x => x.pagos)
                .HasForeignKey(x => x.nIdPrestamo)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TipoPrestamo>()
                .HasOne(x => x.empresa)
                .WithMany(x => x.tiposPrestamos)
                .HasForeignKey(x => x.cRuc)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ListaNegra>()
                .HasKey(x => new { x.cRuc, x.cDni });


            modelBuilder.Entity<Recomendado>()
                .HasKey(x => new { x.cDniRec, x.cDni, x.cRuc });

            modelBuilder.Entity<Documento>()
                .HasKey(x => new { x.cDni, x.cRuc });
        }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Documento> documento { get; set; }
        public DbSet<Empleado> empleado { get; set; }
        public DbSet<Empresa> empresa { get; set; }
        public DbSet<ListaNegra> lista_negra { get; set; }
        public DbSet<Pago> pago { get; set; }
        public DbSet<Prestamo> prestamo { get; set; }
        public DbSet<Recomendado> recomendado { get; set; }
        public DbSet<TipoPrestamo> tipo_prestamo { get; set; }
        public DbSet<Usuario> usuario { get; set; }
    }
}