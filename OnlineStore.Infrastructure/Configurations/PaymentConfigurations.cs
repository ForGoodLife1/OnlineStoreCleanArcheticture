using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Data.Entities;

namespace OnlineStore.Infrastructure.Configurations
{
    public class PaymentConfigurations : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(e => e.PaymentId).HasName("PK__Payments__9B556A583CAD2638");

            builder.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("PaymentID");
            builder.Property(e => e.Amount).HasColumnType("smallmoney");
            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.Property(e => e.PaymentMethod).HasMaxLength(50);
            builder.Property(e => e.TransactionDate).HasColumnType("datetime");

            builder.HasOne(d => d.Order).WithMany(p => p.Payments)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Payment");
        }
    }
}
