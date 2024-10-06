using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Data.Entities;

namespace OnlineStore.Infrastructure.Configurations
{
    public class ReviewConfigurations : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(e => e.ReviewId).HasName("PK__Reviews__74BC79AE335944D9");

            builder.Property(e => e.ReviewId)
                .ValueGeneratedNever()
                .HasColumnName("ReviewID");
            builder.Property(e => e.CustomerId).HasColumnName("CustomerID");
            builder.Property(e => e.ProductId).HasColumnName("ProductID");
            builder.Property(e => e.Rating).HasColumnType("decimal(2, 1)");
            builder.Property(e => e.ReviewDate).HasColumnType("datetime");
            builder.Property(e => e.ReviewText).HasMaxLength(500);

            builder.HasOne(d => d.Customer).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Customer_Review");

            builder.HasOne(d => d.Product).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Review");
        }

    }
}
