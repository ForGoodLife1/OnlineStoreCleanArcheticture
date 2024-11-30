using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Data.Entities.Identity;
using System.Reflection;

namespace OnlineStore.Infrastructure.Context;

public partial class OnlineStoreContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    //private readonly IEncryptionProvider _encryptionProvider;

    public OnlineStoreContext()
    {
    }

    public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
        : base(options)
    {
        // _encryptionProvider=new GenerateEncryptionProvider("8a4dcaaec64d412380fe4b02193cd26f");
    }
    public DbSet<UserRefreshToken> UserRefreshToken { get; set; }
    public DbSet<User> User { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<ProductCatalog> ProductCatalogs { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Shipping> Shippings { get; set; }






    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AI");



        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }

}
