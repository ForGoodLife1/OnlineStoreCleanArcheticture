using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Data.Entities;

namespace OnlineStore.Infrastructure.Configurations
{
    public class ProductCategoryConfigurations : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(e => e.CategoryId).HasName("PK__ProductC__19093A2B4AA82D9C");

            builder.ToTable("ProductCategory");

            builder.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            builder.Property(e => e.CategoryNameAr).HasMaxLength(100);
            builder.Property(e => e.CategoryNameEn).HasMaxLength(100);
        }
    }
}
