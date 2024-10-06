using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Data.Entities;

namespace OnlineStore.Infrastructure.Configurations
{
    public class ShippingConfigurations : IEntityTypeConfiguration<Shipping>
    {
        public void Configure(EntityTypeBuilder<Shipping> builder)
        {
            builder.Property(e => e.ShippingId).HasColumnName("ShippingID");
            builder.Property(e => e.ActualDeliveryDate).HasColumnType("datetime");
            builder.Property(e => e.CarrierName).HasMaxLength(100);
            builder.Property(e => e.EstimatedDeliveryDate).HasColumnType("datetime");
            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.Property(e => e.TrackingNumber).HasMaxLength(50);

            builder.HasOne(d => d.Order).WithMany(p => p.Shippings)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Shipping");
        }
    }
}
