using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Data.Entities;

namespace OnlineStore.Infrastructure.Configurations
{
    public class ProductCatalogConfigurations : IEntityTypeConfiguration<ProductCatalog>
    {
        public void Configure(EntityTypeBuilder<ProductCatalog> builder)
        {
            builder.HasKey(e => e.ProductId).HasName("PK__ProductC__B40CC6EDEB4EC44B");

            builder.ToTable("ProductCatalog");

            builder.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("ProductID");
            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");
            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(e => e.ImageUrl)
                .HasMaxLength(200)
                .HasColumnName("ImageURL");
            builder.Property(e => e.Price).HasColumnType("smallmoney");
            builder.Property(e => e.ProductNameAr).HasMaxLength(100);
            builder.Property(e => e.ProductNameEn).HasMaxLength(100);

            builder.HasOne(d => d.Category).WithMany(p => p.ProductCatalogs)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Category_Product");
        }
    }
}
