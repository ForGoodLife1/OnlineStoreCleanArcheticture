using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Infrastructure.Context;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ProductCategoryRepository : GenericRepositoryAsync<ProductCategory>, IProductCategoryRepository
    {
        private DbSet<ProductCategory> _ProductCategorys;
        public ProductCategoryRepository(OnlineStoreContext dBContext) : base(dBContext)
        {
            _ProductCategorys=dBContext.Set<ProductCategory>();
        }

        public async Task<List<ProductCategory>> GetProductCategorysListAsync()
        {
            return await _ProductCategorys.ToListAsync();
        }
    }
}
