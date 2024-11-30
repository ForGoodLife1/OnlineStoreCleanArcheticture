using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Service.Implementations
{
    public class ProductCatalogService : IProductCatalogService
    {
        private readonly IProductCatalogRepository _ProductCatalogRepository;

        public ProductCatalogService(IProductCatalogRepository ProductCatalogRepository)
        {
            _ProductCatalogRepository=ProductCatalogRepository;
        }

        public async Task<ProductCatalog> GetProductCatalogByIdAsync(int id)
        {
            var customer = await _ProductCatalogRepository.GetTableNoTracking().Where(x => x.ProductId.Equals(id))
                                             .Include(x => x.Category)
                                             .Include(x => x.ProductImages)
                                             .Include(x => x.Reviews)
                                             .FirstOrDefaultAsync();

            return customer;

        }




        public Task<bool> IsProductCatalogIdExist(int productCatalogId)
        {
            throw new NotImplementedException();
        }
    }
}
