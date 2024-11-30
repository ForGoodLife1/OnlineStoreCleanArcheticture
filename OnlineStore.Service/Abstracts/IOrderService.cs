using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IOrderService
    {
        public Task<Order> GetOrderByIdAsync(int id);
        public Task<bool> IsOrderIdExist(int orderId);
        /* public Task<List<ViewOrder>> GetViewOrderDataAsync();*/
        /* public Task<IReadOnlyList<OrderStudentCountProc>> GetOrderStudentCountProcs(OrderStudentCountProcParameters parameters);*/
    }
}
