using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dia17.Models
{
    public partial class Dia17Context : DbContext
    {
        public Dia17Context()
        {
        }

        public Dia17Context(DbContextOptions<Dia17Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Alquiler> Alquilers { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Pelicula> Peliculas { get; set; } = null!;
        public virtual DbSet<Vehiculo> Vehiculos { get; set; } = null!;
        public virtual DbSet<Ventum> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\nombre; Database=Dia17; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alquiler>(entity =>
            {
                entity.ToTable("Alquiler");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.PeliculaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PeliculaID");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Apellido).HasMaxLength(300);

                entity.Property(e => e.Direccion).HasMaxLength(300);

                entity.Property(e => e.Dni)
                    .HasMaxLength(50)
                    .HasColumnName("DNI");

                entity.Property(e => e.Nombre).HasMaxLength(300);
            });

            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.ToTable("Pelicula");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.Genero).HasMaxLength(300);

                entity.Property(e => e.Titulo).HasMaxLength(300);
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.ToTable("Vehiculo");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasMaxLength(300);

                entity.Property(e => e.Marca).HasMaxLength(300);

                entity.Property(e => e.Modelo).HasMaxLength(300);
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClienteId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClienteID");

                entity.Property(e => e.Descuento).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
