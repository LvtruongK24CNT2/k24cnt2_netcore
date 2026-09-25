using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LvtLesson10.Models;

public partial class LvtK24cnt2lesson01Context : DbContext
{
    public LvtK24cnt2lesson01Context()
    {
    }

    public LvtK24cnt2lesson01Context(DbContextOptions<LvtK24cnt2lesson01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LvtMember> LvtMembers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOP\\SQLEXPRESS;Database=LvtK24CNT2Lesson01;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LvtMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__LvtMembe__0CF04B18977DDCDB");

            entity.ToTable("LvtMember");

            entity.HasIndex(e => e.LvtUserName, "UQ__LvtMembe__699C132B349D484B").IsUnique();

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.LvtEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LvtFullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LvtPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LvtPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LvtStatus).HasDefaultValue(true);
            entity.Property(e => e.LvtUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
