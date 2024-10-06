using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Data.Entities;

namespace OnlineStore.Infrastructure.Configurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B86563B9B8");

            builder.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            builder.Property(e => e.Address).HasMaxLength(200);
            builder.Property(e => e.Email).HasMaxLength(100);
            builder.Property(e => e.NameAr).HasMaxLength(100);
            builder.Property(e => e.NameEn).HasMaxLength(100);
            builder.Property(e => e.Password).HasMaxLength(100);
            builder.Property(e => e.Phone).HasMaxLength(20);
            builder.Property(e => e.Username).HasMaxLength(100);
        }
    }
}
