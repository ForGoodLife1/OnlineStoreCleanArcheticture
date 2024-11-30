using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IProductCategoryService
    {
        public Task<ProductCategory> GetProductCategoryByIdAsync(int id);
        public Task<bool> IsProductCategoryIdExist(int productCategoryId);
    }
}
