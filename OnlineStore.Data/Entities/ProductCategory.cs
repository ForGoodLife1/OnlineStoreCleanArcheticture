using OnlineStore.Data.Commons;

namespace OnlineStore.Data.Entities;

public partial class ProductCategory : GeneralLocalizableEntity
{
    public ProductCategory()
    {
        ProductCatalogs=new HashSet<ProductCatalog>();

    }
    public int CategoryId { get; set; }

    public string CategoryNameAr { get; set; } = null!;
    public string CategoryNameEn { get; set; } = null!;

    public virtual ICollection<ProductCatalog> ProductCatalogs { get; set; } = new List<ProductCatalog>();
}
