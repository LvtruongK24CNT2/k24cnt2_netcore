using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LvtLesson11.Models;

public partial class LvtLesson11Context : DbContext
{
    public LvtLesson11Context()
    {
    }

    public LvtLesson11Context(DbContextOptions<LvtLesson11Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LvtEmployee> LvtEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP\\SQLEXPRESS;Database=LvtLesson11;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LvtEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LvtEmplo__3214EC076EB4AF8A");

            entity.ToTable("LvtEmployee");

            entity.Property(e => e.LvtActive).HasDefaultValue(true);
            entity.Property(e => e.LvtEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LvtGender).HasMaxLength(10);
            entity.Property(e => e.LvtName).HasMaxLength(50);
            entity.Property(e => e.LvtPhone)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
