using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Infrastructure.Context;

namespace OnlineStore.Infrastructure.Repositories
{
    public class OrderItemRepository : GenericRepositoryAsync<OrderItem>, IOrderItemRepository
    {
        private DbSet<OrderItem> _OrderItems;
        public OrderItemRepository(OnlineStoreContext dBContext) : base(dBContext)
        {
            _OrderItems=dBContext.Set<OrderItem>();
        }

        public async Task<List<OrderItem>> GetOrderItemsListAsync()
        {
            return await _OrderItems.Include(x => x.Product).ToListAsync();
        }
    }
}
