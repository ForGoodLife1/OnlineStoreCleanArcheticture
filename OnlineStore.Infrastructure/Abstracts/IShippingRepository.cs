using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrastructure.Abstracts
{
    public interface IShippingRepository : IGenericRepositoryAsync<Shipping>
    {
        public Task<List<Shipping>> GetShippingsListAsync();
    }
}
