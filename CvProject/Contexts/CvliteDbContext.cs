using System;
using System.Collections.Generic;
using CvProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace CvProject.Contexts;

public partial class CvliteDbContext : DbContext
{
    public CvliteDbContext()
    {
    }

    public CvliteDbContext(DbContextOptions<CvliteDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Is> Isler { get; set; }

    public virtual DbSet<Kisi> Kisiler { get; set; }

    public virtual DbSet<KisiIs> KisiIsler { get; set; }

    public virtual DbSet<Sehir> Sehirler { get; set; }

    public virtual DbSet<Ulke> Ulkeler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CVliteDB;trusted_connection=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //modelBuilder.Entity<FilmTur>().HasKey("FilmId", "TurId");
        modelBuilder.Entity<KisiIs>().ToTable(nameof(KisiIs)).HasKey(kisiIs => new { kisiIs.KisiId, kisiIs.IsId });

        //modelBuilder.Entity<Film>().ToTable("Film");
        modelBuilder.Entity<Is>().ToTable(nameof(Is));

        modelBuilder.Entity<Kisi>().ToTable(nameof(Kisi));
        modelBuilder.Entity<Sehir>().ToTable(nameof(Sehir));
        modelBuilder.Entity<Ulke>().ToTable(nameof(Ulke));
        
    }

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
