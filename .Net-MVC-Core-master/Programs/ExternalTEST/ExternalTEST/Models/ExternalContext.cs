using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExternalTEST.Models
{
    public partial class ExternalContext : DbContext
    {
        public ExternalContext()
        {
        }

        public ExternalContext(DbContextOptions<ExternalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerTb> CustomerTb { get; set; }
        public virtual DbSet<OrderTb> OrderTb { get; set; }
        public virtual DbSet<ProductTb> ProductTb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LULPB7Q\\SQLEXPRESS;Initial Catalog=External;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CustomerTb>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("CustomerTB");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderTb>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderTB");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderTb)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Table_1_CustomerTB");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderTb)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Table_1ProductTB");
            });

            modelBuilder.Entity<ProductTb>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("ProductTB");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpDate).HasColumnType("date");

                entity.Property(e => e.MfgDate).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
