using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MakaleYaziOrneklerim.Models;

#nullable disable

namespace MakaleYaziOrneklerim.DataAccessLayer
{
    public partial class DiyetisyenDBContext : DbContext
    {
        public DiyetisyenDBContext()
        {
        }

        public DiyetisyenDBContext(DbContextOptions<DiyetisyenDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Besinler> Besinlers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Danisan> Danisans { get; set; }
        public virtual DbSet<DanisanTahlilDosya> DanisanTahlilDosyas { get; set; }
        public virtual DbSet<Deneme> Denemes { get; set; }
        public virtual DbSet<DiyetSablon> DiyetSablons { get; set; }
        public virtual DbSet<Gorusmeler> Gorusmelers { get; set; }
        public virtual DbSet<OgunIcerikleri> OgunIcerikleris { get; set; }
        public virtual DbSet<Ogunler> Ogunlers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=ESRAORHAN; Initial catalog =DiyetisyenDB; trusted_connection=yes");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Besinler>(entity =>
            {
                entity.HasKey(e => e.BesinId);

                entity.HasIndex(e => e.CategoriesId, "IX_Besinlers_CategoriesID");

                entity.Property(e => e.BesinId).HasColumnName("BesinID");

                entity.Property(e => e.CategoriesId).HasColumnName("CategoriesID");

                entity.HasOne(d => d.Categories)
                    .WithMany(p => p.Besinlers)
                    .HasForeignKey(d => d.CategoriesId);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoriesId);

                entity.Property(e => e.CategoriesId).HasColumnName("CategoriesID");
            });

            modelBuilder.Entity<Danisan>(entity =>
            {
                entity.Property(e => e.DanisanId).HasColumnName("DanisanID");

                entity.Property(e => e.Cinsiyet)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<DanisanTahlilDosya>(entity =>
            {
                entity.ToTable("danisanTahlilDosyas");

                entity.HasIndex(e => e.DanisanId, "IX_danisanTahlilDosyas_DanisanID");

                entity.Property(e => e.DanisanTahlilDosyaId).HasColumnName("DanisanTahlilDosyaID");

                entity.Property(e => e.DanisanId).HasColumnName("DanisanID");

                entity.HasOne(d => d.Danisan)
                    .WithMany(p => p.DanisanTahlilDosyas)
                    .HasForeignKey(d => d.DanisanId);
            });

            modelBuilder.Entity<Deneme>(entity =>
            {
                entity.Property(e => e.DenemeId).HasColumnName("DenemeID");
            });

            modelBuilder.Entity<DiyetSablon>(entity =>
            {
                entity.Property(e => e.DiyetSablonId).HasColumnName("DiyetSablonID");

                entity.Property(e => e.ToplamKalori).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Gorusmeler>(entity =>
            {
                entity.HasKey(e => e.GorusmeId);

                entity.HasIndex(e => e.DanisanId, "IX_Gorusmelers_DanisanID");

                entity.Property(e => e.GorusmeId).HasColumnName("GorusmeID");

                entity.Property(e => e.BacakCm).HasColumnName("BacakCM");

                entity.Property(e => e.BasenCm).HasColumnName("BasenCM");

                entity.Property(e => e.BelCm).HasColumnName("BelCM");

                entity.Property(e => e.DanisanId).HasColumnName("DanisanID");

                entity.Property(e => e.GogusCm).HasColumnName("GogusCM");

                entity.Property(e => e.KalcaCm).HasColumnName("KalcaCM");

                entity.Property(e => e.KolCm).HasColumnName("KolCM");

                entity.HasOne(d => d.Danisan)
                    .WithMany(p => p.Gorusmelers)
                    .HasForeignKey(d => d.DanisanId);
            });

            modelBuilder.Entity<OgunIcerikleri>(entity =>
            {
                entity.HasKey(e => e.OgunIcerikId);

                entity.HasIndex(e => e.DiyetSablonId, "IX_OgunIcerikleris_DiyetSablonID");

                entity.HasIndex(e => e.OgunId, "IX_OgunIcerikleris_OgunID");

                entity.Property(e => e.OgunIcerikId).HasColumnName("OgunIcerikID");

                entity.Property(e => e.DiyetSablonId).HasColumnName("DiyetSablonID");

                entity.Property(e => e.OgunId).HasColumnName("OgunID");

                entity.HasOne(d => d.DiyetSablon)
                    .WithMany(p => p.OgunIcerikleris)
                    .HasForeignKey(d => d.DiyetSablonId);

                entity.HasOne(d => d.Ogun)
                    .WithMany(p => p.OgunIcerikleris)
                    .HasForeignKey(d => d.OgunId);
            });

            modelBuilder.Entity<Ogunler>(entity =>
            {
                entity.HasKey(e => e.OgunId);

                entity.HasIndex(e => e.BesinlerBesinId, "IX_Ogunlers_BesinlerBesinID");

                entity.HasIndex(e => e.DiyetSablonId, "IX_Ogunlers_DiyetSablonID");

                entity.Property(e => e.OgunId).HasColumnName("OgunID");

                entity.Property(e => e.BesinlerBesinId).HasColumnName("BesinlerBesinID");

                entity.Property(e => e.DiyetSablonId).HasColumnName("DiyetSablonID");

                entity.HasOne(d => d.BesinlerBesin)
                    .WithMany(p => p.Ogunlers)
                    .HasForeignKey(d => d.BesinlerBesinId);

                entity.HasOne(d => d.DiyetSablon)
                    .WithMany(p => p.Ogunlers)
                    .HasForeignKey(d => d.DiyetSablonId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
