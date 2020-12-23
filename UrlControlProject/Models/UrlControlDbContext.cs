using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UrlControlProject.Models
{
    public partial class UrlControlDbContext : DbContext
    {
        public UrlControlDbContext()
        {
        }

        public UrlControlDbContext(DbContextOptions<UrlControlDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Responses> Responses { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<UrlControl> UrlControl { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Responses>(entity =>
            {
                entity.HasOne(d => d.UrlControl)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.UrlControlId)
                    .HasConstraintName("FK_Responses_UrlControl");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.HasOne(d => d.UrlControl)
                    .WithMany(p => p.Time)
                    .HasForeignKey(d => d.UrlControlId)
                    .HasConstraintName("FK_Time_UrlControl");
            });

            modelBuilder.Entity<UrlControl>(entity =>
            {
                entity.Property(e => e.Url).HasMaxLength(350);

                entity.Property(e => e.UrlName).HasMaxLength(350);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
