using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Service.Implementations
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository=orderItemRepository;
        }

        public async Task<OrderItem> GetOrderItemByIdAsync(int id)
        {
            var orderItem = await _orderItemRepository.GetTableNoTracking().Where(x => x.OrderId.Equals(id))
                                                      .Include(x => x.Order).FirstOrDefaultAsync();
            return orderItem;
        }

        public Task<bool> IsOrderItemIdExist(int orderItemId)
        {
            throw new NotImplementedException();
        }
    }
}
