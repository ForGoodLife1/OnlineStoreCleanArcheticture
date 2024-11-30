using OnlineStore.Data.Entities;

namespace OnlineStore.Service.Abstracts
{
    public interface IShippingService
    {
        public Task<Shipping> GetShippingByIdAsync(int id);
        public Task<bool> IsShippingIdExist(int shippingId);
    }
}
