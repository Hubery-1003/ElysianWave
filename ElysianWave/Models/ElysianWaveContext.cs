using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ElysianWave.Models;

public partial class ElysianWaveContext : DbContext
{
    public ElysianWaveContext()
    {
    }

    public ElysianWaveContext(DbContextOptions<ElysianWaveContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserInfomation> UserInfomations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ElysianWave;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserInfomation>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserInfo__1788CC4C2DCEF986");

            entity.ToTable("UserInfomation");

            entity.HasIndex(e => e.UserAccount, "UQ__UserInfo__D68041C008310E1E").IsUnique();

            entity.Property(e => e.UserAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserNickName).HasMaxLength(20);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
