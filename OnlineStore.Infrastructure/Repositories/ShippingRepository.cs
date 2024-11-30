using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;
using OnlineStore.Infrastructure.Abstracts;
using OnlineStore.Infrastructure.Context;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ShippingRepository : GenericRepositoryAsync<Shipping>, IShippingRepository
    {
        private DbSet<Shipping> _shippings;
        public ShippingRepository(OnlineStoreContext dBContext) : base(dBContext)
        {
            _shippings=dBContext.Set<Shipping>();
        }

        public async Task<List<Shipping>> GetShippingsListAsync()
        {
            return await _shippings.ToListAsync();
        }
    }
}
