using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrastructure.Abstracts
{
    public interface IOrderRepository : IGenericRepositoryAsync<Order>
    {
        public Task<List<Order>> GetOrdersListAsync();
    }
}
