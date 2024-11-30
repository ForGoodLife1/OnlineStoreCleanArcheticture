using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IProductCatalogService
    {
        public Task<ProductCatalog> GetProductCatalogByIdAsync(int id);
        public Task<bool> IsProductCatalogIdExist(int productCatalogId);
    }
}
