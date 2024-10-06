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

        public async Task<List<OrderItem>> GetOrderItemListAsync()
        {
            return await _orderItemRepository.GetOrderItemsListAsync();
        }
    }
}
