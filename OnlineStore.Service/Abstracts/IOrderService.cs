using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IOrderService
    {
        public Task<Order> GetOrderByIdAsync(int id);
    }
}
