using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RRCDataModel.Models;

namespace RRCDataModel.Data;

public partial class RRCContext : DbContext
{
    public RRCContext()
    {
    }

    public RRCContext(DbContextOptions<RRCContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comps> Comps { get; set; }

    public virtual DbSet<Discipline> Discipline { get; set; }

    public virtual DbSet<EventRunnerTimes> EventRunnerTimes { get; set; }

    public virtual DbSet<Events> Events { get; set; }

    public virtual DbSet<LastRace> LastRace { get; set; }

    public virtual DbSet<NextRace> NextRace { get; set; }

    public virtual DbSet<RaceEvent> RaceEvent { get; set; }

    public virtual DbSet<distance> distance { get; set; }

    public virtual DbSet<runners> runners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RRC;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comps>(entity =>
        {
            entity.HasKey(e => e.EFKey);
        });

        modelBuilder.Entity<EventRunnerTimes>(entity =>
        {
            entity.HasKey(e => e.EFKey);

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.EventRunnerTimes)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventRunnerTimes_Events");

            entity.HasOne(d => d.Runner).WithMany(p => p.EventRunnerTimes)
                .HasForeignKey(d => d.RunnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventRunnerTimes_runners");
        });

        modelBuilder.Entity<Events>(entity =>
        {
            entity.HasKey(e => e.EFKey);
        });

        modelBuilder.Entity<LastRace>(entity =>
        {
            entity.HasKey(e => e.EFKey);

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Runner).WithMany(p => p.LastRace)
                .HasForeignKey(d => d.RunnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LastRace_runners");
        });

        modelBuilder.Entity<NextRace>(entity =>
        {
            entity.HasKey(e => e.EFKey);

            entity.HasOne(d => d.Runner).WithMany(p => p.NextRace)
                .HasForeignKey(d => d.RunnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NextRace_runners");
        });

        modelBuilder.Entity<RaceEvent>(entity =>
        {
            entity.HasKey(e => e.EFKey);

            entity.HasOne(d => d.Event).WithMany(p => p.RaceEvent)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceEvent_Events1");
        });

        modelBuilder.Entity<distance>(entity =>
        {
            entity.HasKey(e => e.EFKey);

            entity.Property(e => e.Distance1).HasColumnName("Distance");
        });

        modelBuilder.Entity<runners>(entity =>
        {
            entity.HasKey(e => e.EFKey);

            entity.Property(e => e.ageGradeCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
