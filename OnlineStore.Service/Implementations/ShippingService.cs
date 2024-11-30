using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Service.Implementations
{
    public class ShippingService : IShippingService
    {
        private readonly IShippingRepository _ShippingRepository;

        public ShippingService(IShippingRepository ShippingRepository)
        {
            _ShippingRepository=ShippingRepository;
        }

        public async Task<Shipping> GetShippingByIdAsync(int id)
        {
            var customer = await _ShippingRepository.GetTableNoTracking().Where(x => x.ShippingId.Equals(id))
                                                   .Include(x => x.Shippings).FirstOrDefaultAsync();
            return customer;
        }

        public Task<bool> IsShippingIdExist(int shippingId)
        {
            throw new NotImplementedException();
        }
    }
}
