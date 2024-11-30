using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Infrastructure.Context;

namespace OnlineStore.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepositoryAsync<Order>, IOrderRepository
    {
        private DbSet<Order> _Orders;
        public OrderRepository(OnlineStoreContext dBContext) : base(dBContext)
        {
            _Orders=dBContext.Set<Order>();
        }

        public async Task<List<Order>> GetOrdersListAsync()
        {
            return await _Orders.Include(x => x.OrderItems)
                                .Include(x => x.Payments)
                                .Include(x => x.Shippings).ToListAsync();
        }
    }
}
