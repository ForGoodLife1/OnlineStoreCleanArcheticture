using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Infrastructure.Context;

namespace OnlineStore.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepositoryAsync<Customer>, ICustomerRepository
    {
        private DbSet<Customer> _customers;
        public CustomerRepository(OnlineStoreContext dBContext) : base(dBContext)
        {
            _customers=dBContext.Set<Customer>();
        }

        public async Task<List<Customer>> GetCustomersListAsync()
        {
            return await _customers.Include(x => x.Order).ToListAsync();
        }
    }
}
