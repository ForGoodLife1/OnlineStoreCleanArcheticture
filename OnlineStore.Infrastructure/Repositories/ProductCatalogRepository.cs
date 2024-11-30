using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Infrastructure.Context;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ProductCatalogRepository : GenericRepositoryAsync<ProductCatalog>, IProductCatalogRepository
    {
        private DbSet<ProductCatalog> _ProductCatalogs;
        public ProductCatalogRepository(OnlineStoreContext dBContext) : base(dBContext)
        {
            _ProductCatalogs=dBContext.Set<ProductCatalog>();
        }

        public async Task<List<ProductCatalog>> GetProductCatalogsListAsync()
        {
            return await _ProductCatalogs.Include(x => x.ProductImages)
                                         .Include(x => x.OrderItems)
                                         .Include(x => x.Reviews).ToListAsync();
        }
    }
}
