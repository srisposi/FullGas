using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FullGas.Core.Entities;

namespace FullGas.Infraestructure.Data
{
    public partial class FullGasContext : DbContext
    {
        public FullGasContext()
        {
        }

        public FullGasContext(DbContextOptions<FullGasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estacion> Estacion { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<Playero> Playero { get; set; }
        public virtual DbSet<Surtidor> Surtidor { get; set; }
        public virtual DbSet<Tanque> Tanque { get; set; }
        public virtual DbSet<TipoCombustible> TipoCombustible { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FullGas;Integrated Security = true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estacion>(entity =>
            {
                entity.Property(e => e.EstacionCuil)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionDireccion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionTelefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Operacion>(entity =>
            {
                entity.Property(e => e.OperacionCantidadLitro).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OperacionTotal).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.Playero)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.PlayeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Operacion_Playero");

                entity.HasOne(d => d.Surtidor)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.SurtidorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Operacion_Surtidor");

                entity.HasOne(d => d.Tanque)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.TanqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Operacion_Tanque");

                entity.HasOne(d => d.TipoCombustible)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.TipoCombustibleId)
                    .HasConstraintName("fk_Operacion_TipoCombustible");
            });

            modelBuilder.Entity<Playero>(entity =>
            {
                entity.HasIndex(e => e.PlayeroDni)
                    .HasName("UQ__Playero__7C42CF8E61111733")
                    .IsUnique();

                entity.Property(e => e.PlayeroCuil)
                    .HasColumnName("PlayeroCUIL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlayeroDni)
                    .HasColumnName("PlayeroDNI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlayeroName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlayeroSecondName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlayeroTelefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Estacion)
                    .WithMany(p => p.Playero)
                    .HasForeignKey(d => d.EstacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Playero_Estacion");
            });

            modelBuilder.Entity<Surtidor>(entity =>
            {
                entity.Property(e => e.SurtidorName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoCombustible)
                    .WithMany(p => p.Surtidor)
                    .HasForeignKey(d => d.TipoCombustibleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Surtidor_TipoCombustible");
            });

            modelBuilder.Entity<Tanque>(entity =>
            {
                entity.Property(e => e.TanqueCapacidad).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TanqueDisponible).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.TipoCombustible)
                    .WithMany(p => p.Tanque)
                    .HasForeignKey(d => d.TipoCombustibleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Tanque_TipoCombustible");
            });

            modelBuilder.Entity<TipoCombustible>(entity =>
            {
                entity.Property(e => e.TipoCimbustibleNombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCombustiblePrecio).HasColumnType("decimal(8, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
