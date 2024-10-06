using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrastructure.Abstracts
{
    public interface ICustomerRepository : IGenericRepositoryAsync<Customer>
    {
        public Task<List<Customer>> GetCustomersListAsync();
    }
}
