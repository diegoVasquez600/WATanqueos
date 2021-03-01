using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WATanqueos.Models
{
    public partial class WAdbContext : DbContext
    {
        public WAdbContext()
        {
        }

        public WAdbContext(DbContextOptions<WAdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Isla> Islas { get; set; }
        public virtual DbSet<Tanqueo> Tanqueos { get; set; }
        public virtual DbSet<TipoCombustible> TipoCombustibles { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KNX2-PC;Database=WAdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Isla>(entity =>
            {
                entity.HasKey(e => e.IdIsla)
                    .HasName("PK__ISLAS__AED4AD4ACCFB1664");

                entity.ToTable("ISLAS");

                entity.Property(e => e.IdIsla).HasColumnName("idIsla");

                entity.Property(e => e.IdTipoCombustible).HasColumnName("idTipoCombustible");

                entity.Property(e => e.NIsla)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nIsla");

                entity.HasOne(d => d.IdTipoCombustibleNavigation)
                    .WithMany(p => p.Islas)
                    .HasForeignKey(d => d.IdTipoCombustible)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ISLAS__idTipoCom__2D27B809");
            });

            modelBuilder.Entity<Tanqueo>(entity =>
            {
                entity.HasKey(e => e.IdTanqueo)
                    .HasName("PK__TANQUEOS__54F92ED760461F00");

                entity.ToTable("TANQUEOS");

                entity.Property(e => e.IdTanqueo).HasColumnName("idTanqueo");

                entity.Property(e => e.IdIsla).HasColumnName("idIsla");

                entity.Property(e => e.IdVehiculo).HasColumnName("idVehiculo");

                entity.Property(e => e.Placa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdIslaNavigation)
                    .WithMany(p => p.Tanqueos)
                    .HasForeignKey(d => d.IdIsla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TANQUEOS__idIsla__2F10007B");

                entity.HasOne(d => d.IdVehiculoNavigation)
                    .WithMany(p => p.Tanqueos)
                    .HasForeignKey(d => d.IdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TANQUEOS__idVehi__2E1BDC42");
            });

            modelBuilder.Entity<TipoCombustible>(entity =>
            {
                entity.HasKey(e => e.IdTipoCombustible)
                    .HasName("PK__TIPO_COM__4B84C3C04449A14D");

                entity.ToTable("TIPO_COMBUSTIBLE");

                entity.Property(e => e.IdTipoCombustible).HasColumnName("idTipoCombustible");

                entity.Property(e => e.TipoCombustible1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoCombustible");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PK__VEHICULO__48682970C36BF637");

                entity.ToTable("VEHICULOS");

                entity.Property(e => e.IdVehiculo).HasColumnName("idVehiculo");

                entity.Property(e => e.IdTipoCombustible).HasColumnName("idTipoCombustible");

                entity.Property(e => e.Placa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoCombustibleNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdTipoCombustible)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VEHICULOS__idTip__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
