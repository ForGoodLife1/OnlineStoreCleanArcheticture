using OnlineStore.Data.Commons;

namespace OnlineStore.Data.Entities;

public partial class ProductCatalog : GeneralLocalizableEntity
{
    public ProductCatalog()
    {
        OrderItems=new HashSet<OrderItem>();
        ProductImages=new HashSet<ProductImage>();
        Reviews=new HashSet<Review>();


    }
    public int ProductId { get; set; }

    public string ProductNameAr { get; set; } = null!;
    public string ProductNameEn { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int QuantityInStock { get; set; }

    public string? ImageUrl { get; set; }

    public int CategoryId { get; set; }

    public virtual ProductCategory Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
