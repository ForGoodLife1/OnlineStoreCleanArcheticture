using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrastructure.Abstracts
{
    public interface IProductCatalogRepository : IGenericRepositoryAsync<ProductCatalog>
    {
        public Task<List<ProductCatalog>> GetProductCatalogsListAsync();
    }
}
