using OnlineStore.Data.Entities;
using OnlineStore.Infarastructure.InfrastructureBases;

namespace OnlineStore.Infrastructure.Abstracts
{
    public interface IReviewRepository : IGenericRepositoryAsync<Review>
    {
        public Task<List<Review>> GetReviewsListAsync();
    }
}
