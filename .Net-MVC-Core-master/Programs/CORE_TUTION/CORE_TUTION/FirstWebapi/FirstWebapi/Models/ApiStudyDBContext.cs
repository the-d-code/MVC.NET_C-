using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstWebapi.Models
{
    public partial class ApiStudyDBContext : DbContext
    {
        public ApiStudyDBContext()
        {
        }

        public ApiStudyDBContext(DbContextOptions<ApiStudyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmpTb> EmpTb { get; set; }
        public virtual DbSet<Table> Table { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=ApiStudyDB;Integrated Security=True;Pooling=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpTb>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("EmpTB");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
