using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Service.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository=orderRepository;
        }



        public async Task<Order> GetOrderByIdAsync(int id)
        {
            var customer = await _orderRepository.GetTableNoTracking().Where(x => x.OrderId.Equals(id))
                                                   .Include(x => x.OrderItems)
                                                   .Include(x => x.Payments)
                                                   .Include(x => x.Shippings).FirstOrDefaultAsync();
            return customer;
        }



        public async Task<bool> IsOrderIdExist(int orderId)
        {
            return await _orderRepository.GetTableNoTracking().AnyAsync(x => x.OrderId.Equals(orderId));
        }
    }
}
