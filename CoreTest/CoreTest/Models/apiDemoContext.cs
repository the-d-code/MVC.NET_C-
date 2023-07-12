using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreTest.models
{
    public partial class apiDemoContext : DbContext
    {
        public apiDemoContext()
        {
        }

        public apiDemoContext(DbContextOptions<apiDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryTb> CategoryTb { get; set; }
        public virtual DbSet<ProductTb> ProductTb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LULPB7Q\\SQLEXPRESS;Initial Catalog=apiDemo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CategoryTb>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Category__19093A0BB702A61F");

                entity.ToTable("CategoryTB");

                entity.Property(e => e.Categiry)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductTb>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__ProductT__B40CC6CDD1991A2D");

                entity.ToTable("ProductTB");

                entity.Property(e => e.MfgDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductTb)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_To_Category");
            });
        }
    }
}
