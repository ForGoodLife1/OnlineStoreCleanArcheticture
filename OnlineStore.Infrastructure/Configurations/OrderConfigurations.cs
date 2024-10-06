using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Data.Entities;

namespace OnlineStore.Infrastructure.Configurations
{
    public class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAF37153F67");

            builder.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            builder.Property(e => e.CustomerId2).HasColumnName("CustomerID");
            builder.Property(e => e.OrderDate).HasColumnType("datetime");
            builder.Property(e => e.TotalAmount).HasColumnType("smallmoney");

            builder.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_Order");
        }
    }
}
