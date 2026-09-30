using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LvtLesson12.Models;

public partial class LvtProductDbContext : DbContext
{
    public LvtProductDbContext()
    {
    }

    public LvtProductDbContext(DbContextOptions<LvtProductDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP\\SQLEXPRESS;Database=LvtProductDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.LvtId).HasName("PK__Product__09AC9921ACB07AA3");

            entity.ToTable("Product");

            entity.Property(e => e.LvtId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LvtCategoryId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LvtCreateDate).HasColumnType("datetime");
            entity.Property(e => e.LvtDescription).HasMaxLength(500);
            entity.Property(e => e.LvtImages).HasMaxLength(255);
            entity.Property(e => e.LvtName).HasMaxLength(100);
            entity.Property(e => e.LvtPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LvtSalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LvtStatus).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
