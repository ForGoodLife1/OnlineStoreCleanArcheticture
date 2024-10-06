using OnlineStore.Data.Entities;
using OnlineStore.Data.Enums;

namespace OnlineStore.Service.Abstracts
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetCustomersListAsync();
        public Task<Customer> GetCustomerByIDWithIncludeAsync(int id);
        public Task<Customer> GetByIDAsync(int id);
        public Task<string> AddAsync(Customer customer);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(Customer customer);
        public Task<string> DeleteAsync(Customer customer);
        public IQueryable<Customer> GetCustomersQuerable();
        public IQueryable<Customer> GetCustomersByOrderIDQuerable(int DID);
        public IQueryable<Customer> FilterCustomerPaginatedQuerable(CustomerOrderingEnum orderingEnum, string search);
    }
}

