using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace ARD.Models;

public partial class Co_DbContext : DbContext
{
    public Co_DbContext()
    {
    }

    public Co_DbContext(DbContextOptions<Co_DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CoBlock> CoBlocks { get; set; }

    public virtual DbSet<CoContainer> CoContainers { get; set; }

    public virtual DbSet<CoUser> CoUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=mysql.hostify.cz;database=db_44046_CP_x_MySQL_test;user=db_44046_CP_x_MySQL_test;password=Admin1;connection timeout=60", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.4-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<CoBlock>(entity =>
        {
            entity.HasKey(e => e.Rowid).HasName("PRIMARY");

            entity.ToTable("co_block");

            entity.HasIndex(e => new { e.Type, e.Time }, "type");

            entity.HasIndex(e => new { e.User, e.Time }, "user");

            entity.HasIndex(e => new { e.Wid, e.X, e.Z, e.Time }, "wid");

            entity.Property(e => e.Rowid)
                .HasColumnType("bigint(20)")
                .HasColumnName("rowid");
            entity.Property(e => e.Action)
                .HasColumnType("tinyint(4)")
                .HasColumnName("action");
            entity.Property(e => e.Blockdata)
                .HasColumnType("blob")
                .HasColumnName("blockdata");
            entity.Property(e => e.Data)
                .HasColumnType("int(11)")
                .HasColumnName("data");
            entity.Property(e => e.Meta)
                .HasColumnType("mediumblob")
                .HasColumnName("meta");
            entity.Property(e => e.RolledBack)
                .HasColumnType("tinyint(4)")
                .HasColumnName("rolled_back");
            entity.Property(e => e.Time)
                .HasColumnType("int(11)")
                .HasColumnName("time");
            entity.Property(e => e.Type)
                .HasColumnType("int(11)")
                .HasColumnName("type");
            entity.Property(e => e.User)
                .HasColumnType("int(11)")
                .HasColumnName("user");
            entity.Property(e => e.Wid)
                .HasColumnType("int(11)")
                .HasColumnName("wid");
            entity.Property(e => e.X)
                .HasColumnType("int(11)")
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasColumnType("int(11)")
                .HasColumnName("y");
            entity.Property(e => e.Z)
                .HasColumnType("int(11)")
                .HasColumnName("z");
        });

        modelBuilder.Entity<CoContainer>(entity =>
        {
            entity.HasKey(e => e.Rowid).HasName("PRIMARY");

            entity.ToTable("co_container");

            entity.HasIndex(e => new { e.Type, e.Time }, "type");

            entity.HasIndex(e => new { e.User, e.Time }, "user");

            entity.HasIndex(e => new { e.Wid, e.X, e.Z, e.Time }, "wid");

            entity.Property(e => e.Rowid)
                .HasColumnType("int(11)")
                .HasColumnName("rowid");
            entity.Property(e => e.Action)
                .HasColumnType("tinyint(4)")
                .HasColumnName("action");
            entity.Property(e => e.Amount)
                .HasColumnType("int(11)")
                .HasColumnName("amount");
            entity.Property(e => e.Data)
                .HasColumnType("int(11)")
                .HasColumnName("data");
            entity.Property(e => e.Metadata)
                .HasColumnType("blob")
                .HasColumnName("metadata");
            entity.Property(e => e.RolledBack)
                .HasColumnType("tinyint(4)")
                .HasColumnName("rolled_back");
            entity.Property(e => e.Time)
                .HasColumnType("int(11)")
                .HasColumnName("time");
            entity.Property(e => e.Type)
                .HasColumnType("int(11)")
                .HasColumnName("type");
            entity.Property(e => e.User)
                .HasColumnType("int(11)")
                .HasColumnName("user");
            entity.Property(e => e.Wid)
                .HasColumnType("int(11)")
                .HasColumnName("wid");
            entity.Property(e => e.X)
                .HasColumnType("int(11)")
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasColumnType("int(11)")
                .HasColumnName("y");
            entity.Property(e => e.Z)
                .HasColumnType("int(11)")
                .HasColumnName("z");
        });

        modelBuilder.Entity<CoUser>(entity =>
        {
            entity.HasKey(e => e.Rowid).HasName("PRIMARY");

            entity.ToTable("co_user");

            entity.HasIndex(e => e.User, "user");

            entity.HasIndex(e => e.Uuid, "uuid");

            entity.Property(e => e.Rowid)
                .HasColumnType("int(11)")
                .HasColumnName("rowid");
            entity.Property(e => e.Time)
                .HasColumnType("int(11)")
                .HasColumnName("time");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("user");
            entity.Property(e => e.Uuid)
                .HasMaxLength(64)
                .HasColumnName("uuid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
