using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace practice.Models
{
    public partial class examdbContext : DbContext
    {
        public examdbContext()
        {
        }

        public examdbContext(DbContextOptions<examdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Empptb> Empptb { get; set; }
        public virtual DbSet<Salarytb> Salarytb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=examdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Did);

                entity.ToTable("dept");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasColumnName("dname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empptb>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("empptb");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Desgn)
                    .HasColumnName("desgn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.D)
                    .WithMany(p => p.Empptb)
                    .HasForeignKey(d => d.Did)
                    .HasConstraintName("FK_Table_ToTable");
            });

            modelBuilder.Entity<Salarytb>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("salarytb");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.E)
                    .WithMany(p => p.Salarytb)
                    .HasForeignKey(d => d.Eid)
                    .HasConstraintName("eid");
            });
        }
    }
}
