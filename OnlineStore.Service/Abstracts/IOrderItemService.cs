using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IOrderItemService
    {
        public Task<List<OrderItem>> GetOrderItemListAsync();
    }
}
