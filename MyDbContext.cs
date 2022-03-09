using LoanNet.Models;
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

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<ListaNegra> Listas_Negras { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Recomendado> Recomendados { get; set; }
        public DbSet<TipoPrestamo> Tipos_Prestamos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
