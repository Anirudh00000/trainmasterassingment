using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace trainmaster.Models
{
    public partial class TrainmasterContext : DbContext
    {
        public TrainmasterContext()
        {
        }

        public TrainmasterContext(DbContextOptions<TrainmasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Traindetail> Traindetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-0GGBKPE\\SQLEXPRESS;Database=Trainmaster;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Traindetail>(entity =>
            {
                entity.HasKey(e => e.TrainNo);

                entity.Property(e => e.TrainNo).ValueGeneratedNever();

                entity.Property(e => e.FromStation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToStation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrainName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
