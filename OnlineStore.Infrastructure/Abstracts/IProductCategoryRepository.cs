using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrastructure.Abstracts
{
    public interface IProductCategoryRepository : IGenericRepositoryAsync<ProductCategory>
    {
        public Task<List<ProductCategory>> GetProductCategorysListAsync();
    }
}
