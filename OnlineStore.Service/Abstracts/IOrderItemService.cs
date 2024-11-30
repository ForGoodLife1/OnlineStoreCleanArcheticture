using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IOrderItemService
    {
        public Task<OrderItem> GetOrderItemByIdAsync(int id);
        public Task<bool> IsOrderItemIdExist(int orderItemId);
    }
}
