using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Service.Implementations
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _ProductCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository ProductCategoryRepository)
        {
            _ProductCategoryRepository=ProductCategoryRepository;
        }

        public async Task<ProductCategory> GetProductCategoryByIdAsync(int id)
        {

            return await _ProductCategoryRepository
           .Include(pc => pc.ProductCatalogs)
           .FirstOrDefaultAsync(pc => pc.CategoryId == id);

        }

        public Task<bool> IsProductCategoryIdExist(int productCategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
