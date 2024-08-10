using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace deneme.Entity;

public partial class MuhasebeContext : DbContext
{
    public MuhasebeContext()
    {
    }

    public MuhasebeContext(DbContextOptions<MuhasebeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cari> Caris { get; set; }

    public virtual DbSet<Fatura> Faturas { get; set; }

    public virtual DbSet<Kasa> Kasas { get; set; }

    public virtual DbSet<KasaTanim> KasaTanims { get; set; }

    public virtual DbSet<OdemeTuru> OdemeTurus { get; set; }

    public virtual DbSet<Stok> Stoks { get; set; }

    public virtual DbSet<StokH> StokHs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-K96LII6\\SQLEXPRESS;Database=muhasebe;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cari>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cari");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlisOzelFiyati)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariTuru)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Durum).HasColumnName("durum");
            entity.Property(e => e.FaturaUnvani)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IskontoOrani).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SatisOzelFiyati)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VergiNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fatura>(entity =>
        {
            entity.ToTable("fatura");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariTuru)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaturaKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IskontoOrani).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IskontoTutari).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ToplamTutar).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Kasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kasa");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaturaKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hareket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OdemeTuruKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tutar).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<KasaTanim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kasaTanim");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KasaAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KasaKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OdemeTuru>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("odemeTuru");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OdemeTuruAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OdemeTuruKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Stok>(entity =>
        {
            entity.ToTable("stok");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlisFiyati1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.AlisFiyati2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.AlisFiyati3).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Birimi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marka)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modeli)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SatisFiyati1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SatisFiyati2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SatisFiyati3).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.StokAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StokGrubu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StokKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StokH>(entity =>
        {
            entity.ToTable("stokH");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Birimi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaturaKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hareket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndirimOrani).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IndirimTutari).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Miktari).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.StokAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StokKodu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToplamTutari).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
