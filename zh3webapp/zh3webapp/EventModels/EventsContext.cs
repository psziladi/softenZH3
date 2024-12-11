using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace zh3webapp.EventModels
{
    public partial class EventsContext : DbContext
    {
        public EventsContext()
        {
        }

        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Jegy> Jegy { get; set; } = null!;
        public virtual DbSet<Rendezveny> Rendezveny { get; set; } = null!;
        public virtual DbSet<Vasarlo> Vasarlo { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=soften2.database.windows.net;Initial Catalog=Events;Persist Security Info=True;User ID=lf7bzn;Password=Password12345;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jegy>(entity =>
            {
                entity.Property(e => e.JegyId).HasColumnName("JegyID");

                entity.Property(e => e.Ar).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RendezvenyId).HasColumnName("RendezvenyID");

                entity.Property(e => e.VasarlasIdopont)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VasarloId).HasColumnName("VasarloID");

                entity.HasOne(d => d.Rendezveny)
                    .WithMany(p => p.Jegy)
                    .HasForeignKey(d => d.RendezvenyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jegy_Rendezveny");

                entity.HasOne(d => d.Vasarlo)
                    .WithMany(p => p.Jegy)
                    .HasForeignKey(d => d.VasarloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jegy_Vasarlo");
            });

            modelBuilder.Entity<Rendezveny>(entity =>
            {
                entity.Property(e => e.RendezvenyId).HasColumnName("RendezvenyID");

                entity.Property(e => e.Helyszin).HasMaxLength(100);

                entity.Property(e => e.KezdetiIdo).HasColumnType("datetime");

                entity.Property(e => e.Koltsegvetes).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Nev).HasMaxLength(100);

                entity.Property(e => e.VegsoIdo).HasColumnType("datetime");
            });

            modelBuilder.Entity<Vasarlo>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Vasarlo__A9D105340AB2974B")
                    .IsUnique();

                entity.Property(e => e.VasarloId).HasColumnName("VasarloID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Nev).HasMaxLength(100);

                entity.Property(e => e.Telefon).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
