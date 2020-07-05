using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVC_Xiong.Models
{
    public partial class FlagsContext : DbContext
    {
        public FlagsContext()
        {
        }

        public FlagsContext(DbContextOptions<FlagsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Sports> Sports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:lxiong.database.windows.net,1433;Initial Catalog=Flags;Persist Security Info=False;User ID=lxiong;Password=Summer50317;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.SportId).HasColumnName("SportID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__Countries__GameI__4D94879B");

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.SportId)
                    .HasConstraintName("FK__Countries__Sport__4E88ABD4");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Game).HasMaxLength(50);
            });

            modelBuilder.Entity<Sports>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Sport).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
