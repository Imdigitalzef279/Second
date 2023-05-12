using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Second.Models;

public partial class ProjectNewContext : DbContext
{
    public ProjectNewContext()
    {
    }

    public ProjectNewContext(DbContextOptions<ProjectNewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1FD9KVA;Initial Catalog=ProjectNew;Persist Security Info=False;User ID=User;Password=a123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lop>(entity =>
        {
            entity.ToTable("Lop");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LoaiLop).HasMaxLength(200);
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.ToTable("SinhVien");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.HoVaTen).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
