using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Data.Enums;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Service.Abstracts;
using Serilog;

namespace OnlineStore.Service.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository=customerRepository;
        }

        public async Task<string> AddAsync(Customer customer)
        {
            await _customerRepository.AddAsync(customer);
            return "Success";
        }

        public async Task<string> DeleteAsync(Customer customer)
        {
            var trans = _customerRepository.BeginTransaction();
            try
            {
                await _customerRepository.DeleteAsync(customer);
                await trans.CommitAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
                Log.Error(ex.Message);
                return "Falied";
            }
        }

        public async Task<string> EditAsync(Customer customer)
        {
            await _customerRepository.UpdateAsync(customer);
            return "Success";
        }

        public IQueryable<Customer> FilterCustomerPaginatedQuerable(CustomerOrderingEnum orderingEnum, string search)
        {
            var querable = _customerRepository.GetTableNoTracking().Include(x => x.Order).AsQueryable();
            if (search != null)
            {
                querable = querable.Where(x => x.NameAr.Contains(search) || x.Address.Contains(search));
            }
            switch (orderingEnum)
            {
                case CustomerOrderingEnum.CustomerId:
                    querable = querable.OrderBy(x => x.CustomerId);
                    break;
                case CustomerOrderingEnum.Name:
                    querable = querable.OrderBy(x => x.NameAr);
                    break;

                case CustomerOrderingEnum.Address:
                    querable = querable.OrderBy(x => x.Address);
                    break;
                case CustomerOrderingEnum.TotalAmount:
                    querable = querable.OrderBy(x => x.Order.TotalAmount);
                    break;
            }

            return querable;
        }

        public async Task<Customer> GetByIDAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            return customer;
        }

        public async Task<Customer> GetCustomerByIDWithIncludeAsync(int id)
        {
            var customer = _customerRepository.GetTableNoTracking()
                                         .Include(x => x.Order)
                                         .Where(x => x.CustomerId.Equals(id))
                                         .FirstOrDefault();
            return customer;
        }

        public IQueryable<Customer> GetCustomersByOrderIDQuerable(int DID)
        {
            return _customerRepository.GetTableNoTracking().Where(x => x.Order.OrderId.Equals(DID)).AsQueryable();
        }

        public async Task<List<Customer>> GetCustomersListAsync()
        {
            return await _customerRepository.GetCustomersListAsync();
        }

        public IQueryable<Customer> GetCustomersQuerable()
        {
            return _customerRepository.GetTableNoTracking().Include(x => x.Order).AsQueryable();
        }

        public async Task<bool> IsNameArExist(string nameAr)
        {
            var customer = _customerRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr)).FirstOrDefault();
            if (customer==null) return false;
            return true;
        }

        public async Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        {
            var customer = await _customerRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr) & !x.CustomerId.Equals(id)).FirstOrDefaultAsync();
            if (customer == null) return false;
            return true;
        }

        public async Task<bool> IsNameEnExist(string nameEn)
        {
            var customer = _customerRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn)).FirstOrDefault();
            if (customer==null) return false;
            return true;
        }

        public async Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
        {
            var customer = await _customerRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn) & !x.CustomerId.Equals(id)).FirstOrDefaultAsync();
            if (customer == null) return false;
            return true;
        }
    }
}
