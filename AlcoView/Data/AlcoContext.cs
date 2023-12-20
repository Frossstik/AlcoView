using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AlcoView.Data.Models;

public partial class AlcoContext : DbContext
{


    public AlcoContext(DbContextOptions<AlcoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.HasIndex(e => e.CategoryId, "IX_products_categoryId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.ImageUrl).HasColumnName("imageUrl");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("price");
            entity.Property(e => e.SpirtVolume)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("spirtVolume");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Volume)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("volume");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
