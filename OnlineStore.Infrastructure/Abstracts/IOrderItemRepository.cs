using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrastructure.Abstracts
{
    public interface IOrderItemRepository : IGenericRepositoryAsync<OrderItem>
    {
        public Task<List<OrderItem>> GetOrderItemsListAsync();
    }
}
